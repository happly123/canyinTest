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
    public partial class CustomerPersional : Form
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
        ///     完成信息：李梓楠      2010/11/8 完成   
        ///     更新信息：
        /// </history>
        //*******************************************************************
        private void setButtonState()
        {
            switch (dataType)
            {
                case DataType.None:
                case DataType.Success:

                    txtCustomer_name.ReadOnly = true;
                    txtCustomer_yxm.ReadOnly = true;
                    txtCustomer_tel.ReadOnly = true;
                    txtCustomer_address.ReadOnly = true;
                    txtCustomer_usecode.ReadOnly = true;
                    txtCustomer_age.ReadOnly = true;
                    cbCustomer_sex.Enabled = false;
                    
                    btnInsert.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnCommit.Enabled = false;
                    btnCancel.Enabled = false;

                    break;
                case DataType.Insert:
                    txtCustomer_name.ReadOnly = false;
                    txtCustomer_yxm.ReadOnly = true;
                    txtCustomer_tel.ReadOnly = false;
                    txtCustomer_address.ReadOnly = false;
                    txtCustomer_usecode.ReadOnly = false;
                    txtCustomer_age.ReadOnly = false;
                    cbCustomer_sex.Enabled = true;

                    txtCustomer_name.Text = "";
                    txtCustomer_yxm.Text = "";
                    txtCustomer_tel.Text = "";
                    txtCustomer_address.Text = "";
                    txtCustomer_age.Text = "";
                    txtCustomer_usecode.Text = "";
                    cbCustomer_sex.SelectedIndex = 0;

                    btnInsert.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnCommit.Enabled = true;
                    btnCancel.Enabled = true;

                    break;
                case DataType.Update:
                    txtCustomer_name.ReadOnly = false;
                    txtCustomer_yxm.ReadOnly = true;
                    txtCustomer_tel.ReadOnly = false;
                    txtCustomer_address.ReadOnly = false;
                    txtCustomer_usecode.ReadOnly = false;
                    txtCustomer_age.ReadOnly = false;
                    cbCustomer_sex.Enabled = true;
                   

                    btnInsert.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnCommit.Enabled = true;
                    btnCancel.Enabled = true;

                    break;
                default:
                    txtCustomer_name.ReadOnly = true;
                    txtCustomer_yxm.ReadOnly = true;
                    txtCustomer_tel.ReadOnly = true;
                    txtCustomer_address.ReadOnly = true;
                    txtCustomer_usecode.ReadOnly = true;
                    txtCustomer_age.ReadOnly = true;
                    cbCustomer_sex.Enabled = false;

                    btnInsert.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnCommit.Enabled = false;
                    btnCancel.Enabled = false;

                    break;
            }
        }
        public CustomerPersional()
        {
            InitializeComponent();
        }
        
        //formload
        private void CustomerPersional_Load(object sender, EventArgs e)
        {
            dgv.AutoGenerateColumns = false;
            cbCustomer_sex.SelectedIndex = 0;
            BandingDgv();
            setButtonState();
        }
        //*******************************************************************
        /// <summary>
        /// 绑定画面
        /// </summary>
        /// <history>
        ///     完成信息：李梓楠      2010/11/8 完成   
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
                sp.SetValue(":customer_flag", "1");

                DataTable dt = getData.GetTableBySqlStr(Constants.SqlStr.TC_CUSTOMER_RIGHTJOIN_TC_ARCHIVES, sp);

                dgv.AutoGenerateColumns = false;
                dt.Columns.Add("index", typeof(int));
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["index"] = i + 1;
                }
                dgv.DataSource = dt;

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

        //改变选择行,重新填充text数据
        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            //设定按钮状态
            dataType = DataType.None;
            setButtonState();


            if (dgv != null && dgv.SelectedRows.Count != 0)
            {
                txtCustomer_name.Text = dgv.SelectedRows[0].Cells["Customer_name"].Value.ToString();
                txtCustomer_yxm.Text = dgv.SelectedRows[0].Cells["Customer_yxm"].Value.ToString();
                txtCustomer_tel.Text = dgv.SelectedRows[0].Cells["Customer_tel"].Value.ToString();
                txtCustomer_address.Text = dgv.SelectedRows[0].Cells["Customer_address"].Value.ToString();
                cbCustomer_sex.Text = dgv.SelectedRows[0].Cells["Customer_sex"].Value.ToString();
                txtCustomer_usecode.Text = dgv.SelectedRows[0].Cells["Customer_usecode"].Value.ToString();
                txtCustomer_age.Text = dgv.SelectedRows[0].Cells["Customer_age"].Value.ToString();
            }
        }
        /// <summary>
        /// 添加按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：李梓楠      2010/11/8 完成   
        ///    更新信息：
        /// </history>

        private void btnInsert_Click(object sender, EventArgs e)
        {
            dataType = DataType.Insert;
            setButtonState();
            txtCustomer_usecode.Focus();
        }
        /// <summary>
        /// 修改按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：李梓楠      2010/11/8 完成   
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
            txtCustomer_usecode.Focus();
        }
        //***********************************************************************
        /// <summary>
        /// 保存按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：李梓楠      2010/11/8 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnCommit_Click(object sender, EventArgs e)
        {
           
            //判断客户编号不能为空
            if (txtCustomer_usecode.Text.Trim() == string.Empty)
            {
                MessageBox.Show("客户编号不能为空！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCustomer_usecode.Focus();
                return;
            }

            //判断客户名称不能为空
            if (txtCustomer_name.Text.Trim() == string.Empty)
            {
                MessageBox.Show("客户姓名不能为空！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCustomer_name.Focus();
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
            EntityCustomer entityCustomer = new EntityCustomer();
            EntityArchives entityArchives = new EntityArchives();
            int result1 = -1;
            try
            {
                result = -1;

                //如果是添加
                if (dataType == DataType.Insert)
                {

                    //向客户实体类添加数据
                    entityCustomer.Customer_name = txtCustomer_name.Text;
                    entityCustomer.Customer_yxm = txtCustomer_yxm.Text;
                    entityCustomer.Customer_tel = txtCustomer_tel.Text;
                    entityCustomer.Customer_address = txtCustomer_address.Text;
                    //向档案实体类添加数据
                    entityArchives.Customer_age = txtCustomer_age.Text;
                    entityArchives.Customer_usecode = txtCustomer_usecode.Text;
                    entityArchives.Customer_sex = cbCustomer_sex.Text;
                    
                    //添加标识, "1",固定为个人客户
                    entityCustomer.Customer_flag = "1";
                    

                    dataAccess = new DataAccess();
                    dataAccess.Open();
                    GetData getData = new GetData(dataAccess.Connection);
                    if (getData.InsertIsOnly("tc_archives", "customer_usecode", txtCustomer_usecode.Text.Trim()))
                    {
                        MessageBox.Show("您输入的客户编号已经存在！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCustomer_usecode.Focus();
                        return;
                    }


                    MakePrimaryKey primaryKey = new MakePrimaryKey(dataAccess.Connection, dataAccess.Transaction);
                    string code = primaryKey.MakeCode("客户");
                    entityCustomer.Customer_code = code;
                    entityArchives.Customer_code = code;

                    
                    result = getData.InsertCustomer(entityCustomer);
                    result1 = getData.InsertArchives(entityArchives);
                }
                //如果是更新
                else if (dataType == DataType.Update)
                {
                    //给选中行赋值
                    countNum = dgv.SelectedRows[0].Index;
                    entityCustomer.Customer_code = dgv.SelectedRows[0].Cells["CUSTOMER_code"].Value.ToString();
                    entityCustomer.Customer_name = txtCustomer_name.Text;
                    entityCustomer.Customer_yxm = txtCustomer_yxm.Text;
                    entityCustomer.Customer_tel = txtCustomer_tel.Text;
                    entityCustomer.Customer_address = txtCustomer_address.Text;


                    //添加标识, "1",固定为个人客户
                    entityCustomer.Customer_flag = "1";

                    //向档案实体类添加数据
                    entityArchives.Customer_age = txtCustomer_age.Text;
                    entityArchives.Customer_usecode = txtCustomer_usecode.Text;
                    entityArchives.Customer_sex = cbCustomer_sex.Text;
                    entityArchives.Customer_code = entityCustomer.Customer_code;
                    entityArchives.Archives_id = Convert.ToInt32(dgv.SelectedRows[0].Cells["Archives_id"].Value.ToString());

                    dataAccess = new DataAccess();
                    dataAccess.Open();
                    dataAccess.BeginTransaction();

                    GetData getData = new GetData(dataAccess.Connection, dataAccess.Transaction);
                    //判断客户编号重复
                    if (getData.UpdateIsOnly("tc_archives", "Archives_id", entityArchives.Archives_id.ToString(), "customer_usecode", txtCustomer_usecode.Text.Trim()))
                    {
                        MessageBox.Show("您输入的客户编号已经存在！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCustomer_usecode.Focus();
                        return;
                    }
                    //取得结果符
                    result = getData.UpdateCustomer(entityCustomer);
                    result1 = getData.UpdateArchives(entityArchives);
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
            if (result == 0 && result1 == 0)
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
        ///    完成信息：李梓楠      2010/11/8 完成   
        ///    更新信息：
        /// </history>

        private void btnDelete_Click(object sender, EventArgs e)
        {


            result = -1;
            countNum = 0;
            if (dgv.SelectedRows.Count > 1)
            {
                MessageBox.Show("只能选择一条要删除的记录！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dgv.SelectedRows.Count < 1)
            {
                MessageBox.Show("请选择一条要删除的记录！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SearchParameter sp = new SearchParameter();
            dataAccess = new DataAccess();
            sp.SetValue(":customer_code", dgv.SelectedRows[0].Cells["CUSTOMER_CODE"].Value.ToString());
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

            if (MessageBox.Show("您确定要删除该数据吗？", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    sp.Clear();
                    sp.SetValue(":CUSTOMER_CODE", dgv.SelectedRows[0].Cells["CUSTOMER_CODE"].Value.ToString());

                    dataAccess.Open();
                    dataAccess.BeginTransaction();
                    GetData getData = new GetData(dataAccess.Connection, dataAccess.Transaction);

                    result = getData.DeleteRow("TC_CUSTOMER", sp);
                    result = getData.DeleteRow("TC_Archives", sp);

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
        //***********************************************************************
        /// <summary>
        /// 取消按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：李梓楠      2010/11/8 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dataType = DataType.None;
            setButtonState();
            if (dgv != null && dgv.SelectedRows.Count != 0)
            {
                txtCustomer_name.Text = dgv.SelectedRows[0].Cells["CUSTOMER_NAME"].Value.ToString();
                txtCustomer_yxm.Text = dgv.SelectedRows[0].Cells["CUSTOMER_YXM"].Value.ToString();
                txtCustomer_address.Text = dgv.SelectedRows[0].Cells["CUSTOMER_ADDRESS"].Value.ToString();
                txtCustomer_tel.Text = dgv.SelectedRows[0].Cells["CUSTOMER_TEL"].Value.ToString();

                txtCustomer_age.Text = dgv.SelectedRows[0].Cells["Customer_age"].Value.ToString();
                txtCustomer_usecode.Text = dgv.SelectedRows[0].Cells["Customer_usecode"].Value.ToString();
                cbCustomer_sex.Text = dgv.SelectedRows[0].Cells["Customer_sex"].Value.ToString();

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
        ///    完成信息：李梓楠      2010/11/8 完成   
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
                if (txtCustomer_codeSelect.Text.Trim() != string.Empty)
                {
                    sp.SetValue(":CUSTOMER_usecode", txtCustomer_codeSelect.Text);

                }

                sp.SetValue(":customer_flag", "1");

                dataAccess = new DataAccess();
                dataAccess.Open();

                GetData getData = new GetData(dataAccess.Connection);

                DataTable dt = getData.GetTableBySqlStr(Constants.SqlStr.TC_CUSTOMER_RIGHTJOIN_TC_ARCHIVES, sp);
                

                if (dt == null)
                {
                    MessageBox.Show("请查看数据库是否正常！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                dt.Columns.Add("index", typeof(int));

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["index"] = i + 1;
                }

                dgv.DataSource = dt;

                if (dt.Rows.Count == 0)
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
        //重置按钮
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomer_codeSelect.Text = "";
            txtCustomer_nameSelect.Text = "";
            txtCustomer_yxmSelect.Text = "";
        }
        //客户名称改变事件
        private void txtCustomer_name_TextChanged(object sender, EventArgs e)
        {
            txtCustomer_yxm.Text = Util.IndexCode(txtCustomer_name.Text);
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
