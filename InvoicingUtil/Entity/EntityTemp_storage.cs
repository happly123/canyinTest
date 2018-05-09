using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//*******************************************************************
/// <summary>
/// 库存临时表定义
/// </summary>
/// <history>
///     完成信息：吴小科      2010/07/20 完成   
///     更新信息：
/// </history>
//*******************************************************************
namespace InvoicingUtil
{

    public class EntityTemp_storage
    {   
        //定义数据成员
        private string goods_code = string.Empty;
        private int count = 0;
        /// <summary>
        /// 获取或设置成员数据
        /// </summary>
        public string Goods_code
        {
            get
            {
                return this.goods_code;
            }
            set
            {
                this.goods_code = value;
            }
        }
        /// <summary>
        /// 获取或设置成员数据
        /// </summary>
        public int Count
        {
            get
            {
                return this.count;
            }
            set
            {
                this.count = value;
            }
        }


    }
}
