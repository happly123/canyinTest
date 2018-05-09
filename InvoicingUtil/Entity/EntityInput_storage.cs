using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//*******************************************************************
/// <summary>
/// 入库表定义
/// </summary>
/// <history>
///     完成信息：吴小科      2010/07/13 完成   
///     更新信息：吴小科      2010/07/19 修改 2010/07/20 2次修改
/// </history>
//*******************************************************************
namespace InvoicingUtil
{
   public class EntityInput_storage
   {   //定义数据成员 
        private string input_code = string.Empty;     
        private string input_goods_code = string.Empty;
        private string input_quality_reg = string.Empty;
        private string input_batch_num = string.Empty;
        private int input_arrival_count = 0;
        private int input_standard_count = 0;
        private string counter_name = string.Empty;
        private string supplier_name= string.Empty;
        private string input_check_persion = string.Empty;
        private string input_oper = string.Empty;
        private string input_quality_persion = string.Empty;
        private string input_issued = string.Empty;
        private string input_packing_in = string.Empty;
        private string input_packing_mid = string.Empty;
        private string input_packing_out = string.Empty;
        private string input_remark = string.Empty;
        private DateTime input_instorage_date;
        private DateTime input_maketime;
        private DateTime input_checktime;
        private char input_type = '0';
        private char operate_type ='0';
        private DateTime backstorage_date;
        private string output_code = string.Empty;
        private string quality_info = string.Empty;
        private string check_info = string.Empty;
  
       /// <summary>
        /// 获取或设置成员数据
       /// </summary>
        public string INPUT_CODE
        {
            set
            {
                this.input_code = value;
            }
            get
            {
                return this.input_code;
            }

        }
       /// <summary>
        /// 获取或设置成员数据
       /// </summary>
        public string COUNTER_NAME
        {
            set
            {
                this.counter_name = value;
            }
            get
            {
                return this.counter_name;
            }

        }
    
       /// <summary>
        /// 获取或设置成员数据
       /// </summary>
        public string SUPPLIER_NAME
        {
            set
            {
                this.supplier_name = value;
            }
            get
            {
                return this.supplier_name;
            }
        }
       /// <summary>
        /// 获取或设置成员数据
       /// </summary>
        public char INPUT_TYPE
        {
            set
            {
                this.input_type = value;
            }
            get
            {
                return this.input_type;
            }
        }

        /// <summary>
        /// 获取或设置成员数据
        /// </summary>
        public int INPUT_ARRIVAL_COUNT
        {
            set
            {
                this.input_arrival_count = value;
            }
            get
            {
                return this.input_arrival_count;
            }
 
        }
       /// <summary>
        /// 获取或设置成员数据
       /// </summary>
        public int INPUT_STANDARD_COUNT
        {
            set
            {
                this.input_standard_count = value;
            }
            get
            {
                return this.input_standard_count;
            }
        }
       /// <summary>
        /// 获取或设置成员数据
       /// </summary>
        public string INPUT_GOODS_CODE
        {
            set
            {
                this.input_goods_code = value;
            }
            get
            {
                return this.input_goods_code;
            }
        }
       /// <summary>
        /// 获取或设置成员数据
       /// </summary>
        public DateTime INPUT_MAKETIME
        {
            set
            {
                this.input_maketime = value;
            }
            get
            {
                return this.input_maketime;
            }
        }
       /// <summary>
        /// 获取或设置成员数据
       /// </summary>
        public DateTime INPUT_CHECKTIME
        {
            set 
            {
                this.input_checktime = value;
            }
            get
            {
                return this.input_checktime;
            }
        }
        /// <summary>
        /// 获取或设置成员数据
        /// </summary>
        public DateTime BACKSTORAGE_DATE
        {
            get
            {
                return this.backstorage_date;
            }
            set
            {
                this.backstorage_date = value;
            }
        }
       /// <summary>
        /// 获取或设置成员数据
       /// </summary>
        public string INPUT_CHECK_PERSION
        {
            set
            {
                this.input_check_persion = value;
            }
            get
            {
                return this.input_check_persion;
            }
        }
       /// <summary>
        /// 获取或设置成员数据
       /// </summary>
        public string INPUT_OPER
        {
            set
            {
                this.input_oper = value;
            }
            get
            {
                return this.input_oper;
            }
        }
       /// <summary>
        /// 获取或设置成员数据
       /// </summary>
        public string INPUT_QUALITY_PERSION
        {
            set
            {
                this.input_quality_persion = value;

            }
            get
            {
                return this.input_quality_persion;
            }
        }
       /// <summary>
        /// 获取或设置成员数据
       /// </summary>
        public string INPUT_PACKING_IN
        {
            set
            {
                this.input_packing_in = value;
            }
            get
            {
                return this.input_packing_in;
            }
        }
       /// <summary>
        /// 获取或设置成员数据
       /// </summary>
        public string INPUT_PACKING_MID
        {
            set
            {
                this.input_packing_mid = value;
            }
            get
            {
                return this.input_packing_mid;
            }
        }
       /// <summary>
        /// 获取或设置成员数据
       /// </summary>
        public string INPUT_PACKING_OUT
        {
            set
            {
                this.input_packing_out = value;
            }
            get
            {
                return this.input_packing_out;
            }
        }
       /// <summary>
        /// 获取或设置成员数据
       /// </summary>
        public string INPUT_QUALITY_REG
        {
            set
            {
                this.input_quality_reg = value;
            }
            get
            {
                return this.input_quality_reg;
            }
        }
       /// <summary>
        /// 获取或设置成员数据
       /// </summary>
        public string INPUT_ISSUED
        {
            set
            {
                this.input_issued = value;
            }
            get
            {
                return this.input_issued;
            }
        }
       /// <summary>
        /// 获取或设置成员数据
       /// </summary>
        public char OPERATE_TYPE
        {
            set 
            {
                this.operate_type = value;
            }
            get
            {
                return this.operate_type;
            }
        }
       /// <summary>
        /// 获取或设置成员数据
       /// </summary>
        public string INPUT_REMARK
        {
            set
            {
                this.input_remark = value;
            }
            get
            {
                return this.input_remark;
            }
        }
       /// <summary>
        /// 获取或设置成员数据
       /// </summary>
        public DateTime INPUT_INSTORAGE_DATE
        {
            set
            {
                this.input_instorage_date = value;
            }
            get
            {
                return this.input_instorage_date;
            }
        }
        public string INPUT_BATCH_NUM
        {
            set
            {
                this.input_batch_num = value;
            }
            get
            {
                return this.input_batch_num;
            }
            
        
        }
       /// <summary>
        /// 获取或设置成员数据
       /// </summary>
        public string OUTPUT_CODE
        {
            get
            {
                return this.output_code;
            }
            set
            {
                this.output_code = value;
            }
        }
       /// <summary>
       /// 获取或设置成员数据
       /// </summary>
        public string QUALITY_INFO
        {
            get
            {
                return this.quality_info;
            }
            set
            {
                this.quality_info = value;
            }
        }
       /// <summary>
       /// 获取或设置成员数据
       /// </summary>
        public string CHECK_INFO
        {
            get
            {
                return this.check_info;

            }
            set
            {
                this.check_info = value;
            }
        }
    }
}
