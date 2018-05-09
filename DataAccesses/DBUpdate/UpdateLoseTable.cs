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
        public int UpdateLoseTable(EntityLose entity)
        {
            string SqlStr = "";
            SqlStr = "update tc_lose set ";

            SqlStr += "input_code = '" + entity.Input_code.Trim() + "' ,";
            SqlStr += "lose_count = '" + entity.Lose_count + "', ";
            SqlStr += "lose_reason = '" + entity.Lose_reason.Trim() + "' ,";
            SqlStr += "lose_applier = '" + entity.Lose_applier.Trim() + "' ,";
            SqlStr += "lose_checker = '" + entity.Lose_checker.Trim() + "' ,";
            SqlStr += "lose_datetime = '" + entity.Lose_datetime + "' ,";
            SqlStr += "lose_result = '" + entity.Lose_result.Trim() + "' ,";
            SqlStr += "lose_remark = '" + entity.Lose_remark.Trim() + "' ";

            SqlStr += " where lose_code= '" + entity.Lose_code.Trim() + "' ";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SqlStr;

            ExcuteSql(sqlCommand);

            return Constants.SystemConfig.SERVER_SUCCESS;
        }
    }
}
