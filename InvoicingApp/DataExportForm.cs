using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using DataExport;
using System.Text.RegularExpressions;
using DataAccesses;

namespace InvoicingApp
{
    public partial class DataExportForm : Form
    {
        DataAccess dataAccess;
        string companyBusinessLicence = string.Empty;
        public DataExportForm()
        {
            InitializeComponent();
            passWord.Visible = false;
            label1.Visible = false;
            dateExportFrom.Value = DateTime.Now.Date;
            dateExportTo.Value = DateTime.Now.Date;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (dateExportFrom.Value.Date > dateExportTo.Value.Date)
                {
                    MessageBox.Show("开始日期不能大于结束日期！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dateExportFrom.Focus();
                    return;
                }
                Regex regExp = new Regex("^[A-Za-z0-9]+$");

                if (checkBox1.Checked && passWord.Text.Trim().Equals(string.Empty))
                {
                    MessageBox.Show("选择压缩时，必须输入密码！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (!passWord.Text.Trim().Equals(string.Empty) && !regExp.IsMatch(passWord.Text))
                {
                    MessageBox.Show("密码只能是英文或数字！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                try
                {
                    dataAccess = new DataAccess();
                    dataAccess.Open();
                    GetData getData = new GetData(dataAccess.Connection);
                    DataTable dtCompany = getData.GetSingleTable("tc_company");
                    if (dtCompany == null || dtCompany.Rows.Count == 0)
                    {
                        MessageBox.Show("先填写公司的营业执照号码后才可以数据申报！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    companyBusinessLicence = getData.GetSingleTable("tc_company").Rows[0]["company_business_licence"].ToString();
                }
                finally
                {
                    if (dataAccess != null)
                    {
                        dataAccess.Close();
                    }
                }
                if (companyBusinessLicence == string.Empty)
                {
                    MessageBox.Show("先填写公司的营业执照号码后才可以数据申报！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DateTime dtFrom = dateExportFrom.Value.Date;
                DateTime dtTo = dateExportTo.Value.Date;
                //取得连接字符串
                string conn = "Data Source=" + ConfigurationManager.AppSettings["Source"].ToString() + ";"
                                        + "Initial Catalog=" + ConfigurationManager.AppSettings["DataBace"].ToString() + ";";
                if (ConfigurationManager.AppSettings["UserID"].ToString() != string.Empty)
                {
                    conn += "User ID=" + ConfigurationManager.AppSettings["UserID"].ToString() + ";"
                        + "Password=" + ConfigurationManager.AppSettings["PassWord"].ToString() + ";"
                        + "Connect Timeout=30";
                }
                else
                {

                    conn += "trusted_connection=sspi;Connect Timeout=30";
                }
                Export export = new Export(dtFrom, dtTo, conn);
                export.PassWord = "CBIT-85101888";
                if (checkBox1.Checked)
                {
                    export.Compression = true;

                    export.XmlExport(Application.StartupPath + "\\DataReport", companyBusinessLicence + DateTime.Now.ToString("yyyyMMddHHmmss"));

                }
                else
                {
                    export.Compression = false;
                    export.XmlExport(Application.StartupPath + "\\DataReport", companyBusinessLicence + DateTime.Now.ToString("yyyyMMddHHmmss"));
                }
                MessageBox.Show("数据申报成功！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch
            {
                MessageBox.Show("数据申报失败！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnExportCal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passWord.Visible = true;
                label1.Visible = true;
            }
            else
            {
                passWord.Visible = false;
                label1.Visible = false;
            }

        }
    }
}
