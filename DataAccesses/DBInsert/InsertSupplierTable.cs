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
        public int InsertSupplier(EntitySupplier entitySupplier)
        {
            string SqlStr = "";
            SqlStr = "insert into TC_SUPPLIER";
            SqlStr += " values('" 
                + entitySupplier.Supplier_code.Trim() + "','"
                + entitySupplier.Supplier_name.Trim() + "','"
                + entitySupplier.Supplier_yxm.Trim() + "','"
                + entitySupplier.Supplier_address.Trim() + "','"
                + entitySupplier.Supplier_artificial_person.Trim() + "','"
                + entitySupplier.Supplier_business_scpoe.Trim() + "','"
                + entitySupplier.Supplier_licence.Trim() + "','"
                + entitySupplier.Supplier_trustpersion.Trim() + "','"
                + entitySupplier.Supplier_tariff_num.Trim() + "','"
                + entitySupplier.Supplier_principal.Trim() + "','"
                + entitySupplier.Supplier_bank.Trim() + "','"
                + entitySupplier.Supplier_bank_num.Trim() + "','"
                + entitySupplier.Supplier_tel.Trim() + "','"
                + entitySupplier.Supplier_fax.Trim() + "','"
                + entitySupplier.Supplier_business_licence.Trim() + "','"
                + entitySupplier.Supplier_postal_code.Trim() + "','"
                + entitySupplier.Supplier_make_quality_num.Trim() + "','"
                + entitySupplier.Supplier_business_num.Trim() + "','"
                + entitySupplier.Supplier_type.Trim() + "')";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SqlStr;

            ExcuteSql(sqlCommand);

            return Constants.SystemConfig.SERVER_SUCCESS;
        }

    }
}
