using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataExport
{
    public class SqlStr
    {
        /// <summary>           
        /// 取入库表所有记录关联产品表信息	
        /// </summary>
        public const string TC_INPUT_STORAGE_LEFTJOIN_GOODS = " SELECT TC_INPUT_STORAGE.INPUT_CODE, CASE WHEN TC_INPUT_STORAGE.INPUT_TYPE = '0' THEN '初始入库' "
                                                            + " WHEN TC_INPUT_STORAGE.INPUT_TYPE = '1' THEN '购货入库' "
                                                            + " WHEN TC_INPUT_STORAGE.INPUT_TYPE = '2' THEN '赠品入库' "
                                                            + " WHEN TC_INPUT_STORAGE.INPUT_TYPE = '3' THEN '退货入库' "
                                                            + " END AS 'INSTORAGE_TYPE', TC_GOODS.GOODS_NAME,"
                                                            + " TC_GOODS.GOODS_TYPE, TC_INPUT_STORAGE.SUPPLIER_NAME, TC_MAKER.MAKER_NAME, "
                                                            + " TC_INPUT_STORAGE.INPUT_STANDARD_COUNT,TC_INPUT_STORAGE.INPUT_ARRIVAL_COUNT,TC_INPUT_STORAGE.INPUT_ARRIVAL_COUNT, TC_INPUT_STORAGE.INPUT_BATCH_NUM, "
                                                            + " TC_INPUT_STORAGE.INPUT_INSTORAGE_DATE, TC_INPUT_STORAGE.INPUT_MAKETIME, "
                                                            + " TC_GOODS.GOODS_REG_NUM, TC_GOODS.GOODS_VALIDITY, TC_INPUT_STORAGE.INPUT_CHECK_PERSION,TC_INPUT_STORAGE.INPUT_ISSUED, "
                                                            + " TC_INPUT_STORAGE.INPUT_CHECKTIME "
                                                            + " FROM TC_INPUT_STORAGE LEFT OUTER JOIN TC_GOODS ON TC_INPUT_STORAGE.INPUT_GOODS_CODE = TC_GOODS.GOODS_CODE "
                                                            + " LEFT OUTER JOIN TC_MAKER ON TC_GOODS.GOODS_MAKER = TC_MAKER.MAKER_CODE ";

        //出库查询
        public const string TC_OUTPUT_STORAGE_LEFTJOIN_TC_CUSTOMER_LEFTJOIN_TC_INPUT_STORAGE_LEFTJOIN_TC_GOODS_SELECT = " SELECT OS.OUTPUT_CODE ,OS.OUTPUT_CHECK_PERSION,OS.INPUT_CODE ,CASE WHEN OUTPUT_TYPE = '0' THEN '销售出库' "
                                                            + " WHEN OUTPUT_TYPE = '1' THEN '退货出库'  END AS 'OUTSTORAGE_TYPE',OS.OUTPUT_COUNT ,OS.OUTPUT_INSTORAGE_DATE ,"
                                                            + " OS.OUTPUT_CHECKTIME ,CUSTOMER.CUSTOMER_NAME , OS.OUTPUT_REMARK, INPUTSTORAGE.SUPPLIER_NAME ,INPUTSTORAGE.INPUT_BATCH_NUM ,INPUTSTORAGE.INPUT_MAKETIME , GOODS.GOODS_NAME , GOODS.GOODS_REG_NUM,"
                                                            + " GOODS.GOODS_TYPE ,GOODS.GOODS_UNIT ,GOODS.GOODS_VALIDITY , TC_MAKER.MAKER_NAME "
                                                            + " FROM TC_OUTPUT_STORAGE AS OS LEFT JOIN TC_CUSTOMER AS CUSTOMER ON OS.CUSTOMER_CODE = CUSTOMER.CUSTOMER_CODE "
                                                            + " LEFT JOIN (TC_INPUT_STORAGE AS INPUTSTORAGE LEFT JOIN (TC_GOODS AS GOODS LEFT JOIN TC_MAKER ON GOODS.GOODS_MAKER = TC_MAKER.MAKER_CODE)ON INPUTSTORAGE.INPUT_GOODS_CODE = GOODS.GOODS_CODE) "
                                                            + " ON OS.INPUT_CODE = INPUTSTORAGE.INPUT_CODE ";

        /// <summary>           
        /// 查询医疗器械验收记录
        /// </summary>
        public const string TC_INPUT_STORAGE_LEFTJOIN_GOODS_SELECTRECORDVALIDATE = " SELECT TC_INPUT_STORAGE.INPUT_CODE, TC_INPUT_STORAGE.INPUT_TYPE, TC_INPUT_STORAGE.INPUT_QUALITY_REG,TC_GOODS.GOODS_NAME,"
                 + " TC_GOODS.GOODS_TYPE, TC_INPUT_STORAGE.SUPPLIER_NAME, TC_MAKER.MAKER_NAME, "
                 + " TC_INPUT_STORAGE.INPUT_STANDARD_COUNT,TC_INPUT_STORAGE.INPUT_ARRIVAL_COUNT, TC_INPUT_STORAGE.INPUT_BATCH_NUM, "
                 + " TC_INPUT_STORAGE.INPUT_INSTORAGE_DATE, TC_INPUT_STORAGE.INPUT_MAKETIME, TC_INPUT_STORAGE.QUALITY_INFO, TC_INPUT_STORAGE.CHECK_INFO, "
                 + " TC_GOODS.GOODS_VALIDITY, TC_GOODS.GOODS_REG_NUM, TC_INPUT_STORAGE.INPUT_CHECK_PERSION, "
                 + " TC_INPUT_STORAGE.INPUT_CHECKTIME ,TC_SUPPLIER.SUPPLIER_LICENCE "
                 + " FROM TC_INPUT_STORAGE LEFT OUTER JOIN TC_GOODS ON TC_INPUT_STORAGE.INPUT_GOODS_CODE = TC_GOODS.GOODS_CODE "
                 + " LEFT OUTER JOIN TC_MAKER ON TC_GOODS.GOODS_MAKER = TC_MAKER.MAKER_CODE "
                 + " LEFT OUTER JOIN TC_SUPPLIER ON TC_INPUT_STORAGE.SUPPLIER_NAME = TC_SUPPLIER.SUPPLIER_NAME ";

        /// <summary>
        /// 不良记录查询
        /// </summary>
        public const string TC_APPARATUS_QUALITY_SELECT = "SELECT APP.*,OUT.INPUT_CODE,OUT.CUSTOMER_CODE,OUT.OUTPUT_COUNT,"
                                                        + "INPUT.INPUT_GOODS_CODE,INPUT.INPUT_BATCH_NUM,INPUT.SUPPLIER_NAME,"
                                                        + "GOODS.GOODS_NAME,GOODS.GOODS_TYPE,MAKER.MAKER_NAME,"
                                                        + "CUSTOMER.CUSTOMER_NAME FROM TC_APPARATUS_QUALITY AS APP "
                                                        + "LEFT JOIN TC_OUTPUT_STORAGE AS OUT ON APP.APPARATUS_OUTPUT_CODE = OUT.OUTPUT_CODE "
                                                        + "LEFT JOIN TC_INPUT_STORAGE AS INPUT ON OUT.INPUT_CODE = INPUT.INPUT_CODE "
                                                        + "LEFT JOIN TC_GOODS AS GOODS ON INPUT.INPUT_GOODS_CODE = GOODS.GOODS_CODE "
                                                        + "LEFT JOIN TC_MAKER AS MAKER ON GOODS.GOODS_MAKER = MAKER.MAKER_CODE "
                                                        + "LEFT JOIN TC_CUSTOMER AS CUSTOMER ON OUT.CUSTOMER_CODE = CUSTOMER.CUSTOMER_CODE ";

        //养护管理,养护记录查询
        public const string TC_MAINTAIN_LEFTJOIN_TC_TC_INPUT_STORAGE_LEFTJOIN_TC_GOODS_LEFTJOIN_TC_MAKER = " SELECT TC_INPUT_STORAGE.INPUT_BATCH_NUM, TC_MAINTAIN.MAINTAIN_CODE,TC_MAINTAIN.MAINTAIN_INPUT_CODE,TC_MAINTAIN.MAINTAIN_APPLICATION,TC_MAINTAIN.MAINTAIN_PURPOSE,"
                                                        + " TC_GOODS.GOODS_TYPE,TC_GOODS.GOODS_REG_NUM,TC_GOODS.GOODS_STOREMETHOD,TC_GOODS.GOODS_NAME,TC_GOODS.GOODS_VALIDITY,TC_GOODS.GOODS_YXM,"
                                                        + " TC_MAKER.MAKER_NAME,TC_MAKER.MAKER_POSTAL_CODE,TC_MAKER.MAKER_ADDRESS,TC_MAKER.MAKER_TEL ,"
                                                        + " TC_INPUT_STORAGE.INPUT_PACKING_IN,TC_INPUT_STORAGE.INPUT_PACKING_MID,TC_INPUT_STORAGE.INPUT_PACKING_OUT,"
                                                        + " TC_MAINTAIN.MAINTAIN_QUALITY,TC_MAINTAIN.MAINTAIN_TEST_ITEMS,TC_MAINTAIN.MAINTAIN_CHARACTERS,TC_MAINTAIN.MAINTAIN_CREATE_DATE "
                                                        + " FROM TC_MAINTAIN LEFT JOIN TC_INPUT_STORAGE ON TC_MAINTAIN.MAINTAIN_INPUT_CODE = TC_INPUT_STORAGE.INPUT_CODE "
                                                        + " LEFT JOIN TC_GOODS ON TC_INPUT_STORAGE.INPUT_GOODS_CODE = TC_GOODS.GOODS_CODE LEFT JOIN TC_MAKER ON TC_MAKER.MAKER_CODE = TC_GOODS.GOODS_MAKER ";

        public const string TC_MAINTAIN_DETAIL = " SELECT * FROM TC_MAINTAIN_DETAIL ";


    }
}
