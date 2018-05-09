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
    public partial class SystemLogForm : Form
    {
        /// <summary>
        /// 数据库连接句柄
        /// </summary>
        DataAccess dataAccess = null;

        public SystemLogForm()
        {
            InitializeComponent();

            this.dgvSystemLog.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(239, 243, 251);
        }

        private void SystemLogForm_Load(object sender, EventArgs e)
        {

            dgvSystemLog.AllowUserToOrderColumns = false;

            try
            {
                //初始化参数类
                SearchParameter sp = new SearchParameter();

                sp.SetValue(":CONDITION1", "");
                //打开数据库连接
                dataAccess = new DataAccess();
                dataAccess.Open();

                //取得操作类
                GetData getData = new GetData(dataAccess.Connection);

                //根据条件检索表
                DataTable dtSystemLog = getData.GetTableByDiyCondition(Constants.SqlStr.TC_SYSTEM_LOG, sp);

                //如果为NULL，报错
                if (dtSystemLog == null)
                {
                    MessageBox.Show("请查看数据库是否正常！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dtSystemLog.Columns.Add("index");

                for (int i = 0; i < dtSystemLog.Rows.Count; i++)
                {
                    dtSystemLog.Rows[i]["index"] = i + 1;
                }

                dgvSystemLog.DataSource = dtSystemLog;

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

        //*******************************************************************
        /// <summary>
        /// 绑定画面
        /// </summary>
        /// <history>
        ///     完成信息：代国明      2010/08/03 完成   
        ///     更新信息：
        /// </history>
        //*******************************************************************
        private void BindingDgvLose()
        {

            try
            {
                //初始化参数类
                SearchParameter sp = new SearchParameter();

                sp.SetValue(":CONDITION1", "");
                //打开数据库连接
                dataAccess = new DataAccess();
                dataAccess.Open();

                //取得操作类
                GetData getData = new GetData(dataAccess.Connection);

                //根据条件检索表
                DataTable dtSystemLog = getData.GetTableByDiyCondition(Constants.SqlStr.TC_SYSTEM_LOG, sp);

                //如果为NULL，报错
                if (dtSystemLog == null)
                {
                    MessageBox.Show("请查看数据库是否正常！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //如果为零，显示没有数据
                if (dtSystemLog.Rows.Count == 0)
                {
                    MessageBox.Show("数据不存在，请查看输入的条件是否正确！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                //如果不为NULL，绑定数据
                if (dtSystemLog.Rows.Count > 0)
                {
                    dgvSystemLog.DataSource = dtSystemLog;
                }
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

            string condition1 = string.Empty;

            //条件不为空，添加参数
            if (!dpf_systemlog_logon.Text.Equals(string.Empty))
            {
                try
                {
                    condition1 += "where SYSTEMLOG_LOGON>= '" + DateTime.Parse(dpf_systemlog_logon.Text) + "' ";
                }
                catch
                {
                    MessageBox.Show("请输入正确的时间格式！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dpf_systemlog_logon.Focus();
                    return;
                }
            }

            if (!dpf_systemlog_logoff.Text.Equals(string.Empty))
            {
                try
                {
                    if (condition1.StartsWith("where"))
                    {
                        condition1 += " and SYSTEMLOG_LOGOFF<= '" + DateTime.Parse(dpf_systemlog_logoff.Text.ToString() + " " + "23:59:59") + "' ";
                    }
                    else
                    {
                        condition1 += "where SYSTEMLOG_LOGOFF<= '" + DateTime.Parse(dpf_systemlog_logoff.Text.ToString() + " " + "23:59:59") + "' ";
                    }
                }
                catch
                {
                    MessageBox.Show("请输入正确的时间格式！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dpf_systemlog_logoff.Focus();
                    return;
                }
            }

            if (DateTime.Parse(dpf_systemlog_logoff.Text.ToString() + " " + "23:59:59") < DateTime.Parse(dpf_systemlog_logon.Text))
            {
                MessageBox.Show("结束日期不能小于开始日期！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                dpf_systemlog_logon.Focus();
                return;
            }

            //初始化参数类
            SearchParameter sp = new SearchParameter();

            sp.SetValue(":CONDITION1", condition1);
            try
            {
                //打开数据库连接
                dataAccess = new DataAccess();
                dataAccess.Open();

                //取得操作类
                GetData getData = new GetData(dataAccess.Connection);

                //根据条件检索表
                DataTable dtSystemLog = getData.GetTableByDiyCondition(Constants.SqlStr.TC_SYSTEM_LOG, sp);

                //如果为NULL，报错
                if (dtSystemLog == null)
                {
                    MessageBox.Show("请查看数据库是否正常！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //如果为零，显示没有数据
                if (dtSystemLog.Rows.Count == 0)
                {
                    MessageBox.Show("数据不存在，请查看输入的条件是否正确！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                //如果不为NULL，绑定数据
                if (dtSystemLog.Rows.Count >= 0)
                {
                    dtSystemLog.Columns.Add("index");

                    for (int i = 0; i < dtSystemLog.Rows.Count; i++)
                    {
                        dtSystemLog.Rows[i]["index"] = i + 1;
                    }                    
                }

                dgvSystemLog.DataSource = dtSystemLog;
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

        private void dgvSystemLog_Sorted(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvSystemLog.Rows.Count; i++)
            {
                dgvSystemLog.Rows[i].Cells["index"].Value = i + 1;
            }
        }
    }
}
