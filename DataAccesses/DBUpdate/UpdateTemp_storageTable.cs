using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InvoicingUtil;
using System.Data.SqlClient;
using System.Collections;
//*******************************************************************
/// <summary>
/// 临时库存表更新
/// </summary>
/// <history>
///     完成信息：吴小科      2010/07/20 完成   
///     更新信息：
/// </history>
//*******************************************************************
namespace DataAccesses
{
    public partial class GetData
    {
        public int UpdateTemp_storage(EntityTemp_storage entity, SearchParameter sp)
        {   //设置更新库存表SQL语句
            string SqlStr = "";
            SqlStr = "update tc_temp_storage";
            SqlStr += " set count= count +" + entity.Count + "";
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
