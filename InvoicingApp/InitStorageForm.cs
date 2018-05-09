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
//* 功能画面		：  初始化入库管理
//* 画面名称	    ：  InitStorageForm
//* 完成年月日      ：  2010/07/14
//* 作者		    ：  吴小科
//* Version		    ：  1.00
//* ---------------------------------------------------------------------
//* 前提		：SQL SERVER,.NetFramework3.0
//***********************************************************************


namespace InvoicingApp
{
    //***********************************************************************
    /// <summary>
    ///初始化入库管理功能
    /// </summary>
    /// <history>
    ///     完成信息：吴小科      2010/07/13 完成  
    ///     更新信息：吴小科      2010/07/20 修改 
    /// </history>
    //***********************************************************************
    public partial class InitStorageForm : Form
    {
        /// <summary>
        /// 产品信息初始化 
        /// </summary>
        public string goods_code = string.Empty;
        public string goodsMaker = string.Empty;
        /// <summary>
        /// 数量标识
        /// </summary>
        public int oldCount;

        /// <summary>
        /// 选择记录的行号
        /// </summary>
        int countNum = 0;
        /// <summary>
        /// 数据库连接句柄
        /// </summary>
        DataAccess dataAccess = null;
        /// <summary>
        /// 画面状态
        /// </summary>
        DataType dataType = DataType.None;
        /// <summary>
        /// 返回状态标记
        /// </summary>

        int result1 = -1;
        int result2 = -1;
        /// <summary>
        /// 入库实体类
        /// </summary>
        EntityInput_storage input_storageEntity = null;
        /// <summary>
        /// 临时库存实体类
        /// </summary>
        EntityTemp_storage temp_storageEntity = null;
        public InitStorageForm()
        {
            InitializeComponent();
            this.dataGridView_input_storage.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(239, 243, 251);
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
            /// 插入
            /// </summary>
            Insert = 0x0002,
            /// <summary>
            /// 默认
            /// </summary>
            None = 0x0003

        }
        //*******************************************************************
        /// <summary>
        /// 设置按钮，文本框状态
        /// </summary>
        /// <history>
        ///     完成信息：吴小科      2010/07/13 完成   
        ///     更新信息：
        /// </history>
        //*******************************************************************
        private void SetButtonState()
        {

            switch (dataType)
            {
                case DataType.None:

                    textBox_input_code2.ReadOnly = true;
                    dataTime_input_maketime.Enabled = false;
                    dateTime_input_instorage_date.Enabled = false;
                    textBox_input_quality_reg.ReadOnly = true;
                    textBox_input_remark.ReadOnly = true;
                    textBox_input_standard_count.Enabled = false;
                    textBox_input_batch_num.ReadOnly = true;
                    comboBox_packing_out.Enabled = false;
                    comboBox_packing_mid.Enabled = false;
                    comboBox_packing_in.Enabled = false;
                    textBox_goods_name.BackColor = Color.FromArgb(236, 233, 216);
                    textBox_counter_name.BackColor = Color.FromArgb(236, 233, 216);
                    textBox_input_quality_persion.BackColor = Color.FromArgb(236, 233, 216);
                    textBox_input_oper.BackColor = Color.FromArgb(236, 233, 216);
                    textBox_supplier_name.BackColor = Color.FromArgb(236, 233, 216);
                    btnInsert.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnCommit.Enabled = false;
                    btnCancel.Enabled = false;
                    
                    break;
                case DataType.Insert:
                    textBox_input_code2.ReadOnly = true;
                    dataTime_input_maketime.Enabled = true;
                    dateTime_input_instorage_date.Enabled = true;
                    textBox_input_quality_reg.ReadOnly = false;
                    textBox_input_remark.ReadOnly = false;
                    textBox_input_standard_count.Enabled = true;
                    textBox_input_batch_num.ReadOnly = false;
                    comboBox_packing_out.Enabled = true;
                    comboBox_packing_mid.Enabled = true;
                    comboBox_packing_in.Enabled = true;
                    textBox_input_code2.Text = "";
                    textBox_input_quality_reg.Text = "";
                    textBox_input_remark.Text = "";
                    textBox_input_standard_count.Value = 0;

                    textBox_goods_name.Text = "双击选择一个产品...";
                    textBox_goods_name.BackColor = Color.FromArgb(255, 255, 255);

                    textBox_input_quality_persion.Text = "双击此处一个质管员...";
                    textBox_input_quality_persion.BackColor = Color.FromArgb(255, 255, 255);
                    textBox_input_oper.Text = "双击选择一个业务员...";
                    textBox_input_oper.BackColor = Color.FromArgb(255, 255, 255);
                    textBox_input_batch_num.Text = "";
                    textBox_counter_name.Text = "双击选择一个货位...";
                    textBox_counter_name.BackColor = Color.FromArgb(255, 255, 255);
                    textBox_supplier_name.Text = "双击选择一个供货商...";
                    textBox_supplier_name.BackColor = Color.FromArgb(255, 255, 255);
                    dataTime_input_maketime.Value = DateTime.Now;
                    dateTime_input_instorage_date.Value = DateTime.Now;

                    btnInsert.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnCommit.Enabled = true;
                    btnCancel.Enabled = true;
                    textBox_goods_name.Focus();
                    break;
                case DataType.Update:
                    textBox_input_code2.ReadOnly = true;
                    dataTime_input_maketime.Enabled = true;
                    dateTime_input_instorage_date.Enabled = true;
                    textBox_input_quality_reg.ReadOnly = false;
                    textBox_input_remark.ReadOnly = false;
                    textBox_input_standard_count.Enabled = true;
                    textBox_input_batch_num.ReadOnly = false;
                    comboBox_packing_out.Enabled = true;
                    comboBox_packing_mid.Enabled = true;
                    comboBox_packing_in.Enabled = true;
                    textBox_input_quality_persion.BackColor = Color.FromArgb(255, 255, 255);
                    textBox_input_oper.BackColor = Color.FromArgb(255, 255, 255);
                    textBox_counter_name.BackColor = Color.FromArgb(255, 255, 255);
                    textBox_supplier_name.BackColor = Color.FromArgb(255, 255, 255);
                    btnInsert.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnCommit.Enabled = true;
                    btnCancel.Enabled = true;
                    textBox_goods_name.Focus();
                    break;

                default:
                    textBox_goods_name.BackColor = Color.FromArgb(236, 233, 216);
                    textBox_counter_name.BackColor = Color.FromArgb(236, 233, 216);
                    textBox_input_quality_persion.BackColor = Color.FromArgb(236, 233, 216);
                    textBox_input_oper.BackColor = Color.FromArgb(236, 233, 216);
                    textBox_supplier_name.BackColor = Color.FromArgb(236, 233, 216);
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
        /// 双击文本框弹出不同的选择窗体
        /// </summary>
        /// <history>
        ///     完成信息：吴小科      2010/07/13 完成   
        ///     更新信息：
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
                                goods_code = goodInfo.goodsCode;
                                textBox_goods_name.Text = goodInfo.goodsName;
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
                            counterForm counter = new counterForm();
                            counter.ShowDialog();
                            //获取货柜信息
                            if (!counter.counterCode.Equals(string.Empty))
                            {
                                textBox_counter_name.Text = counter.counterCode;
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
            textBox_input_code2.Text = "";
            textBox_goods_name.Text = "";
            textBox_input_standard_count.Value = 0;
            textBox_counter_name.Text = "";
            dataTime_input_maketime.Value = DateTime.Now.Date;
            dateTime_input_instorage_date.Value = DateTime.Now.Date;
            textBox_input_oper.Text = "";
            textBox_input_quality_reg.Text = "";
            textBox_input_quality_persion.Text = "";
            textBox_input_remark.Text = "";
            textBox_input_batch_num.Text = "";
            textBox_supplier_name.Text = "";
            comboBox_packing_out.SelectedIndex = 0;
            comboBox_packing_mid.SelectedIndex = 0;
            comboBox_packing_in.SelectedIndex = 0;
 
        }

        //*******************************************************************
        /// <summary>
        /// 入库页面初始化
        /// </summary>
        /// <history>
        ///     完成信息：吴小科      2010/07/13 完成   
        ///     更新信息：
        /// </history>
        //*******************************************************************
        private void InitStorageForm_Load(object sender, EventArgs e)
        {
            try
            {
                //打开数据库
                dataAccess = new DataAccess();
                dataAccess.Open();
                //获取操作类
                GetData getData = new GetData(dataAccess.Connection);
                //设置加载条件
                SearchParameter sp = new SearchParameter();
                sp.SetValue(":input_type", '0');
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
                }
                //设定按钮状态
                SetButtonState();
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
        /// 选择画面数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/07/13 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void dataGridView_input_storage_SelectionChanged(object sender, EventArgs e)
        {   //按钮状态
            dataType = DataType.None;
            SetButtonState();
            //判断画面数据不为空
            if (dataGridView_input_storage != null && dataGridView_input_storage.SelectedRows.Count != 0)
            {
                //取得数据赋值文本框
                goods_code = dataGridView_input_storage.SelectedRows[0].Cells["input_goods_code"].Value.ToString();
                textBox_input_code2.Text = dataGridView_input_storage.SelectedRows[0].Cells["input_code"].Value.ToString();
                textBox_goods_name.Text = dataGridView_input_storage.SelectedRows[0].Cells["goods_name"].Value.ToString();
                textBox_input_standard_count.Value = Convert.ToInt32(dataGridView_input_storage.SelectedRows[0].Cells["input_standard_count"].Value.ToString());
                textBox_counter_name.Text = dataGridView_input_storage.SelectedRows[0].Cells["counter_code"].Value.ToString();
                dataTime_input_maketime.Value = DateTime.Parse(dataGridView_input_storage.SelectedRows[0].Cells["input_maketime"].Value.ToString());
                dateTime_input_instorage_date.Value = DateTime.Parse(dataGridView_input_storage.SelectedRows[0].Cells["input_instorage_date"].Value.ToString());
                textBox_input_oper.Text = dataGridView_input_storage.SelectedRows[0].Cells["input_oper"].Value.ToString();
                textBox_input_quality_reg.Text = dataGridView_input_storage.SelectedRows[0].Cells["input_quality_reg"].Value.ToString();
                goods_code = dataGridView_input_storage.SelectedRows[0].Cells["input_goods_code"].Value.ToString();
                textBox_input_quality_persion.Text = dataGridView_input_storage.SelectedRows[0].Cells["input_quality_persion"].Value.ToString();
                textBox_input_remark.Text = dataGridView_input_storage.SelectedRows[0].Cells["input_remark"].Value.ToString();
                textBox_input_batch_num.Text = dataGridView_input_storage.SelectedRows[0].Cells["input_batch_num"].Value.ToString();
                textBox_supplier_name.Text = dataGridView_input_storage.SelectedRows[0].Cells["supplier_name"].Value.ToString();
                comboBox_packing_out.Text = dataGridView_input_storage.SelectedRows[0].Cells["input_packing_out"].Value.ToString();
                comboBox_packing_mid.Text = dataGridView_input_storage.SelectedRows[0].Cells["input_packing_mid"].Value.ToString();
                comboBox_packing_in.Text = dataGridView_input_storage.SelectedRows[0].Cells["input_packing_in"].Value.ToString();

            }


        }
        //***********************************************************************
        /// <summary>
        /// 添加按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/07/13 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************

        private void btnInsert_Click(object sender, EventArgs e)
        {
            comboBox_packing_mid.SelectedIndex = 0;
            comboBox_packing_out.SelectedIndex = 0;
            comboBox_packing_in.SelectedIndex = 0;
            dataType = DataType.Insert;
            SetButtonState();
        }
        //***********************************************************************
        /// <summary>
        /// 更新按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/07/13 完成   
        ///    更新信息：
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
                MessageBox.Show("请选择一条要修改的记录！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //设置查询条件参数
            SearchParameter sp2 = new SearchParameter();
            sp2.SetValue(":TC_INPUT_STORAGE.INPUT_TYPE", '0');
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
                MessageBox.Show("该入库单已经存在销售或报损记录，不能修改或删除！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //获取原先数据和行号
            oldCount = Convert.ToInt32(dataGridView_input_storage.SelectedRows[0].Cells["input_standard_count"].Value.ToString());
            countNum = dataGridView_input_storage.SelectedRows[0].Index;
            dataType = DataType.Update;
            SetButtonState();
        }
        //***********************************************************************
        /// <summary>
        /// 删除按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/07/13 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************


        private void btnDelete_Click(object sender, EventArgs e)
        {
            //设置按钮状态
            countNum = 0;
            dataType = DataType.None;
            SetButtonState();
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
            sp2.SetValue(":TC_INPUT_STORAGE.INPUT_TYPE", '0');
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
                MessageBox.Show("该入库单已经存在销售或报损记录，不能修改或删除！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //如果选择数据删除，提示
            if (MessageBox.Show("您确定要删除该数据吗？", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                //取得实体类
                temp_storageEntity = new EntityTemp_storage();
                //赋值实体类
                temp_storageEntity.Count = 0 - Convert.ToInt32(textBox_input_standard_count.Value);
                SearchParameter sp1 = new SearchParameter();
                sp1.SetValue(":goods_code", goods_code);
                try
                {
                    //设置删除条件参数
                    SearchParameter sp = new SearchParameter();

                    //获得表的主健
                    string input_code = dataGridView_input_storage.SelectedRows[0].Cells["input_code"].Value.ToString();

                    if (textBox_input_code2.Text != string.Empty)
                    {
                        //删除条件参数赋值
                        sp.SetValue(":input_code", input_code);
                    }

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
                    //提交事务
                    dataAccess.Commit();
                    //出现错误，提示信息
                    if (result1 == -1 || result2 == -1)
                    {
                        MessageBox.Show("操作数据时发生错误，请检查数据库是否正常开启！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                }
                catch (Exception ex)
                {
                    //回滚
                    dataAccess.Rollback();
                    MessageBox.Show("操作数据时发生错误，请检查数据库是否正常开启！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    //关闭数据库连接
                    dataAccess.Close();
                }
                //判断结果符，0：成功；-1：失败
                if (result1 == 0 || result2 == 0)
                {

                    //加载画面
                    BandingDgvCounter();
                    MessageBox.Show("数据已经被成功删除！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("操作数据时发生错误，请检查数据库是否正常开启！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //***********************************************************************
        /// <summary>
        /// 更新按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/07/14 完成   
        ///    更新信息：
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
            //结果符
            result1 = -1;
            //取得实体类
            input_storageEntity = new EntityInput_storage();
            //判断该字段是否为空   
            if (textBox_goods_name.Text.Equals("双击选择一个产品..."))
            {
                MessageBox.Show("产品名称不能为空", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_goods_name.Focus();
                return;
            }
            //赋值实体类
            input_storageEntity.INPUT_GOODS_CODE = goods_code;
            //判断该字段是否为空
            if (textBox_input_standard_count.Value == 0)
            {
                MessageBox.Show("数量不能为0，请重新输入！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_input_standard_count.Focus();
                return;
            }
            if (textBox_input_standard_count.Text == "")
            {
                MessageBox.Show("数量不能为空，请重新输入！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_input_standard_count.Focus();
                return;
 
            }
            input_storageEntity.INPUT_STANDARD_COUNT = (int)textBox_input_standard_count.Value;
            input_storageEntity.INPUT_ARRIVAL_COUNT = (int)textBox_input_standard_count.Value;
            //判断时间有效性
            if (dataTime_input_maketime.Value.Date > dateTime_input_instorage_date.Value.Date)
            {
                MessageBox.Show("生产日期不可大于入库日期", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataTime_input_maketime.Focus();
                return;
            }
            //判断时间有效性
            if (DateTime.Now.Date < dateTime_input_instorage_date.Value.Date)
            {
                MessageBox.Show("入库时间不可大于今天", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateTime_input_instorage_date.Focus();
                return;
            }
            input_storageEntity.INPUT_MAKETIME = dataTime_input_maketime.Value.Date;
            input_storageEntity.INPUT_INSTORAGE_DATE = dateTime_input_instorage_date.Value.Date;
            //判断该字段是否为空
            if (textBox_counter_name.Text.Equals("双击选择一个货位..."))
            {
                MessageBox.Show("货位不能为空！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_counter_name.Focus();
                return;
            }
            if (textBox_input_oper.Text.Equals("双击选择一个业务员..."))
            {
                MessageBox.Show("业务员不能为空！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_input_oper.Focus();
                return;

            }
            if (textBox_input_quality_persion.Text.Equals("双击此处一个质管员..."))
            {
                MessageBox.Show("质管员不能为空！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_input_quality_persion.Focus();
                return;
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
            if (comboBox_packing_mid.Text.Equals("请选择一种包装情况"))
            {
                MessageBox.Show("请重新选择包装情况(中)", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBox_packing_mid.Focus();
                return;
            }
            if (comboBox_packing_in.Text.Equals("请选择一种包装情况"))
            {
                MessageBox.Show("请重新选择一种包装情况(内)", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboBox_packing_in.Focus();
                return;
            }
            if (textBox_input_batch_num.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("批号/设备号不能为空！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_input_batch_num.Focus();
                return;
            }
            input_storageEntity.INPUT_PACKING_OUT = comboBox_packing_out.Text;
            input_storageEntity.INPUT_PACKING_MID = comboBox_packing_mid.Text;
            input_storageEntity.INPUT_PACKING_IN = comboBox_packing_in.Text;
            input_storageEntity.INPUT_REMARK = textBox_input_remark.Text;
            input_storageEntity.INPUT_BATCH_NUM = textBox_input_batch_num.Text;
            input_storageEntity.SUPPLIER_NAME = textBox_supplier_name.Text;
            input_storageEntity.COUNTER_NAME = textBox_counter_name.Text;
            input_storageEntity.INPUT_OPER = textBox_input_oper.Text;
            input_storageEntity.INPUT_QUALITY_PERSION = textBox_input_quality_persion.Text;
            //实体类赋值
            input_storageEntity.INPUT_QUALITY_REG = textBox_input_quality_reg.Text;
            input_storageEntity.INPUT_REMARK = textBox_input_remark.Text;

            //增加操作
            if (dataType == DataType.Insert)
            {
                SearchParameter sp = new SearchParameter();
                //更新条件参数赋值
                sp.SetValue(":goods_code", goods_code);
                //取得实体类
                temp_storageEntity = new EntityTemp_storage();
                //赋值实体类
                temp_storageEntity.Count = (int)textBox_input_standard_count.Value;
                try
                {
                    //打开数据库连接
                    dataAccess = new DataAccess();
                    dataAccess.Open();

                    //取得操作类
                    GetData getData1 = new GetData(dataAccess.Connection);
                    MakePrimaryKey key = new MakePrimaryKey(dataAccess.Connection, dataAccess.Transaction);
                    input_storageEntity.INPUT_CODE = key.MakeCode("入库");
                    //取得结果符
                    result2 = getData1.InsertInput_storageRow(input_storageEntity);
                    result1 = getData1.UpdateTemp_storage(temp_storageEntity, sp);
                    MessageBox.Show("数据已经保存成功！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    SetButtonState();

                    //重新加载画面
                    BandingDgvCounter();
                }
            }

            //更新操作
            else if (dataType == DataType.Update)
            {

                input_storageEntity.INPUT_CODE = textBox_input_code2.Text;
                //设置更新条件参数
                SearchParameter sp = new SearchParameter();
                SearchParameter sp1 = new SearchParameter();
                //更新条件参数赋值
                sp.SetValue(":goods_code", goods_code);
                sp1.SetValue(":input_code", input_storageEntity.INPUT_CODE);
                temp_storageEntity = new EntityTemp_storage();
                //赋值实体类
                temp_storageEntity.Count = (int)textBox_input_standard_count.Value - oldCount;
                try
                {
                    //打开数据库连接
                    dataAccess = new DataAccess();
                    dataAccess.Open();
                    //打开事务
                    dataAccess.BeginTransaction();

                    GetData getData1 = new GetData(dataAccess.Connection, dataAccess.Transaction);
                    //取得结果符
                    result2 = getData1.UpdateInput_storageRow(input_storageEntity, sp1);
                    result1 = getData1.UpdateTemp_storage(temp_storageEntity, sp);
                    //提交事务
                    dataAccess.Commit();
                    MessageBox.Show("数据已经保存成功！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                }
                //设置按钮状态
                dataType = DataType.None;
                SetButtonState();

                //重新加载画面
                BandingDgvCounter();

            }
            dataGridView_input_storage.Focus();
        }
        //*******************************************************************
        /// <summary>
        /// 绑定画面
        /// </summary>
        /// <history>
        ///     完成信息：吴小科      2010/07/13 完成   
        ///     更新信息：
        /// </history>
        //*******************************************************************
        private void BandingDgvCounter()
        {
            try
            {

                //打开数据库
                dataAccess = new DataAccess();
                dataAccess.Open();
                //获取操作类
                GetData getData = new GetData(dataAccess.Connection);
                //设置加载条件
                SearchParameter sp = new SearchParameter();
                sp.SetValue(":input_type", '0');
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




        //***********************************************************************
        /// <summary>
        /// 取消按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/07/13 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************

        private void btnCancel_Click(object sender, EventArgs e)
        {   //按钮状态
            dataType = DataType.None;
            SetButtonState();
            //判断画面数据不为空
            if (dataGridView_input_storage != null && dataGridView_input_storage.SelectedRows.Count != 0)
            {   //取得数据赋值文本框
                textBox_input_code2.Text = dataGridView_input_storage.SelectedRows[0].Cells["input_code"].Value.ToString();
                textBox_goods_name.Text = dataGridView_input_storage.SelectedRows[0].Cells["goods_name"].Value.ToString();
                textBox_input_standard_count.Value = Convert.ToInt32(dataGridView_input_storage.SelectedRows[0].Cells["input_standard_count"].Value.ToString());
                textBox_counter_name.Text = dataGridView_input_storage.SelectedRows[0].Cells["counter_code"].Value.ToString();
                dataTime_input_maketime.Value = DateTime.Parse(dataGridView_input_storage.SelectedRows[0].Cells["input_maketime"].Value.ToString());
                dateTime_input_instorage_date.Value = DateTime.Parse(dataGridView_input_storage.SelectedRows[0].Cells["input_instorage_date"].Value.ToString());
                textBox_input_oper.Text = dataGridView_input_storage.SelectedRows[0].Cells["input_oper"].Value.ToString();
                textBox_input_quality_reg.Text = dataGridView_input_storage.SelectedRows[0].Cells["input_quality_reg"].Value.ToString();
                textBox_input_quality_persion.Text = dataGridView_input_storage.SelectedRows[0].Cells["input_quality_persion"].Value.ToString();
                textBox_input_remark.Text = dataGridView_input_storage.SelectedRows[0].Cells["input_remark"].Value.ToString();
                textBox_input_batch_num.Text = dataGridView_input_storage.SelectedRows[0].Cells["input_batch_num"].Value.ToString();
                textBox_supplier_name.Text = dataGridView_input_storage.SelectedRows[0].Cells["supplier_name"].Value.ToString();

            }
            else
            { 
                textBox_input_code2.Text = "";
                textBox_goods_name.Text = "";
                textBox_input_standard_count.Value = 0;
                textBox_counter_name.Text = "";
                dataTime_input_maketime.Value = DateTime.Now.Date;
                dateTime_input_instorage_date.Value = DateTime.Now.Date;
                textBox_input_oper.Text = "";
                textBox_input_quality_reg.Text = "";
                textBox_input_quality_persion.Text = "";
                textBox_input_remark.Text = "";
                textBox_input_batch_num.Text = "";
                textBox_supplier_name.Text = "";
            }
            dataGridView_input_storage.Focus();
        }
        //***********************************************************************
        /// <summary>
        /// 查询按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/07/13 完成   
        ///    更新信息：
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
                sp.SetValue(":input_type", '0');
                //判断文本框是否为空
                if (textBox_input_code.Text.Trim() != string.Empty)
                {   //查询条件参数赋值
                    sp.SetValue(":TC_INPUT_STORAGE.INPUT_CODE", textBox_input_code.Text.Trim());
                }
                if (textBox_goods_name1.Text.Trim() != string.Empty)
                {
                    sp.SetValue(":TC_GOODS.GOODS_NAME", textBox_goods_name1.Text.Trim());

                }
                if (textBox_goods_yxm.Text.Trim() != string.Empty)
                {
                    sp.SetValue(":TC_GOODS.GOODS_YXM", textBox_goods_yxm.Text.Trim());

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
            textBox_goods_name1.Text = "";
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
