using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InvoicingUtil;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
namespace DataAccesses
{
    public partial class GetData
    {
        public int UpdateAuthorityTable(EntityAuthority entity)
        {
            string SqlStr = "";
            SqlStr = "update tc_Authority";
            SqlStr += " set authority_user_code = '" + entity.Authority_user_code.Trim()
                + "',authority_password = '" + entity.Authority_password.Trim()
                + "',authority_level = '" + entity.Authority_level.Trim()
                + "',staff_code = '" + entity.Staff_code.Trim();
            SqlStr += "' where authority_id = " + entity.Id + " ";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SqlStr;

            ExcuteSql(sqlCommand);

            return Constants.SystemConfig.SERVER_SUCCESS;
        }
    }
}
