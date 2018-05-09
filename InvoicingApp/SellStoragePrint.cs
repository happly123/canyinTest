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
    public partial class SellStoragePrint : Form
    {
        private DataTable dtSell = null;

        string sellType = string.Empty;
        public SellStoragePrint(DataTable dt, string typeName)
        {
            if (typeName.Equals("销售出库"))
            {
                sellType = "销 售";
            }
            else if (typeName.Equals("退货出库"))
            {
                sellType = "退 货";
            }
            else
            {
                sellType = "出 库";
            }
            this.dtSell = dt;
            InitializeComponent();

        }

        private DataTable GetSellRecordTable(DataTable dt)
        {


            DataTable dtSellRecord = new DataTable();
            dtSellRecord.Columns.Add("output_instorage_date", typeof(string));
            dtSellRecord.Columns.Add("customer_name", typeof(string));
            dtSellRecord.Columns.Add("goods_name", typeof(string));
            dtSellRecord.Columns.Add("goods_type", typeof(string));
            dtSellRecord.Columns.Add("input_batch_num", typeof(string));
            dtSellRecord.Columns.Add("goods_validity", typeof(string));
            dtSellRecord.Columns.Add("output_count", typeof(string));
            dtSellRecord.Columns.Add("terilization_num", typeof(string));
            dtSellRecord.Columns.Add("maker_name", typeof(string));
            dtSellRecord.Columns.Add("goods_reg_num", typeof(string));
            //dtSellRecord.Columns.Add("sell_price", typeof(string));
            dtSellRecord.Columns.Add("output_remark", typeof(string));

            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dtSellRecord.NewRow();
                    dr["output_instorage_date"] = DateTime.Parse(dt.Rows[i]["output_instorage_date"].ToString()).ToString("yyyy-MM-dd");
                    dr["customer_name"] = dt.Rows[i]["customer_name"].ToString();
                    dr["goods_name"] = dt.Rows[i]["goods_name"].ToString();
                    dr["goods_type"] = dt.Rows[i]["goods_type"].ToString();
                    dr["input_batch_num"] = dt.Rows[i]["input_batch_num"].ToString();
                    dr["goods_validity"] = dt.Rows[i]["goods_validity"].ToString();
                    dr["output_count"] = dt.Rows[i]["output_count"].ToString();
                    dr["terilization_num"] = dt.Rows[i]["input_quality_reg"].ToString();
                    dr["maker_name"] = dt.Rows[i]["maker_name"].ToString();
                    dr["goods_reg_num"] = dt.Rows[i]["goods_reg_num"].ToString();
                    //dr["sell_price"] = "";
                    dr["output_remark"] = dt.Rows[i]["output_remark"].ToString();
                    dtSellRecord.Rows.Add(dr);
                }

            }

            return dtSellRecord;
        }

        private void SellStoragePrint_Load(object sender, EventArgs e)
        {
            ReportViewer reportViewer = new ReportViewer();
            //reportViewer.ShowExportButton = false;
            reportViewer.ProcessingMode = ProcessingMode.Local;
            reportViewer.LocalReport.ReportPath = Application.StartupPath + "\\RDLC\\" + "SellRecordReport.rdlc";
            reportViewer.LocalReport.DataSources.Add(
                new ReportDataSource("MaintenanceData_DTSellRecord", GetSellRecordTable(dtSell)));

            ReportParameter[] parameters = new ReportParameter[1];
            parameters[0] = new ReportParameter("sellType", sellType);

            reportViewer.LocalReport.SetParameters(parameters);

            reportViewer.Dock = DockStyle.Fill;

            this.Controls.Add(reportViewer);

            reportViewer.RefreshReport();
        }
    }
}
