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
        public int UpdateVisit(EntityVisit entityVisit)
        {
            string SqlStr = "";
            SqlStr = "update tc_visit set ";
            SqlStr += "visit_date = '" + entityVisit.Visit_date + "' ";
            SqlStr += ",staff_name = '" + entityVisit.Staff_name.Trim() + "' ";
            SqlStr += ",visit_man = '" + entityVisit.Visit_man.Trim() + "' ";
            SqlStr += ",visit_output_code = '" + entityVisit.Visit_output_code.Trim() + "' ";
            SqlStr += ",visit_usage = '" + entityVisit.Visit_usage.Trim() + "' ";
            SqlStr += ",visit_opinion = '" + entityVisit.Visit_opinion.Trim() + "' ";
            SqlStr += ",visit_remarks = '" + entityVisit.Visit_remarks.Trim() + "' ";

            SqlStr += " where visit_id = '" + entityVisit.Visit_id + "' ";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SqlStr;

            ExcuteSql(sqlCommand);

            return Constants.SystemConfig.SERVER_SUCCESS;
  
        }
    }
}
