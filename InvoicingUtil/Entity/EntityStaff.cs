using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvoicingUtil
{
    public class EntityStaff
    {
        private string staff_code = string.Empty;
        private string staff_name = string.Empty;
        private string staff_yxm = string.Empty;
        private string staff_sex = string.Empty;
        private DateTime staff_birthday;
        private string staff_card = string.Empty;
        private string staff_tel = string.Empty;
        private string staff_edu = string.Empty;
        private string staff_introduction = string.Empty;
        private string staff_dep = string.Empty;

        /// <summary>
        /// 获取或设置
        /// </summary>
        public string Staff_dep
        {
            get { return Util.ChangeForSqlString(staff_dep); }
            set { staff_dep = value; }
        }
        private string staff_contract_num = string.Empty;

        /// <summary>
        /// 获取或设置
        /// </summary>
        public string Staff_contract_num
        {
            get { return Util.ChangeForSqlString(staff_contract_num); }
            set { staff_contract_num = value; }
        }
        private string staff_job_title = string.Empty;

        /// <summary>
        /// 获取或设置
        /// </summary>
        public string Staff_job_title
        {
            get { return Util.ChangeForSqlString(staff_job_title); }
            set { staff_job_title = value; }
        }
        private string staff_specialities = string.Empty;

        /// <summary>
        /// 获取或设置
        /// </summary>
        public string Staff_specialities
        {
            get { return Util.ChangeForSqlString(staff_specialities); }
            set { staff_specialities = value; }
        }

        /// <summary>
        /// 获取或设置
        /// </summary>
        public string Staff_code
        {
            get
            {
                return this.staff_code;
            }

            set
            {
                this.staff_code = value;
            }
        }

        /// <summary>
        /// 获取或设置
        /// </summary>
        public string Staff_name
        {
            get
            {
                return Util.ChangeForSqlString(this.staff_name);
            }

            set
            {
                this.staff_name = value;
            }
        }

        /// <summary>
        /// 获取或设置
        /// </summary>
        public string Staff_yxm
        {
            get
            {
                return Util.ChangeForSqlString(this.staff_yxm);
            }

            set
            {
                this.staff_yxm = value;
            }
        }

        /// <summary>
        /// 获取或设置
        /// </summary>
        public string Staff_sex
        {
            get
            {
                return this.staff_sex;
            }

            set
            {
                this.staff_sex = value;
            }
        }

        /// <summary>
        /// 获取或设置
        /// </summary>
        public DateTime Staff_birthday
        {
            get
            {
                return this.staff_birthday;
            }

            set
            {
                this.staff_birthday = value;
            }
        }

        /// <summary>
        /// 获取或设置
        /// </summary>
        public string Staff_card
        {
            get
            {
                return this.staff_card;
            }

            set
            {
                this.staff_card = value;
            }
        }

        /// <summary>
        /// 获取或设置
        /// </summary>
        public string Staff_tel
        {
            get
            {
                return this.staff_tel;
            }

            set
            {
                this.staff_tel = value;
            }
        }

        /// <summary>
        /// 获取或设置
        /// </summary>
        public string Staff_edu
        {
            get
            {
                return this.staff_edu;
            }

            set
            {
                this.staff_edu = value;
            }
        }

        /// <summary>
        /// 获取或设置
        /// </summary>
        public string Staff_introduction
        {
            get
            {
                return Util.ChangeForSqlString(this.staff_introduction);
            }

            set
            {
                this.staff_introduction = value;
            }
        }

    }
}
