//***********************************************************************
//* 系统名称	    ：  长白ERP系统
//* 功能模块	    ：  系统信息
//* 功能画面		：  货位管理
//* 画面名称	    ：  CargospaceManageForm
//* 完成年月日      ：  2010/07/13
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
using DataAccesses;
using InvoicingUtil;

namespace InvoicingApp
{
    //***********************************************************************
    /// <summary>
    ///货位管理功能
    /// </summary>
    /// <history>
    ///     完成信息：赵毅男      2010/07/13 完成  
    ///     更新信息：
    /// </history>
    //***********************************************************************
    public partial class CargospaceManageForm : Form
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
        /// 货位实体类
        /// </summary>
        EntityCounter counterEntity = null;

        public CargospaceManageForm()
        {

            InitializeComponent();
            this.dgvCounter.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(239, 243, 251);
        }

        //*******************************************************************
        /// <summary>
        /// 取得格式化数据源
        /// </summary>
        /// <param name="dt">数据源表</param>
        /// <returns>格式化完成的表</returns>
        /// <history>
        ///     完成信息：赵毅男      2010/07/13 完成   
        ///     更新信息：
        /// </history>
        //*******************************************************************
        private DataTable GetCounterTable(DataTable dt)
        {
            dt = new DataTable();

            dt.Columns.Add("counter_code", typeof(string));
            dt.Columns.Add("counter_manager", typeof(string));
            dt.Columns.Add("counter_type", typeof(string));

            return dt;
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
        ///     完成信息：赵毅男      2010/07/13 完成   
        ///     更新信息：
        /// </history>
        //*******************************************************************
        private void setButtonState()
        {
            switch (dataType)
            {
                case DataType.None:
                    txtCode.ReadOnly = true;
                    txtManager.ReadOnly = true;
                    txtType.ReadOnly = true;
                    txtManager.BackColor = Color.FromArgb(236, 233, 216);
                    btnInsert.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnCommit.Enabled = false;
                    btnCancel.Enabled = false;

                    break;
                case DataType.Insert:
                    txtCode.Focus();
                    txtCode.ReadOnly = false;

                    txtType.ReadOnly = false;

                    //添加时，同时清空文本框
                    txtCode.Text = "";
                    txtManager.Text = "双击选择负责人...";
                    txtType.Text = "";
                    txtManager.BackColor = Color.FromArgb(255, 255, 255);
                    btnDelete.Enabled = false;
                    btnInsert.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnCommit.Enabled = true;
                    btnCancel.Enabled = true;
                    break;
                case DataType.Update:
                    txtCode.Focus();
                    txtCode.ReadOnly = true;
                    //txtManager.Text = "双击选择负责人...";
                    txtType.ReadOnly = false;
                    txtManager.BackColor = Color.FromArgb(255, 255, 255);
                    btnDelete.Enabled = false;
                    btnInsert.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnCommit.Enabled = true;
                    btnCancel.Enabled = true;
                    break;
                default:
                    txtCode.ReadOnly = true;
                    //txtManager.ReadOnly = true;
                    txtType.ReadOnly = true;
                    txtManager.BackColor = Color.FromArgb(236, 233, 216);
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
        ///     完成信息：赵毅男      2010/07/13 完成   
        ///     更新信息：
        /// </history>
        //*******************************************************************
        private void BandingDgvCounter()
        {
            try
            {

                //打开数据库连接
                dataAccess = new DataAccess();
                dataAccess.Open();

                //取得操作类
                GetData getData = new GetData(dataAccess.Connection);

                //取得单表数据
                DataTable dtCounter = getData.GetSingleTable("tc_counter");

                dtCounter.Columns.Add("index", typeof(int));
                for (int i = 0; i < dtCounter.Rows.Count; i++)
                {
                    dtCounter.Rows[i]["index"] = i + 1;
                }

                //绑定画面
                dgvCounter.DataSource = dtCounter;

                if (dgvCounter != null && dgvCounter.Rows.Count > 0 && countNum != 0)
                {
                    dgvCounter.Rows[0].Selected = false;
                    dgvCounter.Rows[countNum].Selected = true;
                    dgvCounter.FirstDisplayedScrollingRowIndex = countNum;
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

        //***********************************************************************
        /// <summary>
        /// 画面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：赵毅男      2010/07/13 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void CargospaceManageForm_Load(object sender, EventArgs e)
        {
            //绑定画面
            BandingDgvCounter();

            //设定按钮状态
            dataType = DataType.None;
            setButtonState();
        }

        //***********************************************************************
        /// <summary>
        /// 选择画面数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：赵毅男      2010/07/13 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void dgvCounter_SelectionChanged(object sender, EventArgs e)
        {

            //设定按钮状态
            dataType = DataType.None;
            setButtonState();

            //判断画面数据不为空
            if (dgvCounter != null && dgvCounter.SelectedRows.Count != 0)
            {

                //取得数据赋值文本框
                txtCode.Text = dgvCounter.SelectedRows[0].Cells["counter_code"].Value.ToString();
                txtType.Text = dgvCounter.SelectedRows[0].Cells["counter_type"].Value.ToString();
                txtManager.Text = dgvCounter.SelectedRows[0].Cells["counter_manager"].Value.ToString();
            }
            else
            {
                txtCode.Text = "";
                txtType.Text = "";
                txtManager.Text = "";
            }

        }

        //***********************************************************************
        /// <summary>
        /// 添加按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：赵毅男      2010/07/13 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnInsert_Click(object sender, EventArgs e)
        {

            //设定按钮状态
            dataType = DataType.Insert;
            setButtonState();
        }

        //***********************************************************************
        /// <summary>
        /// 更新按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：赵毅男      2010/07/13 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            //如果选择多条数据，提示
            if (dgvCounter.SelectedRows.Count > 1)
            {
                MessageBox.Show("只能选择一条要修改的记录！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //如过画面中不存在数据，提示
            if (dgvCounter.SelectedRows.Count < 1)
            {
                MessageBox.Show("请选择一条要修改的记录！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //设定按钮状态
            dataType = DataType.Update;
            setButtonState();
        }

        //***********************************************************************
        /// <summary>
        /// 取消按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：赵毅男      2010/07/13 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnCancel_Click(object sender, EventArgs e)
        {

            //设置按钮状态
            dataType = DataType.None;
            setButtonState();

            //判断画面数据不为空
            if (dgvCounter != null && dgvCounter.SelectedRows.Count != 0)
            {

                //取得画面数据赋值文本框
                txtCode.Text = dgvCounter.SelectedRows[0].Cells["counter_code"].Value.ToString();
                txtType.Text = dgvCounter.SelectedRows[0].Cells["counter_type"].Value.ToString();
                txtManager.Text = dgvCounter.SelectedRows[0].Cells["counter_manager"].Value.ToString();
            }
            else
            {
                txtCode.Text = "";
                txtType.Text = "";
                txtManager.Text = "";
            }
            dgvCounter.Focus();

        }

        //***********************************************************************
        /// <summary>
        /// 查询按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：赵毅男      2010/07/13 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnSelect_Click(object sender, EventArgs e)
        {

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

            try
            {

                //初始化参数类
                SearchParameter sp = new SearchParameter();

                //条件不为空，添加参数
                if (txtCodeSelect.Text != string.Empty)
                {
                    sp.SetValue(":COUNTER_CODE", txtCodeSelect.Text);
                }

                if (txtManagerSelect.Text != string.Empty)
                {
                    sp.SetValue(":COUNTER_MANAGER", txtManagerSelect.Text);

                }

                if (txtTypeSelect.Text != string.Empty)
                {
                    sp.SetValue(":COUNTER_TYPE", txtTypeSelect.Text);
                }

                //打开数据库连接
                dataAccess = new DataAccess();
                dataAccess.Open();

                //取得操作类
                GetData getData = new GetData(dataAccess.Connection);

                //根据条件检索单表
                DataTable dtCondition = getData.GetSingleTableByCondition("TC_COUNTER", sp);

                //如果为NULL，报错
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
                //绑定画面
                dgvCounter.DataSource = dtCondition;

                //没有数据
                if (dtCondition.Rows.Count == 0)
                {

                    //给出提示
                    MessageBox.Show("数据不存在，请查看输入的条件是否正确！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //txtCode.Text = "";
                    //txtType.Text = "";
                    //txtManager.Text = "";
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

        //***********************************************************************
        /// <summary>
        /// 删除按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：赵毅男      2010/07/13 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnDelete_Click(object sender, EventArgs e)
        {

            //设置按钮状态
            dataType = DataType.None;
            setButtonState();

            //结果符
            result = -1;
            countNum = 0;

            //如果选择多条数据删除，提示
            if (dgvCounter.SelectedRows.Count > 1)
            {
                MessageBox.Show("只能选择一条要删除的记录！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //如过画面中不存在数据，提示
            if (dgvCounter.SelectedRows.Count < 1)
            {
                MessageBox.Show("请选择一条要删除的记录！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //弹出提示，确认删除
            if (MessageBox.Show("您确定要删除该数据吗？", this.Text, MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {

                    //初始化参数类
                    SearchParameter sp = new SearchParameter();

                    //设置主键
                    sp.SetValue(":COUNTER_CODE", dgvCounter.SelectedRows[0].Cells["counter_code"].Value.ToString());

                    //打开数据库
                    dataAccess = new DataAccess();
                    dataAccess.Open();

                    //打开事务
                    dataAccess.BeginTransaction();

                    //取得操作类
                    GetData getData = new GetData(dataAccess.Connection, dataAccess.Transaction);

                    //取得结果符
                    result = getData.DeleteRow("TC_COUNTER", sp);

                    //提交事务
                    dataAccess.Commit();
                }
                catch (Exception ex)
                {

                    //回滚
                    dataAccess.Rollback();
                    MessageBox.Show(ex.Message);

                }
                finally
                {
                    //关闭数据库连接
                    dataAccess.Close();

                }

                //判断结果符，0：成功；-1：失败
                if (result == 0)
                {

                    //加载画面
                    BandingDgvCounter();
                    MessageBox.Show("数据已经被成功删除！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("数据删除时发生错误，请检查数据库！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


        }

        //***********************************************************************
        /// <summary>
        /// 确定按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：赵毅男      2010/07/13 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnCommit_Click(object sender, EventArgs e)
        {
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

            if (txtCode.Text.Trim() == string.Empty)
            {
                MessageBox.Show("货位编号不能为空！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCode.Focus();
                return;
            }

            if (txtType.Text.Trim() == string.Empty)
            {
                MessageBox.Show("存货种类不能为空！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtType.Focus();
                return;
            }

            if (txtManager.Text.Trim() == "" || txtManager.Text.Trim() == "双击选择负责人...")
            {
                MessageBox.Show("货位负责人不能为空！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtManager.Focus();
                return;
            }

            try
            {

                result = -1;

                //如果是添加
                if (dataType == DataType.Insert)
                {

                    //取得实体类
                    counterEntity = new EntityCounter();

                    //赋值实体类
                    counterEntity.Counter_code = txtCode.Text;
                    counterEntity.Counter_manager = txtManager.Text;
                    counterEntity.Counter_type = txtType.Text;

                    //打开数据库连接
                    dataAccess = new DataAccess();
                    dataAccess.Open();

                    //取得操作类
                    GetData getData = new GetData(dataAccess.Connection);

                    if (getData.InsertIsOnly("TC_COUNTER", "Counter_code", txtCode.Text.Trim()))
                    {
                        MessageBox.Show("您输入的货位编号已经存在，请更改货位编号后再保存！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCode.Focus();
                        return;
                    }

                    //取得结果符
                    result = getData.InsertCounterRow(counterEntity);

                    if (result == 0)
                    {
                        MessageBox.Show("数据已经保存成功！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("操作添加时发生错误，请检查数据库！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }

                //如果是更新
                else if (dataType == DataType.Update)
                {
                    if (dgvCounter.SelectedRows != null && dgvCounter.SelectedRows.Count != 0)
                    {
                        countNum = dgvCounter.SelectedRows[0].Index;
                    }
                    //取得树体类
                    counterEntity = new EntityCounter();

                    //赋值实体类
                    counterEntity.Counter_code = txtCode.Text;
                    counterEntity.Counter_manager = txtManager.Text;
                    counterEntity.Counter_type = txtType.Text;

                    //打开数据库连接
                    dataAccess = new DataAccess();
                    dataAccess.Open();

                    //打开事务
                    dataAccess.BeginTransaction();

                    //取得操作类
                    GetData getData = new GetData(dataAccess.Connection, dataAccess.Transaction);


                    if (getData.UpdateIsOnly("TC_COUNTER", "Counter_code", counterEntity.Counter_code, "Counter_code", txtCode.Text.Trim()))
                    {
                        MessageBox.Show("您输入的货位编号已经存在，请更改货位编号后再保存！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCode.Focus();
                        return;
                    }

                    //取得结果符
                    result = getData.UpdateCounterTable(counterEntity);

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

                //提示错误
                MessageBox.Show("操作数据时发生错误，请检查数据库是否正常开启！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            finally
            {

                //关闭数据库连接
                dataAccess.Close();

            }

            //设置按钮状态
            dataType = DataType.None;
            setButtonState();

            //重新加载画面
            BandingDgvCounter();
        }

        private void txtManager_DoubleClick(object sender, EventArgs e)
        {
            if (dataType == DataType.Insert || dataType == DataType.Update)
            {
                StaffForm staffForm = new StaffForm();
                staffForm.ShowDialog();
                if (!staffForm.staffName.Equals(string.Empty))
                {
                    txtManager.Text = staffForm.staffName;
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCodeSelect.Text = string.Empty;
            txtTypeSelect.Text = string.Empty;
            txtManagerSelect.Text = string.Empty;
        }

        private void dgvCounter_Sorted(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvCounter.Rows.Count; i++)
            {
                dgvCounter.Rows[i].Cells["index"].Value = i + 1;
            }
        }



    }
}
