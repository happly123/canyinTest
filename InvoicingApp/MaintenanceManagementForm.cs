//***********************************************************************
//* 系统名称	    ：  长白ERP系统
//* 功能模块	    ：  质量平台
//* 功能画面		：  养护管理
//* 画面名称	    ：  CustomerUnitManageForm
//* 完成年月日      ：  2010/07/21
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
using System.Collections;

namespace InvoicingApp
{
    //***********************************************************************
    /// <summary>
    ///养护管理
    /// </summary>
    /// <history>
    ///     完成信息：李梓楠      2010/07/21 完成  
    ///     更新信息：
    /// </history>
    //***********************************************************************
    public partial class MaintenanceManagementForm : Form
    {
        /// <summary>
        /// 数据库连接句柄
        /// </summary>
        DataAccess dataAccess = null;

        /// <summary>
        /// 画面状态
        /// </summary>
        DataType dataType = DataType.None;
        public DateTime inStorageDate;

        /// <summary>
        /// 结果符，默认-1
        /// </summary>
        int result = -1;

        /// <summary>
        /// 选择记录的行号
        /// </summary>
        int countNum = 0;

        public MaintenanceManagementForm()
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
        ///     完成信息：李梓楠      2010/7/21 完成   
        ///     更新信息：
        /// </history>
        //*******************************************************************
        private void setButtonState()
        {
            switch (dataType)
            {
                case DataType.None:
                case DataType.Success:

                    txtMaintain_input_code.ReadOnly = true;
                    txtMaintain_application.ReadOnly = true;
                    txtMaintain_purpose.ReadOnly = true;
                    txtMaintain_quality.ReadOnly = true;
                    txtMaintain_test_items.ReadOnly = true;
                    txtMaintain_characters.ReadOnly = true;
                    txtGoods_name.ReadOnly = true;
                    dateMaintain_create_date.Enabled = false;

                    txtMaintain_input_code.BackColor = Color.FromArgb(236, 233, 216);



                    btnInsert.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnCommit.Enabled = false;
                    btnDelete.Enabled = true;
                    btnCancel.Enabled = false;
                    
                    break;
                case DataType.Insert:
                    txtMaintain_input_code.ReadOnly = true;
                    txtMaintain_application.ReadOnly = false;
                    txtMaintain_purpose.ReadOnly = false;
                    txtMaintain_quality.ReadOnly = false;
                    txtMaintain_test_items.ReadOnly = false;
                    txtMaintain_characters.ReadOnly = false;
                    dateMaintain_create_date.Enabled = true;
                    txtGoods_name.ReadOnly = true;

                    txtMaintain_input_code.BackColor = Color.FromArgb(255, 255, 255);

                    txtMaintain_input_code.Text = "双击选择入库编号...";
                    txtMaintain_application.Text = "";
                    txtMaintain_purpose.Text = "";
                    txtMaintain_quality.Text = "";
                    txtMaintain_test_items.Text = "";
                    txtMaintain_characters.Text = "";
                    dateMaintain_create_date.Text = "";
                    txtGoods_name.Text = "";

                    btnInsert.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnCommit.Enabled = true;
                    btnDelete.Enabled = false;
                    btnCancel.Enabled = true;

                    break;
                case DataType.Update:
                    txtMaintain_input_code.ReadOnly = true;
                    txtMaintain_application.ReadOnly = false;
                    txtMaintain_purpose.ReadOnly = false;
                    txtMaintain_quality.ReadOnly = false;
                    txtMaintain_test_items.ReadOnly = false;
                    txtMaintain_characters.ReadOnly = false;
                    dateMaintain_create_date.Enabled = true;
                    txtGoods_name.ReadOnly = true;

                    txtMaintain_input_code.BackColor = Color.FromArgb(236, 233, 216);


                    btnInsert.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnCommit.Enabled = true;
                    btnDelete.Enabled = false;
                    btnCancel.Enabled = true;

                    break;
                default:
                    txtMaintain_input_code.ReadOnly = true;
                    txtMaintain_application.ReadOnly = true;
                    txtMaintain_purpose.ReadOnly = true;
                    txtMaintain_quality.ReadOnly = true;
                    txtMaintain_test_items.ReadOnly = true;
                    txtMaintain_characters.ReadOnly = true;
                    dateMaintain_create_date.Enabled = false;
                    txtGoods_name.ReadOnly = true;

                    btnInsert.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnCommit.Enabled = false;
                    btnDelete.Enabled = true;
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
        ///    完成信息：李梓楠      2010/7/21 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void MaintenanceManagementForm_Load(object sender, EventArgs e)
        {
            dgv.AutoGenerateColumns = false;

            BandingDgv();
            setButtonState();
            txtMaintain_codeSelect.Focus();
            
        }
        //*******************************************************************
        /// <summary>
        /// 绑定画面
        /// </summary>
        /// <history>
        ///     完成信息：李梓楠      2010/7/21 完成   
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

                DataTable dtCounter = getData.GetTableBySqlStr(Constants.SqlStr.TC_MAINTAIN_LEFTJOIN_TC_TC_INPUT_STORAGE_LEFTJOIN_TC_GOODS_LEFTJOIN_TC_MAKER, sp);
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
                MessageBox.Show("请查看数据库是否正常！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw ex;
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
                txtMaintain_input_code.Text = dgv.SelectedRows[0].Cells["Maintain_input_code"].Value.ToString();
                txtMaintain_application.Text = dgv.SelectedRows[0].Cells["Maintain_application"].Value.ToString();
                txtMaintain_purpose.Text = dgv.SelectedRows[0].Cells["Maintain_purpose"].Value.ToString();
                txtMaintain_quality.Text = dgv.SelectedRows[0].Cells["Maintain_quality"].Value.ToString();
                txtMaintain_test_items.Text = dgv.SelectedRows[0].Cells["Maintain_test_items"].Value.ToString();
                txtMaintain_characters.Text = dgv.SelectedRows[0].Cells["Maintain_characters"].Value.ToString();
                txtGoods_name.Text = dgv.SelectedRows[0].Cells["goods_name"].Value.ToString();
                dateMaintain_create_date.Value = DateTime.Parse(dgv.SelectedRows[0].Cells["Maintain_create_date"].Value.ToString());
            }
        }
        /// <summary>
        /// 添加按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：李梓楠      2010/7/21 完成   
        ///    更新信息：
        /// </history>

        private void btnInsert_Click(object sender, EventArgs e)
        {
            dataType = DataType.Insert;
            setButtonState();
            txtMaintain_input_code.Focus();
        }
        /// <summary>
        /// 修改按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：李梓楠      2010/7/21 完成   
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
            txtMaintain_input_code.Focus();
        }

        //***********************************************************************
        /// <summary>
        /// 保存按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：李梓楠      2010/7/21 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnCommit_Click(object sender, EventArgs e)
        {
            //判断入库编号不为空
            if (txtMaintain_input_code.Text.Trim() == string.Empty || txtMaintain_input_code.Text == "双击选择入库编号...")
            {
                MessageBox.Show("入库编号不能为空！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaintain_input_code.Focus();
                return;
            }
            //判断时间有效性
            if (DateTime.Now.Date < dateMaintain_create_date.Value.Date)
            {
                MessageBox.Show("建档日期不可大于今天日期！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateMaintain_create_date.Focus();
                return;
            }
            if (inStorageDate > dateMaintain_create_date.Value.Date)
            {
                MessageBox.Show("建档日期不可小于入库日期！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateMaintain_create_date.Focus();
                return;
            }
            //判断非法字符
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
            EntityMaintain entity = new EntityMaintain();
            try
            {
                result = -1;

                //如果是添加
                if (dataType == DataType.Insert)
                {
                    entity.Maintain_input_code = txtMaintain_input_code.Text;
                    entity.Maintain_application = txtMaintain_application.Text;
                    entity.Maintain_purpose = txtMaintain_purpose.Text;
                    entity.Maintain_quality = txtMaintain_quality.Text;
                    entity.Maintain_test_items = txtMaintain_test_items.Text;
                    entity.Maintain_characters = txtMaintain_characters.Text;
                    entity.Maintain_create_date = dateMaintain_create_date.Value.Date;

                    dataAccess = new DataAccess();
                    dataAccess.Open();

                    MakePrimaryKey primaryKey = new MakePrimaryKey(dataAccess.Connection, dataAccess.Transaction);
                    entity.Maintain_code = primaryKey.MakeCode("养护记录");

                    GetData getData = new GetData(dataAccess.Connection);
                    result = getData.InsertMaintainTable(entity);

                    //处理操作标示
                    EntityInput_storage inputStorageEntity = new EntityInput_storage();
                    inputStorageEntity.OPERATE_TYPE = '1';
                    inputStorageEntity.INPUT_CODE = txtMaintain_input_code.Text;

                    result = getData.UpdateOperate_typeByInput_codeRow(inputStorageEntity);

                }
                //如果是更新
                else if (dataType == DataType.Update)
                {
                    //给选中行赋值
                    countNum = dgv.SelectedRows[0].Index;

                    entity.Maintain_code = dgv.SelectedRows[0].Cells["Maintain_code"].Value.ToString();
                    entity.Maintain_input_code = txtMaintain_input_code.Text;
                    entity.Maintain_application = txtMaintain_application.Text;
                    entity.Maintain_purpose = txtMaintain_purpose.Text;
                    entity.Maintain_quality = txtMaintain_quality.Text;
                    entity.Maintain_test_items = txtMaintain_test_items.Text;
                    entity.Maintain_characters = txtMaintain_characters.Text;
                    entity.Maintain_create_date = dateMaintain_create_date.Value.Date;
                    
                    dataAccess = new DataAccess();
                    dataAccess.Open();
                    dataAccess.BeginTransaction();

                    GetData getData = new GetData(dataAccess.Connection, dataAccess.Transaction);
                    //取得结果符
                    result = getData.UpdateMaintainTable(entity);
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
                MessageBox.Show("操作数据时发生错误，请检查数据库是否正常开启！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw ex;
            }
            finally
            {

                //关闭数据库连接
                dataAccess.Close();

            }
            if (result == 0)
            {
                MessageBox.Show("数据已经保存成功！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                BandingDgv();
            }
            else
            {
                MessageBox.Show("数据保存时发生错误，请检查数据库！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //设置按钮状态
            dataType = DataType.None;
            setButtonState();

            //重新加载画面
            BandingDgv();

        }
        /// <summary>
        /// 删除按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：李梓楠      2010/7/21 完成   
        ///    更新信息：
        /// </history>

        private void btnDelete_Click(object sender, EventArgs e)
        {


            result = -1;
            countNum = 0;
            int result1 = -1;
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

            if (MessageBox.Show("您确定要删除该养护记录吗？如果删除该记录，明细记录也会被同时删除！", Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    SearchParameter sp = new SearchParameter();
                    sp.SetValue(":maintain_code", dgv.SelectedRows[0].Cells["maintain_code"].Value.ToString());

                    dataAccess = new DataAccess();
                    dataAccess.Open();
                    dataAccess.BeginTransaction();
                    GetData getData = new GetData(dataAccess.Connection, dataAccess.Transaction);

                    result = getData.DeleteRow("tc_maintain", sp);
                    result1 = getData.DeleteRow("tc_maintain_detail", sp);
                    dataAccess.Commit();
                }
                catch (Exception ex)
                {
                    dataAccess.Rollback();
                    MessageBox.Show(ex.Message);
                    throw ex;
                }
                finally
                {
                    dataAccess.Close();
                    
                }
                if (result == 0 && result1 == 0)
                {
                    if (!updateMark())
                    {
                        try
                        {
                            dataAccess = new DataAccess();
                            dataAccess.Open();
                            GetData getData = new GetData(dataAccess.Connection);
                            //处理操作标示
                            EntityInput_storage inputStorageEntity = new EntityInput_storage();
                            inputStorageEntity.OPERATE_TYPE = '0';
                            inputStorageEntity.INPUT_CODE = txtMaintain_input_code.Text;

                            result = getData.UpdateOperate_typeByInput_codeRow(inputStorageEntity);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("请查看数据库是否正常！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        finally
                        {
                            if (dataAccess.Connection != null)
                                dataAccess.Close();
                        }

                    }
                    
                    MessageBox.Show("数据已经被成功删除！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BandingDgv();
                }
                else
                {
                    MessageBox.Show("数据删除时发生错误，请检查数据库！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        ///    完成信息：李梓楠      2010/7/21 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dataType = DataType.None;
            setButtonState();
            if (dgv != null && dgv.SelectedRows.Count != 0)
            {
                txtMaintain_input_code.Text = dgv.SelectedRows[0].Cells["Maintain_input_code"].Value.ToString();
                txtMaintain_application.Text = dgv.SelectedRows[0].Cells["Maintain_application"].Value.ToString();
                txtMaintain_purpose.Text = dgv.SelectedRows[0].Cells["Maintain_purpose"].Value.ToString();
                txtMaintain_quality.Text = dgv.SelectedRows[0].Cells["Maintain_quality"].Value.ToString();
                txtMaintain_test_items.Text = dgv.SelectedRows[0].Cells["Maintain_test_items"].Value.ToString();
                txtMaintain_characters.Text = dgv.SelectedRows[0].Cells["Maintain_characters"].Value.ToString();
                txtGoods_name.Text = dgv.SelectedRows[0].Cells["goods_name"].Value.ToString();
                dateMaintain_create_date.Value = DateTime.Parse(dgv.SelectedRows[0].Cells["Maintain_create_date"].Value.ToString());
            }
            else
            { 
                 txtMaintain_input_code.Text = "";
                txtMaintain_application.Text = "";
                txtMaintain_purpose.Text = "";
                txtMaintain_quality.Text = "";
                txtMaintain_test_items.Text = "";
                txtMaintain_characters.Text = "";
                txtGoods_name.Text = "";
                dateMaintain_create_date.Value = DateTime.Now.Date;
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
        ///    完成信息：李梓楠      2010/7/21 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnSelect_Click(object sender, EventArgs e)
        {
            //判断非法字符
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
            try
            {
                SearchParameter sp = new SearchParameter();

                if (txtGoods_nameSelect.Text.Trim() != string.Empty)
                {
                    sp.SetValue(":Goods_name", txtGoods_nameSelect.Text);
                }

                if (txtGoods_yxmSelect.Text.Trim() != string.Empty)
                {
                    sp.SetValue(":goods_YXM", txtGoods_yxmSelect.Text);
                }
                if (txtMaintain_codeSelect.Text.Trim() != string.Empty)
                {
                    sp.SetValue(":maintain_code", txtMaintain_codeSelect.Text);
                }


                dataAccess = new DataAccess();
                dataAccess.Open();

                GetData getData = new GetData(dataAccess.Connection);

                DataTable dtCondition = getData.GetTableBySqlStr(Constants.SqlStr.TC_MAINTAIN_LEFTJOIN_TC_TC_INPUT_STORAGE_LEFTJOIN_TC_GOODS_LEFTJOIN_TC_MAKER, sp);

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
                    txtMaintain_input_code.Text = "";
                    MessageBox.Show("数据不存在，请查看输入的条件是否正确！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("请查看数据库是否正常！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw ex;
            }
            finally
            {
                dataAccess.Close();
            }
        }
        //判断标示
        private bool updateMark()
        {
            Boolean mark = false;
            dataAccess = new DataAccess();
            try
            {
                SearchParameter sp = new SearchParameter();
                sp.SetValue(":Maintain_input_code", txtMaintain_input_code.Text);
                dataAccess.Open();
                GetData getData = new GetData(dataAccess.Connection);
                DataTable dt = getData.GetSingleTableByCondition("TC_MAINTAIN", sp);
                if (dt.Rows.Count > 0)
                {
                    mark = true;
                    return mark;
                }
                sp.Clear();
                sp.SetValue("input_code", txtMaintain_input_code.Text);
                dataAccess.Open();
                getData = new GetData(dataAccess.Connection);
                dt = getData.GetSingleTableByCondition("TC_lose", sp);
                if (dt.Rows.Count > 0)
                {
                    mark = true;
                    return mark;
                }

                dataAccess.Open();
                getData = new GetData(dataAccess.Connection);
                dt = getData.GetSingleTableByCondition("TC_OUTPUT_STORAGE", sp);
                if (dt.Rows.Count > 0)
                {
                    mark = true;
                    return mark;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("请查看数据库是否正常！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                throw ex;
            }
            finally
            {
                if(dataAccess.Connection!=null)
                dataAccess.Close();
            }
            return mark;
        }
        //弹出入库编号选择界面
        private void txtMaintain_input_code_DoubleClick(object sender, EventArgs e)
        {
            if (dataType == DataType.Insert)
            {
                initStorageDialogForm child = new initStorageDialogForm();
                child.ShowDialog();
                if (child.Inputcode != string.Empty)
                {
                    txtMaintain_input_code.Text = child.Inputcode;
                    txtGoods_name.Text = child.goods_name;
                    inStorageDate = child.inStorageDate;
                }
            }
            else return;
        }
        //双击一行进入养护记录明细
        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1 || e.ColumnIndex <= -1)//双击表头或列头时不起作用   
            {
                return;
            }

            if (dgv.SelectedRows != null && dgv.SelectedRows.Count == 1)
            {
                maintenanceDialogForm childForm = new maintenanceDialogForm(dgv.SelectedRows[0].Cells["Maintain_code"].Value.ToString(), DateTime.Parse(dgv.SelectedRows[0].Cells["maintain_create_date"].Value.ToString()));
                childForm.ShowDialog();
            }
            else MessageBox.Show("只能选择一条记录进行查看！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //***********************************************************************
        /// <summary>
        /// 打印按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：李梓楠      2010/7/26 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows != null && dgv.SelectedRows.Count == 1)
            {
                Hashtable ht = new Hashtable();
                ht.Add("maintain_code", dgv.SelectedRows[0].Cells["maintain_code"].Value.ToString());
                ht.Add("goods_name", dgv.SelectedRows[0].Cells["goods_name"].Value.ToString());
                ht.Add("goods_type", dgv.SelectedRows[0].Cells["goods_type"].Value.ToString());
                ht.Add("maker_name", dgv.SelectedRows[0].Cells["maker_name"].Value.ToString());
                ht.Add("goods_validity", dgv.SelectedRows[0].Cells["goods_validity"].Value.ToString());
                ht.Add("goods_reg_num", dgv.SelectedRows[0].Cells["goods_reg_num"].Value.ToString());
                ht.Add("maker_postal_code", dgv.SelectedRows[0].Cells["maker_postal_code"].Value.ToString());
                ht.Add("maker_address", dgv.SelectedRows[0].Cells["maker_address"].Value.ToString());
                ht.Add("maker_tel", dgv.SelectedRows[0].Cells["maker_tel"].Value.ToString());
                ht.Add("maintain_application", dgv.SelectedRows[0].Cells["maintain_application"].Value.ToString());
                ht.Add("maintain_purpose", dgv.SelectedRows[0].Cells["maintain_purpose"].Value.ToString());
                ht.Add("maintain_quality", dgv.SelectedRows[0].Cells["maintain_quality"].Value.ToString());
                ht.Add("maintain_test_items", dgv.SelectedRows[0].Cells["maintain_test_items"].Value.ToString());
                ht.Add("maintain_characters", dgv.SelectedRows[0].Cells["maintain_characters"].Value.ToString());
                ht.Add("goods_storemethod", dgv.SelectedRows[0].Cells["goods_storemethod"].Value.ToString());
                ht.Add("input_packing_in", dgv.SelectedRows[0].Cells["input_packing_in"].Value.ToString());
                ht.Add("input_packing_mid", dgv.SelectedRows[0].Cells["input_packing_mid"].Value.ToString());
                ht.Add("input_packing_out", dgv.SelectedRows[0].Cells["input_packing_out"].Value.ToString());
                ht.Add("input_batch_num", dgv.SelectedRows[0].Cells["input_batch_num"].Value.ToString());

                MaintenancePrint maintenancePrint = new MaintenancePrint(ht);
                maintenancePrint.ShowDialog();
            }
            else MessageBox.Show("没有可以打印的数据！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaintain_codeSelect.Text = "";
            txtGoods_nameSelect.Text = "";
            txtGoods_yxmSelect.Text = "";
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
