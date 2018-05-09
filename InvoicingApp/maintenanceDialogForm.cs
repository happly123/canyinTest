//***********************************************************************
//* 系统名称	    ：  长白ERP系统
//* 功能模块	    ：  质量平台
//* 功能画面		：  养护明细
//* 画面名称	    ：  maintenanceDialogForm
//* 完成年月日      ：  2010/07/22
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
    ///养护明细
    /// </summary>
    /// <history>
    ///     完成信息：李梓楠      2010/07/22 完成  
    ///     更新信息：
    /// </history>
    //***********************************************************************
    public partial class maintenanceDialogForm : Form
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

        string p_maintain_code;
        DateTime maintainCreateDate;

        //无参构造
        public maintenanceDialogForm()
        {
            InitializeComponent();
            this.dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(239, 243, 251);

        }
        //重载有参构造
        public maintenanceDialogForm(string p_maintain_code, DateTime maintainCreateDate)
        {
            this.p_maintain_code = p_maintain_code;
            this.maintainCreateDate = maintainCreateDate;
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
        ///     完成信息：李梓楠      2010/7/22 完成   
        ///     更新信息：
        /// </history>
        //*******************************************************************
        private void setButtonState()
        {
            switch (dataType)
            {
                case DataType.None:
                case DataType.Success:

                    dateMaintain_datetime.Enabled = false;
                    txtMaintain_detail_quality.ReadOnly = true;
                    txtMaintain_detail_settle.ReadOnly = true;
                    txtMaintain_detail_oper.ReadOnly = true;
                    txtMaintain_detail_remark.ReadOnly = true;

                    txtMaintain_detail_oper.BackColor = Color.FromArgb(236, 233, 216);

                    btnInsert.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnCommit.Enabled = false;
                    btnDelete.Enabled = true;
                    btnCancel.Enabled = false;

                    break;
                case DataType.Insert:
                    dateMaintain_datetime.Enabled = true;
                    txtMaintain_detail_quality.ReadOnly = false;
                    txtMaintain_detail_settle.ReadOnly = false;
                    txtMaintain_detail_oper.ReadOnly = true;
                    txtMaintain_detail_remark.ReadOnly = false;

                    txtMaintain_detail_oper.BackColor = Color.FromArgb(255, 255, 255);


                    dateMaintain_datetime.Text = "";
                    txtMaintain_detail_quality.Text = "";
                    txtMaintain_detail_settle.Text = "";
                    txtMaintain_detail_oper.Text = "双击选择养护员...";
                    txtMaintain_detail_remark.Text = "";



                    btnInsert.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnCommit.Enabled = true;
                    btnDelete.Enabled = false;
                    btnCancel.Enabled = true;

                    break;
                case DataType.Update:
                    dateMaintain_datetime.Enabled = true;
                    txtMaintain_detail_quality.ReadOnly = false;
                    txtMaintain_detail_settle.ReadOnly = false;
                    txtMaintain_detail_oper.ReadOnly = true;
                    txtMaintain_detail_remark.ReadOnly = false;

                    txtMaintain_detail_oper.BackColor = Color.FromArgb(255, 255, 255);


                    btnInsert.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnCommit.Enabled = true;
                    btnDelete.Enabled = false;
                    btnCancel.Enabled = true;

                    break;
                default:
                    dateMaintain_datetime.Enabled = false;
                    txtMaintain_detail_quality.ReadOnly = true;
                    txtMaintain_detail_settle.ReadOnly = true;
                    txtMaintain_detail_oper.ReadOnly = true;
                    txtMaintain_detail_remark.ReadOnly = true;

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
        ///    完成信息：李梓楠      2010/7/22 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void maintenanceDialogForm_Load(object sender, EventArgs e)
        {
            BandingDgv();
            setButtonState();

        }
        //*******************************************************************
        /// <summary>
        /// 绑定画面
        /// </summary>
        /// <history>
        ///     完成信息：李梓楠      2010/7/22 完成   
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
                sp.SetValue(":maintain_code", p_maintain_code);

                DataTable dtCounter = getData.GetSingleTableByCondition("tc_maintain_detail",sp);
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
                throw ex;
            }
            finally
            {
                dataAccess.Close();
            }

        }
        //*******************************************************************
        /// <summary>
        /// 选择行改变
        /// </summary>
        /// <history>
        ///     完成信息：李梓楠      2010/7/22 完成   
        ///     更新信息：
        /// </history>
        //*******************************************************************
        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            //设定按钮状态
            dataType = DataType.None;
            setButtonState();


            if (dgv != null && dgv.SelectedRows.Count != 0)
            {
                dateMaintain_datetime.Value = DateTime.Parse(dgv.SelectedRows[0].Cells["Maintain_detail_datetime"].Value.ToString());
                txtMaintain_detail_quality.Text = dgv.SelectedRows[0].Cells["Maintain_detail_quality"].Value.ToString();
                txtMaintain_detail_settle.Text = dgv.SelectedRows[0].Cells["Maintain_detail_settle"].Value.ToString();
                txtMaintain_detail_oper.Text = dgv.SelectedRows[0].Cells["Maintain_detail_oper"].Value.ToString();
                txtMaintain_detail_remark.Text = dgv.SelectedRows[0].Cells["Maintain_detail_remark"].Value.ToString();
            }
        }
        /// <summary>
        /// 添加按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：李梓楠      2010/7/22 完成   
        ///    更新信息：
        /// </history>

        private void btnInsert_Click(object sender, EventArgs e)
        {
            dataType = DataType.Insert;
            setButtonState();
            txtMaintain_detail_oper.Focus();
        }
        /// <summary>
        /// 修改按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：李梓楠      2010/7/22 完成   
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
            txtMaintain_detail_oper.Focus();
        }

        //***********************************************************************
        /// <summary>
        /// 保存按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：李梓楠      2010/7/22 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnCommit_Click(object sender, EventArgs e)
        {
            //判断时间有效性
            if (DateTime.Now.Date < dateMaintain_datetime.Value.Date)
            {
                MessageBox.Show("养护日期不可大于今天！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //判断时间有效性
            if (maintainCreateDate > dateMaintain_datetime.Value.Date)
            {
                MessageBox.Show("养护日期不可小于建档日期！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaintain_detail_oper.Text.Trim() == string.Empty || txtMaintain_detail_oper.Text == "双击选择养护员...")
            {
                MessageBox.Show("养护员不能为空！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //判断非法字符
            foreach (Control control in groupbox.Controls)
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
            EntityMaintain_detail entity = new EntityMaintain_detail();
            try
            {
                result = -1;

                //如果是添加
                if (dataType == DataType.Insert)
                {
                    entity.Maintain_detail_datetime = dateMaintain_datetime.Value.Date;
                    entity.Maintain_detail_oper = txtMaintain_detail_oper.Text;
                    entity.Maintain_detail_quality = txtMaintain_detail_quality.Text;
                    entity.Maintain_detail_remark = txtMaintain_detail_remark.Text;
                    entity.Maintain_detail_settle = txtMaintain_detail_settle.Text;
                    entity.Maintain_code = p_maintain_code;

                    dataAccess = new DataAccess();
                    dataAccess.Open();

                    


                    GetData getData = new GetData(dataAccess.Connection);
                    result = getData.InsertMaintain_detailTable(entity);



                }
                //如果是更新
                else if (dataType == DataType.Update)
                {
                    //给选中行赋值
                    countNum = dgv.SelectedRows[0].Index;

                    entity.Maintain_detail_datetime = dateMaintain_datetime.Value.Date;
                    entity.Maintain_detail_oper = txtMaintain_detail_oper.Text;
                    entity.Maintain_detail_quality = txtMaintain_detail_quality.Text;
                    entity.Maintain_detail_remark = txtMaintain_detail_remark.Text;
                    entity.Maintain_detail_settle = txtMaintain_detail_settle.Text;
                    entity.Maintain_code = p_maintain_code;
                    entity.Maintain_detail_code = int.Parse(dgv.SelectedRows[0].Cells["Maintain_detail_code"].Value.ToString());
                    
                    dataAccess = new DataAccess();
                    dataAccess.Open();
                    dataAccess.BeginTransaction();

                    GetData getData = new GetData(dataAccess.Connection, dataAccess.Transaction);
                    //取得结果符
                    result = getData.UpdateMaintain_detailTable(entity);
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
        ///    完成信息：李梓楠      2010/7/22 完成   
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
                    sp.SetValue(":maintain_detail_code", int.Parse(dgv.SelectedRows[0].Cells["maintain_detail_code"].Value.ToString()));

                    dataAccess = new DataAccess();
                    dataAccess.Open();
                    dataAccess.BeginTransaction();
                    GetData getData = new GetData(dataAccess.Connection, dataAccess.Transaction);

                    result = getData.DeleteRow("tc_maintain_detail", sp);

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
        ///    完成信息：李梓楠      2010/7/22 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dataType = DataType.None;
            setButtonState();
            if (dgv != null && dgv.SelectedRows.Count != 0)
            {
                dateMaintain_datetime.Value = DateTime.Parse(dgv.SelectedRows[0].Cells["Maintain_detail_datetime"].Value.ToString());
                txtMaintain_detail_quality.Text = dgv.SelectedRows[0].Cells["Maintain_detail_quality"].Value.ToString();
                txtMaintain_detail_settle.Text = dgv.SelectedRows[0].Cells["Maintain_detail_settle"].Value.ToString();
                txtMaintain_detail_oper.Text = dgv.SelectedRows[0].Cells["Maintain_detail_oper"].Value.ToString();
                txtMaintain_detail_remark.Text = dgv.SelectedRows[0].Cells["Maintain_detail_remark"].Value.ToString();
            }
            dgv.Focus();
        }
        //***********************************************************************
        /// <summary>
        /// 养护员TEXTBOX双击,选择养护员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：李梓楠      2010/7/22 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void txtMaintain_detail_oper_DoubleClick(object sender, EventArgs e)
        {
            if (dataType == DataType.Insert || dataType == DataType.Update)
            {
                StaffForm child = new StaffForm();
                child.ShowDialog();
                if (child.staffName != string.Empty)
                    txtMaintain_detail_oper.Text = child.staffName;
            }
            else return;
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
