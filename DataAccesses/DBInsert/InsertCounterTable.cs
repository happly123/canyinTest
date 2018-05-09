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
        public int InsertCounterRow(EntityCounter entity)
        {
            string SqlStr = "";
            SqlStr = "insert into tc_counter";
            SqlStr += " values('" + entity.Counter_code.Trim() + "','" + entity.Counter_manager.Trim() + "','" + entity.Counter_type.Trim() + "')";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SqlStr;

            ExcuteSql(sqlCommand);

            return Constants.SystemConfig.SERVER_SUCCESS;
        }

    }
}
