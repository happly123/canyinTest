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
using System.Text.RegularExpressions;

namespace InvoicingApp
{
    public partial class EmpArchivesForm : Form
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
        int result2 = -1;
        /// <summary>
        /// 选择记录的行号
        /// </summary>
        int countNum = 0;

        /// <summary>
        /// 货位实体类
        /// </summary>
        EntityStaff staffEntity = null;

        public EmpArchivesForm()
        {
            InitializeComponent();
            this.dgvStaff.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(239, 243, 251);
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
        ///     完成信息：赵毅男      2010/07/15 完成   
        ///     更新信息：
        /// </history>
        //*******************************************************************
        private void setButtonState()
        {
            switch (dataType)
            {
                case DataType.None:
                    txtStaffCode.ReadOnly = true;
                    txtStaffName.ReadOnly = true;
                    txtStaffCard.ReadOnly = true;
                    txtTel.ReadOnly = true;
                    txtStaffIntroduction.ReadOnly = true;
                    comBoxSex.Enabled = false;
                    dateTimeBrithday.Enabled = false;
                    comBoxStaffEdu.Enabled = false;
                    txt_staff_dep.ReadOnly = true;
                    txt_staff_job_title.ReadOnly = true;
                    txt_staff_contract_num.ReadOnly = true;
                    txt_staff_specialities.ReadOnly = true;

                    btnInsert.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnCommit.Enabled = false;
                    btnCancel.Enabled = false;


                    break;
                case DataType.Insert:
                    txtStaffCode.ReadOnly = false;
                    txtStaffName.ReadOnly = false;
                    txtStaffCard.ReadOnly = false;
                    txtStaffIntroduction.ReadOnly = false;
                    txtTel.ReadOnly = false;
                    comBoxSex.Enabled = true;
                    dateTimeBrithday.Enabled = true;
                    comBoxStaffEdu.Enabled = true;
                    txt_staff_dep.ReadOnly = false;
                    txt_staff_job_title.ReadOnly = false;
                    txt_staff_contract_num.ReadOnly = false;
                    txt_staff_specialities.ReadOnly = false;

                    txtStaffCode.Text = "";
                    txtStaffName.Text = "";
                    txtStaffCard.Text = "";
                    txtStaffIntroduction.Text = "";
                    txtTel.Text = "";
                    txtYXM.Text = "";
                    comBoxSex.SelectedIndex = 0;
                    dateTimeBrithday.Value = DateTime.Now;
                    comBoxStaffEdu.SelectedIndex = 0;
                    txt_staff_contract_num.Text = "";
                    txt_staff_dep.Text = "";
                    txt_staff_job_title.Text = "";
                    txt_staff_specialities.Text = "";

                    btnInsert.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnCommit.Enabled = true;
                    btnCancel.Enabled = true;
                    txt_staff_contract_num.Focus();
                    break;
                case DataType.Update:
                    txtStaffCode.ReadOnly = false;
                    txtStaffName.ReadOnly = false;
                    txtStaffCard.ReadOnly = false;
                    txtStaffIntroduction.ReadOnly = false;
                    comBoxSex.Enabled = true;
                    dateTimeBrithday.Enabled = true;
                    comBoxStaffEdu.Enabled = true;
                    txtTel.ReadOnly = false;
                    txt_staff_specialities.ReadOnly = false;
                    txt_staff_job_title.ReadOnly = false;
                    txt_staff_dep.ReadOnly = false;
                    txt_staff_dep.ReadOnly = false;

                    btnInsert.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnCommit.Enabled = true;
                    btnCancel.Enabled = true;
                    txtStaffName.Focus();
                    break;
                default:
                    txtStaffCode.ReadOnly = true;
                    txtStaffName.ReadOnly = true;
                    txtStaffCard.ReadOnly = true;
                    txtStaffIntroduction.ReadOnly = true;
                    comBoxSex.Enabled = false;
                    dateTimeBrithday.Enabled = false;
                    comBoxStaffEdu.Enabled = false;
                    txtTel.ReadOnly = true;
                    txt_staff_dep.ReadOnly = true;
                    txt_staff_job_title.ReadOnly = true;
                    txt_staff_contract_num.ReadOnly = true;
                    txt_staff_specialities.ReadOnly = true;

                    btnInsert.Enabled = true;
                    btnUpdate.Enabled = true;
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
        ///     完成信息：赵毅男      2010/07/15 完成   
        ///     更新信息：
        /// </history>
        //*******************************************************************
        private void BandingDgvStaff()
        {
            try
            {
                //打开数据库连接
                dataAccess = new DataAccess();
                dataAccess.Open();

                //取得操作类
                GetData getData = new GetData(dataAccess.Connection);

                DataTable dt = getData.GetSingleTable("TC_STAFF");

                if (dt == null)
                {
                    MessageBox.Show("数据库连接出错，请查看数据库是否开启！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //添加序列号
                int countNumber = 0;
                dt.Columns.Add("index", typeof(int));
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["index"] = ++countNumber;

                }

                dgvStaff.DataSource = dt;

                if (dgvStaff != null && dgvStaff.Rows.Count > 0 && countNum != 0)
                {
                    dgvStaff.Rows[0].Selected = false;
                    dgvStaff.Rows[countNum].Selected = true;
                    dgvStaff.FirstDisplayedScrollingRowIndex = countNum;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("操作数据时发生错误，请检查数据库是否正常开启！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        ///    完成信息：赵毅男      2010/07/15 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void EmpArchivesForm_Load(object sender, EventArgs e)
        {
            dataType = DataType.None;
            setButtonState();
            if (LoginUser.UserAuthority == "2")
            {
                btnInsert.Visible = false;
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
                btnCommit.Visible = false;
                btnCancel.Visible = false;
            }
            dgvStaff.AutoGenerateColumns = false;

            BandingDgvStaff();

            txtStaffNameSelect.Focus();

        }

        //***********************************************************************
        /// <summary>
        /// 选择画面数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：赵毅男      2010/07/15 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void dgvStaff_SelectionChanged(object sender, EventArgs e)
        {

            //设定按钮状态
            dataType = DataType.None;
            setButtonState();

            //判断画面数据不为空
            if (dgvStaff != null && dgvStaff.SelectedRows.Count != 0)
            {

                //取得数据赋值文本框
                txtStaffCode.Text = dgvStaff.SelectedRows[0].Cells["staff_code"].Value.ToString();
                txtStaffName.Text = dgvStaff.SelectedRows[0].Cells["staff_name"].Value.ToString();
                txtStaffCard.Text = dgvStaff.SelectedRows[0].Cells["staff_card"].Value.ToString();
                txtTel.Text = dgvStaff.SelectedRows[0].Cells["staff_tel"].Value.ToString();
                txtStaffIntroduction.Text = dgvStaff.SelectedRows[0].Cells["staff_introduction"].Value.ToString();
                dateTimeBrithday.Value = DateTime.Parse(dgvStaff.SelectedRows[0].Cells["staff_birthday"].Value.ToString());
                comBoxSex.Text = dgvStaff.SelectedRows[0].Cells["staff_sex"].Value.ToString();
                comBoxStaffEdu.Text = dgvStaff.SelectedRows[0].Cells["staff_edu"].Value.ToString();
                txt_staff_dep.Text = dgvStaff.SelectedRows[0].Cells["staff_dep"].Value.ToString();
                txt_staff_job_title.Text = dgvStaff.SelectedRows[0].Cells["staff_job_title"].Value.ToString();
                txt_staff_specialities.Text = dgvStaff.SelectedRows[0].Cells["staff_specialities"].Value.ToString();
                txt_staff_contract_num.Text = dgvStaff.SelectedRows[0].Cells["staff_contract_num"].Value.ToString();
            }
        }

        //***********************************************************************
        /// <summary>
        /// 文本框姓名变化时，音序码变化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：赵毅男      2010/07/15 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void txtStaffName_TextChanged(object sender, EventArgs e)
        {
            if (!txtStaffName.Text.Equals(string.Empty))
            {
                txtYXM.Text = Util.IndexCode(txtStaffName.Text).ToUpper();
            }
            else
            {
                txtYXM.Text = "";
            }
        }

        //***********************************************************************
        /// <summary>
        /// 选择画面数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：赵毅男      2010/07/15 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnSelect_Click(object sender, EventArgs e)
        {

            try
            {
                //初始化参数类
                SearchParameter sp = new SearchParameter();

                //条件不为空，添加参数
                if (txtStaffNameSelect.Text.Trim() != string.Empty)
                {
                    sp.SetValue(":STAFF_NAME", txtStaffNameSelect.Text.Trim());
                }


                if (txtStaffYXMSelect.Text.Trim() != string.Empty)
                {
                    sp.SetValue(":STAFF_YXM", txtStaffYXMSelect.Text.Trim());

                }

                if (txtStaffCradSelect.Text.Trim() != string.Empty)
                {
                    sp.SetValue(":STAFF_CARD", txtStaffCradSelect.Text.ToUpper());
                }

                //if (txtStaffNameSelect.Text != string.Empty)
                //{
                //    sp.SetValue(":staff_name", txtStaffNameSelect.Text);
                //}

                //打开数据库连接
                dataAccess = new DataAccess();
                dataAccess.Open();

                //取得操作类
                GetData getData = new GetData(dataAccess.Connection);

                //取得单表数据


                DataTable dt = getData.GetSingleTableByCondition("TC_STAFF", sp);

                if (dt == null)
                {
                    MessageBox.Show("数据库连接出错，请查看数据库是否开启！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //添加序列号
                int countNumber = 0;
                dt.Columns.Add("index", typeof(int));
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["index"] = ++countNumber;

                }

                //绑定画面
                dgvStaff.DataSource = dt;

                //没有数据
                if (dt.Rows.Count == 0)
                {

                    //给出提示
                    MessageBox.Show("数据不存在，请查看输入的条件是否正确！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //取得数据赋值文本框
                    txtStaffCode.Text = "";
                    txtStaffName.Text = "";
                    txtStaffCard.Text = "";
                    txtTel.Text = "";
                    txtStaffIntroduction.Text = "";
                    dateTimeBrithday.Value = System.DateTime.Now.Date;
                    comBoxSex.SelectedIndex = 0;
                    comBoxStaffEdu.SelectedIndex = 0;
                    txt_staff_dep.Text = "";
                    txt_staff_job_title.Text = "";
                    txt_staff_specialities.Text = "";
                    txt_staff_contract_num.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("操作数据时发生错误，请检查数据库是否正常开启！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {

                //关闭数据库连接
                dataAccess.Close();
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStaffNameSelect.Text = "";
            txtStaffYXMSelect.Text = "";
            txtStaffCradSelect.Text = "";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            dataType = DataType.Insert;
            setButtonState();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //如果选择多条数据，提示
            if (dgvStaff.SelectedRows.Count > 1)
            {
                MessageBox.Show("只能选择一条要修改的记录！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //如过画面中不存在数据，提示
            if (dgvStaff.SelectedRows.Count < 1)
            {
                MessageBox.Show("请选择一条要修改的记录！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dataType = DataType.Update;
            setButtonState();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dataType = DataType.None;
            setButtonState();

            //判断画面数据不为空
            if (dgvStaff != null && dgvStaff.SelectedRows.Count != 0)
            {

                //取得画面数据赋值文本框
                txtStaffCode.Text = dgvStaff.SelectedRows[0].Cells["staff_code"].Value.ToString();
                txtStaffName.Text = dgvStaff.SelectedRows[0].Cells["staff_name"].Value.ToString();
                txtStaffCard.Text = dgvStaff.SelectedRows[0].Cells["staff_card"].Value.ToString();
                txtTel.Text = dgvStaff.SelectedRows[0].Cells["staff_tel"].Value.ToString();
                txtStaffIntroduction.Text = dgvStaff.SelectedRows[0].Cells["staff_introduction"].Value.ToString();
                dateTimeBrithday.Value = DateTime.Parse(dgvStaff.SelectedRows[0].Cells["staff_birthday"].Value.ToString());
                comBoxSex.Text = dgvStaff.SelectedRows[0].Cells["staff_sex"].Value.ToString();
                comBoxStaffEdu.Text = dgvStaff.SelectedRows[0].Cells["staff_edu"].Value.ToString();
                txt_staff_contract_num.Text = dgvStaff.SelectedRows[0].Cells["staff_contract_num"].Value.ToString();
                txt_staff_dep.Text = dgvStaff.SelectedRows[0].Cells["staff_dep"].Value.ToString();
                txt_staff_job_title.Text = dgvStaff.SelectedRows[0].Cells["staff_job_title"].Value.ToString();
                txt_staff_specialities.Text = dgvStaff.SelectedRows[0].Cells["staff_specialities"].Value.ToString();
            }
            else
            {
                txtStaffCode.Text = "";
                txtStaffName.Text = "";
                txtStaffCard.Text = "";
                txtTel.Text = "";
                txtStaffIntroduction.Text = "";
                dateTimeBrithday.Value = DateTime.Now;
                comBoxSex.SelectedIndex = 0;
                comBoxStaffEdu.SelectedIndex = 0;
                txt_staff_specialities.Text = "";
                txt_staff_job_title.Text = "";
                txt_staff_dep.Text = "";
                txt_staff_contract_num.Text = "";
            }
            dgvStaff.Focus();
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {

            foreach (Control control in groupBox2.Controls)
            {
                if (control is TextBox)
                {
                    if (control.Name != "txtStaffIntroduction")
                    {
                        if (Util.CheckRegex(control.Text.Trim()) && !((TextBox)control).ReadOnly)
                        {
                            MessageBox.Show("不可以输入非法字符，请重新输入！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            control.Focus();
                            return;
                        }
                    }
                }
            }

            if (txt_staff_contract_num.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("合同编号不能为空！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_staff_contract_num.Focus();
                return;
            }

            if (txtStaffName.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("员工姓名不能为空！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtStaffName.Focus();
                return;
            }

            //if (Util.GetByteLength(txtStaffName.Text.Trim()) > 10)
            //{
            //    MessageBox.Show("员工姓名过长！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txtStaffName.Focus();
            //    return;
            //}

            if (txtStaffCard.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("身份证号不能为空！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtStaffCard.Focus();
                return;
            }

            if (!Util.CheckIdCard(txtStaffCard.Text.Trim()))
            {
                MessageBox.Show("身份证格式不正确！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtStaffCard.Focus();
                return;
            }



            try
            {
                result = -1;

                //如果是添加
                if (dataType == DataType.Insert)
                {
                    staffEntity = new EntityStaff();
                    staffEntity.Staff_name = txtStaffName.Text.Trim();
                    staffEntity.Staff_yxm = Util.IndexCode(txtStaffName.Text.Trim()).ToUpper();
                    staffEntity.Staff_sex = comBoxSex.Text;
                    staffEntity.Staff_birthday = DateTime.Parse(dateTimeBrithday.Value.ToString("yyyy-MM-dd"));
                    staffEntity.Staff_card = txtStaffCard.Text.Trim();
                    staffEntity.Staff_edu = comBoxStaffEdu.Text;
                    staffEntity.Staff_tel = txtTel.Text.Trim();
                    staffEntity.Staff_introduction = txtStaffIntroduction.Text;
                    staffEntity.Staff_dep = txt_staff_dep.Text;
                    staffEntity.Staff_contract_num = txt_staff_contract_num.Text;
                    staffEntity.Staff_specialities = txt_staff_specialities.Text;
                    staffEntity.Staff_job_title = txt_staff_job_title.Text;

                    //打开数据库连接
                    dataAccess = new DataAccess();
                    dataAccess.Open();


                    MakePrimaryKey primaryKey = new MakePrimaryKey(dataAccess.Connection, dataAccess.Transaction);
                    staffEntity.Staff_code = primaryKey.MakeCode("员工");

                    //取得操作类
                    GetData getData = new GetData(dataAccess.Connection);

                    if (getData.InsertIsOnly("tc_staff", "staff_contract_num", Util.ChangeForSqlString(txt_staff_contract_num.Text.Trim())))
                    {
                        MessageBox.Show("您输入的合同编号已经存在！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_staff_contract_num.Focus();
                        return;
                    }

                    if (getData.InsertIsOnly("tc_staff", "staff_card", Util.ChangeForSqlString(txtStaffCard.Text.Trim())))
                    {
                        MessageBox.Show("您输入的身份证号已经存在！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtStaffCard.Focus();
                        return;
                    }

                    //取得结果符
                    result = getData.InsertStaffRow(staffEntity);

                    if (result == 0)
                    {
                        MessageBox.Show("数据已经保存成功！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("操作添加时发生错误，请检查数据库！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else if (dataType == DataType.Update)
                {
                    if (dgvStaff.SelectedRows != null && dgvStaff.SelectedRows.Count != 0)
                    {
                        countNum = dgvStaff.SelectedRows[0].Index;
                    }

                    //赋值实体类
                    staffEntity = new EntityStaff();
                    staffEntity.Staff_code = txtStaffCode.Text.Trim();
                    staffEntity.Staff_name = txtStaffName.Text.Trim();
                    staffEntity.Staff_yxm = Util.IndexCode(txtStaffName.Text.Trim()).ToUpper();
                    staffEntity.Staff_sex = comBoxSex.Text;
                    staffEntity.Staff_birthday = DateTime.Parse(dateTimeBrithday.Value.ToString("yyyy-MM-dd"));
                    staffEntity.Staff_card = txtStaffCard.Text.Trim();
                    staffEntity.Staff_edu = comBoxStaffEdu.Text;
                    staffEntity.Staff_tel = txtTel.Text.Trim();
                    staffEntity.Staff_introduction = txtStaffIntroduction.Text;
                    staffEntity.Staff_job_title = txt_staff_job_title.Text;
                    staffEntity.Staff_dep = txt_staff_dep.Text;
                    staffEntity.Staff_contract_num = txt_staff_contract_num.Text;
                    staffEntity.Staff_specialities = txt_staff_specialities.Text;

                    //打开数据库连接
                    dataAccess = new DataAccess();
                    dataAccess.Open();

                    //打开事务
                    dataAccess.BeginTransaction();

                    //取得操作类
                    GetData getData = new GetData(dataAccess.Connection, dataAccess.Transaction);

                    if (getData.UpdateIsOnly("tc_staff", "Staff_code", staffEntity.Staff_code, "staff_contract_num", Util.ChangeForSqlString(txt_staff_contract_num.Text.Trim())))
                    {
                        MessageBox.Show("您输入的合同编号已经存在！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_staff_contract_num.Focus();
                        return;
                    }

                    if (getData.UpdateIsOnly("tc_staff", "Staff_code", staffEntity.Staff_code, "staff_card", Util.ChangeForSqlString(txtStaffCard.Text.Trim())))
                    {
                        MessageBox.Show("您输入的身份证号已经存在！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtStaffCard.Focus();
                        return;
                    }

                    //取得结果符
                    result = getData.UpdateStaffTable(staffEntity);

                    //提交事务
                    dataAccess.Commit();

                    if (result == 0)
                    {
                        MessageBox.Show("数据已经保存成功！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("操作修改时发生错误，请检查数据库！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                if (dataAccess.Transaction != null)
                {

                    //回滚
                    dataAccess.Rollback();
                }

                MessageBox.Show("操作数据时发生错误，请检查数据库是否正常开启！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                dataAccess.Close();
            }

            //设置按钮状态
            dataType = DataType.None;
            setButtonState();
            BandingDgvStaff();




        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //设置按钮状态
            dataType = DataType.None;
            setButtonState();

            //结果符
            result = -1;
            result2 = -1;
            countNum = 0;

            //如果选择多条数据删除，提示
            if (dgvStaff.SelectedRows.Count > 1)
            {
                MessageBox.Show("只能选择一条要删除的记录！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //如过画面中不存在数据，提示
            if (dgvStaff.SelectedRows.Count < 1)
            {
                MessageBox.Show("请选择一条要删除的记录！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //弹出提示，确认删除
            if (MessageBox.Show("您确定要删除该数据吗？", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {

                    //初始化参数类
                    SearchParameter sp = new SearchParameter();

                    //设置主键
                    sp.SetValue(":STAFF_CODE", dgvStaff.SelectedRows[0].Cells["staff_code"].Value.ToString());

                    //打开数据库
                    dataAccess = new DataAccess();
                    dataAccess.Open();

                    //打开事务
                    dataAccess.BeginTransaction();

                    //取得操作类
                    GetData getData = new GetData(dataAccess.Connection, dataAccess.Transaction);

                    //取得结果符
                    result = getData.DeleteRow("TC_STAFF", sp);
                    result2 = getData.DeleteRow("tc_authority", sp);
                    //提交事务
                    dataAccess.Commit();

                    //判断结果符，0：成功；-1：失败
                    if (result == 0 && result2 == 0)
                    {

                        MessageBox.Show("数据已经被成功删除！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("数据删除时发生错误，请检查数据库！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {

                    //回滚
                    dataAccess.Rollback();
                    MessageBox.Show("操作数据时发生错误，请检查数据库是否正常开启！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                finally
                {
                    //关闭数据库连接
                    dataAccess.Close();

                }

                //加载画面
                BandingDgvStaff();

            }
        }

        private void dgvStaff_Sorted(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvStaff.Rows.Count; i++)
            {
                dgvStaff.Rows[i].Cells["index"].Value = i + 1;
            }
        }


    }
}
