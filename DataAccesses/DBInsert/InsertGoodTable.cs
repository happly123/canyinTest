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
        public int InsertGoods(EntityGoods entity)
        {
            string SqlStr = "";
            SqlStr = "insert into tc_goods";
            SqlStr += " values('" + entity.Goods_code.Trim() + "','" + entity.Goods_name.Trim() + "','" + entity.Goods_yxm.Trim();
            SqlStr += "','" + entity.Goods_reg_num.Trim() + "','" + entity.Goods_reg_mark.Trim() + "','" + entity.Goods_type.Trim();
            SqlStr += "','" + entity.Goods_maker.Trim() + "','" + entity.Goods_validity + "','" + entity.Goods_unit.Trim();
            SqlStr += "','" + entity.Goods_storemethod.Trim() + "','" + entity.Goods_appliance_code.Trim() +"','"+ entity.Goods_batch_num.Trim() + "')";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SqlStr;
           
            ExcuteSql(sqlCommand);
          
            return Constants.SystemConfig.SERVER_SUCCESS;
           
        }


   
    }
}
