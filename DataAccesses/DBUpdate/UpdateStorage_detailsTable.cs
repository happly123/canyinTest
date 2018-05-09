using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InvoicingUtil;
using System.Data.SqlClient;
using System.Collections;
//*******************************************************************
/// <summary>
/// 库存表更新
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

        public int UpdateStorage_details(EntityStorage_details entity, SearchParameter sp)
        {   //设置更新库存表SQL语句
            string SqlStr = "";
            SqlStr = "update tc_storage_details";
            SqlStr += " set storage_goods_code= '" + entity.Storage_goods_code.Trim();
            SqlStr += "' ,storage_count=" + entity.Storage_count + ",storage_inputdate='" + entity.Storage_inputdate + "',storage_maker_code= '" + entity.Storage_maker_code.Trim() + "',storage_count_name='"+entity.Storage_count_name.Trim()+"'";
            ArrayList arrayList = sp.Keys();
            switch (sp.GetHashTable[arrayList[0]].GetType().Name)
            {
                case "String":
                    SqlStr += " where " + arrayList[0].ToString().Replace(":", "") + " like '" + sp.GetValue(arrayList[0].ToString()) + "%'";
                    break;
                case "Int32":
                    SqlStr += " where " + arrayList[0].ToString().Replace(":", "") + "= " + sp.GetValue(arrayList[0].ToString()) + "";
                    break;
                default:
                    SqlStr += " where " + arrayList[0].ToString().Replace(":", "") + " like '" + sp.GetValue(arrayList[0].ToString()) + "%'";
                    break;
            }
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SqlStr;
            //执行SQL语句
            ExcuteSql(sqlCommand);
            //返回操作成功结果 
            return Constants.SystemConfig.SERVER_SUCCESS;
        

        }
    

    }
}
