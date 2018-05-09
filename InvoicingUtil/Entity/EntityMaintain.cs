using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvoicingUtil
{
    public class EntityMaintain
    {
        private string maintain_code = string.Empty;
        private string maintain_input_code = string.Empty;
        private string maintain_application = string.Empty;
        private string maintain_purpose = string.Empty;
        private string maintain_quality = string.Empty;
        private string maintain_test_items = string.Empty;
        private string maintain_characters = string.Empty;
        private DateTime maintain_create_date;

        public string Maintain_code
        {
            get { return maintain_code; }
            set { maintain_code = value; }
        }


        public string Maintain_input_code
        {
            get { return maintain_input_code; }
            set { maintain_input_code = value; }
        }


        public string Maintain_application
        {
            get { return maintain_application; }
            set { maintain_application = value; }
        }


        public string Maintain_purpose
        {
            get { return maintain_purpose; }
            set { maintain_purpose = value; }
        }


        public string Maintain_quality
        {
            get { return maintain_quality; }
            set { maintain_quality = value; }
        }


        public string Maintain_test_items
        {
            get { return maintain_test_items; }
            set { maintain_test_items = value; }
        }


        public string Maintain_characters
        {
            get { return maintain_characters; }
            set { maintain_characters = value; }
        }


        public DateTime Maintain_create_date
        {
            get { return maintain_create_date; }
            set { maintain_create_date = value; }
        }


    }
}
