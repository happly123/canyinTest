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
    public partial class MaintenancePrint : Form
    {
        Hashtable htMaintenance;
        DataAccess dataAccess = null;
        public MaintenancePrint(Hashtable ht)
        {
            this.htMaintenance = ht;
            InitializeComponent();
        }

        private DataTable LoadMaintenance()
        {
            try
            {
                dataAccess = new DataAccess();
                dataAccess.Open();

                GetData getData = new GetData(dataAccess.Connection);
                SearchParameter sp = new SearchParameter();
                sp.SetValue(":maintain_code", htMaintenance["maintain_code"].ToString());
                DataTable dt = getData.GetSingleTableByCondition("tc_maintain_detail", sp);
                //DataTable dtCompany = getData.GetSingleTable("tc_company");
                //if (dtCompany == null || dtCompany.Rows.Count == 0)
                //{
                //    MessageBox.Show("请先填写公司基本信息再进行打印！", "公司信息：", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    return dt.Clone();
                //}
                //htMaintenance.Add("company_name", "");
                DataTable dtMaintenance = new DataTable();
                //DataSet dsMaintenance = new DataSet();
                dtMaintenance.Columns.Add("maintain_detail_datetime", typeof(string));
                dtMaintenance.Columns.Add("maintain_detail_quality", typeof(string));
                dtMaintenance.Columns.Add("maintain_detail_settle", typeof(string));
                dtMaintenance.Columns.Add("maintain_detail_oper", typeof(string));
                dtMaintenance.Columns.Add("maintain_detail_remark", typeof(string));
                dtMaintenance.Columns.Add("input_batch_num", typeof(string));

                if (dt != null && dt.Rows.Count != 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow dr = dtMaintenance.NewRow();
                        dr["maintain_detail_datetime"] = DateTime.Parse(dt.Rows[i]["maintain_detail_datetime"].ToString()).ToString("yyyy-MM-dd");
                        dr["maintain_detail_quality"] = dt.Rows[i]["maintain_detail_quality"].ToString();
                        dr["maintain_detail_settle"] = dt.Rows[i]["maintain_detail_settle"].ToString();
                        dr["maintain_detail_oper"] = dt.Rows[i]["maintain_detail_oper"].ToString();
                        dr["maintain_detail_remark"] = dt.Rows[i]["maintain_detail_remark"].ToString();
                        dr["input_batch_num"] = htMaintenance["input_batch_num"];

                        dtMaintenance.Rows.Add(dr);
                    }
                }
                
                return dtMaintenance;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                dataAccess.Close();
            }

        }
        private void MaintenancePrint_Load(object sender, EventArgs e)
        {
            
            ReportViewer reportViewer = new ReportViewer();
            //reportViewer.ShowExportButton = false;
            reportViewer.ProcessingMode = ProcessingMode.Local;
            reportViewer.LocalReport.ReportPath = Application.StartupPath + "\\RDLC\\" + "MaintenanceReport.rdlc";
            reportViewer.LocalReport.DataSources.Add(
                new ReportDataSource("MaintenanceData_DTMaintenance", LoadMaintenance()));

            //if (htMaintenance["company_name"] == null)
            //{
            //    this.Close();
            //    return;
            //}
            ReportParameter[] parameters = new ReportParameter[16];
            parameters[0] = new ReportParameter("goods_name", htMaintenance["goods_name"].ToString());
            parameters[1] = new ReportParameter("goods_validity", htMaintenance["goods_validity"].ToString());
            parameters[2] = new ReportParameter("goods_type", htMaintenance["goods_type"].ToString());
            parameters[3] = new ReportParameter("goods_reg_num", htMaintenance["goods_reg_num"].ToString());
            parameters[4] = new ReportParameter("maker_name", htMaintenance["maker_name"].ToString());
            parameters[5] = new ReportParameter("maker_address", htMaintenance["maker_address"].ToString() + "(" + htMaintenance["maker_postal_code"] + ")");
            parameters[6] = new ReportParameter("maker_tel", htMaintenance["maker_tel"].ToString());
            parameters[7] = new ReportParameter("maintain_application", htMaintenance["maintain_application"].ToString());
            parameters[8] = new ReportParameter("maintain_purpose", htMaintenance["maintain_purpose"].ToString());
            parameters[9] = new ReportParameter("maintain_quality", htMaintenance["maintain_quality"].ToString());
            parameters[10] = new ReportParameter("maintain_test_items", htMaintenance["maintain_test_items"].ToString());
            parameters[11] = new ReportParameter("maintain_characters", htMaintenance["maintain_characters"].ToString());
            parameters[12] = new ReportParameter("goods_storemethod", htMaintenance["goods_storemethod"].ToString());
            parameters[13] = new ReportParameter("input_packing_in", htMaintenance["input_packing_in"].ToString());
            parameters[14] = new ReportParameter("input_packing_mid", htMaintenance["input_packing_mid"].ToString());
            parameters[15] = new ReportParameter("input_packing_out", htMaintenance["input_packing_out"].ToString());
            //parameters[16] = new ReportParameter("company_name", htMaintenance["company_name"].ToString());


            reportViewer.LocalReport.SetParameters(parameters);

            reportViewer.Dock = DockStyle.Fill;

            this.Controls.Add(reportViewer);

            reportViewer.RefreshReport();
        }
    }
}
