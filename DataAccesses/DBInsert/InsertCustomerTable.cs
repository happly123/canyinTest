using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InvoicingUtil;
using System.Data.SqlClient;

namespace DataAccesses
{
    public partial class GetData
    {
        public int InsertCustomer(EntityCustomer entityCustomer)
        {
            string SqlStr = "";
            SqlStr = "insert into tc_customer";
            SqlStr += " values('" 
                + entityCustomer.Customer_code.Trim() + "','" 
                + entityCustomer.Customer_name.Trim() + "','" 
                + entityCustomer.Customer_yxm.Trim() + "','" 
                + entityCustomer.Customer_artificial_person.Trim() + "','" 
                + entityCustomer.Customer_bank.Trim() + "','" 
                + entityCustomer.Customer_bank_num.Trim() + "','" 
                + entityCustomer.Customer_address.Trim() + "','" 
                + entityCustomer.Customer_principal.Trim() + "','" 
                + entityCustomer.Customer_tariff_num.Trim() + "','" 
                + entityCustomer.Customer_licence.Trim() + "','" 
                + entityCustomer.Customer_business_licence.Trim() + "','"
                + entityCustomer.Customer_type.Trim() + "','"
                + entityCustomer.Customer_tel.Trim() + "','"
                + entityCustomer.Customer_fax.Trim() + "','" 
                + entityCustomer.Customer_postal_code.Trim() + "','" 
                + entityCustomer.Customer_medical_institutions.Trim() + "','"
                + entityCustomer.Customer_quality.Trim() + "','" 
                + entityCustomer.Customer_flag.Trim() + "')"; 
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SqlStr;
            try
            {
                ExcuteSql(sqlCommand);
            }
            catch
            {
                return Constants.SystemConfig.SERVER_ERROR;
            }

            return Constants.SystemConfig.SERVER_SUCCESS;
        }

    }
}
