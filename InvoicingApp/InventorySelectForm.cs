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
//* 功能画面		：  库存查询管理
//* 画面名称	    ：  InitStorageForm
//* 完成年月日      ：  2010/07/26
//* 作者		    ：  吴小科
//* Version		    ：  1.00
//* ---------------------------------------------------------------------
//* 前提		：SQL SERVER,.NetFramework3.0
//***********************************************************************
namespace InvoicingApp
{
    public partial class InventorySelectForm : Form
    {
         /// <summary>
        /// 数据库连接句柄
        /// </summary>
        DataAccess dataAccess = null;
        /// <summary>
        /// 数据库绑定表
        /// </summary>
        DataTable dtStorage = null;
        public InventorySelectForm()
        {
            InitializeComponent();
            dateInputDateFrom.Value = new DateTime(DateTime.Now.Date.Year, DateTime.Now.Date.Month, 1);
            dateInputDateTo.Value = new DateTime(DateTime.Now.Date.Year, DateTime.Now.Date.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
        }
        //*******************************************************************
        /// <summary>
        /// 库存查询页面初始化
        /// </summary>
        /// <history>
        ///     完成信息：吴小科      2010/07/26 完成   
        ///     更新信息：
        /// </history>
        //*******************************************************************
        private void InventorySelectForm_Load(object sender, EventArgs e)
        {
            try
            {

                //打开数据库
                dataAccess = new DataAccess();
                dataAccess.Open();
                //获取操作类
                GetData getData = new GetData(dataAccess.Connection);
                SearchParameter sp = new SearchParameter();
                sp.SetValue(":input_instorage_date_FROM", dateInputDateFrom.Value.Date);
                sp.SetValue(":input_instorage_date_TO", dateInputDateTo.Value.Date);
                //获取绑定数据表
                dtStorage = getData.GetTableBySqlStr(Constants.SqlStr.tc_storage_count, sp);
               
                if (dtStorage == null)
                {
                    MessageBox.Show("请查看数据库是否正常！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DataRow[] drs = dtStorage.Select("input_count=0");
                for (int i = 0; i < drs.Length; i++)
                {
                    dtStorage.Rows.Remove(drs[i]);
                }

                //添加序列号和有效期至
                int countNumber = 0;
                dtStorage.Columns.Add("num", typeof(int));
                dtStorage.Columns.Add("goodsValidity", typeof(DateTime));
                for (int i = 0; i < dtStorage.Rows.Count; i++)
                {
                    dtStorage.Rows[i]["num"] = ++countNumber;
                    int validity = int.Parse(dtStorage.Rows[i]["goods_validity"].ToString());
                    DateTime goodSValidity = DateTime.Parse(dtStorage.Rows[i]["input_maketime"].ToString()).AddMonths(validity);
                    dtStorage.Rows[i]["goodsValidity"] = goodSValidity;

                }
                dataGridView_storage.AutoGenerateColumns = false;
                 //绑定数据
                dataGridView_storage.DataSource = dtStorage;

                textBox_input_code.Focus();
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
        /// 查询按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/07/26 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnCheck_Click(object sender, EventArgs e)
        {
            foreach (Control control in groupBox1.Controls)
            {
                if (control is TextBox)
                {
                    if (Util.CheckRegex(control.Text.Trim()))
                    {
                        MessageBox.Show("不可以输入非法字符，请重新输入！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        control.Focus();
                        return;
                    }
                }
            }
            //设置查询条件参数
            SearchParameter sp = new SearchParameter();
            //判断文本框是否为空
            if (!textBox_input_code.Text.Trim().Equals(string.Empty))
            {
                sp.SetValue(":TC_INPUT_STORAGE.INPUT_CODE", textBox_input_code.Text);
            }
            //判断文本框是否为空
            if (!textBox_maker_name.Text.Trim().Equals(string.Empty))
            {
                sp.SetValue(":TC_MAKER.MAKER_NAME", textBox_maker_name.Text);
            }
            //判断文本框是否为空
            if (!textBox_goods_name.Text.Trim().Equals(string.Empty))
            {
                sp.SetValue(":TC_GOODS.GOODS_NAME", textBox_goods_name.Text);
            }
            //判断文本框是否为空
            if (!textBox_goods_yxm.Text.Trim().Equals(string.Empty))
            {
                sp.SetValue(":TC_GOODS.GOODS_YXM", textBox_goods_yxm.Text);
            }
            //判断文本框是否为空
            if (!textBox_maker_yxm.Text.Trim().Equals(string.Empty))
            {
                sp.SetValue(":TC_MAKER.MAKER_YXM", textBox_maker_yxm.Text);
            }
            DateTime dateFrom = DateTime.Parse("1000-01-01");
            DateTime dateTo = DateTime.Parse("9999-12-30");

            if (dateTo < dateFrom)
            {
                MessageBox.Show("结束日期不能小于开始日期！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateInputDateFrom.Focus();
                return;
            }
            if (checkDate.Checked == true)
            {
                dateFrom = dateInputDateFrom.Value.Date;
                dateTo = dateInputDateTo.Value.Date;
                sp.SetValue(":input_instorage_date_FROM", dateInputDateFrom.Value.Date);
                sp.SetValue(":input_instorage_date_TO", dateInputDateTo.Value.Date);

            }
            try
            {
                //打开数据库
                dataAccess = new DataAccess();
                dataAccess.Open();
                //获取操作类
                GetData getData = new GetData(dataAccess.Connection);
                //返回绑定数据表
                dtStorage = getData.GetTableBySqlStr(Constants.SqlStr.tc_storage_count, sp);
                if (dtStorage == null)
                {
                    MessageBox.Show("请查看数据库是否正常！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DataRow[] drs = dtStorage.Select("input_count=0");
                for (int i = 0; i < drs.Length; i++)
                {
                    dtStorage.Rows.Remove(drs[i]);
                }

                //添加序列号
                int countNumber = 0;
                dtStorage.Columns.Add("num", typeof(int));
                dtStorage.Columns.Add("goodsValidity", typeof(DateTime));
                for (int i = 0; i < dtStorage.Rows.Count; i++)
                {
                    dtStorage.Rows[i]["num"] = ++countNumber;
                    int validity = int.Parse(dtStorage.Rows[i]["goods_validity"].ToString());
                    DateTime goodSValidity = DateTime.Parse(dtStorage.Rows[i]["input_maketime"].ToString()).AddMonths(validity);
                    dtStorage.Rows[i]["goodsValidity"] = goodSValidity;

                }
                dataGridView_storage.AutoGenerateColumns = false;
                //绑定数据
                dataGridView_storage.DataSource = dtStorage;
                if (dtStorage.Rows.Count == 0)
                {
                    MessageBox.Show("数据不存在，请查看输入的条件是否正确！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        /// 清空按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/07/26 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox_goods_name.Text = "";
            textBox_input_code.Text = "";
            textBox_maker_name.Text = "";
            textBox_goods_yxm.Text = "";
            textBox_maker_yxm.Text = "";
            checkDate.Checked = true;
            dateInputDateFrom.Value = new DateTime(DateTime.Now.Date.Year, DateTime.Now.Date.Month, 1);
            dateInputDateTo.Value = new DateTime(DateTime.Now.Date.Year, DateTime.Now.Date.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
        }
        //***********************************************************************
        /// <summary>
        /// 样式绑定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/08/03 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void dataGridView_storage_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
           
            for (int i = 0; i < dtStorage.Rows.Count; i++)
            {
                dataGridView_storage.Rows[0].Selected = false;
                if ((DateTime.Parse(dataGridView_storage.Rows[i].Cells["goodsValidity"].Value.ToString()) - DateTime.Now).TotalDays < 0)
                {
                    dataGridView_storage.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
                else if ((DateTime.Parse(dataGridView_storage.Rows[i].Cells["goodsValidity"].Value.ToString()) - DateTime.Now).TotalDays < 30)
                {
                    dataGridView_storage.Rows[i].DefaultCellStyle.BackColor = Color.Bisque;
                }
                else if ((DateTime.Parse(dataGridView_storage.Rows[i].Cells["goodsValidity"].Value.ToString()) - DateTime.Now).TotalDays < 90)
                {
                    dataGridView_storage.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else if ((DateTime.Parse(dataGridView_storage.Rows[i].Cells["goodsValidity"].Value.ToString()) - DateTime.Now).TotalDays < 180)
                {
                    dataGridView_storage.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                }

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
        

   
    }
}
