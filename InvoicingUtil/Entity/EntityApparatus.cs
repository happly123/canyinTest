using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvoicingUtil
{
    public class EntityApparatus
    {
        private int apparatus_id = 0;

        /// <summary>
        /// 获取或设置
        /// </summary>
        public int Apparatus_id
        {
            get { return apparatus_id; }
            set { apparatus_id = value; }
        }

        private string apparatus_code = string.Empty;

        /// <summary>
        /// 获取或设置
        /// </summary>
        public string Apparatus_code
        {
            get { return apparatus_code; }
            set { apparatus_code = value; }
        }        

        private string apparatus_name = string.Empty;

        /// <summary>
        /// 获取或设置
        /// </summary>
        public string Apparatus_name
        {
            get { return apparatus_name; }
            set { apparatus_name = value; }
        }
        private string apparatus_yxm = string.Empty;

        /// <summary>
        /// 获取或设置
        /// </summary>
        public string Apparatus_yxm
        {
            get { return apparatus_yxm; }
            set { apparatus_yxm = value; }
        }
        private string apparatus_upcode = string.Empty;

        /// <summary>
        /// 获取或设置
        /// </summary>
        public string Apparatus_upcode
        {
            get { return apparatus_upcode; }
            set { apparatus_upcode = value; }
        }
        private string apparatus_type = string.Empty;

        /// <summary>
        /// 获取或设置
        /// </summary>
        public string Apparatus_type
        {
            get { return apparatus_type; }
            set { apparatus_type = value; }
        }
    }
}
