using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvoicingUtil
{
    public class EntitySystemLog
    {
        private DateTime dateLogOn;
        private DateTime dateLogOff;
        private string userName = string.Empty;

        /// <summary>
        /// 登录时间
        /// </summary>
        public DateTime DateLogOn
        {
            get
            {
                return this.dateLogOn;
            }

            set
            {
                this.dateLogOn = value;
            }
        }

        /// <summary>
        /// 退出时间
        /// </summary>
        public DateTime DateLogOff
        {
            get
            {
                return this.dateLogOff;
            }

            set
            {
                this.dateLogOff = value;
            }
        }

        /// <summary>
        /// 登录人姓名
        /// </summary>
        public string UserName
        {
            get
            {
                return this.userName;
            }

            set
            {
                this.userName = value;
            }
        }
    }
}
