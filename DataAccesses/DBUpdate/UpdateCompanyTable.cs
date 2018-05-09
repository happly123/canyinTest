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
        public int UpdateCompanyTable(EntityCompany entity)
        {
            string SqlStr = "";

            SqlStr = "update tc_company set ";

            SqlStr += " company_name = '" + entity.Company_name.Trim() + "' ";

            SqlStr += ",company_registered_address = '" + entity.Company_registered_address.Trim() + "' ";

            SqlStr += ",company_rel_address = '" + entity.Company_rel_address.Trim() + "' ";           

            SqlStr += ",company_storage_address = '" + entity.Company_storage_address.Trim() + "' ";

            SqlStr += ",company_artificial_person = '" + entity.Company_artificial_person.Trim() + "' ";

            SqlStr += ",company_principal = '" + entity.Company_principal.Trim() + "' ";

            SqlStr += ",company_business_type = '" + entity.Company_business_type.Trim() + "' ";

            SqlStr += ",company_licence = '" + entity.Company_licence.Trim() + "' ";

            SqlStr += ",company_business_licence = '" + entity.Company_business_licence.Trim() + "' ";

            SqlStr += ",company_tel = '" + entity.Company_tel.Trim() + "' ";

            SqlStr += ",company_fax = '" + entity.Company_fax.Trim() + "' ";

            SqlStr += ",company_postal_code = '" + entity.Company_postal_code.Trim() + "' ";

            SqlStr += ",company_bank = '" + entity.Company_bank.Trim() + "' ";

            SqlStr += ",company_bank_num = '" + entity.Company_bank_num.Trim() + "' ";

            SqlStr += ",company_tariff_num = '" + entity.Company_tariff_num.Trim() + "' ";

            SqlStr += ",company_quality_persion = '" + entity.Company_quality_persion.Trim() + "' ";

            SqlStr += ",company_business_scope = '" + entity.Company_business_scope.Trim() + "' ";

            SqlStr += ",company_mobile = '" + entity.Company_mobile.Trim() + "' ";

            SqlStr += ",company_style = '" + entity.Company_style.Trim() + "' ";

            SqlStr += " where company_code= '" + entity.Company_code.Trim() + "' ";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SqlStr;

            ExcuteSql(sqlCommand);

            return Constants.SystemConfig.SERVER_SUCCESS;
        }
    }
}
