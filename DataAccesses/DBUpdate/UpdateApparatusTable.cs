using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InvoicingUtil;
using System.Data;
using System.Data.SqlClient;

namespace DataAccesses
{
    public partial class GetData
    {
        public int UpdateApparatusTable(EntityApparatus entity)
        {
            string SqlStr = "";
            SqlStr = "update tc_apparatus set ";

            if (entity.Apparatus_name != string.Empty)
            {
                SqlStr += "apparatus_name = '" + entity.Apparatus_name.Trim() + "' ";
            }

            if (entity.Apparatus_yxm != string.Empty)
            {
                SqlStr += ",apparatus_yxm = '" + entity.Apparatus_yxm .Trim()+ "' ";
            }

            if (entity.Apparatus_type != string.Empty)
            {
                SqlStr += ",apparatus_type = '" + entity.Apparatus_type.Trim() + "' ";
            }

            SqlStr += " where apparatus_id= '" + entity.Apparatus_id + "' ";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SqlStr;

            ExcuteSql(sqlCommand);

            return Constants.SystemConfig.SERVER_SUCCESS;
        }
    }
}
