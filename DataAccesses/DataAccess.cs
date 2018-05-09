using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
namespace DataAccesses
{

    /// <summary>
    /// 数据库连接类
    /// </summary>
    public class DataAccess
    {
        public DataAccess()
        {

        }

        /// <summary>
        /// 连接字符串
        /// </summary>
        private string connectionString = String.Empty;

        private SqlConnection sqlConnection = null;

        public SqlConnection Connection
        {
            set
            {
                this.sqlConnection = value;
            }
            get
            {
                return this.sqlConnection;
            }

        }

        private SqlTransaction sqlTransaction = null;

        public SqlTransaction Transaction
        {
            set
            {
                this.sqlTransaction = value;
            }
            get
            {
                return this.sqlTransaction;
            }

        }

        private IsolationLevel enumisolationLevel = IsolationLevel.ReadCommitted;

        public IsolationLevel IsolationLevel
        {
            get
            {
                return this.enumisolationLevel;
            }
            set
            {
                this.enumisolationLevel = value;
            }
        }

        /// <summary>
        /// 打开数据库连接
        /// </summary>
        public void Open()
        {

            //取得连接字符串
            this.connectionString = "Data Source=" + ConfigurationManager.AppSettings["Source"].ToString() + ";"
                                    + "Initial Catalog=" + ConfigurationManager.AppSettings["DataBace"].ToString() + ";";
            if (ConfigurationManager.AppSettings["UserID"].ToString() != string.Empty)
            {
                this.connectionString += "User ID=" + ConfigurationManager.AppSettings["UserID"].ToString() + ";"
                    + "Password=" + ConfigurationManager.AppSettings["PassWord"].ToString() + ";"
                    + "Connect Timeout=30";
            }
            else
            {

                this.connectionString += "trusted_connection=sspi;Connect Timeout=30";
            }

            if (this.sqlConnection == null)
            {

                //打开连接
                this.sqlConnection = new SqlConnection(this.connectionString);
                this.sqlConnection.Open();
            }
            else
            {
                //设置连接状态
                if (this.sqlConnection.State != ConnectionState.Open)
                {
                    this.sqlConnection.Open();
                }
            }
        }

        /// <summary>
        /// 关闭数据库
        /// </summary>
        public void Close()
        {
            if (this.sqlConnection != null)
            {
                //设置连接状态
                if (this.sqlConnection.State != ConnectionState.Closed)
                {
                    this.sqlConnection.Close();
                }
            }
            if (this.sqlTransaction != null)
            {
                //关闭事务
                this.sqlTransaction.Dispose();
                this.sqlTransaction = null;
            }

            //释放连接
            this.sqlConnection.Dispose();
            this.sqlConnection = null;
        }

        /// <summary>
        /// 打开事务
        /// </summary>
        public void BeginTransaction()
        {
            if (this.sqlTransaction == null)
            {
                this.sqlTransaction = this.sqlConnection.BeginTransaction(this.IsolationLevel);
            }
        }

        /// <summary>
        /// 提交事务
        /// </summary>
        public void Commit()
        {
            if (this.sqlTransaction != null)
            {
                this.sqlTransaction.Commit();
            }
        }

        /// <summary>
        /// 回滚事务
        /// </summary>
        public void Rollback()
        {
            if (this.sqlTransaction != null)
            {
                this.sqlTransaction.Rollback();
            }
        }

    }
}
