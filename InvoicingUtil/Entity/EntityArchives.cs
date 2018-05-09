using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvoicingUtil
{
    public class EntityArchives
    {
        private int archives_id = 0;
        private string customer_usecode = string.Empty;
        private string customer_code = string.Empty;
        private string customer_sex = string.Empty;
        private string customer_age = string.Empty;
        
        /// <summary>
        /// 获取或设置
        /// </summary>
        public int Archives_id
        {
            get
            {
                return this.archives_id;
            }

            set
            {
                this.archives_id = value;
            }
        }

        /// <summary>
        /// 获取或设置
        /// </summary>
        public string Customer_usecode
        {
            get
            {
                return this.customer_usecode;
            }

            set
            {
                this.customer_usecode = value;
            }
        }

        /// <summary>
        /// 获取或设置
        /// </summary>
        public string Customer_code
        {
            get
            {
                return this.customer_code;
            }

            set
            {
                this.customer_code = value;
            }
        }

        /// <summary>
        /// 获取或设置
        /// </summary>
        public string Customer_sex
        {
            get
            {
                return this.customer_sex;
            }

            set
            {
                this.customer_sex = value;
            }
        }

        /// <summary>
        /// 获取或设置
        /// </summary>
        public string Customer_age
        {
            get
            {
                return this.customer_age;
            }

            set
            {
                this.customer_age = value;
            }
        }

        
    }
}
