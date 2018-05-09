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
        public int UpdateArchives(EntityArchives entity)
        {
            string SqlStr = "";
            SqlStr = "update tc_archives set ";
            SqlStr += "customer_usecode = '" + entity.Customer_usecode.Trim() + "' ";
            SqlStr += ",customer_code = '" + entity.Customer_code.Trim() + "' ";
            SqlStr += ",customer_sex = '" + entity.Customer_sex.Trim() + "' ";
            SqlStr += ",customer_age = '" + entity.Customer_age.Trim() + "' ";

            SqlStr += " where archives_id= '" + entity.Archives_id + "' ";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SqlStr;

            ExcuteSql(sqlCommand);

            return Constants.SystemConfig.SERVER_SUCCESS;
        }
    }
}
