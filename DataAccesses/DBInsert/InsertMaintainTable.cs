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
        public int InsertMaintainTable(EntityMaintain entity)
        {
            string SqlStr = "";
            SqlStr = "insert into tc_maintain";
            SqlStr += " values('" 
                + entity.Maintain_code.Trim()+ "','"
                + entity.Maintain_input_code.Trim()+ "','"
                + entity.Maintain_application.Trim()+ "','"
                + entity.Maintain_purpose.Trim()+ "','"
                + entity.Maintain_quality.Trim()+ "','"
                + entity.Maintain_test_items.Trim()+ "','"
                + entity.Maintain_characters.Trim()+ "','"
                + entity.Maintain_create_date+ "')";

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
