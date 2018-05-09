using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvoicingUtil
{
    public class EntityOutput_storage
    {
        private string output_code = string.Empty;

        public string Output_code
        {
            get { return output_code; }
            set { output_code = value; }
        }
        private string input_code = string.Empty;

        public string Input_code
        {
            get { return input_code; }
            set { input_code = value; }
        }
        private string customer_code = string.Empty;

        public string Customer_code
        {
            get { return customer_code; }
            set { customer_code = value; }
        }
        private int output_count = 0;

        public int Output_count
        {
            get { return output_count; }
            set { output_count = value; }
        }
        private string output_check_persion = string.Empty;

        public string Output_check_persion
        {
            get { return output_check_persion; }
            set { output_check_persion = value; }
        }
        private string output_oper = string.Empty;

        public string Output_oper
        {
            get { return output_oper; }
            set { output_oper = value; }
        }
        private string output_quality_persion = string.Empty;

        public string Output_quality_persion
        {
            get { return output_quality_persion; }
            set { output_quality_persion = value; }
        }
        private string output_issued = string.Empty;

        public string Output_issued
        {
            get { return output_issued; }
            set { output_issued = value; }
        }
        private string output_packing_in = string.Empty;

        public string Output_packing_in
        {
            get { return output_packing_in; }
            set { output_packing_in = value; }
        }
        private string output_packing_mid = string.Empty;

        public string Output_packing_mid
        {
            get { return output_packing_mid; }
            set { output_packing_mid = value; }
        }
        private string output_packing_out = string.Empty;

        public string Output_packing_out
        {
            get { return output_packing_out; }
            set { output_packing_out = value; }
        }
        private string output_remark = string.Empty;

        public string Output_remark
        {
            get { return output_remark; }
            set { output_remark = value; }
        }
        private DateTime output_instorage_date = DateTime.Now;

        public DateTime Output_instorage_date
        {
            get { return output_instorage_date; }
            set { output_instorage_date = value; }
        }
        private DateTime output_checktime = DateTime.Now;

        public DateTime Output_checktime
        {
            get { return output_checktime; }
            set { output_checktime = value; }
        }
        private string output_type = string.Empty;

        public string Output_type
        {
            get { return output_type; }
            set { output_type = value; }
        }
        private string output_backreason = string.Empty;

        public string Output_backreason
        {
            get { return output_backreason; }
            set { output_backreason = value; }
        }

        private string operate_type = string.Empty;

        public string Operate_type
        {
            get { return operate_type; }
            set { operate_type = value; }
        }
    }
}
