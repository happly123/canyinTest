using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DataAccesses
{
    public class MakePrimaryKey : DataAccess
    {
        public MakePrimaryKey(SqlConnection conn, SqlTransaction tran)
        {
            base.Connection = conn;
            base.Transaction = tran;
        }

        public string MakeCode(string type)
        {

            DataTable dt = new DataTable();
            string serialNumber = string.Empty;
            string ruleCode = string.Empty;
            ruleCode = ConfigurationManager.AppSettings[type].ToString();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = base.Connection;
            sqlCommand.Transaction = base.Transaction;
            sqlCommand.CommandText = "select code from tc_code_seq ";
            //SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
            //da.Fill(dt);
            serialNumber = sqlCommand.ExecuteScalar().ToString();
            sqlCommand.CommandText = "update tc_code_seq set code=" + (int.Parse(serialNumber) + 1);
            sqlCommand.ExecuteNonQuery();
            string primaryKey = string.Empty;
            //int length = 10 - serialNumber.Length + 1;
            serialNumber = serialNumber.PadLeft(10, '0');
            primaryKey = ruleCode + DateTime.Now.ToString("yyyyMMdd") + serialNumber;
            return primaryKey;

        }
    }
}
