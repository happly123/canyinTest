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
        public int InsertStaffRow(EntityStaff entity)
        {
            string SqlStr = "";
            SqlStr = "insert into tc_staff(Staff_code,Staff_name,Staff_yxm,Staff_sex,"
                + "Staff_birthday,Staff_card,Staff_tel,Staff_edu,Staff_introduction,Staff_dep,Staff_contract_num,Staff_job_title,Staff_specialities)";
            SqlStr += " values('" + entity.Staff_code.Trim() + "','" + entity.Staff_name.Trim() + "','" + entity.Staff_yxm.Trim() + "','" + entity.Staff_sex.Trim()
                + "','" + entity.Staff_birthday + "','" + entity.Staff_card.Trim() + "','" + entity.Staff_tel.Trim() + "','" + entity.Staff_edu.Trim() + "','" 
                + entity.Staff_introduction.Trim() + "','"+entity.Staff_dep.Trim()+"','"+entity.Staff_contract_num.Trim()+"','"+entity.Staff_job_title.Trim()+"','"+entity.Staff_specialities.Trim()+"')";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SqlStr;

            ExcuteSql(sqlCommand);

            return Constants.SystemConfig.SERVER_SUCCESS;
        }
    }
}
