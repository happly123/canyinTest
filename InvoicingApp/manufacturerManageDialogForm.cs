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
    public partial class manufacturerManageDialogForm : Form
    {
        /// <summary>
        /// 数据库连接句柄
        /// </summary>
        DataAccess dataAccess = null;

      

        private string[] maker_name_1= new String[5];
        public string[] Maker_name
        {
            get { return this.maker_name_1; }
            set { this.maker_name_1 = value; }
        }

        public manufacturerManageDialogForm()
        {
            InitializeComponent();
            this.dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(239, 243, 251);

        }

        //*******************************************************************
        /// <summary>
        /// 绑定画面
        /// </summary>
        /// <history>
        ///     完成信息：李梓楠      2010/07/13 完成   
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

                DataTable dtCounter = getData.GetSingleTable("TC_MAKER");

                dtCounter.Columns.Add("index", typeof(int));
                for (int i = 0; i < dtCounter.Rows.Count; i++)
                {
                    dtCounter.Rows[i]["index"] = i + 1;
                }


                dgv.DataSource = dtCounter;

                
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
        ///    完成信息：李梓楠      2010/07/13 完成   
        ///    更新信息：
        /// </history>
        //***********************************************************************
        private void ManufacturerManageForm_Load(object sender, EventArgs e)
        {
            BandingDgv();
        }
        //***********************************************************************
        /// <summary>
        /// 查询按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：李梓楠      2010/07/13 完成   
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

                if (txtMaker_nameSelect.Text.Trim() != string.Empty)
                {
                    sp.SetValue(":MAKER_NAME", txtMaker_nameSelect.Text);
                }

                if (txtMaker_yxmSelect.Text.Trim() != string.Empty)
                {
                    sp.SetValue(":MAKER_YXM", txtMaker_yxmSelect.Text);

                }



                dataAccess = new DataAccess();
                dataAccess.Open();

                GetData getData = new GetData(dataAccess.Connection);

                DataTable dtCondition = getData.GetSingleTableByCondition("TC_MAKER", sp);

                if (dtCondition == null)
                {
                    MessageBox.Show("请查看数据库是否正常！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (dtCondition.Rows.Count == 0)
                {
                    MessageBox.Show("数据不存在，请查看输入的条件是否正确！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                dtCondition.Columns.Add("index", typeof(int));
                for (int i = 0; i < dtCondition.Rows.Count; i++)
                {
                    dtCondition.Rows[i]["index"] = i + 1;
                }

                dgv.DataSource = dtCondition;

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

        private void btnCommit_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows != null && dgv.SelectedRows.Count == 1 )
            {
                Maker_name[0] = dgv.SelectedRows[0].Cells["maker_code"].Value.ToString();
                Maker_name[1] = dgv.SelectedRows[0].Cells["maker_name"].Value.ToString();
                this.Close();
            }
            else MessageBox.Show("只能选择一条记录！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1 || e.ColumnIndex <= -1)//双击表头或列头时不起作用   
            {
                return;
            }

            if (dgv.SelectedRows != null && dgv.SelectedRows.Count == 1)
            {
                Maker_name[0] = dgv.SelectedRows[0].Cells["maker_code"].Value.ToString();
                Maker_name[1] = dgv.SelectedRows[0].Cells["maker_name"].Value.ToString();
                this.Close();
            }
            else MessageBox.Show("只能选择一条记录！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaker_nameSelect.Text = "";
            txtMaker_yxmSelect.Text = "";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            ManufacturerManageForm mmf = new ManufacturerManageForm();
            mmf.ShowDialog();
            BandingDgv();
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
