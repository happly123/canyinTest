using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace InvoicingApp
{
    public partial class LawForm : Form
    {
        public LawForm()
        {
            InitializeComponent();
            radioButton1.Checked = true;

        }

        private void LoadFile(string typeName)
        {
            string[] strFiles;
            if (typeName == "部门规章")
            {
                strFiles = Directory.GetFiles(Application.StartupPath + "\\法律法规\\部门规章");
            }
            else if (typeName == "行政法规")
            {
                strFiles = Directory.GetFiles(Application.StartupPath + "\\法律法规\\行政法规");
            }
            else
            {
                strFiles = Directory.GetFiles(Application.StartupPath + "\\法律法规\\法律");
            }

            DataTable dtFile = new DataTable();

            dtFile.Columns.Add("file", typeof(string));
            dtFile.Columns.Add("path", typeof(string));
            dtFile.Columns.Add("index", typeof(int));
            try
            {
                for (int i = 0; i < strFiles.Length; i++)
                {
                    if (strFiles[i].Substring(strFiles[i].LastIndexOf('.')).Equals(".doc") && !strFiles[i].Substring(strFiles[i].LastIndexOf("\\") + 1).Trim().StartsWith("~$"))
                    {

                        DataRow dr = dtFile.NewRow();

                        dr["index"] = i + 1;
                        dr["file"] = strFiles[i].Substring(strFiles[i].LastIndexOf("\\") + 1);
                        dr["path"] = strFiles[i];

                        dtFile.Rows.Add(dr);

                    }
                }
                dgvLaw.DataSource = dtFile;

            }
            catch
            {
                MessageBox.Show("文件格式不正确！", "文件错误：", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void dgvLaw_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= -1 || e.ColumnIndex <= -1)//双击表头或列头时不起作用   
            {
                return;
            }
            if (dgvLaw.SelectedRows.Count == 0)
            {
                MessageBox.Show("没有要打开的文件！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (dgvLaw.SelectedRows.Count > 1)
            {
                MessageBox.Show("每次只能双击打开一个文件！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                if (dgvLaw.SelectedRows.Count == 1)
                {
                    System.Diagnostics.Process.Start(dgvLaw.SelectedRows[0].Cells["path"].Value.ToString());
                }
            }
            catch
            {
                MessageBox.Show("打开文件时出错！请检查文件是否存在！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RadioCheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked == true)
            {
                LoadFile(((RadioButton)sender).Text);
            }
        }

        private void dgvLaw_Sorted(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvLaw.Rows.Count; i++)
            {
                dgvLaw.Rows[i].Cells["index"].Value = i + 1;
            }
        }


    }
}
