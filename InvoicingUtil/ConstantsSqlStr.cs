using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvoicingUtil
{
    public partial class Constants
    {
        public class SqlStr
        {    /// <summary>
            /// 取入库表关联产品表相关信息goods_reg_num
            /// </summary>
            public const string TC_INPUT_INIT_STORAGE_LEFTJOIN_GOODS = "SELECT TC_INPUT_STORAGE.INPUT_CODE,TC_GOODS.GOODS_NAME,TC_GOODS.GOODS_TYPE,TC_MAKER.MAKER_NAME, TC_GOODS.GOODS_UNIT,TC_INPUT_STORAGE.INPUT_STANDARD_COUNT,TC_INPUT_STORAGE.INPUT_BATCH_NUM, TC_INPUT_STORAGE.INPUT_MAKETIME,TC_GOODS.GOODS_VALIDITY,TC_INPUT_STORAGE.INPUT_QUALITY_REG,TC_INPUT_STORAGE.SUPPLIER_NAME,TC_GOODS.GOODS_REG_NUM,TC_GOODS.GOODS_YXM ,TC_INPUT_STORAGE.INPUT_TYPE, TC_INPUT_STORAGE.INPUT_ISSUED,TC_INPUT_STORAGE.INPUT_CHECKTIME,TC_INPUT_STORAGE.COUNTER_NAME,TC_INPUT_STORAGE.INPUT_INSTORAGE_DATE, TC_INPUT_STORAGE.OPERATE_TYPE,"
                + " TC_INPUT_STORAGE.BACKSTORAGE_DATE,TC_INPUT_STORAGE.OUTPUT_CODE,"
                + "TC_INPUT_STORAGE.INPUT_GOODS_CODE, TC_INPUT_STORAGE.INPUT_CHECK_PERSION, TC_INPUT_STORAGE.INPUT_OPER,"
                + "TC_INPUT_STORAGE.INPUT_QUALITY_PERSION,"
                + " TC_INPUT_STORAGE.INPUT_REMARK,TC_INPUT_STORAGE.INPUT_PACKING_IN,TC_INPUT_STORAGE.INPUT_ARRIVAL_COUNT,TC_INPUT_STORAGE.INPUT_PACKING_OUT,TC_INPUT_STORAGE.INPUT_PACKING_MID,TC_INPUT_STORAGE.QUALITY_INFO,TC_INPUT_STORAGE.CHECK_INFO FROM TC_INPUT_STORAGE LEFT JOIN TC_GOODS ON TC_INPUT_STORAGE.INPUT_GOODS_CODE = TC_GOODS.GOODS_CODE LEFT JOIN TC_MAKER ON TC_GOODS.GOODS_MAKER = TC_MAKER.MAKER_CODE ";



            public const string TC_INPUT_INIT_STORAGE_LEFTJOIN_GOODS_LEFTJOIN_TC_OUTPUT_STORAGE_LEFTJOIN_TC_CUSTOMER = "SELECT TC_INPUT_STORAGE.INPUT_CODE,TC_CUSTOMER.CUSTOMER_NAME,TC_GOODS.GOODS_NAME,TC_GOODS.GOODS_REG_NUM,TC_OUTPUT_STORAGE.OUTPUT_CODE,TC_OUTPUT_STORAGE.OUTPUT_INSTORAGE_DATE,TC_INPUT_STORAGE.INPUT_INSTORAGE_DATE,TC_INPUT_STORAGE.INPUT_STANDARD_COUNT,TC_INPUT_STORAGE.INPUT_ISSUED,TC_INPUT_STORAGE.INPUT_CHECK_PERSION,TC_GOODS.GOODS_YXM ,TC_CUSTOMER.CUSTOMER_YXM,TC_INPUT_STORAGE.INPUT_BATCH_NUM,TC_INPUT_STORAGE.INPUT_TYPE,TC_INPUT_STORAGE.INPUT_MAKETIME, TC_INPUT_STORAGE.BACKSTORAGE_DATE,TC_INPUT_STORAGE.INPUT_PACKING_OUT,TC_INPUT_STORAGE.INPUT_PACKING_MID,TC_INPUT_STORAGE.INPUT_PACKING_IN,TC_INPUT_STORAGE.INPUT_QUALITY_REG,TC_INPUT_STORAGE.INPUT_REMARK ,TC_INPUT_STORAGE.COUNTER_NAME,TC_INPUT_STORAGE.INPUT_ARRIVAL_COUNT,"
                + " TC_GOODS.GOODS_CODE,TC_OUTPUT_STORAGE.OUTPUT_TYPE,TC_OUTPUT_STORAGE.OUTPUT_COUNT,TC_INPUT_STORAGE.QUALITY_INFO,TC_INPUT_STORAGE.CHECK_INFO "
                + " FROM TC_INPUT_STORAGE LEFT OUTER JOIN TC_GOODS ON TC_INPUT_STORAGE.INPUT_GOODS_CODE = TC_GOODS.GOODS_CODE "
                + " LEFT OUTER JOIN TC_SUPPLIER ON TC_INPUT_STORAGE.SUPPLIER_NAME = TC_SUPPLIER.SUPPLIER_NAME"
                + " LEFT OUTER JOIN TC_OUTPUT_STORAGE ON TC_INPUT_STORAGE.OUTPUT_CODE = TC_OUTPUT_STORAGE.OUTPUT_CODE"
                + " LEFT OUTER JOIN TC_CUSTOMER ON TC_OUTPUT_STORAGE.CUSTOMER_CODE =TC_CUSTOMER.CUSTOMER_CODE";
           
            
            public const string TC_INPUT_STORAGE_LEFTJOIN_OUTPUT_STORAGE = "SELECT TC_OUTPUT_STORAGE.OUTPUT_CODE,TC_CUSTOMER.CUSTOMER_NAME,TC_GOODS.GOODS_NAME,TC_INPUT_STORAGE.SUPPLIER_NAME,TC_OUTPUT_STORAGE.OUTPUT_COUNT,TC_OUTPUT_STORAGE.OUTPUT_INSTORAGE_DATE,TC_OUTPUT_STORAGE.OUTPUT_CHECKTIME,TC_OUTPUT_STORAGE.OUTPUT_OPER,TC_OUTPUT_STORAGE.OUTPUT_CHECK_PERSION,TC_OUTPUT_STORAGE.INPUT_CODE,TC_CUSTOMER.CUSTOMER_YXM,TC_OUTPUT_STORAGE.CUSTOMER_CODE,TC_OUTPUT_STORAGE.OUTPUT_QUALITY_PERSION,TC_OUTPUT_STORAGE.OUTPUT_ISSUED,TC_OUTPUT_STORAGE.OUTPUT_PACKING_IN,TC_OUTPUT_STORAGE.OUTPUT_PACKING_MID,TC_OUTPUT_STORAGE.OUTPUT_PACKING_OUT,TC_OUTPUT_STORAGE.OUTPUT_REMARK,TC_OUTPUT_STORAGE.OUTPUT_TYPE,TC_OUTPUT_STORAGE.OUTPUT_BACKREASON,TC_OUTPUT_STORAGE.OPERATE_TYPE,TC_INPUT_STORAGE.INPUT_GOODS_CODE,TC_INPUT_STORAGE.INPUT_MAKETIME,TC_INPUT_STORAGE.INPUT_INSTORAGE_DATE,TC_INPUT_STORAGE.INPUT_BATCH_NUM,TC_INPUT_STORAGE.INPUT_QUALITY_REG  FROM TC_OUTPUT_STORAGE LEFT OUTER JOIN TC_INPUT_STORAGE ON TC_OUTPUT_STORAGE.INPUT_CODE = TC_INPUT_STORAGE.INPUT_CODE "
                + " LEFT OUTER JOIN TC_SUPPLIER ON TC_INPUT_STORAGE.SUPPLIER_NAME = TC_SUPPLIER.SUPPLIER_NAME"
                + " LEFT OUTER JOIN TC_GOODS ON TC_INPUT_STORAGE.INPUT_GOODS_CODE = TC_GOODS.GOODS_CODE"
                + " LEFT OUTER JOIN TC_CUSTOMER ON TC_OUTPUT_STORAGE.CUSTOMER_CODE =TC_CUSTOMER.CUSTOMER_CODE";
            /// <summary>
            /// 销售小窗体SQL
            /// </summary>
            public const string TC_INPUT_STORAGE_LEFTJOIN_OUTPUT_STORAGE2 = "select TC_OUTPUT_STORAGE.OUTPUT_CODE,TC_CUSTOMER.CUSTOMER_NAME,TC_CUSTOMER.customer_tel,TC_GOODS.GOODS_NAME,TC_INPUT_STORAGE.SUPPLIER_NAME,TC_OUTPUT_STORAGE.OUTPUT_COUNT,TC_OUTPUT_STORAGE.OUTPUT_INSTORAGE_DATE,TC_OUTPUT_STORAGE.OUTPUT_CHECKTIME,TC_OUTPUT_STORAGE.OUTPUT_OPER,TC_OUTPUT_STORAGE.OUTPUT_CHECK_PERSION,TC_OUTPUT_STORAGE.INPUT_CODE,TC_CUSTOMER.CUSTOMER_YXM,TC_OUTPUT_STORAGE.CUSTOMER_CODE,TC_OUTPUT_STORAGE.OUTPUT_QUALITY_PERSION,TC_OUTPUT_STORAGE.OUTPUT_ISSUED,TC_OUTPUT_STORAGE.OUTPUT_PACKING_IN,TC_OUTPUT_STORAGE.OUTPUT_PACKING_MID,TC_OUTPUT_STORAGE.OUTPUT_PACKING_OUT,TC_OUTPUT_STORAGE.OUTPUT_REMARK,TC_OUTPUT_STORAGE.OUTPUT_TYPE,TC_OUTPUT_STORAGE.OUTPUT_BACKREASON,TC_OUTPUT_STORAGE.OPERATE_TYPE,TC_INPUT_STORAGE.INPUT_GOODS_CODE,TC_INPUT_STORAGE.INPUT_MAKETIME,TC_INPUT_STORAGE.INPUT_INSTORAGE_DATE,TC_INPUT_STORAGE.INPUT_BATCH_NUM,TC_INPUT_STORAGE.INPUT_QUALITY_REG,isnull((tc_output_storage.output_count-back.backcount),output_count) as reloutput_count"
                + " from tc_output_storage left join (select distinct output_code,sum(input_arrival_count) as backcount from tc_input_storage where input_type='3' group by output_code ) as back on tc_output_storage.output_code=back.output_code"
                + " left join tc_input_storage on tc_output_storage.input_code=tc_input_storage.input_code"
                + " LEFT  JOIN TC_SUPPLIER ON TC_INPUT_STORAGE.SUPPLIER_NAME = TC_SUPPLIER.SUPPLIER_NAME"
                + " left join tc_goods on TC_INPUT_STORAGE.input_goods_code=tc_goods.goods_code"
                + " LEFT  JOIN TC_CUSTOMER ON TC_OUTPUT_STORAGE.CUSTOMER_CODE =TC_CUSTOMER.CUSTOMER_CODE"
                + " where tc_output_storage.output_type='0' and isnull((tc_output_storage.output_count-back.backcount),output_count)<>0 :CONDITION1";

            public const string TC_STORAGE_COUNT = "SELECT  TC_GOODS.GOODS_NAME,TC_GOODS.GOODS_TYPE,TC_MAKER.MAKER_NAME, TC_GOODS.GOODS_UNIT,TC_TEMP_STORAGE.COUNT, TC_GOODS.GOODS_VALIDITY FROM TC_TEMP_STORAGE "	
                + " LEFT OUTER JOIN TC_GOODS ON TC_TEMP_STORAGE.GOODS_CODE = TC_GOODS.GOODS_CODE"
                + " LEFT OUTER JOIN TC_MAKER ON TC_GOODS.GOODS_MAKER = TC_MAKER.MAKER_CODE  ";

            public const string TC_DISQUALIFICATION_MANAGER = "SELECT TC_INPUT_STORAGE.INPUT_CODE,TC_INPUT_STORAGE.INPUT_INSTORAGE_DATE,TC_GOODS.GOODS_NAME,TC_GOODS.GOODS_REG_NUM,TC_INPUT_STORAGE.INPUT_BATCH_NUM,TC_MAKER.MAKER_NAME, TC_GOODS.GOODS_UNIT,TC_DISQUALIFICATION_MANAGE.DISQUALIFICATION_COUNT,TC_DISQUALIFICATION_MANAGE.DEAL_COUNT,TC_DISQUALIFICATION_MANAGE.UNDEAL_COUNT,TC_GOODS.GOODS_YXM,TC_DISQUALIFICATION_MANAGE.DISQUALIFICATION_CODE,TC_INPUT_STORAGE.INPUT_GOODS_CODE,TC_INPUT_STORAGE.OPERATE_TYPE FROM TC_DISQUALIFICATION_MANAGE "
                + " LEFT OUTER JOIN TC_INPUT_STORAGE ON TC_DISQUALIFICATION_MANAGE.INPUT_CODE = TC_INPUT_STORAGE.INPUT_CODE"  
                + " LEFT OUTER JOIN TC_GOODS ON TC_INPUT_STORAGE.INPUT_GOODS_CODE = TC_GOODS.GOODS_CODE "
                + " LEFT OUTER JOIN TC_MAKER ON TC_GOODS.GOODS_MAKER = TC_MAKER.MAKER_CODE  ";

            public const string TC_DISQUALIFICATION_TO = "SELECT TC_GOODS.GOODS_NAME,TC_GOODS.GOODS_REG_NUM,TC_INPUT_STORAGE.INPUT_BATCH_NUM,TC_MAKER.MAKER_NAME,TC_DISQUALIFICATION_TO.DISQUALIFICATION_TO_COUNT, CASE WHEN TC_DISQUALIFICATION_TO.DEAL_TYPE = '0' THEN '返厂' WHEN TC_DISQUALIFICATION_TO.DEAL_TYPE = '1' THEN '销毁' WHEN TC_DISQUALIFICATION_TO.DEAL_TYPE "
                + "= '2' THEN '维修' END AS 'DISQUALIFICATION_TYPE', TC_INPUT_STORAGE.INPUT_INSTORAGE_DATE,TC_DISQUALIFICATION_TO.DEAL_DATE,TC_DISQUALIFICATION_TO.REAMARK,TC_DISQUALIFICATION_TO.ISSUED,TC_DISQUALIFICATION_TO.DEAL_OPER,TC_DISQUALIFICATION_TO.DEAL_ADDRESS,TC_DISQUALIFICATION_MANAGE.UNDEAL_COUNT,TC_DISQUALIFICATION_TO.DISQUALIFICATION_TO_CODE FROM TC_DISQUALIFICATION_TO "
                + " LEFT OUTER JOIN TC_DISQUALIFICATION_MANAGE ON TC_DISQUALIFICATION_TO.DISQUALIFICATION_CODE = TC_DISQUALIFICATION_MANAGE.DISQUALIFICATION_CODE"
                + " LEFT OUTER JOIN TC_INPUT_STORAGE ON TC_DISQUALIFICATION_MANAGE.INPUT_CODE = TC_INPUT_STORAGE.INPUT_CODE"
                 + " LEFT OUTER JOIN TC_GOODS ON TC_INPUT_STORAGE.INPUT_GOODS_CODE = TC_GOODS.GOODS_CODE "
                + " LEFT OUTER JOIN TC_MAKER ON TC_GOODS.GOODS_MAKER = TC_MAKER.MAKER_CODE  ";
            /// <summary>           
            /// 取入库表所有记录关联产品表信息	
            /// </summary>
            public const string TC_INPUT_STORAGE_LEFTJOIN_GOODS = "SELECT TC_INPUT_STORAGE.INPUT_CODE, TC_INPUT_STORAGE.INPUT_TYPE, TC_GOODS.GOODS_NAME,"
                + " TC_GOODS.GOODS_TYPE, TC_INPUT_STORAGE.SUPPLIER_NAME, TC_MAKER.MAKER_NAME, "
                + " TC_INPUT_STORAGE.INPUT_STANDARD_COUNT,TC_INPUT_STORAGE.INPUT_ARRIVAL_COUNT,TC_INPUT_STORAGE.INPUT_ARRIVAL_COUNT, TC_INPUT_STORAGE.INPUT_BATCH_NUM, "
                + " TC_INPUT_STORAGE.INPUT_INSTORAGE_DATE, TC_INPUT_STORAGE.INPUT_MAKETIME, "
                + " TC_GOODS.GOODS_REG_NUM, TC_GOODS.GOODS_VALIDITY, TC_INPUT_STORAGE.INPUT_CHECK_PERSION,TC_INPUT_STORAGE.INPUT_ISSUED, "
                + " TC_INPUT_STORAGE.INPUT_CHECKTIME ,TC_INPUT_STORAGE.INPUT_QUALITY_REG "
                + " FROM TC_INPUT_STORAGE LEFT OUTER JOIN TC_GOODS ON TC_INPUT_STORAGE.INPUT_GOODS_CODE = TC_GOODS.GOODS_CODE "
                + " LEFT OUTER JOIN TC_MAKER ON TC_GOODS.GOODS_MAKER = TC_MAKER.MAKER_CODE ";

            public const string TC_GOODS_LEFTJOIN_TC_MAKER = "SELECT TC_GOODS.GOODS_CODE,TC_GOODS.GOODS_NAME,TC_GOODS.GOODS_REG_MARK,TC_GOODS.GOODS_TYPE,TC_GOODS.GOODS_REG_NUM,TC_GOODS.GOODS_MAKER,TC_GOODS.GOODS_VALIDITY,TC_GOODS.GOODS_UNIT,TC_GOODS.GOODS_YXM,TC_GOODS.GOODS_STOREMETHOD,TC_GOODS.GOODS_APPLIANCE_CODE,TC_MAKER.MAKER_CODE,TC_MAKER.MAKER_NAME"
                + " FROM TC_GOODS LEFT JOIN TC_MAKER ON TC_GOODS.GOODS_MAKER = TC_MAKER.MAKER_CODE";

            public const string TC_OUTPUT_STORAGE_LEFTJOIN_TC_CUSTOMER_LEFTJOIN_TC_INPUT_STORAGE_LEFTJOIN_TC_GOODS = "SELECT OS.OUTPUT_CODE ,OS.OUTPUT_INSTORAGE_DATE ,OS.OUTPUT_COUNT ,OS.OUTPUT_BACKREASON ,OS.OUTPUT_CHECKTIME,"
                + "OS.OUTPUT_REMARK,OS.OUTPUT_PACKING_OUT,OS.OUTPUT_PACKING_MID,OS.OUTPUT_PACKING_IN,OS.OUTPUT_ISSUED,OS.OUTPUT_QUALITY_PERSION,OS.OUTPUT_OPER,"
                + "OS.OUTPUT_CHECK_PERSION ,CUSTOMER.CUSTOMER_NAME ,OS.OPERATE_TYPE ,"
                + "INPUTSTORAGE.INPUT_CODE ,INPUTSTORAGE.INPUT_GOODS_CODE ,INPUTSTORAGE.INPUT_MAKETIME ,INPUTSTORAGE.INPUT_BATCH_NUM ,INPUTSTORAGE.INPUT_QUALITY_REG ,"
                + "GOODS.GOODS_NAME ,GOODS.GOODS_VALIDITY ,GOODS.GOODS_REG_NUM "
                + "FROM TC_OUTPUT_STORAGE AS OS LEFT JOIN  TC_CUSTOMER AS CUSTOMER ON OS.CUSTOMER_CODE = CUSTOMER.CUSTOMER_CODE "
                + " LEFT JOIN (TC_INPUT_STORAGE AS INPUTSTORAGE LEFT JOIN TC_GOODS AS GOODS ON INPUTSTORAGE.INPUT_GOODS_CODE = GOODS.GOODS_CODE) ON OS.INPUT_CODE = INPUTSTORAGE.INPUT_CODE";

            //按入库编号取得产品实际剩余数量
            public const string TC_INPUT_STORAGE_LEFTJOIN_TC_OUTPUT_STORAGE_LEFTJOIN_TC_GOODS = "SELECT TC_INPUT_STORAGE.INPUT_CODE,TC_INPUT_STORAGE.INPUT_INSTORAGE_DATE ,TC_INPUT_STORAGE.INPUT_MAKETIME,TC_INPUT_STORAGE.SUPPLIER_NAME ,TC_GOODS.GOODS_NAME ,"
                + "TC_GOODS.GOODS_CODE ,TC_GOODS.GOODS_REG_MARK ,TC_GOODS.GOODS_TYPE ,TC_GOODS.GOODS_VALIDITY,"
                + "ISNULL(DERIVEDTBL_1.OUTPUT_COUNT, 0) AS OUTPUT_COUNT, "
                + "ISNULL(DERIVEDTBL_2.LOSE_COUNT, 0) AS LOSE_COUNT, "
                + "ISNULL(TC_INPUT_STORAGE.INPUT_STANDARD_COUNT, 0) AS INPUT_COUNT,"
                + "(ISNULL(TC_INPUT_STORAGE.INPUT_STANDARD_COUNT, 0)-ISNULL(DERIVEDTBL_2.LOSE_COUNT, 0)-ISNULL(DERIVEDTBL_1.OUTPUT_COUNT,0)) AS '剩余数量'"
                + " FROM TC_INPUT_STORAGE "
                + " LEFT OUTER JOIN TC_GOODS ON TC_INPUT_STORAGE.INPUT_GOODS_CODE = TC_GOODS.GOODS_CODE "
                + " LEFT OUTER JOIN "
                + " (SELECT DISTINCT INPUT_CODE, SUM(OUTPUT_COUNT) AS OUTPUT_COUNT "
                + " FROM TC_OUTPUT_STORAGE GROUP BY INPUT_CODE) AS DERIVEDTBL_1 "
                + " ON TC_INPUT_STORAGE.INPUT_CODE = DERIVEDTBL_1.INPUT_CODE "
                + " LEFT OUTER JOIN (SELECT DISTINCT INPUT_CODE, SUM(LOSE_COUNT) AS LOSE_COUNT "
                + " FROM TC_LOSE GROUP BY INPUT_CODE) AS DERIVEDTBL_2 "
                + " ON TC_INPUT_STORAGE.INPUT_CODE = DERIVEDTBL_2.INPUT_CODE ";

            //养护管理,养护记录查询
            public const string TC_MAINTAIN_LEFTJOIN_TC_TC_INPUT_STORAGE_LEFTJOIN_TC_GOODS_LEFTJOIN_TC_MAKER = ""
               + "SELECT TC_INPUT_STORAGE.INPUT_BATCH_NUM, TC_MAINTAIN.maintain_code,TC_MAINTAIN.maintain_input_code,TC_MAINTAIN.maintain_application,TC_MAINTAIN.maintain_purpose,"
               + "TC_GOODS.GOODS_TYPE,TC_GOODS.GOODS_REG_NUM,TC_GOODS.GOODS_STOREMETHOD,TC_GOODS.GOODS_NAME,TC_GOODS.GOODS_VALIDITY,TC_GOODS.GOODS_YXM,"
               + "TC_MAKER.MAKER_NAME,TC_MAKER.MAKER_POSTAL_CODE,TC_MAKER.MAKER_ADDRESS,TC_MAKER.MAKER_TEL ,"
               + "TC_INPUT_STORAGE.INPUT_PACKING_IN,TC_INPUT_STORAGE.INPUT_PACKING_MID,TC_INPUT_STORAGE.INPUT_PACKING_OUT,"
               + "TC_MAINTAIN.maintain_quality,TC_MAINTAIN.maintain_test_items,TC_MAINTAIN.maintain_characters,TC_MAINTAIN.maintain_create_date "
               + "FROM TC_MAINTAIN LEFT JOIN TC_INPUT_STORAGE ON TC_MAINTAIN.MAINTAIN_INPUT_CODE = TC_INPUT_STORAGE.INPUT_CODE "
               + "LEFT JOIN TC_GOODS ON TC_INPUT_STORAGE.INPUT_GOODS_CODE = TC_GOODS.GOODS_CODE LEFT JOIN TC_MAKER ON TC_MAKER.MAKER_CODE = TC_GOODS.GOODS_MAKER";
            /// <summary>
            /// 不良记录查询
            /// </summary>
            public const string TC_APPARATUS_QUALITY_SELECT = ""
               + "SELECT APP.*,"
               + "OUT.INPUT_CODE,OUT.CUSTOMER_CODE,OUT.OUTPUT_COUNT,"
               + "INPUT.INPUT_GOODS_CODE,INPUT.INPUT_BATCH_NUM,INPUT.SUPPLIER_NAME,"
               + "GOODS.GOODS_NAME,GOODS.GOODS_TYPE,"
               + "MAKER.MAKER_NAME,"
               + "CUSTOMER.CUSTOMER_NAME "
               + "FROM TC_APPARATUS_QUALITY AS APP "
               + "LEFT JOIN TC_OUTPUT_STORAGE AS OUT ON APP.APPARATUS_OUTPUT_CODE = OUT.OUTPUT_CODE "
               + "LEFT JOIN TC_INPUT_STORAGE AS INPUT ON OUT.INPUT_CODE = INPUT.INPUT_CODE "
               + "LEFT JOIN TC_GOODS AS GOODS ON INPUT.INPUT_GOODS_CODE = GOODS.GOODS_CODE "
               + "LEFT JOIN TC_MAKER AS MAKER ON GOODS.GOODS_MAKER = MAKER.MAKER_CODE "
               + "LEFT JOIN TC_CUSTOMER AS CUSTOMER ON OUT.CUSTOMER_CODE = CUSTOMER.CUSTOMER_CODE ";

            public const string TC_OUTPUT_STORAGE_LEFTJOIN_TC_INPUT_STORAGE_LEFTJOIN_TC_GOODS = ""
                + " SELECT OS.OUTPUT_CODE ,OS.INPUT_CODE ,OS.OUTPUT_COUNT ,OS.OUTPUT_REMARK ,OS.OUTPUT_CHECKTIME ,OS.OUTPUT_INSTORAGE_DATE ,OS.OUTPUT_OPER ,"
                + " OS.OUTPUT_QUALITY_PERSION ,OS.OUTPUT_CHECK_PERSION ,OS.OUTPUT_ISSUED ,OS.OUTPUT_PACKING_OUT ,OS.OUTPUT_PACKING_MID , "
                + " OS.OUTPUT_PACKING_IN ,OS.OUTPUT_BACKREASON , "
                + " INPUTSTORAGE.INPUT_BATCH_NUM ,INPUTSTORAGE.INPUT_MAKETIME ,INPUTSTORAGE.SUPPLIER_NAME ,INPUTSTORAGE.INPUT_GOODS_CODE ,"
                + " GOODS.GOODS_NAME ,GOODS.GOODS_TYPE ,GOODS.GOODS_UNIT ,GOODS.GOODS_VALIDITY ,GOODS.GOODS_REG_NUM"
                + " FROM TC_OUTPUT_STORAGE AS OS "
                + " LEFT JOIN (TC_INPUT_STORAGE AS INPUTSTORAGE LEFT JOIN TC_GOODS AS GOODS ON INPUTSTORAGE.INPUT_GOODS_CODE = GOODS.GOODS_CODE) "
                + " ON OS.INPUT_CODE = INPUTSTORAGE.INPUT_CODE";

            /// <summary>
            /// 自定义条件，查询入库统计
            /// </summary>
            public const string tc_input_storage_count = " SELECT  tc_goods.goods_name,derivedtbl_1.input_count, tc_goods.goods_unit,tc_goods.goods_type,tc_maker.maker_name,tc_goods.goods_validity "
                + " FROM (SELECT DISTINCT input_goods_code, SUM(input_standard_count) AS input_count FROM tc_input_storage "
                + " :CONDITION1 "
                + " GROUP BY input_goods_code )"
                + " AS derivedtbl_1 LEFT OUTER JOIN tc_goods ON derivedtbl_1.input_goods_code = tc_goods.goods_code "
                + " left join tc_maker on tc_goods.goods_maker=tc_maker.maker_code "
                + "  :CONDITION2";

            //出库查询
            //public const string TC_OUTPUT_STORAGE_LEFTJOIN_TC_CUSTOMER_LEFTJOIN_TC_INPUT_STORAGE_LEFTJOIN_TC_GOODS_SELECT = ""
            //    + "SELECT OS.OUTPUT_CODE ,OS.INPUT_CODE ,OS.OUTPUT_TYPE ,OS.OUTPUT_COUNT ,OS.OUTPUT_INSTORAGE_DATE ,OS.OUTPUT_CHECKTIME ,CUSTOMER.CUSTOMER_NAME , OS.OUTPUT_REMARK, "
            //    + "INPUTSTORAGE.SUPPLIER_NAME ,INPUTSTORAGE.INPUT_BATCH_NUM ,INPUTSTORAGE.INPUT_MAKETIME , GOODS.GOODS_NAME , GOODS.GOODS_REG_NUM,"
            //    + "GOODS.GOODS_TYPE ,GOODS.GOODS_UNIT ,GOODS.GOODS_VALIDITY , TC_MAKER.MAKER_NAME "
            //    + " FROM TC_OUTPUT_STORAGE AS OS "
            //    + " LEFT JOIN TC_CUSTOMER AS CUSTOMER ON OS.CUSTOMER_CODE = CUSTOMER.CUSTOMER_CODE "
            //    + " LEFT JOIN (TC_INPUT_STORAGE AS INPUTSTORAGE LEFT JOIN (TC_GOODS AS GOODS LEFT JOIN TC_MAKER ON GOODS.GOODS_MAKER = TC_MAKER.MAKER_CODE)ON INPUTSTORAGE.INPUT_GOODS_CODE = GOODS.GOODS_CODE) "
            //    + " ON OS.INPUT_CODE = INPUTSTORAGE.INPUT_CODE ";
            public const string TC_OUTPUT_STORAGE_LEFTJOIN_TC_CUSTOMER_LEFTJOIN_TC_INPUT_STORAGE_LEFTJOIN_TC_GOODS_SELECT = " SELECT OS.OUTPUT_CODE ,OS.output_check_persion,OS.INPUT_CODE ,CASE WHEN OUTPUT_TYPE = '0' THEN '销售出库' "
                                                            + " WHEN OUTPUT_TYPE = '1' THEN '退货出库'  END AS 'OUTSTORAGE_TYPE',OUTPUT_TYPE,OS.OUTPUT_COUNT ,OS.OUTPUT_INSTORAGE_DATE ,"
                                                            + " OS.OUTPUT_CHECKTIME ,CUSTOMER.CUSTOMER_NAME , OS.OUTPUT_REMARK, INPUTSTORAGE.SUPPLIER_NAME ,INPUTSTORAGE.INPUT_BATCH_NUM ,INPUTSTORAGE.INPUT_QUALITY_REG, INPUTSTORAGE.INPUT_MAKETIME , GOODS.GOODS_NAME , GOODS.GOODS_REG_NUM,"
                                                            + " GOODS.GOODS_TYPE ,GOODS.GOODS_UNIT ,GOODS.GOODS_VALIDITY , TC_MAKER.MAKER_NAME "
                                                            + " FROM TC_OUTPUT_STORAGE AS OS LEFT JOIN TC_CUSTOMER AS CUSTOMER ON OS.CUSTOMER_CODE = CUSTOMER.CUSTOMER_CODE "
                                                            + " LEFT JOIN (TC_INPUT_STORAGE AS INPUTSTORAGE LEFT JOIN (TC_GOODS AS GOODS LEFT JOIN TC_MAKER ON GOODS.GOODS_MAKER = TC_MAKER.MAKER_CODE)ON INPUTSTORAGE.INPUT_GOODS_CODE = GOODS.GOODS_CODE) "
                                                            + " ON OS.INPUT_CODE = INPUTSTORAGE.INPUT_CODE ";
            public const string TC_OUTPUT_STORAGE_LEFTJOIN_TC_INPUT_STORAGE_LEFTJOIN_TC_GOODS_LEFTJOIN_TC_MAKER = ""
                + " SELECT GOODS_NAME,GOODS_TYPE,MAKER_NAME,GOODS_UNIT,OUT_COUNT,GOODS_VALIDITY "
                + " FROM ( SELECT DISTINCT A.INPUT_GOODS_CODE,SUM(A.OUT_COUNT) AS OUT_COUNT "
                + " FROM( SELECT DERIVEDTBL_1.INPUT_CODE,OUT_COUNT,TC_INPUT_STORAGE.INPUT_GOODS_CODE "
                + " FROM( SELECT DISTINCT INPUT_CODE,SUM(OUTPUT_COUNT) AS OUT_COUNT "
                + " FROM TC_OUTPUT_STORAGE :CONDITION1 GROUP BY INPUT_CODE ) AS DERIVEDTBL_1 "
                + " LEFT JOIN TC_INPUT_STORAGE ON DERIVEDTBL_1.INPUT_CODE = TC_INPUT_STORAGE.INPUT_CODE) AS A "
                + " GROUP BY INPUT_GOODS_CODE ) AS B "
                + " LEFT JOIN TC_GOODS ON B.INPUT_GOODS_CODE =TC_GOODS.GOODS_CODE "
                + " LEFT JOIN TC_MAKER ON TC_GOODS.GOODS_MAKER=TC_MAKER.MAKER_CODE :CONDITION2 ";

            /// <summary>
            /// 库存查询：入库表，出库表，报损表，产品表，生产厂家表
            /// </summary>
            public const string tc_storage_count = "SELECT tc_goods.goods_name, tc_input_storage.input_checktime,tc_input_storage.input_check_persion,tc_input_storage.input_code, tc_goods.goods_type, tc_maker.maker_name, tc_goods.goods_unit, "
                + "  ISNULL(tc_input_storage.input_standard_count, 0) AS input_count, ISNULL(output_storage.output_count, 0) AS output_count, "
                + " ISNULL(lose_storage.lose_count, 0) AS lose_count, "
                + " ISNULL(tc_input_storage.input_standard_count, 0) - ISNULL(output_storage.output_count, 0) - ISNULL(lose_storage.lose_count, 0) AS storage_count, "
                + " CASE WHEN tc_input_storage.input_type = '0' THEN '初始入库' WHEN tc_input_storage.input_type = '1' THEN '购货入库' WHEN tc_input_storage.input_type "
                + "= '2' THEN '赠品入库' WHEN tc_input_storage.input_type = '3' THEN '退货入库' END AS 'instorage_type', tc_input_storage.input_batch_num, "
                + " tc_input_storage.input_maketime, tc_goods.goods_validity, tc_input_storage.input_instorage_date,tc_goods.goods_yxm,tc_maker.maker_yxm "
                + " FROM tc_input_storage LEFT OUTER JOIN (SELECT DISTINCT input_code, SUM(output_count) AS output_count "
                + " FROM  tc_output_storage GROUP BY input_code) AS output_storage ON tc_input_storage.input_code = output_storage.input_code LEFT OUTER JOIN "
                + " (SELECT DISTINCT input_code, SUM(lose_count) AS lose_count  FROM tc_lose "
                + " GROUP BY input_code) AS lose_storage ON tc_input_storage.input_code = lose_storage.input_code LEFT OUTER JOIN "
                + " tc_goods ON tc_input_storage.input_goods_code = tc_goods.goods_code LEFT OUTER JOIN "
                + "  tc_maker ON tc_goods.goods_maker = tc_maker.maker_code ";
            /// <summary>
            /// 库存查询：入库表，出库表，报损表，产品表，生产厂家表加条件
            /// </summary>
            public const string tc_storage_count_yh = "Select * From (SELECT tc_goods.goods_name, tc_input_storage.input_code, tc_goods.goods_type, tc_maker.maker_name, tc_goods.goods_unit, "
                + "  ISNULL(tc_input_storage.input_standard_count, 0) AS input_count, ISNULL(output_storage.output_count, 0) AS output_count, "
                + " ISNULL(lose_storage.lose_count, 0) AS lose_count, "
                + " ISNULL(tc_input_storage.input_standard_count, 0) - ISNULL(output_storage.output_count, 0) - ISNULL(lose_storage.lose_count, 0) AS storage_count, "
                + " CASE WHEN tc_input_storage.input_type = '0' THEN '初始入库' WHEN tc_input_storage.input_type = '1' THEN '购货入库' WHEN tc_input_storage.input_type "
                + "= '2' THEN '赠品入库' WHEN tc_input_storage.input_type = '3' THEN '退货入库' END AS 'instorage_type', tc_input_storage.input_batch_num, "
                + " tc_input_storage.input_maketime, tc_goods.goods_validity, tc_input_storage.input_instorage_date,tc_goods.goods_yxm,tc_maker.maker_yxm "
                + " FROM tc_input_storage LEFT OUTER JOIN (SELECT DISTINCT input_code, SUM(output_count) AS output_count "
                + " FROM  tc_output_storage GROUP BY input_code) AS output_storage ON tc_input_storage.input_code = output_storage.input_code LEFT OUTER JOIN "
                + " (SELECT DISTINCT input_code, SUM(lose_count) AS lose_count  FROM tc_lose "
                + " GROUP BY input_code) AS lose_storage ON tc_input_storage.input_code = lose_storage.input_code LEFT OUTER JOIN "
                + " tc_goods ON tc_input_storage.input_goods_code = tc_goods.goods_code LEFT OUTER JOIN "
                + "  tc_maker ON tc_goods.goods_maker = tc_maker.maker_code ) t ";
            /// <summary>
            /// 查询报损
            /// </summary>
            public const string TC_LOSE_LEFTJOIN_TC_INPUT_STORAGE_LEFTJOIN_TC_GOODS_LEFTJOIN_TC_MAKER = ""
                + " select tc_lose.lose_code, tc_lose.lose_count ,tc_lose.lose_applier , tc_lose.lose_checker, tc_lose.lose_datetime,"
                + " tc_lose.lose_result, tc_lose.lose_remark, tc_lose.lose_reason, tc_input_storage.input_code,tc_input_storage.input_instorage_date, tc_input_storage.input_goods_code,tc_input_storage.input_batch_num, tc_input_storage.input_maketime, "
                + " tc_goods.goods_name, tc_goods.goods_type, tc_goods.goods_unit, tc_goods.goods_validity, tc_goods.goods_reg_num, tc_maker.maker_name "
                + " from tc_lose left join (tc_input_storage left join "
                + " (tc_goods left join tc_maker on tc_goods.goods_maker = tc_maker.maker_code) "
                + " on tc_input_storage.input_goods_code = tc_goods.goods_code) on tc_lose.input_code = tc_input_storage.input_code ";

            /// <summary>
            /// 报损查询模块语句
            /// </summary>
            public const string TC_LOSE_LEFTJOIN_TC_INPUT_STORAGE_LEFTJOIN_TC_GOODS_LEFTJOIN_TC_MAKER_SELECT = ""
                + "select tc_goods.goods_name ,tc_goods.goods_type ,tc_goods.goods_unit , tc_goods.goods_reg_num,tc_maker.maker_name "
                + ", tc_lose.lose_count ,tc_lose.lose_datetime ,tc_lose.lose_code"
                + " from tc_lose left join ( tc_input_storage left join "
                + " (tc_goods left join tc_maker on tc_goods.goods_maker = tc_maker.maker_code) "
                + " on tc_input_storage.input_goods_code = tc_goods.goods_code) "
                + " on tc_lose.input_code = tc_input_storage.input_code ";

            /// <summary>
            /// 报损统计模块语句
            /// </summary>
            public const string TC_LOSE_LEFTJOIN_TC_INPUT_STORAGE_LEFTJOIN_TC_GOODS_LEFTJOIN_TC_MAKER_COUNT = ""
                + "SELECT GOODS_NAME,GOODS_TYPE,MAKER_NAME,GOODS_UNIT,LOSE_COUNT,GOODS_VALIDITY "
                + " FROM ( SELECT DISTINCT A.INPUT_GOODS_CODE,SUM(A.LOSE_COUNT) AS LOSE_COUNT "
                + " FROM( SELECT DERIVEDTBL_1.INPUT_CODE,LOSE_COUNT,TC_INPUT_STORAGE.INPUT_GOODS_CODE "
                + " FROM( SELECT DISTINCT INPUT_CODE,SUM(LOSE_COUNT) AS LOSE_COUNT "
                + " FROM TC_LOSE :CONDITION1  GROUP BY INPUT_CODE ) AS DERIVEDTBL_1 "
                + " LEFT JOIN TC_INPUT_STORAGE ON DERIVEDTBL_1.INPUT_CODE = TC_INPUT_STORAGE.INPUT_CODE) AS A "
                + " GROUP BY INPUT_GOODS_CODE ) AS B "
                + " LEFT JOIN TC_GOODS ON B.INPUT_GOODS_CODE =TC_GOODS.GOODS_CODE "
                + " LEFT JOIN TC_MAKER ON TC_GOODS.GOODS_MAKER=TC_MAKER.MAKER_CODE :CONDITION2 ";
            /// <summary>
            /// 不良记录表可填数量计算
            /// </summary>
            public const string SUM_TC_APPARATUS_QUALITY = " select sum(apparatus_quality_count) as suncount from tc_apparatus_quality ";

            /// <summary>
            /// 登录时，密码校验并取得登录人信息
            /// </summary>
            public const string AUTHORITY_LEFTJOIN_STAFF = " SELECT TC_AUTHORITY.AUTHORITY_USER_CODE, TC_AUTHORITY.AUTHORITY_PASSWORD "
                + " ,TC_AUTHORITY.AUTHORITY_LEVEL, TC_AUTHORITY.STAFF_CODE, TC_STAFF.STAFF_NAME, STAFF_DEP "
                + " FROM TC_AUTHORITY LEFT OUTER JOIN TC_STAFF ON TC_AUTHORITY.STAFF_CODE = TC_STAFF.STAFF_CODE :CONDITION1 ";

            /// <summary>
            /// 查询系统日志
            /// </summary>
            public const string TC_SYSTEM_LOG = "SELECT SYSTEMLOG_CODE, SYSTEMLOG_LOGON, SYSTEMLOG_LOGOFF, SYSTEMLOG_USER FROM TC_SYSTEM_LOG :CONDITION1 ORDER BY SYSTEMLOG_LOGON DESC";
            
            /// <summary>
            /// 查询用户名并关联员工姓名部门
            /// </summary>
            public const string tc_AUTHORITY_LEFTJOIN_STAFF = "select a.authority_id,a.authority_user_code,a.staff_code,s.staff_dep,a.authority_level ,s.staff_name from "
                + " tc_authority as a left join tc_staff as s on a.staff_code = s.staff_code ";

            /// <summary>           
            /// 查询医疗器械验收记录
            /// </summary>
            public const string TC_INPUT_STORAGE_LEFTJOIN_GOODS_SELECTRECORDVALIDATE = "SELECT TC_INPUT_STORAGE.INPUT_CODE, TC_INPUT_STORAGE.INPUT_TYPE, TC_INPUT_STORAGE.INPUT_QUALITY_REG,TC_GOODS.GOODS_NAME,"
                + " TC_GOODS.GOODS_TYPE, TC_INPUT_STORAGE.SUPPLIER_NAME, TC_MAKER.MAKER_NAME, "
                + " TC_INPUT_STORAGE.INPUT_STANDARD_COUNT,TC_INPUT_STORAGE.INPUT_ARRIVAL_COUNT, TC_INPUT_STORAGE.INPUT_BATCH_NUM, "
                + " TC_INPUT_STORAGE.INPUT_INSTORAGE_DATE, TC_INPUT_STORAGE.INPUT_MAKETIME, TC_INPUT_STORAGE.QUALITY_INFO, TC_INPUT_STORAGE.CHECK_INFO, "
                + " TC_GOODS.GOODS_VALIDITY, TC_GOODS.GOODS_REG_NUM, TC_INPUT_STORAGE.INPUT_CHECK_PERSION, "
                + " TC_INPUT_STORAGE.INPUT_CHECKTIME ,TC_SUPPLIER.SUPPLIER_LICENCE "
                + " FROM TC_INPUT_STORAGE LEFT OUTER JOIN TC_GOODS ON TC_INPUT_STORAGE.INPUT_GOODS_CODE = TC_GOODS.GOODS_CODE "
                + " LEFT OUTER JOIN TC_MAKER ON TC_GOODS.GOODS_MAKER = TC_MAKER.MAKER_CODE "
                + " LEFT OUTER JOIN TC_SUPPLIER ON TC_INPUT_STORAGE.SUPPLIER_NAME = TC_SUPPLIER.SUPPLIER_NAME :CONDITION1 ORDER BY TC_INPUT_STORAGE.INPUT_CHECKTIME DESC";

            /// <summary>           
            /// 查询客户表关联档案
            /// </summary>
            public const string TC_CUSTOMER_RIGHTJOIN_TC_ARCHIVES = "SELECT TC_CUSTOMER.CUSTOMER_CODE,TC_CUSTOMER.CUSTOMER_NAME,TC_CUSTOMER.CUSTOMER_TEL,TC_CUSTOMER.CUSTOMER_ADDRESS,TC_CUSTOMER.CUSTOMER_YXM,TC_ARCHIVES.* "
                + "FROM TC_CUSTOMER RIGHT JOIN TC_ARCHIVES ON TC_CUSTOMER.CUSTOMER_CODE = TC_ARCHIVES.CUSTOMER_CODE";

            /// <summary>           
            /// 客户回访界面查询
            /// 客户回访表关联物品表,出库表,入库表,客户表
            /// </summary>
            public const string TC_VISIT_JOIN_IN_OUT_CUSTOMER_GOODS = "SELECT TC_VISIT.*,TC_OUTPUT_STORAGE.OUTPUT_INSTORAGE_DATE, TC_OUTPUT_STORAGE.INPUT_CODE,"
                +"TC_INPUT_STORAGE.INPUT_GOODS_CODE,TC_GOODS.GOODS_NAME,TC_OUTPUT_STORAGE.OUTPUT_COUNT,"
                +"TC_OUTPUT_STORAGE.CUSTOMER_CODE,TC_CUSTOMER.CUSTOMER_NAME,TC_INPUT_STORAGE.INPUT_BATCH_NUM,"
                + "TC_GOODS.GOODS_TYPE,TC_CUSTOMER.CUSTOMER_ADDRESS,TC_CUSTOMER.CUSTOMER_TEL,TC_OUTPUT_STORAGE.OUTPUT_INSTORAGE_DATE ,isnull((tc_output_storage.output_count-back.backcount),output_count) as reloutput_count "
                +"FROM TC_VISIT "
                +"LEFT JOIN TC_OUTPUT_STORAGE ON TC_VISIT.VISIT_OUTPUT_CODE = TC_OUTPUT_STORAGE.OUTPUT_CODE "
                +"LEFT JOIN TC_INPUT_STORAGE ON TC_OUTPUT_STORAGE.INPUT_CODE = TC_INPUT_STORAGE.INPUT_CODE "
                +"LEFT JOIN TC_GOODS ON TC_INPUT_STORAGE.INPUT_GOODS_CODE = TC_GOODS.GOODS_CODE "
                +"LEFT JOIN TC_CUSTOMER ON TC_OUTPUT_STORAGE.CUSTOMER_CODE = TC_CUSTOMER.CUSTOMER_CODE "
                +"left join (select distinct output_code,sum(input_arrival_count) as backcount from tc_input_storage where input_type='3' group by output_code ) as back on tc_output_storage.output_code=back.output_code";
            
        }
    }
}
