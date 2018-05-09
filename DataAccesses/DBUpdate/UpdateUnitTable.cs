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
        public int UpdateUnitTable(EntityUnit entity)
        {
            string SqlStr = "";
            SqlStr = "update tc_unit set ";

            SqlStr += "unit_name = '" + entity.Unit_name.Trim() + "' ";

            SqlStr += ",unit_yxm = '" + entity.Unit_yxm.Trim() + "' ";

            SqlStr += " where unit_code= '" + entity.Unit_code.Trim() + "' ";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SqlStr;

            ExcuteSql(sqlCommand);

            return Constants.SystemConfig.SERVER_SUCCESS;
        }
    }
}
