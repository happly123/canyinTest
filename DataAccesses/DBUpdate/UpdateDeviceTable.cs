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
        public int UpdateDeviceTable(EntityDevice entity)
        {
            string SqlStr = "";
            SqlStr = "update tc_device set ";

            if (entity.Device_code.Trim() != string.Empty)
            {
                SqlStr += "device_code = '" + entity.Device_code.Trim() + "' ";
            }

            if (entity.Device_name.Trim() != string.Empty)
            {
                SqlStr += ",device_name = '" + entity.Device_name.Trim() + "' ";
            }

            if (entity.Device_type.Trim() != string.Empty)
            {
                SqlStr += ",device_type = '" + entity.Device_type.Trim() + "' ";
            }

            if (entity.Device_made.Trim() != string.Empty)
            {
                SqlStr += ",device_made = '" + entity.Device_made.Trim() + "' ";
            }

            SqlStr += ",device_date = '" + entity.Device_date.Date + "' ";

            SqlStr += ",device_usedate = '" + entity.Device_usedate.Date + "' ";

            if (entity.Device_address.Trim() != string.Empty)
            {
                SqlStr += ",device_address = '" + entity.Device_address.Trim() + "' ";
            }

            if (entity.Device_application.Trim() != string.Empty)
            {
                SqlStr += ",device_application = '" + entity.Device_application.Trim() + "' ";
            }

            if (entity.Staff_name.Trim() != string.Empty)
            {
                SqlStr += ",staff_name = '" + entity.Staff_name.Trim() + "' ";
            }

            if (entity.Device_remarks.Trim() != string.Empty)
            {
                SqlStr += ",device_remarks = '" + entity.Device_remarks.Trim() + "' ";
            }

            SqlStr += " where device_id= " + entity.Device_id.ToString() + " ";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SqlStr;

            ExcuteSql(sqlCommand);

            return Constants.SystemConfig.SERVER_SUCCESS;
        }
    }
}
