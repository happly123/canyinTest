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
        public int InsertMaker(EntityMaker entityMaker)
        {
            string SqlStr = "";
            SqlStr = "insert into tc_maker";
            SqlStr += " values('"
                + entityMaker.Maker_code.Trim() + "','"
                + entityMaker.Maker_name.Trim() + "','"
                + entityMaker.Maker_yxm.Trim() + "','"
                + entityMaker.Maker_address.Trim() + "','"
                + entityMaker.Maker_quality_reg.Trim() + "','"
                + entityMaker.Maker_hygiene.Trim() + "','"
                + entityMaker.Maker_licence.Trim() + "','"
                + entityMaker.Maker_tel.Trim() + "','"
                + entityMaker.Maker_principal.Trim() + "','"
                + entityMaker.Maker_postal_code.Trim() + "','"
                + entityMaker.Maker_business_scope.Trim() + "','"
                + entityMaker.Maker_business_goods.Trim() + "')";

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
