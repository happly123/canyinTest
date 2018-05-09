using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InvoicingUtil;
using System.Data.SqlClient;
using System.Collections;
//*******************************************************************
/// <summary>
/// 不合格产品临时表更新
/// </summary>
/// <history>
///     完成信息：吴小科      2010/08/04 完成   
///     更新信息：
/// </history>
//*******************************************************************
namespace DataAccesses
{
    public partial class GetData
    {
        public int UpdateDisqualification_manage(EntityDisqualification entity, SearchParameter sp)
        {   //设置更新不合格产品临时表SQL语句
            string SqlStr = "";
            SqlStr = "update tc_disqualification_manage ";
            SqlStr += " set deal_count =  " + entity.Deal_Count + ",undeal_count = " + entity.Undeal_Count + ",disqualification_count =  " + entity.Disqualification_Count;
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

        public int UpdateDisqualification_manage_NUM(EntityDisqualification entity, SearchParameter sp)
        {   //设置更新不合格产品临时表相关数量SQL语句
            string SqlStr = "";
            SqlStr = "update tc_disqualification_manage ";
            SqlStr += " set deal_count = deal_count + " + entity.Deal_Count + ",undeal_count = undeal_count + " + entity.Undeal_Count + ",disqualification_count =  disqualification_count +" + entity.Disqualification_Count;
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
