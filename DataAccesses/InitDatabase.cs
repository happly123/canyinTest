using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Collections;
using System.IO;
using System.Data;
using System.Configuration;

namespace DataAccesses
{
    public class InitDatabase
    {
        public static int createdb(string path, string pathinit)
        {
            string strConn = string.Empty;
            strConn = "Data Source=" + ConfigurationManager.AppSettings["Source"].ToString() + ";"
                        + "Initial Catalog=master;";
            if (ConfigurationManager.AppSettings["UserID"].ToString() != string.Empty)
            {
                strConn += "User ID=" + ConfigurationManager.AppSettings["UserID"].ToString() + ";"
                    + "Password=" + ConfigurationManager.AppSettings["PassWord"].ToString() + ";"
                    + "Connect Timeout=30";
            }
            else
            {

                strConn += "trusted_connection=sspi;Connect Timeout=30";
            }

            SqlConnection conn = new SqlConnection(strConn);

            SqlCommand createDatabase = new SqlCommand();
            createDatabase.Connection = conn;
            createDatabase.CommandText = "select filename from sysfiles";
            try
            {
                conn.Open();
                string dataBaceFileName = createDatabase.ExecuteScalar().ToString();

                if (dataBaceFileName.Equals(string.Empty))
                {
                    conn.Close();
                    return -1;
                }

                String str;
                str = "CREATE DATABASE tc_invoicing ON PRIMARY " +
                "(NAME = tc_invoicing_Data, " +
                "FILENAME = '" + dataBaceFileName.Substring(0, dataBaceFileName.LastIndexOf('\\') + 1) + "tc_invoicing.mdf', " +
                "SIZE = 3MB, MAXSIZE = 2048MB, FILEGROWTH = 10%) " +
                "LOG ON (NAME = tc_invoicing_Log, " +
                "FILENAME = '" + dataBaceFileName.Substring(0, dataBaceFileName.LastIndexOf('\\') + 1) + "tc_invoicing.ldf', " +
                "SIZE = 1MB, " +
                "MAXSIZE = 2048MB, " +
                "FILEGROWTH = 10%)";
                createDatabase = new SqlCommand();
                SqlCommand createTable = new SqlCommand();
                createDatabase.Connection = conn;
                createDatabase.CommandText = str;

                ArrayList List1 = ExecuteSqlFile(path);
                string teststr;


                createDatabase.ExecuteNonQuery();

                createTable.Connection = conn;
                foreach (string varcommandText in List1)
                {
                    teststr = varcommandText;             //遍历并符值;
                    //Response.Write(teststr + "|@|<br>");
                    createTable.CommandText = teststr;            //为SqlCommand赋Sql语句;
                    createTable.ExecuteNonQuery();                //执行
                }

                ArrayList List2 = InitDatabase.ExecuteSqlFile2(pathinit);

                foreach (string varcommandText in List2)
                {
                    teststr = varcommandText;             //遍历并符值;
                    //Response.Write(teststr + "|@|<br>");
                    createTable.CommandText = teststr;            //为SqlCommand赋Sql语句;
                    createTable.ExecuteNonQuery();                //执行
                }
                return 0;
            }
            catch (System.Exception ex)
            {
                return -1;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

        }
        public static ArrayList ExecuteSqlFile(string varFileName)
        {
            //
            // TODO:读取.sql脚本文件
            //
            StreamReader sr = File.OpenText(varFileName);//传入的是文件路径及完整的文件名
            ArrayList alSql = new ArrayList();           //每读取一条语名存入ArrayList
            string commandText = "";
            string varLine = "";
            while (sr.Peek() > -1)
            {
                varLine = sr.ReadLine();
                if (varLine == "")
                {
                    continue;
                }
                if (varLine != "GO")
                {
                    commandText += varLine;
                    commandText += " ";
                }
                else
                {
                    alSql.Add(commandText);
                    commandText = "";
                }
            }
            alSql.Add(commandText);
            sr.Close();
            return alSql;
        }
        public static ArrayList ExecuteSqlFile2(string varFileName)
        {
            StreamReader sr = File.OpenText(varFileName);//传入的是文件路径及完整的文件名
            ArrayList alSql = new ArrayList();           //每读取一条语名存入ArrayList

            string varLine = "";
            while (sr.Peek() > -1)
            {
                varLine = sr.ReadLine();
                if (varLine == "")
                {
                    continue;
                }
                if (varLine == "GO")
                {
                    continue;
                }
                else
                {
                    alSql.Add(varLine);

                }
            }

            sr.Close();
            return alSql;
        }

    }
}

