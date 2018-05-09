using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using InvoicingUtil;

namespace DataAccesses
{
    public partial class GetData
    {
        public int InsertDeviceRow(EntityDevice entityDevice)
        {
            string SqlStr = "";
            SqlStr = "insert into tc_device(device_code,device_name, device_type,device_made,device_date,device_usedate,device_address,device_application,staff_name,device_remarks)";
            SqlStr += " values('" + entityDevice.Device_code.Trim()
                                  + "','" + entityDevice.Device_name.Trim()
                                  + "','" + entityDevice.Device_type.Trim()
                                  + "','" + entityDevice.Device_made.Trim()
                                  + "','" + entityDevice.Device_date
                                  + "','" + entityDevice.Device_usedate
                                  + "','" + entityDevice.Device_address.Trim()
                                  + "','" + entityDevice.Device_application.Trim()
                                  + "','" + entityDevice.Staff_name.Trim()
                                  + "','" + entityDevice.Device_remarks.Trim()
                                  + "')";

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
