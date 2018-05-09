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
    public partial class DevicePrint : Form
    {
        private DataTable dtPrint = null;
        public DevicePrint(DataTable dt)
        {
            this.dtPrint = dt;
            InitializeComponent();
        }

        private DataTable GetDeviceTable(DataTable dt)
        {

            DataTable dtDevice = new DataTable();
            dtDevice.Columns.Add("index", typeof(string));
            dtDevice.Columns.Add("device_code", typeof(string));
            dtDevice.Columns.Add("device_name", typeof(string));
            dtDevice.Columns.Add("device_type", typeof(string));
            dtDevice.Columns.Add("device_made", typeof(string));
            dtDevice.Columns.Add("device_date", typeof(string));
            dtDevice.Columns.Add("device_usedate", typeof(string));
            dtDevice.Columns.Add("device_address", typeof(string));
            dtDevice.Columns.Add("device_application", typeof(string));
            dtDevice.Columns.Add("staff_name", typeof(string));
            dtDevice.Columns.Add("device_remarks", typeof(string));

            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dtDevice.NewRow();

                    dr["index"] = dt.Rows[i]["index"].ToString();
                    dr["device_code"] = dt.Rows[i]["device_code"].ToString();
                    dr["device_name"] = dt.Rows[i]["device_name"].ToString();
                    dr["device_type"] = dt.Rows[i]["device_type"].ToString();
                    dr["device_made"] = dt.Rows[i]["device_made"].ToString();
                    dr["device_date"] = DateTime.Parse(dt.Rows[i]["device_date"].ToString()).ToString("yyyy-MM-dd");
                    dr["device_usedate"] = DateTime.Parse(dt.Rows[i]["device_usedate"].ToString()).ToString("yyyy-MM-dd");
                    dr["device_address"] = dt.Rows[i]["device_address"].ToString();
                    dr["device_application"] = dt.Rows[i]["device_application"].ToString();
                    dr["staff_name"] = dt.Rows[i]["staff_name"].ToString();
                    dr["device_remarks"] = dt.Rows[i]["device_remarks"].ToString();

                    dtDevice.Rows.Add(dr);
                }

            }

            return dtDevice;
        }

        private void DevicePrint_Load(object sender, EventArgs e)
        {
            ReportViewer reportViewer = new ReportViewer();
            //reportViewer.ShowExportButton = false;
            reportViewer.ProcessingMode = ProcessingMode.Local;

            reportViewer.LocalReport.ReportPath = Application.StartupPath + "\\RDLC\\" + "DeviceReport.rdlc";
            reportViewer.LocalReport.DataSources.Add(
                new ReportDataSource("MaintenanceData_DTDevice", GetDeviceTable(dtPrint)));

            reportViewer.Dock = DockStyle.Fill;

            this.Controls.Add(reportViewer);

            reportViewer.RefreshReport();
        }
    }
}
