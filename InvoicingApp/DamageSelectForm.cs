//***********************************************************************
//* 系统名称	    ：  长白ERP系统
//* 功能模块	    ：  系统信息
//* 功能画面		：  报损查询
//* 画面名称	    ：  DamageSelectForm
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
    ///报损查询
    /// </summary>
    /// <history>
    ///     完成信息：代国明      2010/07/26 完成  
    ///     更新信息：
    /// </history>
    //***********************************************************************
    public partial class DamageSelectForm : Form
    {
        /// <summary>
        /// 数据库连接句柄
        /// </summary>
        DataAccess dataAccess = null;

        /// <summary>
        /// 出库数据源表
        /// </summary>
        private DataTable dtDgvLose = null;

        public DamageSelectForm()
        {
            InitializeComponent();
            dgvLose.AutoGenerateColumns = false;
            this.dgvLose.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(239, 243, 251);
            dtp_lose_datetime_Start.Value = new DateTime(DateTime.Now.Date.Year, DateTime.Now.Date.Month, 1);
            dtp_lose_datetime_End.Value = new DateTime(DateTime.Now.Date.Year, DateTime.Now.Date.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
        }

        //*******************************************************************
        /// <summary>
        /// 取得数据源
        /// </summary>
        /// <param name="dt">数据源表</param>
        /// <history>
        ///     完成信息：代国明      2010/07/26 完成   
        ///     更新信息：
        /// </history>
        //*******************************************************************
        private void GetDgvLose(DataTable dt)
        {
            //定义出库统计数据源表
            dtDgvLose = new DataTable();

            //添加各个数据列
            dtDgvLose.Columns.Add("goods_name", typeof(string));
            dtDgvLose.Columns.Add("goods_type", typeof(string));
            dtDgvLose.Columns.Add("maker_name", typeof(string));
            dtDgvLose.Columns.Add("goods_unit", typeof(string));
            dtDgvLose.Columns.Add("lose_count", typeof(string));
            dtDgvLose.Columns.Add("lose_datetime", typeof(string));
            dtDgvLose.Columns.Add("goods_reg_num", typeof(string));
            dtDgvLose.Columns.Add("lose_code", typeof(string));

            //遍历数据源
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dtDgvLose.NewRow();

                dr["goods_name"] = dt.Rows[i]["goods_name"].ToString();
                dr["goods_type"] = dt.Rows[i]["goods_type"].ToString();
                dr["maker_name"] = dt.Rows[i]["maker_name"].ToString();
                dr["goods_unit"] = dt.Rows[i]["goods_unit"].ToString();
                dr["lose_count"] = dt.Rows[i]["lose_count"].ToString();
                dr["goods_reg_num"] = dt.Rows[i]["goods_reg_num"].ToString();
                dr["lose_datetime"] = DateTime.Parse(dt.Rows[i]["lose_datetime"].ToString()).ToString("yyyy-MM-dd");
                if (dt.Rows[i]["lose_datetime"].ToString().Equals(string.Empty))
                {
                    dr["lose_datetime"] = "";
                }
                else
                {
                    dr["lose_datetime"] = DateTime.Parse(dt.Rows[i]["lose_datetime"].ToString()).ToString("yyyy-MM-dd");
                }
                dr["lose_code"] = dt.Rows[i]["lose_code"].ToString();
                dtDgvLose.Rows.Add(dr);
            }
        }

        //*******************************************************************
        /// <summary>
        /// 绑定画面
        /// </summary>
        /// <history>
        ///     完成信息：代国明      2010/07/26 完成   
        ///     更新信息：
        /// </history>
        //*******************************************************************
        private void BindingDgvLose()
        {
            //初始化参数类
            SearchParameter sp = new SearchParameter();

            try
            {
                //打开数据库连接
                dataAccess = new DataAccess();
                dataAccess.Open();

                //取得操作类
                GetData getData = new GetData(dataAccess.Connection);
                sp.SetValue(":LOSE_DATETIME_FROM", dtp_lose_datetime_Start.Value.Date);
                sp.SetValue(":LOSE_DATETIME_TO", DateTime.Parse(dtp_lose_datetime_End.Value.Date.ToString("yy-MM-dd") + " " + "23:59:59"));
                //根据条件检索表
                DataTable dtLose = getData.GetTableBySqlStr(Constants.SqlStr.TC_LOSE_LEFTJOIN_TC_INPUT_STORAGE_LEFTJOIN_TC_GOODS_LEFTJOIN_TC_MAKER_SELECT, sp);

                //如果为NULL，报错
                if (dtLose == null)
                {
                    MessageBox.Show("请查看数据库是否正常！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //如果不为NULL，绑定数据

                GetDgvLose(dtLose);

                //添加序列号
                int countNumber = 0;
                dtDgvLose.Columns.Add("index", typeof(int));
                for (int i = 0; i < dtDgvLose.Rows.Count; i++)
                {
                    dtDgvLose.Rows[i]["index"] = ++countNumber;

                }

                dgvLose.DataSource = dtDgvLose;
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
        /// 画面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：代国明      2010/07/26 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void DamageSelectForm_Load(object sender, EventArgs e)
        {
            dtp_lose_datetime_Start.Enabled = true;
            dtp_lose_datetime_End.Enabled = true;

            dgvLose.AutoGenerateColumns = false;
            //加载数据
            BindingDgvLose();

            txt_goods_name.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //清空文本框
            txt_goods_name.Text = "";
            checkDate.Checked = true;
            dtp_lose_datetime_Start.Value = new DateTime(DateTime.Now.Date.Year, DateTime.Now.Date.Month, 1);
            dtp_lose_datetime_End.Value = new DateTime(DateTime.Now.Date.Year, DateTime.Now.Date.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
        }

        //***********************************************************************
        /// <summary>
        /// 查找按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：代国明      2010/07/26 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
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

            //初始化参数类
            SearchParameter sp = new SearchParameter();

            if (checkDate.Checked)
            {
                if (DateTime.Parse(dtp_lose_datetime_End.Value.ToString("yyyy-MM-dd")) < DateTime.Parse(dtp_lose_datetime_Start.Value.ToString("yyyy-MM-dd")))
                {
                    MessageBox.Show("日期起止范围不正确。", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtp_lose_datetime_Start.Focus();
                    return;
                }
                sp.SetValue(":LOSE_DATETIME_FROM", dtp_lose_datetime_Start.Value.Date);
                sp.SetValue(":LOSE_DATETIME_TO", DateTime.Parse(dtp_lose_datetime_End.Value.Date.ToString("yy-MM-dd") + " " + "23:59:59"));
            }

            if (!txt_goods_name.Text.Trim().Equals(string.Empty))
            {
                sp.SetValue(":TC_GOODS.GOODS_NAME", txt_goods_name.Text.Trim());
            }

            try
            {
                //打开数据库连接
                dataAccess = new DataAccess();
                dataAccess.Open();

                //取得操作类
                GetData getData = new GetData(dataAccess.Connection);

                //根据条件检索表
                DataTable dtLose = getData.GetTableBySqlStr(Constants.SqlStr.TC_LOSE_LEFTJOIN_TC_INPUT_STORAGE_LEFTJOIN_TC_GOODS_LEFTJOIN_TC_MAKER_SELECT, sp);

                //如果为NULL，报错
                if (dtLose == null)
                {
                    MessageBox.Show("请查看数据库是否正常！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //如果为零，显示没有数据
                if (dtLose.Rows.Count == 0)
                {
                    MessageBox.Show("数据不存在，请查看输入的条件是否正确！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                GetDgvLose(dtLose);

                //添加序列号
                int countNumber = 0;
                dtDgvLose.Columns.Add("index", typeof(int));
                for (int i = 0; i < dtDgvLose.Rows.Count; i++)
                {
                    dtDgvLose.Rows[i]["index"] = ++countNumber;

                }

                dgvLose.DataSource = dtDgvLose;
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
