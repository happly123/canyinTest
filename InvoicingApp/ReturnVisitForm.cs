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
    public partial class ReturnVisitForm : Form
    {/// <summary>
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
        public DateTime outputInstorageDate;

        /// <summary>
        /// 选择记录的行号
        /// </summary>
        int countNum = 0;

        DataTable dtPrint;

        //销售日期
        private DateTime sellDate;

        //按钮状态类型
        public enum DataType
        {
            Update = 0x0001,
            Insert = 0x0002,
            Success = 0x0003,
            None = 0x0004,

        }

        public ReturnVisitForm()
        {
            InitializeComponent();
            txtOutput_codeSelect.BackColor = Color.FromArgb(255, 255, 255);
            txtOutput_codeSelect.Text = "双击选择出库编号...";
            this.dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(239, 243, 251);
            dateVisitFrom.Value = new DateTime(DateTime.Now.Date.Year, DateTime.Now.Date.Month, 1);
            dateVisitTo.Value = new DateTime(DateTime.Now.Date.Year, DateTime.Now.Date.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
        }
        //*******************************************************************
        /// <summary>
        /// 设置按钮，文本框状态
        /// </summary>
        /// <history>
        ///     完成信息：李梓楠      2010/11/14 完成   
        ///     更新信息：
        /// </history>
        //*******************************************************************
        private void setButtonState()
        {
            switch (dataType)
            {
                case DataType.None:
                case DataType.Success:

                    txtOutput_code.ReadOnly = true;
                    txtGoods_name.ReadOnly = true;
                    txtCustomer_name.ReadOnly = true;
                    txtCustomer_Tel.ReadOnly = true;
                    txtStaff_name.ReadOnly = true;
                    txtVisit_Man.ReadOnly = true;
                    txtUsage.ReadOnly = true;
                    txtVisit_opinion.ReadOnly = true;
                    txtVisit_remarks.ReadOnly = true;
                    dateVisit.Enabled = false;


                    txtOutput_code.BackColor = Color.FromArgb(236, 233, 216);
                    txtGoods_name.BackColor = Color.FromArgb(236, 233, 216);
                    txtCustomer_name.BackColor = Color.FromArgb(236, 233, 216);
                    txtCustomer_Tel.BackColor = Color.FromArgb(236, 233, 216);
                    txtStaff_name.BackColor = Color.FromArgb(236, 233, 216);

                    btnInsert.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnCommit.Enabled = false;
                    btnDelete.Enabled = true;
                    btnCancel.Enabled = false;

                    break;
                case DataType.Insert:
                    txtOutput_code.ReadOnly = true;
                    txtGoods_name.ReadOnly = true;
                    txtCustomer_name.ReadOnly = true;
                    txtCustomer_Tel.ReadOnly = true;
                    txtStaff_name.ReadOnly = true;
                    txtVisit_Man.ReadOnly = false;
                    txtUsage.ReadOnly = false;
                    txtVisit_opinion.ReadOnly = false;
                    txtVisit_remarks.ReadOnly = false;
                    dateVisit.Enabled = true;

                    txtOutput_code.BackColor = Color.FromArgb(255, 255, 255);
                    txtGoods_name.BackColor = Color.FromArgb(255, 255, 255);
                    txtCustomer_name.BackColor = Color.FromArgb(255, 255, 255);
                    txtCustomer_Tel.BackColor = Color.FromArgb(255, 255, 255);
                    txtStaff_name.BackColor = Color.FromArgb(255, 255, 255);

                    txtOutput_code.Text = "双击选择出库编号...";
                    txtGoods_name.Text = "";
                    txtCustomer_name.Text = "";
                    txtCustomer_Tel.Text = "";
                    txtStaff_name.Text = "双击选择回访人...";
                    txtVisit_Man.Text = "";
                    txtVisit_opinion.Text = "";
                    txtUsage.Text = "";
                    txtVisit_opinion.Text = "";
                    txtVisit_remarks.Text = "";
                    dateVisit.Value = DateTime.Now;


                    btnInsert.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnCommit.Enabled = true;
                    btnDelete.Enabled = false;
                    btnCancel.Enabled = true;

                    break;
                case DataType.Update:

                    txtOutput_code.ReadOnly = true;
                    txtGoods_name.ReadOnly = true;
                    txtCustomer_name.ReadOnly = true;
                    txtCustomer_Tel.ReadOnly = true;
                    txtStaff_name.ReadOnly = true;
                    txtVisit_Man.ReadOnly = false;
                    txtUsage.ReadOnly = false;
                    txtVisit_opinion.ReadOnly = false;
                    txtVisit_remarks.ReadOnly = false;
                    dateVisit.Enabled = true;

                    txtOutput_code.BackColor = Color.FromArgb(255, 255, 255);
                    txtGoods_name.BackColor = Color.FromArgb(255, 255, 255);
                    txtCustomer_name.BackColor = Color.FromArgb(255, 255, 255);
                    txtCustomer_Tel.BackColor = Color.FromArgb(255, 255, 255);
                    txtStaff_name.BackColor = Color.FromArgb(255, 255, 255);

                    btnInsert.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnCommit.Enabled = true;
                    btnDelete.Enabled = false;
                    btnCancel.Enabled = true;

                    break;
                default:
                    txtOutput_code.ReadOnly = true;
                    txtGoods_name.ReadOnly = true;
                    txtCustomer_name.ReadOnly = true;
                    txtCustomer_Tel.ReadOnly = true;
                    txtStaff_name.ReadOnly = true;
                    txtVisit_Man.ReadOnly = true;
                    txtUsage.ReadOnly = true;
                    txtVisit_opinion.ReadOnly = true;
                    txtVisit_remarks.ReadOnly = true;
                    dateVisit.Enabled = false;

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
        ///    完成信息：李梓楠      2010/11/14 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void ReturnVisitForm_Load(object sender, EventArgs e)
        {
            dgv.AutoGenerateColumns = false;
            BandingDgv();
            setButtonState();
            txtOutput_code.Focus();
        }
        //*******************************************************************
        /// <summary>
        /// 绑定画面
        /// </summary>
        /// <history>
        ///     完成信息：李梓楠      2010/11/14 完成   
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
                if (checkDate.Checked == true)
                {
                    sp.SetValue(":VISIT_DATE_FROM", dateVisitFrom.Value.Date);
                    sp.SetValue(":VISIT_DATE_TO", dateVisitTo.Value.Date);
                }
                DataTable dtCounter = getData.GetTableBySqlStr(Constants.SqlStr.TC_VISIT_JOIN_IN_OUT_CUSTOMER_GOODS, sp);

                dtCounter.Columns.Add("index", typeof(int));
                for (int i = 0; i < dtCounter.Rows.Count; i++)
                {
                    dtCounter.Rows[i]["index"] = i + 1;
                }
                dgv.DataSource = dtCounter;

                dtPrint = dtCounter;
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
        //*******************************************************************
        /// <summary>
        /// 选中行改变,TEXTBOX值跟随改变
        /// </summary>
        /// <history>
        ///     完成信息：李梓楠      2010/11/15 完成   
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
                txtOutput_code.Text = dgv.SelectedRows[0].Cells["output_code"].Value.ToString();
                txtGoods_name.Text = dgv.SelectedRows[0].Cells["Goods_name"].Value.ToString();
                txtCustomer_name.Text = dgv.SelectedRows[0].Cells["Customer_name"].Value.ToString();
                txtCustomer_Tel.Text = dgv.SelectedRows[0].Cells["Customer_Tel"].Value.ToString();
                dateVisit.Value = DateTime.Parse(dgv.SelectedRows[0].Cells["date_Visit"].Value.ToString());
                txtStaff_name.Text = dgv.SelectedRows[0].Cells["Staff_name"].Value.ToString();
                txtVisit_Man.Text = dgv.SelectedRows[0].Cells["Visit_Man"].Value.ToString();
                txtUsage.Text = dgv.SelectedRows[0].Cells["visit_Usage"].Value.ToString();
                txtVisit_opinion.Text = dgv.SelectedRows[0].Cells["Visit_opinion"].Value.ToString();
                txtVisit_remarks.Text = dgv.SelectedRows[0].Cells["Visit_remarks"].Value.ToString();
            }
        }
        //***********************************************************************
        /// <summary>
        /// 查询按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：李梓楠      2010/11/14 完成   
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
                        MessageBox.Show("不可以输入非法字符，请重新输入！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        control.Focus();
                        return;
                    }
                }
            }
            try
            {
                SearchParameter sp = new SearchParameter();

                if (txtOutput_codeSelect.Text != string.Empty && txtOutput_codeSelect.Text != "双击选择出库编号...")
                {
                    sp.SetValue(":visit_Output_code", txtOutput_codeSelect.Text);
                }

                if (txtGoods_nameSelect.Text != string.Empty)
                {
                    sp.SetValue(":Goods_name", txtGoods_nameSelect.Text);

                }
                if (txtCustomer_nameSelect.Text != string.Empty)
                {
                    sp.SetValue(":Customer_name", txtCustomer_nameSelect.Text);

                }
                if (checkDate.Checked == true)
                {
                    sp.SetValue(":VISIT_DATE_FROM", dateVisitFrom.Value.Date);
                    sp.SetValue(":VISIT_DATE_TO", dateVisitTo.Value.Date);
                }

                dataAccess = new DataAccess();
                dataAccess.Open();

                GetData getData = new GetData(dataAccess.Connection);

                DataTable dt = getData.GetTableBySqlStr(Constants.SqlStr.TC_VISIT_JOIN_IN_OUT_CUSTOMER_GOODS, sp); ;


                if (dt == null)
                {
                    MessageBox.Show("请查看数据库是否正常！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    txtOutput_code.Text = "";
                    txtStaff_name.Text = "";
                    MessageBox.Show("数据不存在，请查看输入的条件是否正确！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dtPrint = dt;
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
        /// <summary>
        /// 添加按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：李梓楠      2010/11/14 完成   
        ///    更新信息：
        /// </history>

        private void btnInsert_Click(object sender, EventArgs e)
        {
            dataType = DataType.Insert;
            setButtonState();
            txtOutput_code.Focus();
        }
        /// <summary>
        /// 修改按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：李梓楠      2010/11/14 完成   
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
            txtOutput_code.Focus();
        }
        //***********************************************************************
        /// <summary>
        /// 保存按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：李梓楠      2010/11/14 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnCommit_Click(object sender, EventArgs e)
        {



            if (txtOutput_code.Text.Trim() == string.Empty || txtOutput_code.Text == "双击选择出库编号...")
            {
                MessageBox.Show("出库编号不能为空！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtOutput_code.Focus();
                return;
            }
            //判断注册证号不能为空
            if (txtVisit_Man.Text.Trim() == string.Empty)
            {
                MessageBox.Show("被访人不能为空！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtVisit_Man.Focus();
                return;
            }

            //判断生产厂家不能为空
            if (txtStaff_name.Text.Trim() == string.Empty || txtStaff_name.Text == "双击选择回访人...")
            {
                MessageBox.Show("双击选择回访人！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtStaff_name.Focus();
                return;
            }

            //判断规格型号不能为空
            if (txtVisit_opinion.Text.Trim() == string.Empty)
            {
                MessageBox.Show("使用意见不能为空！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtVisit_opinion.Focus();
                return;
            }

            if (txtUsage.Text.Trim() == string.Empty)
            {
                MessageBox.Show("使用情况不能为空！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsage.Focus();
                return;
            }
            //日期校验
            if (dateVisit.Value.Date > DateTime.Now)
            {
                MessageBox.Show("回访日期不能大于今天！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateVisit.Focus();
                return;
            }
            if (dateVisit.Value.Date < sellDate)
            {
                MessageBox.Show("回访日期不能小于销售日期！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateVisit.Focus();
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
            EntityVisit entityVisit = new EntityVisit();
            try
            {
                result = -1;

                //如果是添加
                if (dataType == DataType.Insert)
                {


                    entityVisit.Visit_output_code = txtOutput_code.Text;
                    entityVisit.Visit_date = dateVisit.Value.Date;
                    entityVisit.Staff_name = txtStaff_name.Text;
                    entityVisit.Visit_man = txtVisit_Man.Text;
                    entityVisit.Visit_opinion = txtVisit_opinion.Text;
                    entityVisit.Visit_usage = txtUsage.Text;
                    entityVisit.Visit_remarks = txtVisit_remarks.Text;

                    dataAccess = new DataAccess();
                    dataAccess.Open();

                    GetData getData = new GetData(dataAccess.Connection);
                    result = getData.InsertVisit(entityVisit);

                }
                //如果是更新
                else if (dataType == DataType.Update)
                {
                    //给选中行赋值
                    countNum = dgv.SelectedRows[0].Index;

                    entityVisit.Visit_id = Convert.ToInt32(dgv.SelectedRows[0].Cells["visit_id"].Value.ToString());
                    entityVisit.Visit_output_code = txtOutput_code.Text;
                    entityVisit.Visit_date = dateVisit.Value.Date;
                    entityVisit.Staff_name = txtStaff_name.Text;
                    entityVisit.Visit_man = txtVisit_Man.Text;
                    entityVisit.Visit_opinion = txtVisit_opinion.Text;
                    entityVisit.Visit_usage = txtUsage.Text;
                    entityVisit.Visit_remarks = txtVisit_remarks.Text;

                    dataAccess = new DataAccess();
                    dataAccess.Open();
                    dataAccess.BeginTransaction();

                    GetData getData = new GetData(dataAccess.Connection, dataAccess.Transaction);
                    //取得结果符
                    result = getData.UpdateVisit(entityVisit);
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
        ///    完成信息：李梓楠      2010/11/14 完成   
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
                SearchParameter sp = new SearchParameter();

                dataAccess = new DataAccess();
                try
                {

                    dataAccess.Open();
                    dataAccess.BeginTransaction();
                    GetData getData = new GetData(dataAccess.Connection, dataAccess.Transaction);

                    sp.SetValue(":visit_id", dgv.SelectedRows[0].Cells["visit_id"].Value.ToString());
                    result = getData.DeleteRow("tc_visit", sp);
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
        ///    完成信息：李梓楠      2010/11/14 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dataType = DataType.None;
            setButtonState();
            if (dgv != null && dgv.SelectedRows.Count != 0)
            {
                txtOutput_code.Text = dgv.SelectedRows[0].Cells["output_code"].Value.ToString();
                txtGoods_name.Text = dgv.SelectedRows[0].Cells["Goods_name"].Value.ToString();
                txtCustomer_name.Text = dgv.SelectedRows[0].Cells["Customer_name"].Value.ToString();
                txtCustomer_Tel.Text = dgv.SelectedRows[0].Cells["Customer_Tel"].Value.ToString();
                dateVisit.Value = DateTime.Parse(dgv.SelectedRows[0].Cells["date_Visit"].Value.ToString());
                txtStaff_name.Text = dgv.SelectedRows[0].Cells["Staff_name"].Value.ToString();
                txtVisit_Man.Text = dgv.SelectedRows[0].Cells["Visit_Man"].Value.ToString();
                txtUsage.Text = dgv.SelectedRows[0].Cells["visit_Usage"].Value.ToString();
                txtVisit_opinion.Text = dgv.SelectedRows[0].Cells["Visit_opinion"].Value.ToString();
                txtVisit_remarks.Text = dgv.SelectedRows[0].Cells["Visit_remarks"].Value.ToString();
            }
            dgv.Focus();
        }
        private void dgv_Sorted(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                dgv.Rows[i].Cells["index"].Value = i + 1;
            }
        }
        //双击选择出库编号,(添加修改)
        private void txtOutput_code_DoubleClick(object sender, EventArgs e)
        {
            if (dataType == DataType.Insert || dataType == DataType.Update)
            {
                sellStorageDialogForm child = new sellStorageDialogForm("visit");
                child.ShowDialog();
                if (child.outputCode != string.Empty)
                {
                    txtOutput_code.Text = child.outputCode;
                    txtCustomer_name.Text = child.customerName;
                    txtGoods_name.Text = child.goodsName;
                    txtCustomer_Tel.Text = child.customerTel;
                    sellDate = child.outputInstorageDate;
                }
            }
        }


        //双击选择出库编号,(查询)
        private void txtOutput_codeSelect_DoubleClick(object sender, EventArgs e)
        {
            sellStorageDialogForm child = new sellStorageDialogForm("visit");
            child.ShowDialog();
            if (child.outputCode != string.Empty)
            {
                txtOutput_codeSelect.Text = child.outputCode;
            }
        }
        //重置按钮
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOutput_codeSelect.Text = "双击选择出库编号...";
            txtGoods_nameSelect.Text = "";
            txtCustomer_nameSelect.Text = "";
            checkDate.Checked = true;
            dateVisitFrom.Value = new DateTime(DateTime.Now.Date.Year, DateTime.Now.Date.Month, 1);
            dateVisitTo.Value = new DateTime(DateTime.Now.Date.Year, DateTime.Now.Date.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
        }
        //双击选择回访人
        private void txtStaff_name_DoubleClick(object sender, EventArgs e)
        {
            //判断当前页面的状态
            if (dataType == DataType.Insert || dataType == DataType.Update)
            {
                StaffForm child = new StaffForm();
                child.ShowDialog();
                //获取员工信息
                if (!child.staffName.Equals(string.Empty))
                {
                    txtStaff_name.Text = child.staffName;
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgv == null || dgv.Rows.Count < 1)
            {
                MessageBox.Show("没有可以打印的数据！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dgv.Rows.Count > 1)
            {
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    if (!dgv.Rows[0].Cells["output_code"].Value.ToString().Equals(dgv.Rows[i].Cells["output_code"].Value.ToString()))
                    {
                        MessageBox.Show("只能打印同一出库编号的回访记录！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }

            ReturnVisitPrint returnVisitPrint = new ReturnVisitPrint(dtPrint);
            returnVisitPrint.ShowDialog();
        }
        //checkbox改变
        private void checkDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDate.Checked == true)
            {
                dateVisitFrom.Enabled = true;
                dateVisitTo.Enabled = true;
            }
            else
            {
                dateVisitFrom.Enabled = false;
                dateVisitTo.Enabled = false;
            }
        }

        private void txtOutput_codeSelect_Enter(object sender, EventArgs e)
        {
            if (txtOutput_codeSelect.Text == "双击选择出库编号...")
            {
                txtOutput_codeSelect.Text = string.Empty;
            }
        }

        private void txtOutput_codeSelect_Leave(object sender, EventArgs e)
        {
            if (txtOutput_codeSelect.Text == "")
            {
                txtOutput_codeSelect.Text = "双击选择出库编号...";
            }
        }

        

    }
}
