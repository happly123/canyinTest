using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InvoicingUtil;
using System.Data.SqlClient;
namespace DataAccesses
{
    public partial class GetData
    {
        public int UpdateApparatus_quality(EntityApparatus_quality entity)
        {
            string SqlStr = "";
            SqlStr = "update tc_apparatus_quality set ";

            SqlStr += "Apparatus_quality_code = '" + entity.Apparatus_quality_code.Trim() + "', ";
            SqlStr += "Apparatus_output_code = '" + entity.Apparatus_output_code.Trim() + "', ";
            SqlStr += "Apparatus_quality_count = '" + entity.Apparatus_quality_count + "', ";
            SqlStr += "Apparatus_qualityt_issued = '" + entity.Apparatus_qualityt_issued.Trim() + "', ";
            SqlStr += "Apparatus_accident_conditions = '" + entity.Apparatus_accident_conditions.Trim() + "', ";
            SqlStr += "Apparatus_report_date = '" + entity.Apparatus_report_date + "', ";
            SqlStr += "Apparatus_accident_management = '" + entity.Apparatus_accident_management.Trim() + "', ";
            SqlStr += "Apparatus_accident_management_date = '" + entity.Apparatus_accident_management_date + "', ";
            SqlStr += "Apparatus_speaker = '" + entity.Apparatus_speaker.Trim() + "', ";
            SqlStr += "Apparatus_customer_feedback = '" + entity.Apparatus_customer_feedback.Trim() + "', ";
            SqlStr += "Apparatus_opinion_leader = '" + entity.Apparatus_opinion_leader.Trim() + "' ";


            SqlStr += " where Apparatus_quality_code= '" + entity.Apparatus_quality_code.Trim() + "' ";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SqlStr;

            ExcuteSql(sqlCommand);

            return Constants.SystemConfig.SERVER_SUCCESS;
        }
    }
}
