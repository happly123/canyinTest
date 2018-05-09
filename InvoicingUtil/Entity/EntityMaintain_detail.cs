using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvoicingUtil
{
    public class EntityMaintain_detail
    {
        private int maintain_detail_code;
        private DateTime maintain_detail_datetime;
        private string maintain_detail_quality = string.Empty;
        private string maintain_detail_settle = string.Empty;
        private string maintain_detail_oper = string.Empty;
        private string maintain_detail_remark = string.Empty;
        private string maintain_code = string.Empty;

        public int Maintain_detail_code
        {
            get { return maintain_detail_code; }
            set { maintain_detail_code = value; }
        }


        public DateTime Maintain_detail_datetime
        {
            get { return maintain_detail_datetime; }
            set { maintain_detail_datetime = value; }
        }


        public string Maintain_detail_quality
        {
            get { return maintain_detail_quality; }
            set { maintain_detail_quality = value; }
        }


        public string Maintain_detail_settle
        {
            get { return maintain_detail_settle; }
            set { maintain_detail_settle = value; }
        }


        public string Maintain_detail_oper
        {
            get { return maintain_detail_oper; }
            set { maintain_detail_oper = value; }
        }


        public string Maintain_detail_remark
        {
            get { return maintain_detail_remark; }
            set { maintain_detail_remark = value; }
        }


        public string Maintain_code
        {
            get { return maintain_code; }
            set { maintain_code = value; }
        }



    }
}
