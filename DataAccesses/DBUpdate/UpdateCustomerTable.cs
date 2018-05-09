using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InvoicingUtil;
using System.Data.SqlClient;
using System.Collections;

namespace DataAccesses
{
    public partial class GetData
    {
        public int UpdateCustomer(EntityCustomer entity)
        {
            string SqlStr = "";
            SqlStr = "update tc_customer set ";

            SqlStr += "customer_name = '" + entity.Customer_name.Trim() + "' ";
            SqlStr += ",customer_yxm = '" + entity.Customer_yxm.Trim() + "' ";
            SqlStr += ",customer_artificial_person = '" + entity.Customer_artificial_person.Trim() + "' ";
            SqlStr += ",customer_bank = '" + entity.Customer_bank.Trim() + "' ";
            SqlStr += ",customer_bank_num = '" + entity.Customer_bank_num.Trim() + "' ";
            SqlStr += ",customer_address = '" + entity.Customer_address.Trim() + "' ";
            SqlStr += ",customer_principal = '" + entity.Customer_principal.Trim() + "' ";
            SqlStr += ",customer_tariff_num = '" + entity.Customer_tariff_num.Trim() + "' ";
            SqlStr += ",customer_licence = '" + entity.Customer_licence.Trim() + "' ";
            SqlStr += ",customer_business_licence = '" + entity.Customer_business_licence.Trim() + "' ";
            SqlStr += ",customer_type = '" + entity.Customer_type.Trim() + "' ";
            SqlStr += ",customer_tel = '" + entity.Customer_tel.Trim() + "' ";
            SqlStr += ",customer_fax = '" + entity.Customer_fax.Trim() + "' ";
            SqlStr += ",customer_postal_code = '" + entity.Customer_postal_code.Trim() + "' ";
            SqlStr += ",customer_medical_institutions = '" + entity.Customer_medical_institutions.Trim() + "' ";
            SqlStr += ",customer_quality = '" + entity.Customer_quality.Trim() + "' ";
            SqlStr += ",customer_flag = '" + entity.Customer_flag.Trim() + "' ";

            SqlStr += " where customer_code= '" + entity.Customer_code.Trim() + "' ";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SqlStr;

            ExcuteSql(sqlCommand);

            return Constants.SystemConfig.SERVER_SUCCESS;
        }
    }
}
