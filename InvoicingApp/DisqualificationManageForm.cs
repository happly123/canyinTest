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
//***********************************************************************
//* 系统名称	    ：  长白ERP系统
//* 功能模块	    ：  系统信息
//* 功能画面		：  不合格物品管理
//* 画面名称	    ：  InitStorageForm
//* 完成年月日      ：  2010/08/04
//* 作者		    ：  吴小科
//* Version		    ：  1.00
//* ---------------------------------------------------------------------
//* 前提		：SQL SERVER,.NetFramework3.0
//***********************************************************************
namespace InvoicingApp
{
    //***********************************************************************
    /// <summary>
    ///不合格物品管理功能
    /// </summary>
    /// <history>
    ///     完成信息：吴小科      2010/08/04 完成  
    ///     更新信息：
    /// </history>
    //***********************************************************************
    public partial class DisqualificationManageForm : Form
    {
        private int countNum = 0;
        /// <summary>
        /// 数据库连接句柄
        /// </summary>
        DataAccess dataAccess = null;

        DataTable dtPrint;
        public DisqualificationManageForm()
        {
            InitializeComponent();
            this.dataGridView_Disqualification.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(239, 243, 251);
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }
        //***********************************************************************
        /// <summary>
        /// 数据重新加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/08/30 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        public void DataBanding()
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
                //获取绑定数据表
                DataTable dtDisqualification = getData.GetTableBySqlStr(Constants.SqlStr.TC_DISQUALIFICATION_MANAGER, sp);
                //添加序列号
                int countNumber = 0;
                dtDisqualification.Columns.Add("num", typeof(int));
                dtDisqualification.Columns.Add("back", typeof(string));
                dtDisqualification.Columns.Add("destroy", typeof(string));
                dtDisqualification.Columns.Add("edit", typeof(string));
                dtDisqualification.Columns.Add("disqualificationNum", typeof(int));
                DataTable dtDisqualificationTo = getData.GetSingleTable("tc_disqualification_To");
                for (int i = 0; i < dtDisqualification.Rows.Count; i++)
                {
                    dtDisqualification.Rows[i]["num"] = ++countNumber;
                    DataRow[] drs = dtDisqualificationTo.Select("disqualification_code = " + dtDisqualification.Rows[i]["disqualification_code"]);
                    int back = 0;
                    int destroy = 0;
                    int edit = 0;
                    if (drs.Length > 0)
                    {
                        for (int j = 0; j < drs.Length; j++)
                        {
                            if (drs[j]["deal_type"].ToString().Equals("0"))
                            {
                                back += int.Parse(drs[j]["disqualification_to_count"].ToString());
                            }
                            if (drs[j]["deal_type"].ToString().Equals("1"))
                            {
                                destroy += int.Parse(drs[j]["disqualification_to_count"].ToString());
                            }
                            if (drs[j]["deal_type"].ToString().Equals("2"))
                            {
                                edit += int.Parse(drs[j]["disqualification_to_count"].ToString());
                            }

                        }
                       
                    }
                    dtDisqualification.Rows[i]["back"] = back.ToString();
                    dtDisqualification.Rows[i]["destroy"] = destroy.ToString();
                    dtDisqualification.Rows[i]["edit"] = edit.ToString();
                    dtDisqualification.Rows[i]["disqualificationNum"] = Convert.ToString(int.Parse(dtDisqualification.Rows[i]["disqualification_count"].ToString()) + edit);

                }
                //绑定数据
                dataGridView_Disqualification.DataSource = dtDisqualification;
                dtPrint = dtDisqualification;
                if (dataGridView_Disqualification != null && dataGridView_Disqualification.Rows.Count > 0 && countNum != 0)
                {
                    dataGridView_Disqualification.Rows[0].Selected = false;
                    dataGridView_Disqualification.Rows[countNum].Selected = true;
                    dataGridView_Disqualification.FirstDisplayedScrollingRowIndex = countNum;
                }
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
        //*******************************************************************
        /// <summary>
        /// 不合格物品管理页面选中数据
        /// </summary>
        /// <history>
        ///     完成信息：吴小科      2010/08/04 完成   
        ///     更新信息：
        /// </history>
        //*******************************************************************
        private void dataGridView_Disqualification_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1 || e.ColumnIndex <= -1)//双击表头或列头时不起作用   
            {
                return;
            }

            if (dataGridView_Disqualification != null && dataGridView_Disqualification.SelectedRows.Count == 1)
            {
                countNum = dataGridView_Disqualification.SelectedRows[0].Index;
                Hashtable ht = new Hashtable();
                ht.Add("disqualification_code", int.Parse(dataGridView_Disqualification.SelectedRows[0].Cells["disqualification_code"].Value.ToString()));
                ht.Add("undeal_count", int.Parse(dataGridView_Disqualification.SelectedRows[0].Cells["undeal_count"].Value.ToString()));
                ht.Add("input_code", dataGridView_Disqualification.SelectedRows[0].Cells["input_code"].Value.ToString());
                ht.Add("input_goods_code", dataGridView_Disqualification.SelectedRows[0].Cells["input_goods_code"].Value.ToString());
                ht.Add("inStorageDate",DateTime.Parse(dataGridView_Disqualification.SelectedRows[0].Cells["input_instorage_date"].Value.ToString()));
                disqualificationForm form = new disqualificationForm(ht);
                form.ShowDialog();
                DataBanding();
            }
            else
            {
                MessageBox.Show("只能选择一条记录！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
        //*******************************************************************
        /// <summary>
        /// 不合格物品管理页面初始化
        /// </summary>
        /// <history>
        ///     完成信息：吴小科      2010/08/04 完成   
        ///     更新信息：
        /// </history>
        //*******************************************************************
        public void DisqualificationManageForm_Load(object sender, EventArgs e)
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
                //获取绑定数据表
                DataTable dtDisqualification = getData.GetTableBySqlStr(Constants.SqlStr.TC_DISQUALIFICATION_MANAGER, sp);
                //添加序列号
                int countNumber = 0;
                dtDisqualification.Columns.Add("num", typeof(int));
                dtDisqualification.Columns.Add("back", typeof(string));
                dtDisqualification.Columns.Add("destroy", typeof(string));
                dtDisqualification.Columns.Add("edit", typeof(string));
                dtDisqualification.Columns.Add("disqualificationNum",typeof(int));
                DataTable dtDisqualificationTo = getData.GetSingleTable("tc_disqualification_To");
                for (int i = 0; i < dtDisqualification.Rows.Count; i++)
                {
                    dtDisqualification.Rows[i]["num"] = ++countNumber;
                    DataRow[] drs = dtDisqualificationTo.Select("disqualification_code = " + dtDisqualification.Rows[i]["disqualification_code"]);
                    int back = 0;
                    int destroy = 0;
                    int edit = 0;
                    if (drs.Length > 0)
                    {
                        for (int j = 0; j < drs.Length; j++)
                        {
                            if (drs[j]["deal_type"].ToString().Equals("0"))
                            {
                                back += int.Parse(drs[j]["disqualification_to_count"].ToString());
                            }
                            if (drs[j]["deal_type"].ToString().Equals("1"))
                            {
                                destroy += int.Parse(drs[j]["disqualification_to_count"].ToString());
                            }
                            if (drs[j]["deal_type"].ToString().Equals("2"))
                            {
                                edit += int.Parse(drs[j]["disqualification_to_count"].ToString());
                            }

                        }
                       
                    }
                    dtDisqualification.Rows[i]["back"] = back.ToString();
                    dtDisqualification.Rows[i]["destroy"] = destroy.ToString();
                    dtDisqualification.Rows[i]["edit"] = edit.ToString();
                    dtDisqualification.Rows[i]["disqualificationNum"] =Convert.ToString(int.Parse(dtDisqualification.Rows[i]["disqualification_count"].ToString()) + edit);

                }
                //绑定数据
                dataGridView_Disqualification.DataSource = dtDisqualification;
                dtPrint = dtDisqualification;
                textBox_input_code.Focus();

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
        /// 清空按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/08/04 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox_goods_name.Text = "";
            textBox_goods_yxm.Text = "";
            textBox_input_code.Text = "";
            checkBox1.Checked = false;


        }
        //***********************************************************************
        /// <summary>
        /// 查询按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/08/04 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnSearch_Click(object sender, EventArgs e)
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
            countNum = 0;
            SearchParameter sp = new SearchParameter();
            if (checkBox1.Checked)
            {
                DateTime dateFrom = dateTimePicker1.Value.Date;
                DateTime dateTo = dateTimePicker2.Value.Date;
                if (dateTo < dateFrom)
                {
                    MessageBox.Show("入库日期起止范围不正确。", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dateTimePicker2.Focus();
                    return;
                }
                if (DateTime.Now.Date < dateTimePicker2.Value.Date)
                {
                    MessageBox.Show("入库日期不可大于今天", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                sp.SetValue(":INPUT_INSTORAGE_DATE_FROM", dateTimePicker1.Value.Date);
                sp.SetValue(":INPUT_INSTORAGE_DATE_TO", dateTimePicker2.Value.Date);

            }
            if (!textBox_input_code.Text.Trim().Equals(string.Empty))
            {
                sp.SetValue(":TC_INPUT_STORAGE.INPUT_CODE", textBox_input_code.Text);
            }
            if (!textBox_goods_name.Text.Trim().Equals(string.Empty))
            {
                sp.SetValue(":TC_GOODS.GOODS_NAME", textBox_goods_name.Text);
            }
            if (!textBox_goods_yxm.Text.Trim().Equals(string.Empty))
            {
                sp.SetValue(":TC_GOODS.GOODS_YXM", textBox_goods_yxm.Text);
            }
            try
            {

                //打开数据库
                dataAccess = new DataAccess();
                dataAccess.Open();
                //获取操作类
                GetData getData = new GetData(dataAccess.Connection);
                //获取绑定数据表
                DataTable dtDisqualification = getData.GetTableBySqlStr(Constants.SqlStr.TC_DISQUALIFICATION_MANAGER, sp);
                //添加序列号
                int countNumber = 0;
                dtDisqualification.Columns.Add("num", typeof(int));
                dtDisqualification.Columns.Add("back", typeof(string));
                dtDisqualification.Columns.Add("destroy", typeof(string));
                dtDisqualification.Columns.Add("edit", typeof(string));
                dtDisqualification.Columns.Add("disqualificationNum", typeof(int));
                DataTable dtDisqualificationTo = getData.GetSingleTable("tc_disqualification_To");
                for (int i = 0; i < dtDisqualification.Rows.Count; i++)
                {
                    dtDisqualification.Rows[i]["num"] = ++countNumber;
                    DataRow[] drs = dtDisqualificationTo.Select("disqualification_code = '" + dtDisqualification.Rows[i]["disqualification_code"].ToString() + "'");
                    int back = 0;
                    int destroy = 0;
                    int edit = 0;
                    if (drs.Length > 0)
                    {
                        for (int j = 0; j < drs.Length; j++)
                        {
                            if (drs[j]["deal_type"].ToString().Equals("0"))
                            {
                                back += int.Parse(drs[j]["disqualification_to_count"].ToString());
                            }
                            if (drs[j]["deal_type"].ToString().Equals("1"))
                            {
                                destroy += int.Parse(drs[j]["disqualification_to_count"].ToString());
                            }
                            if (drs[j]["deal_type"].ToString().Equals("2"))
                            {
                                edit += int.Parse(drs[j]["disqualification_to_count"].ToString());
                            }

                        }
                       
                    }
                    dtDisqualification.Rows[i]["back"] = back.ToString();
                    dtDisqualification.Rows[i]["destroy"] = destroy.ToString();
                    dtDisqualification.Rows[i]["edit"] = edit.ToString();
                    dtDisqualification.Rows[i]["disqualificationNum"] = Convert.ToString(int.Parse(dtDisqualification.Rows[i]["disqualification_count"].ToString()) + edit);

                }
                if (dtDisqualification == null)
                {
                    MessageBox.Show("请查看数据库是否正常！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //绑定数据
                dataGridView_Disqualification.DataSource = dtDisqualification;
                dtPrint = dtDisqualification;
                if (dtDisqualification.Rows.Count == 0)
                {
                    MessageBox.Show("数据不存在，请查看输入的条件是否正确！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


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
        /// 选择按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/08/11 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
            }
            if (checkBox1.Checked == false)
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;

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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dtPrint == null || dtPrint.Rows.Count == 0)
            {
                MessageBox.Show("没有可以打印的数据！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DisqualificationPrint disqualificationPrint = new DisqualificationPrint(dtPrint);
            disqualificationPrint.ShowDialog();
        }


    }
}
