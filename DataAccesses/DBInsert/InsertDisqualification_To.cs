using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InvoicingUtil;
using System.Data.SqlClient;
//*******************************************************************
/// <summary>
/// 不合格产品去向记录表插入
/// </summary>
/// <history>
///     完成信息：吴小科      2010/08/05 完成  
///     更新信息：
/// </history>
namespace DataAccesses
{
     public partial class GetData
    {
         public int InsertDisqualification_To(EntityDisqualification_To entity)
         {
             //设置插入不合格产品去向记录表SQL语句
             string SqlStr = " ";
             SqlStr = "insert into tc_disqualification_to ";
             SqlStr += " values( " + entity.DISQUALIFICATION_CODE + ", " + entity.DISQUALIFICATION_TO_COUNT + ", '" + entity.DEAL_TYPE + "', '" + entity.DEAL_DATE+"','" + entity.DEAL_ADDRESS.Trim()+"','"+entity.ISSUED.Trim()+"','"+entity.REAMARK.Trim()+"','"+entity.DEAL_OPER.Trim()+"' )";
             SqlCommand sqlCommand = new SqlCommand();
             sqlCommand.CommandText = SqlStr;
             //执行SQL语句
             ExcuteSql(sqlCommand);
             //返回操作成功结果          
             return Constants.SystemConfig.SERVER_SUCCESS;
         }
    }
}
