//***********************************************************************
//* 系统名称	    ：  长白ERP系统
//* 功能模块	    ：  主页
//* 功能画面		：  主页
//* 画面名称	    ：  MainForm
//* 完成年月日      ：  2010/09/20
//* 作者		    ：  赵毅男
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
using InvoicingUtil;
using DataAccesses;
using System.Data.SqlClient;
using System.Collections;
using System.IO;
using System.Security.AccessControl;
using DataExport;
using System.Configuration;
using System.Xml;


namespace InvoicingApp
{

    //***********************************************************************
    /// <summary>
    ///主页
    /// </summary>
    /// <history>
    ///     完成信息：赵毅男      2010/09/20 完成  
    ///     更新信息：
    /// </history>
    //***********************************************************************
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();

        }

        /// <summary>
        /// 是否存在加密狗
        /// </summary>
        private bool hasKey = true;

        /// <summary>
        /// 数据库连接句柄
        /// </summary>
        DataAccess dataAccess = null;

        //***********************************************************************
        /// <summary>
        /// 关闭按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：赵毅男      2010/09/20 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //取得日志实体
            EntitySystemLog systemLogEntity = new EntitySystemLog();
            systemLogEntity.DateLogOn = LoginUser.LogOnTime;
            systemLogEntity.DateLogOff = DateTime.Now;
            systemLogEntity.UserName = LoginUser.UserName;

            try
            {
                //打开数据库连接
                dataAccess = new DataAccess();
                dataAccess.Open();

                //调用数据操作类
                GetData getData = new GetData(dataAccess.Connection);
                int result = getData.InsertSystemLogTable(systemLogEntity);

                //如果失败
                if (result == -1)
                {
                    MessageBox.Show("添加系统日志失败，请查看数据库连接是否正常！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

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

            //退出系统
            Application.Exit();

        }

        /// <summary>
        /// 创建Tab页
        /// </summary>
        /// <param name="key">键值</param>
        /// <param name="title">标题名称</param>
        /// <returns>是否已存在该名称的标题</returns>
        private bool CreateTab(string key, string title)
        {

            //查找是否存在标题的tab页
            if (tabControl.TabPages.IndexOfKey(key) == -1)
            {
                //不存在，则创建
                tabControl.TabPages.Add(key, title);
                tabControl.TabPages[key].BackColor = SystemColors.GradientInactiveCaption;
                tabControl.SelectedIndex = tabControl.TabCount - 1;
                return true;
            }
            else
            {
                //选择该页
                tabControl.SelectedIndex = tabControl.TabPages.IndexOfKey(key);
                return false;
            }
        }

        /// <summary>
        /// 设置tab页属性
        /// </summary>
        /// <param name="frm">要显示的窗体</param>
        private void SetTab(Form frm)
        {

            //设置窗体基本属性
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Parent = tabControl.TabPages[tabControl.TabCount - 1];
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            frm.Show();

        }

        //***********************************************************************
        /// <summary>
        /// 双击标题页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：赵毅男      2010/09/20 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void tabControl_DoubleClick(object sender, EventArgs e)
        {
            //如果是鼠标左键才关闭
            MouseEventArgs mouse = (MouseEventArgs)e;
            if (mouse.Button == MouseButtons.Right)
            {
                return;
            }

            //主页不关闭
            if (tabControl.TabPages[tabControl.SelectedIndex].Text != "主页")
            {
                tabControl.TabPages.Remove(tabControl.TabPages[tabControl.SelectedIndex]);

            }


        }

        //***********************************************************************
        /// <summary>
        /// 初始化入库按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：赵毅男      2010/09/20 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void InitStorage_Click(object sender, EventArgs e)
        {

            //如果不存在则创建，存在选择
            if (CreateTab("初始化入库", "初始化入库"))
            {
                InitStorageForm initStorageForm = new InitStorageForm();

                SetTab(initStorageForm);
            }

        }

        //***********************************************************************
        /// <summary>
        /// 购货入库按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：赵毅男      2010/09/20 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void PurchasesStorage_Click(object sender, EventArgs e)
        {
            if (CreateTab("购货入库", "购货入库"))
            {
                PurchasesStorageForm purchasesStorageForm = new PurchasesStorageForm();

                SetTab(purchasesStorageForm);
            }
        }

        //***********************************************************************
        /// <summary>
        /// 关闭按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：赵毅男      2010/09/20 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void GiftsStorage_Click(object sender, EventArgs e)
        {
            if (CreateTab("赠品入库", "赠品入库"))
            {
                GiftsStorageForm giftsStorageForm = new GiftsStorageForm();

                SetTab(giftsStorageForm);
            }
        }

        //***********************************************************************
        /// <summary>
        /// 退货入库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：赵毅男      2010/09/20 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void BackStorage_Click(object sender, EventArgs e)
        {
            if (CreateTab("退货入库", "退货入库"))
            {
                BackStorageForm backStorageForm = new BackStorageForm();

                SetTab(backStorageForm);
            }

        }

        //***********************************************************************
        /// <summary>
        /// 初始化入库按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：赵毅男      2010/09/20 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void SellStorage_Click(object sender, EventArgs e)
        {
            if (CreateTab("销售出库", "销售出库"))
            {
                SellStorageForm sellStorageForm = new SellStorageForm();

                SetTab(sellStorageForm);
            }
        }

        private void BackOutStorage_Click(object sender, EventArgs e)
        {
            if (CreateTab("退货出库", "退货出库"))
            {
                BackOutStorageForm backOutStorageForm = new BackOutStorageForm();

                SetTab(backOutStorageForm);
            }
        }

        private void StorageInventory_Click(object sender, EventArgs e)
        {
            if (CreateTab("库存盘点", "库存盘点"))
            {
                StorageInventoryForm storageInventoryForm = new StorageInventoryForm();

                SetTab(storageInventoryForm);
            }
        }

        private void DamageAccounts_Click(object sender, EventArgs e)
        {
            if (CreateTab("报损下账", "报损下账"))
            {
                DamageAccountsForm damageAccountsForm = new DamageAccountsForm();

                SetTab(damageAccountsForm);
            }

        }

        private void InStorageSelect_Click(object sender, EventArgs e)
        {
            if (CreateTab("入库查询", "入库查询"))
            {
                InStorageSelectForm inStorageSelectForm = new InStorageSelectForm();

                SetTab(inStorageSelectForm);
            }
        }

        private void InStorageCount_Click(object sender, EventArgs e)
        {
            if (CreateTab("入库统计", "入库统计"))
            {
                InStorageCountForm inStorageCountForm = new InStorageCountForm();

                SetTab(inStorageCountForm);
            }
        }

        private void OutStorageSelect_Click(object sender, EventArgs e)
        {
            if (CreateTab("出库查询", "出库查询"))
            {
                OutStorageSelectForm outStorageSelectForm = new OutStorageSelectForm();

                SetTab(outStorageSelectForm);
            }
        }

        private void OutStorageCount_Click(object sender, EventArgs e)
        {
            if (CreateTab("出库统计", "出库统计"))
            {
                OutStorageCountForm outStorageCountForm = new OutStorageCountForm();

                SetTab(outStorageCountForm);
            }
        }

        private void InventorySelect_Click(object sender, EventArgs e)
        {
            if (CreateTab("库存查询", "库存查询"))
            {
                InventorySelectForm inventorySelectForm = new InventorySelectForm();

                SetTab(inventorySelectForm);
            }
        }

        private void InventoryCount_Click(object sender, EventArgs e)
        {
            if (CreateTab("库存统计", "库存统计"))
            {
                InventoryCountForm inventoryCountForm = new InventoryCountForm();

                SetTab(inventoryCountForm);
            }
        }

        private void DamageSelect_Click(object sender, EventArgs e)
        {
            if (CreateTab("报损查询", "报损查询"))
            {
                DamageSelectForm damageSelectForm = new DamageSelectForm();

                SetTab(damageSelectForm);
            }
        }

        private void DamageCount_Click(object sender, EventArgs e)
        {
            if (CreateTab("报损统计", "报损统计"))
            {
                DamageCountForm damageCountForm = new DamageCountForm();

                SetTab(damageCountForm);
            }
        }

        private void MaintenanceManagement_Click(object sender, EventArgs e)
        {
            if (CreateTab("养护管理", "养护管理"))
            {
                MaintenanceManagementForm maintenanceManagementForm = new MaintenanceManagementForm();

                SetTab(maintenanceManagementForm);
            }
        }

        private void ManufacturerManage_Click(object sender, EventArgs e)
        {
            if (!CheckDog()) return;

            FormCollection fc = Application.OpenForms;
            if (fc["ManufacturerManageForm"] == null)
            {
                ManufacturerManageForm manufacturerManageForm = new ManufacturerManageForm();
                manufacturerManageForm.ShowDialog();
            }
            else
            {
                fc["ManufacturerManageForm"].Select();
            }

            //if (CreateTab("生产厂家管理", "生产厂家管理"))
            //{
            //    ManufacturerManageForm manufacturerManageForm = new ManufacturerManageForm();

            //    SetTab(manufacturerManageForm);
            //}
        }

        private void SupplierManage_Click(object sender, EventArgs e)
        {
            if (!CheckDog()) return;

            FormCollection fc = Application.OpenForms;
            if (fc["SupplierManageForm"] == null)
            {
                SupplierManageForm supplierManageForm = new SupplierManageForm();
                supplierManageForm.ShowDialog();
            }
            else
            {
                fc["SupplierManageForm"].Select();
            }

            //if (CreateTab("供货厂商管理", "供货厂商管理"))
            //{
            //    SupplierManageForm supplierManageForm = new SupplierManageForm();

            //    SetTab(supplierManageForm);
            //}
        }

        private void CustomerUnitManage_Click(object sender, EventArgs e)
        {
            if (!CheckDog()) return;

            FormCollection fc = Application.OpenForms;
            if (fc["CustomerUnitManageForm"] == null)
            {
                CustomerUnitManageForm customerUnitManageForm = new CustomerUnitManageForm();
                customerUnitManageForm.ShowDialog();
            }
            else
            {
                fc["CustomerUnitManageForm"].Select();
            }

            //if (CreateTab("客户单位管理", "客户单位管理"))
            //{
            //    CustomerUnitManageForm customerUnitManageForm = new CustomerUnitManageForm();

            //    SetTab(customerUnitManageForm);
            //}
        }

        private void TradeNameManage_Click(object sender, EventArgs e)
        {
            if (!CheckDog()) return;

            FormCollection fc = Application.OpenForms;
            if (fc["TradeNameManageForm"] == null)
            {
                TradeNameManageForm tradeNameManageForm = new TradeNameManageForm();
                tradeNameManageForm.ShowDialog();
            }
            else
            {
                fc["TradeNameManageForm"].Select();
            }

            //if (CreateTab("品名管理", "品名管理"))
            //{
            //    TradeNameManageForm tradeNameManageForm = new TradeNameManageForm();

            //    SetTab(tradeNameManageForm);
            //}
        }

        private void MachineType_Click(object sender, EventArgs e)
        {
            if (!CheckDog()) return;

            FormCollection fc = Application.OpenForms;
            if (fc["MachineTypeForm"] == null)
            {
                MachineTypeForm machineTypeForm = new MachineTypeForm();
                machineTypeForm.ShowDialog();
            }
            else
            {
                fc["MachineTypeForm"].Select();
            }
        }

        private void UnitType_Click(object sender, EventArgs e)
        {
            if (!CheckDog()) return;

            UnitTypeForm unitTypeForm = new UnitTypeForm();
            unitTypeForm.ShowDialog();
            //if (CreateTab("计量单位", "计量单位"))
            //{

            //    UnitTypeForm unitTypeForm = new UnitTypeForm();
            //    SetTab(unitTypeForm);
            //}
        }

        private void DataBackup_Click(object sender, EventArgs e)
        {
            if (!CheckDog()) return;

            if (MessageBox.Show("点击确定后将进行数据备份，如果今天已有过备份，则覆盖之前的数据备份，您确定要进行数据备份吗？", "数据备份", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    dataAccess = new DataAccess();
                    dataAccess.Open();
                    SqlCommand cmdBK = new SqlCommand();
                    cmdBK.CommandType = CommandType.Text;
                    cmdBK.Connection = dataAccess.Connection;
                    if (!File.Exists(LoginUser.SqlSetUpPath.Substring(0, LoginUser.SqlSetUpPath.Length - 1)))
                    {

                        Directory.CreateDirectory(LoginUser.SqlSetUpPath.Substring(0, LoginUser.SqlSetUpPath.Length - 1));
                    }
                    cmdBK.CommandText = "backup database tc_invoicing to disk='" + LoginUser.SqlSetUpPath + DateTime.Now.Date.ToString("yyyy_MM_dd") + "_tc_invoicing.bak' with init";
                    cmdBK.ExecuteNonQuery();
                    MessageBox.Show("数据库备份成功！", "数据备份", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        }

        private void DataRecovery_Click(object sender, EventArgs e)
        {
            if (!CheckDog()) return;

            FormCollection fc = Application.OpenForms;
            if (fc["DataRecoveryForm"] == null)
            {
                DataRecoveryForm dataBackupForm = new DataRecoveryForm();
                dataBackupForm.ShowDialog();
            }
            else
            {
                fc["DataRecoveryForm"].Select();
            }
        }

        /// <summary>
        /// 校验加密狗统一方法。
        /// </summary>
        /// <returns></returns>
        private bool CheckDog()
        {
#if DEBUG
            return true;
#else
            if (Util.checkDog())
            {
                return true;
            }
            else
            {
                MessageBox.Show("加密狗未找到，请插入加密狗！", "长白ERP系统", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

#endif
        }

        private void DataClear_Click(object sender, EventArgs e)
        {
            if (!CheckDog()) return;

            if (MessageBox.Show("警告(1/3):\n\r\n\r点击确定后将清除所有非基础数据信息，您确定要清除数据吗？", "数据清空", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                if (MessageBox.Show("警告(2/3):\n\r\n\r点击确定后将清除所有非基础数据信息，您确定要清除数据吗？", "数据清空", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    if (MessageBox.Show("警告(3/3):\n\r\n\r点击确定后将清除所有非基础数据信息，您确定要清除数据吗？", "数据清空", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                    {
                        try
                        {
                            dataAccess = new DataAccess();
                            dataAccess.Open();
                            SqlCommand cmd = new SqlCommand();
                            cmd.CommandText = " DELETE FROM TC_INPUT_STORAGE;DELETE FROM TC_OUTPUT_STORAGE;DELETE FROM TC_APPARATUS_QUALITY;"
                                                + " DELETE FROM TC_LOSE ;DELETE FROM TC_MAINTAIN ;"
                                                + " DELETE FROM TC_MAINTAIN_DETAIL;UPDATE TC_TEMP_STORAGE SET [COUNT]=0;"
                                                + " DELETE FROM TC_DISQUALIFICATION_MANAGE;DELETE FROM TC_DISQUALIFICATION_TO ;"
                                                + " DELETE FROM TC_STORAGE_DETAILS ";
                            cmd.Connection = dataAccess.Connection;
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("非基础数据清空成功！", "数据清空", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                }
            }

        }

        private void CompanyInfo_Click(object sender, EventArgs e)
        {
            if (!CheckDog()) return;

            FormCollection fc = Application.OpenForms;
            if (fc["CompanyInfoForm"] == null)
            {
                CompanyInfoForm companyInfoForm = new CompanyInfoForm();
                companyInfoForm.ShowDialog();
            }
            else
            {
                fc["CompanyInfoForm"].Select();
            }
        }

        private void EmpArchives_Click(object sender, EventArgs e)
        {
            if (!CheckDog()) return;

            FormCollection fc = Application.OpenForms;
            if (fc["EmpArchivesForm"] == null)
            {
                EmpArchivesForm empArchivesForm = new EmpArchivesForm();
                empArchivesForm.ShowDialog();
            }
            else
            {
                fc["EmpArchivesForm"].Select();
            }

        }

        private void CargospaceManage_Click(object sender, EventArgs e)
        {
            if (!CheckDog()) return;

            FormCollection fc = Application.OpenForms;
            if (fc["CargospaceManageForm"] == null)
            {
                CargospaceManageForm cargospaceManageForm = new CargospaceManageForm();
                cargospaceManageForm.ShowDialog();
            }
            else
            {
                fc["CargospaceManageForm"].Select();
            }
        }

        private void SystemLog_Click(object sender, EventArgs e)
        {
            if (!CheckDog()) return;

            FormCollection fc = Application.OpenForms;
            if (fc["SystemLogForm"] == null)
            {
                SystemLogForm systemLogForm = new SystemLogForm();
                systemLogForm.ShowDialog();
            }
            else
            {
                fc["SystemLogForm"].Select();
            }
        }

        private void LogOff_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void contextMenuCloseAll_Click(object sender, EventArgs e)
        {
            while (tabControl.TabCount > 1)
            {
                tabControl.TabPages.Remove(tabControl.TabPages[1]);
            }
        }

        private void DisqualificationManage_Click(object sender, EventArgs e)
        {
            if (CreateTab("不合格产品管理", "不合格产品管理"))
            {
                DisqualificationManageForm disqualificationManageForm = new DisqualificationManageForm();

                SetTab(disqualificationManageForm);
            }
        }

        private void WeaponQualityAegis_Click(object sender, EventArgs e)
        {
            if (CreateTab("不良事件及质量事故报告记录", "不良事件及质量事故报告记录"))
            {
                WeaponQualityAegisForm weaponQualityAegisForm = new WeaponQualityAegisForm();

                SetTab(weaponQualityAegisForm);
            }
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(Application.StartupPath + "\\XMLLoginUsers.xml");
            XmlNode xmlNode = doc.SelectSingleNode("login//loginType");
            if (xmlNode.InnerText.Equals("1"))
            {
                CustomerUnitManage.Visible = false;

            }
            else
            {
                CustomerPersional.Visible = false;
            }

            lblCurrentUser.Text = "当前用户: " + LoginUser.UserName;

            if (LoginUser.UserAuthority == "2")
            {
                AegisPlatform.DropDownItems["DataBackup"].Visible = false;
                AegisPlatform.DropDownItems["DataRecovery"].Visible = false;
                AegisPlatform.DropDownItems["DataClear"].Visible = false;
                SystemInfo.DropDownItems["SystemLog"].Visible = false;
                SystemInfo.DropDownItems["DataUpLoad"].Visible = false;
                SystemInfo.DropDownItems["AuthorityManage"].Text = "密码管理";

            }

            if (LoginUser.UserAuthority != "0")
            {
                FasterPlatform.Visible = false;
            }

            try
            {
                if (!ConfigurationManager.AppSettings["sjsb"].ToString().Trim().Equals("1"))
                {
                    btnReport.Visible = true;
                }
                else
                {
                    btnReport.Visible = false;
                }
            }
            catch (NullReferenceException ex)
            {
                btnReport.Visible = true;
            }

            if (LoginUser.UserAuthority == "2")
            {
                btnReport.Visible = false;
            }
        }

        private void AuthorityManage_Click(object sender, EventArgs e)
        {
            if (!CheckDog()) return;

            if (LoginUser.UserAuthority == "2")
            {
                passWordChangeForm passChange = new passWordChangeForm();
                passChange.ShowDialog();
            }
            else
            {
                PassWordManageForm passManage = new PassWordManageForm();
                passManage.ShowDialog();
            }
        }

        private void CheckRecordSelect_Click(object sender, EventArgs e)
        {
            if (CreateTab("验收记录查询", "验收记录查询"))
            {
                CheckRecordSelectForm checkRecordSelectForm = new CheckRecordSelectForm();

                SetTab(checkRecordSelectForm);
            }
        }

        private void NewMouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = InvoicingApp.Properties.Resources.leftBarFill;
        }

        private void NewMouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = InvoicingApp.Properties.Resources.leftBarButton;
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            if (!CheckDog()) return;

            FormCollection fc = Application.OpenForms;
            if (fc["CompanyInfoForm"] == null)
            {
                CompanyInfoForm companyInfoForm = new CompanyInfoForm();
                companyInfoForm.ShowDialog();
            }
            else
            {
                fc["CompanyInfoForm"].Select();
            }
        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            if (!CheckDog()) return;

            FormCollection fc = Application.OpenForms;
            if (fc["EmpArchivesForm"] == null)
            {
                EmpArchivesForm empArchivesForm = new EmpArchivesForm();
                empArchivesForm.ShowDialog();
            }
            else
            {
                fc["EmpArchivesForm"].Select();
            }
        }

        private void btnStorageCount_Click(object sender, EventArgs e)
        {
            if (CreateTab("库存盘点", "库存盘点"))
            {
                StorageInventoryForm storageInventoryForm = new StorageInventoryForm();

                SetTab(storageInventoryForm);
            }
        }

        private void btnLose_Click(object sender, EventArgs e)
        {
            if (CreateTab("报损下账", "报损下账"))
            {
                DamageAccountsForm damageAccountsForm = new DamageAccountsForm();

                SetTab(damageAccountsForm);
            }
        }

        private void btnBigPurchasesStorage_Click(object sender, EventArgs e)
        {
            if (CreateTab("购货入库", "购货入库"))
            {
                PurchasesStorageForm purchasesStorageForm = new PurchasesStorageForm();

                SetTab(purchasesStorageForm);
            }
        }

        private void btnBigBackStorage_Click(object sender, EventArgs e)
        {
            if (CreateTab("退货入库", "退货入库"))
            {
                BackStorageForm backStorageForm = new BackStorageForm();

                SetTab(backStorageForm);
            }
        }

        private void btnBigSellStorage_Click(object sender, EventArgs e)
        {
            if (CreateTab("销售出库", "销售出库"))
            {
                SellStorageForm sellStorageForm = new SellStorageForm();

                SetTab(sellStorageForm);
            }
        }

        private void btnBigBackOutStorage_Click(object sender, EventArgs e)
        {
            if (CreateTab("退货出库", "退货出库"))
            {
                BackOutStorageForm backOutStorageForm = new BackOutStorageForm();

                SetTab(backOutStorageForm);
            }
        }

        private void btnBigInStorageSelect_Click(object sender, EventArgs e)
        {
            if (CreateTab("入库查询", "入库查询"))
            {
                InStorageSelectForm inStorageSelectForm = new InStorageSelectForm();

                SetTab(inStorageSelectForm);
            }
        }

        private void btnBigInStorageCount_Click(object sender, EventArgs e)
        {
            if (CreateTab("入库统计", "入库统计"))
            {
                InStorageCountForm inStorageCountForm = new InStorageCountForm();

                SetTab(inStorageCountForm);
            }
        }

        private void btnBigOutStorageSelect_Click(object sender, EventArgs e)
        {
            if (CreateTab("出库查询", "出库查询"))
            {
                OutStorageSelectForm outStorageSelectForm = new OutStorageSelectForm();

                SetTab(outStorageSelectForm);
            }
        }

        private void btnBigOutStorageCount_Click(object sender, EventArgs e)
        {
            if (CreateTab("出库统计", "出库统计"))
            {
                OutStorageCountForm outStorageCountForm = new OutStorageCountForm();

                SetTab(outStorageCountForm);
            }
        }

        private void btnBigInventorySelect_Click(object sender, EventArgs e)
        {
            if (CreateTab("库存查询", "库存查询"))
            {
                InventorySelectForm inventorySelectForm = new InventorySelectForm();

                SetTab(inventorySelectForm);
            }
        }

        private void btnBigInventoryCount_Click(object sender, EventArgs e)
        {
            if (CreateTab("库存统计", "库存统计"))
            {
                InventoryCountForm inventoryCountForm = new InventoryCountForm();

                SetTab(inventoryCountForm);
            }
        }

        private void btnBigDamageSelect_Click(object sender, EventArgs e)
        {
            if (CreateTab("报损查询", "报损查询"))
            {
                DamageSelectForm damageSelectForm = new DamageSelectForm();

                SetTab(damageSelectForm);
            }
        }

        private void btnBigDamageCount_Click(object sender, EventArgs e)
        {
            if (CreateTab("报损统计", "报损统计"))
            {
                DamageCountForm damageCountForm = new DamageCountForm();

                SetTab(damageCountForm);
            }
        }

        private void 入库查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CreateTab("入库查询", "入库查询"))
            {
                InStorageSelectForm inStorageSelectForm = new InStorageSelectForm();

                SetTab(inStorageSelectForm);
            }
        }

        private void 出库查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CreateTab("出库查询", "出库查询"))
            {
                OutStorageSelectForm outStorageSelectForm = new OutStorageSelectForm();

                SetTab(outStorageSelectForm);
            }
        }

        private void 库存查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CreateTab("库存查询", "库存查询"))
            {
                InventorySelectForm inventorySelectForm = new InventorySelectForm();

                SetTab(inventorySelectForm);
            }
        }

        private void 报损查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CreateTab("报损查询", "报损查询"))
            {
                DamageSelectForm damageSelectForm = new DamageSelectForm();

                SetTab(damageSelectForm);
            }
        }

        private void 养护管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CreateTab("养护管理", "养护管理"))
            {
                MaintenanceManagementForm maintenanceManagementForm = new MaintenanceManagementForm();

                SetTab(maintenanceManagementForm);
            }
        }

        private void 不良事件及质量事故报告记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CreateTab("不良事件及质量事故报告记录", "不良事件及质量事故报告记录"))
            {
                WeaponQualityAegisForm weaponQualityAegisForm = new WeaponQualityAegisForm();

                SetTab(weaponQualityAegisForm);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("您确定要退出系统吗？", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void 用户指南ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckDog()) return;

            string FileName = Application.StartupPath + "\\用户手册\\长白ERP系统操作手册.chm";

            try
            {
                System.Diagnostics.Process.Start(FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("您的文件可能出现错误，请检查文件是否存在！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLaw_Click(object sender, EventArgs e)
        {
            if (!CheckDog()) return;

            LawForm law = new LawForm();
            law.ShowDialog();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckDog()) return;

            FormCollection fc = Application.OpenForms;
            if (fc["FrmAbout"] == null)
            {
                FrmAbout frmAbout = new FrmAbout();
                frmAbout.ShowDialog();
            }
            else
            {
                fc["FrmAbout"].Select();
            }
        }

        private void tabControl_MouseUp(object sender, MouseEventArgs e)
        {
            if ((e.Y < this.tabControl.GetTabRect(0).Bottom) && (e.Button == MouseButtons.Right))
            {
                contextMenuCloseAll.Show(this.tabControl, e.X + 1, e.Y);
            }
        }

        private void 验收记录查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CreateTab("验收记录查询", "验收记录查询"))
            {
                CheckRecordSelectForm checkRecordSelectForm = new CheckRecordSelectForm();

                SetTab(checkRecordSelectForm);
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (!CheckDog()) return;

            FileUpLoadForm data = new FileUpLoadForm();
            data.ShowDialog();

        }

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
#if !DEBUG

            if (hasKey)
            {
                if (!Util.checkDog())
                {
                    while (tabControl.TabCount > 1)
                    {
                        tabControl.TabPages.Remove(tabControl.TabPages[1]);
                    }
                    MessageBox.Show("加密狗未找到，请插入加密狗！", "长白ERP系统", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }

#endif
        }

        private void CustomerPersional_Click(object sender, EventArgs e)
        {
            if (!CheckDog()) return;

            CustomerPersional customerPersional = new CustomerPersional();
            customerPersional.ShowDialog();
        }

        private void FacilityManage_Click(object sender, EventArgs e)
        {

            if (CreateTab("设备仪器管理", "设备仪器管理"))
            {
                DeviceManageForm facilityManageForm = new DeviceManageForm();

                SetTab(facilityManageForm);
            }
        }

        private void ReturnVisit_Click(object sender, EventArgs e)
        {
            if (CreateTab("客户回访", "客户回访"))
            {
                ReturnVisitForm returnVisitForm = new ReturnVisitForm();

                SetTab(returnVisitForm);
            }
        }

        private void DataUpLoad_Click(object sender, EventArgs e)
        {
            if (!CheckDog()) return;

            FormCollection fc = Application.OpenForms;
            if (fc["SystemLogForm"] == null)
            {
                DataUpLoadForm dataUpLoadForm = new DataUpLoadForm();
                dataUpLoadForm.ShowDialog();
            }
            else
            {
                fc["SystemLogForm"].Select();
            }
        }
    }
}
