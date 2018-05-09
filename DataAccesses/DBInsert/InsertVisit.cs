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
        public int InsertVisit(EntityVisit entityVisit)
        {
            string SqlStr = "";
            SqlStr = "insert into tc_visit";
            SqlStr += " values('"
                + entityVisit.Visit_output_code + "','"
                + entityVisit.Visit_date + "','"
                + entityVisit.Staff_name.Trim() + "','"
                + entityVisit.Visit_man.Trim() + "','"
                + entityVisit.Visit_usage.Trim() + "','"
                + entityVisit.Visit_opinion.Trim() + "','"
                + entityVisit.Visit_remarks + "')";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SqlStr;

            ExcuteSql(sqlCommand);

            return Constants.SystemConfig.SERVER_SUCCESS;
        }
    }
}
