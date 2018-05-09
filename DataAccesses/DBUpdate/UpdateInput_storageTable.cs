using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InvoicingUtil;
using System.Data.SqlClient;
using System.Collections;
//*******************************************************************
/// <summary>
/// 入库表更新
/// </summary>
/// <history>
///     完成信息：吴小科      2010/07/13 完成   
///     更新信息：吴小科      2010/07/19 修改 2010/07/20 2次修改
/// </history>
//*******************************************************************
namespace DataAccesses
{
    public partial class GetData
    {
        public int UpdateInput_storageRow(EntityInput_storage entity, SearchParameter sp)
        {   //设置更新入库表SQL语句
            string SqlStr = "";
            SqlStr = "update tc_input_storage"; 
            SqlStr += " set input_goods_code='" + entity.INPUT_GOODS_CODE.Trim() + "'";
            SqlStr += " ,input_quality_reg='" + entity.INPUT_QUALITY_REG.Trim() + "',input_batch_num='" + entity.INPUT_BATCH_NUM.Trim() + "',input_arrival_count= " + entity.INPUT_ARRIVAL_COUNT + ",input_standard_count= " + entity.INPUT_STANDARD_COUNT;
            SqlStr += " ,counter_name= '" + entity.COUNTER_NAME.Trim() + "',input_maketime='" + entity.INPUT_MAKETIME + "',input_check_persion='" + entity.INPUT_CHECK_PERSION.Trim() + "',supplier_name = '"+entity.SUPPLIER_NAME.Trim()+"" ;
            SqlStr += "',input_oper= '" + entity.INPUT_OPER.Trim() + "',input_quality_persion= '" + entity.INPUT_QUALITY_PERSION.Trim() + "',input_packing_in='" + entity.INPUT_PACKING_IN.Trim() + "',QUALITY_INFO = '" + entity.QUALITY_INFO.Trim() + "',check_info='"+entity.CHECK_INFO.Trim();
            SqlStr += "',input_packing_mid='" + entity.INPUT_PACKING_MID.Trim() + "',input_packing_out='" + entity.INPUT_PACKING_OUT.Trim() + "',input_issued= '" + entity.INPUT_ISSUED.Trim() + "' ,output_code= '" + entity.OUTPUT_CODE.Trim();
            SqlStr += "' ,input_remark='" + entity.INPUT_REMARK.Trim() + "',input_instorage_date='" + entity.INPUT_INSTORAGE_DATE + "',input_type='" + entity.INPUT_TYPE + "',operate_type='" + entity.OPERATE_TYPE + "',backstorage_date = ";
            if (entity.BACKSTORAGE_DATE.ToString("yyyyMMdd").Equals("00010101"))
            {
                SqlStr += "null";
            }
            else
            {
                SqlStr +="'"+entity.BACKSTORAGE_DATE + "'";
            }
            if (entity.INPUT_CHECKTIME.ToString("yyyyMMdd").Equals("00010101"))
            {
                SqlStr += ",input_checktime= " + "null";

            }
            else
            {
                SqlStr += ",input_checktime='" +entity.INPUT_CHECKTIME+"'";
            }
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

        public int UpdateInput_storageRow2(EntityInput_storage entity, SearchParameter sp)
        {   //设置更新入库表SQL语句
            string SqlStr = "";
            SqlStr = "update tc_input_storage";
            SqlStr += " set input_standard_count= " + entity.INPUT_STANDARD_COUNT + " ,input_arrival_count= " + entity.INPUT_ARRIVAL_COUNT;
            SqlStr += " ,counter_name= '" + entity.COUNTER_NAME.Trim() + "',input_maketime='" + entity.INPUT_MAKETIME + "',input_check_persion='" + entity.INPUT_CHECK_PERSION.Trim() + "";
            SqlStr += "',input_oper= '" + entity.INPUT_OPER.Trim() + "',input_quality_persion= '" + entity.INPUT_QUALITY_PERSION.Trim() + "',input_packing_in='" + entity.INPUT_PACKING_IN.Trim() + "',QUALITY_INFO = '" + entity.QUALITY_INFO.Trim() + "',check_info='" + entity.CHECK_INFO.Trim();
            SqlStr += "',input_packing_mid='" + entity.INPUT_PACKING_MID.Trim() + "',input_packing_out='" + entity.INPUT_PACKING_OUT.Trim() + "',input_issued= '" + entity.INPUT_ISSUED.Trim() + "' ,output_code= '" + entity.OUTPUT_CODE.Trim();
            SqlStr += "' ,input_remark='" + entity.INPUT_REMARK.Trim() + "',input_instorage_date='" + entity.INPUT_INSTORAGE_DATE + "',input_type='" + entity.INPUT_TYPE + "',operate_type='" + entity.OPERATE_TYPE + "',backstorage_date = ";
            if (entity.BACKSTORAGE_DATE.ToString("yyyyMMdd").Equals("00010101"))
            {
                SqlStr += "null";
            }
            else
            {
                SqlStr += "'" + entity.BACKSTORAGE_DATE + "'";
            }
            if (entity.INPUT_CHECKTIME.ToString("yyyyMMdd").Equals("00010101"))
            {
                SqlStr += ",input_checktime= " + "null";

            }
            else
            {
                SqlStr += ",input_checktime='" + entity.INPUT_CHECKTIME + "'";
            }
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

        public int UpdateInput_storageNUM(EntityInput_storage entity, SearchParameter sp)
        {   //设置更新入库表合格数量SQL语句
            string SqlStr = "";
            SqlStr = "update tc_input_storage";
            SqlStr += " set input_standard_count = input_standard_count +" + entity.INPUT_STANDARD_COUNT ;
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



        //更新入库操作标识,出库和报损专用
        public int UpdateOperate_typeByInput_codeRow(EntityInput_storage entity)
        {
            string SqlStr = "";
            SqlStr = "update tc_input_storage set ";

            SqlStr += "operate_type = '" + entity.OPERATE_TYPE + "' ";

            SqlStr += " where input_code= '" + entity.INPUT_CODE.Trim() + "' ";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SqlStr;

            ExcuteSql(sqlCommand);

            return Constants.SystemConfig.SERVER_SUCCESS;
        }
    }
}
