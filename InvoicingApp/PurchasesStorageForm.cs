using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using DataAccesses;
using InvoicingUtil;
//***********************************************************************
//* 系统名称	    ：  长白ERP系统
//* 功能模块	    ：  系统信息
//* 功能画面		：  购货入库管理
//* 画面名称	    ：  PurchasesStorageForm
//* 完成年月日      ：  2010/07/16
//* 作者		    ：  吴小科
//* Version		    ：  1.00
//* ---------------------------------------------------------------------
//* 前提		：SQL SERVER,.NetFramework3.0
//***********************************************************************
namespace InvoicingApp
{
    public partial class PurchasesStorageForm : Form
    {
         /// <summary>
        /// 数据库连接句柄
        /// </summary>
        DataAccess dataAccess = null;
        /// <summary>
        /// 选择记录的行号
        /// </summary>
        int countNum = 0;
        /// <summary>
        /// 入库标识 
        /// </summary>
        public string goods_code;
        /// <summary>
        /// 数量标识
        /// </summary>
        public int oldSTCount;
        /// <summary>
        /// 不合格数量标识
        /// </summary>
        public int disCount;
        /// <summary>
        /// 不合格物品标识
        /// </summary>
        public int disqualificationCode;
        /// <summary>
        /// 画面状态
        /// </summary>
        DataType dataType = DataType.None;
        /// <summary>
        /// 返回状态标记
        /// </summary>
        int result1 = -1;
        int result2 = -1;
        int result3 = -1;
        int result5 = -1;
        /// <summary>
        /// 入库实体类
        /// </summary>
        EntityInput_storage input_storageEntity = null;
        /// <summary>
        /// 临时库存表实体类
        /// </summary>
        EntityTemp_storage temp_storageEntity = null;
        /// <summary>
        /// 不合格产品临时表实体类
        /// </summary>
        EntityDisqualification disqualificationEntity = null;
        private static int editFlag;
        public PurchasesStorageForm()
        {
            editFlag = 0;
            InitializeComponent();
            this.dataGridView_input_storage.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(239, 243, 251);
        }
        //*******************************************************************
        /// <summary>
        /// 绑定画面
        /// </summary>
        /// <history>
        ///     完成信息：吴小科      2010/07/15 完成   
        ///     更新信息：吴小科      2010/07/21 修改
        /// </history>
        //*******************************************************************
        private void BandingDgvCounter()
        {
            try
            {

                //打开数据库连接
                dataAccess = new DataAccess();
                dataAccess.Open();

                //获取操作类
                GetData getData = new GetData(dataAccess.Connection);
                //设置加载条件
                SearchParameter sp = new SearchParameter();
                sp.SetValue(":input_type", '1');
                //获取绑定数据表
                DataTable dtInput_storage = getData.GetTableBySqlStr(Constants.SqlStr.TC_INPUT_INIT_STORAGE_LEFTJOIN_GOODS, sp);
                //添加序列号
                int countNumber = 0;
                dtInput_storage.Columns.Add("num", typeof(int));
                for (int i = 0; i < dtInput_storage.Rows.Count; i++)
                {
                    dtInput_storage.Rows[i]["num"] = ++countNumber;

                }
                //绑定数据
                dataGridView_input_storage.DataSource = dtInput_storage;
                if (dataGridView_input_storage != null && dataGridView_input_storage.Rows.Count > 0 && countNum != 0)
                {
                    dataGridView_input_storage.Rows[0].Selected = false;
                    dataGridView_input_storage.Rows[countNum].Selected = true;
                    dataGridView_input_storage.FirstDisplayedScrollingRowIndex = countNum;
                }
                if (dataGridView_input_storage.Rows.Count == 0)
                {
                    dataGridClear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("请查看数据库是否正常！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {

                //关闭数据库连接
                dataAccess.Close();
            }
        }

        /// <summary>
        /// 画面状态枚举
        /// </summary>
        public enum DataType
        {
            /// <summary>
            /// 更新
            /// </summary>
            Update = 0x0001,

            /// <summary>
            /// 添加
            /// </summary>
            Insert = 0x0002,

            /// <summary>
            /// 无状态
            /// </summary>
            None = 0x0003,

        }
        //*******************************************************************
        /// <summary>
        /// 设置按钮，文本框状态
        /// </summary>
        /// <history>
        ///     完成信息：吴小科      2010/07/15 完成   
        ///     更新信息：吴小科      2010/07/21 修改
        /// </history>
        //*******************************************************************

        private void setButtonState()
        {

            switch (dataType)
            {
                case DataType.None:

                    dataTime_input_maketime.Enabled = false;
                    dateTime_input_instorage_date.Enabled = false;
                    dateTime_input_checktime.Enabled = false;
                    textBox_input_quality_reg.ReadOnly = true;
                    textBox_input_remark.ReadOnly = true;
                    textBox_input_arrival_count.Enabled = false;
                    textBox_check_info.ReadOnly = true;
                    textBox_quality_info.ReadOnly = true;
                    comboBox_packing_out.Enabled = false;
                    comboBox_packing_mid.Enabled = false;
                    comboBox_packing_in.Enabled = false;
                    textBox_input_standard_count.Enabled = false;
                    textBox_input_batch_num.ReadOnly = true;
                    
                    textBox_goods_name.BackColor = Color.FromArgb(236, 233, 216);
                    textBox_input_quality_persion.BackColor = Color.FromArgb(236, 233, 216);
                    textBox_input_oper.BackColor = Color.FromArgb(236, 233, 216);
                    textBox_counter_name.BackColor = Color.FromArgb(236, 233, 216);
                    textBox_supplier_name.BackColor = Color.FromArgb(236, 233, 216);
                    textBox_input_check_persion.BackColor = Color.FromArgb(236, 233, 216);
                    textBox_input_issued.BackColor = Color.FromArgb(236, 233, 216);

                    btnInsert.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnCommit.Enabled = false;
                    btnCancel.Enabled = false;
                    
                    break;
                case DataType.Insert:
                    dataTime_input_maketime.Enabled = true;
                    dateTime_input_instorage_date.Enabled = true;
                    dateTime_input_checktime.Enabled = true;
                    textBox_input_quality_reg.ReadOnly = false;
                    textBox_input_remark.ReadOnly = false;
                    textBox_input_arrival_count.Enabled = true;
                    textBox_check_info.ReadOnly = false;
                    textBox_quality_info.ReadOnly = false;
                    comboBox_packing_out.Enabled = true;
                    comboBox_packing_mid.Enabled = true;
                    comboBox_packing_in.Enabled = true;
                    textBox_input_standard_count.Enabled= true;
                    textBox_input_batch_num.ReadOnly = false;
                   
                    textBox_input_code2.Text = "";
                    textBox_input_quality_reg.Text = "";
                    textBox_input_remark.Text = "";
                    textBox_input_arrival_count.Value = 0;

                    textBox_goods_name.Text = "双击选择一个产品...";
                    textBox_input_quality_persion.Text = "双击选择一个质管员...";
                    textBox_input_oper.Text = "双击选择一个业务员...";
                    textBox_counter_name.Text = "双击选择一个货位...";
                    textBox_supplier_name.Text = "双击选择一个供货商...";
                    textBox_input_standard_count.Value = 0;
                    textBox_input_check_persion.Text = "双击选择一个验收人...";
                    textBox_input_issued.Text = "双击选择一个审核人...";
                    textBox_goods_name.BackColor = Color.FromArgb(255, 255, 255);
                    textBox_input_quality_persion.BackColor = Color.FromArgb(255, 255, 255);
                    textBox_input_oper.BackColor = Color.FromArgb(255, 255, 255);
                    textBox_counter_name.BackColor = Color.FromArgb(255, 255, 255);
                    textBox_supplier_name.BackColor = Color.FromArgb(255, 255, 255);
                    textBox_input_check_persion.BackColor = Color.FromArgb(255, 255, 255);
                    textBox_input_issued.BackColor = Color.FromArgb(255, 255, 255);

                    textBox_input_batch_num.Text = "";
                    textBox_check_info.Text="";
                    textBox_quality_info.Text="";
                    dataTime_input_maketime.Value = DateTime.Now;
                    dateTime_input_instorage_date.Value = DateTime.Now;
                    dateTime_input_checktime.Value = DateTime.Now;

                    btnInsert.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnCommit.Enabled = true;
                    btnCancel.Enabled = true;
                    textBox_goods_name.Focus();
                    break;
                case DataType.Update:
                    dataTime_input_maketime.Enabled = true;
                    dateTime_input_instorage_date.Enabled = true;
                    dateTime_input_checktime.Enabled = true;
                    textBox_input_quality_reg.ReadOnly = false;
                    textBox_input_remark.ReadOnly = false;
                    textBox_input_arrival_count.Enabled = true;
                    textBox_check_info.ReadOnly = false;
                    textBox_quality_info.ReadOnly = false;
                    comboBox_packing_out.Enabled = true;
                    comboBox_packing_mid.Enabled = true;
                    comboBox_packing_in.Enabled = true;
                    textBox_input_standard_count.Enabled = true;
                    textBox_input_batch_num.ReadOnly = false;
                    textBox_input_quality_persion.BackColor = Color.FromArgb(255, 255, 255);
                    textBox_input_oper.BackColor = Color.FromArgb(255, 255, 255);
                    textBox_counter_name.BackColor = Color.FromArgb(255, 255, 255);
                    textBox_supplier_name.BackColor = Color.FromArgb(255, 255, 255);
                    textBox_input_check_persion.BackColor = Color.FromArgb(255, 255, 255);
                    textBox_input_issued.BackColor = Color.FromArgb(255, 255, 255);
                    btnInsert.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnCommit.Enabled = true;
                    btnCancel.Enabled = true;
                    textBox_goods_name.Focus();
                    break;


                default:
                    textBox_goods_name.BackColor = Color.FromArgb(236, 233, 216);
                    textBox_input_quality_persion.BackColor = Color.FromArgb(236, 233, 216);
                    textBox_input_oper.BackColor = Color.FromArgb(236, 233, 216);
                    textBox_counter_name.BackColor = Color.FromArgb(236, 233, 216);
                    textBox_supplier_name.BackColor = Color.FromArgb(236, 233, 216);
                    textBox_input_check_persion.BackColor = Color.FromArgb(236, 233, 216);
                    textBox_input_issued.BackColor = Color.FromArgb(236, 233, 216);
                    btnInsert.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnCommit.Enabled = false;
                    btnCancel.Enabled = false;
                    
                    break;
            }
        }
        //*******************************************************************
        /// <summary>
        /// 购货入库页面初始化
        /// </summary>
        /// <history>
        ///     完成信息：吴小科      2010/07/15 完成   
        ///     更新信息：吴小科      2010/07/21 修改
        /// </history>
        //*******************************************************************
        private void PurchasesStorageForm_Load(object sender, EventArgs e)
        {
            //comboBox_packing_out.Items.Insert(0, "请选择一种包装情况");
            //comboBox_packing_out.SelectedIndex = 0;
            //comboBox_packing_mid.Items.Insert(0, "请选择一种包装情况");
            //comboBox_packing_mid.SelectedIndex = 0;
            //comboBox_packing_in.Items.Insert(0, "请选择一种包装情况");
            //comboBox_packing_in.SelectedIndex = 0;
            //绑定画面
            BandingDgvCounter();
            
            //设定按钮状态
            dataType = DataType.None;
            setButtonState();
            textBox_input_code.Focus();
        }
        //***********************************************************************
        /// <summary>
        /// 清理画面数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/09/01 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void dataGridClear()
        {
            //文本框清空
            textBox_input_code2.Text = "";
            textBox_goods_name.Text = "";
            textBox_input_arrival_count.Value = 0;
            textBox_counter_name.Text = "";
            dataTime_input_maketime.Value = DateTime.Now.Date;
            dateTime_input_instorage_date.Value = DateTime.Now.Date;
            dateTime_input_checktime.Value = DateTime.Now.Date;
            textBox_input_oper.Text = "";
            textBox_input_quality_reg.Text = "";
            textBox_supplier_name.Text = "";
            textBox_input_quality_persion.Text = "";
            textBox_input_remark.Text = "";
            comboBox_packing_out.SelectedIndex = 0;
            comboBox_packing_mid.SelectedIndex = 0;
            comboBox_packing_in.SelectedIndex = 0;
            textBox_input_standard_count.Value = 0;
            textBox_input_check_persion.Text = "";
            textBox_input_issued.Text = "";
            textBox_input_batch_num.Text = "";
            textBox_quality_info.Text = "";
            textBox_check_info.Text = "";
 
        }
        //***********************************************************************
        /// <summary>
        /// 选择画面数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/07/15 完成   
        ///    更新信息：吴小科      2010/07/21 修改
        /// </history>
        //***********************************************************************
        private void dataGridView_input_storage_SelectionChanged(object sender, EventArgs e)
        {
            //判断画面数据不为空
            if (dataGridView_input_storage != null && dataGridView_input_storage.SelectedRows.Count != 0)
            {

                //取得数据赋值文本框
                goods_code = dataGridView_input_storage.SelectedRows[0].Cells["input_goods_code"].Value.ToString();
                textBox_input_code2.Text = dataGridView_input_storage.SelectedRows[0].Cells["input_code"].Value.ToString();
                textBox_goods_name.Text = dataGridView_input_storage.SelectedRows[0].Cells["goods_name"].Value.ToString();
                textBox_input_arrival_count.Value =Convert.ToInt32(dataGridView_input_storage.SelectedRows[0].Cells["input_arrival_count"].Value.ToString());
                textBox_counter_name.Text = dataGridView_input_storage.SelectedRows[0].Cells["counter_name"].Value.ToString();
                dataTime_input_maketime.Value = DateTime.Parse(dataGridView_input_storage.SelectedRows[0].Cells["input_maketime"].Value.ToString());
                dateTime_input_instorage_date.Value = DateTime.Parse(dataGridView_input_storage.SelectedRows[0].Cells["input_instorage_date"].Value.ToString());
                dateTime_input_checktime.Value = DateTime.Parse(dataGridView_input_storage.SelectedRows[0].Cells["input_checktime"].Value.ToString());
                textBox_input_oper.Text = dataGridView_input_storage.SelectedRows[0].Cells["input_oper"].Value.ToString();
                textBox_input_quality_reg.Text = dataGridView_input_storage.SelectedRows[0].Cells["input_quality_reg"].Value.ToString();
                textBox_supplier_name.Text = dataGridView_input_storage.SelectedRows[0].Cells["supplier_name"].Value.ToString();
                textBox_input_quality_persion.Text = dataGridView_input_storage.SelectedRows[0].Cells["input_quality_persion"].Value.ToString();
                textBox_input_remark.Text = dataGridView_input_storage.SelectedRows[0].Cells["input_remark"].Value.ToString();
                comboBox_packing_out.Text = dataGridView_input_storage.SelectedRows[0].Cells["input_packing_out"].Value.ToString();
                comboBox_packing_mid.Text = dataGridView_input_storage.SelectedRows[0].Cells["input_packing_mid"].Value.ToString();
                comboBox_packing_in.Text = dataGridView_input_storage.SelectedRows[0].Cells["input_packing_in"].Value.ToString();
                textBox_input_standard_count.Value =Convert.ToInt32(dataGridView_input_storage.SelectedRows[0].Cells["input_standard_count"].Value.ToString());
                textBox_input_check_persion.Text = dataGridView_input_storage.SelectedRows[0].Cells["input_check_persion"].Value.ToString();
                textBox_input_issued.Text = dataGridView_input_storage.SelectedRows[0].Cells["input_issued"].Value.ToString();
                textBox_input_batch_num.Text = dataGridView_input_storage.SelectedRows[0].Cells["input_batch_num"].Value.ToString();
                textBox_quality_info.Text = dataGridView_input_storage.SelectedRows[0].Cells["quality_info"].Value.ToString();
                textBox_check_info.Text = dataGridView_input_storage.SelectedRows[0].Cells["check_info"].Value.ToString();
            }
            dataType = DataType.None;
            setButtonState();



        }
        //*******************************************************************
        /// <summary>
        /// 双击文本框弹出不同的选择窗体
        /// </summary>
        /// <history>
        ///     完成信息：吴小科      2010/07/15 完成   
        ///     更新信息：吴小科      2010/07/21 修改
        /// </history>
        //*******************************************************************

        private void textBox_DoubleClick(object sender, EventArgs e)
        {
            switch (((TextBox)sender).Name)
            {   //双击文本框弹出弹出产品信息窗体
                case "textBox_goods_name":
                    {   //判断当前页面的状态
                        if (dataType == DataType.Insert)
                        {
                            goodsInformation goodInfo = new goodsInformation();
                            goodInfo.ShowDialog();
                            //获取产品信息
                            if (!goodInfo.goodsCode.Equals(string.Empty))
                            {
                                textBox_goods_name.Text = goodInfo.goodsName;
                                goods_code = goodInfo.goodsCode;
                            }
                        }
                        break;

                    }
                //双击文本框弹出弹出员工信息窗体
                case "textBox_input_oper":
                    {
                        //判断当前页面的状态
                        if (dataType == DataType.Insert || dataType == DataType.Update)
                        {
                            StaffForm child = new StaffForm();
                            child.ShowDialog();
                            //获取员工信息
                            if (!child.staffName.Equals(string.Empty))
                            {
                                textBox_input_oper.Text = child.staffName;
                            }
                        }
                        break;

                    }
                //双击文本框弹出弹出员工信息窗体
                case "textBox_input_quality_persion":
                    {
                        //判断当前页面的状态
                        if (dataType == DataType.Insert || dataType == DataType.Update)
                        {
                            StaffForm child = new StaffForm();
                            child.ShowDialog();
                            //获取员工信息
                            if (!child.staffName.Equals(string.Empty))
                            {
                                textBox_input_quality_persion.Text = child.staffName;
                            }
                        }
                        break;
                    }
                //双击文本框弹出弹出员工信息窗体
                case "textBox_input_issued":
                    {
                        //判断当前页面的状态
                        if (dataType == DataType.Insert || dataType == DataType.Update)
                        {
                            StaffForm child = new StaffForm();
                            child.ShowDialog();
                            //获取员工信息
                            if (!child.staffName.Equals(string.Empty))
                            {
                                textBox_input_issued.Text = child.staffName;
                            }
                        }
                        break;
                    }
                //双击文本框弹出弹出员工信息窗体
                case "textBox_input_check_persion":
                    {
                        //判断当前页面的状态
                        if (dataType == DataType.Insert || dataType == DataType.Update)
                        {
                            StaffForm child = new StaffForm();
                            child.ShowDialog();
                            //获取员工信息
                            if (!child.staffName.Equals(string.Empty))
                            {
                                textBox_input_check_persion.Text = child.staffName;
                            }
                        }
                        break;
                    }
                //双击文本框弹出弹出供货商信息窗体
                case "textBox_supplier_name":
                    {
                        //判断当前页面的状态
                        if (dataType == DataType.Insert || dataType == DataType.Update)
                        {
                            supplierManageDialogForm child = new supplierManageDialogForm();
                            child.ShowDialog();
                            //获取供货商信息
                            if (!child.supplierName.Equals(string.Empty))
                            {
                                textBox_supplier_name.Text = child.supplierName;
                            }
                        }
                        break;
                    }
               
                //双击文本框弹出弹出货柜信息窗体
                case "textBox_counter_name":
                    {
                        //判断当前页面的状态
                        if (dataType == DataType.Insert || dataType == DataType.Update)
                        {
                            counterForm child = new counterForm();
                            child.ShowDialog();
                            //获取货柜信息
                            if (!child.counterCode.Equals(string.Empty))
                            {
                                textBox_counter_name.Text = child.counterCode;
                            }
                        }
                        break;
                    }
                default:
                    break;


            }
        }
        //***********************************************************************
        /// <summary>
        /// 添加按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/07/15 完成   
        ///    更新信息：吴小科      2010/07/21 修改
        /// </history>
        //***********************************************************************
        private void btnInsert_Click(object sender, EventArgs e)
        {
            comboBox_packing_out.SelectedIndex = 0;
            comboBox_packing_mid.SelectedIndex = 0;
            comboBox_packing_in.SelectedIndex = 0;
            dataType = DataType.Insert;
            setButtonState();
            textBox_goods_name.Focus();

        }
        //***********************************************************************
        /// <summary>
        /// 更新按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/07/15 完成   
        ///    更新信息：吴小科      2010/07/21 修改
        /// </history>
        //***********************************************************************
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //如果选择多条数据，提示
            if (dataGridView_input_storage.SelectedRows.Count > 1)
            {
                MessageBox.Show("只能选择一条要修改的记录！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //如过画面中不存在数据，提示
            if (dataGridView_input_storage.SelectedRows.Count < 1)
            {
                MessageBox.Show("只能选择一条要修改的记录！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //设置查询条件参数
            SearchParameter sp2 = new SearchParameter();
            sp2.SetValue(":input_type", '1');
            sp2.SetValue(":TC_INPUT_STORAGE.INPUT_CODE", textBox_input_code2.Text);
            //打开数据库
            dataAccess = new DataAccess();
            dataAccess.Open();
            //获取操作类
            GetData getData = new GetData(dataAccess.Connection);
            //返回绑定数据表
            DataTable dtCondition = getData.GetTableBySqlStr(Constants.SqlStr.TC_INPUT_INIT_STORAGE_LEFTJOIN_GOODS, sp2);
            if (dtCondition.Rows[0]["operate_type"].ToString() == "1")
            {
                MessageBox.Show("该入库单已被使用，不能修改！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("确认修改后，请重新添加不合格产品去向记录！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBox_goods_name.Focus();
            //获取原先数据和行号
            oldSTCount = Convert.ToInt32(dataGridView_input_storage.SelectedRows[0].Cells["input_standard_count"].Value.ToString());
            countNum = dataGridView_input_storage.SelectedRows[0].Index;
            dataType = DataType.Update;
            setButtonState();

        }
        //***********************************************************************
        /// <summary>
        /// 删除按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/07/15 完成   
        ///    更新信息：吴小科      2010/07/21 修改
        /// </history>
        //***********************************************************************
        private void btnDelete_Click(object sender, EventArgs e)
        {
            countNum = 0;
            //设置按钮状态
            dataType = DataType.None;
            setButtonState();
            //如果选择多条数据删除，提示
            if (dataGridView_input_storage.SelectedRows.Count > 1)
            {
                MessageBox.Show("只能选择一条要删除的记录！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //如果没有选择数据删除，提示
            if (dataGridView_input_storage.SelectedRows.Count < 1)
            {
                MessageBox.Show("请选择一条要删除的记录！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //设置查询条件参数
            SearchParameter sp2 = new SearchParameter();
            SearchParameter sp0 = new SearchParameter();
            sp0.SetValue(":TC_DISQUALIFICATION_MANAGE.INPUT_CODE", textBox_input_code2.Text);
            sp2.SetValue(":input_type", '1');
            sp2.SetValue(":TC_INPUT_STORAGE.INPUT_CODE", textBox_input_code2.Text);
            //打开数据库
            dataAccess = new DataAccess();
            dataAccess.Open();
            //获取操作类
            GetData getData = new GetData(dataAccess.Connection);
            //返回绑定数据表
            DataTable dtCondition = getData.GetTableBySqlStr(Constants.SqlStr.TC_INPUT_INIT_STORAGE_LEFTJOIN_GOODS, sp2);
            DataTable dtQualification = getData.GetTableBySqlStr(Constants.SqlStr.TC_DISQUALIFICATION_MANAGER, sp0);
            try
            {
                disqualificationCode = Convert.ToInt32(dtQualification.Rows[0]["DISQUALIFICATION_CODE"].ToString());
            }
            catch (Exception ex)
            {
                disqualificationCode = -1;
            }
            if (dtCondition.Rows[0]["operate_type"].ToString() == "1")
            {
                MessageBox.Show("该入库单已被使用，不能删除！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //如果选择数据删除，提示
            if (MessageBox.Show("您确定要删除该数据吗？", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                //取得实体类
                temp_storageEntity = new EntityTemp_storage();
                //赋值实体类
                temp_storageEntity.Count = 0- Convert.ToInt32(textBox_input_standard_count.Value);
               
                //设置删除条件参数
                SearchParameter sp = new SearchParameter();
                SearchParameter sp1 = new SearchParameter();
                SearchParameter sp3 = new SearchParameter();
                SearchParameter sp5 = new SearchParameter();
                //获得表的主健
                string input_code = dataGridView_input_storage.SelectedRows[0].Cells["input_code"].Value.ToString();
                //更新条件参数赋值
                sp1.SetValue(":goods_code", goods_code);
                sp3.SetValue(":input_code", input_code);
                sp5.SetValue(":disqualification_code", disqualificationCode);
                if (textBox_input_code2.Text != string.Empty)
                {
                    //删除条件参数赋值
                    sp.SetValue(":input_code", input_code);

                }
                try
                {
                    dataAccess = new DataAccess();
                    //打开数据库连接
                    dataAccess.Open();
                    //打开事务
                    dataAccess.BeginTransaction();
                    //取得操作类
                    GetData getData1 = new GetData(dataAccess.Connection, dataAccess.Transaction);
                    //取得结果符
                    result1 = getData1.DeleteRow("tc_input_storage", sp);
                    result2 = getData1.UpdateTemp_storage(temp_storageEntity, sp1);
                    result3 = getData1.DeleteRow("tc_disqualification_manage", sp3);
                    result5 = getData1.DeleteRow("tc_disqualification_to", sp5);
                    //提交事务
                    dataAccess.Commit();
                    //出现错误，提示信息
                    if (result1 == -1 || result2 == -1 || result3==-1||result5==-1)
                    {
                        MessageBox.Show("请查看数据库是否正常！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                }
                catch (Exception ex)
                {
                    //回滚
                    dataAccess.Rollback();
                    MessageBox.Show("请查看数据库是否正常！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                finally
                {
                    //成功删除
                    if (result1 == 0 || result2 == 0 || result3==0||result5==0)
                    {
                        MessageBox.Show("数据已经被成功删除！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BandingDgvCounter();
                    }
                    else
                    {
                        MessageBox.Show("请查看数据库是否正常！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }


                }
            }

        }
        //***********************************************************************
        /// <summary>
        /// 确定按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/07/16 完成   
        ///    更新信息：吴小科      2010/07/21 修改
        /// </history>
        //***********************************************************************
        private void btnCommit_Click(object sender, EventArgs e)
        {      
            foreach (Control control in groupBox2.Controls)
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
            ////结果符
            result1 = -1;
            input_storageEntity = new EntityInput_storage();
            input_storageEntity.INPUT_TYPE = '1';

            //判断该字段是否为空   
            if (textBox_goods_name.Text.Equals("双击选择一个产品..."))
            {
                MessageBox.Show("产品名称不能为空！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_goods_name.Focus();
                return;
            }
            else
            {
                input_storageEntity.INPUT_GOODS_CODE = goods_code;
            }
            if (textBox_supplier_name.Text.Equals("双击选择一个供货商..."))
            {
                MessageBox.Show("供货商不能为空！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_supplier_name.Focus();
                return;
            }
          
            if (comboBox_packing_out.Text.Equals("请选择一种包装情况"))
            {
                MessageBox.Show("请重新选择包装情况(外)", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBox_packing_out.Focus();
                return;
            }
            if (textBox_counter_name.Text.Equals("双击选择一个货位..."))
            {
                MessageBox.Show("货位不能为空！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_counter_name.Focus();
                return;
            }

           
            if (comboBox_packing_mid.Text.Equals("请选择一种包装情况"))
            {
                MessageBox.Show("请重新选择包装情况(中)", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBox_packing_mid.Focus();
                return;
            }
            if (textBox_input_batch_num.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("批号/设备号不能为空！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_input_batch_num.Focus();
                return;
            }
            if (comboBox_packing_in.Text.Equals("请选择一种包装情况"))
            {
                MessageBox.Show("请重新选择包装情况(内)", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBox_packing_in.Focus();
                return;
            }
            //判断文本框是否为空
            if (textBox_input_oper.Text.Equals("双击选择一个业务员..."))
            {
                MessageBox.Show("业务员不能为空！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_input_oper.Focus();
                return;
            }
            if (textBox_input_quality_persion.Text.Equals("双击选择一个质管员..."))
            {
                MessageBox.Show("质管员不能为空！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_input_quality_persion.Focus();
                return;
            }
            if (textBox_input_check_persion.Text.Equals("双击选择一个验收人..."))
            {
                MessageBox.Show("验收人不能为空！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_input_check_persion.Focus();
                return;
            }
            if (textBox_input_issued.Text.Equals("双击选择一个审核人..."))
            {
                MessageBox.Show("审核人不能为空！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_input_issued.Focus();
                return;
            }
          
            if (Convert.ToInt32(textBox_input_arrival_count.Value) == 0)
            {
                MessageBox.Show("到货数量不能为0，请重新输入！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_input_arrival_count.Focus();
                return;
            }
            if (textBox_input_arrival_count.Text == "")
            {
                MessageBox.Show("到货数量不能为空，请重新输入！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_input_arrival_count.Focus();
                return;
 
            }
            input_storageEntity.INPUT_ARRIVAL_COUNT = Convert.ToInt32(textBox_input_arrival_count.Value);
            input_storageEntity.INPUT_STANDARD_COUNT = Convert.ToInt32(textBox_input_standard_count.Value);
            if (input_storageEntity.INPUT_STANDARD_COUNT > input_storageEntity.INPUT_ARRIVAL_COUNT)
            {
                MessageBox.Show("合格数量不能大于到货数量，请核对后重新输入！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_input_standard_count.Focus();
                return;
            }
            if (textBox_input_standard_count.Text == "")
            {
                MessageBox.Show("合格数量不能为空，请重新输入！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_input_standard_count.Focus();
                return;

            }   
                  
            //判断时间有效性
            if (dataTime_input_maketime.Value.Date > dateTime_input_instorage_date.Value.Date)
            {
                MessageBox.Show("生产日期不可大于入库日期", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataTime_input_maketime.Focus();
                return;
            }
            //判断数据的有效性
            if (dateTime_input_instorage_date.Value.Date > dateTime_input_checktime.Value.Date)
            {
                MessageBox.Show("入库日期不可大于验收日期", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateTime_input_instorage_date.Focus();
                return;
            }
            //判断数据的有效性
            if (DateTime.Now.Date < dateTime_input_checktime.Value.Date)
            {
                MessageBox.Show("验收日期不可大于今天", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateTime_input_checktime.Focus();
                return;

            }
            input_storageEntity.INPUT_MAKETIME = dataTime_input_maketime.Value.Date;
            input_storageEntity.INPUT_INSTORAGE_DATE = dateTime_input_instorage_date.Value.Date;
            input_storageEntity.INPUT_CHECKTIME = dateTime_input_checktime.Value.Date;
            //实体类赋值
            input_storageEntity.SUPPLIER_NAME = textBox_supplier_name.Text;
            input_storageEntity.INPUT_ISSUED = textBox_input_issued.Text;
            input_storageEntity.INPUT_CHECK_PERSION = textBox_input_check_persion.Text;
            input_storageEntity.COUNTER_NAME = textBox_counter_name.Text;
            input_storageEntity.INPUT_OPER = textBox_input_oper.Text;
            input_storageEntity.INPUT_QUALITY_PERSION = textBox_input_quality_persion.Text;
            //实体类赋值
            input_storageEntity.INPUT_QUALITY_REG = textBox_input_quality_reg.Text;
            input_storageEntity.INPUT_PACKING_OUT = comboBox_packing_out.Text;
            input_storageEntity.INPUT_PACKING_MID = comboBox_packing_mid.Text;
            input_storageEntity.INPUT_PACKING_IN = comboBox_packing_in.Text;
            input_storageEntity.INPUT_REMARK = textBox_input_remark.Text;
            input_storageEntity.INPUT_BATCH_NUM = textBox_input_batch_num.Text;
            input_storageEntity.QUALITY_INFO = textBox_quality_info.Text;
            input_storageEntity.CHECK_INFO = textBox_check_info.Text;
            //增加操作
            if (dataType == DataType.Insert)
            {   
                //取得实体类
                temp_storageEntity = new EntityTemp_storage();
                disqualificationEntity = new EntityDisqualification();
                //赋值实体类
                temp_storageEntity.Count = Convert.ToInt32(textBox_input_standard_count.Value);
                SearchParameter sp = new SearchParameter();
                //更新条件参数赋值
                sp.SetValue(":goods_code", goods_code);
                disCount = input_storageEntity.INPUT_ARRIVAL_COUNT - input_storageEntity.INPUT_STANDARD_COUNT;
                if (disCount > 0)
                {
                    DialogResult result = MessageBox.Show("合格数量与到货数量不一致，其中不合格产品有：" + disCount.ToString() + "，您确定添加吗？", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                   if (result == DialogResult.Cancel)
                   {
                       return;
                   }
                }
                disqualificationEntity.Deal_Count = 0;
                disqualificationEntity.Disqualification_Count = disCount;
                disqualificationEntity.Undeal_Count = disCount;
                try
                {
                    //打开数据库连接
                    dataAccess = new DataAccess();
                    dataAccess.Open();
                    //取得操作类
                    GetData getData = new GetData(dataAccess.Connection);
                    MakePrimaryKey key = new MakePrimaryKey(dataAccess.Connection, dataAccess.Transaction);
                    input_storageEntity.INPUT_CODE = key.MakeCode("入库");
                    disqualificationEntity.Input_Code = input_storageEntity.INPUT_CODE;
                    //取得结果符
                    result1 = getData.InsertInput_storageRow(input_storageEntity);
                    result2 = getData.UpdateTemp_storage(temp_storageEntity, sp);
                    if (disCount != 0)
                    {
                        result3 = getData.InsertDisqualification_Manager(disqualificationEntity);
                    }
                    if (disCount == 0)
                    {
                        editFlag = 1;
                    }
                    MessageBox.Show("数据已经保存成功！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisqualificationManageForm disload = new DisqualificationManageForm();
                    disload.DataBanding();
                }
                catch (Exception ex)
                {
                    //提示错误
                    MessageBox.Show("操作数据时发生错误，请检查数据库是否正常开启！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                finally
                {
                    //关闭数据库连接
                    dataAccess.Close();

                    //设置按钮状态
                    dataType = DataType.None;
                    setButtonState();

                    //重新加载画面
                    BandingDgvCounter();
                }
          
            }
            //修改操作
            else if (dataType == DataType.Update)
            {
                
                input_storageEntity.INPUT_CODE = textBox_input_code2.Text;
                //取得实体类
                temp_storageEntity = new EntityTemp_storage();
                disqualificationEntity = new EntityDisqualification();
                //赋值实体类
                temp_storageEntity.Count = Convert.ToInt32(textBox_input_standard_count.Value)-oldSTCount;
                disCount = input_storageEntity.INPUT_ARRIVAL_COUNT - input_storageEntity.INPUT_STANDARD_COUNT;
                if (disCount > 0)
                {
                    DialogResult result = MessageBox.Show("点击确定后将修改入库记录，其中不合格产品有：" + disCount.ToString() + ",您确定修改该条记录吗？", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Cancel)
                    {
                        return;
                    }
                }
                disqualificationEntity.Deal_Count = 0;
                disqualificationEntity.Disqualification_Count = disCount;
                disqualificationEntity.Undeal_Count = disCount;
                disqualificationEntity.Input_Code = textBox_input_code2.Text;
                //设置更新条件参数
                SearchParameter sp = new SearchParameter();
                SearchParameter sp1 = new SearchParameter();
                SearchParameter sp2 = new SearchParameter();
                SearchParameter sp3 = new SearchParameter();
                //更新条件参数赋值
                sp.SetValue(":goods_code", goods_code);
                sp1.SetValue(":input_code", input_storageEntity.INPUT_CODE);
                sp2.SetValue(":tc_disqualification_manage.input_code", disqualificationEntity.Input_Code);
                try
                {
                    //打开数据库连接
                    dataAccess = new DataAccess();
                    dataAccess.Open();
                    //打开事务
                    dataAccess.BeginTransaction();

                    GetData getData1 = new GetData(dataAccess.Connection, dataAccess.Transaction);
                    DataTable dtQualification = getData1.GetTableBySqlStr(Constants.SqlStr.TC_DISQUALIFICATION_MANAGER, sp2);
                    try
                    {
                        disqualificationCode = Convert.ToInt32(dtQualification.Rows[0]["DISQUALIFICATION_CODE"].ToString());
                    }
                    catch(Exception ex)
                    {
                        disqualificationCode = 0;
                    }
                    sp3.SetValue(":disqualification_code", disqualificationCode);
                    //取得结果符
                    result1 = getData1.UpdateInput_storageRow(input_storageEntity, sp1);
                    result2 = getData1.UpdateTemp_storage(temp_storageEntity, sp);
                    if (disCount != 0)
                    {
                        if (editFlag == 0)
                        {
                            result3 = getData1.UpdateDisqualification_manage(disqualificationEntity, sp2);
                            result5 = getData1.DeleteRow("tc_disqualification_to", sp3);
                        }
                        if (editFlag == 1)
                        {
                            editFlag = 0;
                            result3 = getData1.InsertDisqualification_Manager(disqualificationEntity);
                            result5 = getData1.DeleteRow("tc_disqualification_to", sp3);
 
                        }
                    }
                    if (disCount == 0)
                    {
                        editFlag = 1;
                        result3 = getData1.DeleteRow("tc_disqualification_manage",sp2);
                        result5 = getData1.DeleteRow("tc_disqualification_to", sp3);
                    }
                    //提交事务
                    dataAccess.Commit();
                    MessageBox.Show("数据已经保存成功！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisqualificationManageForm disload = new DisqualificationManageForm();
                    disload.DataBanding();
                }
                catch (Exception ex)
                {

                    if (dataAccess.Transaction != null)
                    {

                        //回滚
                        dataAccess.Rollback();
                    }

                    //提示错误
                    MessageBox.Show("操作数据时发生错误，请检查数据库是否正常开启！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                finally
                {
                    //关闭数据库连接
                    dataAccess.Close();

                    //设置按钮状态
                    dataType = DataType.None;
                    setButtonState();

                    //重新加载画面
                    BandingDgvCounter();
                }
 
            }
           
            //设置按钮状态
            dataType = DataType.None;
            setButtonState();
            dataGridView_input_storage.Focus();
        }
        
        //***********************************************************************
        /// <summary>
        /// 查询按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/07/16 完成   
        ///    更新信息：吴小科      2010/07/21 修改
        /// </history>
        //***********************************************************************
        private void btnSearch_Click(object sender, EventArgs e)
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
            try
            {
                //设置查询条件参数
                SearchParameter sp = new SearchParameter();
                sp.SetValue(":input_type", '1');
                //判断文本框是否为空
                if (textBox_input_code.Text.Trim() != string.Empty)
                {   //查询条件参数赋值
                    sp.SetValue(":TC_INPUT_STORAGE.INPUT_CODE",textBox_input_code.Text);
                }
                if (textBox_supplierName.Text.Trim() != string.Empty)
                {
                    sp.SetValue(":TC_GOODS.GOODS_NAME", textBox_supplierName.Text);

                }
                //判断文本框是否为空
                if (!textBox_goods_yxm.Text.Trim().Equals(string.Empty))
                {

                    sp.SetValue(":TC_GOODS.GOODS_YXM", textBox_goods_yxm.Text);
                }
                //打开数据库
                dataAccess = new DataAccess();
                dataAccess.Open();
                //获取操作类
                GetData getData = new GetData(dataAccess.Connection);
                //返回绑定数据表
                DataTable dtCondition = getData.GetTableBySqlStr(Constants.SqlStr.TC_INPUT_INIT_STORAGE_LEFTJOIN_GOODS, sp);
                if (dtCondition == null)
                {
                    MessageBox.Show("请查看数据库是否正常！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //添加序列号
                int countNumber = 0;
                dtCondition.Columns.Add("num", typeof(int));
                for (int i = 0; i < dtCondition.Rows.Count; i++)
                {
                    dtCondition.Rows[i]["num"] = ++countNumber;

                }
                //绑定数据
                dataGridView_input_storage.DataSource = dtCondition;

                if (dtCondition.Rows.Count == 0)
                {
                    dataGridClear();
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
        /// 取消按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/07/15 完成   
        ///    更新信息：吴小科      2010/07/21 修改
        /// </history>
        //***********************************************************************
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //按钮状态
            dataType = DataType.None;
            setButtonState();
            //判断画面数据不为空
            if (dataGridView_input_storage != null && dataGridView_input_storage.SelectedRows.Count != 0)
            {   //取得数据赋值文本框
                textBox_input_code2.Text = dataGridView_input_storage.SelectedRows[0].Cells["input_code"].Value.ToString();
                textBox_goods_name.Text = dataGridView_input_storage.SelectedRows[0].Cells["goods_name"].Value.ToString();
                textBox_input_arrival_count.Value = Convert.ToInt32(dataGridView_input_storage.SelectedRows[0].Cells["input_arrival_count"].Value.ToString());
                textBox_counter_name.Text = dataGridView_input_storage.SelectedRows[0].Cells["counter_name"].Value.ToString();
                dataTime_input_maketime.Value = DateTime.Parse(dataGridView_input_storage.SelectedRows[0].Cells["input_maketime"].Value.ToString());
                dateTime_input_instorage_date.Value = DateTime.Parse(dataGridView_input_storage.SelectedRows[0].Cells["input_instorage_date"].Value.ToString());
                dateTime_input_checktime.Value = DateTime.Parse(dataGridView_input_storage.SelectedRows[0].Cells["input_checktime"].Value.ToString());
                textBox_input_oper.Text = dataGridView_input_storage.SelectedRows[0].Cells["input_oper"].Value.ToString();
                textBox_input_quality_reg.Text = dataGridView_input_storage.SelectedRows[0].Cells["input_quality_reg"].Value.ToString();
                textBox_supplier_name.Text = dataGridView_input_storage.SelectedRows[0].Cells["supplier_name"].Value.ToString();
                textBox_input_quality_persion.Text = dataGridView_input_storage.SelectedRows[0].Cells["input_quality_persion"].Value.ToString();
                textBox_input_remark.Text = dataGridView_input_storage.SelectedRows[0].Cells["input_remark"].Value.ToString();
                comboBox_packing_out.Text = dataGridView_input_storage.SelectedRows[0].Cells["input_packing_out"].Value.ToString();
                comboBox_packing_mid.Text = dataGridView_input_storage.SelectedRows[0].Cells["input_packing_mid"].Value.ToString();
                comboBox_packing_in.Text = dataGridView_input_storage.SelectedRows[0].Cells["input_packing_in"].Value.ToString();
                textBox_supplier_name.Text = dataGridView_input_storage.SelectedRows[0].Cells["supplier_name"].Value.ToString();
                textBox_input_standard_count.Value = Convert.ToInt32(dataGridView_input_storage.SelectedRows[0].Cells["input_standard_count"].Value.ToString());
                textBox_input_check_persion.Text = dataGridView_input_storage.SelectedRows[0].Cells["input_check_persion"].Value.ToString();
                textBox_input_issued.Text = dataGridView_input_storage.SelectedRows[0].Cells["input_issued"].Value.ToString();
                textBox_input_batch_num.Text = dataGridView_input_storage.SelectedRows[0].Cells["input_batch_num"].Value.ToString();
                textBox_quality_info.Text = dataGridView_input_storage.SelectedRows[0].Cells["quality_info"].Value.ToString();
                textBox_check_info.Text = dataGridView_input_storage.SelectedRows[0].Cells["check_info"].Value.ToString();
            }
            else
            {
                textBox_input_code2.Text = "";
                textBox_goods_name.Text = "";
                textBox_input_arrival_count.Value = 0;
                textBox_counter_name.Text = "";
                dataTime_input_maketime.Value = DateTime.Now.Date;
                dateTime_input_instorage_date.Value = DateTime.Now.Date;
                dateTime_input_checktime.Value = DateTime.Now.Date;
                textBox_input_oper.Text = "";
                textBox_input_quality_reg.Text = "";
                textBox_supplier_name.Text = "";
                textBox_input_quality_persion.Text = "";
                textBox_input_remark.Text = "";
                comboBox_packing_out.Text = "";
                comboBox_packing_mid.Text = "";
                comboBox_packing_in.Text = "";
                textBox_supplier_name.Text = "";
                textBox_input_standard_count.Value = 0;
                textBox_input_check_persion.Text = "";
                textBox_input_issued.Text = "";
                textBox_input_batch_num.Text = "";
                textBox_quality_info.Text = "";
                textBox_check_info.Text = "";
            }

            dataGridView_input_storage.Focus();
        }
        //***********************************************************************
        /// <summary>
        /// 重置按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/08/09 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnReset_Click(object sender, EventArgs e)
        {
            textBox_input_code.Text = "";
            textBox_supplierName.Text = "";
            textBox_goods_yxm.Text = "";

        }
        //***********************************************************************
        /// <summary>
        /// 数量验证
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/09/03 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void textBox_input_arrival_count_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox_input_arrival_count.Value.ToString().Length > 4)
            {
                textBox_input_arrival_count.Value = 9999;

            }

        }

        private void textBox_input_standard_count_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox_input_standard_count.Value.ToString().Length > 4)
            {
                textBox_input_standard_count.Value = 9999;

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
        private void dataGridView_input_storage_Sorted(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView_input_storage.Rows.Count; i++)
            {
                dataGridView_input_storage.Rows[i].Cells["num"].Value = i + 1;
            }

        }

      
    }
}
