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
        public int InsertCompanyRow(EntityCompany entity)
        {
            string SqlStr = "";
            SqlStr = "insert into tc_company(company_code,Company_name,Company_registered_address,Company_rel_address,"
                + " Company_storage_address,Company_artificial_person,Company_principal,Company_business_type,Company_licence,Company_business_licence,"
                +"Company_tel,Company_fax,Company_postal_code,Company_bank,"
                +"Company_bank_num,Company_tariff_num,Company_mobile,Company_quality_persion,Company_business_scope,Company_style)";
            SqlStr += " values('" + entity.Company_code.Trim() + "','" + entity.Company_name.Trim() + "','" + entity.Company_registered_address.Trim() + "','"
            + entity.Company_rel_address.Trim() + "','" + entity.Company_storage_address.Trim() + "','"
            + entity.Company_artificial_person.Trim() + "','" + entity.Company_principal.Trim() + "','"
            + entity.Company_business_type.Trim() + "','" + entity.Company_licence.Trim() + "','" + entity.Company_business_licence.Trim() + "','"
            + entity.Company_tel.Trim() + "','" + entity.Company_fax.Trim() + "','" + entity.Company_postal_code.Trim() + "','" + entity.Company_bank.Trim() + "','"
            + entity.Company_bank_num.Trim() + "','" + entity.Company_tariff_num.Trim() + "','" + entity.Company_mobile.Trim() + "','" + entity.Company_quality_persion.Trim() + "','"+entity.Company_business_scope.Trim()+"','"+entity.Company_style.Trim()+"')";
            
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SqlStr;

            ExcuteSql(sqlCommand);

            return Constants.SystemConfig.SERVER_SUCCESS;
        }
    }
}
