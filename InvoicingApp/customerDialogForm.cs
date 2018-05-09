//***********************************************************************
//* 系统名称	    ：  长白ERP系统
//* 功能模块	    ：  系统信息
//* 功能画面		：  客户管理
//* 画面名称	    ：  customerDialogForm
//* 完成年月日      ：  2010/07/23
//* 作者		    ：  代国明
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
    ///客户管理功能
    /// </summary>
    /// <history>
    ///     完成信息：代国明      2010/07/23 完成  
    ///     更新信息：
    /// </history>
    //***********************************************************************
    public partial class customerDialogForm : Form
    {
        /// <summary>
        /// 数据库连接句柄
        /// </summary>
        DataAccess dataAccess = null;

        /// <summary>
        /// 客户名称
        /// </summary>
        public string customerName = string.Empty;

        /// <summary>
        /// 客户编码
        /// </summary>
        public string customerCode = string.Empty;

        public customerDialogForm()
        {
            InitializeComponent();

            this.dgvCustomer.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(239, 243, 251);
        }

        //*******************************************************************
        /// <summary>
        /// 绑定画面
        /// </summary>
        /// <history>
        ///     完成信息：代国明      2010/07/23 完成   
        ///     更新信息：
        /// </history>
        //*******************************************************************
        private void BandingDgvCustomer()
        {
            try
            {
                dataAccess = new DataAccess();
                dataAccess.Open();

                GetData getData = new GetData(dataAccess.Connection);

                SearchParameter sp = new SearchParameter();
                sp.SetValue(":CUSTOMER_FLAG", "0");

                DataTable dtCounter = getData.GetSingleTableByCondition("TC_CUSTOMER", sp);

                dtCounter.Columns.Add("index", typeof(int));
                for (int i = 0; i < dtCounter.Rows.Count; i++)
                {
                    dtCounter.Rows[i]["index"] = i + 1;
                }


                dgvCustomer.DataSource = dtCounter;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
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
        ///    完成信息：代国明      2010/07/23 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void customerDialogForm_Load(object sender, EventArgs e)
        {
            dgvCustomer.AutoGenerateColumns = false;

            BandingDgvCustomer();
        }

        //***********************************************************************
        /// <summary>
        /// 查询按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：代国明      2010/07/23 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnFind_Click(object sender, EventArgs e)
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
                if (txt_Customer_Select.Text.Trim() != string.Empty)
                {
                    sp.SetValue(":CUSTOMER_NAME", txt_Customer_Select.Text.Trim());
                }

                if (txt_yxm_Select.Text.Trim() != string.Empty)
                {
                    sp.SetValue(":CUSTOMER_YXM", txt_yxm_Select.Text.Trim());
                }

                sp.SetValue(":CUSTOMER_FLAG", "0");
                //打开数据库连接
                dataAccess = new DataAccess();
                dataAccess.Open();

                //取得操作类
                GetData getData = new GetData(dataAccess.Connection);

                //根据条件检索单表
                DataTable dtCondition = getData.GetSingleTableByCondition("TC_CUSTOMER", sp);

                //如果为NULL，报错
                if (dtCondition == null)
                {
                    MessageBox.Show("请查看数据库是否正常！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //没有数据
                if (dtCondition.Rows.Count == 0)
                {
                    //给出提示
                    MessageBox.Show("数据不存在，请查看输入的条件是否正确！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                dtCondition.Columns.Add("index", typeof(int));

                for (int i = 0; i < dtCondition.Rows.Count; i++)
                {
                    dtCondition.Rows[i]["index"] = i + 1;
                }

                //绑定画面
                dgvCustomer.DataSource = dtCondition;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
            finally
            {
                //关闭数据库连接
                dataAccess.Close();
            }
        }

        //***********************************************************************
        /// <summary>
        /// 确认按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：代国明      2010/07/23 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnCommit_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.SelectedRows != null && dgvCustomer.SelectedRows.Count == 1)
            {
                customerCode = dgvCustomer.SelectedRows[0].Cells["customer_code"].Value.ToString();
                customerName = dgvCustomer.SelectedRows[0].Cells["customer_name"].Value.ToString();
            }
            else
            {
                MessageBox.Show("只能选择一条要添加的记录！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            this.Close();
        }

        //***********************************************************************
        /// <summary>
        /// 取消按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：代国明      2010/07/23 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //***********************************************************************
        /// <summary>
        /// 双击dataGridView事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：代国明      2010/07/23 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void dgvCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1 || e.ColumnIndex <= -1)//双击表头或列头时不起作用   
            {
                return;
            }

            if (dgvCustomer.SelectedRows != null && dgvCustomer.SelectedRows.Count == 1)
            {
                customerCode = dgvCustomer.SelectedRows[0].Cells["customer_code"].Value.ToString();
                customerName = dgvCustomer.SelectedRows[0].Cells["customer_name"].Value.ToString();
            }
            else
            {
                MessageBox.Show("只能选择一条要添加的记录！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CustomerUnitManageForm cum = new CustomerUnitManageForm();
            cum.ShowDialog();
            BandingDgvCustomer();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txt_yxm_Select.Text = "";
            txt_Customer_Select.Text = "";
        }

        private void dgvCustomer_Sorted(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvCustomer.Rows.Count; i++)
            {
                dgvCustomer.Rows[i].Cells["index"].Value = i + 1;
            }
        }

    }
}
