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
        public int UpdateSupplier(EntitySupplier entity) 
        {
            string SqlStr = "";
            SqlStr = "update tc_supplier set ";

            SqlStr += "Supplier_code  = '" + entity.Supplier_code.Trim() + "' ";
            SqlStr += ",Supplier_name  = '" + entity.Supplier_name.Trim() + "' ";
            SqlStr += ",Supplier_yxm  = '" + entity.Supplier_yxm.Trim() + "' ";
            SqlStr += ",Supplier_address  = '" + entity.Supplier_address.Trim() + "' ";
            SqlStr += ",Supplier_artificial_person  = '" + entity.Supplier_artificial_person.Trim() + "' ";
            SqlStr += ",Supplier_business_scpoe  = '" + entity.Supplier_business_scpoe.Trim() + "' ";
            SqlStr += ",Supplier_licence  = '" + entity.Supplier_licence.Trim() + "' ";
            SqlStr += ",Supplier_trustpersion  = '" + entity.Supplier_trustpersion.Trim() + "' ";
            SqlStr += ",Supplier_tariff_num  = '" + entity.Supplier_tariff_num.Trim() + "' ";
            SqlStr += ",Supplier_principal  = '" + entity.Supplier_principal.Trim() + "' ";
            SqlStr += ",Supplier_bank  = '" + entity.Supplier_bank.Trim() + "' ";
            SqlStr += ",Supplier_bank_num  = '" + entity.Supplier_bank_num.Trim() + "' ";
            SqlStr += ",Supplier_tel  = '" + entity.Supplier_tel.Trim() + "' ";
            SqlStr += ",Supplier_fax  = '" + entity.Supplier_fax.Trim() + "' ";
            SqlStr += ",Supplier_business_licence  = '" + entity.Supplier_business_licence.Trim() + "' ";
            SqlStr += ",Supplier_postal_code  = '" + entity.Supplier_postal_code.Trim() + "' ";
            SqlStr += ",Supplier_make_quality_num  = '" + entity.Supplier_make_quality_num.Trim() + "' ";
            SqlStr += ",Supplier_business_num  = '" + entity.Supplier_business_num.Trim() + "' ";
            SqlStr += ",Supplier_type  = '" + entity.Supplier_type.Trim() + "' ";
            SqlStr += " where supplier_code = '" + entity.Supplier_code.Trim() + "' ";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SqlStr;

            ExcuteSql(sqlCommand);

            return Constants.SystemConfig.SERVER_SUCCESS;
        }
    }
}
