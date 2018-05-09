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
        public int UpdateMaintain_detailTable(EntityMaintain_detail entity)
        {
            string SqlStr = "";
            SqlStr = "update tc_maintain_detail set ";
            SqlStr += "Maintain_detail_datetime = '" + entity.Maintain_detail_datetime + "' ";
            SqlStr += ",Maintain_detail_quality = '" + entity.Maintain_detail_quality.Trim() + "' ";
            SqlStr += ",Maintain_detail_settle = '" + entity.Maintain_detail_settle.Trim() + "' ";
            SqlStr += ",Maintain_detail_oper = '" + entity.Maintain_detail_oper.Trim() + "' ";
            SqlStr += ",Maintain_detail_remark = '" + entity.Maintain_detail_remark.Trim() + "' ";
            SqlStr += ",Maintain_code = '" + entity.Maintain_code.Trim() + "' ";

            SqlStr += " where Maintain_detail_code= '" + entity.Maintain_detail_code + "' ";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SqlStr;

            ExcuteSql(sqlCommand);

            return Constants.SystemConfig.SERVER_SUCCESS;
        }
    }
}
