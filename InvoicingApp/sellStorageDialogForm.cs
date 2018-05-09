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
//***********************************************************************
//* 系统名称	    ：  长白ERP系统
//* 功能模块	    ：  系统信息
//* 功能画面		：  销售信息管理功能
//* 画面名称	    ：  InitStorageForm
//* 完成年月日      ：  2010/07/22
//* 作者		    ：  吴小科
//* Version		    ：  1.00
//* ---------------------------------------------------------------------
//* 前提		：SQL SERVER,.NetFramework3.0
//***********************************************************************
namespace InvoicingApp
{
    public partial class sellStorageDialogForm : Form
    {
        //***********************************************************************
        /// <summary>
        ///销售信息管理功能
        /// </summary>
        /// <history>
        ///     完成信息：吴小科      2010/07/22 完成  
        ///     更新信息：
        /// </history>
        //***********************************************************************
        public sellStorageDialogForm()
        {
            InitializeComponent();
            dgvOutput_storage.AutoGenerateColumns = false;
            this.dgvOutput_storage.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(239, 243, 251);
            
        }

        //为客户回访提供的重载构造,改变dgv中剩余数量列名为"销售数量"
        public sellStorageDialogForm(string parentName)
        {
            
            InitializeComponent();
            if (parentName == "visit")
            {
                dgvOutput_storage.Columns["reloutput_count"].HeaderText = "销售数量";
            }
            dgvOutput_storage.AutoGenerateColumns = false;
            this.dgvOutput_storage.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(239, 243, 251);
        }
        //数据库连接句柄
        DataAccess dataAccess = null;
        /// <summary>
        /// 出库编号和数量初始化
        /// </summary>
        public string outputCode = string.Empty;
        public string customerTel = string.Empty;
        public int outCount;
        public string goodsCode = string.Empty;
        public string supplierName = string.Empty;
        public string goodsName = string.Empty;
        public string customerName = string.Empty;
        public DateTime makeTime;
        public DateTime instorageTime;
        public DateTime outputInstorageDate;
        public string batchNum = string.Empty;
        public string qualityReg = string.Empty;
        public int lastCount;
        //***********************************************************************
        /// <summary>
        /// 画面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/07/22 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void sellStorageDialogForm_Load(object sender, EventArgs e)
        {
            //设置参数
            SearchParameter sp = new SearchParameter();
            sp.SetValue(":CONDITION1", "");
            //sp.SetValue(":TC_OUTPUT_STORAGE.OUTPUT_TYPE", "0");
            try
            {
                //打开数据库
                dataAccess = new DataAccess();
                dataAccess.Open();
                //获取操作类
                GetData getData = new GetData(dataAccess.Connection);
                //获取绑定数据表
                DataTable dtOutGoods = getData.GetTableByDiyCondition(Constants.SqlStr.TC_INPUT_STORAGE_LEFTJOIN_OUTPUT_STORAGE2, sp);
                //添加序列号
                int countNumber = 0;
                dtOutGoods.Columns.Add("num", typeof(int));
                for (int i = 0; i < dtOutGoods.Rows.Count; i++)
                {
                    dtOutGoods.Rows[i]["num"] = ++countNumber;

                }
                //绑定数据
                dgvOutput_storage.DataSource = dtOutGoods;
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
        /// 选择销售记录信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/07/22 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btn_Confirm_Click(object sender, EventArgs e)
        {
           
            if (dgvOutput_storage.SelectedRows != null && dgvOutput_storage.SelectedRows.Count == 1)
            {
                //出库编号和出库数量赋值
                outputCode = dgvOutput_storage.SelectedRows[0].Cells["output_code"].Value.ToString();
                outCount = Convert.ToInt32(dgvOutput_storage.SelectedRows[0].Cells["output_count"].Value.ToString());
                goodsCode = dgvOutput_storage.SelectedRows[0].Cells["input_goods_code"].Value.ToString();
                supplierName = dgvOutput_storage.SelectedRows[0].Cells["supplier_name"].Value.ToString();
                goodsName = dgvOutput_storage.SelectedRows[0].Cells["goods_name"].Value.ToString();
                customerName = dgvOutput_storage.SelectedRows[0].Cells["customer_name"].Value.ToString();
                makeTime = Convert.ToDateTime(dgvOutput_storage.SelectedRows[0].Cells["input_maketime"].Value.ToString());
                instorageTime = Convert.ToDateTime(dgvOutput_storage.SelectedRows[0].Cells["input_instorage_date"].Value.ToString());
                batchNum = dgvOutput_storage.SelectedRows[0].Cells["input_batch_num"].Value.ToString();
                qualityReg = dgvOutput_storage.SelectedRows[0].Cells["input_quality_reg"].Value.ToString();
                lastCount = Convert.ToInt32(dgvOutput_storage.SelectedRows[0].Cells["reloutput_count"].Value.ToString());
                outputInstorageDate = DateTime.Parse(dgvOutput_storage.SelectedRows[0].Cells["output_instorage_date"].Value.ToString());
                customerTel = dgvOutput_storage.SelectedRows[0].Cells["customer_tel"].Value.ToString();
                this.Close();

            }
            else
            {
                MessageBox.Show("请选择一条记录！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
        //***********************************************************************
        /// <summary>
        /// 查询按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/07/22 完成   
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
            try
            {
                //设置查询条件参数
                SearchParameter sp = new SearchParameter();
                string condition = "";
                // sp.SetValue(":tc_output_storage.output_type", "0");
                if (textBox_output_code.Text.Trim() != string.Empty)
                {   //查询条件参数赋值
                    condition += " and tc_output_storage.output_code like '%" + textBox_output_code.Text + "%'";
                    //sp.SetValue(":tc_output_storage.output_code", textBox_output_code.Text);
                }
                if (textBox_customer_name.Text.Trim() != string.Empty)
                {   //查询条件参数赋值
                    condition += " and tc_customer.customer_name like '%" + textBox_customer_name.Text + "%'";
                    //sp.SetValue(":tc_customer.customer_name", textBox_customer_name.Text);
                }
                if (textBox_customer_yxm.Text.Trim() != string.Empty)
                {   //查询条件参数赋值
                    condition += " and tc_customer.customer_yxm like '%" + textBox_customer_yxm.Text + "%'";
                    //sp.SetValue(":tc_customer.customer_yxm",textBox_customer_yxm.Text);

                }
                sp.SetValue(":CONDITION1", condition);
                //打开数据库
                dataAccess = new DataAccess();
                dataAccess.Open();
                //获取操作类
                GetData getData = new GetData(dataAccess.Connection);
                //返回绑定数据表
                DataTable dtOutGoods = getData.GetTableByDiyCondition(Constants.SqlStr.TC_INPUT_STORAGE_LEFTJOIN_OUTPUT_STORAGE2, sp);
                if (dtOutGoods == null)
                {
                    MessageBox.Show("请查看数据库是否正常！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //添加序列号
                int countNumber = 0;
                dtOutGoods.Columns.Add("num", typeof(int));
                for (int i = 0; i < dtOutGoods.Rows.Count; i++)
                {
                    dtOutGoods.Rows[i]["num"] = ++countNumber;

                }
                //绑定数据
                dgvOutput_storage.DataSource = dtOutGoods;
                if (dgvOutput_storage.Rows.Count == 0)
                {
                    MessageBox.Show("数据不存在，请查看输入的条件是否正确！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("请查看数据库是否正常！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            finally
            {
                //关闭数据库
                dataAccess.Close();

            }

        }
        //***********************************************************************
        /// <summary>
        /// 关闭销售记录信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/07/24 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //***********************************************************************
        /// <summary>
        /// 双击选择销售记录信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/07/24 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void dgvOutput_storage_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1 || e.ColumnIndex <= -1)//双击表头或列头时不起作用   
            {
                return;
            }

            if (dgvOutput_storage.SelectedRows != null && dgvOutput_storage.SelectedRows.Count == 1)
            {
                //出库编号和出库数量赋值
                outputCode = dgvOutput_storage.SelectedRows[0].Cells["output_code"].Value.ToString();
                outCount = Convert.ToInt32(dgvOutput_storage.SelectedRows[0].Cells["output_count"].Value.ToString());
                goodsCode = dgvOutput_storage.SelectedRows[0].Cells["input_goods_code"].Value.ToString();
                supplierName = dgvOutput_storage.SelectedRows[0].Cells["supplier_name"].Value.ToString();
                goodsName = dgvOutput_storage.SelectedRows[0].Cells["goods_name"].Value.ToString();
                customerName = dgvOutput_storage.SelectedRows[0].Cells["customer_name"].Value.ToString();
                makeTime = Convert.ToDateTime(dgvOutput_storage.SelectedRows[0].Cells["input_maketime"].Value.ToString());
                instorageTime = Convert.ToDateTime(dgvOutput_storage.SelectedRows[0].Cells["input_instorage_date"].Value.ToString());
                batchNum = dgvOutput_storage.SelectedRows[0].Cells["input_batch_num"].Value.ToString();
                qualityReg = dgvOutput_storage.SelectedRows[0].Cells["input_quality_reg"].Value.ToString();
                lastCount = Convert.ToInt32(dgvOutput_storage.SelectedRows[0].Cells["reloutput_count"].Value.ToString());
                outputInstorageDate = DateTime.Parse(dgvOutput_storage.SelectedRows[0].Cells["output_instorage_date"].Value.ToString());
                customerTel = dgvOutput_storage.SelectedRows[0].Cells["customer_tel"].Value.ToString();
                this.Close();

            }
            else
            {
                MessageBox.Show("请选择一条记录！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
 
            }
        }
        //***********************************************************************
        /// <summary>
        /// 重置按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/08/09 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox_output_code.Text = "";
            textBox_customer_name.Text = "";
            textBox_customer_yxm.Text = "";
        }

        private void dgvOutput_storage_Sorted(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvOutput_storage.Rows.Count; i++)
            {
                dgvOutput_storage.Rows[i].Cells["num"].Value = i + 1;
            }
        }
      

  }
}
