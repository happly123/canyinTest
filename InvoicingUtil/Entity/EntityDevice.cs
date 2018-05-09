using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvoicingUtil
{
    public class EntityDevice
    {
        private int device_id;
        private string device_code = string.Empty;
        private string device_name = string.Empty;
        private string device_type = string.Empty;
        private string device_made = string.Empty;
        private DateTime device_date;
        private DateTime device_usedate;
        private string device_address = string.Empty;
        private string device_application = string.Empty;
        private string staff_name = string.Empty;
        private string device_remarks = string.Empty;

        /// <summary>
        /// 获取或设置主键
        /// </summary>
        public int Device_id
        {
            get
            {
                return this.device_id;
            }

            set
            {
                this.device_id = value;
            }
        }

        /// <summary>
        /// 获取或设置设备编号
        /// </summary>
        public string Device_code
        {
            get
            {
                return this.device_code;
            }

            set
            {
                this.device_code = value;
            }
        }

        /// <summary>
        /// 获取或设置设备名称
        /// </summary>
        public string Device_name
        {
            get
            {
                return this.device_name;
            }

            set
            {
                this.device_name = value;
            }
        }

        /// <summary>
        /// 获取或设置规格型号
        /// </summary>
        public string Device_type
        {
            get
            {
                return this.device_type;
            }

            set
            {
                this.device_type = value;
            }
        }

        /// <summary>
        /// 获取或设置生产厂家
        /// </summary>
        public string Device_made
        {
            get
            {
                return this.device_made;
            }

            set
            {
                this.device_made = value;
            }
        }

        /// <summary>
        /// 获取或设置购进日期
        /// </summary>
        public DateTime Device_date
        {
            get
            {
                return this.device_date;
            }

            set
            {
                this.device_date = value;
            }
        }

        /// <summary>
        /// 获取或设置使用日期
        /// </summary>
        public DateTime Device_usedate
        {
            get
            {
                return this.device_usedate;
            }

            set
            {
                this.device_usedate = value;
            }
        }

        /// <summary>
        /// 获取或设置配置地点
        /// </summary>
        public string Device_address
        {
            get
            {
                return this.device_address;
            }

            set
            {
                this.device_address = value;
            }
        }

        /// <summary>
        /// 获取或设置用途
        /// </summary>
        public string Device_application
        {
            get
            {
                return this.device_application;
            }

            set
            {
                this.device_application = value;
            }
        }

        /// <summary>
        /// 获取或设置使用和维护人员
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
        /// 获取或设置备注
        /// </summary>
        public string Device_remarks
        {
            get
            {
                return this.device_remarks;
            }

            set
            {
                this.device_remarks = value;
            }
        }


    }
}
