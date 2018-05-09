//***********************************************************************
//* 系统名称	    ：  长白ERP系统
//* 功能模块	    ：  系统信息
//* 功能画面		：  退货出库管理
//* 画面名称	    ：  BackOutStorageForm
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
    ///退货出库管理功能
    /// </summary>
    /// <history>
    ///     完成信息：代国明      2010/07/23 完成  
    ///     更新信息：
    /// </history>
    //***********************************************************************
    public partial class BackOutStorageForm : Form
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
        /// 入库编号
        /// </summary>
        string inputCode = string.Empty;

        /// <summary>
        /// 结果符，默认-1
        /// </summary>
        int result = -1;

        /// <summary>
        /// 选择记录的行号
        /// </summary>
        int countNum = 0;

        EntityInput_storage inputStorageEntity = null;

        /// <summary>
        /// 出库实体类
        /// </summary>
        EntityOutput_storage outputStorageEntity = null;

        /// <summary>
        /// 库存临时表实体类
        /// </summary>
        EntityTemp_storage tempStorageEntity = null;

        /// <summary>
        /// 数据源出库表
        /// </summary>
        private DataTable dtDgvOutputStorage = null;

        private DataTable dtOutputStorage = null;

        public BackOutStorageForm()
        {
            InitializeComponent();

            this.dgvOutputStorage.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(239, 243, 251);
        }

        //*******************************************************************
        /// <summary>
        /// 取得数据源
        /// </summary>
        /// <param name="dt">数据源表</param>
        /// <history>
        ///     完成信息：代国明      2010/07/23 完成   
        ///     更新信息：
        /// </history>
        //*******************************************************************
        private void GetDgvOutputStorage(DataTable dt)
        {
            //定义出库统计数据源表
            dtDgvOutputStorage = new DataTable();

            //添加各个数据列
            dtDgvOutputStorage.Columns.Add("goods_name", typeof(string));
            dtDgvOutputStorage.Columns.Add("output_code", typeof(string));
            dtDgvOutputStorage.Columns.Add("input_goods_code", typeof(string));
            dtDgvOutputStorage.Columns.Add("supplier_name", typeof(string));
            dtDgvOutputStorage.Columns.Add("output_count", typeof(string));
            dtDgvOutputStorage.Columns.Add("goods_type", typeof(string));
            dtDgvOutputStorage.Columns.Add("goods_unit", typeof(string));
            dtDgvOutputStorage.Columns.Add("input_maketime", typeof(string));
            dtDgvOutputStorage.Columns.Add("output_checktime", typeof(string));
            dtDgvOutputStorage.Columns.Add("goods_validity", typeof(string));
            dtDgvOutputStorage.Columns.Add("output_instorage_date", typeof(string));
            dtDgvOutputStorage.Columns.Add("output_remark", typeof(string));
            dtDgvOutputStorage.Columns.Add("output_oper", typeof(string));
            dtDgvOutputStorage.Columns.Add("output_quality_persion", typeof(string));

            dtDgvOutputStorage.Columns.Add("output_check_persion", typeof(string));
            dtDgvOutputStorage.Columns.Add("output_issued", typeof(string));
            dtDgvOutputStorage.Columns.Add("output_packing_out", typeof(string));
            dtDgvOutputStorage.Columns.Add("output_packing_mid", typeof(string));
            dtDgvOutputStorage.Columns.Add("output_packing_in", typeof(string));
            dtDgvOutputStorage.Columns.Add("output_backreason", typeof(string));
            dtDgvOutputStorage.Columns.Add("input_batch_num", typeof(string));
            dtDgvOutputStorage.Columns.Add("goods_reg_num", typeof(string));
            dtDgvOutputStorage.Columns.Add("input_code", typeof(string));

            //遍历数据源
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dtDgvOutputStorage.NewRow();

                dr["goods_name"] = dt.Rows[i]["goods_name"].ToString();
                dr["output_code"] = dt.Rows[i]["output_code"].ToString();
                dr["input_goods_code"] = dt.Rows[i]["input_goods_code"].ToString();
                dr["supplier_name"] = dt.Rows[i]["supplier_name"].ToString();
                dr["output_count"] = dt.Rows[i]["output_count"].ToString();
                dr["goods_type"] = dt.Rows[i]["goods_type"].ToString();
                dr["goods_unit"] = dt.Rows[i]["goods_unit"].ToString();
                dr["goods_validity"] = dt.Rows[i]["goods_validity"].ToString();
                dr["output_remark"] = dt.Rows[i]["output_remark"].ToString();
                dr["output_oper"] = dt.Rows[i]["output_oper"].ToString();
                dr["goods_reg_num"] = dt.Rows[i]["goods_reg_num"].ToString();

                dr["output_quality_persion"] = dt.Rows[i]["output_quality_persion"].ToString();
                dr["output_check_persion"] = dt.Rows[i]["output_check_persion"].ToString();
                dr["output_issued"] = dt.Rows[i]["output_issued"].ToString();
                dr["output_packing_out"] = dt.Rows[i]["output_packing_out"].ToString();
                dr["output_packing_mid"] = dt.Rows[i]["output_packing_mid"].ToString();
                dr["output_packing_in"] = dt.Rows[i]["output_packing_in"].ToString();
                dr["output_backreason"] = dt.Rows[i]["output_backreason"].ToString();
                dr["input_batch_num"] = dt.Rows[i]["input_batch_num"].ToString();
                dr["input_code"] = dt.Rows[i]["input_code"].ToString();

                if (dt.Rows[i]["input_maketime"].ToString().Equals(string.Empty))
                {
                    dr["input_maketime"] = "";
                }
                else
                {
                    dr["input_maketime"] = DateTime.Parse(dt.Rows[i]["input_maketime"].ToString()).ToString("yyyy-MM-dd");
                }

                if (dt.Rows[i]["output_checktime"].ToString().Equals(string.Empty))
                {
                    dr["output_checktime"] = "";
                }
                else
                {
                    dr["output_checktime"] = DateTime.Parse(dt.Rows[i]["output_checktime"].ToString()).ToString("yyyy-MM-dd");
                }

                if (dt.Rows[i]["output_instorage_date"].ToString().Equals(string.Empty))
                {
                    dr["output_instorage_date"] = "";
                }
                else
                {
                    dr["output_instorage_date"] = DateTime.Parse(dt.Rows[i]["output_instorage_date"].ToString()).ToString("yyyy-MM-dd");
                }

                dtDgvOutputStorage.Rows.Add(dr);
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
        ///     完成信息：代国明      2010/07/22 完成   
        ///     更新信息：
        /// </history>
        //*******************************************************************
        private void setButtonState()
        {
            switch (dataType)
            {
                case DataType.None:
                    txt_output_remark.ReadOnly = true;
                    txt_output_reback_reason.ReadOnly = true;
                    cmb_output_packing_out.Enabled = false;
                    cmb_output_packing_mid.Enabled = false;
                    cmb_output_packing_in.Enabled = false;
                    dtp_output_checktime.Enabled = false;
                    dtp_output_instorage_date.Enabled = false;
                    txt_goods_name.BackColor = Color.FromArgb(236, 233, 216);
                    txt_output_check_persion.BackColor = Color.FromArgb(236, 233, 216);
                    txt_output_issued.BackColor = Color.FromArgb(236, 233, 216);
                    txt_output_oper.BackColor = Color.FromArgb(236, 233, 216);
                    txt_output_quality_persion.BackColor = Color.FromArgb(236, 233, 216);

                    btnAdd.Enabled = true;
                    btnDelete.Enabled = true;
                    btnCommit.Enabled = false;
                    btnCancel.Enabled = false;
                    
                    break;
                case DataType.Insert:
                    txt_output_remark.ReadOnly = false;
                    txt_output_reback_reason.ReadOnly = false;
                    cmb_output_packing_out.Enabled = true;
                    cmb_output_packing_mid.Enabled = true;
                    cmb_output_packing_in.Enabled = true;
                    dtp_output_checktime.Enabled = true;
                    dtp_output_instorage_date.Enabled = true;


                    //添加时，同时清空文本框                    
                    cmb_output_packing_in.SelectedIndex = 0;
                    cmb_output_packing_mid.SelectedIndex = 0;
                    cmb_output_packing_out.SelectedIndex = 0;
                    txt_goods_name.Text = "双击选择产品...";
                    txt_goods_name.BackColor = Color.FromArgb(255, 255, 255);
                    txt_output_check_persion.Text = "双击选择验收人...";
                    txt_output_check_persion.BackColor = Color.FromArgb(255, 255, 255);
                    nud_output_count.Value = 0;
                    txt_output_issued.Text = "双击选择经办人...";
                    txt_output_issued.BackColor = Color.FromArgb(255, 255, 255);
                    txt_output_oper.Text = "双击选择业务员...";
                    txt_output_oper.BackColor = Color.FromArgb(255, 255, 255);
                    txt_output_quality_persion.Text = "双击选择质管员...";
                    txt_output_quality_persion.BackColor = Color.FromArgb(255, 255, 255);
                    txt_output_reback_reason.Text = "";
                    txt_output_remark.Text = "";
                    txt_supplier_name.Text = "";
                    dtp_output_checktime.Value = DateTime.Now;
                    dtp_output_instorage_date.Value = DateTime.Now;

                    btnDelete.Enabled = false;
                    btnAdd.Enabled = false;
                    btnCommit.Enabled = true;
                    btnCancel.Enabled = true;
                    break;
                default:
                    txt_output_remark.ReadOnly = true;
                    txt_output_reback_reason.ReadOnly = true;
                    cmb_output_packing_in.Enabled = false;
                    cmb_output_packing_mid.Enabled = false;
                    cmb_output_packing_out.Enabled = false;
                    dtp_output_checktime.Enabled = false;
                    dtp_output_instorage_date.Enabled = false;

                    btnAdd.Enabled = true;
                    btnDelete.Enabled = true;
                    btnCommit.Enabled = false;
                    btnCancel.Enabled = false;
                    
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
        ///    完成信息：代国明      2010/07/22 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void BackOutStorageForm_Load(object sender, EventArgs e)
        {
            cmb_output_packing_in.SelectedIndex = 0;
            cmb_output_packing_mid.SelectedIndex = 0;
            cmb_output_packing_out.SelectedIndex = 0;

            dgvOutputStorage.AutoGenerateColumns = false;

            BindingDgvOutputStorage();

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
        ///     完成信息：代国明      2010/07/22 完成   
        ///     更新信息：
        /// </history>
        //*******************************************************************
        public void BindingDgvOutputStorage()
        {
            try
            {

                //打开数据库连接
                dataAccess = new DataAccess();
                dataAccess.Open();

                //取得操作类
                GetData getData = new GetData(dataAccess.Connection);

                //设置加载条件
                SearchParameter sp = new SearchParameter();

                sp.SetValue(":OS.OUTPUT_TYPE", '1');

                //取得单表数据
                dtOutputStorage = getData.GetTableBySqlStr(Constants.SqlStr.TC_OUTPUT_STORAGE_LEFTJOIN_TC_INPUT_STORAGE_LEFTJOIN_TC_GOODS, sp);

                //绑定画面
                if (dtOutputStorage.Rows.Count >= 0)
                {
                    GetDgvOutputStorage(dtOutputStorage);

                    dtDgvOutputStorage.Columns.Add("goodsValidate", typeof(string));
                    for (int i = 0; i < dtDgvOutputStorage.Rows.Count; i++)
                    {
                        if (dtDgvOutputStorage.Rows[i]["goods_validity"] != null)
                        {
                            int validity = Convert.ToInt32(dtDgvOutputStorage.Rows[i]["goods_validity"].ToString());
                            DateTime goodSValidity = DateTime.Parse(dtDgvOutputStorage.Rows[i]["input_maketime"].ToString()).AddMonths(validity);
                            dtDgvOutputStorage.Rows[i]["goodsValidate"] = goodSValidity;
                        }
                    }

                    //添加序列号
                    int countNumber = 0;
                    dtDgvOutputStorage.Columns.Add("index", typeof(int));
                    for (int i = 0; i < dtDgvOutputStorage.Rows.Count; i++)
                    {
                        dtDgvOutputStorage.Rows[i]["index"] = ++countNumber;

                    }

                    dgvOutputStorage.DataSource = dtDgvOutputStorage;
                }

                if (dgvOutputStorage != null && dgvOutputStorage.Rows.Count > 0 && countNum != 0)
                {
                    dgvOutputStorage.Rows[0].Selected = false;
                    dgvOutputStorage.Rows[countNum].Selected = true;
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
        /// 查找按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：代国明      2010/07/22 完成   
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

            try
            {

                //打开数据库连接
                dataAccess = new DataAccess();
                dataAccess.Open();

                //取得操作类
                GetData getData = new GetData(dataAccess.Connection);

                //设置加载条件
                SearchParameter sp = new SearchParameter();

                //条件不为空，添加参数
                if (txt_output_code_Select.Text != string.Empty)
                {
                    sp.SetValue(":OS.OUTPUT_CODE", txt_output_code_Select.Text);
                }

                if (txt_goods_name_Select.Text != string.Empty)
                {
                    sp.SetValue(":GOODS.GOODS_NAME", txt_goods_name_Select.Text);

                }

                if (txt_supplier_name_Select.Text != string.Empty)
                {
                    sp.SetValue(":INPUTSTORAGE.SUPPLIER_NAME", txt_supplier_name_Select.Text);
                }

                sp.SetValue(":OS.OUTPUT_TYPE", '1');

                //取得单表数据
                DataTable dtOutputStorage = getData.GetTableBySqlStr(Constants.SqlStr.TC_OUTPUT_STORAGE_LEFTJOIN_TC_INPUT_STORAGE_LEFTJOIN_TC_GOODS, sp);

                GetDgvOutputStorage(dtOutputStorage);

                dtDgvOutputStorage.Columns.Add("goodsValidate", typeof(DateTime));
                for (int i = 0; i < dtDgvOutputStorage.Rows.Count; i++)
                {
                    int validity = int.Parse(dtDgvOutputStorage.Rows[i]["goods_validity"].ToString());
                    DateTime goodSValidity = DateTime.Parse(dtDgvOutputStorage.Rows[i]["input_maketime"].ToString()).AddMonths(validity);
                    dtDgvOutputStorage.Rows[i]["goodsValidate"] = goodSValidity;

                }

                //添加序列号
                int countNumber = 0;
                dtDgvOutputStorage.Columns.Add("index", typeof(int));
                for (int i = 0; i < dtDgvOutputStorage.Rows.Count; i++)
                {
                    dtDgvOutputStorage.Rows[i]["index"] = ++countNumber;

                }

                if (dtOutputStorage.Rows.Count == 0)
                {
                    //给出提示
                    MessageBox.Show("数据不存在，请查看输入的条件是否正确！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                }

                dgvOutputStorage.DataSource = dtDgvOutputStorage;
               
                if (dgvOutputStorage != null && dgvOutputStorage.Rows.Count > 0 && countNum != 0)
                {
                    dgvOutputStorage.Rows[0].Selected = false;
                    dgvOutputStorage.Rows[countNum].Selected = true;
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
        ///    完成信息：代国明      2010/07/22 完成   
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
        ///    完成信息：代国明      2010/07/22 完成   
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

            if (txt_goods_name.Text.Trim() == "双击选择产品..." || txt_goods_name.Text.Trim() == string.Empty)
            {
                MessageBox.Show("产品名称不能为空！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_goods_name.Focus();
                return;
            }

            if (txt_supplier_name.Text.Trim() == string.Empty)
            {
                MessageBox.Show("供货商不能为空！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_supplier_name.Focus();
                return;
            }

            if (nud_output_count.Value == 0)
            {
                MessageBox.Show("退货数量不能为0！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                nud_output_count.Select();
                return;
            }

            //判断时间有效性
            if (DateTime.Now.Date < dtp_output_checktime.Value.Date)
            {
                MessageBox.Show("请选择一个正确的验收日期！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtp_output_checktime.Select();
                return;
            }

            //判断时间有效性
            if (dtp_output_instorage_date.Value.Date > dtp_output_checktime.Value.Date)
            {
                MessageBox.Show("请选择一个正确的出库日期！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtp_output_instorage_date.Select();
                return;
            }

            if (txt_output_check_persion.Text.Trim() == "双击选择验收人..." || txt_output_check_persion.Text.Trim() == string.Empty)
            {
                MessageBox.Show("验收人不能为空！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_output_check_persion.Focus();
                return;
            }

            if (txt_output_quality_persion.Text.Trim() == "双击选择质管员..." || txt_output_quality_persion.Text.Trim() == string.Empty)
            {
                MessageBox.Show("质管员不能为空！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_output_quality_persion.Focus();
                return;
            }

            if (txt_output_oper.Text.Trim() == "双击选择业务员..." || txt_output_oper.Text.Trim() == string.Empty)
            {
                MessageBox.Show("业务员不能为空！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_output_oper.Focus();
                return;
            }

            if (txt_output_issued.Text.Trim() == "双击选择经办人..." || txt_output_issued.Text.Trim() == string.Empty)
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
                    outputStorageEntity.Output_instorage_date = Convert.ToDateTime(dtp_output_instorage_date.Value.ToString("yyyy-MM-dd"));
                    outputStorageEntity.Output_count = Convert.ToInt32(nud_output_count.Value);
                    outputStorageEntity.Input_code = inputCode;
                    outputStorageEntity.Output_packing_in = cmb_output_packing_in.Text.ToString();
                    outputStorageEntity.Output_packing_mid = cmb_output_packing_mid.Text.ToString();
                    outputStorageEntity.Output_packing_out = cmb_output_packing_out.Text.ToString();
                    outputStorageEntity.Output_oper = txt_output_oper.Text.ToString();
                    outputStorageEntity.Output_quality_persion = txt_output_quality_persion.Text.ToString();
                    outputStorageEntity.Output_issued = txt_output_issued.Text.ToString();
                    outputStorageEntity.Output_check_persion = txt_output_check_persion.Text.ToString();
                    outputStorageEntity.Output_backreason = txt_output_reback_reason.Text.ToString();
                    outputStorageEntity.Output_remark = txt_output_remark.Text.ToString();
                    outputStorageEntity.Output_type = "1";
                    outputStorageEntity.Operate_type = "0";

                    //赋值实体类
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
                BindingDgvOutputStorage();
            }
        }

        //***********************************************************************
        /// <summary>
        /// 添加后库存数目剪掉添加数目数据信息
        /// </summary>       
        /// <history>
        ///    完成信息：代国明      2010/07/22 完成   
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

        //***********************************************************************
        /// <summary>
        /// 双击text事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：代国明      2010/07/22 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void textBox_DoubleClick(object sender, EventArgs e)
        {
            switch (((TextBox)sender).Name)
            {
                //双击文本框弹出弹出产品信息窗体                
                case "txt_goods_name":
                    {   //判断当前页面的状态
                        if (dataType == DataType.Insert)
                        {
                            storageGoodsDialogForm sgd = new storageGoodsDialogForm("退货数量:");
                            sgd.ShowDialog();

                            if (sgd.goodName != string.Empty)
                            {
                                //产品名称
                                txt_goods_name.Text = sgd.goodName;

                                //退货数量
                                nud_output_count.Value = sgd.outputStorage1;

                                //入库编号
                                inputCode = sgd.inputCode;

                                //供货商名称
                                txt_supplier_name.Text = sgd.supplierName;

                                //库存数量临时表
                                tempStorageEntity = sgd.tempStorageEntity;
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
                default:
                    break;
            }
        }

        //***********************************************************************
        /// <summary>
        /// 删除后复原库存数目数据信息
        /// </summary>        
        /// <history>
        ///    完成信息：代国明      2010/07/22 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        void UpdateStorageDetailsbyDelete()
        {

            //取得树体类
            tempStorageEntity = new EntityTemp_storage();

            //赋值实体类
            tempStorageEntity.Goods_code = dgvOutputStorage.SelectedRows[0].Cells["input_goods_code"].Value.ToString();
            tempStorageEntity.Count = Convert.ToInt32(dgvOutputStorage.SelectedRows[0].Cells["output_count"].Value.ToString());

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
                if (dr["maintain_input_code"].ToString() == dgvOutputStorage.SelectedRows[0].Cells["input_code"].Value.ToString())
                {
                    f = true;
                }
            }

            return f;
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
                if (dr["input_code"].ToString() == dgvOutputStorage.SelectedRows[0].Cells["input_code"].Value.ToString() && dr["output_code"].ToString() != dgvOutputStorage.SelectedRows[0].Cells["output_code"].Value.ToString())
                {
                    return false;
                }
            }
            return true;
        }

        //***********************************************************************
        /// <summary>
        /// 删除按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：代国明      2010/07/22 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //设置按钮状态
            dataType = DataType.None;
            setButtonState();

            //结果符
            result = -1;
            countNum = 0;

            //取得单表类
            DataTable dtLose = GetLoseTable();

            //如果选择多条数据删除，提示
            if (dgvOutputStorage.SelectedRows.Count > 1)
            {
                MessageBox.Show("只能选择一条要作废的记录！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //如过画面中不存在数据，提示
            if (dgvOutputStorage.SelectedRows.Count < 1)
            {
                MessageBox.Show("请选择一条要作废的记录！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Boolean bs = JudgeMaintain();

            //弹出提示，确认删除
            if (MessageBox.Show("您确定要作废该数据吗？", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {

                    //初始化参数类
                    SearchParameter sp = new SearchParameter();

                    //设置主键
                    sp.SetValue(":OUTPUT_CODE", dgvOutputStorage.SelectedRows[0].Cells["output_code"].Value.ToString());
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
                            if (dr["input_code"].ToString() == dgvOutputStorage.SelectedRows[0].Cells["input_code"].Value.ToString())
                            {
                                flag = true;
                                break;
                            }
                        }

                        //如果报损表该删除的入库记录，将入库标识置为1
                        if (!flag && !bs)
                        {
                            inputStorageEntity = new EntityInput_storage();
                            inputStorageEntity.INPUT_CODE = dgvOutputStorage.SelectedRows[0].Cells["input_code"].Value.ToString();
                            inputStorageEntity.OPERATE_TYPE = '0';
                            getData.UpdateOperate_typeByInput_codeRow(inputStorageEntity);
                        }
                        else
                        {
                            inputStorageEntity = new EntityInput_storage();
                            inputStorageEntity.INPUT_CODE = dgvOutputStorage.SelectedRows[0].Cells["input_code"].Value.ToString();
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
                        BindingDgvOutputStorage();
                    }
                    else
                    {
                        MessageBox.Show("数据作废时发生错误，请检查数据库！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
        }

        //***********************************************************************
        /// <summary>
        /// 取消按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：代国明      2010/07/22 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //设置按钮状态
            dataType = DataType.None;
            setButtonState();

            //判断画面数据不为空
            if (dgvOutputStorage != null && dgvOutputStorage.SelectedRows.Count != 0)
            {

                //取得画面数据赋值文本框
                txt_supplier_name.Text = dgvOutputStorage.SelectedRows[0].Cells["supplier_name"].Value.ToString();
                nud_output_count.Value = Convert.ToInt32(dgvOutputStorage.SelectedRows[0].Cells["output_count"].Value.ToString());
                txt_output_reback_reason.Text = dgvOutputStorage.SelectedRows[0].Cells["output_backreason"].Value.ToString();
                txt_goods_name.Text = dgvOutputStorage.SelectedRows[0].Cells["goods_name"].Value.ToString();
                txt_output_check_persion.Text = dgvOutputStorage.SelectedRows[0].Cells["output_check_persion"].Value.ToString();
                txt_output_issued.Text = dgvOutputStorage.SelectedRows[0].Cells["output_issued"].Value.ToString();
                txt_output_oper.Text = dgvOutputStorage.SelectedRows[0].Cells["output_oper"].Value.ToString();
                cmb_output_packing_in.Text = dgvOutputStorage.SelectedRows[0].Cells["output_packing_in"].Value.ToString();
                cmb_output_packing_mid.Text = dgvOutputStorage.SelectedRows[0].Cells["output_packing_mid"].Value.ToString();
                cmb_output_packing_out.Text = dgvOutputStorage.SelectedRows[0].Cells["output_packing_out"].Value.ToString();
                txt_output_quality_persion.Text = dgvOutputStorage.SelectedRows[0].Cells["output_quality_persion"].Value.ToString();
                txt_output_remark.Text = dgvOutputStorage.SelectedRows[0].Cells["output_remark"].Value.ToString();
                dtp_output_checktime.Text = dgvOutputStorage.SelectedRows[0].Cells["output_checktime"].Value.ToString();
                dtp_output_instorage_date.Text = dgvOutputStorage.SelectedRows[0].Cells["output_instorage_date"].Value.ToString();
            }
            else
            {
                //清空文本框
                txt_supplier_name.Text = "";
                nud_output_count.Value = 0;
                txt_output_reback_reason.Text = "";
                txt_goods_name.Text = "";
                txt_output_check_persion.Text = "";
                txt_output_issued.Text = "";
                txt_output_oper.Text = "";
                txt_output_quality_persion.Text = "";
                txt_output_remark.Text = "";
                cmb_output_packing_in.SelectedIndex = 0;
                cmb_output_packing_mid.SelectedIndex = 0;
                cmb_output_packing_out.SelectedIndex = 0;
            }
            dgvOutputStorage.Focus();

        }

        //***********************************************************************
        /// <summary>
        /// 选择dataGridView事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：代国明      2010/07/22 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void dgvOutputStorage_SelectionChanged(object sender, EventArgs e)
        {
            //设定按钮状态
            dataType = DataType.None;
            setButtonState();


            if (dgvOutputStorage != null && dgvOutputStorage.SelectedRows.Count != 0)
            {
                //文本框赋值
                txt_supplier_name.Text = dgvOutputStorage.SelectedRows[0].Cells["supplier_name"].Value.ToString();
                nud_output_count.Value = Convert.ToInt32(dgvOutputStorage.SelectedRows[0].Cells["output_count"].Value.ToString());
                txt_output_reback_reason.Text = dgvOutputStorage.SelectedRows[0].Cells["output_backreason"].Value.ToString();
                txt_goods_name.Text = dgvOutputStorage.SelectedRows[0].Cells["goods_name"].Value.ToString();
                txt_output_check_persion.Text = dgvOutputStorage.SelectedRows[0].Cells["output_check_persion"].Value.ToString();
                txt_output_issued.Text = dgvOutputStorage.SelectedRows[0].Cells["output_issued"].Value.ToString();
                txt_output_oper.Text = dgvOutputStorage.SelectedRows[0].Cells["output_oper"].Value.ToString();
                cmb_output_packing_in.Text = dgvOutputStorage.SelectedRows[0].Cells["output_packing_in"].Value.ToString();
                cmb_output_packing_mid.Text = dgvOutputStorage.SelectedRows[0].Cells["output_packing_mid"].Value.ToString();
                cmb_output_packing_out.Text = dgvOutputStorage.SelectedRows[0].Cells["output_packing_out"].Value.ToString();
                txt_output_quality_persion.Text = dgvOutputStorage.SelectedRows[0].Cells["output_quality_persion"].Value.ToString();
                txt_output_remark.Text = dgvOutputStorage.SelectedRows[0].Cells["output_remark"].Value.ToString();
                dtp_output_checktime.Text = dgvOutputStorage.SelectedRows[0].Cells["output_checktime"].Value.ToString();
                dtp_output_instorage_date.Text = dgvOutputStorage.SelectedRows[0].Cells["output_instorage_date"].Value.ToString();
            }
            else
            {
                //文本框赋值
                txt_supplier_name.Text = "";
                nud_output_count.Value = 0;
                txt_output_reback_reason.Text = "";
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
            txt_output_code_Select.Text = "";
            txt_supplier_name_Select.Text = "";
        }

        private void dgvOutputStorage_Sorted(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvOutputStorage.Rows.Count; i++)
            {
                dgvOutputStorage.Rows[i].Cells["index"].Value = i + 1;
            }
        }

    }
}
