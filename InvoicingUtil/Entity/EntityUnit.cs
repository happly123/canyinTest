using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvoicingUtil
{
    public class EntityUnit
    {
        private string unit_code = string.Empty;

        public string Unit_code
        {
            get { return unit_code; }
            set { unit_code = value; }
        }        

        private string unit_name = string.Empty;

        public string Unit_name
        {
            get { return unit_name; }
            set { unit_name = value; }
        }

        private string unit_yxm = string.Empty;

        public string Unit_yxm
        {
            get { return unit_yxm; }
            set { unit_yxm = value; }
        }

    }
}
