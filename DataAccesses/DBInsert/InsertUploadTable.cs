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
        public int InsertUploadRow(EntityUpload entity)
        {
            string SqlStr = "";
            SqlStr = "insert into tc_upload_log(upload_date, upload_result,upload_ip)";
            SqlStr += " values('" + entity.Upload_date + "','" + entity.Upload_result.Trim() + "','" + entity.Upload_ip.Trim() + "')";

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
