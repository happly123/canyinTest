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
        public int InsertArchives(EntityArchives entityArchives)
        {
            string SqlStr = "";
            SqlStr = "insert into tc_archives";
            SqlStr += " values('"
                + entityArchives.Customer_usecode.Trim() + "','"
                + entityArchives.Customer_code.Trim() + "','"
                + entityArchives.Customer_sex.Trim() + "','"
                + entityArchives.Customer_age.Trim() + "')";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SqlStr;
            try
            {
                ExcuteSql(sqlCommand);
            }
            catch
            {
                return Constants.SystemConfig.SERVER_ERROR;
            }

            return Constants.SystemConfig.SERVER_SUCCESS;
        }
    }
}
