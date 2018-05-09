//***********************************************************************
//* 系统名称	    ：  长白ERP系统
//* 功能模块	    ：  登录模块
//* 功能画面		：  登录
//* 画面名称	    ：  LogOnForm
//* 完成年月日      ：  2010/07/23
//* 作者		    ：  代国明
//* Version		    ：  1.00
//* ---------------------------------------------------------------------
//* 前提		：SQL SERVER,.NetFramework3.0
//***********************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using InvoicingUtil;
using DataAccesses;
using System.Collections;
using System.Xml;
using System.Configuration;
using System.Runtime.InteropServices;
using System.IO;
using Microsoft.Win32;
using System.Data.SqlClient;
namespace InvoicingApp
{
    //***********************************************************************
    /// <summary>
    ///登录功能
    /// </summary>
    /// <history>
    ///     完成信息：赵毅男      2010/07/23 完成  
    ///     更新信息：
    /// </history>
    //***********************************************************************
    public partial class LogOnForm : Form
    {
        public LogOnForm()
        {
            InitializeComponent();

        }
        /// <summary>
        /// 登录人
        /// </summary>
        string strLoginUser = string.Empty;

        /// <summary>
        /// 数据库连接句柄
        /// </summary>
        DataAccess dataAccess = null;

        //***********************************************************************
        /// <summary>
        /// 登录按钮点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：赵毅男      2010/07/22 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnLogOn_Click(object sender, EventArgs e)
        {
#if !DEBUG
            if (!Util.checkDog())
            {
                MessageBox.Show("加密狗未找到，请插入加密狗！", "长白ERP系统", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
#endif

            ////判断注册表中是否已注册加密狗
            //RegistryKey rkTest = Registry.ClassesRoot.OpenSubKey("CLSID\\{8934A89B-4995-4E09-88BB-563871BEC8AF}\\");

            ////不存在，注册
            //if (rkTest == null)
            //{
            //    //MessageBox.Show("检测到系统中未注册组件，点击确定将为您注册该组件！", "长白ERP系统", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    DllRegisterServer();
            //    //MessageBox.Show("组件注册成功！", "长白ERP系统", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

            //账号不能为空
            if (cmbUserName.Text.Equals(string.Empty))
            {
                MessageBox.Show("用户账号不能为空！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbUserName.Focus();
                return;
            }

            //密码不能为空
            if (txtPassWord.Text.Equals(string.Empty))
            {
                MessageBox.Show("用户密码不能为空！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassWord.Focus();
                return;
            }

            //取得连接字符串
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

            //数据库连接
            SqlConnection conn = new SqlConnection(strConn);

            //创建数据库
            SqlCommand createDatabase = new SqlCommand();
            createDatabase.Connection = conn;
            createDatabase.CommandText = "select filename from sysfiles";

            try
            {
                //查找数据库是否存在
                conn.Open();
                string dataBaceFileName = createDatabase.ExecuteScalar().ToString();

                //如果没安装数据库，提示信息
                if (dataBaceFileName == string.Empty)
                {
                    MessageBox.Show("请检查数据库是否正常安装并启动！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();
                    return;
                }
                conn.Close();

                //打开另一个连接
                dataAccess = new DataAccess();
                dataAccess.Open();

                //设置查询参数
                GetData getData = new GetData(dataAccess.Connection);
                SearchParameter sp = new SearchParameter();

                //根据加密算法，查询数据库
#if DEBUG
                sp.SetValue(":CONDITION1", " WHERE AUTHORITY_USER_CODE like '" + cmbUserName.Text + "' AND AUTHORITY_PASSWORD like '" + txtPassWord.Text + "'");
#else
                sp.SetValue(":CONDITION1", " WHERE AUTHORITY_USER_CODE like '" + cmbUserName.Text + "' AND AUTHORITY_PASSWORD like '" + Util.GetHashCode(txtPassWord.Text) + "'");
#endif


                DataTable dtUser = getData.GetTableByDiyCondition(Constants.SqlStr.AUTHORITY_LEFTJOIN_STAFF, sp);

                //数据为空或不存在时
                if (dtUser == null || dtUser.Rows.Count == 0)
                {
                    MessageBox.Show("用户名或密码错误，请重新输入！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //添加登录人信息
                Hashtable ht = new Hashtable();
                ht.Add("User_Code", dtUser.Rows[0]["authority_user_code"].ToString());
                ht.Add("User_Pass", dtUser.Rows[0]["authority_password"].ToString());

                //根据不同权限，设置不同的登录信息
                if (dtUser.Rows[0]["authority_level"].ToString().Equals("0") || dtUser.Rows[0]["authority_level"].ToString().Equals("1"))
                {
                    ht.Add("User_Name", dtUser.Rows[0]["staff_code"].ToString());
                    ht.Add("User_Dep", "");
                }
                else
                {
                    ht.Add("User_Name", dtUser.Rows[0]["staff_name"].ToString());
                    ht.Add("User_Dep", dtUser.Rows[0]["staff_dep"].ToString());
                }

                ht.Add("User_Authority", dtUser.Rows[0]["authority_level"].ToString());
                ht.Add("LogOnTime", DateTime.Now);
                ht.Add("SqlSetUpPath", dataBaceFileName.Substring(0, dataBaceFileName.LastIndexOf('\\') + 1).Replace("Data", "Backup").Replace("DATA", "Backup"));

                if (radioJxCompany.Checked)
                {
                    ht.Add("CompanyType", "0");
                }
                else
                {
                    ht.Add("CompanyType", "1");
                }

                //添加到全局
                LoginUser loginUser = new LoginUser(ht);
                XmlDocument doc = new XmlDocument();
                doc.Load(Application.StartupPath + "\\XMLLoginUsers.xml");
                XmlNode xmlNode;
                //记录用户名
                if (!strLoginUser.Contains(cmbUserName.Text))
                {
                    if (strLoginUser.Trim().Equals(string.Empty))
                    {
                        strLoginUser = cmbUserName.Text;
                    }
                    else
                    {
                        strLoginUser += "," + cmbUserName.Text;
                    }

                    //写到配置文件中，以“,”为分割

                    doc.Load(Application.StartupPath + "\\XMLLoginUsers.xml");
                    xmlNode = doc.SelectSingleNode("login//loginUser");
                    xmlNode.InnerText = strLoginUser;
                    doc.Save(Application.StartupPath + "\\XMLLoginUsers.xml");
                }

                xmlNode = doc.SelectSingleNode("login//loginType");

                if (radioJxCompany.Checked)
                {
                    xmlNode.InnerText = "0";
                   
                }
                else
                {
                    xmlNode.InnerText = "1";
                   
                }

                doc.Save(Application.StartupPath + "\\XMLLoginUsers.xml");

                //显示主窗体
                MainForm mainForm = new MainForm();

                //隐藏登录页面
                this.Hide();
                mainForm.ShowDialog();
            }
            catch (COMException comex)
            {
                MessageBox.Show("加密狗未找到，请插入加密狗！", "长白ERP系统", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FileNotFoundException noFile)
            {
                MessageBox.Show("加密狗未找到，请插入加密狗！", "长白ERP系统", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //DllRegisterServer();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                //关闭数据库连接
                dataAccess.Close();
            }

        }

        ///// <summary>
        ///// 导入DLL
        ///// </summary>
        ///// <returns></returns>
        //[DllImport("Rockey3Com.dll")]
        //public static extern int DllRegisterServer();

        //***********************************************************************
        /// <summary>
        /// 取消按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：赵毅男      2010/09/22 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //***********************************************************************
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：赵毅男      2010/09/22 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void LogOnForm_Load(object sender, EventArgs e)
        {
            //读取配置文件，取得登录过的用户名，并显示
            XmlDocument doc = new XmlDocument();
            doc.Load(Application.StartupPath + "\\XMLLoginUsers.xml");
            strLoginUser = doc.SelectSingleNode("login//loginUser").InnerText;
            string[] strLoginUsers = strLoginUser.Split(',');
            cmbUserName.DataSource = strLoginUsers;
            if (doc.SelectSingleNode("login//loginType").InnerText.Equals("1"))
            {
                radioJxCompany.Checked = false;
                radioYpCompany.Checked = true;

            }
            else
            {
                radioJxCompany.Checked = true;
                radioYpCompany.Checked = false;
            }
        }

        //***********************************************************************
        /// <summary>
        /// 用户名变化，密码处置空
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：赵毅男      2010/09/22 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void cmbUserName_TextChanged(object sender, EventArgs e)
        {
            txtPassWord.Text = "";
        }

    }
}
