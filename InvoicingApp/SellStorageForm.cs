//***********************************************************************
//* 系统名称	    ：  长白ERP系统
//* 功能模块	    ：  系统信息
//* 功能画面		：  销售出库管理
//* 画面名称	    ：  SellStorageForm
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
    ///销售出库管理功能
    /// </summary>
    /// <history>
    ///     完成信息：代国明      2010/07/23 完成  
    ///     更新信息：
    /// </history>
    //***********************************************************************
    public partial class SellStorageForm : Form
    {
        /// <summary>
        /// 数据库连接句柄
        /// </summary>
        DataAccess dataAccess = null;

        /// <summary>
        /// 画面状态
        /// </summary>
        DataType dataType = DataType.None;

        /// <summary>
        /// 结果符，默认-1
        /// </summary>
        int result = -1;

        /// <summary>
        /// 选择记录的行号
        /// </summary>
        int countNum = 0;

        /// <summary>
        /// 入库编号
        /// </summary>
        string inputCode = string.Empty;

        /// <summary>
        /// 生产日期
        /// </summary>
        DateTime makeTime;

        /// <summary>
        /// 生产日期
        /// </summary>
        DateTime instorageDate;

        /// <summary>
        /// 客户编码 
        /// </summary>
        string customerCode = string.Empty;

        /// <summary>
        /// 出库实体类
        /// </summary>
        EntityOutput_storage outputStorageEntity = null;

        /// <summary>
        /// 库存临时表实体类
        /// </summary>
        EntityTemp_storage tempStorageEntity = null;

        /// <summary>
        /// 入库记录表实体类
        /// </summary>
        EntityInput_storage inputStorageEntity = null;

        /// <summary>
        /// 出库表DataTable
        /// </summary>
        DataTable dtOutputStorage = null;

        public SellStorageForm()
        {

            InitializeComponent();

            this.dgvOutput_storage.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(239, 243, 251);
        }

        /// <summary>
        /// 画面状态枚举
        /// </summary>
        public enum DataType
        {
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
        ///     完成信息：代国明      2010/07/23 完成   
        ///     更新信息：
        /// </history>
        //*******************************************************************
        private void setButtonState()
        {
            switch (dataType)
            {
                case DataType.None:
                    txt_output_customer_name.ReadOnly = true;
                    cmb_output_packing_in.Enabled = false;
                    cmb_output_packing_mid.Enabled = false;
                    cmb_output_packing_out.Enabled = false;
                    txt_output_check_persion.ReadOnly = true;
                    txt_output_issued.ReadOnly = true;
                    txt_output_remark.ReadOnly = true;
                    txt_output_oper.ReadOnly = true;
                    dtp_output_checktime.Enabled = false;
                    dtp_output_datetime.Enabled = false;
                    txt_output_customer_name.BackColor = Color.FromArgb(236, 233, 216);
                    txt_output_check_persion.BackColor = Color.FromArgb(236, 233, 216);
                    txt_goods_name.BackColor = Color.FromArgb(236, 233, 216);
                    txt_output_oper.BackColor = Color.FromArgb(236, 233, 216);
                    txt_output_issued.BackColor = Color.FromArgb(236, 233, 216);
                    txt_output_quality_persion.BackColor = Color.FromArgb(236, 233, 216);


                    btnAdd.Enabled = true;
                    btnDelete.Enabled = true;
                    btnCommit.Enabled = false;
                    btnCancel.Enabled = false;

                    break;
                case DataType.Insert:
                    cmb_output_packing_in.Enabled = true;
                    cmb_output_packing_mid.Enabled = true;
                    cmb_output_packing_out.Enabled = true;
                    txt_output_remark.ReadOnly = false;
                    dtp_output_checktime.Enabled = true;
                    dtp_output_datetime.Enabled = true;


                    //添加时，同时清空文本框                    
                    txt_output_customer_name.Text = "双击选择客户...";
                    txt_output_customer_name.BackColor = Color.FromArgb(255, 255, 255);
                    cmb_output_packing_in.SelectedIndex = 0;
                    cmb_output_packing_mid.SelectedIndex = 0;
                    cmb_output_packing_out.SelectedIndex = 0;
                    txt_output_check_persion.Text = "双击选择验收人...";
                    txt_output_check_persion.BackColor = Color.FromArgb(255, 255, 255);
                    txt_goods_name.Text = "双击选择产品...";
                    txt_goods_name.BackColor = Color.FromArgb(255, 255, 255);
                    nud_output_count.Value = 0;
                    txt_output_remark.Text = "";
                    txt_output_oper.Text = "双击选择业务员...";
                    txt_output_oper.BackColor = Color.FromArgb(255, 255, 255);
                    txt_output_issued.Text = "双击选择经办人...";
                    txt_output_issued.BackColor = Color.FromArgb(255, 255, 255);
                    txt_output_quality_persion.Text = "双击选择质管员...";
                    txt_output_quality_persion.BackColor = Color.FromArgb(255, 255, 255);
                    txt_output_remark.Text = "";
                    dtp_output_checktime.Value = DateTime.Now;
                    dtp_output_datetime.Value = DateTime.Now;

                    btnDelete.Enabled = false;
                    btnAdd.Enabled = false;
                    btnCommit.Enabled = true;
                    btnCancel.Enabled = true;
                    break;
                default:
                    txt_output_customer_name.ReadOnly = true;
                    cmb_output_packing_in.Enabled = false;
                    cmb_output_packing_mid.Enabled = false;
                    cmb_output_packing_out.Enabled = false;
                    txt_output_check_persion.ReadOnly = true;
                    txt_output_issued.ReadOnly = true;
                    txt_output_remark.ReadOnly = true;
                    txt_output_oper.ReadOnly = true;

                    btnAdd.Enabled = true;
                    btnDelete.Enabled = true;
                    btnCommit.Enabled = false;
                    btnCancel.Enabled = false;
                    txt_output_code_Select.Focus();
                    break;
            }
        }

        //***********************************************************************
        /// <summary>
        /// 页面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：代国明      2010/07/20 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void SellStorageForm_Load(object sender, EventArgs e)
        {

            dgvOutput_storage.AutoGenerateColumns = false;
            cmb_output_packing_in.SelectedIndex = 0;
            cmb_output_packing_mid.SelectedIndex = 0;
            cmb_output_packing_out.SelectedIndex = 0;
            if (LoginUser.CompanyType == "0")
            {
                labOper.Text = "业务员:";
                labDate.Visible = false;
            }
            else
            {
                labOper.Text = "验配员:";
                labDate.Visible = true;
            }

            BandingDgvOutput_Storage();

            //设定按钮状态
            dataType = DataType.None;
            setButtonState();
            txt_output_code_Select.Focus();
        }

        //*******************************************************************
        /// <summary>
        /// 绑定画面
        /// </summary>
        /// <history>
        ///     完成信息：代国明      2010/07/13 完成   
        ///     更新信息：
        /// </history>
        //*******************************************************************
        private void BandingDgvOutput_Storage()
        {
            //初始化参数类
            SearchParameter sp = new SearchParameter();

            sp.SetValue(":OS.OUTPUT_TYPE", '0');

            try
            {

                //打开数据库连接
                dataAccess = new DataAccess();
                dataAccess.Open();

                //取得操作类
                GetData getData = new GetData(dataAccess.Connection);

                //取得单表数据
                dtOutputStorage = getData.GetTableBySqlStr(Constants.SqlStr.TC_OUTPUT_STORAGE_LEFTJOIN_TC_CUSTOMER_LEFTJOIN_TC_INPUT_STORAGE_LEFTJOIN_TC_GOODS, sp);

                //如果为NULL，报错
                if (dtOutputStorage == null)
                {
                    MessageBox.Show("请查看数据库是否正常！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //添加序列号
                int countNumber = 0;
                dtOutputStorage.Columns.Add("index", typeof(int));
                for (int i = 0; i < dtOutputStorage.Rows.Count; i++)
                {
                    dtOutputStorage.Rows[i]["index"] = ++countNumber;

                }

                this.dgvOutput_storage.DataSource = dtOutputStorage;

                if (dgvOutput_storage != null && dgvOutput_storage.Rows.Count > 0 && countNum != 0)
                {
                    dgvOutput_storage.Rows[0].Selected = false;
                    dgvOutput_storage.Rows[countNum].Selected = true;
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

        private DataTable GetDataTableNew()
        {
            //初始化参数类
            SearchParameter sp = new SearchParameter();

            sp.SetValue(":OS.OUTPUT_TYPE", '0');

            try
            {

                //打开数据库连接
                dataAccess = new DataAccess();
                dataAccess.Open();

                //取得操作类
                GetData getData = new GetData(dataAccess.Connection);

                //取得单表数据
                dtOutputStorage = getData.GetTableBySqlStr(Constants.SqlStr.TC_OUTPUT_STORAGE_LEFTJOIN_TC_CUSTOMER_LEFTJOIN_TC_INPUT_STORAGE_LEFTJOIN_TC_GOODS, sp);

                //如果为NULL，报错
                if (dtOutputStorage == null)
                {
                    MessageBox.Show("请查看数据库是否正常！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            return dtOutputStorage;
        }


        //***********************************************************************
        /// <summary>
        /// 查找按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：代国明      2010/07/20 完成   
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

            //条件不为空，添加参数
            if (txt_output_code_Select.Text.Trim() != string.Empty)
            {
                sp.SetValue(":OS.OUTPUT_CODE", txt_output_code_Select.Text);
            }

            if (txt_output_customer_name_Select.Text.Trim() != string.Empty)
            {
                sp.SetValue(":CUSTOMER.CUSTOMER_NAME", txt_output_customer_name_Select.Text);

            }

            if (txt_goods_name_Select.Text.Trim() != string.Empty)
            {
                sp.SetValue(":GOODS.GOODS_NAME", txt_goods_name_Select.Text);
            }

            sp.SetValue(":OS.OUTPUT_TYPE", '0');

            try
            {

                //打开数据库连接
                dataAccess = new DataAccess();
                dataAccess.Open();

                //取得操作类
                GetData getData = new GetData(dataAccess.Connection);

                //取得单表数据
                dtOutputStorage = getData.GetTableBySqlStr(Constants.SqlStr.TC_OUTPUT_STORAGE_LEFTJOIN_TC_CUSTOMER_LEFTJOIN_TC_INPUT_STORAGE_LEFTJOIN_TC_GOODS, sp);

                //如果为NULL，报错
                if (dtOutputStorage == null)
                {
                    MessageBox.Show("请查看数据库是否正常！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //没有数据
                if (dtOutputStorage.Rows.Count == 0)
                {

                    //给出提示
                    MessageBox.Show("数据不存在，请查看输入的条件是否正确！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                //添加序列号
                int countNumber = 0;
                dtOutputStorage.Columns.Add("index", typeof(int));
                for (int i = 0; i < dtOutputStorage.Rows.Count; i++)
                {
                    dtOutputStorage.Rows[i]["index"] = ++countNumber;

                }

                this.dgvOutput_storage.DataSource = dtOutputStorage;

                if (dgvOutput_storage != null && dgvOutput_storage.Rows.Count > 0 && countNum != 0)
                {
                    dgvOutput_storage.Rows[0].Selected = false;
                    dgvOutput_storage.Rows[countNum].Selected = true;
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
        /// 添加按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：代国明      2010/07/20 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //设定按钮状态
            dataType = DataType.Insert;
            setButtonState();
            txt_goods_name.Focus();
        }

        //***********************************************************************
        /// <summary>
        /// 确认按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：代国明      2010/07/20 完成   
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

            if (txt_goods_name.Text.Trim() == string.Empty || txt_goods_name.Text.Trim() == "双击选择产品...")
            {
                MessageBox.Show("产品名称不能为空！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_goods_name.Focus();
                return;
            }

            if (nud_output_count.Value == 0)
            {
                MessageBox.Show("销售数量不能为零！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                nud_output_count.Focus();
                return;
            }

            if (txt_output_customer_name.Text.Trim() == string.Empty || txt_output_customer_name.Text.Trim() == "双击选择客户...")
            {
                MessageBox.Show("客户不能为空！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_output_customer_name.Focus();
                return;
            }

            //判断时间有效性
            if (DateTime.Now.Date < dtp_output_checktime.Value.Date)
            {
                MessageBox.Show("验收日期不可大于今天", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtp_output_checktime.Focus();
                return;
            }
            if (makeTime > dtp_output_datetime.Value.Date)
            {
                MessageBox.Show("销售日期不可小于生产日期", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtp_output_datetime.Focus();
                return;
            }
            if (instorageDate > dtp_output_datetime.Value.Date)
            {
                MessageBox.Show("销售日期不可入小于库日期", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtp_output_datetime.Focus();
                return;
            }

            //判断时间有效性
            if (dtp_output_datetime.Value.Date > dtp_output_checktime.Value.Date)
            {
                MessageBox.Show("验收日期不可小于销售日期", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtp_output_datetime.Focus();
                return;
            }


            if (txt_output_quality_persion.Text.Trim() == string.Empty || txt_output_quality_persion.Text.Trim() == "双击选择质管员...")
            {
                MessageBox.Show("质管员不能为空！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_output_quality_persion.Focus();
                return;
            }

            if (txt_output_check_persion.Text.Trim() == string.Empty || txt_output_check_persion.Text.Trim() == "双击选择验收人...")
            {
                MessageBox.Show("验收人不能为空！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_output_check_persion.Focus();
                return;
            }

            if (txt_output_oper.Text.Trim() == string.Empty || txt_output_oper.Text.Trim() == "双击选择业务员...")
            {
                MessageBox.Show("业务员不能为空！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_output_oper.Focus();
                return;
            }

            if (txt_output_issued.Text.Trim() == string.Empty || txt_output_issued.Text.Trim() == "双击选择经办人...")
            {
                MessageBox.Show("经办人不能为空！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_output_issued.Focus();
                return;
            }

            //if (cmb_output_packing_in.Text.Equals("请选择一种包装情况"))
            //{
            //    MessageBox.Show("请选择一种包装情况", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    cmb_output_packing_in.Focus();
            //    return;
            //}

            //if (cmb_output_packing_mid.Text.Equals("请选择一种包装情况"))
            //{
            //    MessageBox.Show("请选择一种包装情况", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    cmb_output_packing_mid.Focus();
            //    return;
            //}

            //if (cmb_output_packing_out.Text.Equals("请选择一种包装情况"))
            //{
            //    MessageBox.Show("请选择一种包装情况", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    cmb_output_packing_out.Focus();
            //    return;
            //}

            //添加后库存数目剪掉添加数目数据信息
            UpdateStorageDetailsByAdd();

            try
            {

                result = -1;

                //如果是添加
                if (dataType == DataType.Insert)
                {

                    //取得实体类
                    outputStorageEntity = new EntityOutput_storage();

                    //赋值实体类                   
                    outputStorageEntity.Output_checktime = Convert.ToDateTime(dtp_output_checktime.Value.ToString("yyyy-MM-dd"));
                    outputStorageEntity.Output_instorage_date = Convert.ToDateTime(dtp_output_datetime.Value.ToString("yyyy-MM-dd"));
                    outputStorageEntity.Output_count = Convert.ToInt32(nud_output_count.Value);
                    outputStorageEntity.Input_code = inputCode;
                    outputStorageEntity.Output_packing_in = cmb_output_packing_in.Text.ToString();
                    outputStorageEntity.Output_packing_mid = cmb_output_packing_mid.Text.ToString();
                    outputStorageEntity.Output_packing_out = cmb_output_packing_out.Text.ToString();
                    outputStorageEntity.Output_oper = txt_output_oper.Text.ToString();
                    outputStorageEntity.Output_quality_persion = txt_output_quality_persion.Text.ToString();
                    outputStorageEntity.Output_issued = txt_output_issued.Text.ToString();
                    outputStorageEntity.Output_check_persion = txt_output_check_persion.Text.ToString();
                    outputStorageEntity.Output_remark = txt_output_remark.Text.ToString();
                    outputStorageEntity.Customer_code = customerCode;
                    outputStorageEntity.Output_type = "0";
                    outputStorageEntity.Operate_type = "0";

                    inputStorageEntity = new EntityInput_storage();
                    inputStorageEntity.OPERATE_TYPE = '1';
                    inputStorageEntity.INPUT_CODE = inputCode;

                    //打开数据库连接
                    dataAccess = new DataAccess();
                    dataAccess.Open();

                    MakePrimaryKey mpk = new MakePrimaryKey(dataAccess.Connection, dataAccess.Transaction);

                    outputStorageEntity.Output_code = mpk.MakeCode("出库");

                    //取得操作类
                    GetData getData = new GetData(dataAccess.Connection);

                    //取得结果符
                    result = getData.InsertOutput_storageRow(outputStorageEntity);

                    if (result == 0)
                    {

                        MessageBox.Show("数据已经保存成功！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("数据已经保存失败！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    getData.UpdateOperate_typeByInput_codeRow(inputStorageEntity);

                }

            }
            catch (Exception ex)
            {

                if (dataAccess.Transaction != null)
                {

                    //回滚
                    dataAccess.Rollback();
                }

                //提示错误
                MessageBox.Show("数据添加时发生错误，请检查数据库！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            finally
            {

                //关闭数据库连接
                dataAccess.Close();


                //设置按钮状态
                dataType = DataType.None;
                setButtonState();

                //重新加载画面
                BandingDgvOutput_Storage();
            }
        }

        //***********************************************************************
        /// <summary>
        /// 添加后库存数目剪掉添加数目数据信息
        /// </summary>        
        /// <history>
        ///    完成信息：代国明      2010/07/20 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        void UpdateStorageDetailsByAdd()
        {
            try
            {
                result = -1;

                //打开数据库连接
                dataAccess = new DataAccess();
                dataAccess.Open();

                //打开事务
                dataAccess.BeginTransaction();

                SearchParameter sp = new SearchParameter();

                sp.SetValue(":GOODS_CODE", tempStorageEntity.Goods_code);
                sp.SetValue(":COUNT", tempStorageEntity.Count);

                //取得操作类
                GetData getData = new GetData(dataAccess.Connection, dataAccess.Transaction);

                //取得结果符
                result = getData.UpdateTemp_storage(tempStorageEntity, sp);

                //提交事务
                dataAccess.Commit();
            }
            catch (Exception ex)
            {

                if (dataAccess.Transaction != null)
                {

                    //回滚
                    dataAccess.Rollback();
                }

                //提示错误
                MessageBox.Show("数据添加时发生错误，请检查数据库！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            finally
            {

                //关闭数据库连接
                dataAccess.Close();
            }
        }

        //*******************************************************************
        /// <summary>
        /// 双击文本框弹出不同的选择窗体
        /// </summary>
        /// <history>
        ///     完成信息：代国明      2010/07/20 完成   
        ///     更新信息：
        /// </history>
        //*******************************************************************
        private void textBox_DoubleClick(object sender, EventArgs e)
        {
            switch (((TextBox)sender).Name)
            {
                //双击文本框弹出弹出产品信息窗体                
                case "txt_goods_name":
                    {   //判断当前页面的状态
                        if (dataType == DataType.Insert)
                        {
                            storageGoodsDialogForm sgd = new storageGoodsDialogForm("销售数量:");
                            sgd.ShowDialog();
                            if (sgd.goodName != string.Empty)
                            {
                                txt_goods_name.Text = sgd.goodName;
                                nud_output_count.Value = sgd.outputStorage1;
                                inputCode = sgd.inputCode;
                                tempStorageEntity = sgd.tempStorageEntity;
                                makeTime = sgd.makeTime;
                                instorageDate = sgd.instorageDate;
                            }
                        }
                        break;

                    }

                //双击文本框弹出弹出员工信息窗体
                case "txt_output_check_persion":
                    {
                        //判断当前页面的状态
                        if (dataType == DataType.Insert)
                        {
                            StaffForm child = new StaffForm();
                            child.ShowDialog();
                            if (child.staffName != string.Empty)
                                txt_output_check_persion.Text = child.staffName;
                        }
                        break;

                    }

                //双击文本框弹出弹出员工信息窗体
                case "txt_output_oper":
                    {
                        //判断当前页面的状态
                        if (dataType == DataType.Insert)
                        {
                            StaffForm child = new StaffForm();
                            child.ShowDialog();
                            if (child.staffName != string.Empty)
                                txt_output_oper.Text = child.staffName;
                        }
                        break;
                    }

                //双击文本框弹出弹出员工信息窗体
                case "txt_output_issued":
                    {
                        //判断当前页面的状态
                        if (dataType == DataType.Insert)
                        {

                            StaffForm child = new StaffForm();
                            child.ShowDialog();
                            if (child.staffName != string.Empty)
                                txt_output_issued.Text = child.staffName;
                        }
                        break;

                    }

                //双击文本框弹出弹出员工信息窗体
                case "txt_output_quality_persion":
                    {
                        //判断当前页面的状态
                        if (dataType == DataType.Insert)
                        {

                            StaffForm child = new StaffForm();
                            child.ShowDialog();
                            if (child.staffName != string.Empty)
                                txt_output_quality_persion.Text = child.staffName;
                        }
                        break;

                    }

                //双击文本框弹出弹出客户信息窗体
                case "txt_output_customer_name":
                    {
                        //判断当前页面的状态
                        if (dataType == DataType.Insert)
                        {
                            if (LoginUser.CompanyType == "0")
                            {
                                customerDialogForm customerForm = new customerDialogForm();
                                customerForm.ShowDialog();
                                if (customerForm.customerName != string.Empty)
                                {
                                    txt_output_customer_name.Text = customerForm.customerName;
                                    customerCode = customerForm.customerCode;
                                }
                            }
                            else
                            {
                                persionalDialogForm persionalForm = new persionalDialogForm();
                                persionalForm.ShowDialog();
                                if (persionalForm.customerName != string.Empty)
                                {
                                    txt_output_customer_name.Text = persionalForm.customerName;
                                    customerCode = persionalForm.customerCode;
                                }
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
        /// 删除后复原库存数目数据信息
        /// </summary>        
        /// <history>
        ///    完成信息：代国明      2010/07/20 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        void UpdateStorageDetailsbyDelete()
        {

            //取得树体类
            tempStorageEntity = new EntityTemp_storage();

            //赋值实体类
            tempStorageEntity.Goods_code = dgvOutput_storage.SelectedRows[0].Cells["input_goods_code"].Value.ToString();
            tempStorageEntity.Count = Convert.ToInt32(dgvOutput_storage.SelectedRows[0].Cells["output_count"].Value.ToString());

            try
            {
                result = -1;

                //打开数据库连接
                dataAccess = new DataAccess();
                dataAccess.Open();

                //打开事务
                dataAccess.BeginTransaction();

                SearchParameter sp = new SearchParameter();

                sp.SetValue(":goods_code", tempStorageEntity.Goods_code);

                //取得操作类
                GetData getData = new GetData(dataAccess.Connection, dataAccess.Transaction);

                //取得结果符
                result = getData.UpdateTemp_storage(tempStorageEntity, sp);

                //提交事务
                dataAccess.Commit();
            }
            catch (Exception ex)
            {

                if (dataAccess.Transaction != null)
                {

                    //回滚
                    dataAccess.Rollback();
                }

                //提示错误
                MessageBox.Show("数据添加时发生错误，请检查数据库！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            finally
            {

                //关闭数据库连接
                dataAccess.Close();
            }
        }

        //***********************************************************************
        /// <summary>
        ///判断出库表里有没有入库编号相同的记录，有返回false，无返回true
        /// </summary>        
        /// <history>
        ///    完成信息：代国明      2010/07/25 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private Boolean JudgeOutputStorage()
        {
            DataTable dt = dtOutputStorage;
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["input_code"].ToString() == dgvOutput_storage.SelectedRows[0].Cells["input_code"].Value.ToString() && dr["output_code"].ToString() != dgvOutput_storage.SelectedRows[0].Cells["output_code"].Value.ToString())
                {
                    return false;
                }
            }
            return true;
        }


        private Boolean JudgeMaintain()
        {
            Boolean f = false;

            //取得单表数据
            DataTable dtMaintain = null; ;

            try
            {

                //打开数据库连接
                dataAccess = new DataAccess();
                dataAccess.Open();

                //取得操作类
                GetData getData = new GetData(dataAccess.Connection);

                //取得单表数据
                dtMaintain = getData.GetSingleTable("tc_maintain");
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

            foreach (DataRow dr in dtMaintain.Rows)
            {
                if (dr["maintain_input_code"].ToString() == dgvOutput_storage.SelectedRows[0].Cells["input_code"].Value.ToString())
                {
                    f = true;
                }
            }

            return f;
        }

        //***********************************************************************
        /// <summary>
        /// 作废按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：代国明      2010/07/20 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //设置按钮状态
            dataType = DataType.None;
            setButtonState();

            //如果选择多条数据删除，提示
            if (dgvOutput_storage.SelectedRows.Count > 1)
            {
                MessageBox.Show("只能选择一条要作废的记录！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //如过画面中不存在数据，提示
            if (dgvOutput_storage.SelectedRows.Count < 1)
            {
                MessageBox.Show("请选择一条要作废的记录！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataTable dt = GetDataTableNew();

            foreach (DataRow dr in dt.Rows)
            {
                if (dr["output_code"].ToString() == dgvOutput_storage.SelectedRows[0].Cells["output_code"].Value.ToString() && dr["operate_type"].ToString() == "1")
                {
                    MessageBox.Show("该销售单已经被使用，不能作废！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            //if (dgvOutput_storage.SelectedRows[0].Cells["operate_type"].Value.ToString() == "1")
            //{
            //    MessageBox.Show("该销售单已经存在退货入库记录，不能修改或删除！", "操作失败", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}
            //else
            //{
            //结果符
            result = -1;
            countNum = 0;


            //取得单表类
            DataTable dtLose = GetLoseTable();

            Boolean bs = JudgeMaintain();

            //弹出提示，确认删除
            if (MessageBox.Show("您确定要作废该数据吗？", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {

                    //初始化参数类
                    SearchParameter sp = new SearchParameter();

                    //设置主键
                    sp.SetValue(":OUTPUT_CODE", dgvOutput_storage.SelectedRows[0].Cells["output_code"].Value.ToString());
                    //打开数据库
                    dataAccess = new DataAccess();
                    dataAccess.Open();

                    //打开事务
                    dataAccess.BeginTransaction();

                    //取得操作类
                    GetData getData = new GetData(dataAccess.Connection, dataAccess.Transaction);

                    //判断报损表是否有标识
                    Boolean flag = false;

                    if (JudgeOutputStorage())
                    {
                        //遍历报损表
                        foreach (DataRow dr in dtLose.Rows)
                        {
                            if (dr["input_code"].ToString() == dgvOutput_storage.SelectedRows[0].Cells["input_code"].Value.ToString())
                            {
                                flag = true;
                                break;
                            }
                        }

                        //如果报损表该删除的入库记录，将入库标识置为1
                        if (!flag && !bs)
                        {
                            inputStorageEntity = new EntityInput_storage();
                            inputStorageEntity.INPUT_CODE = dgvOutput_storage.SelectedRows[0].Cells["input_code"].Value.ToString();
                            inputStorageEntity.OPERATE_TYPE = '0';
                            getData.UpdateOperate_typeByInput_codeRow(inputStorageEntity);
                        }
                        else
                        {
                            inputStorageEntity = new EntityInput_storage();
                            inputStorageEntity.INPUT_CODE = dgvOutput_storage.SelectedRows[0].Cells["input_code"].Value.ToString();
                            inputStorageEntity.OPERATE_TYPE = '1';
                            getData.UpdateOperate_typeByInput_codeRow(inputStorageEntity);
                        }
                    }

                    //取得结果符
                    result = getData.DeleteRow("TC_OUTPUT_STORAGE", sp);

                    //提交事务
                    dataAccess.Commit();
                }
                catch (Exception ex)
                {

                    //回滚
                    dataAccess.Rollback();
                    MessageBox.Show(ex.Message);

                }
                finally
                {
                    //关闭数据库连接
                    dataAccess.Close();

                    //判断结果符，0：成功；-1：失败
                    if (result == 0)
                    {
                        MessageBox.Show("数据已经被成功作废！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UpdateStorageDetailsbyDelete();
                        //加载画面
                        BandingDgvOutput_Storage();
                    }

                }

            }
            //}

        }

        //***********************************************************************
        /// <summary>
        /// 获得报损表
        /// </summary>
        /// <return>dtLose</return>
        /// <history>
        ///    完成信息：代国明      2010/07/20 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private DataTable GetLoseTable()
        {
            //取得单表数据
            DataTable dtLose = null; ;

            try
            {

                //打开数据库连接
                dataAccess = new DataAccess();
                dataAccess.Open();

                //取得操作类
                GetData getData = new GetData(dataAccess.Connection);

                //取得单表数据
                dtLose = getData.GetSingleTable("tc_lose");
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
            return dtLose;
        }

        //***********************************************************************
        /// <summary>
        /// 取消按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：代国明      2010/07/20 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnCancel_Click(object sender, EventArgs e)
        {

            //设置按钮状态
            dataType = DataType.None;
            setButtonState();

            //判断画面数据不为空
            if (dgvOutput_storage != null && dgvOutput_storage.SelectedRows.Count != 0)
            {

                //取得画面数据赋值文本框
                txt_output_customer_name.Text = dgvOutput_storage.SelectedRows[0].Cells["customer_name"].Value.ToString();
                nud_output_count.Value = Convert.ToInt32(dgvOutput_storage.SelectedRows[0].Cells["output_count"].Value.ToString());
                txt_goods_name.Text = dgvOutput_storage.SelectedRows[0].Cells["goods_name"].Value.ToString();
                txt_output_check_persion.Text = dgvOutput_storage.SelectedRows[0].Cells["output_check_persion"].Value.ToString();
                txt_output_issued.Text = dgvOutput_storage.SelectedRows[0].Cells["output_issued"].Value.ToString();
                txt_output_oper.Text = dgvOutput_storage.SelectedRows[0].Cells["output_oper"].Value.ToString();
                cmb_output_packing_in.Text = dgvOutput_storage.SelectedRows[0].Cells["output_packing_in"].Value.ToString();
                cmb_output_packing_mid.Text = dgvOutput_storage.SelectedRows[0].Cells["output_packing_mid"].Value.ToString();
                cmb_output_packing_out.Text = dgvOutput_storage.SelectedRows[0].Cells["output_packing_out"].Value.ToString();
                txt_output_quality_persion.Text = dgvOutput_storage.SelectedRows[0].Cells["output_quality_persion"].Value.ToString();
                txt_output_remark.Text = dgvOutput_storage.SelectedRows[0].Cells["output_remark"].Value.ToString();
                dtp_output_checktime.Text = dgvOutput_storage.SelectedRows[0].Cells["output_checktime"].Value.ToString();
                dtp_output_datetime.Text = dgvOutput_storage.SelectedRows[0].Cells["output_instorage_date"].Value.ToString();
            }
            else
            {
                txt_output_customer_name.Text = "";
                nud_output_count.Value = 0;
                txt_goods_name.Text = "";
                txt_output_check_persion.Text = "";
                txt_output_issued.Text = "";
                txt_output_oper.Text = "";
                cmb_output_packing_in.SelectedIndex = 0;
                cmb_output_packing_mid.SelectedIndex = 0;
                cmb_output_packing_out.SelectedIndex = 0;
                txt_output_quality_persion.Text = "";
                txt_output_remark.Text = "";
                dtp_output_checktime.Text = "";
                dtp_output_datetime.Text = "";
            }
            dgvOutput_storage.Focus();
        }

        //***********************************************************************
        /// <summary>
        /// 选择dataGridView事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：代国明      2010/07/20 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void dgvOutput_storage_SelectionChanged(object sender, EventArgs e)
        {
            //设定按钮状态
            dataType = DataType.None;
            setButtonState();


            if (dgvOutput_storage != null && dgvOutput_storage.SelectedRows.Count != 0)
            {
                //文本框赋值
                txt_output_customer_name.Text = dgvOutput_storage.SelectedRows[0].Cells["customer_name"].Value.ToString();
                nud_output_count.Value = Convert.ToInt32(dgvOutput_storage.SelectedRows[0].Cells["output_count"].Value.ToString());
                txt_goods_name.Text = dgvOutput_storage.SelectedRows[0].Cells["goods_name"].Value.ToString();
                txt_output_check_persion.Text = dgvOutput_storage.SelectedRows[0].Cells["output_check_persion"].Value.ToString();
                txt_output_issued.Text = dgvOutput_storage.SelectedRows[0].Cells["output_issued"].Value.ToString();
                txt_output_oper.Text = dgvOutput_storage.SelectedRows[0].Cells["output_oper"].Value.ToString();
                cmb_output_packing_in.Text = dgvOutput_storage.SelectedRows[0].Cells["output_packing_in"].Value.ToString();
                cmb_output_packing_mid.Text = dgvOutput_storage.SelectedRows[0].Cells["output_packing_mid"].Value.ToString();
                cmb_output_packing_out.Text = dgvOutput_storage.SelectedRows[0].Cells["output_packing_out"].Value.ToString();
                txt_output_quality_persion.Text = dgvOutput_storage.SelectedRows[0].Cells["output_quality_persion"].Value.ToString();
                txt_output_remark.Text = dgvOutput_storage.SelectedRows[0].Cells["output_remark"].Value.ToString();
                dtp_output_checktime.Text = dgvOutput_storage.SelectedRows[0].Cells["output_checktime"].Value.ToString();
                dtp_output_datetime.Text = dgvOutput_storage.SelectedRows[0].Cells["output_instorage_date"].Value.ToString();
            }
            else
            {
                //文本框赋值
                txt_output_customer_name.Text = "";
                nud_output_count.Value = 0;
                txt_goods_name.Text = "";
                txt_output_check_persion.Text = "";
                txt_output_issued.Text = "";
                txt_output_oper.Text = "";
                txt_output_quality_persion.Text = "";
                txt_output_remark.Text = "";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txt_goods_name_Select.Text = "";
            this.txt_output_code_Select.Text = "";
            txt_output_customer_name_Select.Text = "";
        }

        private void dgvOutput_storage_Sorted(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvOutput_storage.Rows.Count; i++)
            {
                dgvOutput_storage.Rows[i].Cells["index"].Value = i + 1;
            }
        }

    }
}
