using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvoicingUtil
{
    public class EntityAuthority
    {
        private int id;
        private string authority_user_code;
        private string authority_password;
        private string authority_level;
        private string staff_code;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Authority_user_code
        {
            get { return authority_user_code; }
            set { authority_user_code = value; }
        }

        public string Authority_password
        {
            get { return authority_password; }
            set { authority_password = value; }
        }

        public string Authority_level
        {
            get { return authority_level; }
            set { authority_level = value; }
        }
        

        public string Staff_code
        {
            get { return staff_code; }
            set { staff_code = value; }
        }
    }
}
