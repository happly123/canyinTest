//***********************************************************************
//* 系统名称	    ：  长白ERP系统
//* 功能模块	    ：  基础平台
//* 功能画面		：  生产厂家管理
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
    ///生产厂家管理
    /// </summary>
    /// <history>
    ///     完成信息：李梓楠      2010/07/13 完成  
    ///     更新信息：
    /// </history>
    //***********************************************************************
    public partial class ManufacturerManageForm : Form
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


        public ManufacturerManageForm()
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
                    txtMaker_code.ReadOnly = true;
                    txtMaker_name.ReadOnly = true;
                    txtMaker_yxm.ReadOnly = true;
                    txtMaker_address.ReadOnly = true;
                    txtMaker_quality_reg.ReadOnly = true;
                    txtMaker_hygiene.ReadOnly = true;
                    txtMaker_licence.ReadOnly = true;
                    txtMaker_tel.ReadOnly = true;
                    txtMaker_principal.ReadOnly = true;
                    txtMaker_postal_code.ReadOnly = true;
                    txtMaker_business_scope.ReadOnly = true;
                    txtMaker_business_goods.ReadOnly = true;



                    btnInsert.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnCommit.Enabled = false;
                    btnDelete.Enabled = true;
                    btnCancel.Enabled = false;

                    break;
                case DataType.Insert:
                    txtMaker_code.ReadOnly = true;
                    txtMaker_name.ReadOnly = false;
                    txtMaker_yxm.ReadOnly = true;
                    txtMaker_address.ReadOnly = false;
                    txtMaker_quality_reg.ReadOnly = false;
                    txtMaker_hygiene.ReadOnly = false;
                    txtMaker_licence.ReadOnly = false;
                    txtMaker_tel.ReadOnly = false;
                    txtMaker_principal.ReadOnly = false;
                    txtMaker_postal_code.ReadOnly = false;
                    txtMaker_business_scope.ReadOnly = false;
                    txtMaker_business_goods.ReadOnly = false;

                    txtMaker_code.Text = "";
                    txtMaker_name.Text = "";
                    txtMaker_yxm.Text = "";
                    txtMaker_address.Text = "";
                    txtMaker_quality_reg.Text = "";
                    txtMaker_hygiene.Text = "";
                    txtMaker_licence.Text = "";
                    txtMaker_tel.Text = "";
                    txtMaker_principal.Text = "";
                    txtMaker_postal_code.Text = "";
                    txtMaker_business_scope.Text = "";
                    txtMaker_business_goods.Text = "";

                    btnInsert.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnCommit.Enabled = true;
                    btnCancel.Enabled = true;

                    break;
                case DataType.Update:
                    txtMaker_code.ReadOnly = true;
                    txtMaker_name.ReadOnly = false;
                    txtMaker_yxm.ReadOnly = true;
                    txtMaker_address.ReadOnly = false;
                    txtMaker_quality_reg.ReadOnly = false;
                    txtMaker_hygiene.ReadOnly = false;
                    txtMaker_licence.ReadOnly = false;
                    txtMaker_tel.ReadOnly = false;
                    txtMaker_principal.ReadOnly = false;
                    txtMaker_postal_code.ReadOnly = false;
                    txtMaker_business_scope.ReadOnly = false;
                    txtMaker_business_goods.ReadOnly = false;


                    btnInsert.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnCommit.Enabled = true;
                    btnCancel.Enabled = true;

                    break;
                default:
                    txtMaker_code.ReadOnly = true;
                    txtMaker_name.ReadOnly = true;
                    txtMaker_yxm.ReadOnly = true;
                    txtMaker_address.ReadOnly = true;
                    txtMaker_quality_reg.ReadOnly = true;
                    txtMaker_hygiene.ReadOnly = true;
                    txtMaker_licence.ReadOnly = true;
                    txtMaker_tel.ReadOnly = true;
                    txtMaker_principal.ReadOnly = true;
                    txtMaker_postal_code.ReadOnly = true;
                    txtMaker_business_scope.ReadOnly = true;
                    txtMaker_business_goods.ReadOnly = true;

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
        private void ManufacturerManageForm_Load(object sender, EventArgs e)
        {
            dgv.AutoGenerateColumns = false;
            BandingDgv();
            setButtonState();
            txtMaker_nameSelect.Focus();
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

                DataTable dtCounter = getData.GetSingleTable("TC_MAKER");

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
                MessageBox.Show("请查看数据库是否正常！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                txtMaker_code.Text = dgv.SelectedRows[0].Cells["Maker_code"].Value.ToString();
                txtMaker_name.Text = dgv.SelectedRows[0].Cells["Maker_name"].Value.ToString();
                txtMaker_yxm.Text = dgv.SelectedRows[0].Cells["Maker_yxm"].Value.ToString();
                txtMaker_address.Text = dgv.SelectedRows[0].Cells["Maker_address"].Value.ToString();
                txtMaker_quality_reg.Text = dgv.SelectedRows[0].Cells["Maker_quality_reg"].Value.ToString();
                txtMaker_hygiene.Text = dgv.SelectedRows[0].Cells["Maker_hygiene"].Value.ToString();
                txtMaker_licence.Text = dgv.SelectedRows[0].Cells["Maker_licence"].Value.ToString();
                txtMaker_tel.Text = dgv.SelectedRows[0].Cells["Maker_tel"].Value.ToString();
                txtMaker_principal.Text = dgv.SelectedRows[0].Cells["Maker_principal"].Value.ToString();
                txtMaker_postal_code.Text = dgv.SelectedRows[0].Cells["Maker_postal_code"].Value.ToString();
                txtMaker_business_scope.Text = dgv.SelectedRows[0].Cells["Maker_business_scope"].Value.ToString();
                txtMaker_business_goods.Text = dgv.SelectedRows[0].Cells["Maker_business_goods"].Value.ToString();
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
            txtMaker_name.Focus();
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
            txtMaker_name.Focus();
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
            if (txtMaker_name.Text.Trim() == string.Empty)
            {
                MessageBox.Show("生产厂家名称不能为空！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaker_name.Focus();
                return;
            }
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
            EntityMaker entityMaker = new EntityMaker();
            try
            {
                result = -1;

                //如果是添加
                if (dataType == DataType.Insert)
                {

                    entityMaker.Maker_code = txtMaker_code.Text;
                    entityMaker.Maker_name = txtMaker_name.Text;
                    entityMaker.Maker_yxm = txtMaker_yxm.Text;
                    entityMaker.Maker_address = txtMaker_address.Text;
                    entityMaker.Maker_quality_reg = txtMaker_quality_reg.Text;
                    entityMaker.Maker_hygiene = txtMaker_hygiene.Text;
                    entityMaker.Maker_licence = txtMaker_licence.Text;
                    entityMaker.Maker_tel = txtMaker_tel.Text;
                    entityMaker.Maker_principal = txtMaker_principal.Text;
                    entityMaker.Maker_postal_code = txtMaker_postal_code.Text;
                    entityMaker.Maker_business_scope = txtMaker_business_scope.Text;
                    entityMaker.Maker_business_goods = txtMaker_business_goods.Text;

                    dataAccess = new DataAccess();
                    dataAccess.Open();

                    MakePrimaryKey primaryKey = new MakePrimaryKey(dataAccess.Connection, dataAccess.Transaction);
                    entityMaker.Maker_code = primaryKey.MakeCode("生产厂家");


                    GetData getData = new GetData(dataAccess.Connection);
                    result = getData.InsertMaker(entityMaker);

                }
                //如果是更新
                else if (dataType == DataType.Update)
                {
                    //给选中行赋值
                    countNum = dgv.SelectedRows[0].Index;

                    entityMaker.Maker_code = txtMaker_code.Text;
                    entityMaker.Maker_name = txtMaker_name.Text;
                    entityMaker.Maker_yxm = txtMaker_yxm.Text;
                    entityMaker.Maker_address = txtMaker_address.Text;
                    entityMaker.Maker_quality_reg = txtMaker_quality_reg.Text;
                    entityMaker.Maker_hygiene = txtMaker_hygiene.Text;
                    entityMaker.Maker_licence = txtMaker_licence.Text;
                    entityMaker.Maker_tel = txtMaker_tel.Text;
                    entityMaker.Maker_principal = txtMaker_principal.Text;
                    entityMaker.Maker_postal_code = txtMaker_postal_code.Text;
                    entityMaker.Maker_business_scope = txtMaker_business_scope.Text;
                    entityMaker.Maker_business_goods = txtMaker_business_goods.Text;

                    dataAccess = new DataAccess();
                    dataAccess.Open();
                    dataAccess.BeginTransaction();

                    GetData getData = new GetData(dataAccess.Connection, dataAccess.Transaction);
                    //取得结果符
                    result = getData.UpdateMaker(entityMaker);
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
            sp.SetValue(":GOODS_MAKER", dgv.SelectedRows[0].Cells["MAKER_CODE"].Value.ToString());

            dataAccess = new DataAccess();
            try
            {
                dataAccess.Open();
                GetData gd = new GetData(dataAccess.Connection);
                DataTable dt = gd.GetSingleTableByCondition("TC_GOODS", sp);
                if (dt != null && dt.Rows.Count > 0)
                {
                    MessageBox.Show("此生产厂家信息已经被使用，无法删除！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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


            if (MessageBox.Show("您确定要删除该数据吗？", Text, MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    sp.Clear();
                    sp.SetValue(":MAKER_CODE", dgv.SelectedRows[0].Cells["MAKER_CODE"].Value.ToString());

                    dataAccess.Open();
                    dataAccess.BeginTransaction();
                    GetData getData = new GetData(dataAccess.Connection, dataAccess.Transaction);

                    result = getData.DeleteRow("TC_MAKER", sp);

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
                txtMaker_code.Text = dgv.SelectedRows[0].Cells["Maker_code"].Value.ToString();
                txtMaker_name.Text = dgv.SelectedRows[0].Cells["Maker_name"].Value.ToString();
                txtMaker_yxm.Text = dgv.SelectedRows[0].Cells["Maker_yxm"].Value.ToString();
                txtMaker_address.Text = dgv.SelectedRows[0].Cells["Maker_address"].Value.ToString();
                txtMaker_quality_reg.Text = dgv.SelectedRows[0].Cells["Maker_quality_reg"].Value.ToString();
                txtMaker_hygiene.Text = dgv.SelectedRows[0].Cells["Maker_hygiene"].Value.ToString();
                txtMaker_licence.Text = dgv.SelectedRows[0].Cells["Maker_licence"].Value.ToString();
                txtMaker_tel.Text = dgv.SelectedRows[0].Cells["Maker_tel"].Value.ToString();
                txtMaker_principal.Text = dgv.SelectedRows[0].Cells["Maker_principal"].Value.ToString();
                txtMaker_postal_code.Text = dgv.SelectedRows[0].Cells["Maker_postal_code"].Value.ToString();
                txtMaker_business_scope.Text = dgv.SelectedRows[0].Cells["Maker_business_scope"].Value.ToString();
                txtMaker_business_goods.Text = dgv.SelectedRows[0].Cells["Maker_business_goods"].Value.ToString();
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
            try
            {
                SearchParameter sp = new SearchParameter();

                if (txtMaker_nameSelect.Text.Trim() != string.Empty)
                {
                    sp.SetValue(":MAKER_NAME", txtMaker_nameSelect.Text);
                }

                if (txtMaker_yxmSelect.Text.Trim() != string.Empty)
                {
                    sp.SetValue(":MAKER_YXM", txtMaker_yxmSelect.Text);

                }

              

                dataAccess = new DataAccess();
                dataAccess.Open();

                GetData getData = new GetData(dataAccess.Connection);

                DataTable dtCondition = getData.GetSingleTableByCondition("TC_MAKER", sp);

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
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (dataAccess.Connection != null)
                dataAccess.Close();
            }
        }

        

        //客户名称改变事件
        private void txtMaker_name_TextChanged(object sender, EventArgs e)
        {
            txtMaker_yxm.Text = Util.IndexCode(txtMaker_name.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaker_nameSelect.Text = "";
            txtMaker_yxmSelect.Text = "";
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
