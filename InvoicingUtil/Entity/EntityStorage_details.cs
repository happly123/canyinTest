using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//*******************************************************************
/// <summary>
/// 设置库存表实体定义
/// </summary>
/// <history>
///     完成信息：吴小科      2010/07/13 完成   
///     更新信息：吴小科      2010/07/19 修改 
/// </history>
//*******************************************************************
namespace InvoicingUtil
{
    public class EntityStorage_details
    {   //定义数据成员
        private string storage_code=string.Empty;
        private string storage_input_code = string.Empty;
        private string storage_goods_code = string.Empty;
        private int storage_count = 0;
        private DateTime storage_inputdate=DateTime.Now;
        private string storage_maker_code = string.Empty;
        private string storage_count_name = string.Empty;
        /// <summary>
        /// 获取或设置成员数据
        /// </summary>
        public string Storage_input_code
        {
            get
            {
                return this.storage_input_code;
            }

            set
            {
                this.storage_input_code = value;
            }
        }

        /// <summary>
        /// 获取或设置成员数据
        /// </summary>
        public string Storage_goods_code
        {
            get
            {
                return this.storage_goods_code;
            }

            set
            {
                this.storage_goods_code = value;
            }
        }

        /// <summary>
        /// 获取或设置成员数据
        /// </summary>
        public int Storage_count
        {
            get
            {
                return this.storage_count;
            }

            set
            {
                this.storage_count = value;
            }
        }
        /// <summary>
        /// 获取或设置成员数据
        /// </summary>
        public string Storage_code
        {
            get
            {
                return this.storage_code;
            }

            set
            {
                this.storage_code = value;
            }
        }

        /// <summary>
        /// 获取或设置成员数据
        /// </summary>
        public DateTime Storage_inputdate
        {
            get
            {
                return this.storage_inputdate;
            }

            set
            {
                this.storage_inputdate = value;
            }
        }
        /// <summary>
        /// 获取或设置成员数据
        /// </summary>
        public string Storage_maker_code
        {
            get
            {
                return this.storage_maker_code;
            }

            set
            {
                this.storage_maker_code = value;
            }
        }
        /// <summary>
        /// 获取或设置成员数据
        /// </summary>
        public string Storage_count_name
        {
            get
            {
                return this.storage_count_name;
            }
            set
            {
                this.storage_count_name = value;
            }
        }


    }
}
