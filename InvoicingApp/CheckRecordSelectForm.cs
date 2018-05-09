using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataAccesses;
using InvoicingUtil;

namespace InvoicingApp
{
    public partial class CheckRecordSelectForm : Form
    {
        /// <summary>
        /// 数据库连接句柄
        /// </summary>
        DataAccess dataAcess = null;

        public CheckRecordSelectForm()
        {
            InitializeComponent();

            this.dgvRecordValidate.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(239, 243, 251);
            dtp_input_checktime_Start.Value = new DateTime(DateTime.Now.Date.Year, DateTime.Now.Date.Month, 1);
            dtp_input_checktime_End.Value  = new DateTime(DateTime.Now.Date.Year, DateTime.Now.Date.Month,DateTime.DaysInMonth(DateTime.Now.Year,DateTime.Now.Month));
        }

        DataTable dtPrint = null;

        private void BandingDgvRecordValidate()
        {
            try
            {

                dataAcess = new DataAccess();
                dataAcess.Open();
                GetData getData = new GetData(dataAcess.Connection);

                SearchParameter sp = new SearchParameter();

                sp.SetValue(":CONDITION1", " WHERE TC_INPUT_STORAGE.INPUT_TYPE <> 0 and  TC_INPUT_STORAGE.INPUT_CHECKTIME >= '" + dtp_input_checktime_Start.Value.Date + "' and TC_INPUT_STORAGE.INPUT_CHECKTIME <= '" + DateTime.Parse(dtp_input_checktime_End.Value.Date.ToString("yyyy-MM-dd") + " " + "23:59:59") + "' ");

                DataTable dtRecordValidate = getData.GetTableByDiyCondition(Constants.SqlStr.TC_INPUT_STORAGE_LEFTJOIN_GOODS_SELECTRECORDVALIDATE, sp);

                if (dtRecordValidate == null)
                {
                    MessageBox.Show("请查看数据库是否正常！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                dtPrint = dtRecordValidate;

                dtRecordValidate.Columns.Add("sn_sl");

                for (int i = 0; i < dtRecordValidate.Rows.Count; i++)
                {
                    string sn_sl = dtRecordValidate.Rows[i]["supplier_name"].ToString() + "(" + dtRecordValidate.Rows[i]["supplier_licence"].ToString() + ")";
                    dtRecordValidate.Rows[i]["sn_sl"] = sn_sl;
                }

                //添加序列号
                int countNumber = 0;
                dtRecordValidate.Columns.Add("index", typeof(int));
                for (int i = 0; i < dtRecordValidate.Rows.Count; i++)
                {
                    dtRecordValidate.Rows[i]["index"] = ++countNumber;

                }

                dgvRecordValidate.DataSource = dtRecordValidate;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dataAcess.Close();
            }
        }

        private void CheckRecordSelectForm_Load(object sender, EventArgs e)
        {
            dtp_input_checktime_Start.Enabled = true;
            dtp_input_checktime_End.Enabled = true;
            dgvRecordValidate.AutoGenerateColumns = false;
            BandingDgvRecordValidate();
            txt_goods_name.Focus();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            foreach (Control control in groupBox1.Controls)
            {
                if (control is TextBox)
                {
                    if (Util.CheckRegex(control.Text.Trim()) && !((TextBox)control).ReadOnly)
                    {
                        MessageBox.Show("不可以输入非法字符，请重新输入！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        control.Focus();
                        return;
                    }
                }
            }

            string condition1 = " where TC_INPUT_STORAGE.INPUT_TYPE <> 0 ";
            SearchParameter sp = new SearchParameter();
            //DateTime dateFrom = DateTime.Parse("1000-01-01");
            //DateTime dateTo = DateTime.Parse("9999-12-30");

            if (checkDate.Checked)
            {
                if (DateTime.Parse(dtp_input_checktime_End.Value.ToString("yyyy-MM-dd")) < DateTime.Parse(dtp_input_checktime_Start.Value.ToString("yyyy-MM-dd")))
                {
                    MessageBox.Show("结束日期不能小于开始日期！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtp_input_checktime_Start.Focus();
                    return;
                }

                condition1 += " AND TC_INPUT_STORAGE.INPUT_CHECKTIME >= '" + dtp_input_checktime_Start.Value.Date + "' ";
                if (condition1.Trim().StartsWith("where"))
                {
                    condition1 += " and TC_INPUT_STORAGE.INPUT_CHECKTIME <= '" + DateTime.Parse(dtp_input_checktime_End.Value.Date.ToString("yyyy-MM-dd") + " " + "23:59:59") + "' ";
                }
                else
                {
                    condition1 += "where TC_INPUT_STORAGE.INPUT_CHECKTIME <= '" + DateTime.Parse(dtp_input_checktime_End.Value.Date.ToString("yyyy-MM-dd") + " " + "23:59:59") + "' ";
                }
            }

            //if (!txt_input_checktime_Start.Text.Equals(string.Empty))
            //{

            //    try
            //    {
            //        condition1 += "where TC_INPUT_STORAGE.INPUT_CHECKTIME >= '" + DateTime.Parse(txt_input_checktime_Start.Text) + "' ";
            //    }
            //    catch
            //    {
            //        MessageBox.Show("请输入正确的时间格式！", "时间格式：", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        txt_input_checktime_Start.Focus();
            //        return;
            //    }
            //}

            //if (!txt_input_checktime_End.Text.Equals(string.Empty))
            //{
            //    try
            //    {
            //        if (condition1.StartsWith("where"))
            //        {
            //            condition1 += " and TC_INPUT_STORAGE.INPUT_CHECKTIME <= '" + DateTime.Parse(txt_input_checktime_End.Text.ToString() + " " + "23:59:59") + "' ";
            //        }
            //        else
            //        {
            //            condition1 += "where TC_INPUT_STORAGE.INPUT_CHECKTIME <= '" + DateTime.Parse(txt_input_checktime_End.Text.ToString() + " " + "23:59:59") + "' ";
            //        }
            //    }
            //    catch
            //    {
            //        MessageBox.Show("请输入正确的时间格式！", "时间格式：", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        txt_input_checktime_End.Focus();
            //        return;
            //    }    

            //}           

            if (!txt_goods_yxm.Text.Trim().Equals(string.Empty))
            {
                try
                {
                    if (condition1.Trim().StartsWith("where"))
                    {
                        condition1 += " and TC_GOODS.GOODS_YXM like '%" + txt_goods_yxm.Text.Trim() + "%' ";
                    }
                    else
                    {
                        condition1 += "where TC_GOODS.GOODS_YXM like '%" + txt_goods_yxm.Text.Trim() + "%' ";
                    }
                }
                catch
                {
                    //MessageBox.Show("请输入正确的时间格式！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_goods_yxm.Focus();
                    return;
                }
            }

            if (!txt_goods_name.Text.Trim().Equals(string.Empty))
            {
                try
                {
                    if (condition1.Trim().StartsWith("where"))
                    {
                        condition1 += " and TC_GOODS.GOODS_NAME like '%" + txt_goods_name.Text.Trim() + "%' ";
                    }
                    else
                    {
                        condition1 += "where TC_GOODS.GOODS_NAME like '%" + txt_goods_name.Text.Trim() + "%' ";
                    }
                }
                catch
                {
                    //MessageBox.Show("请输入正确的时间格式！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_goods_name.Focus();
                    return;
                }
            }
            sp.SetValue(":CONDITION1", condition1);

            try
            {

                dataAcess = new DataAccess();
                dataAcess.Open();
                GetData getData = new GetData(dataAcess.Connection);

                DataTable dtRecordValidate = getData.GetTableByDiyCondition(Constants.SqlStr.TC_INPUT_STORAGE_LEFTJOIN_GOODS_SELECTRECORDVALIDATE, sp);

                if (dtRecordValidate == null)
                {
                    MessageBox.Show("请查看数据库是否正常！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (dtRecordValidate.Rows.Count == 0)
                {
                    MessageBox.Show("数据不存在，请查看输入的条件是否正确！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                dtPrint = dtRecordValidate;

                dtRecordValidate.Columns.Add("sn_sl");

                for (int i = 0; i < dtRecordValidate.Rows.Count; i++)
                {
                    string sn_sl = dtRecordValidate.Rows[i]["supplier_name"].ToString() + "(" + dtRecordValidate.Rows[i]["supplier_licence"].ToString() + ")";
                    dtRecordValidate.Rows[i]["sn_sl"] = sn_sl;
                }

                //添加序列号
                int countNumber = 0;
                dtRecordValidate.Columns.Add("index", typeof(int));
                for (int i = 0; i < dtRecordValidate.Rows.Count; i++)
                {
                    dtRecordValidate.Rows[i]["index"] = ++countNumber;

                }

                dgvRecordValidate.DataSource = dtRecordValidate;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dataAcess.Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //文本框清空
            txt_goods_yxm.Text = "";
            checkDate.Checked = true;
            dtp_input_checktime_Start.Value = new DateTime(DateTime.Now.Date.Year, DateTime.Now.Date.Month, 1);
            dtp_input_checktime_End.Value = new DateTime(DateTime.Now.Date.Year, DateTime.Now.Date.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
            txt_goods_name.Text = "";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dtPrint == null || dtPrint.Rows.Count == 0)
            {
                MessageBox.Show("没有可以打印的数据！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            CheckRecordPrint checkRecordPrint = new CheckRecordPrint(dtPrint);
            checkRecordPrint.ShowDialog();
        }

        private void checkDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDate.Checked)
            {
                dtp_input_checktime_Start.Enabled = true;
                dtp_input_checktime_End.Enabled = true;
            }
            else
            {
                dtp_input_checktime_Start.Enabled = false;
                dtp_input_checktime_End.Enabled = false;
            }
        }

        private void dgvRecordValidate_Sorted(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvRecordValidate.Rows.Count; i++)
            {
                dgvRecordValidate.Rows[i].Cells["index"].Value = i + 1;
            }
        }


    }
}
