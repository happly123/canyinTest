using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvoicingUtil
{
    public class EntityVisit
    {
        private int visit_id;
        private string visit_output_code = string.Empty;
        private string staff_name = string.Empty;
        private string visit_man = string.Empty;
        private string visit_usage = string.Empty;
        private string visit_opinion = string.Empty;
        private string visit_remarks = string.Empty;
        private DateTime visit_date;

        /// <summary>
        /// 获取或设置
        /// </summary>
        public int Visit_id
        {
            get
            {
                return this.visit_id;
            }

            set
            {
                this.visit_id = value;
            }
        }

        /// <summary>
        /// 获取或设置
        /// </summary>
        public string Visit_output_code
        {
            get
            {
                return this.visit_output_code;
            }

            set
            {
                this.visit_output_code = value;
            }
        }

        /// <summary>
        /// 获取或设置
        /// </summary>
        public string Staff_name
        {
            get
            {
                return this.staff_name;
            }

            set
            {
                this.staff_name = value;
            }
        }

        /// <summary>
        /// 获取或设置
        /// </summary>
        public string Visit_man
        {
            get
            {
                return this.visit_man;
            }

            set
            {
                this.visit_man = value;
            }
        }

        /// <summary>
        /// 获取或设置
        /// </summary>
        public string Visit_usage
        {
            get
            {
                return this.visit_usage;
            }

            set
            {
                this.visit_usage = value;
            }
        }

        /// <summary>
        /// 获取或设置
        /// </summary>
        public string Visit_opinion
        {
            get
            {
                return this.visit_opinion;
            }

            set
            {
                this.visit_opinion = value;
            }
        }

        /// <summary>
        /// 获取或设置
        /// </summary>
        public string Visit_remarks
        {
            get
            {
                return this.visit_remarks;
            }

            set
            {
                this.visit_remarks = value;
            }
        }

        /// <summary>
        /// 获取或设置
        /// </summary>
        public DateTime Visit_date
        {
            get
            {
                return this.visit_date;
            }

            set
            {
                this.visit_date = value;
            }
        }


    }
}
