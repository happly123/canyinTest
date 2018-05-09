using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InvoicingUtil;
using System.Data.SqlClient;
//*******************************************************************
/// <summary>
/// 入库表插入
/// </summary>
/// <history>
///     完成信息：吴小科      2010/07/13 完成   
///     更新信息：吴小科      2010/07/19 修改 2010/07/23 2次修改
/// </history>
//*******************************************************************
namespace DataAccesses
{
    public partial class GetData
    {
        public int InsertInput_storageRow(EntityInput_storage entity)
        {   //设置插入入库表SQL语句
            string SqlStr = "";
            SqlStr = "insert into tc_input_storage";
            SqlStr += " values('" + entity.INPUT_CODE.Trim() + "','" + entity.INPUT_GOODS_CODE.Trim();
            SqlStr += "','" + entity.INPUT_QUALITY_REG.Trim() + "','" + entity.INPUT_BATCH_NUM.Trim() + "'," + entity.INPUT_ARRIVAL_COUNT + "," + entity.INPUT_STANDARD_COUNT;
            SqlStr += ",'" + entity.COUNTER_NAME.Trim() + "','" + entity.SUPPLIER_NAME.Trim() + "','" + entity.INPUT_CHECK_PERSION.Trim();
            SqlStr += "','" + entity.INPUT_OPER.Trim() + "','" + entity.INPUT_QUALITY_PERSION.Trim() + "','" + entity.INPUT_ISSUED.Trim() + "','" + entity.INPUT_PACKING_IN.Trim();
            SqlStr += "','" + entity.INPUT_PACKING_MID.Trim() + "','" + entity.INPUT_PACKING_OUT.Trim() + "','" + entity.INPUT_REMARK.Trim() + "','" + entity.INPUT_INSTORAGE_DATE;
            SqlStr += "','" + entity.INPUT_MAKETIME + "',";
            if (entity.INPUT_CHECKTIME.ToString("yyyyMMdd").Equals("00010101"))
            {
                SqlStr += "null,";
            }
            else
            {
                SqlStr += "'" + entity.INPUT_CHECKTIME + "',";

            }
            SqlStr +="'" +entity.INPUT_TYPE + "','" + entity.OPERATE_TYPE + "',";
            if (entity.BACKSTORAGE_DATE.ToString("yyyyMMdd").Equals("00010101"))
            {
                SqlStr += "null,";
            }
            else
            {
                SqlStr += "'" + entity.BACKSTORAGE_DATE + "',";
            }

            SqlStr += "'" + entity.OUTPUT_CODE.Trim() +"','"+entity.QUALITY_INFO.Trim()+"','"+entity.CHECK_INFO.Trim()+ "')";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SqlStr;
            //执行SQL语句
            ExcuteSql(sqlCommand);
            //返回操作成功结果          
            return Constants.SystemConfig.SERVER_SUCCESS;

        }

    }
}
