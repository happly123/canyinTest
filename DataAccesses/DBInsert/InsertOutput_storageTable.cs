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
        public int InsertOutput_storageRow(EntityOutput_storage outputStorage)
        {
            string SqlStr = "";
            SqlStr = "INSERT INTO TC_OUTPUT_STORAGE "
                + "(OUTPUT_CODE ,input_code ,customer_code ,output_count ,output_check_persion"
                + ",output_oper ,output_quality_persion ,output_issued ,output_packing_in ,output_packing_mid"
                + ",output_packing_out ,output_remark ,output_instorage_date ,output_checktime ,output_type"
                + ",output_backreason ,operate_type)";
            SqlStr += " VALUES ('" + outputStorage.Output_code.Trim() + "','" + outputStorage.Input_code.Trim() + "','" + outputStorage.Customer_code.Trim() + "',"
                + "" + outputStorage.Output_count + ",'" + outputStorage.Output_check_persion.Trim() + "','" + outputStorage.Output_oper.Trim() + "','" + outputStorage.Output_quality_persion.Trim() + "'"
                + ",'" + outputStorage.Output_issued.Trim() + "','" + outputStorage.Output_packing_in.Trim() + "','" + outputStorage.Output_packing_mid.Trim() + "','" + outputStorage.Output_packing_out.Trim() + "'"
                + ",'" + outputStorage.Output_remark.Trim() + "','" + outputStorage.Output_instorage_date + "','" + outputStorage.Output_checktime + "'," + outputStorage.Output_type.Trim() + ""
                + ",'" + outputStorage.Output_backreason.Trim() + "','"+outputStorage.Operate_type.Trim()+"')";

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
