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
    public partial class persionalDialogForm : Form
    {
        /// <summary>
        /// 客户名称
        /// </summary>
        public string customerName = string.Empty;

        /// <summary>
        /// 客户编码
        /// </summary>
        public string customerCode = string.Empty;

        /// <summary>
        /// 数据库连接句柄
        /// </summary>
        DataAccess dataAccess = null;

        public persionalDialogForm()
        {
            InitializeComponent();
            this.dgvCustomer.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(239, 243, 251);
        }

        public void BandingDgvCustomer()
        {

            try
            {
                dataAccess = new DataAccess();
                dataAccess.Open();

                GetData getData = new GetData(dataAccess.Connection);

                SearchParameter sp = new SearchParameter();
                sp.SetValue(":customer_flag", "1");

                DataTable dt = getData.GetTableBySqlStr(Constants.SqlStr.TC_CUSTOMER_RIGHTJOIN_TC_ARCHIVES, sp);

                dgvCustomer.AutoGenerateColumns = false;
                dt.Columns.Add("index", typeof(int));
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["index"] = i + 1;
                }
                dgvCustomer.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (dataAccess.Connection != null)
                    dataAccess.Close();
            }
        }

        private void persionalDialogForm_Load(object sender, EventArgs e)
        {
            dgvCustomer.AutoGenerateColumns = false;
            BandingDgvCustomer();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCustomer_yxmSelect.Text = "";
            txtCustomer_nameSelect.Text = "";
        }

        private void dgvCustomer_Sorted(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvCustomer.Rows.Count; i++)
            {
                dgvCustomer.Rows[i].Cells["index"].Value = i + 1;
            }
        }

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
            CustomerPersional customerPersional = new CustomerPersional();
            customerPersional.ShowDialog();
            BandingDgvCustomer();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            //判断非法字符
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
                SearchParameter sp = new SearchParameter();

                if (txtCustomer_nameSelect.Text.Trim() != string.Empty)
                {
                    sp.SetValue(":CUSTOMER_NAME", txtCustomer_nameSelect.Text);
                }

                if (txtCustomer_yxmSelect.Text.Trim() != string.Empty)
                {
                    sp.SetValue(":CUSTOMER_YXM", txtCustomer_yxmSelect.Text);

                }

                sp.SetValue(":customer_flag", "1");

                dataAccess = new DataAccess();
                dataAccess.Open();

                GetData getData = new GetData(dataAccess.Connection);

                DataTable dt = getData.GetTableBySqlStr(Constants.SqlStr.TC_CUSTOMER_RIGHTJOIN_TC_ARCHIVES, sp);


                if (dt == null)
                {
                    MessageBox.Show("请查看数据库是否正常！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                dt.Columns.Add("index", typeof(int));

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["index"] = i + 1;
                }

                dgvCustomer.DataSource = dt;

                if (dt.Rows.Count == 0)
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
                dataAccess.Close();
            }
        }

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
    }
}
