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
        public int UpdateMaintainTable(EntityMaintain entity)
        {
            string SqlStr = "";
            SqlStr = "update tc_maintain set ";

            SqlStr += "Maintain_code = '" + entity.Maintain_code.Trim() + "' ,";
            SqlStr += "Maintain_input_code = '" + entity.Maintain_input_code.Trim() + "', ";
            SqlStr += "Maintain_application = '" + entity.Maintain_application.Trim() + "' ,";
            SqlStr += "Maintain_purpose = '" + entity.Maintain_purpose.Trim() + "' ,";
            SqlStr += "Maintain_quality = '" + entity.Maintain_quality.Trim() + "' ,";
            SqlStr += "Maintain_test_items = '" + entity.Maintain_test_items.Trim() + "' ,";
            SqlStr += "Maintain_characters = '" + entity.Maintain_characters.Trim() + "' ,";
            SqlStr += "Maintain_create_date = '" + entity.Maintain_create_date + "' ";

            SqlStr += " where Maintain_code= '" + entity.Maintain_code.Trim() + "' ";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SqlStr;

            ExcuteSql(sqlCommand);

            return Constants.SystemConfig.SERVER_SUCCESS;
        }
    }
}
