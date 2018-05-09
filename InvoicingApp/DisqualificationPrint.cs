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
    public partial class DisqualificationPrint : Form
    {
        private DataTable dtPrint = null;

        public DisqualificationPrint(DataTable dt)
        {
            this.dtPrint = dt;
            InitializeComponent();
        }

        private DataTable GetDisqualificationTable(DataTable dt)
        {

            DataTable Disqualification = new DataTable();
            Disqualification.Columns.Add("input_instorage_date", typeof(string));
            Disqualification.Columns.Add("goods_name", typeof(string));
            Disqualification.Columns.Add("goods_reg_num", typeof(string));
            Disqualification.Columns.Add("input_batch_num", typeof(string));
            Disqualification.Columns.Add("maker_name", typeof(string));
            Disqualification.Columns.Add("disqualificationNum", typeof(string));
            Disqualification.Columns.Add("undeal_count", typeof(string));
            Disqualification.Columns.Add("back", typeof(string));
            Disqualification.Columns.Add("destroy", typeof(string));
            Disqualification.Columns.Add("edit", typeof(string));

            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = Disqualification.NewRow();

                    dr["input_instorage_date"] = DateTime.Parse(dt.Rows[i]["input_instorage_date"].ToString()).ToString("yyyy-MM-dd");
                    dr["goods_name"] = dt.Rows[i]["goods_name"].ToString();
                    dr["goods_reg_num"] = dt.Rows[i]["goods_reg_num"].ToString();
                    dr["input_batch_num"] = dt.Rows[i]["input_batch_num"].ToString();
                    dr["maker_name"] = dt.Rows[i]["maker_name"].ToString();
                    dr["disqualificationNum"] = dt.Rows[i]["disqualificationNum"].ToString();
                    dr["undeal_count"] = dt.Rows[i]["undeal_count"].ToString();
                    dr["back"] = dt.Rows[i]["back"].ToString();
                    dr["destroy"] = dt.Rows[i]["destroy"].ToString();
                    dr["edit"] = dt.Rows[i]["edit"].ToString();

                    Disqualification.Rows.Add(dr);
                }

            }

            return Disqualification;
        }

        private void DisqualificationPrint_Load(object sender, EventArgs e)
        {
            ReportViewer reportViewer = new ReportViewer();
            //reportViewer.ShowExportButton = false;
            reportViewer.ProcessingMode = ProcessingMode.Local;

            reportViewer.LocalReport.ReportPath = Application.StartupPath + "\\RDLC\\" + "DisqualificationReport.rdlc";
            reportViewer.LocalReport.DataSources.Add(
                new ReportDataSource("MaintenanceData_DTDisqualification", GetDisqualificationTable(dtPrint)));

            reportViewer.Dock = DockStyle.Fill;

            this.Controls.Add(reportViewer);

            reportViewer.RefreshReport();
        }
    }
}
