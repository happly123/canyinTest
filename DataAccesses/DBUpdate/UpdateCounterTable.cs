using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InvoicingUtil;
using System.Data.SqlClient;
using System.Collections;

namespace DataAccesses
{
    public partial class GetData
    {
        public int UpdateCounterTable(EntityCounter entity)
        {
            string SqlStr = "";
            SqlStr = "update tc_counter set ";

            SqlStr += "Counter_manager = '" + entity.Counter_manager.Trim() + "' ";

            SqlStr += ",Counter_type = '" + entity.Counter_type.Trim() + "' ";

            SqlStr += " where counter_code= '" + entity.Counter_code.Trim() + "' ";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SqlStr;

            ExcuteSql(sqlCommand);

            return Constants.SystemConfig.SERVER_SUCCESS;
        }
    }

}
