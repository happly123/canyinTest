using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InvoicingUtil;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace DataAccesses
{
    public partial class GetData
    {
        public int UpdateGoods(EntityGoods entity)
        {
            string SqlStr = "";
            SqlStr = "update tc_goods";
            SqlStr += " set goods_code = '" + entity.Goods_code.Trim() + "',goods_name='" + entity.Goods_name.Trim() + "',goods_yxm='" + entity.Goods_yxm.Trim();
            SqlStr += "',goods_reg_num='" + entity.Goods_reg_num.Trim() + "',goods_reg_mark='" + entity.Goods_reg_mark.Trim() + "',goods_type='" + entity.Goods_type.Trim();
            SqlStr += "',goods_maker='" + entity.Goods_maker.Trim() + "',goods_validity='" + entity.Goods_validity + "',goods_unit='" + entity.Goods_unit.Trim();
            SqlStr += "',goods_storemethod='" + entity.Goods_storemethod.Trim() + "',goods_appliance_code='" + entity.Goods_appliance_code.Trim() +  "'";

            SqlStr += " where goods_code= '" + entity.Goods_code.Trim() + "' ";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SqlStr;

            ExcuteSql(sqlCommand);

            return Constants.SystemConfig.SERVER_SUCCESS;

        }
    }
}
