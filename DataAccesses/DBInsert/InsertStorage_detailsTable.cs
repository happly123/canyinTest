using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InvoicingUtil;
using System.Data.SqlClient;
//*******************************************************************
/// <summary>
/// 库存表插入
/// </summary>
/// <history>
///     完成信息：吴小科      2010/07/13 完成   
///     更新信息：吴小科      2010/07/19 修改 
/// </history>
//*******************************************************************
namespace DataAccesses
{
    public partial class GetData
    {
        public int InsertStorage_detailsRow(EntityStorage_details entity)
        {   //设置插入库存表SQL语句
            string SqlStr = "";
            SqlStr = "insert into tc_storage_details";
            SqlStr += " values('" + entity.Storage_code.Trim() + "','" + entity.Storage_input_code.Trim() + "','" + entity.Storage_goods_code.Trim() + "'," + entity.Storage_count;
            SqlStr += ",'" + entity.Storage_inputdate + "','" + entity.Storage_maker_code.Trim() + "','" +entity.Storage_count_name.Trim()+ "')";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SqlStr;
            //执行SQL语句
            ExcuteSql(sqlCommand);
            //返回操作成功结果 
            return Constants.SystemConfig.SERVER_SUCCESS;

        }



    }
}
