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
//***********************************************************************
//* 系统名称	    ：  长白ERP系统
//* 功能模块	    ：  系统信息
//* 功能画面		：  库存统计管理
//* 画面名称	    ：  InventoryCountForm
//* 完成年月日      ：  2010/07/29 完成
//* 作者		    ：  吴小科
//* Version		    ：  1.00
//* ---------------------------------------------------------------------
//* 前提		：SQL SERVER,.NetFramework3.0
//***********************************************************************
namespace InvoicingApp
{
    public partial class InventoryCountForm : Form
    {
        /// <summary>
        /// 数据库连接句柄
        /// </summary>
        DataAccess dataAccess = null;
        public InventoryCountForm()
        {
            InitializeComponent();
            this.dataGridView_storage.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(239, 243, 251); 
        }
        //*******************************************************************
        /// <summary>
        /// 库存统计页面初始化
        /// </summary>
        /// <history>
        ///     完成信息：吴小科      2010/07/29 完成   
        ///     更新信息：
        /// </history>
        //*******************************************************************
        private void InventoryCountForm_Load(object sender, EventArgs e)
        {
            try
            {

                //打开数据库
                dataAccess = new DataAccess();
                dataAccess.Open();
                //获取操作类
                GetData getData = new GetData(dataAccess.Connection);
                SearchParameter sp = new SearchParameter();
                //获取绑定数据表
                DataTable dtStorage = getData.GetTableBySqlStr(Constants.SqlStr.TC_STORAGE_COUNT, sp);

                if (dtStorage == null)
                {
                    MessageBox.Show("请查看数据库是否正常！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //添加序列号
                int countNumber = 0;
                dtStorage.Columns.Add("num", typeof(int));
                for (int i = 0; i < dtStorage.Rows.Count; i++)
                {
                    dtStorage.Rows[i]["num"] = ++countNumber;

                }
                //绑定数据
                dataGridView_storage.DataSource = dtStorage;

                txtGoodsName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("请查看数据库是否正常！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {   //关闭数据库
                dataAccess.Close();
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
        //***********************************************************************
        /// <summary>
        /// 清空按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/07/29 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnClear_Click(object sender, EventArgs e)
        {
            
            txtGoodsName.Text = "";
            txt_goods_yxm.Text = "";

        }
        //***********************************************************************
        /// <summary>
        /// 统计按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/07/29 完成   
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
            SearchParameter sp = new SearchParameter();
            //判断文本框是否为空
            if (!txtGoodsName.Text.Trim().Equals(string.Empty))
            {
                sp.SetValue(":TC_GOODS.GOODS_NAME", txtGoodsName.Text);
            }
            //判断文本框是否为空
            if (!txt_goods_yxm.Text.Trim().Equals(string.Empty))
            {
                sp.SetValue(":TC_GOODS.GOODS_YXM", txt_goods_yxm.Text);
            }
            try
            {

                //打开数据库
                dataAccess = new DataAccess();
                dataAccess.Open();
                //获取操作类
                GetData getData = new GetData(dataAccess.Connection);
                //获取绑定数据表
                DataTable dtStorage = getData.GetTableBySqlStr(Constants.SqlStr.TC_STORAGE_COUNT, sp);

                if (dtStorage == null)
                {
                    MessageBox.Show("请查看数据库是否正常！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //添加序列号
                int countNumber = 0;
                dtStorage.Columns.Add("num", typeof(int));
                for (int i = 0; i < dtStorage.Rows.Count; i++)
                {
                    dtStorage.Rows[i]["num"] = ++countNumber;

                }
                if (dtStorage.Rows.Count > 0)
                {
                    //绑定数据
                    dataGridView_storage.DataSource = dtStorage;
                }
                if (dtStorage.Rows.Count == 0)
                {
                    MessageBox.Show("数据不存在，请查看输入的条件是否正确！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //绑定数据
                    dataGridView_storage.DataSource = dtStorage;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("请查看数据库是否正常！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {   //关闭数据库
                dataAccess.Close();
            }

        }
        //***********************************************************************
        /// <summary>
        /// 序号重新排列
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/09/10 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void dataGridView_storage_Sorted(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView_storage.Rows.Count; i++)
            {
                dataGridView_storage.Rows[i].Cells["num"].Value = i + 1;
            }

        }

 
    }
}
