using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using DataAccesses;
using Microsoft.Reporting.WinForms;

namespace InvoicingApp
{
    public partial class WeaponQualityPrint : Form
    {
        Hashtable htWeaponQuality;
        public WeaponQualityPrint(Hashtable ht)
        {
            this.htWeaponQuality = ht;
            InitializeComponent();
        }

        private DataTable GetWeaponQualityTable()
        {
            DataTable dtWeaponQuality = new DataTable();
            dtWeaponQuality.Columns.Add("apparatus_goods_name", typeof(string));
            dtWeaponQuality.Columns.Add("apparatus_goods_type", typeof(string));
            dtWeaponQuality.Columns.Add("apparatus_maker_name", typeof(string));
            dtWeaponQuality.Columns.Add("apparatus_quality_count", typeof(string));
            dtWeaponQuality.Columns.Add("apparatus_customer_name", typeof(string));
            dtWeaponQuality.Columns.Add("apparatus_input_batch_num", typeof(string));
            dtWeaponQuality.Columns.Add("apparatus_accident_conditions", typeof(string));
            dtWeaponQuality.Columns.Add("apparatus_speaker", typeof(string));
            dtWeaponQuality.Columns.Add("apparatus_report_date", typeof(string));
            dtWeaponQuality.Columns.Add("apparatus_customer_feedback", typeof(string));
            dtWeaponQuality.Columns.Add("apparatus_opinion_leader", typeof(string));
            dtWeaponQuality.Columns.Add("apparatus_accident_management", typeof(string));
            dtWeaponQuality.Columns.Add("apparatus_accident_management_date", typeof(string));
            dtWeaponQuality.Columns.Add("apparatus_qualityt_issued", typeof(string));

            DataRow dr = dtWeaponQuality.NewRow();
            dr["apparatus_goods_name"] = htWeaponQuality["apparatus_goods_name"].ToString();
            dr["apparatus_goods_type"] = htWeaponQuality["apparatus_goods_type"].ToString();
            dr["apparatus_maker_name"] = htWeaponQuality["apparatus_maker_name"].ToString();
            dr["apparatus_quality_count"] = htWeaponQuality["apparatus_quality_count"].ToString();
            dr["apparatus_customer_name"] = htWeaponQuality["apparatus_customer_name"].ToString();
            dr["apparatus_input_batch_num"] = htWeaponQuality["apparatus_input_batch_num"].ToString();
            dr["apparatus_accident_conditions"] = htWeaponQuality["apparatus_accident_conditions"].ToString();
            dr["apparatus_speaker"] = htWeaponQuality["apparatus_speaker"].ToString();
            dr["apparatus_report_date"] = DateTime.Parse(htWeaponQuality["apparatus_report_date"].ToString()).ToString("yyyy-MM-dd");
            dr["apparatus_customer_feedback"] = htWeaponQuality["apparatus_customer_feedback"].ToString();
            dr["apparatus_opinion_leader"] = htWeaponQuality["apparatus_opinion_leader"].ToString();
            dr["apparatus_accident_management"] = htWeaponQuality["apparatus_accident_management"].ToString();
            dr["apparatus_accident_management_date"] = DateTime.Parse(htWeaponQuality["apparatus_accident_management_date"].ToString()).ToString("yyyy-MM-dd");
            dr["apparatus_qualityt_issued"] = htWeaponQuality["apparatus_qualityt_issued"].ToString();

            dtWeaponQuality.Rows.Add(dr);

            return dtWeaponQuality;
        }

        private void WeaponQualityPrint_Load(object sender, EventArgs e)
        {
            ReportViewer reportViewer = new ReportViewer();
            //reportViewer.ShowExportButton = false;
            reportViewer.ProcessingMode = ProcessingMode.Local;
            reportViewer.LocalReport.ReportPath = Application.StartupPath + "\\RDLC\\" + "WeaponQualityReport.rdlc";
            reportViewer.LocalReport.DataSources.Add(
                new ReportDataSource("MaintenanceData_DTWeaponQuality", GetWeaponQualityTable()));

            reportViewer.Dock = DockStyle.Fill;

            this.Controls.Add(reportViewer);

            reportViewer.RefreshReport();
        }
    }
}
