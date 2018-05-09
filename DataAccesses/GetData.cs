using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using InvoicingUtil;

namespace DataAccesses
{

    public partial class GetData
    {
        private SqlConnection connection = null;
        private SqlTransaction transaction = null;
        private DataTable dt = null;

        public GetData(SqlConnection conn, SqlTransaction tran)
        {
            this.connection = conn;
            this.transaction = tran;
        }

        public GetData(SqlConnection conn)
        {
            this.connection = conn;
        }

        public DataTable GetSingleTable(string tableName)
        {
            try
            {
                dt = new DataTable();
                string SqlStr = "SELECT * FROM " + tableName;
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = SqlStr;
                GetDataTable(sqlCommand, dt);

                return dt;
            }
            catch (Exception ex)
            {

                return null;
            }
            finally
            {
                connection.Close();
            }

        }

        protected DataTable GetDataTable(SqlCommand command, DataTable dt)
        {
            command.Connection = connection;
            if (transaction != null)
            {
                command.Transaction = transaction;
            }

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);

            sqlDataAdapter.Fill(dt);

            return dt;
        }

        public DataTable GetSingleTableByCondition(string tableName, SearchParameter sp)
        {
            try
            {
                if (dt == null)
                {
                    dt = new DataTable();
                }
                string SqlStr = "";
                SqlStr = "SELECT * FROM " + tableName;
                ArrayList arrayList = sp.Keys();
                SqlCommand sqlCommand = new SqlCommand();

                for (int i = 0; i < arrayList.Count; i++)
                {
                    if (i == 0)
                    {
                        switch (sp.GetHashTable[arrayList[i]].GetType().Name)
                        {
                            case "String":
                                SqlStr += " where " + arrayList[i].ToString().Replace(":", "") + " like '%" + sp.GetValue(arrayList[i].ToString()) + "%'";
                                break;
                            case "Int32":
                                SqlStr += " where " + arrayList[i].ToString().Replace(":", "") + "= " + sp.GetValue(arrayList[i].ToString()) + "";
                                break;
                            case "DateTime":
                                if (arrayList[i].ToString().Trim().ToUpper().Contains("_FROM"))
                                {
                                    SqlStr += " where " + arrayList[i].ToString().Replace(":", "").Replace("_FROM", "") + ">= '" + sp.GetValue(arrayList[i].ToString()) + "'";
                                }
                                else if (arrayList[i].ToString().Trim().ToUpper().Contains("_TO"))
                                {
                                    SqlStr += " where " + arrayList[i].ToString().Replace(":", "").Replace("_TO", "") + "<= '" + sp.GetValue(arrayList[i].ToString()) + "'";
                                }
                                break;
                            default:
                                SqlStr += " where " + arrayList[i].ToString().Replace(":", "") + " like '%" + sp.GetValue(arrayList[i].ToString()) + "%'";
                                break;
                        }

                    }
                    else
                    {
                        switch (sp.GetHashTable[arrayList[i]].GetType().Name)
                        {
                            case "String":
                                SqlStr += " and " + arrayList[i].ToString().Replace(":", "") + " like '%" + sp.GetValue(arrayList[i].ToString()) + "%'";
                                break;
                            case "Int32":
                                SqlStr += " and " + arrayList[i].ToString().Replace(":", "") + " = " + sp.GetValue(arrayList[i].ToString()) + "";
                                break;
                            case "DateTime":
                                if (arrayList[i].ToString().Trim().ToUpper().Contains("_FROM"))
                                {
                                    SqlStr += " and " + arrayList[i].ToString().Replace(":", "").Replace("_FROM", "") + ">= '" + sp.GetValue(arrayList[i].ToString()) + "'";
                                }
                                else if (arrayList[i].ToString().Trim().ToUpper().Contains("_TO"))
                                {
                                    SqlStr += " and " + arrayList[i].ToString().Replace(":", "").Replace("_TO", "") + "<= '" + sp.GetValue(arrayList[i].ToString()) + "'";
                                }
                                break;
                            default:
                                SqlStr += " and " + arrayList[i].ToString().Replace(":", "") + " like '%" + sp.GetValue(arrayList[i].ToString()) + "%'";
                                break;
                        }
                    }
                }

                sqlCommand.CommandText = SqlStr;

                GetDataTable(sqlCommand, dt);

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                connection.Close();
            }

        }

        public DataTable GetSingleTableByConditionUnLike(string tableName, SearchParameter sp)
        {
            try
            {
                if (dt == null)
                {
                    dt = new DataTable();
                }
                string SqlStr = "";
                SqlStr = "SELECT * FROM " + tableName;
                ArrayList arrayList = sp.Keys();
                SqlCommand sqlCommand = new SqlCommand();

                for (int i = 0; i < arrayList.Count; i++)
                {
                    if (i == 0)
                    {
                        switch (sp.GetHashTable[arrayList[i]].GetType().Name)
                        {
                            case "String":
                                SqlStr += " where " + arrayList[i].ToString().Replace(":", "") + " like '" + sp.GetValue(arrayList[i].ToString()) + "'";
                                break;
                            case "Int32":
                                SqlStr += " where " + arrayList[i].ToString().Replace(":", "") + "= " + sp.GetValue(arrayList[i].ToString()) + "";
                                break;
                            case "DateTime":
                                if (arrayList[i].ToString().Trim().ToUpper().Contains("_FROM"))
                                {
                                    SqlStr += " where " + arrayList[i].ToString().Replace(":", "").Replace("_FROM", "") + ">= '" + sp.GetValue(arrayList[i].ToString()) + "'";
                                }
                                else if (arrayList[i].ToString().Trim().ToUpper().Contains("_TO"))
                                {
                                    SqlStr += " where " + arrayList[i].ToString().Replace(":", "").Replace("_TO", "") + "<= '" + sp.GetValue(arrayList[i].ToString()) + "'";
                                }
                                break;
                            default:
                                SqlStr += " where " + arrayList[i].ToString().Replace(":", "") + " like '" + sp.GetValue(arrayList[i].ToString()) + "'";
                                break;
                        }

                    }
                    else
                    {
                        switch (sp.GetHashTable[arrayList[i]].GetType().Name)
                        {
                            case "String":
                                SqlStr += " and " + arrayList[i].ToString().Replace(":", "") + " like '" + sp.GetValue(arrayList[i].ToString()) + "'";
                                break;
                            case "Int32":
                                SqlStr += " and " + arrayList[i].ToString().Replace(":", "") + " = " + sp.GetValue(arrayList[i].ToString()) + "";
                                break;
                            case "DateTime":
                                if (arrayList[i].ToString().Trim().ToUpper().Contains("_FROM"))
                                {
                                    SqlStr += " and " + arrayList[i].ToString().Replace(":", "").Replace("_FROM", "") + ">= '" + sp.GetValue(arrayList[i].ToString()) + "'";
                                }
                                else if (arrayList[i].ToString().Trim().ToUpper().Contains("_TO"))
                                {
                                    SqlStr += " and " + arrayList[i].ToString().Replace(":", "").Replace("_TO", "") + "<= '" + sp.GetValue(arrayList[i].ToString()) + "'";
                                }
                                break;
                            default:
                                SqlStr += " and " + arrayList[i].ToString().Replace(":", "") + " like '" + sp.GetValue(arrayList[i].ToString()) + "'";
                                break;
                        }
                    }
                }

                sqlCommand.CommandText = SqlStr;

                GetDataTable(sqlCommand, dt);

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                connection.Close();
            }

        }

        public DataTable GetTableBySqlStr(string sqlStr, SearchParameter sp)
        {
            dt = new DataTable();
            ArrayList arrayList = sp.Keys();
            SqlCommand sqlCommand = new SqlCommand();

            for (int i = 0; i < arrayList.Count; i++)
            {
                if (i == 0)
                {
                    switch (sp.GetHashTable[arrayList[i]].GetType().Name)
                    {
                        case "String":
                            sqlStr += " where " + arrayList[i].ToString().Replace(":", "") + " like '%" + sp.GetValue(arrayList[i].ToString()) + "%'";
                            break;
                        case "Int32":
                            sqlStr += " where " + arrayList[i].ToString().Replace(":", "") + "= " + sp.GetValue(arrayList[i].ToString()) + "";
                            break;
                        case "DateTime":
                            if (arrayList[i].ToString().Trim().ToUpper().Contains("_FROM"))
                            {
                                sqlStr += " where " + arrayList[i].ToString().Replace(":", "").Replace("_FROM", "") + ">= '" + sp.GetValue(arrayList[i].ToString()) + "'";
                            }
                            else if (arrayList[i].ToString().Trim().ToUpper().Contains("_TO"))
                            {
                                sqlStr += " where " + arrayList[i].ToString().Replace(":", "").Replace("_TO", "") + "<= '" + sp.GetValue(arrayList[i].ToString()) + "'";
                            }
                            break;
                        default:
                            sqlStr += " where " + arrayList[i].ToString().Replace(":", "") + " like '%" + sp.GetValue(arrayList[i].ToString()) + "%'";
                            break;
                    }

                }
                else
                {
                    switch (sp.GetHashTable[arrayList[i]].GetType().Name)
                    {
                        case "String":
                            sqlStr += " and " + arrayList[i].ToString().Replace(":", "") + " like '%" + sp.GetValue(arrayList[i].ToString()) + "%'";
                            break;
                        case "Int32":
                            sqlStr += " and " + arrayList[i].ToString().Replace(":", "") + " = " + sp.GetValue(arrayList[i].ToString()) + "";
                            break;
                        case "DateTime":
                            if (arrayList[i].ToString().Trim().ToUpper().Contains("_FROM"))
                            {
                                sqlStr += " and " + arrayList[i].ToString().Replace(":", "").Replace("_FROM", "") + ">= '" + sp.GetValue(arrayList[i].ToString()) + "'";
                            }
                            else if (arrayList[i].ToString().Trim().ToUpper().Contains("_TO"))
                            {
                                sqlStr += " and " + arrayList[i].ToString().Replace(":", "").Replace("_TO", "") + "<= '" + sp.GetValue(arrayList[i].ToString()) + "'";
                            }
                            break;
                        default:
                            sqlStr += " and " + arrayList[i].ToString().Replace(":", "") + " like '%" + sp.GetValue(arrayList[i].ToString()) + "%'";
                            break;
                    }
                }
            }

            sqlCommand.CommandText = sqlStr;

            GetDataTable(sqlCommand, dt);

            return dt;
        }

        public DataTable GetTableBySqlStrUnLike(string sqlStr, SearchParameter sp)
        {
            dt = new DataTable();
            ArrayList arrayList = sp.Keys();
            SqlCommand sqlCommand = new SqlCommand();

            for (int i = 0; i < arrayList.Count; i++)
            {
                if (i == 0)
                {
                    switch (sp.GetHashTable[arrayList[i]].GetType().Name)
                    {
                        case "String":
                            sqlStr += " where " + arrayList[i].ToString().Replace(":", "") + " like '" + sp.GetValue(arrayList[i].ToString()) + "'";
                            break;
                        case "Int32":
                            sqlStr += " where " + arrayList[i].ToString().Replace(":", "") + "= " + sp.GetValue(arrayList[i].ToString()) + "";
                            break;
                        case "DateTime":
                            if (arrayList[i].ToString().Trim().ToUpper().Contains("_FROM"))
                            {
                                sqlStr += " where " + arrayList[i].ToString().Replace(":", "").Replace("_FROM", "") + ">= '" + sp.GetValue(arrayList[i].ToString()) + "'";
                            }
                            else if (arrayList[i].ToString().Trim().ToUpper().Contains("_TO"))
                            {
                                sqlStr += " where " + arrayList[i].ToString().Replace(":", "").Replace("_TO", "") + "<= '" + sp.GetValue(arrayList[i].ToString()) + "'";
                            }
                            break;
                        default:
                            sqlStr += " where " + arrayList[i].ToString().Replace(":", "") + " like '" + sp.GetValue(arrayList[i].ToString()) + "'";
                            break;
                    }

                }
                else
                {
                    switch (sp.GetHashTable[arrayList[i]].GetType().Name)
                    {
                        case "String":
                            sqlStr += " and " + arrayList[i].ToString().Replace(":", "") + " like '" + sp.GetValue(arrayList[i].ToString()) + "'";
                            break;
                        case "Int32":
                            sqlStr += " and " + arrayList[i].ToString().Replace(":", "") + " = " + sp.GetValue(arrayList[i].ToString()) + "";
                            break;
                        case "DateTime":
                            if (arrayList[i].ToString().Trim().ToUpper().Contains("_FROM"))
                            {
                                sqlStr += " and " + arrayList[i].ToString().Replace(":", "").Replace("_FROM", "") + ">= '" + sp.GetValue(arrayList[i].ToString()) + "'";
                            }
                            else if (arrayList[i].ToString().Trim().ToUpper().Contains("_TO"))
                            {
                                sqlStr += " and " + arrayList[i].ToString().Replace(":", "").Replace("_TO", "") + "<= '" + sp.GetValue(arrayList[i].ToString()) + "'";
                            }
                            break;
                        default:
                            sqlStr += " and " + arrayList[i].ToString().Replace(":", "") + " like '" + sp.GetValue(arrayList[i].ToString()) + "'";
                            break;
                    }
                }
            }

            sqlCommand.CommandText = sqlStr;

            GetDataTable(sqlCommand, dt);

            return dt;
        }

        public DataTable GetTableByDiyCondition(string sqlStr, SearchParameter sp)
        {
            dt = new DataTable();
            ArrayList arrayList = sp.Keys();
            SqlCommand sqlCommand = new SqlCommand();

            for (int i = 0; i < arrayList.Count; i++)
            {

                sqlStr = sqlStr.Replace(arrayList[i].ToString(), sp.GetValue(arrayList[i].ToString()).ToString());
            }

            sqlCommand.CommandText = sqlStr;

            GetDataTable(sqlCommand, dt);

            return dt;
        }

        public int DeleteRow(string tableName, SearchParameter sp)
        {

            string SqlStr = "";
            SqlStr = "DELETE  FROM " + tableName;

            ArrayList arrayList = sp.Keys();

            SqlCommand sqlCommand = new SqlCommand();

            for (int i = 0; i < arrayList.Count; i++)
            {
                if (i == 0)
                {
                    switch (sp.GetHashTable[arrayList[i]].GetType().Name)
                    {
                        case "String":
                            SqlStr += " where " + arrayList[i].ToString().Replace(":", "") + " like '" + sp.GetValue(arrayList[i].ToString()) + "'";
                            break;
                        case "Int32":
                            SqlStr += " where " + arrayList[i].ToString().Replace(":", "") + "= " + sp.GetValue(arrayList[i].ToString()) + "";
                            break;
                        default:
                            SqlStr += " where " + arrayList[i].ToString().Replace(":", "") + " = '%" + sp.GetValue(arrayList[i].ToString()) + "'";
                            break;
                    }

                }
                else
                {
                    switch (sp.GetHashTable[arrayList[i]].GetType().Name)
                    {
                        case "String":
                            SqlStr += " and " + arrayList[i].ToString().Replace(":", "") + " like '" + sp.GetValue(arrayList[i].ToString()) + "'";
                            break;
                        case "Int32":
                            SqlStr += " and " + arrayList[i].ToString().Replace(":", "") + " = " + sp.GetValue(arrayList[i].ToString()) + "";
                            break;
                        default:
                            SqlStr += " and " + arrayList[i].ToString().Replace(":", "") + " = '" + sp.GetValue(arrayList[i].ToString()) + "'";
                            break;
                    }
                }
            }

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

        private void ExcuteSql(SqlCommand command)
        {

            command.Connection = connection;
            if (transaction != null)
            {
                command.Transaction = transaction;
            }
            command.ExecuteNonQuery();


        }

        public bool InsertIsOnly(string tableName, string columnName, string value)
        {

            dt = new DataTable();
            string SqlStr = "SELECT * FROM " + tableName + " where " + columnName + "='" + value.Trim() + "'";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SqlStr;
            GetDataTable(sqlCommand, dt);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            return false;


        }

        public bool InsertIsOnly(string tableName, string columnName, int value)
        {

            dt = new DataTable();
            string SqlStr = "SELECT * FROM " + tableName + " where " + columnName + "=" + value.ToString().Trim() + "";
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SqlStr;
            GetDataTable(sqlCommand, dt);
            if (dt.Rows.Count > 0)
            {
                return true;
            }

            return false;


        }

        public bool UpdateIsOnly(string tableName, string pkName, string pkValue, string columnName, string value)
        {

            dt = new DataTable();
            string SqlStr = string.Empty;

            SqlStr = "SELECT * FROM " + tableName + " where " + columnName + "='" + value.ToString().Trim() + "'";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SqlStr;
            GetDataTable(sqlCommand, dt);
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0][pkName].ToString().Equals(pkValue))
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }

            return false;


        }

        public bool UpdateIsOnly(string tableName, string pkName, string pkValue, string columnName, int value)
        {

            dt = new DataTable();
            string SqlStr = string.Empty;

            SqlStr = "SELECT * FROM " + tableName + " where " + columnName + "=" + value.ToString().Trim() + "";

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = SqlStr;
            GetDataTable(sqlCommand, dt);
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0][pkName].ToString().Equals(pkValue.ToString()))
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }

            return false;


        }
    }
}
