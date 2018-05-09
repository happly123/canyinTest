//***********************************************************************
//* 系统名称	    ：  长白ERP系统
//* 功能模块	    ：  基础平台
//* 功能画面		：  客户管理
//* 画面名称	    ：  CustomerUnitManageForm
//* 完成年月日      ：  2010/07/13
//* 作者		    ：  李梓楠
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
    ///客户管理功能
    /// </summary>
    /// <history>
    ///     完成信息：李梓楠      2010/07/13 完成  
    ///     更新信息：
    /// </history>
    //***********************************************************************
    public partial class CustomerUnitManageForm : Form
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


        public CustomerUnitManageForm()
        {
            
            InitializeComponent();
            this.dgvCustomer.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(239, 243, 251);

        }

        //按钮状态类型
        public enum DataType
        {
            Update = 0x0001,
            Insert = 0x0002,
            Success = 0x0003,
            None = 0x0004,

        }
        //*******************************************************************
        /// <summary>
        /// 设置按钮，文本框状态
        /// </summary>
        /// <history>
        ///     完成信息：李梓楠      2010/07/13 完成   
        ///     更新信息：
        /// </history>
        //*******************************************************************
        private void setButtonState()
        {
            switch (dataType)
            {
                case DataType.None:
                case DataType.Success:
                    txtCustomer_code.ReadOnly = true;
                    txtCustomer_name.ReadOnly = true;
                    txtCustomer_yxm.ReadOnly = true;
                    txtCustomer_artificial_person.ReadOnly = true;
                    txtCustomer_bank.ReadOnly = true;
                    txtCustomer_bank_num.ReadOnly = true;
                    txtCustomer_address.ReadOnly = true;
                    txtCustomer_principal.ReadOnly = true;
                    txtCustomer_tariff_num.ReadOnly = true;
                    txtCustomer_licence.ReadOnly = true;
                    txtCustomer_business_licence.ReadOnly = true;
                    txtCustomer_tel.ReadOnly = true;
                    txtCustomer_fax.ReadOnly = true;
                    txtCustomer_postal_code.ReadOnly = true;
                    txtCustomer_medical_institutions.ReadOnly = true;
                    txtCustomer_quality.ReadOnly = true;

                    cb_customer_type.Enabled = false;

                    btnInsert.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnCommit.Enabled = false;
                    btnCancel.Enabled = false;

                    
                    break;
                case DataType.Insert:
                    txtCustomer_code.ReadOnly = true;
                    txtCustomer_name.ReadOnly = false;
                    txtCustomer_yxm.ReadOnly = true;
                    txtCustomer_artificial_person.ReadOnly = false;
                    txtCustomer_bank.ReadOnly = false;
                    txtCustomer_bank_num.ReadOnly = false;
                    txtCustomer_address.ReadOnly = false;
                    txtCustomer_principal.ReadOnly = false;
                    txtCustomer_tariff_num.ReadOnly = false;
                    txtCustomer_licence.ReadOnly = false;
                    txtCustomer_business_licence.ReadOnly = false;
                    txtCustomer_tel.ReadOnly = false;
                    txtCustomer_fax.ReadOnly = false;
                    txtCustomer_postal_code.ReadOnly = false;
                    txtCustomer_medical_institutions.ReadOnly = false;
                    txtCustomer_quality.ReadOnly = false;

                    cb_customer_type.Enabled = true;

                    txtCustomer_code.Text = "";
                    txtCustomer_name.Text = "";
                    txtCustomer_yxm.Text = "";
                    txtCustomer_artificial_person.Text = "";
                    txtCustomer_bank.Text = "";
                    txtCustomer_bank_num.Text = "";
                    txtCustomer_address.Text = "";
                    txtCustomer_principal.Text = "";
                    txtCustomer_tariff_num.Text = "";
                    txtCustomer_licence.Text = "";
                    txtCustomer_business_licence.Text = "";
                    txtCustomer_tel.Text = "";
                    txtCustomer_fax.Text = "";
                    txtCustomer_postal_code.Text = "";
                    txtCustomer_medical_institutions.Text = "";
                    txtCustomer_quality.Text = "";
                    cb_customer_type.SelectedIndex = 0;

                    btnInsert.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnCommit.Enabled = true;
                    btnCancel.Enabled = true;

                    
                    break;
                case DataType.Update:
                    txtCustomer_code.ReadOnly = true;
                    txtCustomer_name.ReadOnly = false;
                    txtCustomer_yxm.ReadOnly = true;
                    txtCustomer_artificial_person.ReadOnly = false;
                    txtCustomer_bank.ReadOnly = false;
                    txtCustomer_bank_num.ReadOnly = false;
                    txtCustomer_address.ReadOnly = false;
                    txtCustomer_principal.ReadOnly = false;
                    txtCustomer_tariff_num.ReadOnly = false;
                    txtCustomer_licence.ReadOnly = false;
                    txtCustomer_business_licence.ReadOnly = false;
                    txtCustomer_tel.ReadOnly = false;
                    txtCustomer_fax.ReadOnly = false;
                    txtCustomer_postal_code.ReadOnly = false;
                    txtCustomer_medical_institutions.ReadOnly = false;
                    txtCustomer_quality.ReadOnly = false;

                    cb_customer_type.Enabled = true;

                    btnInsert.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnCommit.Enabled = true;
                    btnCancel.Enabled = true;

                    
                    break;
                default:
                    txtCustomer_code.ReadOnly = true;
                    txtCustomer_name.ReadOnly = true;
                    txtCustomer_yxm.ReadOnly = true;
                    txtCustomer_artificial_person.ReadOnly = true;
                    txtCustomer_bank.ReadOnly = true;
                    txtCustomer_bank_num.ReadOnly = true;
                    txtCustomer_address.ReadOnly = true;
                    txtCustomer_principal.ReadOnly = true;
                    txtCustomer_tariff_num.ReadOnly = true;
                    txtCustomer_licence.ReadOnly = true;
                    txtCustomer_business_licence.ReadOnly = true;
                    txtCustomer_tel.ReadOnly = true;
                    txtCustomer_fax.ReadOnly = true;
                    txtCustomer_postal_code.ReadOnly = true;
                    txtCustomer_medical_institutions.ReadOnly = true;
                    txtCustomer_quality.ReadOnly = true;

                    cb_customer_type.Enabled = false;

                    btnInsert.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = false;
                    btnCommit.Enabled = false;
                    btnCancel.Enabled = false;

                   
                    break;
            }
        }

        //***********************************************************************
        /// <summary>
        /// 画面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：李梓楠      2010/07/13 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void CustomerUnitManageForm_Load(object sender, EventArgs e)
        {
            dgvCustomer.AutoGenerateColumns = false;
            BandingDgv();
            setButtonState();
        }

        //***********************************************************************
        /// <summary>
        /// 选择画面数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：李梓楠      2010/07/13 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            //设定按钮状态
            dataType = DataType.None;
            setButtonState();


            if (dgvCustomer != null && dgvCustomer.SelectedRows.Count != 0)
            {
                txtCustomer_code.Text = dgvCustomer.SelectedRows[0].Cells["CUSTOMER_CODE"].Value.ToString();
                txtCustomer_name.Text = dgvCustomer.SelectedRows[0].Cells["CUSTOMER_NAME"].Value.ToString();
                txtCustomer_yxm.Text = dgvCustomer.SelectedRows[0].Cells["CUSTOMER_YXM"].Value.ToString();
                txtCustomer_artificial_person.Text = dgvCustomer.SelectedRows[0].Cells["CUSTOMER_ARTIFICIAL_PERSON"].Value.ToString();
                txtCustomer_bank.Text = dgvCustomer.SelectedRows[0].Cells["CUSTOMER_BANK"].Value.ToString();
                txtCustomer_bank_num.Text = dgvCustomer.SelectedRows[0].Cells["CUSTOMER_BANK_NUM"].Value.ToString();
                txtCustomer_address.Text = dgvCustomer.SelectedRows[0].Cells["CUSTOMER_ADDRESS"].Value.ToString();
                txtCustomer_principal.Text = dgvCustomer.SelectedRows[0].Cells["CUSTOMER_PRINCIPAL"].Value.ToString();
                txtCustomer_tariff_num.Text = dgvCustomer.SelectedRows[0].Cells["CUSTOMER_TARIFF_NUM"].Value.ToString();
                txtCustomer_licence.Text = dgvCustomer.SelectedRows[0].Cells["CUSTOMER_LICENCE"].Value.ToString();
                txtCustomer_business_licence.Text = dgvCustomer.SelectedRows[0].Cells["CUSTOMER_BUSINESS_LICENCE"].Value.ToString();
                txtCustomer_tel.Text = dgvCustomer.SelectedRows[0].Cells["CUSTOMER_TEL"].Value.ToString();
                txtCustomer_fax.Text = dgvCustomer.SelectedRows[0].Cells["CUSTOMER_FAX"].Value.ToString();
                txtCustomer_postal_code.Text = dgvCustomer.SelectedRows[0].Cells["CUSTOMER_POSTAL_CODE"].Value.ToString();
                txtCustomer_medical_institutions.Text = dgvCustomer.SelectedRows[0].Cells["CUSTOMER_MEDICAL_INSTITUTIONS"].Value.ToString();
                txtCustomer_quality.Text = dgvCustomer.SelectedRows[0].Cells["CUSTOMER_QUALITY"].Value.ToString();
                cb_customer_type.Text = dgvCustomer.SelectedRows[0].Cells["customer_type"].Value.ToString();

            }
        }

        //***********************************************************************
        /// <summary>
        /// 查询按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：李梓楠      2010/07/13 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnSelect_Click(object sender, EventArgs e)
        {
            //判断非法字符
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
            try
            {
                SearchParameter sp = new SearchParameter();

                if (txtCustomer_nameSelect.Text.Trim() != string.Empty)
                {
                    sp.SetValue(":CUSTOMER_NAME", txtCustomer_nameSelect.Text);
                }

                if (txtCustomer_yxmSelect.Text.Trim() != string.Empty)
                {
                    sp.SetValue(":CUSTOMER_YXM", txtCustomer_yxmSelect.Text);

                }

                sp.SetValue(":customer_flag", "0");

                dataAccess = new DataAccess();
                dataAccess.Open();

                GetData getData = new GetData(dataAccess.Connection);

                DataTable dtCondition = getData.GetSingleTableByCondition("TC_CUSTOMER", sp);

                if (dtCondition == null)
                {
                    MessageBox.Show("请查看数据库是否正常！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                dtCondition.Columns.Add("index", typeof(int));
                
                for (int i = 0; i < dtCondition.Rows.Count; i++)
                {
                    dtCondition.Rows[i]["index"] = i + 1;
                }
                
                    dgvCustomer.DataSource = dtCondition;

                if (dtCondition.Rows.Count == 0)
                {
                    dataType = DataType.Insert;
                    setButtonState();
                    dataType = DataType.None;
                    setButtonState();
                    MessageBox.Show("数据不存在，请查看输入的条件是否正确！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("请查看数据库是否正常！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);                    
            }
            finally
            {
                dataAccess.Close();
            }
        }
        /// <summary>
        /// 删除按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：李梓楠      2010/07/13 完成   
        ///    更新信息：
        /// </history>
        
        private void btnDelete_Click(object sender, EventArgs e)
        {


            result = -1;
            countNum = 0;
            if (dgvCustomer.SelectedRows.Count > 1)
            {
                MessageBox.Show("只能选择一条要删除的记录！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dgvCustomer.SelectedRows.Count < 1)
            {
                MessageBox.Show("请选择一条要删除的记录！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SearchParameter sp = new SearchParameter();
            dataAccess = new DataAccess();
            sp.SetValue(":customer_code", dgvCustomer.SelectedRows[0].Cells["CUSTOMER_CODE"].Value.ToString());
            try
            {
                dataAccess.Open();
                GetData gd = new GetData(dataAccess.Connection);
                DataTable dt = gd.GetSingleTableByCondition("TC_OUTPUT_STORAGE", sp);
                if (dt != null && dt.Rows.Count > 0)
                {
                    MessageBox.Show("此客户信息已经被使用，无法删除！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("数据删除时发生错误，请检查数据库！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                dataAccess.Close();
            }
            
            if (MessageBox.Show("您确定要删除该数据吗？", this.Text, MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    sp.Clear();
                    sp.SetValue(":CUSTOMER_CODE", dgvCustomer.SelectedRows[0].Cells["CUSTOMER_CODE"].Value.ToString());

                    dataAccess.Open();
                    dataAccess.BeginTransaction();
                    GetData getData = new GetData(dataAccess.Connection, dataAccess.Transaction);

                    result = getData.DeleteRow("TC_CUSTOMER", sp);

                    dataAccess.Commit();
                }
                catch (Exception ex)
                {
                    dataAccess.Rollback();
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    dataAccess.Close();
                   
                }
                if (result == 0)
                {
                    MessageBox.Show("数据已经被成功删除！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BandingDgv();

                }
                else
                {
                    MessageBox.Show("数据删除时发生错误，请检查数据库！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        //*******************************************************************
        /// <summary>
        /// 绑定画面
        /// </summary>
        /// <history>
        ///     完成信息：李梓楠      2010/07/13 完成   
        ///     更新信息：
        /// </history>
        //*******************************************************************
        private void BandingDgv()
        {
            try
            {
                dataAccess = new DataAccess();
                dataAccess.Open();

                GetData getData = new GetData(dataAccess.Connection);
                SearchParameter sp = new SearchParameter();
                sp.SetValue(":customer_flag", "0");

                DataTable dtCounter = getData.GetSingleTableByCondition("TC_CUSTOMER",sp);

                dgvCustomer.AutoGenerateColumns = false;
                dtCounter.Columns.Add("index", typeof(int));
                for (int i = 0; i < dtCounter.Rows.Count; i++)
                {
                    dtCounter.Rows[i]["index"] = i + 1;
                }
                dgvCustomer.DataSource = dtCounter;

                //使被修改对线变为选中行
                if (dgvCustomer != null && dgvCustomer.Rows.Count > 0 && countNum != 0)
                {
                    dgvCustomer.Rows[0].Selected = false;
                    dgvCustomer.Rows[countNum].Selected = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据发生错误，请检查数据库！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            finally
            {
                dataAccess.Close();
            }
        }

        /// <summary>
        /// 添加按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：李梓楠      2010/07/13 完成   
        ///    更新信息：
        /// </history>
        
        private void btnInsert_Click(object sender, EventArgs e)
        {
            dataType = DataType.Insert;
            setButtonState();
            txtCustomer_name.Focus();
        }

        /// <summary>
        /// 修改按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：李梓楠      2010/07/13 完成   
        ///    更新信息：
        /// </history>
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.SelectedRows.Count > 1)
            {
                MessageBox.Show("只能选择一条要修改的记录！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dgvCustomer.SelectedRows.Count < 1)
            {
                MessageBox.Show("请选择一条要修改的记录！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dataType = DataType.Update;
            setButtonState();
            txtCustomer_name.Focus();
        }

        //***********************************************************************
        /// <summary>
        /// 保存按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：李梓楠      2010/07/13 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnCommit_Click(object sender, EventArgs e)
        {
            if(txtCustomer_name.Text.Trim() == string.Empty)
            {
                MessageBox.Show("客户名称不能为空！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCustomer_name.Focus();
                return;
            }
            if (cb_customer_type.SelectedIndex == 0)
            {
                MessageBox.Show("客户性质不能为空！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_customer_type.Focus();
                return;
            }
            //判断非法字符
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
            EntityCustomer entityCustomer = new EntityCustomer();
            try
            {
                result = -1;
                //如果是添加
                if (dataType == DataType.Insert)
                {
                    entityCustomer.Customer_name = txtCustomer_name.Text;
                    entityCustomer.Customer_yxm = txtCustomer_yxm.Text;
                    entityCustomer.Customer_artificial_person = txtCustomer_artificial_person.Text;
                    entityCustomer.Customer_bank = txtCustomer_bank.Text;
                    entityCustomer.Customer_bank_num = txtCustomer_bank_num.Text;
                    entityCustomer.Customer_address = txtCustomer_address.Text;
                    entityCustomer.Customer_principal = txtCustomer_principal.Text;
                    entityCustomer.Customer_tariff_num = txtCustomer_tariff_num.Text;
                    entityCustomer.Customer_licence = txtCustomer_licence.Text;
                    entityCustomer.Customer_business_licence = txtCustomer_business_licence.Text;
                    entityCustomer.Customer_tel = txtCustomer_tel.Text;
                    entityCustomer.Customer_fax = txtCustomer_fax.Text;
                    entityCustomer.Customer_postal_code = txtCustomer_postal_code.Text;
                    entityCustomer.Customer_medical_institutions = txtCustomer_medical_institutions.Text;
                    entityCustomer.Customer_quality = txtCustomer_quality.Text;
                    entityCustomer.Customer_type = cb_customer_type.Text;
                    entityCustomer.Customer_flag = "0";

                    dataAccess = new DataAccess();
                    dataAccess.Open();

                    MakePrimaryKey primaryKey = new MakePrimaryKey(dataAccess.Connection, dataAccess.Transaction);
                    entityCustomer.Customer_code = primaryKey.MakeCode("客户");

                    GetData getData = new GetData(dataAccess.Connection);
                    result = getData.InsertCustomer(entityCustomer);

                }
                //如果是更新
                else if (dataType == DataType.Update)
                {
                    //给选中行赋值
                    countNum = dgvCustomer.SelectedRows[0].Index;

                    entityCustomer.Customer_code = txtCustomer_code.Text;
                    entityCustomer.Customer_name = txtCustomer_name.Text;
                    entityCustomer.Customer_yxm = txtCustomer_yxm.Text;
                    entityCustomer.Customer_artificial_person = txtCustomer_artificial_person.Text;
                    entityCustomer.Customer_bank = txtCustomer_bank.Text;
                    entityCustomer.Customer_bank_num = txtCustomer_bank_num.Text;
                    entityCustomer.Customer_address = txtCustomer_address.Text;
                    entityCustomer.Customer_principal = txtCustomer_principal.Text;
                    entityCustomer.Customer_tariff_num = txtCustomer_tariff_num.Text;
                    entityCustomer.Customer_licence = txtCustomer_licence.Text;
                    entityCustomer.Customer_business_licence = txtCustomer_business_licence.Text;
                    entityCustomer.Customer_tel = txtCustomer_tel.Text;
                    entityCustomer.Customer_fax = txtCustomer_fax.Text;
                    entityCustomer.Customer_postal_code = txtCustomer_postal_code.Text;
                    entityCustomer.Customer_medical_institutions = txtCustomer_medical_institutions.Text;
                    entityCustomer.Customer_quality = txtCustomer_quality.Text;
                    entityCustomer.Customer_type = cb_customer_type.Text;
                    entityCustomer.Customer_flag = "0";


                    dataAccess = new DataAccess();
                    dataAccess.Open();
                    dataAccess.BeginTransaction();

                    GetData getData = new GetData(dataAccess.Connection, dataAccess.Transaction);
                    //取得结果符
                    result = getData.UpdateCustomer(entityCustomer);
                    //提交事务
                    dataAccess.Commit();
                
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
            }
            if (result == 0)
            {
                MessageBox.Show("数据已经保存成功！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                BandingDgv();
            }
            else
            {
                MessageBox.Show("数据保存时发生错误，请检查数据库！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //设置按钮状态
            dataType = DataType.None;
            setButtonState();
        }

        //***********************************************************************
        /// <summary>
        /// 取消按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：李梓楠      2010/07/13 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dataType = DataType.None;
            setButtonState();
            if (dgvCustomer != null && dgvCustomer.SelectedRows.Count != 0)
            {
                txtCustomer_code.Text = dgvCustomer.SelectedRows[0].Cells["CUSTOMER_CODE"].Value.ToString();
                txtCustomer_name.Text = dgvCustomer.SelectedRows[0].Cells["CUSTOMER_NAME"].Value.ToString();
                txtCustomer_yxm.Text = dgvCustomer.SelectedRows[0].Cells["CUSTOMER_YXM"].Value.ToString();
                txtCustomer_artificial_person.Text = dgvCustomer.SelectedRows[0].Cells["CUSTOMER_ARTIFICIAL_PERSON"].Value.ToString();
                txtCustomer_bank.Text = dgvCustomer.SelectedRows[0].Cells["CUSTOMER_BANK"].Value.ToString();
                txtCustomer_bank_num.Text = dgvCustomer.SelectedRows[0].Cells["CUSTOMER_BANK_NUM"].Value.ToString();
                txtCustomer_address.Text = dgvCustomer.SelectedRows[0].Cells["CUSTOMER_ADDRESS"].Value.ToString();
                txtCustomer_principal.Text = dgvCustomer.SelectedRows[0].Cells["CUSTOMER_PRINCIPAL"].Value.ToString();
                txtCustomer_tariff_num.Text = dgvCustomer.SelectedRows[0].Cells["CUSTOMER_TARIFF_NUM"].Value.ToString();
                txtCustomer_licence.Text = dgvCustomer.SelectedRows[0].Cells["CUSTOMER_LICENCE"].Value.ToString();
                txtCustomer_business_licence.Text = dgvCustomer.SelectedRows[0].Cells["CUSTOMER_BUSINESS_LICENCE"].Value.ToString();
                txtCustomer_tel.Text = dgvCustomer.SelectedRows[0].Cells["CUSTOMER_TEL"].Value.ToString();
                txtCustomer_fax.Text = dgvCustomer.SelectedRows[0].Cells["CUSTOMER_FAX"].Value.ToString();
                txtCustomer_postal_code.Text = dgvCustomer.SelectedRows[0].Cells["CUSTOMER_POSTAL_CODE"].Value.ToString();
                txtCustomer_medical_institutions.Text = dgvCustomer.SelectedRows[0].Cells["CUSTOMER_MEDICAL_INSTITUTIONS"].Value.ToString();
                txtCustomer_quality.Text = dgvCustomer.SelectedRows[0].Cells["CUSTOMER_QUALITY"].Value.ToString();
                cb_customer_type.Text = dgvCustomer.SelectedRows[0].Cells["CUSTOMER_type"].Value.ToString();

            }
            dgvCustomer.Focus();

        }
        //客户名称改变事件
        private void txtCustomer_name_TextChanged(object sender, EventArgs e)
        {
            txtCustomer_yxm.Text = Util.IndexCode(txtCustomer_name.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomer_nameSelect.Text = "";
            txtCustomer_yxmSelect.Text = "";
        }

       

        private void dgvCustomer_Sorted(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvCustomer.Rows.Count; i++)
            {
                dgvCustomer.Rows[i].Cells["index"].Value = i + 1;
            }
        }
    }
}