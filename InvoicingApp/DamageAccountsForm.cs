//***********************************************************************
//* 系统名称	    ：  长白ERP系统
//* 功能模块	    ：  系统信息
//* 功能画面		：  报损下账
//* 画面名称	    ：  DamageAccountsForm
//* 完成年月日      ：  2010/07/25
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
    ///报损下账功能
    /// </summary>
    /// <history>
    ///     完成信息：代国明      2010/07/25 完成  
    ///     更新信息：
    /// </history>
    //***********************************************************************
    public partial class DamageAccountsForm : Form
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
        /// 报损实体类
        /// </summary>
        EntityLose loseEntity = null;

        /// <summary>
        /// 入库日期
        /// </summary>
        public DateTime instorageDate;

        /// <summary>
        /// 库存临时表实体类
        /// </summary>
        EntityTemp_storage tempStorageEntity = null;

        /// <summary>
        /// 入库记录表实体类
        /// </summary>
        EntityInput_storage inputStorageEntity = null;

        /// <summary>
        /// 报损DataTable
        /// </summary>
        DataTable dtLose = null;

        /// <summary>
        /// 报损数据源
        /// </summary>
        private DataTable dtDgvLose = null;

        public DamageAccountsForm()
        {
            InitializeComponent();
            dgvLose.AutoGenerateColumns = false;
            this.dgvLose.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(239, 243, 251);
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
        private void GetDgvLose(DataTable dt)
        {
            //定义出库统计数据源表
            dtDgvLose = new DataTable();

            //添加各个数据列
            dtDgvLose.Columns.Add("goods_name", typeof(string));
            dtDgvLose.Columns.Add("lose_code", typeof(string));
            dtDgvLose.Columns.Add("input_code", typeof(string));
            dtDgvLose.Columns.Add("input_goods_code", typeof(string));
            dtDgvLose.Columns.Add("lose_count", typeof(string));
            dtDgvLose.Columns.Add("goods_unit", typeof(string));
            dtDgvLose.Columns.Add("goods_type", typeof(string));
            dtDgvLose.Columns.Add("maker_name", typeof(string));
            dtDgvLose.Columns.Add("input_batch_num", typeof(string));
            dtDgvLose.Columns.Add("input_maketime", typeof(string));
            dtDgvLose.Columns.Add("goods_validity", typeof(string));
            dtDgvLose.Columns.Add("lose_applier", typeof(string));
            dtDgvLose.Columns.Add("lose_checker", typeof(string));
            dtDgvLose.Columns.Add("lose_result", typeof(string));

            dtDgvLose.Columns.Add("lose_datetime", typeof(string));
            dtDgvLose.Columns.Add("lose_reason", typeof(string));
            dtDgvLose.Columns.Add("lose_remark", typeof(string));
            dtDgvLose.Columns.Add("goods_reg_num", typeof(string));
            //遍历数据源
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dtDgvLose.NewRow();

                dr["goods_name"] = dt.Rows[i]["goods_name"].ToString();
                dr["lose_code"] = dt.Rows[i]["lose_code"].ToString();
                dr["input_code"] = dt.Rows[i]["input_code"].ToString();
                dr["input_goods_code"] = dt.Rows[i]["input_goods_code"].ToString();
                dr["lose_count"] = dt.Rows[i]["lose_count"].ToString();
                dr["goods_unit"] = dt.Rows[i]["goods_unit"].ToString();
                dr["goods_type"] = dt.Rows[i]["goods_type"].ToString();
                dr["maker_name"] = dt.Rows[i]["maker_name"].ToString();
                dr["input_batch_num"] = dt.Rows[i]["input_batch_num"].ToString();
                dr["goods_reg_num"] = dt.Rows[i]["goods_reg_num"].ToString();

                dr["goods_validity"] = dt.Rows[i]["goods_validity"].ToString();
                dr["lose_applier"] = dt.Rows[i]["lose_applier"].ToString();
                dr["lose_checker"] = dt.Rows[i]["lose_checker"].ToString();
                dr["lose_result"] = dt.Rows[i]["lose_result"].ToString();
                dr["lose_reason"] = dt.Rows[i]["lose_reason"].ToString();
                dr["lose_remark"] = dt.Rows[i]["lose_remark"].ToString();

                if (dt.Rows[i]["input_maketime"].ToString().Equals(string.Empty))
                {
                    dr["input_maketime"] = "";
                }
                else
                {
                    dr["input_maketime"] = DateTime.Parse(dt.Rows[i]["input_maketime"].ToString()).ToString("yyyy-MM-dd");
                }

                if (dt.Rows[i]["lose_datetime"].ToString().Equals(string.Empty))
                {
                    dr["lose_datetime"] = "";
                }
                else
                {
                    dr["lose_datetime"] = DateTime.Parse(dt.Rows[i]["lose_datetime"].ToString()).ToString("yyyy-MM-dd");
                }
               
                dtDgvLose.Rows.Add(dr);
            }
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
        ///     完成信息：代国明      2010/07/25 完成   
        ///     更新信息：
        /// </history>
        //*******************************************************************
        private void setButtonState()
        {
            switch (dataType)
            {
                case DataType.None:
                    txt_lose_reason.ReadOnly = true;
                    txt_lose_remark.ReadOnly = true;
                    dtp_lose_datetime.Enabled = false;
                    txt_lose_checker.BackColor = Color.FromArgb(236, 233, 216);
                    txt_lose_applier.BackColor = Color.FromArgb(236, 233, 216);
                    txt_input_code.BackColor = Color.FromArgb(236, 233, 216);

                    btnAdd.Enabled = true;
                    btnDelete.Enabled = true;
                    btnCommit.Enabled = false;
                    btnCancel.Enabled = false;
                    
                    break;
                case DataType.Insert:
                    txt_lose_reason.ReadOnly = false;
                    txt_lose_remark.ReadOnly = false;
                    dtp_lose_datetime.Enabled = true;

                    //添加时，同时清空文本框     
                    txt_lose_remark.Text = "";
                    txt_lose_reason.Text = "";
                    nud_lose_count.Value = 0;
                    txt_lose_checker.Text = "双击选择报损核准人...";
                    txt_lose_checker.BackColor = Color.FromArgb(255, 255, 255);
                    txt_lose_applier.Text = "双击选择报损申请人...";
                    txt_lose_applier.BackColor = Color.FromArgb(255, 255, 255);
                    txt_input_code.Text = "双击选择入库编号...";
                    txt_input_code.BackColor = Color.FromArgb(255, 255, 255);
                    txt_goods_name.Text = "";
                    dtp_lose_datetime.Value = DateTime.Now;

                    btnDelete.Enabled = false;
                    btnAdd.Enabled = false;
                    btnCommit.Enabled = true;
                    btnCancel.Enabled = true;
                    break;
                default:
                    txt_lose_reason.ReadOnly = true;
                    txt_lose_remark.ReadOnly = true;                  
                    dtp_lose_datetime.Enabled = false;

                    btnAdd.Enabled = true;
                    btnDelete.Enabled = true;
                    btnCommit.Enabled = false;
                    btnCancel.Enabled = false;
                   
                    break;
            }
        }

        //*******************************************************************
        /// <summary>
        /// 绑定画面
        /// </summary>
        /// <history>
        ///     完成信息：代国名      2010/07/25 完成   
        ///     更新信息：
        /// </history>
        //*******************************************************************
        private void BandingDgvLose()
        {            
            try
            {
                //初始化参数类
                SearchParameter sp = new SearchParameter();                           

                //打开数据库连接
                dataAccess = new DataAccess();
                dataAccess.Open();               

                //取得操作类
                GetData getData = new GetData(dataAccess.Connection);

                //取得单表数据
                dtLose = getData.GetTableBySqlStr(Constants.SqlStr.TC_LOSE_LEFTJOIN_TC_INPUT_STORAGE_LEFTJOIN_TC_GOODS_LEFTJOIN_TC_MAKER, sp);

                //如果为NULL，报错
                if (dtLose == null)
                {
                    MessageBox.Show("请查看数据库是否正常！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
               
                //绑定画面
                if (dtLose.Rows.Count >= 0)
                {
                    GetDgvLose(dtLose);

                    dtDgvLose.Columns.Add("goodsValidate", typeof(DateTime));
                    for (int i = 0; i < dtDgvLose.Rows.Count; i++)
                    {
                        
                        int validity = int.Parse(dtDgvLose.Rows[i]["goods_validity"].ToString());
                        DateTime goodSValidity = DateTime.Parse(dtDgvLose.Rows[i]["input_maketime"].ToString()).AddMonths(validity);
                        dtDgvLose.Rows[i]["goodsValidate"] = goodSValidity;

                    }

                    //添加序列号
                    int countNumber = 0;
                    dtDgvLose.Columns.Add("index", typeof(int));
                    for (int i = 0; i < dtDgvLose.Rows.Count; i++)
                    {
                        dtDgvLose.Rows[i]["index"] = ++countNumber;

                    }

                    //绑定数据                    
                    dgvLose.DataSource = dtDgvLose;
                }                  

                if (dgvLose != null && dgvLose.Rows.Count > 0 && countNum != 0)
                {
                    dgvLose.Rows[0].Selected = false;
                    dgvLose.Rows[countNum].Selected = true;
                    dgvLose.FirstDisplayedScrollingRowIndex = countNum;
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
        /// 画面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：代国明      2010/07/25 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void DamageAccountsForm_Load(object sender, EventArgs e)
        {
            
            //绑定画面
            BandingDgvLose();

            //设定按钮状态
            dataType = DataType.None;
            setButtonState();
            txt_input_code_Select.Focus();
            dgvLose.AutoGenerateColumns = false;

        }

        //***********************************************************************
        /// <summary>
        /// 查询按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：代国明      2010/07/25 完成   
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
                //初始化参数类
                SearchParameter sp = new SearchParameter();

                //条件不为空，添加参数
                if (txt_goods_name_Select.Text.Trim() != string.Empty)
                {
                    sp.SetValue(":TC_GOODS.GOODS_NAME", txt_goods_name_Select.Text);
                }

                if (txt_input_code_Select.Text.Trim() != string.Empty)
                {
                    sp.SetValue(":TC_INPUT_STORAGE.INPUT_CODE", txt_input_code_Select.Text);

                }

                //打开数据库连接
                dataAccess = new DataAccess();
                dataAccess.Open();

                //取得操作类
                GetData getData = new GetData(dataAccess.Connection);

                //取得单表数据
                dtLose = getData.GetTableBySqlStr(Constants.SqlStr.TC_LOSE_LEFTJOIN_TC_INPUT_STORAGE_LEFTJOIN_TC_GOODS_LEFTJOIN_TC_MAKER, sp);

                //如果为NULL，报错
                if (dtLose == null)
                {
                    MessageBox.Show("请查看数据库是否正常！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                GetDgvLose(dtLose);

                dtDgvLose.Columns.Add("goodsValidate", typeof(DateTime));
                for (int i = 0; i < dtDgvLose.Rows.Count; i++)
                {
                    int validity = int.Parse(dtDgvLose.Rows[i]["goods_validity"].ToString());
                    DateTime goodSValidity = DateTime.Parse(dtDgvLose.Rows[i]["input_maketime"].ToString()).AddMonths(validity);
                    dtDgvLose.Rows[i]["goodsValidate"] = goodSValidity;

                }

                //添加序列号
                int countNumber = 0;
                dtDgvLose.Columns.Add("index", typeof(int));
                for (int i = 0; i < dtDgvLose.Rows.Count; i++)
                {
                    dtDgvLose.Rows[i]["index"] = ++countNumber;

                }

                //没有数据
                if (dtLose.Rows.Count == 0)
                {

                    //给出提示
                    MessageBox.Show("数据不存在，请查看输入的条件是否正确！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                   
                }

                dgvLose.DataSource = dtDgvLose;
               
                if (dgvLose != null && dgvLose.Rows.Count > 0 && countNum != 0)
                {
                    dgvLose.Rows[0].Selected = false;
                    dgvLose.Rows[countNum].Selected = true;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //设定按钮状态
            dataType = DataType.Insert;
            setButtonState();
            txt_input_code.Focus();
        }

        //***********************************************************************
        /// <summary>
        /// 确认按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：代国明      2010/07/25 完成   
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
            
            //条件不为空
            if (txt_input_code.Text.Trim() == string.Empty || txt_input_code.Text.Trim() == "双击选择入库编号...")
            {
                MessageBox.Show("入库编号不能为空！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_input_code.Focus();
                return;
            }

            if (txt_goods_name.Text.Trim() == string.Empty)
            {
                MessageBox.Show("产品编号不能为空！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_goods_name.Focus();
                return;
            }

            //判断时间有效性
            if (DateTime.Now.Date < dtp_lose_datetime.Value.Date)
            {
                MessageBox.Show("报损日期不能大于今天！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtp_lose_datetime.Focus();
                return;
            }
            if (instorageDate > dtp_lose_datetime.Value.Date)
            {
                MessageBox.Show("报损日期不能小于入库日期！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtp_lose_datetime.Focus();
                return;
            }

            if (txt_lose_applier.Text.Trim() == "双击选择报损申请人..." || txt_lose_applier.Text.Trim() == string.Empty)
            {
                MessageBox.Show("报损申请人不能为空！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_lose_applier.Focus();
                return;
            }

            if (txt_lose_checker.Text.Trim() == "双击选择报损核准人..." || txt_lose_checker.Text.Trim() == string.Empty)
            {
                MessageBox.Show("报损核准人不能为空！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_lose_checker.Focus();
                return;
            }           

            //添加,修改后库存数目剪掉添加数目数据信息
            UpdateStorageDetailsByAdd();

            try
            {

                result = -1;

                //如果是添加
                if (dataType == DataType.Insert)
                {

                    //取得实体类
                    loseEntity = new EntityLose();

                    //赋值实体类
                    loseEntity.Input_code = txt_input_code.Text.ToString();
                    loseEntity.Lose_applier = txt_lose_applier.Text.ToString();
                    loseEntity.Lose_checker = txt_lose_checker.Text.ToString();
                    loseEntity.Lose_count = int.Parse(nud_lose_count.Value.ToString());
                    loseEntity.Lose_reason = txt_lose_reason.Text.ToString();
                    loseEntity.Lose_remark = txt_lose_remark.Text.ToString();
                    loseEntity.Lose_result = txt_lose_result.Text.ToString();
                    loseEntity.Lose_datetime = Convert.ToDateTime(dtp_lose_datetime.Value.ToString("yyyy-MM-dd"));

                    //赋值实体类
                    inputStorageEntity = new EntityInput_storage();
                    inputStorageEntity.OPERATE_TYPE = '1';
                    inputStorageEntity.INPUT_CODE = txt_input_code.Text.ToString();

                    //打开数据库连接
                    dataAccess = new DataAccess();
                    dataAccess.Open();

                    //取得操作类
                    GetData getData = new GetData(dataAccess.Connection);

                    //生成主键
                    MakePrimaryKey mpk = new MakePrimaryKey(dataAccess.Connection, dataAccess.Transaction);

                    loseEntity.Lose_code = mpk.MakeCode("报损表");

                    //取得结果符
                    result = getData.InsertLoseRow(loseEntity);

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
                MessageBox.Show("数据时发生错误，请检查数据库！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            finally
            {

               
                //关闭数据库连接
                dataAccess.Close();

            }

            //设置按钮状态
            dataType = DataType.None;
            setButtonState();

            //重新加载画面
            BandingDgvLose();
        }

        //***********************************************************************
        /// <summary>
        /// 添加后库存数目剪掉添加数目数据信息
        /// </summary>        
        /// <history>
        ///    完成信息：代国明      2010/07/25 完成   
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
        ///     完成信息：代国明      2010/07/25 完成   
        ///     更新信息：
        /// </history>
        //*******************************************************************
        private void textBox_DoubleClick(object sender, EventArgs e)
        {
            switch (((TextBox)sender).Name)
            {
                //双击文本框弹出弹出产品信息窗体                
                case "txt_input_code":
                    {   //判断当前页面的状态
                        if (dataType == DataType.Insert)
                        {
                            storageGoodsDialogForm sgd = new storageGoodsDialogForm("报损数量:");
                            sgd.ShowDialog();
                            if (sgd.inputCode != string.Empty)
                            {
                                txt_goods_name.Text = sgd.goodName;
                                nud_lose_count.Value = sgd.outputStorage1;
                                txt_input_code.Text = sgd.inputCode;
                                tempStorageEntity = sgd.tempStorageEntity;
                                instorageDate = sgd.instorageDate;
                            }

                        }
                        break;

                    }

                //双击文本框弹出弹出员工信息窗体
                case "txt_lose_applier":
                    {
                        //判断当前页面的状态
                        if (dataType == DataType.Insert)
                        {
                            StaffForm child = new StaffForm();
                            child.ShowDialog();
                            if(child.staffName != string.Empty)
                            txt_lose_applier.Text = child.staffName;
                        }
                        break;

                    }

                //双击文本框弹出弹出员工信息窗体
                case "txt_lose_checker":
                    {
                        //判断当前页面的状态
                        if (dataType == DataType.Insert)
                        {
                            StaffForm child = new StaffForm();
                            child.ShowDialog();
                            if (child.staffName != string.Empty)
                            txt_lose_checker.Text = child.staffName;
                        }
                        break;
                    }
                default:
                    break;
            }
        }

        //***********************************************************************
        /// <summary>
        /// 获得出库表
        /// </summary>
        /// <return>dtLose</return>
        /// <history>
        ///    完成信息：代国明      2010/07/25 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private DataTable GetOutputStorageTable()
        {
            //取得单表数据
            DataTable dtOutputStorage = null; ;

            try
            {
                //添加参数
                SearchParameter sp = new SearchParameter();

                sp.SetValue(":OUTPUT_TYPE", "1");

                //打开数据库连接
                dataAccess = new DataAccess();
                dataAccess.Open();

                //取得操作类
                GetData getData = new GetData(dataAccess.Connection);

                //取得单表数据
                dtOutputStorage = getData.GetSingleTableByCondition("tc_output_storage", sp);
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
        /// 删除后复原库存数目数据信息
        /// </summary>        
        /// <history>
        ///    完成信息：代国明      2010/07/25 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        void UpdateStorageDetailsbyDelete()
        {

            //取得树体类
            tempStorageEntity = new EntityTemp_storage();

            //赋值实体类
            tempStorageEntity.Goods_code = dgvLose.SelectedRows[0].Cells["input_goods_code"].Value.ToString();
            tempStorageEntity.Count = Convert.ToInt32(dgvLose.SelectedRows[0].Cells["lose_count"].Value.ToString());

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
        ///判断报损表里有没有入库编号相同的记录，有返回false，无返回true
        /// </summary>        
        /// <history>
        ///    完成信息：代国明      2010/07/25 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private Boolean JudgeLose()
        {
            DataTable dt = dtLose;
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["input_code"].ToString() == dgvLose.SelectedRows[0].Cells["input_code"].Value.ToString() && dr["lose_code"].ToString() != dgvLose.SelectedRows[0].Cells["lose_code"].Value.ToString())
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
                if (dr["maintain_input_code"].ToString() == dgvLose.SelectedRows[0].Cells["input_code"].Value.ToString())
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
        ///    完成信息：代国明      2010/07/25 完成   
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

            //如果选择多条数据删除，提示
            if (dgvLose.SelectedRows.Count > 1)
            {
                MessageBox.Show("只能选择一条要作废的记录！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //如过画面中不存在数据，提示
            if (dgvLose.SelectedRows.Count < 1)
            {
                MessageBox.Show("请选择一条要作废的记录！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //取得单表类
            DataTable dtOutputStorage = GetOutputStorageTable();

            Boolean bs = JudgeMaintain();

            if (MessageBox.Show("您确定要作废该数据吗？", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {

                    //初始化参数类
                    SearchParameter sp = new SearchParameter();

                    //设置主键
                    sp.SetValue(":LOSE_CODE", dgvLose.SelectedRows[0].Cells["lose_code"].Value.ToString());
                    //打开数据库
                    dataAccess = new DataAccess();
                    dataAccess.Open();

                    //打开事务
                    dataAccess.BeginTransaction();

                    //取得操作类
                    GetData getData = new GetData(dataAccess.Connection, dataAccess.Transaction);

                    //判断报损表是否有标识
                    Boolean flag = false;

                    if (JudgeLose())
                    {
                        //遍历报损表
                        foreach (DataRow dr in dtOutputStorage.Rows)
                        {
                            if (dr["input_code"].ToString() == dgvLose.SelectedRows[0].Cells["input_code"].Value.ToString())
                            {
                                flag = true;
                                break;
                            }
                        }

                        //如果报损表该删除的入库记录，将入库标识置为0
                        if (!flag && !bs)
                        {
                            //弹出提示，确认删除

                            inputStorageEntity = new EntityInput_storage();
                            inputStorageEntity.INPUT_CODE = dgvLose.SelectedRows[0].Cells["input_code"].Value.ToString();
                            inputStorageEntity.OPERATE_TYPE = '0';
                            getData.UpdateOperate_typeByInput_codeRow(inputStorageEntity);

                        }
                        else
                        {
                            inputStorageEntity = new EntityInput_storage();
                            inputStorageEntity.INPUT_CODE = dgvLose.SelectedRows[0].Cells["input_code"].Value.ToString();
                            inputStorageEntity.OPERATE_TYPE = '1';
                            getData.UpdateOperate_typeByInput_codeRow(inputStorageEntity);

                        }
                    }



                    //取得结果符
                    result = getData.DeleteRow("tc_lose", sp);

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
                        BandingDgvLose();
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
        ///    完成信息：代国明      2010/07/25 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //设置按钮状态
            dataType = DataType.None;
            setButtonState();

            //判断画面数据不为空
            if (dgvLose != null && dgvLose.SelectedRows.Count != 0)
            {

                //取得画面数据赋值文本框
                txt_goods_name.Text = dgvLose.SelectedRows[0].Cells["goods_name"].Value.ToString();
                txt_input_code.Text = dgvLose.SelectedRows[0].Cells["input_code"].Value.ToString();
                txt_lose_applier.Text = dgvLose.SelectedRows[0].Cells["lose_applier"].Value.ToString();
                txt_lose_checker.Text = dgvLose.SelectedRows[0].Cells["lose_checker"].Value.ToString();
                nud_lose_count.Value = int.Parse(dgvLose.SelectedRows[0].Cells["lose_count"].Value.ToString());
                txt_lose_reason.Text = dgvLose.SelectedRows[0].Cells["lose_reason"].Value.ToString();
                txt_lose_remark.Text = dgvLose.SelectedRows[0].Cells["lose_remark"].Value.ToString();               
                dtp_lose_datetime.Value = Convert.ToDateTime(dgvLose.SelectedRows[0].Cells["lose_datetime"].Value.ToString());
            }
            else
            {
                txt_goods_name.Text = "";
                txt_input_code.Text = "";
                txt_lose_applier.Text = "";
                txt_lose_checker.Text = "";
                nud_lose_count.Value = 0;
                txt_lose_reason.Text = "";
                txt_lose_remark.Text = "";
                //txt_lose_result.Text = "";
            }
            dgvLose.Focus();
        }

        //***********************************************************************
        /// <summary>
        /// 选择dataGridView事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：代国明      2010/07/26 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void dgvLose_SelectionChanged(object sender, EventArgs e)
        {
            //设定按钮状态
            dataType = DataType.None;
            setButtonState();


            if (dgvLose != null && dgvLose.SelectedRows.Count != 0)
            {
                //文本框赋值                
                txt_goods_name.Text = dgvLose.SelectedRows[0].Cells["goods_name"].Value.ToString();
                txt_input_code.Text = dgvLose.SelectedRows[0].Cells["input_code"].Value.ToString();
                txt_lose_applier.Text = dgvLose.SelectedRows[0].Cells["lose_applier"].Value.ToString();
                txt_lose_checker.Text = dgvLose.SelectedRows[0].Cells["lose_checker"].Value.ToString();
                nud_lose_count.Value = int.Parse(dgvLose.SelectedRows[0].Cells["lose_count"].Value.ToString());
                txt_lose_reason.Text = dgvLose.SelectedRows[0].Cells["lose_reason"].Value.ToString();
                txt_lose_remark.Text = dgvLose.SelectedRows[0].Cells["lose_remark"].Value.ToString();
                //txt_lose_result.Text = dgvLose.SelectedRows[0].Cells["lose_result"].Value.ToString();
                dtp_lose_datetime.Value = Convert.ToDateTime(dgvLose.SelectedRows[0].Cells["lose_datetime"].Value.ToString());
            }
            else
            {
                //文本框赋值                
                txt_goods_name.Text = "";
                txt_input_code.Text = "";
                txt_lose_applier.Text = "";
                txt_lose_checker.Text = "";
                nud_lose_count.Value = 0;
                txt_lose_reason.Text = "";
                txt_lose_remark.Text = "";                              
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txt_goods_name_Select.Text = "";
            txt_input_code_Select.Text = "";           
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

