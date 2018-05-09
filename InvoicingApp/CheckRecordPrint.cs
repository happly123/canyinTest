using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace InvoicingApp
{
    public partial class CheckRecordPrint : Form
    {
        private DataTable dtPrint = null;
        public CheckRecordPrint(DataTable dt)
        {
            this.dtPrint = dt;
            InitializeComponent();
        }

        private DataTable GetCheckRecordTable(DataTable dt)
        {

            DataTable dtInputRecord = new DataTable();
            dtInputRecord.Columns.Add("input_checktime", typeof(string));
            dtInputRecord.Columns.Add("supplier_name", typeof(string));
            dtInputRecord.Columns.Add("goods_name", typeof(string));
            dtInputRecord.Columns.Add("goods_type", typeof(string));
            dtInputRecord.Columns.Add("input_standard_count", typeof(string));
            dtInputRecord.Columns.Add("terilization_num", typeof(string));
            dtInputRecord.Columns.Add("maker_name", typeof(string));
            dtInputRecord.Columns.Add("input_batch_num", typeof(string));
            dtInputRecord.Columns.Add("goods_reg_num", typeof(string));
            dtInputRecord.Columns.Add("goods_validity", typeof(string));
            dtInputRecord.Columns.Add("quality_info", typeof(string));
            dtInputRecord.Columns.Add("check_info", typeof(string));
            dtInputRecord.Columns.Add("input_check_persion", typeof(string));

            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dtInputRecord.NewRow();
                    if (dt.Rows[i]["input_checktime"].ToString().Trim().Equals(string.Empty))
                    {
                        dr["input_checktime"] = "";
                    }
                    else
                    {
                        dr["input_checktime"] = DateTime.Parse(dt.Rows[i]["input_checktime"].ToString()).ToString("yyyy-MM-dd");
                    }

                    dr["supplier_name"] = dt.Rows[i]["sn_sl"].ToString();
                    dr["goods_name"] = dt.Rows[i]["goods_name"].ToString();
                    dr["goods_type"] = dt.Rows[i]["goods_type"].ToString();
                    dr["input_standard_count"] = dt.Rows[i]["input_standard_count"].ToString();
                    dr["terilization_num"] = dt.Rows[i]["input_quality_reg"].ToString();
                    dr["maker_name"] = dt.Rows[i]["maker_name"].ToString();
                    dr["input_batch_num"] = dt.Rows[i]["input_batch_num"].ToString();
                    dr["goods_reg_num"] = dt.Rows[i]["goods_reg_num"].ToString();
                    dr["goods_validity"] = dt.Rows[i]["goods_validity"].ToString();
                    dr["quality_info"] = dt.Rows[i]["quality_info"].ToString();
                    dr["check_info"] = dt.Rows[i]["check_info"].ToString();
                    dr["input_check_persion"] = dt.Rows[i]["input_check_persion"].ToString();

                    dtInputRecord.Rows.Add(dr);
                }

            }

            return dtInputRecord;
        }

        private void CheckRecordPrint_Load(object sender, EventArgs e)
        {
            ReportViewer reportViewer = new ReportViewer();
            //reportViewer.ShowExportButton = false;
            reportViewer.ProcessingMode = ProcessingMode.Local;
            
            reportViewer.LocalReport.ReportPath = Application.StartupPath + "\\RDLC\\" + "CheckRecordReport.rdlc";
            reportViewer.LocalReport.DataSources.Add(
                new ReportDataSource("MaintenanceData_DTCheckRecord", GetCheckRecordTable(dtPrint)));

            reportViewer.Dock = DockStyle.Fill;

            this.Controls.Add(reportViewer);

            reportViewer.RefreshReport();
        }
    }
}
