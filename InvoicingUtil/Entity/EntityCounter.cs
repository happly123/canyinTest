using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvoicingUtil
{
    public class EntityCounter
    {
        private string counter_code = string.Empty;
        private string counter_manager = string.Empty;
        private string counter_type = string.Empty;

        /// <summary>
        /// 获取或设置
        /// </summary>
        public string Counter_code
        {
            get
            {
return this.counter_code;
            }

            set
            {
this.counter_code = value;
            }
        }

        /// <summary>
        /// 获取或设置
        /// </summary>
        public string Counter_manager
        {
            get
            {
return this.counter_manager;
            }

            set
            {
this.counter_manager = value;
            }
        }

        /// <summary>
        /// 获取或设置
        /// </summary>
        public string Counter_type
        {
            get
            {
return this.counter_type;
            }

            set
            {
this.counter_type = value;
            }
        }

        
    }
}


