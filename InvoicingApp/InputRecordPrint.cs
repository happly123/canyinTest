using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using DataAccesses;
using InvoicingUtil;

namespace InvoicingApp
{
    public partial class InputRecordPrint : Form
    {
        DataTable dtInput = null;
        public InputRecordPrint(DataTable dt)
        {
            this.dtInput = dt;
            InitializeComponent();
        }

        private DataTable GetInputRecordTable(DataTable dt)
        {


            DataTable dtInputRecord = new DataTable();
            dtInputRecord.Columns.Add("input_instorage_date", typeof(string));
            dtInputRecord.Columns.Add("supplier_name", typeof(string));
            dtInputRecord.Columns.Add("goods_name", typeof(string));
            dtInputRecord.Columns.Add("goods_type", typeof(string));
            dtInputRecord.Columns.Add("maker_name", typeof(string));
            dtInputRecord.Columns.Add("input_arrival_count", typeof(string));
            dtInputRecord.Columns.Add("input_batch_num", typeof(string));
            dtInputRecord.Columns.Add("goods_reg_num", typeof(string));
            dtInputRecord.Columns.Add("goods_validity", typeof(string));
            dtInputRecord.Columns.Add("input_issued", typeof(string));
            dtInputRecord.Columns.Add("terilization_num", typeof(string));

            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dtInputRecord.NewRow();
                    dr["input_instorage_date"] = DateTime.Parse(dt.Rows[i]["input_instorage_date"].ToString()).ToString("yyyy-MM-dd");
                    dr["supplier_name"] = dt.Rows[i]["supplier_name"].ToString();
                    dr["goods_name"] = dt.Rows[i]["goods_name"].ToString();
                    dr["goods_type"] = dt.Rows[i]["goods_type"].ToString();
                    dr["maker_name"] = dt.Rows[i]["maker_name"].ToString();
                    //if (dt.Rows[i]["input_type"].ToString().Equals("0"))
                    //{
                    //    dr["input_arrival_count"] = dt.Rows[i]["input_standard_count"].ToString();
                    //}
                    //else
                    //{
                    dr["input_arrival_count"] = dt.Rows[i]["input_standard_count"].ToString();
                    //}

                    dr["input_batch_num"] = dt.Rows[i]["input_batch_num"].ToString();
                    dr["goods_reg_num"] = dt.Rows[i]["goods_reg_num"].ToString();
                    dr["goods_validity"] = dt.Rows[i]["goods_validity"].ToString();
                    dr["input_issued"] = dt.Rows[i]["input_issued"].ToString();
                    dr["terilization_num"] = dt.Rows[i]["input_quality_reg"].ToString();
                    dtInputRecord.Rows.Add(dr);
                }

            }

            return dtInputRecord;
        }

        private void InputRecordPrint_Load(object sender, EventArgs e)
        {
            ReportViewer reportViewer = new ReportViewer();
            //reportViewer.ShowExportButton = false;
            reportViewer.ProcessingMode = ProcessingMode.Local;
            reportViewer.LocalReport.ReportPath = Application.StartupPath + "\\RDLC\\" + "InputRecordReport.rdlc";
            reportViewer.LocalReport.DataSources.Add(
                new ReportDataSource("MaintenanceData_DTInputRecord", GetInputRecordTable(dtInput)));

            reportViewer.Dock = DockStyle.Fill;

            this.Controls.Add(reportViewer);

            reportViewer.RefreshReport();
        }
    }
}
