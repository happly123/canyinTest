//***********************************************************************
//* 系统名称	    ：  长白ERP系统
//* 功能模块	    ：  系统信息
//* 功能画面		：  出库统计管理
//* 画面名称	    ：  OutStorageCountForm
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
using DataAccesses;
using InvoicingUtil;

namespace InvoicingApp
{
    //***********************************************************************
    /// <summary>
    ///出库统计管理功能
    /// </summary>
    /// <history>
    ///     完成信息：代国明      2010/07/23 完成  
    ///     更新信息：
    /// </history>
    //***********************************************************************
    public partial class OutStorageCountForm : Form
    {
        /// <summary>
        /// 数据库连接句柄
        /// </summary>
        DataAccess dataAccess = null;

        private DataTable dtPrint = null;

        public OutStorageCountForm()
        {
            InitializeComponent();

            this.dgvOutputStorage.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(239, 243, 251);
        }

        //*******************************************************************
        /// <summary>
        /// 绑定画面
        /// </summary>
        /// <history>
        ///     完成信息：代国明      2010/07/23 完成   
        ///     更新信息：
        /// </history>
        //*******************************************************************
        private void BandingDgvOutputStorage()
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
                DataTable dtOutputStorage = getData.GetTableByDiyCondition(Constants.SqlStr.TC_OUTPUT_STORAGE_LEFTJOIN_TC_INPUT_STORAGE_LEFTJOIN_TC_GOODS_LEFTJOIN_TC_MAKER, sp);

                //如果为null,弹出错误
                if (dtOutputStorage == null)
                {
                    MessageBox.Show("请查看数据库是否正常！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //dtPrint = dtOutputStorage.Copy();

                //如果不为空,绑定数据源
                if (dtOutputStorage.Rows.Count > 0)
                {
                    //添加序列号
                    int countNumber = 0;
                    dtOutputStorage.Columns.Add("num", typeof(int));
                    for (int i = 0; i < dtOutputStorage.Rows.Count; i++)
                    {
                        dtOutputStorage.Rows[i]["num"] = ++countNumber;

                    }
                    dgvOutputStorage.DataSource = dtOutputStorage;
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

        //***********************************************************************
        /// <summary>
        /// 统计按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：代国明      2010/07/23 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnStatistics_Click(object sender, EventArgs e)
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
                if (dtp_output_instorage_date_End.Value.Date < dtp_output_instorage_date_Start.Value.Date)
                {
                    MessageBox.Show("结束日期不能小于开始日期！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtp_output_instorage_date_Start.Focus();
                    return;
                }

                condition1 += "where output_instorage_date>= '" + dtp_output_instorage_date_Start.Value.Date + "' ";

                if (condition1.StartsWith("where"))
                {
                    condition1 += " and output_instorage_date<= '" + DateTime.Parse(dtp_output_instorage_date_End.Value.Date.ToString("yyyy-MM-dd") + " " + "23:59:59") + "' ";
                }
                else
                {
                    condition1 += "where output_instorage_date<= '" + DateTime.Parse(dtp_output_instorage_date_End.Value.Date.ToString("yyyy-MM-dd") + " " + "23:59:59") + "' ";
                }
            }

            ////条件不为空，赋值
            //if (!txt_output_instorage_date_Start.Text.Equals(string.Empty))
            //{
            //    try
            //    {
            //        condition1 += "where output_instorage_date>= '" + DateTime.Parse(txt_output_instorage_date_Start.Text) + "' ";
            //    }
            //    catch
            //    {
            //        MessageBox.Show("请输入正确的时间格式！", "时间格式：", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        txt_output_instorage_date_Start.Focus();
            //        return;
            //    }
            //}

            //if (!txt_output_instorage_date_End.Text.Equals(string.Empty))
            //{
            //    try
            //    {
            //        if (condition1.StartsWith("where"))
            //        {
            //            condition1 += " and output_instorage_date<= '" + DateTime.Parse(txt_output_instorage_date_End.Text) + "' ";
            //        }
            //        else
            //        {
            //            condition1 += "where output_instorage_date<= '" + DateTime.Parse(txt_output_instorage_date_End.Text) + "' ";
            //        }
            //    }
            //    catch
            //    {
            //        MessageBox.Show("请输入正确的时间格式！", "时间格式：", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        txt_output_instorage_date_End.Focus();
            //        return;
            //    }
            //}

            //条件以where开始，赋值
            if (condition1.StartsWith("where"))
            {
                if (cmb_output_type.Text.Equals("销售出库"))
                {
                    condition1 += " and output_type ='0' ";
                }
                else if (cmb_output_type.Text.Equals("退货出库"))
                {
                    condition1 += " and output_type ='1' ";
                }                
            }
            else
            {
                if (cmb_output_type.Text.Equals("销售出库"))
                {
                    condition1 += "where output_type ='0' ";
                }
                else if (cmb_output_type.Text.Equals("退货出库"))
                {
                    condition1 += "where output_type ='1' ";
                }               
            }

            //条件不为空，赋值
            if (!txt_goods_name.Text.Trim().Equals(string.Empty))
            {
                condition2 = "where goods_name like'%" + txt_goods_name.Text.Trim() + "%'";
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
                DataTable dtOutputStorage = getData.GetTableByDiyCondition(Constants.SqlStr.TC_OUTPUT_STORAGE_LEFTJOIN_TC_INPUT_STORAGE_LEFTJOIN_TC_GOODS_LEFTJOIN_TC_MAKER, sp);

                //如果为null，出错
                if (dtOutputStorage == null)
                {
                    MessageBox.Show("请查看数据库是否正常！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (dtOutputStorage.Rows.Count <= 0)
                {

                    MessageBox.Show("数据不存在，请查看输入的条件是否正确！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);                  
                }

               // dtPrint = dtOutputStorage.Copy();
                //添加序列号
                int countNumber = 0;
                dtOutputStorage.Columns.Add("num", typeof(int));
                for (int i = 0; i < dtOutputStorage.Rows.Count; i++)
                {
                    dtOutputStorage.Rows[i]["num"] = ++countNumber;

                }
                //绑定数据
                dgvOutputStorage.DataSource = dtOutputStorage;
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
        /// 清空按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：代国明      2010/07/23 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnClear_Click(object sender, EventArgs e)
        {
            txt_goods_name.Text = "";
            dtp_output_instorage_date_Start.Value = DateTime.Now.Date;
            dtp_output_instorage_date_End.Value = DateTime.Now.Date;
            checkDate.Checked = false;
            cmb_output_type.SelectedIndex = 0;
        }

        //***********************************************************************
        /// <summary>
        /// 初始化页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：代国明      2010/07/23 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void OutStorageCountForm_Load(object sender, EventArgs e)
        {
            dtp_output_instorage_date_Start.Enabled = false;
            dtp_output_instorage_date_End.Enabled = false;
            //初始化参数
            cmb_output_type.Items.Insert(0, "请选择出库类别...");
            cmb_output_type.SelectedIndex = 0;

            //加载数据
            BandingDgvOutputStorage();

            txt_goods_name.Focus();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //SellStoragePrint sellStoragePrint = new SellStoragePrint(dtPrint);
            //sellStoragePrint.ShowDialog();
        }

        private void checkDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDate.Checked)
            {
                dtp_output_instorage_date_Start.Enabled = true;
                dtp_output_instorage_date_End.Enabled = true;
            }
            else
            {
                dtp_output_instorage_date_Start.Enabled = false;
                dtp_output_instorage_date_End.Enabled = false;
            }
        }

        private void dgvOutputStorage_Sorted(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvOutputStorage.Rows.Count; i++)
            {
                dgvOutputStorage.Rows[i].Cells["num"].Value = i + 1;
            }
        }

        
    }
}
