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
        public int InsertSystemLogTable(EntitySystemLog entity)
        {

            string SqlStr = "";
            SqlStr = "insert into tc_system_log";
            SqlStr += " values('" + entity.DateLogOn + "','" + entity.DateLogOff + "','" + entity.UserName.Trim() + "')";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SqlStr;

            ExcuteSql(sqlCommand);

            return Constants.SystemConfig.SERVER_SUCCESS;
        }
    }
}
