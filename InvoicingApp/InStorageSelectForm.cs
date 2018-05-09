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
    public partial class InStorageSelectForm : Form
    {

        DataAccess dataAcess = null;

        private DataTable dtPrint = null;
        private DataTable dtDgvInputStorage = null;

        public InStorageSelectForm()
        {
            InitializeComponent();
            this.dgvInputStorage.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(239, 243, 251);
            dateInputDateFrom.Value = new DateTime(DateTime.Now.Date.Year, DateTime.Now.Date.Month, 1);
            dateInputDateTo.Value = new DateTime(DateTime.Now.Date.Year, DateTime.Now.Date.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
        }

        private void GetDgvInputStorage(DataTable dt)
        {

            dtPrint = dt.Copy();
            dtDgvInputStorage = new DataTable();
            dtDgvInputStorage.Columns.Add("input_code", typeof(string));
            dtDgvInputStorage.Columns.Add("input_type", typeof(string));
            dtDgvInputStorage.Columns.Add("goods_name", typeof(string));
            dtDgvInputStorage.Columns.Add("goods_type", typeof(string));
            dtDgvInputStorage.Columns.Add("supplier_name", typeof(string));
            dtDgvInputStorage.Columns.Add("maker_name", typeof(string));
            dtDgvInputStorage.Columns.Add("input_standard_count", typeof(string));
            dtDgvInputStorage.Columns.Add("input_batch_num", typeof(string));
            dtDgvInputStorage.Columns.Add("input_instorage_date", typeof(string));
            dtDgvInputStorage.Columns.Add("input_maketime", typeof(string));
            dtDgvInputStorage.Columns.Add("goods_validity", typeof(string));
            dtDgvInputStorage.Columns.Add("input_check_persion", typeof(string));
            dtDgvInputStorage.Columns.Add("input_issued", typeof(string));
            dtDgvInputStorage.Columns.Add("input_checktime", typeof(string));
            

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dtDgvInputStorage.NewRow();
                dr["input_code"] = dt.Rows[i]["input_code"].ToString();
                if (dt.Rows[i]["input_type"].ToString().Equals("0"))
                {
                    dr["input_type"] = "初始入库";
                }
                else if (dt.Rows[i]["input_type"].ToString().Equals("1"))
                {
                    dr["input_type"] = "购货入库";
                }
                else if (dt.Rows[i]["input_type"].ToString().Equals("2"))
                {
                    dr["input_type"] = "赠品入库";
                }
                else if (dt.Rows[i]["input_type"].ToString().Equals("3"))
                {
                    dr["input_type"] = "退货入库";
                }

                dr["goods_name"] = dt.Rows[i]["goods_name"].ToString();
                dr["goods_type"] = dt.Rows[i]["goods_type"].ToString();
                dr["supplier_name"] = dt.Rows[i]["supplier_name"].ToString();
                dr["maker_name"] = dt.Rows[i]["maker_name"].ToString();
                dr["input_standard_count"] = dt.Rows[i]["input_standard_count"].ToString();
                dr["input_batch_num"] = dt.Rows[i]["input_batch_num"].ToString();
                dr["input_instorage_date"] = DateTime.Parse(dt.Rows[i]["input_instorage_date"].ToString()).ToString("yyyy-MM-dd");
                dr["input_maketime"] = DateTime.Parse(dt.Rows[i]["input_maketime"].ToString()).ToString("yyyy-MM-dd");
                dr["goods_validity"] = dt.Rows[i]["goods_validity"].ToString();
                dr["input_check_persion"] = dt.Rows[i]["input_check_persion"].ToString();
                dr["input_issued"] = dt.Rows[i]["input_issued"].ToString();
                if (dt.Rows[i]["input_checktime"].ToString().Equals(string.Empty))
                {
                    dr["input_checktime"] = "";
                }
                else
                {
                    dr["input_checktime"] = DateTime.Parse(dt.Rows[i]["input_checktime"].ToString()).ToString("yyyy-MM-dd");
                }

                dtDgvInputStorage.Rows.Add(dr);
            }
        }

        private void BandingDgvInputStorage()
        {
            try
            {

                dataAcess = new DataAccess();
                dataAcess.Open();
                GetData getData = new GetData(dataAcess.Connection);
                //DataTable dtCompany = getData.GetSingleTable("TC_COMPANY");
                //string companyName = string.Empty;
                //if (dtCompany != null && dtCompany.Rows.Count > 0)
                //{
                //    companyName = dtCompany.Rows[0]["company_name"].ToString();
                //}
                //else
                //{
                //    MessageBox.Show("请先输入公司基本信息！", "公司名称：", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    return;
                //}

                //labTitle.Text = companyName + "入库单汇总表";
                SearchParameter sp = new SearchParameter();
                sp.SetValue(":INPUT_INSTORAGE_DATE_FROM", dateInputDateFrom.Value.Date);
                sp.SetValue(":INPUT_INSTORAGE_DATE_TO", dateInputDateTo.Value.Date);
                DataTable dtInputStorage = getData.GetTableBySqlStr(Constants.SqlStr.TC_INPUT_STORAGE_LEFTJOIN_GOODS, sp);

                if (dtInputStorage == null)
                {
                    MessageBox.Show("请查看数据库是否正常！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (dtInputStorage.Rows.Count > 0)
                {
                    GetDgvInputStorage(dtInputStorage);
                    //添加序列号
                    int countNumber = 0;
                    dtDgvInputStorage.Columns.Add("num", typeof(int));
                    for (int i = 0; i < dtInputStorage.Rows.Count; i++)
                    {
                        dtDgvInputStorage.Rows[i]["num"] = ++countNumber;

                    }
                    dgvInputStorage.DataSource = dtDgvInputStorage;
                }
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

        private void InStorageSelectForm_Load(object sender, EventArgs e)
        {
            this.dgvInputStorage.AutoGenerateColumns = false;
            comboxInputType.Items.Insert(0, "请选择入库类别...");
            comboxInputType.SelectedIndex = 0;
            BandingDgvInputStorage();
            checkDate.Checked = true;
            txtInputCode.Focus();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            //判断非法字符
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
            DateTime dateFrom = DateTime.Parse("1000-01-01");
            DateTime dateTo = DateTime.Parse("9999-12-30");
            SearchParameter sp = new SearchParameter();

            if (checkDate.Checked == true)
            {
                dateFrom = dateInputDateFrom.Value.Date;
                dateTo = dateInputDateTo.Value.Date;
                sp.SetValue(":INPUT_INSTORAGE_DATE_FROM", dateInputDateFrom.Value.Date);
                sp.SetValue(":INPUT_INSTORAGE_DATE_TO", dateInputDateTo.Value.Date);

            }


            //if (!txtInputDateFrom.Text.Equals(string.Empty))
            //{
            //    try
            //    {
            //        sp.SetValue(":INPUT_INSTORAGE_DATE_FROM", DateTime.Parse(txtInputDateFrom.Text));
            //        dateFrom = DateTime.Parse(txtInputDateFrom.Text);
            //    }
            //    catch
            //    {
            //        MessageBox.Show("请输入正确的时间格式！例：1985-02-11", "时间格式：", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        txtInputDateFrom.Focus();
            //        return;
            //    }
            //}

            //if (!txtInputDateTo.Text.Equals(string.Empty))
            //{
            //    try
            //    {
            //        sp.SetValue(":INPUT_INSTORAGE_DATE_TO", DateTime.Parse(txtInputDateTo.Text));
            //        dateTo = DateTime.Parse(txtInputDateTo.Text);
            //    }
            //    catch
            //    {
            //        MessageBox.Show("请输入正确的时间格式！例：1985-02-11", "时间格式：", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        txtInputDateTo.Focus();
            //        return;
            //    }
            //}

            if (dateTo < dateFrom)
            {
                MessageBox.Show("结束日期不能小于开始日期！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateInputDateFrom.Focus();
                return;
            }

            if (!txtInputCode.Text.Equals(string.Empty))
            {
                sp.SetValue(":TC_INPUT_STORAGE.INPUT_CODE", txtInputCode.Text);
            }

            if (!txtGoodsName.Text.Equals(string.Empty))
            {
                sp.SetValue(":TC_GOODS.GOODS_NAME", txtGoodsName.Text);
            }

            if (comboxInputType.Text.Equals("初始入库"))
            {
                sp.SetValue(":TC_INPUT_STORAGE.INPUT_TYPE", "0");
            }
            else if (comboxInputType.Text.Equals("购货入库"))
            {
                sp.SetValue(":TC_INPUT_STORAGE.INPUT_TYPE", "1");
            }
            else if (comboxInputType.Text.Equals("赠品入库"))
            {
                sp.SetValue(":TC_INPUT_STORAGE.INPUT_TYPE", "2");
            }
            else if (comboxInputType.Text.Equals("退货入库"))
            {
                sp.SetValue(":TC_INPUT_STORAGE.INPUT_TYPE", "3");
            }

            try
            {

                dataAcess = new DataAccess();
                dataAcess.Open();
                GetData getData = new GetData(dataAcess.Connection);

                DataTable dtInputStorage = getData.GetTableBySqlStr(Constants.SqlStr.TC_INPUT_STORAGE_LEFTJOIN_GOODS, sp);

                if (dtInputStorage == null)
                {
                    MessageBox.Show("请查看数据库是否正常！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (dtInputStorage.Rows.Count == 0)
                {
                    MessageBox.Show("数据不存在，请查看输入的条件是否正确！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                GetDgvInputStorage(dtInputStorage);
                //添加序列号
                int countNumber = 0;
                dtDgvInputStorage.Columns.Add("num", typeof(int));
                for (int i = 0; i < dtInputStorage.Rows.Count; i++)
                {
                    dtDgvInputStorage.Rows[i]["num"] = ++countNumber;

                }
                dgvInputStorage.DataSource = dtDgvInputStorage;
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
            checkDate.Checked = true;
            txtGoodsName.Text = "";
            txtInputCode.Text = "";
            dateInputDateFrom.Value = new DateTime(DateTime.Now.Date.Year, DateTime.Now.Date.Month, 1);
            dateInputDateTo.Value = new DateTime(DateTime.Now.Date.Year, DateTime.Now.Date.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
            comboxInputType.SelectedIndex = 0;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dtPrint == null || dtPrint.Rows.Count == 0)
            {
                MessageBox.Show("没有可以打印的数据！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            InputRecordPrint inputRecordPrint = new InputRecordPrint(dtPrint);
            inputRecordPrint.ShowDialog();
        }

        private void checkDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDate.Checked == true)
            {
                dateInputDateFrom.Enabled = true;
                dateInputDateTo.Enabled = true;
            }
            else
            {
                dateInputDateFrom.Enabled = false;
                dateInputDateTo.Enabled = false;
            }
        }

        private void dgvInputStorage_Sorted(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvInputStorage.Rows.Count; i++)
            {
                dgvInputStorage.Rows[i].Cells["num"].Value = i + 1;
            }
        }

    }
}
