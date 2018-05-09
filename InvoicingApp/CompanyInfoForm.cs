using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//***********************************************************************
//* 系统名称	    ：  长白ERP系统
//* 功能模块	    ：  系统信息
//* 功能画面		：  公司信息管理
//* 画面名称	    ：  CompanyInfoForm
//* 完成年月日      ：  2010/07/16
//* 作者		    ：  赵毅男
//* Version		    ：  1.00
//* ---------------------------------------------------------------------
//* 前提		：SQL SERVER,.NetFramework3.0
//***********************************************************************
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataAccesses;
using InvoicingUtil;

namespace InvoicingApp
{
    public partial class CompanyInfoForm : Form
    {

        /// <summary>
        /// 数据库连接句柄
        /// </summary>
        DataAccess dataAccess = null;

        /// <summary>
        /// 结果符，默认-1
        /// </summary>
        int result = -1;

        DataType dataType = DataType.Insert;

        EntityCompany companyEntity = null;

        string companyCode = string.Empty;

        public CompanyInfoForm()
        {
            InitializeComponent();
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
        }

        private void BandingCompanyInfo()
        {
            try
            {

                //打开数据库连接
                dataAccess = new DataAccess();
                dataAccess.Open();

                //取得操作类
                GetData getData = new GetData(dataAccess.Connection);

                //取得单表数据
                DataTable dtCompany = getData.GetSingleTable("tc_company");

                //绑定画面
                if (dtCompany == null)
                {
                    MessageBox.Show("请检查数据库是否正常运行！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (dtCompany.Rows.Count > 0)
                {
                    dataType = DataType.Update;

                    companyCode = dtCompany.Rows[0]["company_code"].ToString();
                    txtCompanyName.Text = dtCompany.Rows[0]["company_name"].ToString();
                    txtRegisteredAddress.Text = dtCompany.Rows[0]["company_registered_address"].ToString();
                    txtRelAddress.Text = dtCompany.Rows[0]["company_rel_address"].ToString();
                    txtBusinessLicence.Text = dtCompany.Rows[0]["company_business_licence"].ToString();
                    txtLicence.Text = dtCompany.Rows[0]["company_licence"].ToString();
                    txtArtificialPerson.Text = dtCompany.Rows[0]["company_artificial_person"].ToString();
                    txtPrincipal.Text = dtCompany.Rows[0]["company_principal"].ToString();
                    comboxBusinessType.Text = dtCompany.Rows[0]["company_business_type"].ToString();                    
                    txtStorageAddress.Text = dtCompany.Rows[0]["company_storage_address"].ToString();
                    txtPostalCode.Text = dtCompany.Rows[0]["company_postal_code"].ToString();
                    txtFax.Text = dtCompany.Rows[0]["company_fax"].ToString();
                    txtTel.Text = dtCompany.Rows[0]["company_tel"].ToString();
                    txtBank.Text = dtCompany.Rows[0]["company_bank"].ToString();
                    txtBankNum.Text = dtCompany.Rows[0]["company_bank_num"].ToString();
                    txtTariffNum.Text = dtCompany.Rows[0]["company_tariff_num"].ToString();             
                    txt_company_business_scope.Text = dtCompany.Rows[0]["company_business_scope"].ToString();
                    txtMobile.Text = dtCompany.Rows[0]["company_mobile"].ToString();
                    cmb_company_style.Text = dtCompany.Rows[0]["company_style"].ToString();
                    txt_company_quality_persion.Text = dtCompany.Rows[0]["company_quality_persion"].ToString();
                }
                else
                {
                    dataType = DataType.Insert;

                    txtCompanyName.Text = "";
                    txtRegisteredAddress.Text = "";
                    txtRelAddress.Text = "";
                    txtBusinessLicence.Text = "";
                    txtLicence.Text = "";
                    txtArtificialPerson.Text = "";
                    txtPrincipal.Text = "";
                    comboxBusinessType.Text = "私营";              
                    txtStorageAddress.Text = "";
                    txtPostalCode.Text = "";
                    txtFax.Text = "";
                    txtTel.Text = "";
                    txtBank.Text = "";
                    txtBankNum.Text = "";
                    txtTariffNum.Text = "";           
                    txt_company_business_scope.Text = "";
                    txtMobile.Text = "";
                    cmb_company_style.Text = "国企";
                    txt_company_quality_persion.Text = "";
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

        private void CompanyInfoForm_Load(object sender, EventArgs e)
        {
            BandingCompanyInfo();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            //判断非法字符
            foreach (Control control in this.panel1.Controls)
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

            if (txtCompanyName.Text.Trim().Equals(string.Empty) )
            {
                MessageBox.Show("企业名称不能为空！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCompanyName.Focus();
                return;
            }
            if (Util.CheckCompanyName(txtCompanyName.Text.Trim()))
            {
                MessageBox.Show("企业名称不能包含特殊字符！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCompanyName.Focus();
                return;
            }

            if (txtBusinessLicence.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("营业执照不能为空！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBusinessLicence.Focus();
                return;
            }

            if (txtLicence.Text.Trim().Equals(string.Empty) )
            {
                MessageBox.Show("许可证编号不能为空！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLicence.Focus();
                return;
            }
            if ( Util.CheckCompanyName(txtLicence.Text.Trim()))
            {
                MessageBox.Show("许可证编号不能包含特殊字符！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLicence.Focus();
                return;
            }
            companyEntity = new EntityCompany();

            companyEntity.Company_name = txtCompanyName.Text;
            companyEntity.Company_registered_address = txtRegisteredAddress.Text;
            companyEntity.Company_rel_address = txtRelAddress.Text;
            companyEntity.Company_business_licence = txtBusinessLicence.Text;
            companyEntity.Company_licence = txtLicence.Text;
            companyEntity.Company_artificial_person = txtArtificialPerson.Text;
            companyEntity.Company_principal = txtPrincipal.Text;
            companyEntity.Company_business_type = comboxBusinessType.Text;
            companyEntity.Company_storage_address = txtStorageAddress.Text;
            companyEntity.Company_postal_code = txtPostalCode.Text;
            companyEntity.Company_fax = txtFax.Text;
            companyEntity.Company_tel = txtTel.Text;
            companyEntity.Company_bank = txtBank.Text;
            companyEntity.Company_bank_num = txtBankNum.Text;
            companyEntity.Company_tariff_num = txtTariffNum.Text;
            companyEntity.Company_business_scope = txt_company_business_scope.Text;
            companyEntity.Company_mobile = txtMobile.Text;
            companyEntity.Company_quality_persion = txt_company_quality_persion.Text;
            companyEntity.Company_style = cmb_company_style.Text;
            
            try
            {
                dataAccess = new DataAccess();
                dataAccess.Open();
                
                
                if (dataType == DataType.Insert)
                {
                    
                    MakePrimaryKey primaryKey = new MakePrimaryKey(dataAccess.Connection, dataAccess.Transaction);
                    companyEntity.Company_code = primaryKey.MakeCode("公司");
                    companyCode = companyEntity.Company_code;
                    GetData getData = new GetData(dataAccess.Connection);

                    //取得结果符
                    result = getData.InsertCompanyRow(companyEntity);

                    dataType = DataType.Update;

                }
                else if (dataType == DataType.Update)
                {
                    //打开事务
                    dataAccess.BeginTransaction();

                    companyEntity.Company_code = companyCode;
                    //取得操作类
                    GetData getData = new GetData(dataAccess.Connection, dataAccess.Transaction);

                    //取得结果符
                    result = getData.UpdateCompanyTable(companyEntity);

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
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //关闭数据库连接
                dataAccess.Close();
            }

            if (result == 0)
            {
                MessageBox.Show("数据已保存成功！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == -1)
            {
                MessageBox.Show("数据提交失败,请检查数据库是否打开，添加信息是否正确！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
}
