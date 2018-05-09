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
        public int InsertUnitRow(EntityUnit entity)
        {
            string SqlStr = "";
            SqlStr = "insert into tc_unit(unit_code,unit_name,unit_yxm)";
            SqlStr += " values('" + entity.Unit_code.Trim() + "','" + entity.Unit_name.Trim() + "','" + entity.Unit_yxm.Trim() + "')";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SqlStr;

            ExcuteSql(sqlCommand);

            return Constants.SystemConfig.SERVER_SUCCESS;
        }
    }
}
