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
        public int InsertLoseRow(EntityLose entity)
        {
            string SqlStr = "";
            SqlStr = "insert into tc_lose(lose_code,input_code,lose_count,lose_reason,lose_applier,lose_checker,lose_datetime,lose_result,lose_remark)";
            SqlStr += " values('" + entity.Lose_code.Trim() + "','" + entity.Input_code.Trim() + "','" + entity.Lose_count + "','"+ entity.Lose_reason.Trim() +"','"+ entity.Lose_applier.Trim() +"','"+ entity.Lose_checker.Trim() +"','"+ entity.Lose_datetime +"','"+ entity.Lose_result.Trim() +"','"+ entity.Lose_remark.Trim() +"')";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SqlStr;

            ExcuteSql(sqlCommand);

            return Constants.SystemConfig.SERVER_SUCCESS;
        }
    }
}
