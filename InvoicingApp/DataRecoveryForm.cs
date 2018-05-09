using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;
using InvoicingUtil;

namespace InvoicingApp
{
    public partial class DataRecoveryForm : Form
    {
        public DataRecoveryForm()
        {
            InitializeComponent();
        }
        string strConn = string.Empty;
        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvRecovery == null || dgvRecovery.Rows.Count == 0)
            {
                MessageBox.Show("不存在可以恢复的数据！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dgvRecovery.SelectedRows.Count > 1)
            {
                MessageBox.Show("只能选择一条数据进行恢复！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string filePath = this.dgvRecovery.SelectedRows[0].Cells["backpath"].Value.ToString();
            SqlConnection conn = null;
            SqlCommand cmd = null;
            ArrayList list = null;
            try
            {


                strConn = "Data Source=" + ConfigurationManager.AppSettings["Source"].ToString() + ";"
                            + "Initial Catalog=master;";
                if (ConfigurationManager.AppSettings["UserID"].ToString() != string.Empty)
                {
                    strConn += "User ID=" + ConfigurationManager.AppSettings["UserID"].ToString() + ";"
                        + "Password=" + ConfigurationManager.AppSettings["PassWord"].ToString() + ";"
                        + "Connect Timeout=30";
                }
                else
                {

                    strConn += "trusted_connection=sspi;Connect Timeout=30";
                }
                conn = new SqlConnection(strConn);
                conn.Open();
                cmd = new SqlCommand("select spid  from sysprocesses,sysdatabases WHERE sysprocesses.dbid =sysdatabases.dbid and sysdatabases.name='tc_invoicing'", conn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                list = new ArrayList();
                while (dr.Read())
                {
                    list.Add(dr.GetInt16(0));
                }
                dr.Close();


                for (int i = 0; i < list.Count; i++)
                {
                    cmd = new SqlCommand(string.Format("KILL {0}", list[i]), conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                MessageBox.Show("操作数据时发生错误，请检查数据库是否正常开启！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                conn.Close();
            }
            try
            {
                conn = new SqlConnection(strConn);
                conn.Open();
                SqlCommand cmdRT = new SqlCommand();
                cmdRT.CommandType = CommandType.Text;
                cmdRT.Connection = conn;
                cmdRT.CommandText = @"restore database tc_invoicing from disk='" + filePath + "' with replace";
                cmdRT.ExecuteNonQuery();
                MessageBox.Show("数据库恢复成功！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                SqlConnection.ClearAllPools();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("操作数据时发生错误，请检查数据库是否正常开启！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                conn.Close();
            }
        }

        private void DataRecoveryForm_Load(object sender, EventArgs e)
        {
            if (!File.Exists(LoginUser.SqlSetUpPath.Substring(0, LoginUser.SqlSetUpPath.Length - 1)))
            {

                Directory.CreateDirectory(LoginUser.SqlSetUpPath.Substring(0, LoginUser.SqlSetUpPath.Length - 1));
            }
            string[] strFiles = Directory.GetFiles(LoginUser.SqlSetUpPath.Substring(0, LoginUser.SqlSetUpPath.Length - 1));
            DataTable dtBackFile = new DataTable();
            dtBackFile.Columns.Add("index", typeof(int));
            dtBackFile.Columns.Add("backdate", typeof(string));
            dtBackFile.Columns.Add("file", typeof(string));
            dtBackFile.Columns.Add("backpath", typeof(string));
            try
            {
                for (int i = 0; i < strFiles.Length; i++)
                {
                    if (strFiles[i].Substring(strFiles[i].LastIndexOf('.')).Equals(".bak"))
                    {

                        DateTime.Parse(strFiles[i].Substring(strFiles[i].LastIndexOf("\\") + 1).Substring(0, 10).Replace("_", "-"));
                        DataRow dr = dtBackFile.NewRow();
                        dr["backdate"] = strFiles[i].Substring(strFiles[i].LastIndexOf("\\") + 1).Substring(0, 10).Replace("_", "-");
                        dr["file"] = strFiles[i].Substring(strFiles[i].LastIndexOf("\\") + 1);
                        dr["backpath"] = strFiles[i];
                        dtBackFile.Rows.Add(dr);

                    }
                }

                for (int i = 0; i < dtBackFile.Rows.Count; i++)
                {
                    dtBackFile.Rows[i]["index"] = i + 1;
                }
                dgvRecovery.DataSource = dtBackFile;

            }
            catch
            {
                MessageBox.Show("文件格式不正确！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void dgvRecovery_Sorted(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvRecovery.Rows.Count; i++)
            {
                dgvRecovery.Rows[i].Cells["index"].Value = i + 1;
            }
        }
    }
}
