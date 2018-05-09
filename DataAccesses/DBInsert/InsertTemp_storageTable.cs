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
        public int InsertTemp_storageTable(EntityTemp_storage entity)
        {
            string SqlStr = "";
            SqlStr = "insert into tc_temp_storage(goods_code,count)";
            SqlStr += " values('" + entity.Goods_code.Trim() + "'," + entity.Count + ")";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SqlStr;
            try
            {
                ExcuteSql(sqlCommand);
            }
            catch(Exception ex)
            {
                return Constants.SystemConfig.SERVER_ERROR;
                throw ex;
            }

            return Constants.SystemConfig.SERVER_SUCCESS;

        }
    
    }
}
