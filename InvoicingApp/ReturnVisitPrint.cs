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
    public partial class ReturnVisitPrint : Form
    {
        private DataTable dtPrint = null;

        public ReturnVisitPrint(DataTable dt)
        {
            this.dtPrint = dt;
            InitializeComponent();
        }

        private DataTable GetReturnVisitTable(DataTable dt)
        {

            DataTable dtVisit = new DataTable();

            dtVisit.Columns.Add("customer_name", typeof(string));
            dtVisit.Columns.Add("customer_tel", typeof(string));
            dtVisit.Columns.Add("customer_address", typeof(string));
            dtVisit.Columns.Add("goods_name", typeof(string));
            dtVisit.Columns.Add("goods_type", typeof(string));
            dtVisit.Columns.Add("input_batch_num", typeof(string));
            dtVisit.Columns.Add("output_instorage_date", typeof(string));
            dtVisit.Columns.Add("visit_date", typeof(string));
            dtVisit.Columns.Add("staff_name", typeof(string));
            dtVisit.Columns.Add("visit_man", typeof(string));
            dtVisit.Columns.Add("visit_usage", typeof(string));
            dtVisit.Columns.Add("visit_opinion", typeof(string));
            dtVisit.Columns.Add("visit_remarks", typeof(string));

            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dtVisit.NewRow();

                    dr["customer_name"] = dt.Rows[i]["customer_name"].ToString();
                    dr["customer_tel"] = dt.Rows[i]["customer_tel"].ToString();
                    dr["customer_address"] = dt.Rows[i]["customer_address"].ToString();
                    dr["goods_name"] = dt.Rows[i]["goods_name"].ToString();
                    dr["goods_type"] = dt.Rows[i]["goods_type"].ToString();
                    dr["input_batch_num"] = dt.Rows[i]["input_batch_num"].ToString();
                    dr["output_instorage_date"] = DateTime.Parse(dt.Rows[i]["output_instorage_date"].ToString()).ToString("yyyy-MM-dd");
                    dr["visit_date"] = DateTime.Parse(dt.Rows[i]["visit_date"].ToString()).ToString("yyyy-MM-dd");
                    dr["staff_name"] = dt.Rows[i]["staff_name"].ToString();
                    dr["visit_man"] = dt.Rows[i]["visit_man"].ToString();
                    dr["visit_usage"] = dt.Rows[i]["visit_usage"].ToString();
                    dr["visit_opinion"] = dt.Rows[i]["visit_opinion"].ToString();
                    dr["visit_remarks"] = dt.Rows[i]["visit_remarks"].ToString();

                    dtVisit.Rows.Add(dr);
                }

            }

            return dtVisit;
        }

        private void ReturnVisitPrint_Load(object sender, EventArgs e)
        {
            ReportViewer reportViewer = new ReportViewer();
            //reportViewer.ShowExportButton = false;
            reportViewer.ProcessingMode = ProcessingMode.Local;

            reportViewer.LocalReport.ReportPath = Application.StartupPath + "\\RDLC\\" + "ReturnVisitReport.rdlc";
            reportViewer.LocalReport.DataSources.Add(
                new ReportDataSource("MaintenanceData_DTReturnVisit", GetReturnVisitTable(dtPrint)));

            reportViewer.Dock = DockStyle.Fill;

            this.Controls.Add(reportViewer);

            reportViewer.RefreshReport();
        }
    }
}
