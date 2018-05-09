using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//*******************************************************************
/// <summary>
/// 设置不合格产品临时表实体定义
/// </summary>
/// <history>
///     完成信息：吴小科      2010/08/04 完成   
///     更新信息：
/// </history>
//*******************************************************************
namespace InvoicingUtil
{
    public class EntityDisqualification
    {
        //定义数据成员
        private string input_code = string.Empty;
        private int deal_count = 0;
        private int undeal_count = 0;
        private int disqualification_count = 0;
        /// <summary>
        /// 获取或设置成员数据
        /// </summary>
        public string Input_Code
        {
            get
            {
                return this.input_code;
            }
            set
            {
                this.input_code = value;
            }
        }
        /// <summary>
        /// 获取或设置成员数据
        /// </summary>
        public int Deal_Count
        {
            get
            {
                return this.deal_count;

            }
            set
            {
                this.deal_count = value;

            }
        }
        /// <summary>
        /// 获取或设置成员数据
        /// </summary>
        public int Undeal_Count
        {
            get
            {
                return this.undeal_count;
            }
            set
            {
                this.undeal_count = value;
            }
        }
        /// <summary>
        /// 获取或设置成员数据
        /// </summary>
        public int Disqualification_Count
        {
            get
            {
                return this.disqualification_count;

            }
            set
            {
                this.disqualification_count = value;
            }
        }


    }
}
