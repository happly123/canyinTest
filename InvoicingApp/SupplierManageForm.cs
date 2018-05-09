//***********************************************************************
//* 系统名称	    ：  长白ERP系统
//* 功能模块	    ：  基础平台
//* 功能画面		：  供货商管理
//* 画面名称	    ：  SupplierManageForm
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
    ///供货商管理功能
    /// </summary>
    /// <history>
    ///     完成信息：李梓楠      2010/07/13 完成  
    ///     更新信息：
    /// </history>
    //***********************************************************************
    public partial class SupplierManageForm : Form
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


        public SupplierManageForm()
        {
            InitializeComponent();
            this.dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(239, 243, 251);

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
                    txtSupplier_code.ReadOnly = true;
                    txtSupplier_name.ReadOnly = true;
                    txtSupplier_yxm.ReadOnly = true;
                    txtSupplier_address.ReadOnly = true;
                    txtSupplier_artificial_person.ReadOnly = true;
                    txtSupplier_business_scpoe.ReadOnly = true;
                    txtSupplier_licence.ReadOnly = true;
                    txtSupplier_trustpersion.ReadOnly = true;
                    txtSupplier_tariff_num.ReadOnly = true;
                    txtSupplier_principal.ReadOnly = true;
                    txtSupplier_bank.ReadOnly = true;
                    txtSupplier_bank_num.ReadOnly = true;
                    txtSupplier_tel.ReadOnly = true;
                    txtSupplier_fax.ReadOnly = true;
                    txtSupplier_business_licence.ReadOnly = true;
                    txtSupplier_postal_code.ReadOnly = true;
                    txtSupplier_make_quality_num.ReadOnly = true;
                    txtSupplier_business_num.ReadOnly = true;
                    cb_Supplier_type.Enabled = false;


                    btnInsert.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnCommit.Enabled = false;
                    btnCancel.Enabled = false;

                    
                    break;
                case DataType.Insert:
                    txtSupplier_code.ReadOnly = true;
                    txtSupplier_name.ReadOnly = false;
                    txtSupplier_yxm.ReadOnly = true;
                    txtSupplier_address.ReadOnly = false;
                    txtSupplier_artificial_person.ReadOnly = false;
                    txtSupplier_business_scpoe.ReadOnly = false;
                    txtSupplier_licence.ReadOnly = false;
                    txtSupplier_trustpersion.ReadOnly = false;
                    txtSupplier_tariff_num.ReadOnly = false;
                    txtSupplier_principal.ReadOnly = false;
                    txtSupplier_bank.ReadOnly = false;
                    txtSupplier_bank_num.ReadOnly = false;
                    txtSupplier_tel.ReadOnly = false;
                    txtSupplier_fax.ReadOnly = false;
                    txtSupplier_business_licence.ReadOnly = false;
                    txtSupplier_postal_code.ReadOnly = false;
                    txtSupplier_make_quality_num.ReadOnly = false;
                    txtSupplier_business_num.ReadOnly = false;
                    cb_Supplier_type.Enabled = true;

                    txtSupplier_code.Text = "";
                    txtSupplier_name.Text = "";
                    txtSupplier_yxm.Text = "";
                    txtSupplier_address.Text = "";
                    txtSupplier_artificial_person.Text = "";
                    txtSupplier_business_scpoe.Text = "";
                    txtSupplier_licence.Text = "";
                    txtSupplier_trustpersion.Text = "";
                    txtSupplier_tariff_num.Text = "";
                    txtSupplier_principal.Text = "";
                    txtSupplier_bank.Text = "";
                    txtSupplier_bank_num.Text = "";
                    txtSupplier_tel.Text = "";
                    txtSupplier_fax.Text = "";
                    txtSupplier_business_licence.Text = "";
                    txtSupplier_postal_code.Text = "";
                    txtSupplier_make_quality_num.Text = "";
                    txtSupplier_business_num.Text = "";
                    cb_Supplier_type.SelectedIndex = 0;

                    btnInsert.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnCommit.Enabled = true;
                    btnCancel.Enabled = true;

                    
                    break;
                case DataType.Update:
                    txtSupplier_code.ReadOnly = true;
                    txtSupplier_name.ReadOnly = true;
                    txtSupplier_yxm.ReadOnly = true;
                    txtSupplier_address.ReadOnly = false;
                    txtSupplier_artificial_person.ReadOnly = false;
                    txtSupplier_business_scpoe.ReadOnly = false;
                    txtSupplier_licence.ReadOnly = false;
                    txtSupplier_trustpersion.ReadOnly = false;
                    txtSupplier_tariff_num.ReadOnly = false;
                    txtSupplier_principal.ReadOnly = false;
                    txtSupplier_bank.ReadOnly = false;
                    txtSupplier_bank_num.ReadOnly = false;
                    txtSupplier_tel.ReadOnly = false;
                    txtSupplier_fax.ReadOnly = false;
                    txtSupplier_business_licence.ReadOnly = false;
                    txtSupplier_postal_code.ReadOnly = false;
                    txtSupplier_make_quality_num.ReadOnly = false;
                    txtSupplier_business_num.ReadOnly = false;
                    cb_Supplier_type.Enabled = true;


                    btnInsert.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnCommit.Enabled = true;
                    btnCancel.Enabled = true;

                    
                    break;
                default:
                    txtSupplier_code.ReadOnly = true;
                    txtSupplier_name.ReadOnly = true;
                    txtSupplier_yxm.ReadOnly = true;
                    txtSupplier_address.ReadOnly = true;
                    txtSupplier_artificial_person.ReadOnly = true;
                    txtSupplier_business_scpoe.ReadOnly = true;
                    txtSupplier_licence.ReadOnly = true;
                    txtSupplier_trustpersion.ReadOnly = true;
                    txtSupplier_tariff_num.ReadOnly = true;
                    txtSupplier_principal.ReadOnly = true;
                    txtSupplier_bank.ReadOnly = true;
                    txtSupplier_bank_num.ReadOnly = true;
                    txtSupplier_tel.ReadOnly = true;
                    txtSupplier_fax.ReadOnly = true;
                    txtSupplier_business_licence.ReadOnly = true;
                    txtSupplier_postal_code.ReadOnly = true;
                    txtSupplier_make_quality_num.ReadOnly = true;
                    txtSupplier_business_num.ReadOnly = true;
                    cb_Supplier_type.Enabled = false;

                    btnInsert.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
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
        private void SupplierManageForm_Load(object sender, EventArgs e)
        {
            dgv.AutoGenerateColumns = false;

            BandingDgv();
            setButtonState();
            txtSupplier_nameSelect.Focus();
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

                DataTable dtCounter = getData.GetSingleTable("tc_Supplier");
                dgv.AutoGenerateColumns = false;
                dtCounter.Columns.Add("index", typeof(int));
                for (int i = 0; i < dtCounter.Rows.Count; i++)
                {
                    dtCounter.Rows[i]["index"] = i + 1;
                }
                dgv.DataSource = dtCounter;

                //使被修改对线变为选中行
                if (dgv != null && dgv.Rows.Count > 0 && countNum != 0)
                {
                    dgv.Rows[0].Selected = false;
                    dgv.Rows[countNum].Selected = true;
                    dgv.FirstDisplayedScrollingRowIndex = countNum;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dataAccess.Close();
            }
        }


        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            //设定按钮状态
            dataType = DataType.None;
            setButtonState();


            if (dgv != null && dgv.SelectedRows.Count != 0)
            {
                txtSupplier_code.Text = dgv.SelectedRows[0].Cells["Supplier_code"].Value.ToString();
                txtSupplier_name.Text = dgv.SelectedRows[0].Cells["Supplier_name"].Value.ToString();
                txtSupplier_yxm.Text = dgv.SelectedRows[0].Cells["Supplier_yxm"].Value.ToString();
                txtSupplier_address.Text = dgv.SelectedRows[0].Cells["Supplier_address"].Value.ToString();
                txtSupplier_artificial_person.Text = dgv.SelectedRows[0].Cells["Supplier_artificial_person"].Value.ToString();
                txtSupplier_business_scpoe.Text = dgv.SelectedRows[0].Cells["Supplier_business_scpoe"].Value.ToString();
                txtSupplier_licence.Text = dgv.SelectedRows[0].Cells["Supplier_licence"].Value.ToString();
                txtSupplier_trustpersion.Text = dgv.SelectedRows[0].Cells["Supplier_trustpersion"].Value.ToString();
                txtSupplier_tariff_num.Text = dgv.SelectedRows[0].Cells["Supplier_tariff_num"].Value.ToString();
                txtSupplier_principal.Text = dgv.SelectedRows[0].Cells["Supplier_principal"].Value.ToString();
                txtSupplier_bank.Text = dgv.SelectedRows[0].Cells["Supplier_bank"].Value.ToString();
                txtSupplier_bank_num.Text = dgv.SelectedRows[0].Cells["Supplier_bank_num"].Value.ToString();
                txtSupplier_tel.Text = dgv.SelectedRows[0].Cells["Supplier_tel"].Value.ToString();
                txtSupplier_fax.Text = dgv.SelectedRows[0].Cells["Supplier_fax"].Value.ToString();
                txtSupplier_business_licence.Text = dgv.SelectedRows[0].Cells["Supplier_business_licence"].Value.ToString();
                txtSupplier_postal_code.Text = dgv.SelectedRows[0].Cells["Supplier_postal_code"].Value.ToString();
                txtSupplier_make_quality_num.Text = dgv.SelectedRows[0].Cells["Supplier_make_quality_num"].Value.ToString();
                txtSupplier_business_num.Text = dgv.SelectedRows[0].Cells["Supplier_business_num"].Value.ToString();
                cb_Supplier_type.Text = dgv.SelectedRows[0].Cells["Supplier_type"].Value.ToString();
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
            txtSupplier_name.Focus();
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
            if (dgv.SelectedRows.Count > 1)
            {
                MessageBox.Show("只能选择一条要修改的记录！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dgv.SelectedRows.Count < 1)
            {
                MessageBox.Show("请选择一条要修改的记录！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dataType = DataType.Update;
            setButtonState();
            txtSupplier_name.Focus();

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
            if (txtSupplier_name.Text.Trim() == string.Empty)
            {
                MessageBox.Show("供货商名称不能为空！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSupplier_name.Focus();
                return;
            }
            
            if (txtSupplier_licence.Text.Trim() == string.Empty)
            {
                MessageBox.Show("许可证编号不能为空！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSupplier_licence.Focus();
                return;
            }

            if (cb_Supplier_type.SelectedIndex == 0)
            {
                MessageBox.Show("供货商分类不能为空！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_Supplier_type.Focus();
                return;
            }

            foreach (Control control in groupBox1.Controls)
            {
                if (control is TextBox)
                {
                    if (Util.CheckRegex(control.Text.Trim()) && !((TextBox)control).ReadOnly)
                    {
                        MessageBox.Show("不可以输入非法字符，请重新输入！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        control.Focus();
                        return;
                    }
                }
            }
            EntitySupplier entitySupplier = new EntitySupplier();
            try
            {
                result = -1;

                //如果是添加
                if (dataType == DataType.Insert)
                {

                    entitySupplier.Supplier_code = txtSupplier_code.Text;
                    entitySupplier.Supplier_name = txtSupplier_name.Text;
                    entitySupplier.Supplier_yxm = txtSupplier_yxm.Text;
                    entitySupplier.Supplier_address = txtSupplier_address.Text;
                    entitySupplier.Supplier_artificial_person = txtSupplier_artificial_person.Text;
                    entitySupplier.Supplier_business_scpoe = txtSupplier_business_scpoe.Text;
                    entitySupplier.Supplier_licence = txtSupplier_licence.Text;
                    entitySupplier.Supplier_trustpersion = txtSupplier_trustpersion.Text;
                    entitySupplier.Supplier_tariff_num = txtSupplier_tariff_num.Text;
                    entitySupplier.Supplier_principal = txtSupplier_principal.Text;
                    entitySupplier.Supplier_bank = txtSupplier_bank.Text;
                    entitySupplier.Supplier_bank_num = txtSupplier_bank_num.Text;
                    entitySupplier.Supplier_tel = txtSupplier_tel.Text;
                    entitySupplier.Supplier_fax = txtSupplier_fax.Text;
                    entitySupplier.Supplier_business_licence = txtSupplier_business_licence.Text;
                    entitySupplier.Supplier_postal_code = txtSupplier_postal_code.Text;
                    entitySupplier.Supplier_make_quality_num = txtSupplier_make_quality_num.Text;
                    entitySupplier.Supplier_business_num = txtSupplier_business_num.Text;
                    entitySupplier.Supplier_type = cb_Supplier_type.Text;

                    dataAccess = new DataAccess();
                    dataAccess.Open();

                    MakePrimaryKey primaryKey = new MakePrimaryKey(dataAccess.Connection, dataAccess.Transaction);
                    entitySupplier.Supplier_code = primaryKey.MakeCode("供货商");

                    GetData getData = new GetData(dataAccess.Connection);

                    if (getData.InsertIsOnly("tc_supplier", "supplier_name", txtSupplier_name.Text.Trim()))
                    {
                        MessageBox.Show("您输入的供货商名称已经存在，请更改供货商名称后再保存！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSupplier_name.Focus();
                        return;
                    }

                    result = getData.InsertSupplier(entitySupplier);

                }
                //如果是更新
                else if (dataType == DataType.Update)
                {
                    //给选中行赋值
                    countNum = dgv.SelectedRows[0].Index;

                    entitySupplier.Supplier_code = txtSupplier_code.Text;
                    entitySupplier.Supplier_name = txtSupplier_name.Text;
                    entitySupplier.Supplier_yxm = txtSupplier_yxm.Text;
                    entitySupplier.Supplier_address = txtSupplier_address.Text;
                    entitySupplier.Supplier_artificial_person = txtSupplier_artificial_person.Text;
                    entitySupplier.Supplier_business_scpoe = txtSupplier_business_scpoe.Text;
                    entitySupplier.Supplier_licence = txtSupplier_licence.Text;
                    entitySupplier.Supplier_trustpersion = txtSupplier_trustpersion.Text;
                    entitySupplier.Supplier_tariff_num = txtSupplier_tariff_num.Text;
                    entitySupplier.Supplier_principal = txtSupplier_principal.Text;
                    entitySupplier.Supplier_bank = txtSupplier_bank.Text;
                    entitySupplier.Supplier_bank_num = txtSupplier_bank_num.Text;
                    entitySupplier.Supplier_tel = txtSupplier_tel.Text;
                    entitySupplier.Supplier_fax = txtSupplier_fax.Text;
                    entitySupplier.Supplier_business_licence = txtSupplier_business_licence.Text;
                    entitySupplier.Supplier_postal_code = txtSupplier_postal_code.Text;
                    entitySupplier.Supplier_make_quality_num = txtSupplier_make_quality_num.Text;
                    entitySupplier.Supplier_business_num = txtSupplier_business_num.Text;
                    entitySupplier.Supplier_type = cb_Supplier_type.Text;

                    dataAccess = new DataAccess();
                    dataAccess.Open();
                    dataAccess.BeginTransaction();

                    GetData getData = new GetData(dataAccess.Connection, dataAccess.Transaction);

                    if (getData.UpdateIsOnly("tc_supplier", "supplier_code", entitySupplier.Supplier_code, "supplier_name", txtSupplier_name.Text.Trim()))
                    {
                        MessageBox.Show("您输入的供货商名称已经存在，请更改供货商名称后再保存！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSupplier_name.Focus();
                        return;
                    }
                    //取得结果符
                    result = getData.UpdateSupplier(entitySupplier);
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
                    MessageBox.Show("数据保存时发生错误，请检查数据库！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            finally
            {
                //关闭数据库连接
                if(dataAccess != null)
                dataAccess.Close();
            }
            if (result == 0)
            {
                MessageBox.Show("数据已经保存成功！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("数据保存时发生错误，请检查数据库！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            BandingDgv();
            //设置按钮状态
            dataType = DataType.None;
            setButtonState();
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
            if (dgv.SelectedRows.Count > 1)
            {
                MessageBox.Show("只能选择一条要删除的记录！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dgv.SelectedRows.Count < 1)
            {
                MessageBox.Show("请选择一条要删除的记录！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SearchParameter sp = new SearchParameter();
            sp.SetValue(":supplier_name", dgv.SelectedRows[0].Cells["supplier_name"].Value.ToString());

            dataAccess = new DataAccess();
            try
            {
                dataAccess.Open();
                GetData gd = new GetData(dataAccess.Connection);
                DataTable dt = gd.GetSingleTableByCondition("TC_INPUT_STORAGE", sp);
                if (dt != null && dt.Rows.Count > 0)
                {
                    MessageBox.Show("此供货商信息已经被使用，无法删除！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            if (MessageBox.Show("您确定要删除该数据吗？", Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    sp.Clear();
                    sp.SetValue(":Supplier_code", dgv.SelectedRows[0].Cells["Supplier_code"].Value.ToString());

                    dataAccess.Open();
                    dataAccess.BeginTransaction();
                    GetData getData = new GetData(dataAccess.Connection, dataAccess.Transaction);

                    result = getData.DeleteRow("tc_Supplier", sp);

                    dataAccess.Commit();
                }
                catch (Exception ex)
                {
                    dataAccess.Rollback();
                }
                finally
                {
                    dataAccess.Close();
                    if (result == 0)
                    {
                        MessageBox.Show("数据已经被成功删除！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BandingDgv();

                    }
                    else
                    {
                        MessageBox.Show("数据删除时发生错误，请检查数据库！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        ///    完成信息：李梓楠      2010/07/13 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dataType = DataType.None;
            setButtonState();
            if (dgv != null && dgv.SelectedRows.Count != 0)
            {
                txtSupplier_code.Text = dgv.SelectedRows[0].Cells["Supplier_code"].Value.ToString();
                txtSupplier_name.Text = dgv.SelectedRows[0].Cells["Supplier_name"].Value.ToString();
                txtSupplier_yxm.Text = dgv.SelectedRows[0].Cells["Supplier_yxm"].Value.ToString();
                txtSupplier_address.Text = dgv.SelectedRows[0].Cells["Supplier_address"].Value.ToString();
                txtSupplier_artificial_person.Text = dgv.SelectedRows[0].Cells["Supplier_artificial_person"].Value.ToString();
                txtSupplier_business_scpoe.Text = dgv.SelectedRows[0].Cells["Supplier_business_scpoe"].Value.ToString();
                txtSupplier_licence.Text = dgv.SelectedRows[0].Cells["Supplier_licence"].Value.ToString();
                txtSupplier_trustpersion.Text = dgv.SelectedRows[0].Cells["Supplier_trustpersion"].Value.ToString();
                txtSupplier_tariff_num.Text = dgv.SelectedRows[0].Cells["Supplier_tariff_num"].Value.ToString();
                txtSupplier_principal.Text = dgv.SelectedRows[0].Cells["Supplier_principal"].Value.ToString();
                txtSupplier_bank.Text = dgv.SelectedRows[0].Cells["Supplier_bank"].Value.ToString();
                txtSupplier_bank_num.Text = dgv.SelectedRows[0].Cells["Supplier_bank_num"].Value.ToString();
                txtSupplier_tel.Text = dgv.SelectedRows[0].Cells["Supplier_tel"].Value.ToString();
                txtSupplier_fax.Text = dgv.SelectedRows[0].Cells["Supplier_fax"].Value.ToString();
                txtSupplier_business_licence.Text = dgv.SelectedRows[0].Cells["Supplier_business_licence"].Value.ToString();
                txtSupplier_postal_code.Text = dgv.SelectedRows[0].Cells["Supplier_postal_code"].Value.ToString();
                txtSupplier_make_quality_num.Text = dgv.SelectedRows[0].Cells["Supplier_make_quality_num"].Value.ToString();
                txtSupplier_business_num.Text = dgv.SelectedRows[0].Cells["Supplier_business_num"].Value.ToString();
                cb_Supplier_type.Text = dgv.SelectedRows[0].Cells["Supplier_type"].Value.ToString();                
            }
            dgv.Focus();

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
            foreach (Control control in groupBox2.Controls)
            {
                if (control is TextBox)
                {
                    if (Util.CheckRegex(control.Text.Trim()) && !((TextBox)control).ReadOnly)
                    {
                        MessageBox.Show("不可以输入非法字符，请重新输入！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        control.Focus();
                        return;
                    }
                }
            }
            try
            {
                SearchParameter sp = new SearchParameter();

                if (txtSupplier_nameSelect.Text.Trim() != string.Empty)
                {
                    sp.SetValue(":Supplier_name", txtSupplier_nameSelect.Text);
                }

                if (txtSupplier_yxmSelect.Text.Trim() != string.Empty)
                {
                    sp.SetValue(":Supplier_YXM", txtSupplier_yxmSelect.Text);
                }
                dataAccess = new DataAccess();
                dataAccess.Open();

                GetData getData = new GetData(dataAccess.Connection);

                DataTable dtCondition = getData.GetSingleTableByCondition("tc_Supplier", sp);

                if (dtCondition == null)
                {
                    MessageBox.Show("请查看数据库是否正常！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                dtCondition.Columns.Add("index", typeof(int));
                for (int i = 0; i < dtCondition.Rows.Count; i++)
                {
                    dtCondition.Rows[i]["index"] = i + 1;
                }
                dgv.DataSource = dtCondition;

                if (dtCondition.Rows.Count == 0)
                {
                    dataType = DataType.Insert;
                    setButtonState();
                    dataType = DataType.None;
                    setButtonState();
                    MessageBox.Show("数据不存在，请查看输入的条件是否正确！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("请查看数据库是否正常！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                dataAccess.Close();
            }
        }



        //客户名称改变事件
        private void txtSupplier_name_TextChanged(object sender, EventArgs e)
        {
            txtSupplier_yxm.Text = Util.IndexCode(txtSupplier_name.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSupplier_nameSelect.Text = "";
            txtSupplier_yxmSelect.Text = "";    
        }

        private void dgv_Sorted(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                dgv.Rows[i].Cells["index"].Value = i + 1;
            }
        }

       

        
    }
}
