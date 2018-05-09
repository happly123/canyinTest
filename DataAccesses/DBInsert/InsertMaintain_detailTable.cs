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
        public int InsertMaintain_detailTable(EntityMaintain_detail entity)
        {
            string SqlStr = "";
            SqlStr = "insert into tc_maintain_detail";
            SqlStr += " values('"
                + entity.Maintain_detail_datetime + "','"
                + entity.Maintain_detail_quality.Trim() + "','"
                + entity.Maintain_detail_settle.Trim() + "','"
                + entity.Maintain_detail_oper.Trim() + "','"
                + entity.Maintain_detail_remark.Trim() + "','"
                + entity.Maintain_code.Trim() + "')";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SqlStr;
            try
            {
                ExcuteSql(sqlCommand);
            }
            catch (Exception ex)
            {
                return Constants.SystemConfig.SERVER_ERROR;
                throw ex;
            }

            return Constants.SystemConfig.SERVER_SUCCESS;
        }
    }
}
