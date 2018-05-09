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
//* 功能画面		：  供货商信息管理功能
//* 画面名称	    ：  InitStorageForm
//* 完成年月日      ：  2010/07/21
//* 作者		    ：  吴小科
//* Version		    ：  1.00
//* ---------------------------------------------------------------------
//* 前提		：SQL SERVER,.NetFramework3.0
//***********************************************************************
namespace InvoicingApp
{   //***********************************************************************
    /// <summary>
    ///供货商信息管理功能
    /// </summary>
    /// <history>
    ///     完成信息：吴小科      2010/07/21 完成  
    ///     更新信息：
    /// </history>
    //***********************************************************************
    public partial class supplierManageDialogForm : Form
    {
        //数据库连接句柄
        DataAccess dataAccess = null;
        /// <summary>
        /// 供货商名称初始化
        /// </summary>
        public string supplierName = string.Empty;
        public supplierManageDialogForm()
        {
            InitializeComponent();
            dataGridView_supplier.AutoGenerateColumns = false;
            this.dataGridView_supplier.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(239, 243, 251);
        }
        //***********************************************************************
        /// <summary>
        /// 查询按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/07/21 完成   
        ///    更新信息：吴小科      2010/07/22 修改
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
                if (textBox_supplier_name.Text.Trim() != string.Empty)
                {   //查询条件参数赋值
                    sp.SetValue(":supplier_name", textBox_supplier_name.Text);
                }
                if (textBox_supplier_yxm.Text.Trim() != string.Empty)
                {   //查询条件参数赋值
                    sp.SetValue(":supplier_yxm",textBox_supplier_yxm.Text);
                }
                //打开数据库
                dataAccess = new DataAccess();
                dataAccess.Open();
                //获取操作类
                GetData getData = new GetData(dataAccess.Connection);
                //返回绑定数据表
                DataTable dtSupplier = getData.GetSingleTableByCondition("tc_supplier", sp);

                if (dtSupplier == null)
                {
                    MessageBox.Show("请查看数据库是否正常！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //添加序列号
                int countNumber = 0;
                dtSupplier.Columns.Add("num", typeof(int));
                for (int i = 0; i < dtSupplier.Rows.Count; i++)
                {
                    dtSupplier.Rows[i]["num"] = ++countNumber;

                }
                //绑定数据
                dataGridView_supplier.DataSource = dtSupplier;
                if (dataGridView_supplier.Rows.Count == 0)
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
        /// 选择供货商信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/07/21 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (dataGridView_supplier.SelectedRows != null && dataGridView_supplier.SelectedRows.Count == 1)
            {
                //供货商信息赋值
                supplierName = dataGridView_supplier.SelectedRows[0].Cells["supplier_name"].Value.ToString();
                this.Close();

            }
            else
            {
                MessageBox.Show("请选择一条记录！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        //***********************************************************************
        /// <summary>
        /// 画面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/07/21 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void supplierManageDialogForm_Load(object sender, EventArgs e)
        {
            try
            {   //打开数据库
                dataAccess = new DataAccess();
                dataAccess.Open();
                //获取操作类
                GetData getData = new GetData(dataAccess.Connection);
                //获取绑定数据表
                DataTable dtSupplier = getData.GetSingleTable("tc_supplier");
                //添加序列号
                int countNumber = 0;
                dtSupplier.Columns.Add("num", typeof(int));
                for (int i = 0; i < dtSupplier.Rows.Count; i++)
                {
                    dtSupplier.Rows[i]["num"] = ++countNumber;

                }
                //绑定数据
                dataGridView_supplier.DataSource = dtSupplier;
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
        /// 关闭择供货商信息
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
        /// 双击选择供货商信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/07/24 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void dataGridView_supplier_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1 || e.ColumnIndex <= -1)//双击表头或列头时不起作用   
            {
                return;
            }

            if (dataGridView_supplier.SelectedRows != null && dataGridView_supplier.SelectedRows.Count == 1)
            {
                //供货商信息赋值
                supplierName = dataGridView_supplier.SelectedRows[0].Cells["supplier_name"].Value.ToString();
                this.Close();

            }
            else
            {
                MessageBox.Show("请选择一条记录！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
             //***********************************************************************
        /// <summary>
        /// 数据重新加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/08/06 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void DataBanding()
        {
            try
            {   //打开数据库
                dataAccess = new DataAccess();
                dataAccess.Open();
                //获取操作类
                GetData getData = new GetData(dataAccess.Connection);
                //获取绑定数据表
                DataTable dtSupplier = getData.GetSingleTable("tc_supplier");
                //添加序列号
                int countNumber = 0;
                dtSupplier.Columns.Add("num", typeof(int));
                for (int i = 0; i < dtSupplier.Rows.Count; i++)
                {
                    dtSupplier.Rows[i]["num"] = ++countNumber;

                }
                //绑定数据
                dataGridView_supplier.DataSource = dtSupplier;
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
        /// 添加供货商信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：吴小科      2010/08/06 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnInsert_Click(object sender, EventArgs e)
        {
            SupplierManageForm supplierManager = new SupplierManageForm();
            supplierManager.ShowDialog();
            DataBanding();

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
            textBox_supplier_name.Text = "";
            textBox_supplier_yxm.Text = "";

        }

        private void dataGridView_supplier_Sorted(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView_supplier.Rows.Count; i++)
            {
                dataGridView_supplier.Rows[i].Cells["num"].Value = i + 1;
            }
        }
    }
}
