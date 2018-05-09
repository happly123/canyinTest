using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvoicingUtil
{
    public class EntityUpload
    {
        private int upload_id = 0;
        private DateTime upload_date;
        private string upload_result = string.Empty;
        private string upload_ip = string.Empty;

        /// <summary>
        /// 获取或设置主键
        /// </summary>
        public int Upload_id
        {
            get
            {
                return this.upload_id;
            }

            set
            {
                this.upload_id = value;
            }
        }

        /// <summary>
        /// 获取或设置上传时间
        /// </summary>
        public DateTime Upload_date
        {
            get
            {
                return this.upload_date;
            }

            set
            {
                this.upload_date = value;
            }
        }

        /// <summary>
        /// 获取或设置上传结果
        /// </summary>
        public string Upload_result
        {
            get
            {
                return this.upload_result;
            }

            set
            {
                this.upload_result = value;
            }
        }

        /// <summary>
        /// 获取或设置上传地址
        /// </summary>
        public string Upload_ip
        {
            get
            {
                return this.upload_ip;
            }

            set
            {
                this.upload_ip = value;
            }
        }
    }
}
