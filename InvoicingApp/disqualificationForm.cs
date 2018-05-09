using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using DataAccesses;
using InvoicingUtil;
using System.Text.RegularExpressions;

//***********************************************************************
//* 系统名称	    ：  长白ERP系统
//* 功能模块	    ：  系统信息
//* 功能画面		：  不合格去向记录管理
//* 画面名称	    ：  InitStorageForm
//* 完成年月日      ：  2010/08/06
//* 作者		    ：  吴小科
//* Version		    ：  1.00
//* ---------------------------------------------------------------------
//* 前提		：SQL SERVER,.NetFramework3.0
//***********************************************************************
namespace InvoicingApp
{
    public partial class disqualificationForm : Form
    {
        /// <summary>
        /// 数据库连接句柄
        /// </summary>
        DataAccess dataAccess = null;
        Hashtable htDisqualification;
        /// <summary>
        /// 画面状态
        /// </summary>
        DataType dataType = DataType.None;
        /// <summary>
        /// 返回状态标记
        /// </summary>
        int result1 = -1;
        int result2 = -1;
        int result3 = -1;
        int result5 = -1;
        string flag;
        int count;
        int orderNum;
        /// <summary>
        /// 选择记录的行号
        /// </summary>
        int countNum = 0;
        /// <summary>
        /// 剩余数量
        /// </summary>
        int leftCount = 0;
        /// <summary>
        /// 入库实体类
        /// </summary>
        EntityInput_storage input_storageEntity = null;
        /// <summary>
        /// 临时库存表实体类
        /// </summary>
        EntityTemp_storage temp_storageEntity = null;
        /// <summary>
        /// 不合格产品临时表实体类
        /// </summary>
        EntityDisqualification disqualificationEntity = null;
        /// <summary>
        /// 不合格产品去向记录表实体类
        /// </summary>
        EntityDisqualification_To disqualification_ToEntity = null;
        public disqualificationForm(Hashtable ht)
        {
            this.htDisqualification = ht;
            leftCount =Convert.ToInt32(htDisqualification["undeal_count"]);
            InitializeComponent();
            this.dataGridView_Disqualification.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(239, 243, 251);
        }
        /// <summary>
        /// 画面状态枚举
        /// </summary>
        public enum DataType
        {
            /// <summary>
            /// 返厂
            /// </summary>
            Back = 0x0001,
            /// <summary>
            /// 销毁
            /// </summary>
            Destory = 0x0002,
            /// <summary>
            /// 维修
            /// </summary>
            Mend = 0x0003,
            /// <summary>
            /// 修改
            /// </summary>
            Edit = 0x0004,
            /// <summary>
            /// 默认
            /// </summary>
            None = 0x0005
        }
        //*******************************************************************
        /// <summary>
        /// 设置按钮，文本框状态
        /// </summary>
        /// <history>
        ///     完成信息：吴小科      2010/08/05 完成   
        ///     更新信息：
        /// </history>
        //*******************************************************************
        private void setButtonState()
        {

            switch (dataType)
            {
                case DataType.None:
                    this.labelMAX1.Visible = false;
                    this.labelMax.Visible = false;
                    textBox_deal_address.ReadOnly = true;
                    textBox_disqualification_to_count.Enabled = false;
                    textBox_reamark.ReadOnly = true;
                    dateTimePicker1.Enabled = false;
                    textBox_deal_address.Visible = true;
                    textBox_deal_oper.Visible = true;
                    labelRed1.Visible = true;
                    labelRed2.Visible = true;
                    labelAddress.Visible = true;
                    labelOper.Visible = true;
                    btnBack.Enabled = true;
                    textBox_issued.BackColor = Color.FromArgb(236, 233, 216);
                    textBox_deal_oper.BackColor = Color.FromArgb(236, 233, 216);
                    btnMend.Enabled = true;
                    btnDestory.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnCancel.Enabled = false;
                    btnCommit.Enabled = false;
                    break;
                case DataType.Back:
                    textBox_deal_address.ReadOnly = false;
                    textBox_disqualification_to_count.Enabled = true;
                    textBox_reamark.ReadOnly = false;
                    dateTimePicker1.Enabled = true;
                    labelAddress.Visible = false;
                    labelOper.Visible = false;
                    labelRed1.Visible = false;
                    labelRed2.Visible = false;
                    textBox_deal_address.Visible = false;
                    textBox_deal_oper.Visible = false;
                    textBox_disqualification_to_count.Value = 0;
                    textBox_issued.Text = "双击选择一个经办人...";
                    textBox_deal_oper.Text = "双击选择一个见证人...";
                    textBox_issued.BackColor = Color.FromArgb(255, 255, 255);
                    textBox_deal_oper.BackColor = Color.FromArgb(255, 255, 255);
                    textBox_reamark.Text = "";
                    textBox_deal_address.Text = "";
                   
                    btnBack.Enabled = false;
                    btnMend.Enabled = false;
                    btnDestory.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnCancel.Enabled = true;
                    btnCommit.Enabled = true;
                    break;
                case DataType.Mend:
                    textBox_deal_address.ReadOnly = false;
                    textBox_disqualification_to_count.Enabled = true;
                    textBox_reamark.ReadOnly = false;
                    dateTimePicker1.Enabled = true;
                    labelAddress.Visible = false;
                    labelOper.Visible = false;
                    labelRed1.Visible = false;
                    labelRed2.Visible = false;
                    textBox_deal_address.Visible = false;
                    textBox_deal_oper.Visible = false;
                    textBox_disqualification_to_count.Value=0;
                    textBox_reamark.Text = "";
                    textBox_deal_address.Text = "";
                    textBox_issued.Text = "双击选择一个经办人...";
                    textBox_deal_oper.Text = "双击选择一个见证人...";
                    textBox_issued.BackColor = Color.FromArgb(255, 255, 255);
                    textBox_deal_oper.BackColor = Color.FromArgb(255, 255, 255);
                    btnBack.Enabled = false;
                    btnMend.Enabled = false;
                    btnDestory.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnCancel.Enabled = true;
                    btnCommit.Enabled = true;
                    break;
                case DataType.Destory:
                    textBox_deal_address.ReadOnly = false;
                    textBox_disqualification_to_count.Enabled= true;
                    textBox_reamark.ReadOnly = false;
                    dateTimePicker1.Enabled = true;
                    labelAddress.Visible = true;
                    labelOper.Visible = true;
                    textBox_deal_address.Visible = true;
                    textBox_deal_oper.Visible = true;
                    labelRed1.Visible = true;
                    labelRed2.Visible = true;
                    textBox_disqualification_to_count.Value = 0;
                    textBox_reamark.Text = "";
                    textBox_deal_address.Text = "";
                    textBox_issued.Text = "双击选择一个经办人...";
                    textBox_deal_oper.Text = "双击选择一个见证人...";
                    textBox_issued.BackColor = Color.FromArgb(255, 255, 255);
                    textBox_deal_oper.BackColor = Color.FromArgb(255, 255, 255);
                    btnBack.Enabled = false;
                    btnMend.Enabled = false;
                    btnDestory.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnCancel.Enabled = true;
                    btnCommit.Enabled = true;
                    break;
                case DataType.Edit:
                    textBox_disqualification_to_count.Enabled = true;
                    dateTimePicker1.Enabled = true;
                    textBox_reamark.ReadOnly = false;
                    textBox_deal_address.ReadOnly = false;
                    textBox_issued.BackColor = Color.FromArgb(255, 255, 255);
                    textBox_deal_oper.BackColor = Color.FromArgb(255, 255, 255);
                    btnBack.Enabled = false;
                    btnMend.Enabled = false;
                    btnDestory.Enabled = false;
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnCancel.Enabled = true;
                    btnCommit.Enabled = true;
                    break;
                default:
                    textBox_issued.BackColor = Color.FromArgb(236, 233, 216);
                    textBox_deal_oper.BackColor = Color.FromArgb(236, 233, 216);
                    btnBack.Enabled = true;
                    btnMend.Enabled = true;
                    btnDestory.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnCancel.Enabled = false;
                    btnCommit.Enabled = false;
                    break;

            }
        }
        //*******************************************************************
        /// <summary>
        /// 双击文本框弹出不同的选择窗体
        /// </summary>
        /// <history>
        ///     完成信息：吴小科      2010/08/06 完成   
        ///     更新信息：
        /// </history>
        //*******************************************************************

        private void textBox_DoubleClick(object sender, EventArgs e)
        {
            switch (((TextBox)sender).Name)
            {
                //双击文本框弹出弹出员工信息窗体
                case "textBox_issued":
                    {
                        //判断当前页面的状态
                        if (dataType != DataType.None)
                        {
                            StaffForm child = new StaffForm();
                            child.ShowDialog();
                            //获取员工信息
                            if (!child.staffName.Equals(string.Empty))
                            {
                                textBox_issued.Text = child.staffName;
                            }
                        }
                        break;

                    }
                //双击文本框弹出弹出员工信息窗体
                case "textBox_deal_oper":
                    {
                        //判断当前页面的状态
                        if (dataType != DataType.None)
                        {
                            StaffForm child = new StaffForm();
                            child.ShowDialog();
                            //获取员工信息
                            if (!child.staffName.Equals(string.Empty))
                            {
                                textBox_deal_oper.Text = child.staffName;
                            }
                        }
                        break;
                    }

            }
        }
        //*******************************************************************
        /// <summary>
        /// 绑定画面
        /// </summary>
        /// <history>
        ///     完成信息：吴小科      2010/08/05 完成   
        ///     更新信息：
        /// </history>
        //*******************************************************************
        private void BandingDgvCounter()
        {
            
            try
            {
                //打开数据库
                dataAccess = new DataAccess();
                dataAccess.Open();
                //获取操作类
                GetData getData = new GetData(dataAccess.Connection);
                //设置加载条件
                SearchParameter sp = new SearchParameter();
                sp.SetValue(":TC_DISQUALIFICATION_TO.DISQUALIFICATION_CODE", htDisqualification["disqualification_code"]);
                //获取绑定数据表
                DataTable dtDisqualification = getData.GetTableBySqlStr(Constants.SqlStr.TC_DISQUALIFICATION_TO, sp);
                //添加序列号
                int countNumber = 0;
                dtDisqualification.Columns.Add("num", typeof(int));
                for (int i = 0; i < dtDisqualification.Rows.Count; i++)
                {
                    dtDisqualification.Rows[i]["num"] = ++countNumber;

                }
                //绑定数据
                dataGridView_Disqualification.DataSource = dtDisqualification;
                if (dtDisqualification.Rows.Count!=0)
                {
                    leftCount = Convert.ToInt32(dataGridView_Disqualification.SelectedRows[0].Cells["undeal_count"].Value.ToString());
                    
                }
                if (dtDisqualification != null && dataGridView_Disqualification.Rows.Count > 0 && countNum != 0)
                {
                    dataGridView_Disqualification.Rows[0].Selected = false;
                    dataGridView_Disqualification.Rows[countNum].Selected = true;
                    dataGridView_Disqualification.FirstDisplayedScrollingRowIndex = countNum;
                }
                if (dtDisqualification.Rows.Count == 0)
                {
                    dataGridClear();
                }
                this.labelMax.Text = leftCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("请查看数据库是否正常！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {   //关闭数据库
                dataAccess.Close();
            }

        }
            //***********************************************************************
        /// <summary>
        /// 清理画面数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/09/01 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void dataGridClear()
        {
            textBox_disqualification_to_count.Value = 0;
            textBox_deal_type.Text = "";
            dateTimePicker1.Value = DateTime.Now.Date;
            textBox_issued.Text = "";
            textBox_reamark.Text = "";
            textBox_deal_address.Text = "";
            textBox_deal_oper.Text = "";
        }
        //*******************************************************************
        /// <summary>
        /// 不合格去向记录页面初始化
        /// </summary>
        /// <history>
        ///     完成信息：吴小科      2010/08/05 完成   
        ///     更新信息：
        /// </history>
        //*******************************************************************
        private void disqualificationForm_Load(object sender, EventArgs e)
        {
            //comboBox1.Items.Insert(0, "选择一种处理方式");
            //comboBox1.SelectedIndex = 0;
            BandingDgvCounter();
            dataType = DataType.None;
            setButtonState();
            try
            {
                textBox_deal_type.Text = dataGridView_Disqualification.SelectedRows[0].Cells["disqualification_type"].Value.ToString();
                if (!textBox_deal_type.Text.Equals("销毁"))
                {
                    labelAddress.Visible = false;
                    labelOper.Visible = false;
                    labelRed1.Visible = false;
                    labelRed2.Visible = false;
                    textBox_deal_address.Visible = false;
                    textBox_deal_oper.Visible = false;
                }
                count = Convert.ToInt32(dataGridView_Disqualification.SelectedRows[0].Cells["disqualification_to_count"].Value.ToString());
                this.labelMax.Text = (leftCount + count).ToString();
            }
            catch (Exception ex)
            {
                textBox_deal_type.Text = "";
                count = 0;
                this.labelMax.Text = count.ToString();
            }
        }
        //***********************************************************************
        /// <summary>
        /// 查询按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/08/05 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        //private void btnSearch_Click(object sender, EventArgs e)
        //{
        //    foreach (Control control in groupBox1.Controls)
        //    {
        //        if (control is TextBox)
        //        {
        //            if (Util.CheckRegex(control.Text.Trim()) && !((TextBox)control).ReadOnly)
        //            {
        //                MessageBox.Show("不可以输入非法字符，请重新输入！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                control.Focus();
        //                return;
        //            }
        //        }
        //    }
        //    SearchParameter sp = new SearchParameter();
        //    if (!textBox_goods_name.Text.Trim().Equals(string.Empty))
        //    {
        //        sp.SetValue(":TC_GOODS.GOODS_NAME", textBox_goods_name.Text);
        //    }
        //    if (!textBox_goods_yxm.Text.Trim().Equals(string.Empty))
        //    {
        //        sp.SetValue(":TC_GOODS.GOODS_YXM", textBox_goods_yxm.Text);
        //    }
        //    if (comboBox1.Text.Equals("返厂"))
        //    {
        //        sp.SetValue(":TC_DISQUALIFICATION_TO.DEAL_TYPE", "0");
        //    }
        //    if (comboBox1.Text.Equals("销毁"))
        //    {
        //        sp.SetValue(":TC_DISQUALIFICATION_TO.DEAL_TYPE", "1");
        //    }
        //    if (comboBox1.Text.Equals("维修"))
        //    {
        //        sp.SetValue(":TC_DISQUALIFICATION_TO.DEAL_TYPE", "2");
        //    }
        //    try
        //    {

        //        //打开数据库
        //        dataAccess = new DataAccess();
        //        dataAccess.Open();
        //        //获取操作类
        //        GetData getData = new GetData(dataAccess.Connection);
        //        sp.SetValue(":TC_DISQUALIFICATION_TO.DISQUALIFICATION_CODE", htDisqualification["disqualification_code"]);
        //        //获取绑定数据表
        //        DataTable dtDisqualification = getData.GetTableBySqlStr(Constants.SqlStr.TC_DISQUALIFICATION_TO, sp);
        //        //添加序列号
        //        int countNumber = 0;
        //        dtDisqualification.Columns.Add("num", typeof(int));
        //        for (int i = 0; i < dtDisqualification.Rows.Count; i++)
        //        {
        //            dtDisqualification.Rows[i]["num"] = ++countNumber;

        //        }
        //        if (dtDisqualification == null)
        //        {
        //            MessageBox.Show("请查看数据库是否正常！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            return;
        //        }
        //        //绑定数据
        //        dataGridView_Disqualification.DataSource = dtDisqualification;
        //        if (dtDisqualification.Rows.Count == 0)
        //        {
        //            MessageBox.Show("数据不存在，请查看输入的条件是否正确！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("请查看数据库是否正常！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    finally
        //    {   //关闭数据库
        //        dataAccess.Close();
        //    }

        //}
        //***********************************************************************
        /// <summary>
        /// 取消按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/08/05 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //按钮状态
            dataType = DataType.None;
            setButtonState();
            //判断画面数据不为空
            if (dataGridView_Disqualification != null && dataGridView_Disqualification.SelectedRows.Count != 0)
            {
                //取得数据赋值文本框
                textBox_disqualification_to_count.Value = Convert.ToInt32(dataGridView_Disqualification.SelectedRows[0].Cells["disqualification_to_count"].Value.ToString());
                textBox_deal_type.Text = dataGridView_Disqualification.SelectedRows[0].Cells["disqualification_type"].Value.ToString();
                dateTimePicker1.Value = DateTime.Parse(dataGridView_Disqualification.SelectedRows[0].Cells["deal_date"].Value.ToString());
                textBox_issued.Text = dataGridView_Disqualification.SelectedRows[0].Cells["issued"].Value.ToString();
                textBox_reamark.Text = dataGridView_Disqualification.SelectedRows[0].Cells["reamark"].Value.ToString();
                textBox_deal_address.Text = dataGridView_Disqualification.SelectedRows[0].Cells["deal_address"].Value.ToString();
                textBox_deal_oper.Text = dataGridView_Disqualification.SelectedRows[0].Cells["deal_oper"].Value.ToString();
            }
            else
            {
                textBox_disqualification_to_count.Value = 0;
                textBox_issued.Text = "双击选择一个经办人...";
                textBox_deal_oper.Text = "双击选择一个见证人...";
                textBox_reamark.Text = "";
                textBox_deal_address.Text = "";
            }
            dataGridView_Disqualification.Focus();

        }
        //*******************************************************************
        /// <summary>
        /// 不合格物品去向记录页面数据
        /// </summary>
        /// <history>
        ///     完成信息：吴小科      2010/08/05 完成   
        ///     更新信息：
        /// </history>
        //*******************************************************************
        private void dataGridView_Disqualification_SelectionChanged(object sender, EventArgs e)
        {
            //按钮状态
            dataType = DataType.None;
            setButtonState();
            //判断画面数据不为空
            if (dataGridView_Disqualification != null && dataGridView_Disqualification.SelectedRows.Count != 0)
            {
                //取得数据赋值文本框
                orderNum = Convert.ToInt32(dataGridView_Disqualification.SelectedRows[0].Cells["disqualification_to_code"].Value.ToString());
                textBox_disqualification_to_count.Value =Convert.ToInt32(dataGridView_Disqualification.SelectedRows[0].Cells["disqualification_to_count"].Value.ToString());
                textBox_deal_type.Text = dataGridView_Disqualification.SelectedRows[0].Cells["disqualification_type"].Value.ToString();
                if (!textBox_deal_type.Text.Equals("销毁"))
                {
                    labelAddress.Visible = false;
                    labelOper.Visible = false;
                    labelRed1.Visible = false;
                    labelRed2.Visible = false;
                    textBox_deal_address.Visible = false;
                    textBox_deal_oper.Visible = false;
                 }
                dateTimePicker1.Value = DateTime.Parse(dataGridView_Disqualification.SelectedRows[0].Cells["deal_date"].Value.ToString());
                textBox_issued.Text = dataGridView_Disqualification.SelectedRows[0].Cells["issued"].Value.ToString();
                textBox_reamark.Text = dataGridView_Disqualification.SelectedRows[0].Cells["reamark"].Value.ToString();
                textBox_deal_address.Text = dataGridView_Disqualification.SelectedRows[0].Cells["deal_address"].Value.ToString();
                textBox_deal_oper.Text = dataGridView_Disqualification.SelectedRows[0].Cells["deal_oper"].Value.ToString();
                count = Convert.ToInt32(dataGridView_Disqualification.SelectedRows[0].Cells["disqualification_to_count"].Value.ToString());
                this.labelMax.Text = (leftCount + count).ToString();
            }
        }
        //***********************************************************************
        /// <summary>
        /// 返厂按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/08/06 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.labelMAX1.Visible = true;
            this.labelMax.Visible = true;
            this.labelMax.Text = leftCount.ToString();
            if (leftCount == 0)
            {
                MessageBox.Show("没有未处理的产品！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            dataType = DataType.Back;
            setButtonState();
            this.labelMax.Text = leftCount.ToString();
            disqualification_ToEntity = new EntityDisqualification_To();
            textBox_deal_type.Text = "返厂";
            disqualification_ToEntity.DEAL_TYPE = '0';
            disqualification_ToEntity.DISQUALIFICATION_CODE =Convert.ToInt32(htDisqualification["disqualification_code"]);

        }
        //***********************************************************************
        /// <summary>
        /// 返厂数据操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/08/06 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void BackFactory()
        {
            if (leftCount == 0)
            {
                MessageBox.Show("没有未处理的产品！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            if (textBox_issued.Text.Equals("双击选择一个经办人..."))
            {
                MessageBox.Show("经办人不能为空！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_issued.Focus();
                return;
            }
            if (dateTimePicker1.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("处理日期不可大于今天！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateTimePicker1.Focus();
                return;
            }
            disqualification_ToEntity.DEAL_DATE = dateTimePicker1.Value.Date;
            //判断该字段是否为空
            if (Convert.ToInt32(textBox_disqualification_to_count.Value)==0)
            {
                MessageBox.Show("处理数量不能为0，请重新输入！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_disqualification_to_count.Focus();
                return;
            }
            if (Convert.ToInt32(textBox_disqualification_to_count.Value) > leftCount)
            {
                MessageBox.Show("处理数量不能大于限制数量，请核对后重新输入！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_disqualification_to_count.Focus();
                return;
            }
          
            disqualification_ToEntity.DISQUALIFICATION_TO_COUNT = Convert.ToInt32(textBox_disqualification_to_count.Value);
            DialogResult result = MessageBox.Show("您确定将进行返厂操作吗？", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
           if (result == DialogResult.Cancel)
           {
               return;
           }
         
            disqualification_ToEntity.ISSUED = textBox_issued.Text;
            disqualification_ToEntity.REAMARK = textBox_reamark.Text;

            disqualificationEntity = new EntityDisqualification();
            disqualificationEntity.Deal_Count = disqualification_ToEntity.DISQUALIFICATION_TO_COUNT;
            disqualificationEntity.Undeal_Count = 0 - disqualification_ToEntity.DISQUALIFICATION_TO_COUNT;
            disqualificationEntity.Disqualification_Count = 0;
            //设置更新条件参数
            SearchParameter sp = new SearchParameter();
            sp.SetValue(":disqualification_code", htDisqualification["disqualification_code"]);
            try
            {
                //打开数据库连接
                dataAccess = new DataAccess();
                dataAccess.Open();
                //取得操作类
                GetData getData = new GetData(dataAccess.Connection);
                //取得结果符
                result1 = getData.InsertDisqualification_To(disqualification_ToEntity);
                result2 = getData.UpdateDisqualification_manage_NUM(disqualificationEntity, sp);
                MessageBox.Show("数据已经保存成功！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                //提示错误
                MessageBox.Show("操作数据时发生错误，请检查数据库是否正常开启！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            finally
            {
                //关闭数据库连接
                dataAccess.Close();
                //设置按钮状态
                dataType = DataType.None;
                setButtonState();
                //重新加载画面
                BandingDgvCounter();
            }

 
        }
        //***********************************************************************
        /// <summary>
        /// 销毁按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/08/06 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnDestory_Click(object sender, EventArgs e)
        {
            this.labelMAX1.Visible = true;
            this.labelMax.Visible = true;
            this.labelMax.Text = leftCount.ToString();
            if (leftCount == 0)
            {
                MessageBox.Show("没有未处理的产品！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            //按钮状态
            dataType = DataType.Destory;
            setButtonState();
            this.labelMax.Text = leftCount.ToString();
            disqualification_ToEntity = new EntityDisqualification_To();
            textBox_deal_type.Text = "销毁";
            disqualification_ToEntity.DEAL_TYPE = '1';
            disqualification_ToEntity.DISQUALIFICATION_CODE =Convert.ToInt32(htDisqualification["disqualification_code"]);
          

        }
        //***********************************************************************
        /// <summary>
        /// 销毁数据操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/08/06 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void DestoryOperate()
        {
            if (leftCount == 0)
            {
                MessageBox.Show("没有未处理的产品！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            if (textBox_issued.Text.Equals("双击选择一个经办人..."))
            {
                MessageBox.Show("经办人不能为空！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_issued.Focus();
                return;
            }
            if (textBox_deal_address.Text.Equals(string.Empty))
            {
                MessageBox.Show("处理地点不能为空！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_deal_address.Focus();
                return;

            }
            if (textBox_deal_oper.Text.Equals("双击选择一个见证人..."))
            {
                MessageBox.Show("见证人不能为空！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_deal_oper.Focus();
                return;
            }
            if (dateTimePicker1.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("处理日期不可大于今天！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateTimePicker1.Focus();
                return;
            }
            disqualification_ToEntity.DEAL_DATE = dateTimePicker1.Value.Date;
            //判断该字段是否为空
            if (Convert.ToInt32(textBox_disqualification_to_count.Value) == 0)
            {
                MessageBox.Show("处理数量不能为0，请重新输入！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_disqualification_to_count.Focus();
                return;
            }
            if (Convert.ToInt32(textBox_disqualification_to_count.Value) > leftCount)
            {
                MessageBox.Show("处理数量不能大于限制数量，请核对后重新输入！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_disqualification_to_count.Focus();
                return;
            }

            disqualification_ToEntity.DISQUALIFICATION_TO_COUNT = Convert.ToInt32(textBox_disqualification_to_count.Value);
            DialogResult result = MessageBox.Show("您确定进行销毁操作吗？", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel)
            {
                return;
            }
           
            disqualification_ToEntity.ISSUED = textBox_issued.Text;
            disqualification_ToEntity.DEAL_ADDRESS = textBox_deal_address.Text;
            disqualification_ToEntity.DEAL_OPER = textBox_deal_oper.Text;
            disqualification_ToEntity.REAMARK = textBox_reamark.Text;

            disqualificationEntity = new EntityDisqualification();
            disqualificationEntity.Deal_Count = disqualification_ToEntity.DISQUALIFICATION_TO_COUNT;
            disqualificationEntity.Undeal_Count = 0 - disqualification_ToEntity.DISQUALIFICATION_TO_COUNT;
            disqualificationEntity.Disqualification_Count = 0;
            //设置更新条件参数
            SearchParameter sp = new SearchParameter();
            sp.SetValue(":disqualification_code", htDisqualification["disqualification_code"]);
            try
            {
                //打开数据库连接
                dataAccess = new DataAccess();
                dataAccess.Open();
                //取得操作类
                GetData getData = new GetData(dataAccess.Connection);
                //取得结果符
                result1 = getData.InsertDisqualification_To(disqualification_ToEntity);
                result2 = getData.UpdateDisqualification_manage_NUM(disqualificationEntity, sp);
                MessageBox.Show("数据已经保存成功！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                //提示错误
                MessageBox.Show("操作数据时发生错误，请检查数据库是否正常开启！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                //关闭数据库连接
                dataAccess.Close();

                //设置按钮状态
                dataType = DataType.None;
                setButtonState();

                //重新加载画面
                BandingDgvCounter();
            }
 
        }
        //***********************************************************************
        /// <summary>
        /// 维修按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/08/06 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnMend_Click(object sender, EventArgs e)
        {
            this.labelMAX1.Visible = true;
            this.labelMax.Visible = true;
            this.labelMax.Text = leftCount.ToString();
            if (leftCount == 0)
            {
                MessageBox.Show("没有未处理的产品！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            //按钮状态
            dataType = DataType.Mend;
            setButtonState();
            this.labelMax.Text = leftCount.ToString();
            disqualification_ToEntity = new EntityDisqualification_To();
            textBox_deal_type.Text = "维修";
            disqualification_ToEntity.DEAL_TYPE = '2';
            disqualification_ToEntity.DISQUALIFICATION_CODE =Convert.ToInt32(htDisqualification["disqualification_code"]);
        }
        //***********************************************************************
        /// <summary>
        /// 维修数据操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/08/06 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void MendOperate()
        {
            if (leftCount == 0)
            {
                MessageBox.Show("没有未处理的产品！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            if (textBox_issued.Text.Equals("双击选择一个经办人..."))
            {
                MessageBox.Show("经办人不能为空，请重新选择或输入！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_issued.Focus();
                return;
            }
            if (dateTimePicker1.Value.Date > DateTime.Now.Date)
            {
                MessageBox.Show("处理日期不可大于今天", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateTimePicker1.Focus();
                return;
            }
            disqualification_ToEntity.DEAL_DATE = dateTimePicker1.Value.Date;
            //判断该字段是否为空
            if (Convert.ToInt32(textBox_disqualification_to_count.Value) == 0)
            {
                MessageBox.Show("处理数量不能为0，请重新输入！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_disqualification_to_count.Focus();
                return;
            }
            if (Convert.ToInt32(textBox_disqualification_to_count.Value) > leftCount)
            {
                MessageBox.Show("处理数量不能大于限制数量，请核对后重新输入！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_disqualification_to_count.Focus();
                return;
            }
            disqualification_ToEntity.DISQUALIFICATION_TO_COUNT = Convert.ToInt32(textBox_disqualification_to_count.Value);
            DialogResult result = MessageBox.Show("您确定进行维修操作吗？", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel)
            {
               return;
            }
        
            disqualification_ToEntity.ISSUED = textBox_issued.Text;
            disqualification_ToEntity.REAMARK = textBox_reamark.Text;

            disqualificationEntity = new EntityDisqualification();
            disqualificationEntity.Deal_Count = disqualification_ToEntity.DISQUALIFICATION_TO_COUNT;
            disqualificationEntity.Undeal_Count = 0 - disqualification_ToEntity.DISQUALIFICATION_TO_COUNT;
            disqualificationEntity.Disqualification_Count = 0 - disqualification_ToEntity.DISQUALIFICATION_TO_COUNT;

            temp_storageEntity = new EntityTemp_storage();
            temp_storageEntity.Count = disqualification_ToEntity.DISQUALIFICATION_TO_COUNT;
            SearchParameter sp = new SearchParameter();
            SearchParameter sp1 = new SearchParameter();
            SearchParameter sp2 = new SearchParameter();
            sp.SetValue(":goods_code", htDisqualification["input_goods_code"].ToString());
            input_storageEntity = new EntityInput_storage();
            input_storageEntity.INPUT_STANDARD_COUNT = disqualification_ToEntity.DISQUALIFICATION_TO_COUNT;
            sp1.SetValue("input_code", htDisqualification["input_code"].ToString());
            sp2.SetValue(":disqualification_code", htDisqualification["disqualification_code"]);
            try
            {
                //打开数据库连接
                dataAccess = new DataAccess();
                dataAccess.Open();
                //取得操作类
                GetData getData = new GetData(dataAccess.Connection);
                //取得结果符
                result1 = getData.InsertDisqualification_To(disqualification_ToEntity);
                result2 = getData.UpdateTemp_storage(temp_storageEntity, sp);
                result3 = getData.UpdateInput_storageNUM(input_storageEntity, sp1);
                result5 = getData.UpdateDisqualification_manage_NUM(disqualificationEntity, sp2);
                MessageBox.Show("数据已经保存成功！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                //提示错误
                MessageBox.Show("操作数据时发生错误，请检查数据库是否正常开启！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                //关闭数据库连接
                dataAccess.Close();

                //设置按钮状态
                dataType = DataType.None;
                setButtonState();

                //重新加载画面
                BandingDgvCounter();
            }
 
        }
        //***********************************************************************
        /// <summary>
        /// 确定按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/08/06 完成   
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
            if (textBox_disqualification_to_count.Text == "")
            {
                MessageBox.Show("处理数量不能为空，请重新输入！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_disqualification_to_count.Focus();
                return;
            }
            if (dateTimePicker1.Value.Date <DateTime.Parse(htDisqualification["inStorageDate"].ToString()))
            {
                MessageBox.Show("处理日期不能小于入库日期！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                dateTimePicker1.Focus();
                return;
            }
            //if (leftCount == 0)
            //{
            //    MessageBox.Show("已经没有未处理的产品", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;

            //}
            switch (dataType)
            {
                case DataType.Back:
                    {
                        BackFactory();
                        break;
                    }
                case DataType.Destory:
                    {
                        DestoryOperate();
                        break;
 
                    }
                case DataType.Mend:
                    {
                        MendOperate();
                        break;
 
                    }
                case DataType.Edit:
                    {
                        AllEdit(flag,count);
                        break;
                    }
                default:
                    break;
            }

        }
        //***********************************************************************
        /// <summary>
        /// 修改按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/08/12 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            //如果选择多条数据，提示
            if (dataGridView_Disqualification.SelectedRows.Count > 1)
            {
                MessageBox.Show("只能选择一条要修改的记录！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //如过画面中不存在数据，提示
            if (dataGridView_Disqualification.SelectedRows.Count < 1)
            {
                MessageBox.Show("请选择一条要修改的记录！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (textBox_deal_type.Text.Equals("维修"))
            {
                //设置查询条件参数
                SearchParameter sp = new SearchParameter();
                sp.SetValue(":TC_INPUT_STORAGE.INPUT_CODE", htDisqualification["input_code"].ToString());
                //打开数据库
                dataAccess = new DataAccess();
                dataAccess.Open();
                //获取操作类
                GetData getData = new GetData(dataAccess.Connection);
                //返回绑定数据表
                DataTable dtCondition = getData.GetTableBySqlStr(Constants.SqlStr.TC_DISQUALIFICATION_MANAGER, sp);
                if (dtCondition.Rows[0]["operate_type"].ToString() == "1")
                {
                    MessageBox.Show("该入库单已被使用，不能修改！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            dataType = DataType.Edit;
            setButtonState();
            flag = dataGridView_Disqualification.SelectedRows[0].Cells["disqualification_type"].Value.ToString();
            if (flag.Equals("返厂"))
            {
                labelAddress.Visible = false;
                labelOper.Visible = false;
                textBox_deal_address.Visible = false;
                textBox_deal_oper.Visible = false;
                labelRed1.Visible = false;
                labelRed2.Visible = false;
            }
            if (flag.Equals("维修"))
            {
                labelAddress.Visible = false;
                labelOper.Visible = false;
                textBox_deal_address.Visible = false;
                textBox_deal_oper.Visible = false;
                labelRed1.Visible = false;
                labelRed2.Visible = false;
            }
            if (flag.Equals("销毁"))
            {
                labelAddress.Visible = true;
                labelOper.Visible = true;
                textBox_deal_address.Visible = true;
                textBox_deal_oper.Visible = true;
                labelRed1.Visible = true;
                labelRed2.Visible = true;

            }
            this.labelMAX1.Visible = true;
            this.labelMax.Visible = true;
            count =Convert.ToInt32(dataGridView_Disqualification.SelectedRows[0].Cells["disqualification_to_count"].Value.ToString());
            this.labelMax.Text = (leftCount + count).ToString();
            countNum = dataGridView_Disqualification.SelectedRows[0].Index;

        }
        //***********************************************************************
        /// <summary>
        /// 更新方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/08/12 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void AllEdit(string flag,int oldnum)
       {
           if (flag.Equals("返厂"))
           {
               if (textBox_issued.Text.Equals("双击选择一个经办人..."))
               {
                   MessageBox.Show("经办人不能为空！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                   textBox_issued.Focus();
                   return;
               }
               disqualification_ToEntity = new EntityDisqualification_To();
               if (dateTimePicker1.Value.Date > DateTime.Now.Date)
               {
                   MessageBox.Show("处理日期日期不可大于今天！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                   dateTimePicker1.Focus();
                   return;
               }
               disqualification_ToEntity.DEAL_DATE = dateTimePicker1.Value.Date;
               //判断该字段是否为空
               if (Convert.ToInt32(textBox_disqualification_to_count.Value) == 0)
               {
                   MessageBox.Show("处理数量不能为0，请重新输入！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                   textBox_disqualification_to_count.Focus();
                   return;
               }
               if (Convert.ToInt32(textBox_disqualification_to_count.Value) > Convert.ToInt32(this.labelMax.Text))
               {
                   MessageBox.Show("处理数量不能大于限制数量，请核对后重新输入！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                   textBox_disqualification_to_count.Focus();
                   return;
               }

               disqualification_ToEntity.DISQUALIFICATION_TO_COUNT = Convert.ToInt32(textBox_disqualification_to_count.Value);
               DialogResult result = MessageBox.Show("您确定进行返厂操作吗？", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
               if (result == DialogResult.Cancel)
               {
                   return;
               }
            
               disqualification_ToEntity.ISSUED = textBox_issued.Text;
               disqualification_ToEntity.REAMARK = textBox_reamark.Text;

               disqualificationEntity = new EntityDisqualification();
               disqualificationEntity.Deal_Count = disqualification_ToEntity.DISQUALIFICATION_TO_COUNT-oldnum;
               disqualificationEntity.Undeal_Count = oldnum - disqualification_ToEntity.DISQUALIFICATION_TO_COUNT;
               disqualificationEntity.Disqualification_Count = 0;
               //设置更新条件参数
               SearchParameter sp = new SearchParameter();
               SearchParameter sp1 = new SearchParameter();
               sp.SetValue(":disqualification_code", htDisqualification["disqualification_code"]);
               sp1.SetValue(":disqualification_to_code", orderNum);
               try
               {
                   //打开数据库连接
                   dataAccess = new DataAccess();
                   dataAccess.Open();
                   //取得操作类
                   GetData getData = new GetData(dataAccess.Connection);
                   //取得结果符
                   result1 = getData.UpdateDisqualification_to(disqualification_ToEntity,sp1);
                   result2 = getData.UpdateDisqualification_manage_NUM(disqualificationEntity, sp);
                   MessageBox.Show("数据已经保存成功！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
               catch (Exception ex)
               {
                   //提示错误
                   MessageBox.Show("操作数据时发生错误，请检查数据库是否正常开启！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

               }
               finally
               {
                   //关闭数据库连接
                   dataAccess.Close();

                   //设置按钮状态
                   dataType = DataType.None;
                   setButtonState();

                   //重新加载画面
                   BandingDgvCounter();
               }

 
           }
           if (flag.Equals("销毁"))
           {
               if (textBox_issued.Text.Equals("双击选择一个经办人..."))
               {
                   MessageBox.Show("经办人不能为空！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                   textBox_issued.Focus();
                   return;
               }
               if (textBox_deal_address.Text.Equals(string.Empty))
               {
                   MessageBox.Show("处理地点不能为空！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                   textBox_deal_address.Focus();
                   return;
               }
               if (textBox_deal_oper.Text.Equals("双击选择一个见证人..."))
               {
                   MessageBox.Show("见证人不能为空！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                   textBox_deal_oper.Focus();
                   return;
               }
               disqualification_ToEntity = new EntityDisqualification_To();
               if (dateTimePicker1.Value.Date > DateTime.Now.Date)
               {
                   MessageBox.Show("处理日期不能大于今天！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                   dateTimePicker1.Focus();
                   return;
               }
               disqualification_ToEntity.DEAL_DATE = dateTimePicker1.Value.Date;
               //判断该字段是否为空
               if (Convert.ToInt32(textBox_disqualification_to_count.Value) == 0)
               {
                   MessageBox.Show("处理数量不能为0，请重新输入！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                   textBox_disqualification_to_count.Focus();
                   return;
               }
               if (Convert.ToInt32(textBox_disqualification_to_count.Value) > Convert.ToInt32(this.labelMax.Text))
               {
                   MessageBox.Show("处理数量不能大于限制数量，请核对后重新输入！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                   textBox_disqualification_to_count.Focus();
                   return;
               }

               disqualification_ToEntity.DISQUALIFICATION_TO_COUNT = Convert.ToInt32(textBox_disqualification_to_count.Value);
               DialogResult result = MessageBox.Show("您确定进行销毁操作吗？", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
               if (result == DialogResult.Cancel)
               {
                   return;
               }
              
               disqualification_ToEntity.ISSUED = textBox_issued.Text;
               disqualification_ToEntity.DEAL_ADDRESS = textBox_deal_address.Text;
               disqualification_ToEntity.DEAL_OPER = textBox_deal_oper.Text;
               disqualification_ToEntity.REAMARK = textBox_reamark.Text;

               disqualificationEntity = new EntityDisqualification();
               disqualificationEntity.Deal_Count = disqualification_ToEntity.DISQUALIFICATION_TO_COUNT-oldnum;
               disqualificationEntity.Undeal_Count = oldnum - disqualification_ToEntity.DISQUALIFICATION_TO_COUNT;
               disqualificationEntity.Disqualification_Count = 0;
               //设置更新条件参数
               SearchParameter sp = new SearchParameter();
               SearchParameter sp1 = new SearchParameter();
               sp.SetValue(":disqualification_code", htDisqualification["disqualification_code"]);
               sp1.SetValue(":disqualification_to_code", orderNum);
               try
               {
                   //打开数据库连接
                   dataAccess = new DataAccess();
                   dataAccess.Open();
                   //取得操作类
                   GetData getData = new GetData(dataAccess.Connection);
                   //取得结果符
                   result1 = getData.UpdateDisqualification_to(disqualification_ToEntity,sp1);
                   result2 = getData.UpdateDisqualification_manage_NUM(disqualificationEntity, sp);
                   MessageBox.Show("数据已经保存成功！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
               catch (Exception ex)
               {
                   //提示错误
                   MessageBox.Show("操作数据时发生错误，请检查数据库是否正常开启！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

               }
               finally
               {
                   //关闭数据库连接
                   dataAccess.Close();

                   //设置按钮状态
                   dataType = DataType.None;
                   setButtonState();

                   //重新加载画面
                   BandingDgvCounter();
               }

               
 
           }
           if (flag.Equals("维修"))
           {
               if (textBox_issued.Text.Equals("双击选择一个经办人..."))
               {
                   MessageBox.Show("经办人不能为空！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                   textBox_issued.Focus();
                   return;
               }
               disqualification_ToEntity = new EntityDisqualification_To();
               if (dateTimePicker1.Value.Date > DateTime.Now.Date)
               {
                   MessageBox.Show("处理日期不能大于今天", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                   dateTimePicker1.Focus();
                   return;
               }
               disqualification_ToEntity.DEAL_DATE = dateTimePicker1.Value.Date;
               //判断该字段是否为空
               if (Convert.ToInt32(textBox_disqualification_to_count.Value) == 0)
               {
                   MessageBox.Show("处理数量不能为0，请重新输入！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                   textBox_disqualification_to_count.Focus();
                   return;
               }
               if (Convert.ToInt32(textBox_disqualification_to_count.Value) > Convert.ToInt32(this.labelMax.Text))
               {
                   MessageBox.Show("处理数量不能大于限制数量，请核对后重新输入！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                   textBox_disqualification_to_count.Focus();
                   return;
               }
               disqualification_ToEntity.DISQUALIFICATION_TO_COUNT = Convert.ToInt32(textBox_disqualification_to_count.Value);
               DialogResult result = MessageBox.Show("您确定进行维修操作吗？", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
               if (result == DialogResult.Cancel)
               {
                   return;
               }
              
               disqualification_ToEntity.ISSUED = textBox_issued.Text;
               disqualification_ToEntity.REAMARK = textBox_reamark.Text;

               disqualificationEntity = new EntityDisqualification();
               disqualificationEntity.Deal_Count = disqualification_ToEntity.DISQUALIFICATION_TO_COUNT-oldnum;
               disqualificationEntity.Undeal_Count = oldnum - disqualification_ToEntity.DISQUALIFICATION_TO_COUNT;
               disqualificationEntity.Disqualification_Count = oldnum - disqualification_ToEntity.DISQUALIFICATION_TO_COUNT;

               temp_storageEntity = new EntityTemp_storage();
               temp_storageEntity.Count = disqualification_ToEntity.DISQUALIFICATION_TO_COUNT-oldnum;
               SearchParameter sp = new SearchParameter();
               SearchParameter sp1 = new SearchParameter();
               SearchParameter sp2 = new SearchParameter();
               SearchParameter sp3 = new SearchParameter();
               sp.SetValue(":goods_code", htDisqualification["input_goods_code"].ToString());
               input_storageEntity = new EntityInput_storage();
               input_storageEntity.INPUT_STANDARD_COUNT = disqualification_ToEntity.DISQUALIFICATION_TO_COUNT-oldnum;
               sp1.SetValue("input_code", htDisqualification["input_code"].ToString());
               sp2.SetValue(":disqualification_code", htDisqualification["disqualification_code"]);
               sp3.SetValue(":disqualification_to_code", orderNum);
               try
               {
                   //打开数据库连接
                   dataAccess = new DataAccess();
                   dataAccess.Open();
                   //取得操作类
                   GetData getData = new GetData(dataAccess.Connection);
                   //取得结果符
                   result1 = getData.UpdateDisqualification_to(disqualification_ToEntity,sp3);
                   result2 = getData.UpdateTemp_storage(temp_storageEntity, sp);
                   result3 = getData.UpdateInput_storageNUM(input_storageEntity, sp1);
                   result5 = getData.UpdateDisqualification_manage_NUM(disqualificationEntity, sp2);
                   MessageBox.Show("数据已经保存成功！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
               }
               catch (Exception ex)
               {
                   //提示错误
                   MessageBox.Show("操作数据时发生错误，请检查数据库是否正常开启！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

               }
               finally
               {
                   //关闭数据库连接
                   dataAccess.Close();

                   //设置按钮状态
                   dataType = DataType.None;
                   setButtonState();

                   //重新加载画面
                   BandingDgvCounter();
               }

           }

       }
        //***********************************************************************
        /// <summary>
        /// 删除按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/08/12 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnDelete_Click(object sender, EventArgs e)
        {
            countNum = 0;
            //如果选择多条数据，提示
            if (dataGridView_Disqualification.SelectedRows.Count > 1)
            {
                MessageBox.Show("只能选择一条要删除的记录！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //如过画面中不存在数据，提示
            if (dataGridView_Disqualification.SelectedRows.Count < 1)
            {
                MessageBox.Show("请选择一条要删除的记录！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dataType = DataType.None;
            setButtonState();
            if (textBox_deal_type.Text.Equals("维修"))
            {
                //设置查询条件参数
                SearchParameter sp = new SearchParameter();
                sp.SetValue(":TC_INPUT_STORAGE.INPUT_CODE", htDisqualification["input_code"].ToString());
                //打开数据库
                dataAccess = new DataAccess();
                dataAccess.Open();
                //获取操作类
                GetData getData = new GetData(dataAccess.Connection);
                //返回绑定数据表
                DataTable dtCondition = getData.GetTableBySqlStr(Constants.SqlStr.TC_DISQUALIFICATION_MANAGER, sp);
                if (dtCondition.Rows[0]["operate_type"].ToString() == "1")
                {
                    MessageBox.Show("该入库单已被使用，不能删除！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            flag = dataGridView_Disqualification.SelectedRows[0].Cells["disqualification_type"].Value.ToString();
            count = Convert.ToInt32(dataGridView_Disqualification.SelectedRows[0].Cells["disqualification_to_count"].Value.ToString());
            leftCount = (leftCount + count);
            if (flag.Equals("返厂"))
            {
                labelAddress.Visible = false;
                labelOper.Visible = false;
                textBox_deal_address.Visible = false;
                textBox_deal_oper.Visible = false;
                labelRed1.Visible = false;
                labelRed2.Visible = false;
                  //如果选择数据删除，提示
                if (MessageBox.Show("您确定要删除该数据吗？", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    disqualificationEntity = new EntityDisqualification();
                    disqualificationEntity.Deal_Count = 0-count;
                    disqualificationEntity.Undeal_Count = count;
                    disqualificationEntity.Disqualification_Count = 0;
                    //设置更新条件参数
                    SearchParameter sp2 = new SearchParameter();
                    SearchParameter sp1 = new SearchParameter();
                    sp2.SetValue(":disqualification_code", htDisqualification["disqualification_code"]);
                    sp1.SetValue(":disqualification_to_code", orderNum);
                    try
                    {
                        dataAccess = new DataAccess();
                        //打开数据库连接
                        dataAccess.Open();
                        //打开事务
                        dataAccess.BeginTransaction();
                        //取得操作类
                        GetData getData1 = new GetData(dataAccess.Connection,dataAccess.Transaction);
                        //取得结果符
                        result1 = getData1.DeleteRow("tc_disqualification_to", sp1);
                        result2 = getData1.UpdateDisqualification_manage_NUM(disqualificationEntity, sp2);
                        //提交事务
                        dataAccess.Commit();               
                    }
                    catch (Exception ex)
                    {
                        //回滚
                        dataAccess.Rollback();
                        //提示错误
                        MessageBox.Show("操作数据时发生错误，请检查数据库是否正常开启！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    finally
                    {
                        //关闭数据库连接
                        dataAccess.Close();

                    }
                    //判断结果符，0：成功；-1：失败
                    if (result1 == 0 && result2 == 0)
                    {

                        //加载画面
                        BandingDgvCounter();
                        MessageBox.Show("数据已经被成功删除！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("操作数据时发生错误，请检查数据库是否正常开启！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }              

                }
            }
            if (flag.Equals("维修"))
            {
                labelAddress.Visible = false;
                labelOper.Visible = false;
                textBox_deal_address.Visible = false;
                textBox_deal_oper.Visible = false;
                labelRed1.Visible = false;
                labelRed2.Visible = false;
                //如果选择数据删除，提示
                if (MessageBox.Show("您确定要删除该数据吗？", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    disqualificationEntity = new EntityDisqualification();
                    disqualificationEntity.Deal_Count = 0 - count;
                    disqualificationEntity.Undeal_Count = count;
                    disqualificationEntity.Disqualification_Count = count;
                    //设置更新条件参数
                    temp_storageEntity = new EntityTemp_storage();
                    temp_storageEntity.Count = 0-count;
                    SearchParameter sp5 = new SearchParameter();
                    SearchParameter sp1 = new SearchParameter();
                    SearchParameter sp2 = new SearchParameter();
                    SearchParameter sp3 = new SearchParameter();
                    sp5.SetValue(":goods_code", htDisqualification["input_goods_code"].ToString());
                    input_storageEntity = new EntityInput_storage();
                    input_storageEntity.INPUT_STANDARD_COUNT = 0 - count;
                    sp1.SetValue("input_code", htDisqualification["input_code"].ToString());
                    sp2.SetValue(":disqualification_code", htDisqualification["disqualification_code"]);
                    sp3.SetValue(":disqualification_to_code", orderNum);
                    try
                    {
                        //打开数据库连接
                        dataAccess = new DataAccess();
                        dataAccess.Open();
                        //打开事务
                        dataAccess.BeginTransaction();
                        //取得操作类
                        GetData getData1 = new GetData(dataAccess.Connection, dataAccess.Transaction);
                        //取得结果符
                        result1 = getData1.DeleteRow("tc_disqualification_to", sp3);
                        result2 = getData1.UpdateTemp_storage(temp_storageEntity, sp5);
                        result3 = getData1.UpdateInput_storageNUM(input_storageEntity, sp1);
                        result5 = getData1.UpdateDisqualification_manage_NUM(disqualificationEntity, sp2);
                        //提交事务
                        dataAccess.Commit();
                    }
                    catch (Exception ex)
                    {
                        //回滚
                        dataAccess.Rollback();
                        //提示错误
                        MessageBox.Show("操作数据时发生错误，请检查数据库是否正常开启！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    finally
                    {
                        //关闭数据库连接
                        dataAccess.Close();
                    }
                    //判断结果符，0：成功；-1：失败
                    if (result1 == 0 && result2 == 0 && result3 == 0 && result5 == 0)
                    {

                        //加载画面
                        BandingDgvCounter();
                        MessageBox.Show("数据已经被成功删除！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("操作数据时发生错误，请检查数据库是否正常开启！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }      


                }
            }
            if (flag.Equals("销毁"))
            {
                labelAddress.Visible = true;
                labelOper.Visible = true;
                textBox_deal_address.Visible = true;
                textBox_deal_oper.Visible = true;
                labelRed1.Visible = true;
                labelRed2.Visible = true;
                //如果选择数据删除，提示
                if (MessageBox.Show("您确定要删除该数据吗？", this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    disqualificationEntity = new EntityDisqualification();
                    disqualificationEntity.Deal_Count = 0 - count;
                    disqualificationEntity.Undeal_Count = count;
                    disqualificationEntity.Disqualification_Count = 0;
                    //设置更新条件参数
                    SearchParameter sp2 = new SearchParameter();
                    SearchParameter sp1 = new SearchParameter();
                    sp2.SetValue(":disqualification_code", htDisqualification["disqualification_code"]);
                    sp1.SetValue(":disqualification_to_code", orderNum);
                    try
                    {
                        dataAccess = new DataAccess();
                        //打开数据库连接
                        dataAccess.Open();
                        //打开事务
                        dataAccess.BeginTransaction();
                        //取得操作类
                        GetData getData1 = new GetData(dataAccess.Connection, dataAccess.Transaction);
                        //取得结果符
                        result1 = getData1.DeleteRow("tc_disqualification_to", sp1);
                        result2 = getData1.UpdateDisqualification_manage_NUM(disqualificationEntity, sp2);
                        //提交事务
                        dataAccess.Commit();
                    }
                    catch (Exception ex)
                    {
                        //回滚
                        dataAccess.Rollback();
                        //提示错误
                        MessageBox.Show("操作数据时发生错误，请检查数据库是否正常开启！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    finally
                    {
                        //关闭数据库连接
                        dataAccess.Close();

                    }
                    //判断结果符，0：成功；-1：失败
                    if (result1 == 0 && result2 == 0)
                    {

                        //加载画面
                        BandingDgvCounter();
                        MessageBox.Show("数据已经被成功删除！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("操作数据时发生错误，请检查数据库是否正常开启！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }         
                }
            }
        }
        //private void btnReset_Click(object sender, EventArgs e)
        //{
        //    textBox_goods_name.Text = "";
        //    textBox_goods_yxm.Text = "";
        //    comboBox1.SelectedIndex = 0;
        //}
        //*******************************************************************
        /// <summary>
        /// 不合格物品去向记录页面加载数据
        /// </summary>
        /// <history>
        ///     完成信息：吴小科      2010/08/30 完成   
        ///     更新信息：
        /// </history>
        //*******************************************************************
        private void dataGridView_Disqualification_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //按钮状态
            dataType = DataType.None;
            setButtonState();
            //判断画面数据不为空
            if (dataGridView_Disqualification != null && dataGridView_Disqualification.SelectedRows.Count != 0)
            {
                //取得数据赋值文本框
                orderNum = Convert.ToInt32(dataGridView_Disqualification.SelectedRows[0].Cells["disqualification_to_code"].Value.ToString());
                textBox_disqualification_to_count.Value = Convert.ToInt32(dataGridView_Disqualification.SelectedRows[0].Cells["disqualification_to_count"].Value.ToString());
                textBox_deal_type.Text = dataGridView_Disqualification.SelectedRows[0].Cells["disqualification_type"].Value.ToString();
                if (!textBox_deal_type.Text.Equals("销毁"))
                {
                    labelAddress.Visible = false;
                    labelOper.Visible = false;
                    labelRed1.Visible = false;
                    labelRed2.Visible = false;
                    textBox_deal_address.Visible = false;
                    textBox_deal_oper.Visible = false;
                }
                dateTimePicker1.Value = DateTime.Parse(dataGridView_Disqualification.SelectedRows[0].Cells["deal_date"].Value.ToString());
                textBox_issued.Text = dataGridView_Disqualification.SelectedRows[0].Cells["issued"].Value.ToString();
                textBox_reamark.Text = dataGridView_Disqualification.SelectedRows[0].Cells["reamark"].Value.ToString();
                textBox_deal_address.Text = dataGridView_Disqualification.SelectedRows[0].Cells["deal_address"].Value.ToString();
                textBox_deal_oper.Text = dataGridView_Disqualification.SelectedRows[0].Cells["deal_oper"].Value.ToString();
                count = Convert.ToInt32(dataGridView_Disqualification.SelectedRows[0].Cells["disqualification_to_count"].Value.ToString());
                this.labelMax.Text = (leftCount + count).ToString();
            }
        }
        //***********************************************************************
        /// <summary>
        /// 数量验证
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/09/03 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void textBox_disqualification_to_count_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox_disqualification_to_count.Value.ToString().Length > 4)
            {
                textBox_disqualification_to_count.Value = 9999;

            }

        }
        //***********************************************************************
        /// <summary>
        /// 序号重新排列
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/09/10 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void dataGridView_Disqualification_Sorted(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView_Disqualification.Rows.Count; i++)
            {
                dataGridView_Disqualification.Rows[i].Cells["num"].Value = i + 1;
            }
        }

    }
}
