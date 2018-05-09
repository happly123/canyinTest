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
        public int InsertApparatusRow(EntityApparatus entityApparatus)
        {
            string SqlStr = "";
            SqlStr = "insert into tc_apparatus(apparatus_code,apparatus_name, apparatus_yxm,apparatus_upcode,apparatus_type)";
            SqlStr += " values('" + entityApparatus.Apparatus_code.Trim() + "','" +  entityApparatus.Apparatus_name.Trim() + "','" + entityApparatus.Apparatus_yxm .Trim()+ "','" + entityApparatus.Apparatus_upcode.Trim() + "','" + entityApparatus.Apparatus_type.Trim() + "')";

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
