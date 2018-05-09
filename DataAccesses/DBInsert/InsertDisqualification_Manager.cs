using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InvoicingUtil;
using System.Data.SqlClient;
//*******************************************************************
/// <summary>
/// 不合格产品临时表插入
/// </summary>
/// <history>
///     完成信息：吴小科      2010/08/04 完成
///     更新信息：
/// </history>
namespace DataAccesses
{
    public partial class GetData
    {
        public int InsertDisqualification_Manager(EntityDisqualification entity)
        {
                      
            //设置插入不合格产品临时表SQL语句
            string SqlStr = " ";
            SqlStr = "insert into tc_disqualification_manage ";
            SqlStr += " values('" + entity.Input_Code.Trim() + "', " + entity.Deal_Count + ", " + entity.Undeal_Count + ", " + entity.Disqualification_Count + " )";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SqlStr;
            //执行SQL语句
            ExcuteSql(sqlCommand);
            //返回操作成功结果          
            return Constants.SystemConfig.SERVER_SUCCESS;
        }
    }
}
