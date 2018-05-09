//***********************************************************************
//* 系统名称	    ：  长白ERP系统
//* 功能模块	    ：  系统信息
//* 功能画面		：  出库查询管理
//* 画面名称	    ：  OutStorageSelectForm
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
    ///出库查询管理功能
    /// </summary>
    /// <history>
    ///     完成信息：代国明      2010/07/23 完成  
    ///     更新信息：
    /// </history>
    //***********************************************************************
    public partial class OutStorageSelectForm : Form
    {
        /// <summary>
        /// 数据库连接句柄
        /// </summary>
        DataAccess dataAccess = null;

        private DataTable dtPrint = null;

        private string sellType = string.Empty;

        public OutStorageSelectForm()
        {
            InitializeComponent();

            this.dgvOutputStorage.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(239, 243, 251);
            dtp_output_instorage_date_Start.Value = new DateTime(DateTime.Now.Date.Year, DateTime.Now.Date.Month, 1);
            dtp_output_instorage_date_End.Value = new DateTime(DateTime.Now.Date.Year, DateTime.Now.Date.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
        }

        //***********************************************************************
        /// <summary>
        /// 画面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：代国明      2010/07/23 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void OutStorageSelectForm_Load(object sender, EventArgs e)
        {
            dtp_output_instorage_date_Start.Enabled = true;
            dtp_output_instorage_date_End.Enabled = true;

            //下拉列表填值
            cmb_output_type.Items.Insert(0, "请选择出库类别...");

            //下拉列表初始化
            cmb_output_type.SelectedIndex = 0;

            dgvOutputStorage.AutoGenerateColumns = false;

            //加载数据
            BindingDgvOutputStorage();
            txt_goods_name.Focus();
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
        private void BindingDgvOutputStorage()
        {
            try
            {
                //打开数据库连接
                dataAccess = new DataAccess();
                dataAccess.Open();

                //取得操作类
                GetData getData = new GetData(dataAccess.Connection);

                //初始化参数类
                SearchParameter sp = new SearchParameter();

                sp.SetValue(":OUTPUT_INSTORAGE_DATE_FROM", dtp_output_instorage_date_Start.Value.Date);
                sp.SetValue(":OUTPUT_INSTORAGE_DATE_TO", dtp_output_instorage_date_End.Value.Date);
                //根据条件检索表
                DataTable dtInputStorage = getData.GetTableBySqlStr(Constants.SqlStr.TC_OUTPUT_STORAGE_LEFTJOIN_TC_CUSTOMER_LEFTJOIN_TC_INPUT_STORAGE_LEFTJOIN_TC_GOODS_SELECT, sp);

                //如果为NULL，报错
                if (dtInputStorage == null)
                {
                    MessageBox.Show("请查看数据库是否正常！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                dtPrint = dtInputStorage.Copy();
                //如果不为NULL，绑定数据
                if (dtInputStorage.Rows.Count > 0)
                {
                    //添加序列号
                    int countNumber = 0;
                    dtInputStorage.Columns.Add("num", typeof(int));
                    for (int i = 0; i < dtInputStorage.Rows.Count; i++)
                    {
                        dtInputStorage.Rows[i]["num"] = ++countNumber;

                    }
                    dgvOutputStorage.DataSource = dtInputStorage;
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
            //清空文本框
            txt_goods_name.Text = "";
            txt_output_code.Text = "";
            checkDate.Checked = true;
            dtp_output_instorage_date_Start.Value = new DateTime(DateTime.Now.Date.Year, DateTime.Now.Date.Month, 1);
            dtp_output_instorage_date_End.Value = new DateTime(DateTime.Now.Date.Year, DateTime.Now.Date.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
            cmb_output_type.SelectedIndex = 0;
        }

        //***********************************************************************
        /// <summary>
        /// 查找按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：代国明      2010/07/23 完成   
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
                if (DateTime.Parse(dtp_output_instorage_date_End.Value.ToString("yyyy-MM-dd")) < DateTime.Parse(dtp_output_instorage_date_Start.Value.ToString("yyyy-MM-dd")))
                {
                    MessageBox.Show("结束日期不能小于开始日期！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtp_output_instorage_date_Start.Focus();
                    return;
                }

                sp.SetValue(":OUTPUT_INSTORAGE_DATE_FROM", dtp_output_instorage_date_Start.Value.Date);
                sp.SetValue(":OUTPUT_INSTORAGE_DATE_TO", dtp_output_instorage_date_End.Value.Date);
            }


            //条件不为空，添加参数
            //if (!txt_output_instorage_date_Start.Text.Equals(string.Empty))
            //{
            //    try
            //    {
            //        sp.SetValue(":OUTPUT_INSTORAGE_DATE_FROM", DateTime.Parse(txt_output_instorage_date_Start.Text));
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
            //        sp.SetValue(":OUTPUT_INSTORAGE_DATE_TO", DateTime.Parse(txt_output_instorage_date_End.Text));
            //    }
            //    catch
            //    {
            //        MessageBox.Show("请输入正确的时间格式！", "时间格式：", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        txt_output_instorage_date_End.Focus();
            //        return;
            //    }
            //}

            if (!txt_output_code.Text.Trim().Equals(string.Empty))
            {
                sp.SetValue(":OS.OUTPUT_CODE", txt_output_code.Text);
            }

            if (!txt_goods_name.Text.Trim().Equals(string.Empty))
            {
                sp.SetValue(":GOODS.GOODS_NAME", txt_goods_name.Text);
            }

            if (cmb_output_type.Text.Trim().Equals("销售出库"))
            {
                sp.SetValue(":OS.OUTPUT_TYPE", "0");
            }
            else if (cmb_output_type.Text.Trim().Equals("退货出库"))
            {
                sp.SetValue(":OS.OUTPUT_TYPE", "1");
            }

            try
            {
                //打开数据库连接
                dataAccess = new DataAccess();
                dataAccess.Open();

                //取得操作类
                GetData getData = new GetData(dataAccess.Connection);

                //根据条件检索表
                DataTable dtOutputStorage = getData.GetTableBySqlStr(Constants.SqlStr.TC_OUTPUT_STORAGE_LEFTJOIN_TC_CUSTOMER_LEFTJOIN_TC_INPUT_STORAGE_LEFTJOIN_TC_GOODS_SELECT, sp);

                //如果为NULL，报错
                if (dtOutputStorage == null)
                {
                    MessageBox.Show("请查看数据库是否正常！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //如果为零，显示没有数据
                if (dtOutputStorage.Rows.Count == 0)
                {
                    MessageBox.Show("数据不存在，请查看输入的条件是否正确！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                }
                dtPrint = dtOutputStorage.Copy();
              
               //添加序列号
                int countNumber = 0;
                dtOutputStorage.Columns.Add("num", typeof(int));
                for (int i = 0; i < dtOutputStorage.Rows.Count; i++)
                {
                    dtOutputStorage.Rows[i]["num"] = ++countNumber;

                }
                //绑定数据源
                dgvOutputStorage.DataSource = dtOutputStorage;

                sellType = cmb_output_type.Text;
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dtPrint == null || dtPrint.Rows.Count == 0)
            {
                MessageBox.Show("没有可以打印的数据！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SellStoragePrint sellStoragePrint = new SellStoragePrint(dtPrint, sellType);
            sellStoragePrint.ShowDialog();
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
