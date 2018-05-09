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
        public int InsertApparatus_quality(EntityApparatus_quality entity)
        {
            string SqlStr = "";
            SqlStr = "insert into tc_apparatus_quality";
            SqlStr += " values('"
                + entity.Apparatus_quality_code.Trim() + "','"
                + entity.Apparatus_output_code.Trim() + "','"
                + entity.Apparatus_quality_count + "','"
                + entity.Apparatus_qualityt_issued.Trim() + "','"
                + entity.Apparatus_accident_conditions.Trim() + "','"
                + entity.Apparatus_report_date + "','"
                + entity.Apparatus_accident_management.Trim() + "','"
                + entity.Apparatus_accident_management_date + "','"
                + entity.Apparatus_speaker.Trim() + "','"
                + entity.Apparatus_customer_feedback.Trim() + "','"
                + entity.Apparatus_opinion_leader.Trim() + "')";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SqlStr;
            try
            {
                ExcuteSql(sqlCommand);
            }
            catch(Exception ex)
            {
                return Constants.SystemConfig.SERVER_ERROR;
                throw ex;
            }

            return Constants.SystemConfig.SERVER_SUCCESS;
        }
    }
}
