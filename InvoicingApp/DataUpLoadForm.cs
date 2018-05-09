using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataAccesses;

namespace InvoicingApp
{
    public partial class DataUpLoadForm : Form
    {
        public DataUpLoadForm()
        {
            InitializeComponent();
        }

        private void DataUpLoadForm_Load(object sender, EventArgs e)
        {
            DataAccess dataAccess = new DataAccess();
            try
            {
                dataAccess.Open();

                GetData getData = new GetData(dataAccess.Connection);
                DataTable dt = getData.GetSingleTable("tc_upload_log");
                dgv.AutoGenerateColumns = false;
                dt.Columns.Add("index", typeof(int));
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["index"] = i + 1;
                }
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据加载时发生错误，请检查数据库！", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (dataAccess.Connection != null)
                {
                    dataAccess.Close();
                }
            }
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
