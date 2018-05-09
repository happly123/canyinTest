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
        public int UpdateStaffTable(EntityStaff entity)
        {
            string SqlStr = "";
            SqlStr = "update tc_staff set ";

            SqlStr += "staff_name = '" + entity.Staff_name.Trim() + "' ";
            SqlStr += ",staff_yxm = '" + entity.Staff_yxm.Trim() + "' ";
            SqlStr += ",staff_sex = '" + entity.Staff_sex.Trim() + "' ";
            SqlStr += ",staff_birthday = '" + entity.Staff_birthday + "' ";
            SqlStr += ",staff_card = '" + entity.Staff_card.Trim() + "' ";
            SqlStr += ",staff_tel = '" + entity.Staff_tel.Trim() + "' ";
            SqlStr += ",staff_edu = '" + entity.Staff_edu.Trim() + "' ";
            SqlStr += ",staff_introduction = '" + entity.Staff_introduction.Trim() + "' ";
            SqlStr += ",staff_dep = '" + entity.Staff_dep.Trim() + "' ";
            SqlStr += ",staff_contract_num = '" + entity.Staff_contract_num.Trim() + "' ";
            SqlStr += ",staff_job_title = '" + entity.Staff_job_title.Trim() + "' ";
            SqlStr += ",staff_specialities = '" + entity.Staff_specialities.Trim() + "' ";

            SqlStr += " where staff_code= '" + entity.Staff_code.Trim() + "' ";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SqlStr;

            ExcuteSql(sqlCommand);

            return Constants.SystemConfig.SERVER_SUCCESS;
        }
    }
}
