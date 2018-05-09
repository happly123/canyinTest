using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using DataAccesses;
using System.Diagnostics;
using System.Data;
using System.Collections;
using System.Runtime.InteropServices;
using System.Configuration;
using System.IO;

namespace InvoicingApp
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            bool createNew;
            using (System.Threading.Mutex m = new System.Threading.Mutex(true, Application.ProductName, out createNew))
            {
                if (createNew)
                {

                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    SqlConnection conn = null;
                    try
                    {
                        string strConn = string.Empty;
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
                        SqlCommand command = new SqlCommand("SELECT NAME FROM SYSDATABASES WHERE NAME='tc_invoicing'", conn);
                        if (command.ExecuteScalar() == null || command.ExecuteScalar().ToString().Equals(""))
                        {
                            MessageBox.Show("检测出您需要点击确定进行系统初始化后再使用！", "长白ERP系统", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //DllRegisterServer();
                            if (InitDatabase.createdb(Application.StartupPath + "\\Resources\\db.sql",Application.StartupPath + "\\Resources\\init.sql") == -1)
                            {
                                MessageBox.Show("初始化数据库失败，请检查是否已安装数据库并开启服务！", "长白ERP系统", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            
                            MessageBox.Show("系统初始化成功，请重新登录！", "长白ERP系统", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();

                            LogOnForm logon = new LogOnForm();
                            logon.ShowDialog();

                        }
                        else
                        {
                            Application.Run(new LogOnForm());
                        }

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("请检查数据库是否正常安装并启动！", "长白ERP系统", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    finally
                    {
                        if (conn != null)
                        {
                            conn.Close();
                        }
                    }

                }
                else
                {
                    MessageBox.Show("检测到系统已启动！", "长白ERP系统", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //[DllImport("Rockey3Com.dll")]
        //public static extern int DllRegisterServer();

    }
}
