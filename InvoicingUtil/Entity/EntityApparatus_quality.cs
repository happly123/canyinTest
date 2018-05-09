using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvoicingUtil
{
    public class EntityApparatus_quality
    {
        private string apparatus_quality_code = string.Empty;
        private string apparatus_output_code = string.Empty;
        private int apparatus_quality_count = 0;
        private string apparatus_qualityt_issued = string.Empty;
        private string apparatus_accident_conditions = string.Empty;
        private string apparatus_accident_management = string.Empty;
        private DateTime apparatus_report_date;
        private DateTime apparatus_accident_management_date;
        private string apparatus_speaker = string.Empty;
        private string apparatus_customer_feedback = string.Empty;
        private string apparatus_opinion_leader = string.Empty;

        public string Apparatus_quality_code
        {
            get { return apparatus_quality_code; }
            set { apparatus_quality_code = value; }
        }


        public string Apparatus_output_code
        {
            get { return apparatus_output_code; }
            set { apparatus_output_code = value; }
        }


        public int Apparatus_quality_count
        {
            get { return apparatus_quality_count; }
            set { apparatus_quality_count = value; }
        }


        public string Apparatus_qualityt_issued
        {
            get { return apparatus_qualityt_issued; }
            set { apparatus_qualityt_issued = value; }
        }


        public string Apparatus_accident_conditions
        {
            get { return apparatus_accident_conditions; }
            set { apparatus_accident_conditions = value; }
        }


        public DateTime Apparatus_report_date
        {
            get { return apparatus_report_date; }
            set { apparatus_report_date = value; }
        }


        public string Apparatus_accident_management
        {
            get { return apparatus_accident_management; }
            set { apparatus_accident_management = value; }
        }


        public DateTime Apparatus_accident_management_date
        {
            get { return apparatus_accident_management_date; }
            set { apparatus_accident_management_date = value; }
        }


        public string Apparatus_speaker
        {
            get { return apparatus_speaker; }
            set { apparatus_speaker = value; }
        }


        public string Apparatus_customer_feedback
        {
            get { return apparatus_customer_feedback; }
            set { apparatus_customer_feedback = value; }
        }


        public string Apparatus_opinion_leader
        {
            get { return apparatus_opinion_leader; }
            set { apparatus_opinion_leader = value; }
        }


    }
}
