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
        public int InsertAuthorityTable(EntityAuthority entity)
        {
            string SqlStr = "";
            SqlStr = "insert into TC_Authority";
            SqlStr += " values('"
                + entity.Authority_user_code.Trim() + "','"
                + entity.Authority_password.Trim() + "','"
                + entity.Authority_level.Trim() + "','"
                + entity.Staff_code.Trim() + "')";

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