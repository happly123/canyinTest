//***********************************************************************
//* 系统名称	    ：  长白ERP系统
//* 功能模块	    ：  质量平台
//* 功能画面		：  不良事件
//* 画面名称	    ：  WeaponQualityAegisForm
//* 完成年月日      ：  2010/07/26
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
    public partial class WeaponQualityAegisForm : Form
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
        public DateTime outputInstorageDate;

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

                    txtApparatus_quality_output_code.ReadOnly = true;
                    txtApparatus_quality_count.Enabled = false;
                    txtApparatus_qualityt_issued.ReadOnly = true;
                    txtApparatus_accident_conditions.ReadOnly = true;
                    dateApparatus_report_date.Enabled = false;
                    txtApparatus_accident_management.ReadOnly = true;
                    dateApparatus_accident_management_date.Enabled = false;
                    txtApparatus_speaker.ReadOnly = true;
                    txtApparatus_customer_feedback.ReadOnly = true;
                    txtApparatus_opinion_leader.ReadOnly = true;
                    txtApparatus_customer_name.ReadOnly = true;
                    txtApparatus_goods_name.ReadOnly = true;
                    txtApparatus_supplier_name.ReadOnly = true;

                    txtApparatus_quality_output_code.BackColor = Color.FromArgb(236, 233, 216);
                    txtApparatus_qualityt_issued.BackColor = Color.FromArgb(236, 233, 216);


                    label9.Visible = false;
                    btnInsert.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnCommit.Enabled = false;
                    btnDelete.Enabled = true;
                    btnCancel.Enabled = false;
                    
                    break;
                case DataType.Insert:
                    txtApparatus_quality_output_code.ReadOnly = true;
                    txtApparatus_quality_count.Enabled = true;
                    txtApparatus_qualityt_issued.ReadOnly = true;
                    txtApparatus_accident_conditions.ReadOnly = false;
                    dateApparatus_report_date.Enabled = true;
                    txtApparatus_accident_management.ReadOnly = false;
                    dateApparatus_accident_management_date.Enabled = true;
                    txtApparatus_speaker.ReadOnly = false;
                    txtApparatus_customer_feedback.ReadOnly = false;
                    txtApparatus_opinion_leader.ReadOnly = false;
                    txtApparatus_customer_name.ReadOnly = true;
                    txtApparatus_goods_name.ReadOnly = true;
                    txtApparatus_supplier_name.ReadOnly = true;

                    txtApparatus_quality_output_code.BackColor = Color.FromArgb(255, 255, 255);
                    txtApparatus_qualityt_issued.BackColor = Color.FromArgb(255, 255, 255);

                    txtApparatus_quality_output_code.Text = "双击选择出库编号...";
                    txtApparatus_quality_count.Text = "0";
                    txtApparatus_qualityt_issued.Text = "双击选择经办人...";
                    txtApparatus_accident_conditions.Text = "";
                    dateApparatus_report_date.Text = "";
                    txtApparatus_accident_management.Text = "";
                    dateApparatus_accident_management_date.Text = "";
                    txtApparatus_speaker.Text = "";
                    txtApparatus_customer_feedback.Text = "";
                    txtApparatus_opinion_leader.Text = "";
                    txtApparatus_customer_name.Text = "";
                    txtApparatus_goods_name.Text = "";
                    txtApparatus_supplier_name.Text = "";
                    labelSellcount.Text = "";

                    label9.Visible = true;
                    btnInsert.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnCommit.Enabled = true;
                    btnDelete.Enabled = false;
                    btnCancel.Enabled = true;

                    break;
                case DataType.Update:
                    txtApparatus_quality_output_code.ReadOnly = true;
                    txtApparatus_quality_count.Enabled = true;
                    txtApparatus_qualityt_issued.ReadOnly = true;
                    txtApparatus_accident_conditions.ReadOnly = false;
                    dateApparatus_report_date.Enabled = true;
                    txtApparatus_accident_management.ReadOnly = false;
                    dateApparatus_accident_management_date.Enabled = true;
                    txtApparatus_speaker.ReadOnly = false;
                    txtApparatus_customer_feedback.ReadOnly = false;
                    txtApparatus_opinion_leader.ReadOnly = false;
                    txtApparatus_customer_name.ReadOnly = true;
                    txtApparatus_goods_name.ReadOnly = true;
                    txtApparatus_supplier_name.ReadOnly = true;

                    txtApparatus_quality_output_code.BackColor = Color.FromArgb(236, 233, 216);
                    txtApparatus_qualityt_issued.BackColor = Color.FromArgb(255, 255, 255);

                    label9.Visible = true;
                    btnInsert.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnCommit.Enabled = true;
                    btnDelete.Enabled = false;
                    btnCancel.Enabled = true;

                    break;
                default:
                    txtApparatus_quality_output_code.ReadOnly = true;
                    txtApparatus_quality_count.Enabled = false;
                    txtApparatus_qualityt_issued.ReadOnly = true;
                    txtApparatus_accident_conditions.ReadOnly = true;
                    dateApparatus_report_date.Enabled = false;
                    txtApparatus_accident_management.ReadOnly = true;
                    dateApparatus_accident_management_date.Enabled = false;
                    txtApparatus_speaker.ReadOnly = true;
                    txtApparatus_customer_feedback.ReadOnly = true;
                    txtApparatus_opinion_leader.ReadOnly = true;
                    txtApparatus_customer_name.ReadOnly = true;
                    txtApparatus_goods_name.ReadOnly = true;
                    txtApparatus_supplier_name.ReadOnly = true;
                    label9.Visible = false;

                    btnInsert.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnCommit.Enabled = false;
                    btnDelete.Enabled = true;
                    btnCancel.Enabled = false;
                    
                    break;
            }
        }
        public WeaponQualityAegisForm()
        {
            InitializeComponent();
            this.dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(239, 243, 251);

        }

        //***********************************************************************
        /// <summary>
        /// 画面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：李梓楠      2010/7/26 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void WeaponQualityAegisForm_Load(object sender, EventArgs e)
        {
            dgv.AutoGenerateColumns = false;
            BandingDgv();
            setButtonState();
            txtApparatus_quality_codeSelect.Focus();


        }
        //*******************************************************************
        /// <summary>
        /// 绑定画面
        /// </summary>
        /// <history>
        ///     完成信息：李梓楠      2010/7/26 完成   
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

                DataTable dtCounter = getData.GetTableBySqlStr(Constants.SqlStr.TC_APPARATUS_QUALITY_SELECT, sp);

                dtCounter.Columns.Remove("customer_code");
                dtCounter.Columns.Remove("input_goods_code");
                dtCounter.Columns.Remove("input_code");
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
        //*******************************************************************
        /// <summary>
        /// 选中行改变,TEXTBOX值跟随改变
        /// </summary>
        /// <history>
        ///     完成信息：李梓楠      2010/7/26 完成   
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
                txtApparatus_quality_output_code.Text = dgv.SelectedRows[0].Cells["Apparatus_quality_output_code"].Value.ToString();
                txtApparatus_quality_count.Text = dgv.SelectedRows[0].Cells["Apparatus_quality_count"].Value.ToString();
                txtApparatus_qualityt_issued.Text = dgv.SelectedRows[0].Cells["Apparatus_qualityt_issued"].Value.ToString();
                txtApparatus_accident_conditions.Text = dgv.SelectedRows[0].Cells["Apparatus_accident_conditions"].Value.ToString();
                dateApparatus_report_date.Value = DateTime.Parse(dgv.SelectedRows[0].Cells["Apparatus_report_date"].Value.ToString());
                txtApparatus_accident_management.Text = dgv.SelectedRows[0].Cells["Apparatus_accident_management"].Value.ToString();
                dateApparatus_accident_management_date.Value = DateTime.Parse(dgv.SelectedRows[0].Cells["Apparatus_accident_management_date"].Value.ToString());
                txtApparatus_speaker.Text = dgv.SelectedRows[0].Cells["Apparatus_speaker"].Value.ToString();
                txtApparatus_customer_feedback.Text = dgv.SelectedRows[0].Cells["Apparatus_customer_feedback"].Value.ToString();
                txtApparatus_opinion_leader.Text = dgv.SelectedRows[0].Cells["Apparatus_opinion_leader"].Value.ToString();
                txtApparatus_customer_name.Text = dgv.SelectedRows[0].Cells["Apparatus_customer_name"].Value.ToString();
                txtApparatus_goods_name.Text = dgv.SelectedRows[0].Cells["Apparatus_goods_name"].Value.ToString();
                txtApparatus_supplier_name.Text = dgv.SelectedRows[0].Cells["Apparatus_supplier_name"].Value.ToString();
                labelSellcount.Text = ""; 
            }
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

                if (txtApparatus_quality_codeSelect.Text.Trim() != string.Empty)
                {
                    sp.SetValue(":Apparatus_quality_code", txtApparatus_quality_codeSelect.Text);
                }

                if (txtApparatus_goods_nameSelect.Text.Trim() != string.Empty)
                {
                    sp.SetValue(":Goods_name", txtApparatus_goods_nameSelect.Text);
                }
                


                dataAccess = new DataAccess();
                dataAccess.Open();

                GetData getData = new GetData(dataAccess.Connection);


                DataTable dtCondition = getData.GetTableBySqlStr(Constants.SqlStr.TC_APPARATUS_QUALITY_SELECT, sp);
                dtCondition.Columns.Remove("customer_code");
                dtCondition.Columns.Remove("input_goods_code");
                dtCondition.Columns.Remove("input_code");

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
                    txtApparatus_quality_output_code.Text = "";
                    txtApparatus_qualityt_issued.Text = "";
                    MessageBox.Show("数据不存在，请查看输入的条件是否正确！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        /// <summary>
        /// 添加按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：李梓楠      2010/7/26 完成   
        ///    更新信息：
        /// </history>

        private void btnInsert_Click(object sender, EventArgs e)
        {
            dataType = DataType.Insert;
            setButtonState();
            txtApparatus_quality_output_code.Focus();
        }
        /// <summary>
        /// 修改按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：李梓楠      2010/7/26 完成   
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
            //可填数量
            int i = 0;
            int sum = 0;
            i = int.Parse(dgv.SelectedRows[0].Cells["output_count"].Value.ToString());
            try
            {
                SearchParameter sp = new SearchParameter();

                sp.SetValue(":apparatus_output_code", dgv.SelectedRows[0].Cells["apparatus_quality_output_code"].Value.ToString());

                dataAccess = new DataAccess();
                dataAccess.Open();

                GetData getData = new GetData(dataAccess.Connection);
                DataTable dt = getData.GetTableBySqlStr(Constants.SqlStr.SUM_TC_APPARATUS_QUALITY, sp);
                if (dt != null && dt.Rows.Count != 0 && dt.Rows[0]["suncount"].ToString() != string.Empty)
                {
                    sum = int.Parse(dt.Rows[0]["suncount"].ToString());
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
            i = i - sum + int.Parse(dgv.SelectedRows[0].Cells["apparatus_quality_count"].Value.ToString());
            labelSellcount.Text = i.ToString();
            dataType = DataType.Update;
            setButtonState();
            txtApparatus_quality_output_code.Focus();

        }
        //***********************************************************************
        /// <summary>
        /// 保存按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：李梓楠      2010/7/26 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnCommit_Click(object sender, EventArgs e)
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
            //判断入库编号不为空
            if (txtApparatus_quality_output_code.Text.Trim() == string.Empty || txtApparatus_quality_output_code.Text == "双击选择出库编号...")
            {
                MessageBox.Show("出库编号不能为空！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtApparatus_quality_output_code.Focus();
                return;
            }
            if (txtApparatus_quality_count.Text.Trim() == string.Empty)
            {
                MessageBox.Show("出问题产品数量不能为空！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtApparatus_quality_count.Focus();
                return;
            }
            if (Convert.ToInt32(txtApparatus_quality_count.Text.Trim()) == 0)
            {
                MessageBox.Show("出问题产品数量不能为0！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtApparatus_quality_count.Focus();
                return;
            }
            if (Convert.ToInt32(labelSellcount.Text) < Convert.ToInt32(txtApparatus_quality_count.Text.Trim()))
            {
                MessageBox.Show("输入的数量不能大于出售数量！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                labelSellcount.Focus();
                return;
            }
            if (txtApparatus_speaker.Text.Trim() == string.Empty)
            {
                MessageBox.Show("报告人不能为空！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtApparatus_speaker.Focus();
                return;
            }
            if (txtApparatus_qualityt_issued.Text.Trim() == string.Empty || txtApparatus_qualityt_issued.Text == "双击选择经办人...")
            {
                MessageBox.Show("经办人不能为空！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtApparatus_qualityt_issued.Focus();
                return;
            }
            
            
            //判断时间有效性
            if (DateTime.Now.Date < dateApparatus_report_date.Value.Date)
            {
                MessageBox.Show("报告日期不能大于今天！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateApparatus_report_date.Focus();
                return;
            }
            //判断时间有效性
            if (dateApparatus_accident_management_date.Value.Date < dateApparatus_report_date.Value.Date)
            {
                MessageBox.Show("处理日期不能小于报告日期！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateApparatus_accident_management_date.Focus();
                return;
            }
            //判断时间有效性
            if (dateApparatus_report_date.Value.Date < outputInstorageDate)
            {
                MessageBox.Show("报告日期不能小于销售日期！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            EntityApparatus_quality entity = new EntityApparatus_quality();
            try
            {
                result = -1;

                //如果是添加
                if (dataType == DataType.Insert)
                {
                    entity.Apparatus_output_code = txtApparatus_quality_output_code.Text;
                    entity.Apparatus_accident_conditions = txtApparatus_accident_conditions.Text;
                    entity.Apparatus_accident_management = txtApparatus_accident_management.Text;
                    entity.Apparatus_accident_management_date = dateApparatus_accident_management_date.Value.Date;
                    entity.Apparatus_customer_feedback = txtApparatus_customer_feedback.Text;
                    entity.Apparatus_opinion_leader = txtApparatus_opinion_leader.Text;
                    entity.Apparatus_quality_count = Convert.ToInt32(txtApparatus_quality_count.Text.Trim());
                    entity.Apparatus_qualityt_issued = txtApparatus_qualityt_issued.Text;
                    entity.Apparatus_report_date = dateApparatus_report_date.Value.Date;
                    entity.Apparatus_speaker = txtApparatus_speaker.Text;

                    dataAccess = new DataAccess();
                    dataAccess.Open();

                    MakePrimaryKey primaryKey = new MakePrimaryKey(dataAccess.Connection, dataAccess.Transaction);
                    entity.Apparatus_quality_code = primaryKey.MakeCode("器械质量跟踪");

                    GetData getData = new GetData(dataAccess.Connection);
                    result = getData.InsertApparatus_quality(entity);
                    //处理操作标示
                    EntityOutput_storage outputStorageEntity = new EntityOutput_storage();
                    outputStorageEntity.Operate_type = "1";

                    SearchParameter sp = new SearchParameter();
                    sp.SetValue(":output_code", txtApparatus_quality_output_code.Text);
                    result = getData.UpdateOutput_storage(outputStorageEntity, sp);
                }
                //如果是更新
                else if (dataType == DataType.Update)
                {
                    //给选中行赋值
                    countNum = dgv.SelectedRows[0].Index;

                    entity.Apparatus_output_code = txtApparatus_quality_output_code.Text;
                    entity.Apparatus_accident_conditions = txtApparatus_accident_conditions.Text;
                    entity.Apparatus_accident_management = txtApparatus_accident_management.Text;
                    entity.Apparatus_accident_management_date = dateApparatus_accident_management_date.Value.Date;
                    entity.Apparatus_customer_feedback = txtApparatus_customer_feedback.Text;
                    entity.Apparatus_opinion_leader = txtApparatus_opinion_leader.Text;
                    entity.Apparatus_quality_count = Convert.ToInt32(txtApparatus_quality_count.Text.Trim());
                    entity.Apparatus_qualityt_issued = txtApparatus_qualityt_issued.Text;
                    entity.Apparatus_report_date = dateApparatus_report_date.Value.Date;
                    entity.Apparatus_speaker = txtApparatus_speaker.Text;
                    entity.Apparatus_quality_code = dgv.SelectedRows[0].Cells["Apparatus_quality_code"].Value.ToString();

                    dataAccess = new DataAccess();
                    dataAccess.Open();
                    dataAccess.BeginTransaction();

                    GetData getData = new GetData(dataAccess.Connection, dataAccess.Transaction);
                    //取得结果符
                    result = getData.UpdateApparatus_quality(entity);
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
                MessageBox.Show("数据保存时发生错误，请检查数据库！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        //***********************************************************************
        /// <summary>
        /// 删除按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：李梓楠      2010/7/26 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
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
                    sp.SetValue(":Apparatus_quality_code", dgv.SelectedRows[0].Cells["Apparatus_quality_code"].Value.ToString());

                    dataAccess = new DataAccess();
                    dataAccess.Open();
                    dataAccess.BeginTransaction();
                    GetData getData = new GetData(dataAccess.Connection, dataAccess.Transaction);

                    result = getData.DeleteRow("tc_apparatus_quality", sp);

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
                    if (!updateMark())
                    {
                        try
                        {
                            dataAccess = new DataAccess();
                            dataAccess.Open();
                            GetData getData = new GetData(dataAccess.Connection);
                            //处理操作标示
                            EntityOutput_storage outputStorageEntity = new EntityOutput_storage();
                            outputStorageEntity.Operate_type = "0";

                            SearchParameter sp = new SearchParameter();
                            sp.SetValue(":output_code", txtApparatus_quality_output_code.Text);
                            result = getData.UpdateOutput_storage(outputStorageEntity, sp);
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
        ///    完成信息：李梓楠      2010/7/26 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dataType = DataType.None;
            setButtonState();
            if (dgv != null && dgv.SelectedRows.Count != 0)
            {
                txtApparatus_quality_output_code.Text = dgv.SelectedRows[0].Cells["Apparatus_quality_output_code"].Value.ToString();
                txtApparatus_quality_count.Text = dgv.SelectedRows[0].Cells["Apparatus_quality_count"].Value.ToString();
                txtApparatus_qualityt_issued.Text = dgv.SelectedRows[0].Cells["Apparatus_qualityt_issued"].Value.ToString();
                txtApparatus_accident_conditions.Text = dgv.SelectedRows[0].Cells["Apparatus_accident_conditions"].Value.ToString();
                dateApparatus_report_date.Value = DateTime.Parse(dgv.SelectedRows[0].Cells["Apparatus_report_date"].Value.ToString());
                txtApparatus_accident_management.Text = dgv.SelectedRows[0].Cells["Apparatus_accident_management"].Value.ToString();
                dateApparatus_accident_management_date.Value = DateTime.Parse(dgv.SelectedRows[0].Cells["Apparatus_accident_management_date"].Value.ToString());
                txtApparatus_speaker.Text = dgv.SelectedRows[0].Cells["Apparatus_speaker"].Value.ToString();
                txtApparatus_customer_feedback.Text = dgv.SelectedRows[0].Cells["Apparatus_customer_feedback"].Value.ToString();
                txtApparatus_opinion_leader.Text = dgv.SelectedRows[0].Cells["Apparatus_opinion_leader"].Value.ToString();
                txtApparatus_customer_name.Text = dgv.SelectedRows[0].Cells["Apparatus_customer_name"].Value.ToString();
                txtApparatus_goods_name.Text = dgv.SelectedRows[0].Cells["Apparatus_goods_name"].Value.ToString();
                txtApparatus_supplier_name.Text = dgv.SelectedRows[0].Cells["Apparatus_supplier_name"].Value.ToString();
                labelSellcount.Text = ""; 
            }
            dgv.Focus();
        }
        
        
        //双击选择出库编号
        private void txtApparatus_quality_output_code_DoubleClick(object sender, EventArgs e)
        {
            if (dataType == DataType.Insert)
            {
                sellStorageDialogForm child = new sellStorageDialogForm();
                child.ShowDialog();
                int sum = 0;
                if (child.outputCode != string.Empty)
                {
                    try
                    {
                        SearchParameter sp = new SearchParameter();

                        sp.SetValue(":apparatus_output_code", child.outputCode);

                        dataAccess = new DataAccess();
                        dataAccess.Open();

                        GetData getData = new GetData(dataAccess.Connection);
                        DataTable dt = getData.GetTableBySqlStr(Constants.SqlStr.SUM_TC_APPARATUS_QUALITY,sp);
                        if (dt != null && dt.Rows.Count != 0 && dt.Rows[0]["suncount"].ToString() != string.Empty)
                        {
                            sum = int.Parse(dt.Rows[0]["suncount"].ToString());
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
                    
                    txtApparatus_quality_output_code.Text = child.outputCode;
                    txtApparatus_goods_name.Text = child.goodsName;
                    txtApparatus_supplier_name.Text = child.supplierName;
                    txtApparatus_customer_name.Text = child.customerName;
                    outputInstorageDate = child.outputInstorageDate;

                    int i = child.lastCount - sum;
                    labelSellcount.Text = i.ToString();
                    if (dataType == DataType.Update)
                    {
                        labelSellcount.Text = (i + int.Parse(dgv.SelectedRows[0].Cells["apparatus_quality_count"].Value.ToString())).ToString();
                    }
                }
            }
            else return;
        }
        //***********************************************************************
        /// <summary>
        /// 经办人TEXTBOX双击,选择经办人
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：李梓楠      2010/7/26 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void txtApparatus_qualityt_issued_DoubleClick(object sender, EventArgs e)
        {
            if (dataType == DataType.Insert || dataType == DataType.Update)
            {
                StaffForm child = new StaffForm();
                child.ShowDialog();
                if (child.staffName != string.Empty)
                    txtApparatus_qualityt_issued.Text = child.staffName;
            }
            else return;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows != null && dgv.SelectedRows.Count == 1)
            {
                Hashtable ht = new Hashtable();
                ht.Add("apparatus_goods_name", dgv.SelectedRows[0].Cells["apparatus_goods_name"].Value.ToString());
                ht.Add("apparatus_goods_type", dgv.SelectedRows[0].Cells["apparatus_goods_type"].Value.ToString());
                ht.Add("apparatus_maker_name", dgv.SelectedRows[0].Cells["apparatus_maker_name"].Value.ToString());
                ht.Add("apparatus_quality_count", dgv.SelectedRows[0].Cells["apparatus_quality_count"].Value.ToString());
                ht.Add("apparatus_customer_name", dgv.SelectedRows[0].Cells["apparatus_customer_name"].Value.ToString());
                ht.Add("apparatus_input_batch_num", dgv.SelectedRows[0].Cells["apparatus_input_batch_num"].Value.ToString());
                ht.Add("apparatus_accident_conditions", dgv.SelectedRows[0].Cells["apparatus_accident_conditions"].Value.ToString());
                ht.Add("apparatus_speaker", dgv.SelectedRows[0].Cells["apparatus_speaker"].Value.ToString());
                ht.Add("apparatus_report_date", dgv.SelectedRows[0].Cells["apparatus_report_date"].Value.ToString());
                ht.Add("apparatus_customer_feedback", dgv.SelectedRows[0].Cells["apparatus_customer_feedback"].Value.ToString());
                ht.Add("apparatus_opinion_leader", dgv.SelectedRows[0].Cells["apparatus_opinion_leader"].Value.ToString());
                ht.Add("apparatus_accident_management", dgv.SelectedRows[0].Cells["apparatus_accident_management"].Value.ToString());
                ht.Add("apparatus_accident_management_date", dgv.SelectedRows[0].Cells["apparatus_accident_management_date"].Value.ToString());
                ht.Add("apparatus_qualityt_issued", dgv.SelectedRows[0].Cells["apparatus_qualityt_issued"].Value.ToString());

                WeaponQualityPrint weaponQualityPrint = new WeaponQualityPrint(ht);
                weaponQualityPrint.ShowDialog();
            }
            else MessageBox.Show("没有可以打印的数据！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtApparatus_quality_codeSelect.Text = "";
            txtApparatus_goods_nameSelect.Text = "";
        }
        private bool updateMark()
        {
            Boolean mark = false;
            dataAccess = new DataAccess();
            try
            {
                SearchParameter sp = new SearchParameter();
                sp.SetValue(":apparatus_output_code", txtApparatus_quality_output_code.Text);
                dataAccess.Open();
                GetData getData = new GetData(dataAccess.Connection);
                DataTable dt = getData.GetSingleTableByCondition("TC_APPARATUS_QUALITY", sp);
                if (dt.Rows.Count > 0)
                {
                    mark = true;
                    return mark;
                }
                sp.Clear();
                sp.SetValue("output_code", txtApparatus_quality_output_code.Text);
                dataAccess.Open();
                getData = new GetData(dataAccess.Connection);
                dt = getData.GetSingleTableByCondition("TC_INPUT_STORAGE", sp);
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
                if (dataAccess.Connection != null)
                    dataAccess.Close();
            }
            return mark;
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
