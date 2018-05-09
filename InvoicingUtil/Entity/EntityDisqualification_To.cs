using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//*******************************************************************
/// <summary>
/// 设置不合格产品去向记录表实体定义
/// </summary>
/// <history>
///     完成信息：吴小科      2010/08/04 完成   
///     更新信息：
/// </history>
//*******************************************************************
namespace InvoicingUtil
{
    public class EntityDisqualification_To
    {
        //定义数据成员
        private int disqualification_code = 0;
        private int disqualification_to_count = 0;
        private char deal_type;
        private DateTime deal_date;
        private string deal_address = string.Empty;
        private string issued = string.Empty;
        private string reamark = string.Empty;
        private string deal_oper = string.Empty;

        /// <summary>
        /// 获取或设置成员数据
        /// </summary>
        public int DISQUALIFICATION_CODE
        {
            get
            {
                return this.disqualification_code;
            }
            set
            {
                this.disqualification_code = value;
            }
        }
        /// <summary>
        /// 获取或设置成员数据
        /// </summary>
        public int DISQUALIFICATION_TO_COUNT
        {
            get
            {
                return this.disqualification_to_count;
            }
            set
            {
                this.disqualification_to_count = value;
            }
        }
        /// <summary>
        /// 获取或设置成员数据
        /// </summary>
        public char DEAL_TYPE
        {
            get
            {
                return this.deal_type;
            }
            set
            {
                this.deal_type = value;
            }
        }
        /// <summary>
        /// 获取或设置成员数据
        /// </summary>
        public DateTime DEAL_DATE
        {
            get
            {
                return this.deal_date;
            }
            set
            {
                this.deal_date = value;
            }
        }
        /// <summary>
        /// 获取或设置成员数据
        /// </summary>
        public string DEAL_ADDRESS
        {
            get
            {
                return this.deal_address;
            }
            set
            {
                this.deal_address = value;
            }
        }
        /// <summary>
        /// 获取或设置成员数据
        /// </summary>
        public string ISSUED
        {
            get
            {
                return this.issued;
            }
            set
            {
                this.issued = value;
            }
        }
        /// <summary>
        /// 获取或设置成员数据
        /// </summary>
        public string REAMARK
        {
            get
            {
                return this.reamark;
            }
            set
            {
                this.reamark = value;
            }
        }
        /// <summary>
        /// 获取或设置成员数据
        /// </summary>
        public string DEAL_OPER
        {
            get
            {
                return this.deal_oper;
            }
            set
            {
                this.deal_oper = value;
            }
        }
    }
}
