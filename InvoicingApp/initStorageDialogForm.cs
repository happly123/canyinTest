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
    public partial class initStorageDialogForm : Form
    {
        /// <summary>
        /// 数据库连接句柄
        /// </summary>
        DataAccess dataAcess = null;
        
        private string inputcode = string.Empty;
        public string goods_name = string.Empty;
        public DateTime inStorageDate;
        public string Inputcode
        {
            set { this.inputcode = value; }
            get { return this.inputcode;  }
        }

        public initStorageDialogForm()
        {
            InitializeComponent();
            this.dgvInputStorage.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(239, 243, 251);
            dgvInputStorage.AutoGenerateColumns = false;
        }
        //private void GetDgvInputStorage(DataTable dt)
        //{
        //    dtDgvInputStorage = new DataTable();
        //    dtDgvInputStorage.Columns.Add("input_code", typeof(string));
        //    dtDgvInputStorage.Columns.Add("input_type", typeof(string));
        //    dtDgvInputStorage.Columns.Add("goods_name", typeof(string));
        //    dtDgvInputStorage.Columns.Add("goods_type", typeof(string));
        //    dtDgvInputStorage.Columns.Add("supplier_name", typeof(string));
        //    dtDgvInputStorage.Columns.Add("maker_name", typeof(string));
        //    dtDgvInputStorage.Columns.Add("input_standard_count", typeof(string));
        //    dtDgvInputStorage.Columns.Add("input_batch_num", typeof(string));
        //    dtDgvInputStorage.Columns.Add("input_instorage_date", typeof(string));
        //    dtDgvInputStorage.Columns.Add("input_maketime", typeof(string));
        //    dtDgvInputStorage.Columns.Add("goods_validity", typeof(string));
        //    dtDgvInputStorage.Columns.Add("input_check_persion", typeof(string));
        //    dtDgvInputStorage.Columns.Add("input_checktime", typeof(string));

        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        DataRow dr = dtDgvInputStorage.NewRow();
        //        dr["input_code"] = dt.Rows[i]["input_code"].ToString();
        //        if (dt.Rows[i]["input_type"].ToString().Equals("0"))
        //        {
        //            dr["input_type"] = "初始入库";
        //        }
        //        else if (dt.Rows[i]["input_type"].ToString().Equals("1"))
        //        {
        //            dr["input_type"] = "购货入库";
        //        }
        //        else if (dt.Rows[i]["input_type"].ToString().Equals("2"))
        //        {
        //            dr["input_type"] = "赠品入库";
        //        }
        //        else if (dt.Rows[i]["input_type"].ToString().Equals("3"))
        //        {
        //            dr["input_type"] = "退货入库";
        //        }

        //        dr["goods_name"] = dt.Rows[i]["goods_name"].ToString();
        //        dr["goods_type"] = dt.Rows[i]["goods_type"].ToString();
        //        dr["supplier_name"] = dt.Rows[i]["supplier_name"].ToString();
        //        dr["maker_name"] = dt.Rows[i]["maker_name"].ToString();
        //        dr["input_standard_count"] = dt.Rows[i]["input_standard_count"].ToString();
        //        dr["input_batch_num"] = dt.Rows[i]["input_batch_num"].ToString();
        //        dr["input_instorage_date"] = DateTime.Parse(dt.Rows[i]["input_instorage_date"].ToString()).ToString("yyyy-MM-dd");
        //        dr["input_maketime"] = DateTime.Parse(dt.Rows[i]["input_maketime"].ToString()).ToString("yyyy-MM-dd");
        //        dr["goods_validity"] = dt.Rows[i]["goods_validity"].ToString();
        //        dr["input_check_persion"] = dt.Rows[i]["input_check_persion"].ToString();
        //        if (dt.Rows[i]["input_checktime"].ToString().Equals(string.Empty))
        //        {
        //            dr["input_checktime"] = "";
        //        }
        //        else
        //        {
        //            dr["input_checktime"] = DateTime.Parse(dt.Rows[i]["input_checktime"].ToString()).ToString("yyyy-MM-dd");
        //        }

        //        dtDgvInputStorage.Rows.Add(dr);
        //    }
        //}

        private void BandingDgvInputStorage()
        {
            try
            {

                dataAcess = new DataAccess();
                dataAcess.Open();
                GetData getData = new GetData(dataAcess.Connection);
                
                SearchParameter sp = new SearchParameter();
                sp.SetValue(":t.storage_count!", 0);
                DataTable dtInputStorage = getData.GetTableBySqlStr(Constants.SqlStr.tc_storage_count_yh, sp);

                if (dtInputStorage == null)
                {
                    MessageBox.Show("请查看数据库是否正常！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (dtInputStorage.Rows.Count > 0)
                {
                    dtInputStorage.Columns.Add("index", typeof(int));
                    for (int i = 0; i < dtInputStorage.Rows.Count; i++)
                    {
                        dtInputStorage.Rows[i]["index"] = i + 1;
                    }

                    dgvInputStorage.DataSource = dtInputStorage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dataAcess.Close();
            }
        }


        //***********************************************************************
        /// <summary>
        /// 查询按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <history>
        ///    完成信息：李梓楠      2010/7/15 完成   
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

                if (txtGoods_nameSelect.Text.Trim() != string.Empty)
                {
                    sp.SetValue(":t.GOODS_NAME", txtGoods_nameSelect.Text);
                }

                if (txtInput_codeSelect.Text.Trim() != string.Empty)
                {
                    sp.SetValue(":t.INPUT_CODE", txtInput_codeSelect.Text);
                }
               


                dataAcess = new DataAccess();
                dataAcess.Open();

                GetData getData = new GetData(dataAcess.Connection);
                sp.SetValue(":t.storage_count!", 0);
                DataTable dtInputStorage = getData.GetTableBySqlStr(Constants.SqlStr.tc_storage_count_yh, sp);


                if (dtInputStorage == null)
                {
                    MessageBox.Show("请查看数据库是否正常！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (dtInputStorage.Rows.Count == 0)
                {
                    MessageBox.Show("数据不存在，请查看输入的条件是否正确！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                dtInputStorage.Columns.Add("index", typeof(int));
                for (int i = 0; i < dtInputStorage.Rows.Count; i++)
                {
                    dtInputStorage.Rows[i]["index"] = i + 1;
                }


                dgvInputStorage.DataSource = dtInputStorage;

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
            finally
            {
                dataAcess.Close();
            }
        }

        //确定按钮事件
        private void btnCommit_Click(object sender, EventArgs e)
        {
            if (dgvInputStorage.SelectedRows != null && dgvInputStorage.SelectedRows.Count == 1)
            {
                Inputcode = dgvInputStorage.SelectedRows[0].Cells["INPUT_CODE"].Value.ToString();
                goods_name = dgvInputStorage.SelectedRows[0].Cells["GOODS_NAME"].Value.ToString();
                inStorageDate =DateTime.Parse(dgvInputStorage.SelectedRows[0].Cells["INPUT_INSTORAGE_DATE"].Value.ToString());
                this.Close();
            }
            else MessageBox.Show("请选择一条记录！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //取消按钮事件
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //dgv被双击事件
        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1 || e.ColumnIndex <= -1)//双击表头或列头时不起作用   
            {
                return;
            }

            if (dgvInputStorage.SelectedRows != null && dgvInputStorage.SelectedRows.Count == 1)
            {
                Inputcode = dgvInputStorage.SelectedRows[0].Cells["INPUT_CODE"].Value.ToString();
                goods_name = dgvInputStorage.SelectedRows[0].Cells["GOODS_NAME"].Value.ToString();
                inStorageDate = DateTime.Parse(dgvInputStorage.SelectedRows[0].Cells["INPUT_INSTORAGE_DATE"].Value.ToString());
                this.Close();
            }
            else MessageBox.Show("请选择一条记录！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void initStorageDialogForm_Load(object sender, EventArgs e)
        {
            BandingDgvInputStorage();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput_codeSelect.Text = "";
            txtGoods_nameSelect.Text = "";
        }

        private void dgvInputStorage_Sorted(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvInputStorage.Rows.Count; i++)
            {
                dgvInputStorage.Rows[i].Cells["index"].Value = i + 1;
            }
        }
    }
}
