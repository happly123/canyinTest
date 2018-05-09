using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace InvoicingUtil
{

    /// <summary>
    /// 用户类
    /// </summary>
    public class LoginUser
    {
        public LoginUser()
        {

        }

        /// <summary>
        /// 用户存储
        /// </summary>
        private static Hashtable ht = new Hashtable();

       /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="ht">用户存储</param>
        public LoginUser(Hashtable ht)
        {

            LoginUser.ht = ht;
        }

        /// <summary>
        /// 用户账号
        /// </summary>
        public static string UserCode
        {
            get
            {
                return ht["User_Code"].ToString();
            }
        }

        /// <summary>
        /// 用户姓名
        /// </summary>
        public static string UserName
        {
            get
            {
                return ht["User_Name"].ToString();
            }
        }

        /// <summary>
        /// 用户职位
        /// </summary>
        public static string UserDep
        {
            get
            {
                return ht["User_Dep"].ToString();
            }
        }

        /// <summary>
        /// 用户权限
        /// </summary>
        public static string UserAuthority
        {
            get
            {
                return ht["User_Authority"].ToString();
            }
        }

        /// <summary>
        /// 登录时间
        /// </summary>
        public static DateTime LogOnTime
        {
            get
            {
                return DateTime.Parse(ht["LogOnTime"].ToString());
            }
        }

        /// <summary>
        /// 登录时间
        /// </summary>
        public static string SqlSetUpPath
        {
            get
            {
                return ht["SqlSetUpPath"].ToString();
            }
        }

        public static string CompanyType
        {
            get
            {
                return ht["CompanyType"].ToString();
            }
        }
    }
}
