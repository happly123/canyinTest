//***********************************************************************
//* 系统名称	    ：  长白ERP系统
//* 功能模块	    ：  基础平台
//* 功能画面		：  产品管理
//* 画面名称	    ：  CustomerUnitManageForm
//* 完成年月日      ：  2010/07/15
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
    ///产品管理
    /// </summary>
    /// <history>
    ///     完成信息：李梓楠      2010/07/15 完成  
    ///     更新信息：
    /// </history>
    //***********************************************************************
    public partial class TradeNameManageForm : Form
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
        /// 记录返回的编号
        /// </summary>
        string child_maker_code = string.Empty;

        public TradeNameManageForm()
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
        ///     完成信息：李梓楠      2010/7/15 完成   
        ///     更新信息：
        /// </history>
        //*******************************************************************
        private void setButtonState()
        {
            switch (dataType)
            {
                case DataType.None:
                case DataType.Success:

                    txtGoods_code.ReadOnly = true;
                    txtGoods_name.ReadOnly = true;
                    txtGoods_yxm.ReadOnly = true;
                    txtGoods_reg_num.ReadOnly = true;
                    txtGoods_reg_mark.ReadOnly = true;
                    txtGoods_type.ReadOnly = true;
                    txtGoods_maker.ReadOnly = true;
                    txtGoods_maker.BackColor = Color.FromArgb(236, 233, 216);
                    txtGoods_validity.ReadOnly = true;
                    txtGoods_storemethod.ReadOnly = true;
                    txtGoods_appliance_code.ReadOnly = true;
                    txtGoods_appliance_code.BackColor = Color.FromArgb(236, 233, 216);
                    cb_goods_unit.Enabled = false;

                    btnInsert.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnCommit.Enabled = false;
                    btnCancel.Enabled = false;

                    break;
                case DataType.Insert:
                    txtGoods_code.ReadOnly = true;
                    txtGoods_name.ReadOnly = false;
                    txtGoods_yxm.ReadOnly = true;
                    txtGoods_reg_num.ReadOnly = false;
                    txtGoods_reg_mark.ReadOnly = false;
                    txtGoods_type.ReadOnly = false;
                    txtGoods_maker.ReadOnly = true;
                    txtGoods_validity.ReadOnly = false;
                    txtGoods_storemethod.ReadOnly = false;
                    txtGoods_appliance_code.ReadOnly = true;
                    txtGoods_appliance_code.BackColor = Color.FromArgb(255, 255, 255);
                    cb_goods_unit.Enabled = true;

                    txtGoods_maker.BackColor = Color.FromArgb(255, 255, 255);



                    txtGoods_code.Text = "";
                    txtGoods_name.Text = "";
                    txtGoods_yxm.Text = "";
                    txtGoods_reg_num.Text = "";
                    txtGoods_reg_mark.Text = "";
                    txtGoods_type.Text = "";
                    txtGoods_maker.Text = "双击选择生产厂家...";
                    txtGoods_validity.Text = "";
                    txtGoods_storemethod.Text = "";
                    txtGoods_appliance_code.Text = "双击选择器械分类...";
                    txtMaker_code.Text = "";
                    cb_goods_unit.SelectedIndex = 0;

                    btnInsert.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnCommit.Enabled = true;
                    btnCancel.Enabled = true;

                    break;
                case DataType.Update:
                    txtGoods_code.ReadOnly = true;
                    txtGoods_name.ReadOnly = false;
                    txtGoods_yxm.ReadOnly = true;
                    txtGoods_reg_num.ReadOnly = false;
                    txtGoods_reg_mark.ReadOnly = false;
                    txtGoods_type.ReadOnly = false;
                    txtGoods_maker.ReadOnly = true;
                    txtGoods_validity.ReadOnly = false;
                    txtGoods_storemethod.ReadOnly = false;
                    txtGoods_appliance_code.ReadOnly = true;
                    txtGoods_appliance_code.BackColor = Color.FromArgb(255, 255, 255);
                    txtGoods_maker.BackColor = Color.FromArgb(255, 255, 255);

                    cb_goods_unit.Enabled = true;

                    btnInsert.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnCommit.Enabled = true;
                    btnCancel.Enabled = true;

                    break;
                default:
                    txtGoods_code.ReadOnly = true;
                    txtGoods_name.ReadOnly = true;
                    txtGoods_yxm.ReadOnly = true;
                    txtGoods_reg_num.ReadOnly = true;
                    txtGoods_reg_mark.ReadOnly = true;
                    txtGoods_type.ReadOnly = true;
                    txtGoods_maker.ReadOnly = true;
                    txtGoods_validity.ReadOnly = true;
                    txtGoods_storemethod.ReadOnly = true;
                    txtGoods_appliance_code.ReadOnly = true;
                    txtGoods_appliance_code.BackColor = Color.FromArgb(236, 233, 216);
                    cb_goods_unit.Enabled = false;

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
        ///    完成信息：李梓楠      2010/7/15 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void TradeNameManageForm_Load(object sender, EventArgs e)
        {
            dgv.AutoGenerateColumns = false;


            //绑定combox单位值
            try
            {
                dataAccess = new DataAccess();
                dataAccess.Open();

                GetData getData = new GetData(dataAccess.Connection);

                DataTable dt = getData.GetSingleTable("TC_UNIT");

                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("请先填写计量单位信息，再进行操作！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    return;
                }
                cb_goods_unit.DataSource = dt.DefaultView;
                cb_goods_unit.DisplayMember = "unit_name";
                cb_goods_unit.ValueMember = "unit_name";

            }
            catch (Exception ex)
            {
                MessageBox.Show("数据加载时发生错误，请检查数据库！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            finally
            {
                dataAccess.Close();
            }
            BandingDgv();
            setButtonState();
        }


        //*******************************************************************
        /// <summary>
        /// 绑定画面
        /// </summary>
        /// <history>
        ///     完成信息：李梓楠      2010/7/15 完成   
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

                DataTable dtCounter = getData.GetTableBySqlStr(Constants.SqlStr.TC_GOODS_LEFTJOIN_TC_MAKER, sp);

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
                MessageBox.Show("数据加载时发生错误，请检查数据库！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                txtGoods_code.Text = dgv.SelectedRows[0].Cells["Goods_code"].Value.ToString();
                txtGoods_name.Text = dgv.SelectedRows[0].Cells["Goods_name"].Value.ToString();
                txtGoods_yxm.Text = dgv.SelectedRows[0].Cells["Goods_yxm"].Value.ToString();
                txtGoods_reg_num.Text = dgv.SelectedRows[0].Cells["Goods_reg_num"].Value.ToString();
                txtGoods_reg_mark.Text = dgv.SelectedRows[0].Cells["Goods_reg_mark"].Value.ToString();
                txtGoods_type.Text = dgv.SelectedRows[0].Cells["Goods_type"].Value.ToString();
                txtGoods_maker.Text = dgv.SelectedRows[0].Cells["Maker_name"].Value.ToString();
                txtGoods_validity.Text = dgv.SelectedRows[0].Cells["Goods_validity"].Value.ToString();
                txtGoods_storemethod.Text = dgv.SelectedRows[0].Cells["Goods_storemethod"].Value.ToString();
                txtGoods_appliance_code.Text = dgv.SelectedRows[0].Cells["Goods_appliance_code"].Value.ToString();
                txtMaker_code.Text = dgv.SelectedRows[0].Cells["Maker_code"].Value.ToString();
                cb_goods_unit.Text = dgv.SelectedRows[0].Cells["Goods_unit"].Value.ToString();

            }
        }
        /// <summary>
        /// 添加按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：李梓楠      2010/7/15 完成   
        ///    更新信息：
        /// </history>

        private void btnInsert_Click(object sender, EventArgs e)
        {
            dataType = DataType.Insert;
            setButtonState();
            txtGoods_name.Focus();
        }
        /// <summary>
        /// 修改按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：李梓楠      2010/7/15 完成   
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
            txtGoods_name.Focus();
        }

        //***********************************************************************
        /// <summary>
        /// 保存按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：李梓楠      2010/7/15 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnCommit_Click(object sender, EventArgs e)
        {


            //判断有效期不能为空

            //判断产品名称不能为空
            if (txtGoods_name.Text.Trim() == string.Empty)
            {
                MessageBox.Show("产品名称不能为空！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGoods_name.Focus();
                return;
            }
            if (txtGoods_appliance_code.Text.Trim() == string.Empty || txtGoods_appliance_code.Text == "双击选择器械分类...")
            {
                MessageBox.Show("器械分类不能为空！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGoods_appliance_code.Focus();
                return;
            }
            //判断注册证号不能为空
            if (txtGoods_reg_num.Text.Trim() == string.Empty)
            {
                MessageBox.Show("注册证号不能为空！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGoods_reg_num.Focus();
                return;
            }

            //判断生产厂家不能为空
            if (txtGoods_maker.Text.Trim() == string.Empty || txtGoods_maker.Text == "双击选择生产厂家...")
            {
                MessageBox.Show("生产厂家不能为空！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGoods_maker.Focus();
                return;
            }

            //判断规格型号不能为空
            if (txtGoods_type.Text.Trim() == string.Empty)
            {
                MessageBox.Show("规格型号不能为空！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGoods_type.Focus();
                return;
            }

            if (txtGoods_validity.Text.Trim() == string.Empty)
            {
                MessageBox.Show("有效期不能为空！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGoods_validity.Focus();
                return;
            }

            if (int.Parse(txtGoods_validity.Text.Trim()) == 0)
            {
                MessageBox.Show("有效期不能为0！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGoods_validity.Focus();
                return;
            }

            //判断储藏方法不能为空
            if (txtGoods_storemethod.Text.Trim() == string.Empty)
            {
                MessageBox.Show("储藏方法不能为空！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGoods_storemethod.Focus();
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
            EntityGoods entityGoods = new EntityGoods();
            try
            {
                result = -1;

                //如果是添加
                if (dataType == DataType.Insert)
                {


                    entityGoods.Goods_name = txtGoods_name.Text;
                    entityGoods.Goods_yxm = txtGoods_yxm.Text;
                    entityGoods.Goods_reg_num = txtGoods_reg_num.Text;
                    entityGoods.Goods_reg_mark = txtGoods_reg_mark.Text;
                    entityGoods.Goods_type = txtGoods_type.Text;
                    entityGoods.Goods_maker = txtMaker_code.Text;
                    entityGoods.Goods_validity = Convert.ToInt32(txtGoods_validity.Text.Trim());
                    entityGoods.Goods_unit = cb_goods_unit.SelectedValue.ToString();
                    entityGoods.Goods_storemethod = txtGoods_storemethod.Text;
                    entityGoods.Goods_appliance_code = txtGoods_appliance_code.Text;

                    dataAccess = new DataAccess();
                    dataAccess.Open();

                    MakePrimaryKey primaryKey = new MakePrimaryKey(dataAccess.Connection, dataAccess.Transaction);
                    entityGoods.Goods_code = primaryKey.MakeCode("产品");


                    GetData getData = new GetData(dataAccess.Connection);
                    result = getData.InsertGoods(entityGoods);

                    if (result == 0)
                    {
                        EntityTemp_storage entityTemp = new EntityTemp_storage();
                        entityTemp.Goods_code = entityGoods.Goods_code;
                        getData.InsertTemp_storageTable(entityTemp);

                    }

                }
                //如果是更新
                else if (dataType == DataType.Update)
                {
                    //给选中行赋值
                    countNum = dgv.SelectedRows[0].Index;

                    entityGoods.Goods_code = txtGoods_code.Text;
                    entityGoods.Goods_name = txtGoods_name.Text;
                    entityGoods.Goods_yxm = txtGoods_yxm.Text;
                    entityGoods.Goods_reg_num = txtGoods_reg_num.Text;
                    entityGoods.Goods_reg_mark = txtGoods_reg_mark.Text;
                    entityGoods.Goods_type = txtGoods_type.Text;
                    entityGoods.Goods_maker = txtMaker_code.Text;
                    entityGoods.Goods_validity = Convert.ToInt32(txtGoods_validity.Text.Trim());
                    entityGoods.Goods_unit = cb_goods_unit.SelectedValue.ToString();
                    entityGoods.Goods_storemethod = txtGoods_storemethod.Text;
                    entityGoods.Goods_appliance_code = txtGoods_appliance_code.Text;

                    dataAccess = new DataAccess();
                    dataAccess.Open();
                    dataAccess.BeginTransaction();

                    GetData getData = new GetData(dataAccess.Connection, dataAccess.Transaction);
                    //取得结果符
                    result = getData.UpdateGoods(entityGoods);
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
                MessageBox.Show("数据添加时发生错误，请检查数据库！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }
        /// <summary>
        /// 删除按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：李梓楠      2010/7/15 完成   
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
            sp.SetValue(":input_goods_code", dgv.SelectedRows[0].Cells["goods_code"].Value.ToString());

            dataAccess = new DataAccess();
            try
            {
                dataAccess.Open();
                GetData gd = new GetData(dataAccess.Connection);
                DataTable dt = gd.GetSingleTableByCondition("TC_INPUT_STORAGE", sp);
                if (dt != null && dt.Rows.Count > 0)
                {
                    MessageBox.Show("此产品信息已经被使用，无法删除！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                    dataAccess.Open();
                    dataAccess.BeginTransaction();
                    GetData getData = new GetData(dataAccess.Connection, dataAccess.Transaction);
                    sp.Clear();
                    sp.SetValue(":goods_code", dgv.SelectedRows[0].Cells["goods_code"].Value.ToString());
                    result = getData.DeleteRow("tc_goods", sp);
                    result = getData.DeleteRow("TC_TEMP_STORAGE", sp);
                    dataAccess.Commit();
                }
                catch (Exception ex)
                {
                    dataAccess.Rollback();
                    MessageBox.Show("数据删除时发生错误，请检查数据库！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    throw ex;
                }
                finally
                {
                    dataAccess.Close();
                }
                if (result == 0)
                {
                    MessageBox.Show("数据已经删除！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BandingDgv();
                }
                else
                {
                    MessageBox.Show("数据删除时发生错误，请检查数据库！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //设置按钮状态
                dataType = DataType.None;
                setButtonState();
            }
        }
        //***********************************************************************
        /// <summary>
        /// 取消按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：李梓楠      2010/7/15 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dataType = DataType.None;
            setButtonState();
            if (dgv != null && dgv.SelectedRows.Count != 0)
            {
                txtGoods_code.Text = dgv.SelectedRows[0].Cells["Goods_code"].Value.ToString();
                txtGoods_name.Text = dgv.SelectedRows[0].Cells["Goods_name"].Value.ToString();
                txtGoods_yxm.Text = dgv.SelectedRows[0].Cells["Goods_yxm"].Value.ToString();
                txtGoods_reg_num.Text = dgv.SelectedRows[0].Cells["Goods_reg_num"].Value.ToString();
                txtGoods_reg_mark.Text = dgv.SelectedRows[0].Cells["Goods_reg_mark"].Value.ToString();
                txtGoods_type.Text = dgv.SelectedRows[0].Cells["Goods_type"].Value.ToString();
                txtGoods_maker.Text = dgv.SelectedRows[0].Cells["Maker_name"].Value.ToString();
                txtGoods_validity.Text = dgv.SelectedRows[0].Cells["Goods_validity"].Value.ToString();
                txtGoods_storemethod.Text = dgv.SelectedRows[0].Cells["Goods_storemethod"].Value.ToString();
                txtGoods_appliance_code.Text = dgv.SelectedRows[0].Cells["Goods_appliance_code"].Value.ToString();
                txtMaker_code.Text = dgv.SelectedRows[0].Cells["Maker_code"].Value.ToString();
                cb_goods_unit.Text = dgv.SelectedRows[0].Cells["Goods_unit"].Value.ToString();
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
        ///    完成信息：李梓楠      2010/7/15 完成   
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

                if (txtGoods_nameSelect.Text != string.Empty)
                {
                    sp.SetValue(":Goods_name", txtGoods_nameSelect.Text);
                }

                if (txtGoods_yxmSelect.Text != string.Empty)
                {
                    sp.SetValue(":goods_YXM", txtGoods_yxmSelect.Text);

                }



                dataAccess = new DataAccess();
                dataAccess.Open();

                GetData getData = new GetData(dataAccess.Connection);

                DataTable dtCounter = getData.GetTableBySqlStr(Constants.SqlStr.TC_GOODS_LEFTJOIN_TC_MAKER, sp); ;


                if (dtCounter == null)
                {
                    MessageBox.Show("请查看数据库是否正常！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                dtCounter.Columns.Add("index", typeof(int));
                for (int i = 0; i < dtCounter.Rows.Count; i++)
                {
                    dtCounter.Rows[i]["index"] = i + 1;
                }
                dgv.DataSource = dtCounter;

                if (dtCounter.Rows.Count == 0)
                {
                    dataType = DataType.Insert;
                    setButtonState();
                    dataType = DataType.None;
                    setButtonState();
                    txtGoods_maker.Text = "";
                    txtGoods_appliance_code.Text = "";
                    MessageBox.Show("数据不存在，请查看输入的条件是否正确！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("数据查询时发生错误，请检查数据库！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            finally
            {
                dataAccess.Close();
            }
        }



        //客户名称改变事件
        private void txtMaker_name_TextChanged(object sender, EventArgs e)
        {
            txtGoods_yxm.Text = Util.IndexCode(txtGoods_name.Text);
        }

        //生产厂家文本框双击事件,选择生产厂家
        private void txtGoods_maker_DoubleClick(object sender, EventArgs e)
        {
            if (dataType == DataType.Insert || dataType == DataType.Update)
            {
                manufacturerManageDialogForm child = new manufacturerManageDialogForm();
                child.ShowDialog();
                if (child.Maker_name.Length != 0 && child.Maker_name[0] != null)
                    txtGoods_maker.Text = child.Maker_name[1];
                txtMaker_code.Text = child.Maker_name[0];
            }
            else return;
        }
        //器械类别文本框双击事件,选择器械类别
        private void txtGoods_appliance_code_DoubleClick(object sender, EventArgs e)
        {
            if (dataType == DataType.Insert || dataType == DataType.Update)
            {
                machineTypeDialogForm child = new machineTypeDialogForm();
                child.ShowDialog();
                if (child.Child_apparatus_name != string.Empty)
                    txtGoods_appliance_code.Text = child.Child_apparatus_name;
            }
            else return;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
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
