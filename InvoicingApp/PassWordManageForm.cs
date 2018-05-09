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
using System.Runtime.InteropServices;

namespace InvoicingApp
{
    public partial class PassWordManageForm : Form
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
        /// 子窗体传递来的员工编号
        /// </summary>
        string staffCode = string.Empty;

        public PassWordManageForm()
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

                    txtStaff_name.ReadOnly = true;
                    txtAuthority_user_code.ReadOnly = true;

                    txtStaff_name.BackColor = Color.FromArgb(236, 233, 216);
                    

                    btnInsert.Enabled = true;
                    btnCommit.Enabled = false;
                    btnDelete.Enabled = true;
                    btnCancel.Enabled = false;

                    break;
                case DataType.Insert:
                    txtStaff_name.ReadOnly = true;
                    txtAuthority_user_code.ReadOnly = false;

                    txtStaff_name.BackColor = Color.FromArgb(255, 255, 255);


                    txtStaff_name.Text = "双击选择员工...";
                    txtAuthority_user_code.Text = "";
                    

                    btnInsert.Enabled = false;
                    btnCommit.Enabled = true;
                    btnDelete.Enabled = false;
                    btnCancel.Enabled = true;

                    break;
                
                default:
                    txtStaff_name.ReadOnly = true;
                    txtAuthority_user_code.ReadOnly = true;

                    txtStaff_name.BackColor = Color.FromArgb(255, 255, 255);

                    btnInsert.Enabled = true;
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
        ///    完成信息：李梓楠      2010/7/15 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void PassWordManageForm_Load(object sender, EventArgs e)
        {
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
                sp.SetValue(":authority_level","2");
                DataTable dtCounter = getData.GetTableBySqlStr(Constants.SqlStr.tc_AUTHORITY_LEFTJOIN_STAFF, sp); ;

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
                if (LoginUser.UserAuthority == "0") 
                {
                    btnRepassword.Text = "初始化管理员密码";
                    btnUpdate.Text = "修改药监局密码";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据查询时发生错误，请检查数据库！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                txtStaff_name.Text = dgv.SelectedRows[0].Cells["staff_name"].Value.ToString();
                txtAuthority_user_code.Text = dgv.SelectedRows[0].Cells["Authority_user_code"].Value.ToString();
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
            if (dataType == DataType.Insert || dataType == DataType.Update)
            {
                StaffForm child = new StaffForm();
                child.ShowDialog();
                if (child.staffName != string.Empty)
                {
                    txtStaff_name.Text = child.staffName;
                    staffCode = child.staffCode;
                }

            }

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

            //判断有效日期不能为空
            if (txtStaff_name.Text.Trim() == string.Empty || txtStaff_name.Text == "双击选择员工...")
            {
                MessageBox.Show("用户姓名不能为空！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtStaff_name.Focus();
                return;
            }
            //判断产品名称不能为空
            if (txtAuthority_user_code.Text.Trim() == string.Empty)
            {
                MessageBox.Show("登录账号不能为空！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAuthority_user_code.Focus();
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
            EntityAuthority entity = new EntityAuthority();
            try
            {
                result = -1;

                //如果是添加
                if (dataType == DataType.Insert)
                {


                    entity.Authority_level = "2";
                    entity.Authority_user_code = txtAuthority_user_code.Text;
                    entity.Staff_code = staffCode;

                    //加密狗
                    entity.Authority_password =Util.GetHashCode("000000");

                    dataAccess = new DataAccess();
                    dataAccess.Open();

                    SearchParameter sp = new SearchParameter();
                    sp.SetValue(":Authority_user_code", txtAuthority_user_code.Text);

                    GetData getData = new GetData(dataAccess.Connection);
                    DataTable dt = getData.GetSingleTableByConditionUnLike("tc_Authority", sp);

                    dataAccess.Open();
                    sp.Clear();
                    sp.SetValue(":staff_code", staffCode);
                    getData = new GetData(dataAccess.Connection);
                    DataTable dt2 = getData.GetSingleTableByConditionUnLike("tc_Authority", sp);
                    if (dt != null && dt.Rows.Count != 0 && dt2 != null && dt2.Rows.Count != 0)
                    {
                        MessageBox.Show("该用户已经存在自己的登录账号！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtStaff_name.Focus();
                        return;
                    }
                    if (dt != null  && dt.Rows.Count != 0 )
                    {
                        MessageBox.Show("登录账号已存在！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtAuthority_user_code.Focus();
                        return;
                    }

                    else if (dt2 != null && dt2.Rows.Count != 0) 
                    {
                        MessageBox.Show("该用户已经存在自己的登录账号！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtStaff_name.Focus();
                        return;
                    }
                    else
                    {
                        dataAccess.Open();
                        result = getData.InsertAuthorityTable(entity);
                    
                    }
                }
                
            }
            catch (COMException comex)
            {
                MessageBox.Show("加密狗未找到，请插入加密狗！", "长白ERP系统", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
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
                if (dataAccess.Connection != null)
                {
                    dataAccess.Close();
                }
                
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

            if (MessageBox.Show("您确定要删除该数据吗？", Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    SearchParameter sp = new SearchParameter();
                    sp.SetValue(":authority_user_code", dgv.SelectedRows[0].Cells["authority_user_code"].Value.ToString());

                    dataAccess = new DataAccess();
                    dataAccess.Open();
                    dataAccess.BeginTransaction();
                    GetData getData = new GetData(dataAccess.Connection, dataAccess.Transaction);

                    result = getData.DeleteRow("tc_authority", sp);

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
                txtStaff_name.Text = dgv.SelectedRows[0].Cells["staff_name"].Value.ToString();
                txtAuthority_user_code.Text = dgv.SelectedRows[0].Cells["Authority_user_code"].Value.ToString();
            }
            dgv.Focus();
        }

        private void txtStaff_name_DoubleClick(object sender, EventArgs e)
        {
            if (dataType == DataType.Insert || dataType == DataType.Update)
            {
                StaffForm child = new StaffForm();
                child.ShowDialog();
                if (child.staffName != string.Empty)
                {
                    txtStaff_name.Text = child.staffName;
                    staffCode = child.staffCode;
                }
                  
            }
            else return;
        }

        private void btnRepassword_Click(object sender, EventArgs e)
        {
            if (LoginUser.UserAuthority == "0")
            {
                EntityAuthority entity = new EntityAuthority();
                entity.Authority_level = "1";
                entity.Authority_user_code = "admin";
                try
                {
                    entity.Authority_password = Util.GetHashCode("123456");
                    entity.Staff_code = "管理员";
                    entity.Id = 2;
                    dataAccess = new DataAccess();
                    dataAccess.Open();
                    dataAccess.BeginTransaction();
                    GetData getData = new GetData(dataAccess.Connection, dataAccess.Transaction);

                    result = getData.UpdateAuthorityTable(entity);

                    dataAccess.Commit();
                }
                catch (COMException comex)
                {
                    MessageBox.Show("加密狗未找到，请插入加密狗！", "长白ERP系统", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                catch (Exception ex)
                {
                    dataAccess.Rollback();
                    MessageBox.Show(ex.Message);
                    throw ex;
                }
                finally
                {
                    if (dataAccess == null)
                    {
                        dataAccess.Close();
                    }
                }
                if (result == 0)
                {
                    MessageBox.Show("管理员密码已初始化成功！新密码为 \"123456\"！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BandingDgv();

                }
                else
                {
                    MessageBox.Show("数据删除时发生错误，请检查数据库！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (dgv.SelectedRows.Count > 1 || dgv.SelectedRows.Count < 1)
                {
                    MessageBox.Show("只能选择一位用户进行初始化！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (MessageBox.Show("您确定要初始化该用户密码吗？", Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    EntityAuthority entity = new EntityAuthority();
                    entity.Authority_level = "2";
                    entity.Authority_user_code = dgv.SelectedRows[0].Cells["Authority_user_code"].Value.ToString();
                    entity.Staff_code = dgv.SelectedRows[0].Cells["Staff_code"].Value.ToString();
                    entity.Id = Int32.Parse(dgv.SelectedRows[0].Cells["Authority_id"].Value.ToString());
                    try
                    {
                        //加密狗
                        entity.Authority_password = Util.GetHashCode("000000");
                        dataAccess = new DataAccess();
                        dataAccess.Open();
                        dataAccess.BeginTransaction();
                        GetData getData = new GetData(dataAccess.Connection, dataAccess.Transaction);

                        result = getData.UpdateAuthorityTable(entity);

                        dataAccess.Commit();
                    }
                    catch (COMException comex)
                    {
                        MessageBox.Show("加密狗未找到，请插入加密狗！", "长白ERP系统", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    catch (Exception ex)
                    {
                        dataAccess.Rollback();
                        MessageBox.Show(ex.Message);
                        throw ex;
                    }
                    finally
                    {
                        if(dataAccess.Connection!=null)
                        dataAccess.Close();
                    }
                    if (result == 0)
                    {
                        MessageBox.Show("用户密码已初始化成功！新密码为 \"000000\"！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BandingDgv();

                    }
                    else
                    {
                        MessageBox.Show("数据删除时发生错误，请检查数据库！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            passWordChangeForm pass = new passWordChangeForm();
            pass.ShowDialog();
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
