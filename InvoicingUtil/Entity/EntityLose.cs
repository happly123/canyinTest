using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvoicingUtil
{
    public class EntityLose
    {
        private string lose_code = string.Empty;

        public string Lose_code
        {
            get { return lose_code; }
            set { lose_code = value; }
        }
        private string input_code = string.Empty;

        public string Input_code
        {
            get { return input_code; }
            set { input_code = value; }
        }
        private int lose_count = 0;

        public int Lose_count
        {
            get { return lose_count; }
            set { lose_count = value; }
        }
        private string lose_reason = string.Empty;

        public string Lose_reason
        {
            get { return lose_reason; }
            set { lose_reason = value; }
        }
        private string lose_applier = string.Empty;

        public string Lose_applier
        {
            get { return lose_applier; }
            set { lose_applier = value; }
        }
        private string lose_checker = string.Empty;

        public string Lose_checker
        {
            get { return lose_checker; }
            set { lose_checker = value; }
        }
        private DateTime lose_datetime = DateTime.Now;

        public DateTime Lose_datetime
        {
            get { return lose_datetime; }
            set { lose_datetime = value; }
        }
        private string lose_result = string.Empty;

        public string Lose_result
        {
            get { return lose_result; }
            set { lose_result = value; }
        }
        private string lose_remark = string.Empty;

        public string Lose_remark
        {
            get { return lose_remark; }
            set { lose_remark = value; }
        }
    }
}
