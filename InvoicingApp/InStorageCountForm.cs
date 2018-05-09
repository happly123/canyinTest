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
    public partial class InStorageCountForm : Form
    {

        DataAccess dataAcess = null;

        public InStorageCountForm()
        {
            InitializeComponent();
            this.dgvInputStorage.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(239, 243, 251);
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

                //labTitle.Text = companyName + "入库统计表";

                SearchParameter sp = new SearchParameter();
                sp.SetValue(":CONDITION1", "");
                sp.SetValue(":CONDITION2", "");
                DataTable dtInputStorage = getData.GetTableByDiyCondition(Constants.SqlStr.tc_input_storage_count, sp);

                if (dtInputStorage == null)
                {
                    MessageBox.Show("请查看数据库是否正常！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //添加序列号
                int countNumber = 0;
                if (dtInputStorage.Rows.Count > 0)
                {
                    dtInputStorage.Columns.Add("num", typeof(int));
                    for (int i = 0; i < dtInputStorage.Rows.Count; i++)
                    {
                        dtInputStorage.Rows[i]["num"] = ++countNumber;

                    }
                    dgvInputStorage.DataSource = dtInputStorage;
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

        private void InStorageCountForm_Load(object sender, EventArgs e)
        {
            dtp_InputDateTo.Enabled = false;
            dtp_InputDateFrom.Enabled = false;

            comboxInputType.Items.Insert(0, "请选择入库类别...");
            comboxInputType.SelectedIndex = 0;
            BandingDgvInputStorage();
            txtGoodsName.Focus();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            string condition1 = string.Empty;
            string condition2 = string.Empty;
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
            if (checkDate.Checked)
            {
                if (dtp_InputDateTo.Value.Date < dtp_InputDateFrom.Value.Date)
                {
                    MessageBox.Show("结束日期不能小于开始日期！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtp_InputDateFrom.Focus();
                    return;
                }

                condition1 += "where input_instorage_date>= '" + dtp_InputDateFrom.Value.Date + "' ";

                if (condition1.StartsWith("where"))
                {
                    condition1 += " and input_instorage_date<= '" + DateTime.Parse(dtp_InputDateTo.Value.Date.ToString("yyyy-MM-dd") + " " + "23:59:59") + "' ";
                }
                else
                {
                    condition1 += "where input_instorage_date<= '" + DateTime.Parse(dtp_InputDateTo.Value.Date.ToString("yyyy-MM-dd") + " " + "23:59:59") + "' ";
                }
            }

            //DateTime dateFrom = DateTime.Parse("1000-01-01");
            //DateTime dateTo = DateTime.Parse("9999-12-30");
            //if (!txtInputDateFrom.Text.Equals(string.Empty))
            //{
            //    try
            //    {
            //        dateFrom = DateTime.Parse(txtInputDateFrom.Text);
            //        condition1 += "where input_instorage_date>= '" + DateTime.Parse(txtInputDateFrom.Text) + "' ";
                    
            //    }
            //    catch
            //    {
            //        MessageBox.Show("请输入正确的时间格式！", "时间格式：", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        txtInputDateFrom.Focus();
            //        return;
            //    }
            //}

            //if (!txtInputDateTo.Text.Equals(string.Empty))
            //{
            //    try
            //    {
            //        dateTo = DateTime.Parse(txtInputDateTo.Text);
            //        if (condition1.StartsWith("where"))
            //        {
            //            condition1 += " and input_instorage_date<= '" + DateTime.Parse(txtInputDateTo.Text) + "' ";
            //        }
            //        else
            //        {
            //            condition1 += "where input_instorage_date<= '" + DateTime.Parse(txtInputDateTo.Text) + "' ";
            //        }
            //    }
            //    catch
            //    {
            //        MessageBox.Show("请输入正确的时间格式！", "时间格式：", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        txtInputDateTo.Focus();
            //        return;
            //    }
            //}

            //if (dateTo < dateFrom)
            //{
            //    MessageBox.Show("结束日期不能小于开始日期！", "时间格式：", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txtInputDateFrom.Focus();
            //    return;
            //}

            if (condition1.StartsWith("where"))
            {
                if (comboxInputType.Text.Equals("初始入库"))
                {
                    condition1 += " and input_type ='0' ";
                }
                else if (comboxInputType.Text.Equals("购货入库"))
                {
                    condition1 += " and input_type ='1' ";
                }
                else if (comboxInputType.Text.Equals("赠品入库"))
                {
                    condition1 += " and input_type ='2' ";
                }
                else if (comboxInputType.Text.Equals("退货入库"))
                {
                    condition1 += " and input_type ='3' ";
                }
            }
            else
            {
                if (comboxInputType.Text.Equals("初始入库"))
                {
                    condition1 += "where input_type ='0' ";
                }
                else if (comboxInputType.Text.Equals("购货入库"))
                {
                    condition1 += "where input_type ='1' ";
                }
                else if (comboxInputType.Text.Equals("赠品入库"))
                {
                    condition1 += "where input_type ='2' ";
                }
                else if (comboxInputType.Text.Equals("退货入库"))
                {
                    condition1 += "where input_type ='3' ";
                }
            }


            if (!txtGoodsName.Text.Trim().Equals(string.Empty))
            {
                condition2 = "where goods_name like'%" + txtGoodsName.Text.Trim() + "%'";
            }

            SearchParameter sp = new SearchParameter();
            sp.SetValue(":CONDITION1", condition1);
            sp.SetValue(":CONDITION2", condition2);
            try
            {
                dataAcess = new DataAccess();
                dataAcess.Open();
                GetData getData = new GetData(dataAcess.Connection);
                DataTable dtInputStorage = getData.GetTableByDiyCondition(Constants.SqlStr.tc_input_storage_count, sp);

                if (dtInputStorage == null)
                {
                    MessageBox.Show("请查看数据库是否正常！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (dtInputStorage.Rows.Count <= 0)
                {

                    MessageBox.Show("您查找的数据不存在，请查看统计条件是否正确后，重新统计！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                dtInputStorage.Columns.Add("num", typeof(int));
                //添加序列号
                int countNumber = 0;
                for (int i = 0; i < dtInputStorage.Rows.Count; i++)
                {
                    dtInputStorage.Rows[i]["num"] = ++countNumber;

                }
                dgvInputStorage.DataSource = dtInputStorage;
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
            txtGoodsName.Text = "";
            checkDate.Checked = false;
            dtp_InputDateFrom.Value = DateTime.Now.Date;
            dtp_InputDateTo.Value = DateTime.Now.Date;
            comboxInputType.SelectedIndex = 0;
        }

        private void checkDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDate.Checked)
            {
                dtp_InputDateFrom.Enabled = true;
                dtp_InputDateTo.Enabled = true;
            }
            else
            {
                dtp_InputDateFrom.Enabled = false;
                dtp_InputDateTo.Enabled = false;
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
