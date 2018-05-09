using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InvoicingUtil;
using System.Data.SqlClient;
using System.Collections;

namespace DataAccesses
{
    public partial class GetData
    {
        public int UpdateMaker(EntityMaker entity)
        {
            string SqlStr = "";
                SqlStr = "update tc_maker set ";

                SqlStr += "Maker_name  = '" + entity.Maker_name.Trim() + "' ";
                SqlStr += ",Maker_yxm  = '" + entity.Maker_yxm.Trim() + "' ";
                SqlStr += ",Maker_address  = '" + entity.Maker_address.Trim() + "' ";
                SqlStr += ",Maker_quality_reg  = '" + entity.Maker_quality_reg.Trim() + "' ";
                SqlStr += ",Maker_hygiene  = '" + entity.Maker_hygiene.Trim() + "' ";
                SqlStr += ",Maker_licence  = '" + entity.Maker_licence.Trim() + "' ";
                SqlStr += ",Maker_tel  = '" + entity.Maker_tel.Trim() + "' ";
                SqlStr += ",Maker_principal  = '" + entity.Maker_principal.Trim() + "' ";
                SqlStr += ",Maker_postal_code  = '" + entity.Maker_postal_code.Trim() + "' ";
                SqlStr += ",Maker_business_scope  = '" + entity.Maker_business_scope.Trim() + "' ";
                SqlStr += ",Maker_business_goods  = '" + entity.Maker_business_goods.Trim() + "' ";
                SqlStr += " where Maker_code= '" + entity.Maker_code.Trim() + "' ";

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = SqlStr;

                ExcuteSql(sqlCommand);

                return Constants.SystemConfig.SERVER_SUCCESS;
        }
    }
}
