//***********************************************************************
//* 系统名称	    ：  长白ERP系统
//* 功能模块	    ：  系统信息
//* 功能画面		：  报损统计管理
//* 画面名称	    ：  DamageCountForm
//* 完成年月日      ：  2010/07/26
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
using DataAccesses;
using InvoicingUtil;

namespace InvoicingApp
{
    //***********************************************************************
    /// <summary>
    ///报损统计管理功能
    /// </summary>
    /// <history>
    ///     完成信息：代国明      2010/07/26 完成  
    ///     更新信息：
    /// </history>
    //***********************************************************************
    public partial class DamageCountForm : Form
    {
        /// <summary>
        /// 数据库连接句柄
        /// </summary>
        DataAccess dataAccess = null;

        public DamageCountForm()
        {
            InitializeComponent();

            this.dgvLose.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(239, 243, 251);
        }


        //*******************************************************************
        /// <summary>
        /// 绑定画面
        /// </summary>
        /// <history>
        ///     完成信息：代国明      2010/07/26完成   
        ///     更新信息：
        /// </history>
        //*******************************************************************
        private void BandingDgvLose()
        {
            try
            {
                //打开数据库连接
                dataAccess = new DataAccess();
                dataAccess.Open();

                //取得操作类
                GetData getData = new GetData(dataAccess.Connection);

                //初始化参数
                SearchParameter sp = new SearchParameter();

                //赋值
                sp.SetValue(":CONDITION1", "");
                sp.SetValue(":CONDITION2", "");

                //根据条件检索表
                DataTable dtLose = getData.GetTableByDiyCondition(Constants.SqlStr.TC_LOSE_LEFTJOIN_TC_INPUT_STORAGE_LEFTJOIN_TC_GOODS_LEFTJOIN_TC_MAKER_COUNT, sp);

                //如果为null,弹出错误
                if (dtLose == null)
                {
                    MessageBox.Show("请查看数据库是否正常！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //添加序列号
                int countNumber = 0;
                dtLose.Columns.Add("index", typeof(int));
                for (int i = 0; i < dtLose.Rows.Count; i++)
                {
                    dtLose.Rows[i]["index"] = ++countNumber;

                }

                dgvLose.DataSource = dtLose;
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

        //***********************************************************************
        /// <summary>
        /// 初始化页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：代国明      2010/07/26 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void DamageCountForm_Load(object sender, EventArgs e)
        {
            dtp_lose_datetime_Start.Enabled = false;
            dtp_lose_datetime_End.Enabled = false;
            //加载数据
            BandingDgvLose();
            txt_goods_name.Focus();
        }

        //***********************************************************************
        /// <summary>
        /// 清空按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：代国明      2010/07/26 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnClear_Click(object sender, EventArgs e)
        {
            //清空文本框
            txt_goods_name.Text = "";
            checkDate.Checked = false;
            dtp_lose_datetime_Start.Value = DateTime.Now.Date;
            dtp_lose_datetime_End.Value = DateTime.Now.Date;
        }

        //***********************************************************************
        /// <summary>
        /// 统计按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：代国明      2010/07/26 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnCount_Click(object sender, EventArgs e)
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
            string condition2 = string.Empty;

            if (checkDate.Checked)
            {
                if (dtp_lose_datetime_End.Value.Date < dtp_lose_datetime_Start.Value.Date)
                {
                    MessageBox.Show("日期起止范围不正确。", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtp_lose_datetime_Start.Focus();
                    return;
                }

                condition1 += "where lose_datetime>= '" + dtp_lose_datetime_Start.Value.Date + "' ";

                if (condition1.StartsWith("where"))
                {
                    condition1 += " and lose_datetime<= '" + DateTime.Parse(dtp_lose_datetime_End.Value.Date.ToString("yyyy-MM-dd") + " " + "23:59:59") + "' ";
                }
                else
                {
                    condition1 += "where lose_datetime<= '" + DateTime.Parse(dtp_lose_datetime_End.Value.Date.ToString("yyyy-MM-dd") + " " + "23:59:59") + "' ";
                }
            }        

            //条件不为空，赋值
            if (!txt_goods_name.Text.Trim().Equals(string.Empty))
            {
                condition2 = "where goods_name like'" + txt_goods_name.Text.Trim() + "%'";
            }

            //初始化参数
            SearchParameter sp = new SearchParameter();

            //为参数赋值
            sp.SetValue(":CONDITION1", condition1);
            sp.SetValue(":CONDITION2", condition2);
            try
            {
                //打开数据库连接
                dataAccess = new DataAccess();
                dataAccess.Open();

                //取得操作类
                GetData getData = new GetData(dataAccess.Connection);

                //取得表数据
                DataTable dtLose = getData.GetTableByDiyCondition(Constants.SqlStr.TC_LOSE_LEFTJOIN_TC_INPUT_STORAGE_LEFTJOIN_TC_GOODS_LEFTJOIN_TC_MAKER_COUNT, sp);

                //如果为null，出错
                if (dtLose == null)
                {
                    MessageBox.Show("请查看数据库是否正常！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (dtLose.Rows.Count <= 0)
                {

                    MessageBox.Show("数据不存在，请查看输入的条件是否正确！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                //添加序列号
                int countNumber = 0;
                dtLose.Columns.Add("index", typeof(int));
                for (int i = 0; i < dtLose.Rows.Count; i++)
                {
                    dtLose.Rows[i]["index"] = ++countNumber;

                }

                //绑定数据
                dgvLose.DataSource = dtLose;
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

        private void checkDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDate.Checked)
            {
                dtp_lose_datetime_Start.Enabled = true;
                dtp_lose_datetime_End.Enabled = true;
            }
            else
            {
                dtp_lose_datetime_Start.Enabled = false;
                dtp_lose_datetime_End.Enabled = false;
            }
        }

        private void dgvLose_Sorted(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvLose.Rows.Count; i++)
            {
                dgvLose.Rows[i].Cells["index"].Value = i + 1;
            }
        }
    }
}
