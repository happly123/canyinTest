using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO.Compression;
using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib.Checksums;

namespace DataExport
{
    public class Export
    {
        private DateTime dateFrom;
        private DateTime dateTo;
        private string strConn;
        private string path;
        private string fileName;
        private DateTime dateNow;
        /// <summary>
        /// 构造函数取得日期和数据库连接串
        /// </summary>
        /// <param name="from">开始日期</param>
        /// <param name="to">结束日期</param>
        /// <param name="connStr">数据库连接串</param>
        public Export(DateTime from, DateTime to, string connStr)
        {
            this.dateFrom = from.Date;
            this.dateTo = to.Date;
            this.strConn = connStr;
            dateNow = DateTime.Now.Date;
        }
        private string password = string.Empty;

        /// <summary>
        /// 设置导出密码
        /// </summary>
        public string PassWord
        {
            set { this.password = value; }
        }

        private bool compression = false;
        /// <summary>
        /// 是否压缩
        /// </summary>
        public bool Compression
        {
            set { this.compression = value; }
        }
        /// <summary>
        /// 输出数据文件,如果没设置Compression,默认不压缩，如果没设置Password，默认无密码
        /// </summary>
        /// <param name="directoryPath">输出目录</param>
        /// <param name="fileName">文件命名，不需要扩展名</param>
        public void XmlExport(string directoryPath, string fileName)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            path = directoryPath;
            this.fileName = fileName;
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = SqlStr.TC_INPUT_STORAGE_LEFTJOIN_GOODS + " WHERE INPUT_INSTORAGE_DATE>='" + dateFrom + "' AND INPUT_INSTORAGE_DATE<='" + dateTo + "';";
            cmd.CommandText += SqlStr.TC_OUTPUT_STORAGE_LEFTJOIN_TC_CUSTOMER_LEFTJOIN_TC_INPUT_STORAGE_LEFTJOIN_TC_GOODS_SELECT + "WHERE OUTPUT_INSTORAGE_DATE>='" + dateFrom + "' AND OUTPUT_INSTORAGE_DATE<='" + dateTo + "';";
            cmd.CommandText += SqlStr.TC_INPUT_STORAGE_LEFTJOIN_GOODS_SELECTRECORDVALIDATE + " WHERE TC_INPUT_STORAGE.INPUT_TYPE <> 0 AND TC_INPUT_STORAGE.INPUT_CHECKTIME >= '" + dateFrom + "'  "
                                + "AND TC_INPUT_STORAGE.INPUT_CHECKTIME <= '" + dateTo + "' ORDER BY TC_INPUT_STORAGE.INPUT_CHECKTIME DESC ;";
            cmd.CommandText += SqlStr.TC_APPARATUS_QUALITY_SELECT + " WHERE APPARATUS_REPORT_DATE>='" + dateFrom + "' AND APPARATUS_REPORT_DATE<='" + dateTo + "';";
            cmd.CommandText += SqlStr.TC_MAINTAIN_LEFTJOIN_TC_TC_INPUT_STORAGE_LEFTJOIN_TC_GOODS_LEFTJOIN_TC_MAKER + " WHERE MAINTAIN_CREATE_DATE>='" + dateFrom + "' AND MAINTAIN_CREATE_DATE<='" + dateTo + "';";
            cmd.CommandText += SqlStr.TC_MAINTAIN_DETAIL + ";";
            cmd.CommandText += " SELECT * FROM TC_COMPANY ;";
            cmd.Connection = conn;
            SqlDataAdapter dtAdapter = new SqlDataAdapter(cmd);
            DataSet dsTables = new DataSet();
            DataTable dtTime = new DataTable();
            dtTime.TableName = "Time";
            dtTime.Columns.Add("ExportDateFrom", typeof(string));
            dtTime.Columns.Add("ExportDateTo", typeof(string));
            dtTime.Columns.Add("ReportDate", typeof(string));
            DataRow drTime = dtTime.NewRow();
            drTime["ExportDateFrom"] = dateFrom.ToString("yyyy-MM-dd");
            drTime["ExportDateTo"] = dateTo.ToString("yyyy-MM-dd");
            drTime["ReportDate"] = dateNow.ToString("yyyy-MM-dd");
            dtTime.Rows.Add(drTime);
            try
            {
                conn.Open();
                dtAdapter.Fill(dsTables);
                dsTables.Tables[0].TableName = "InputStorage";
                dsTables.Tables[1].TableName = "OutputStorage";
                dsTables.Tables[2].TableName = "Check";
                dsTables.Tables[3].TableName = "Quality";
                dsTables.Tables[4].TableName = "Maintain";
                dsTables.Tables[5].TableName = "MaintainDetail";
                dsTables.Tables[6].TableName = "Company";
                dsTables.Tables.Add(dtTime);
                WriteXml(dsTables);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }

        /// <summary>
        /// 取得公司数据表信息
        /// </summary>
        /// <returns></returns>
        public DataTable GetCompanyInfo()
        {
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = " SELECT * FROM TC_COMPANY ;";
            cmd.Connection = conn;
            SqlDataAdapter dtAdapter = new SqlDataAdapter(cmd);
            try
            {
                DataTable dtCompany = null;
                conn.Open();
                dtAdapter.Fill(dtCompany);
                return dtCompany;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }

        /// <summary>
        /// 取得上报数据时间信息
        /// </summary>
        /// <returns>数组，0：开始日期；1：结束日期；2：上报日期</returns>
        public string[] GetDateInfo()
        {
            string[] dateTimeInfos = new string[3] { dateFrom.ToString("yyyy-MM-dd"), dateTo.ToString("yyyy-MM-dd"), dateNow.ToString("yyyy-MM-dd") };
            return dateTimeInfos;
        }

        private void WriteXml(DataSet ds)
        {
            //输出序列化文件
            IFormatter formatter = new BinaryFormatter();
            FileStream fs = File.Create(path + "\\" + fileName);
            formatter.Serialize(fs, ds);
            fs.Close();
            fs.Dispose();

            if (compression)
            {
                //压缩文件的流对象
                // MessageBox.Show(name);
                ZipOutputStream output = new ZipOutputStream(File.Create(path + "\\" + fileName + ".dat"));
                if (password.Trim() != string.Empty)
                {
                    output.Password = this.password;
                    
                }
                
                output.SetLevel(6);
                //存放文件数据
                Crc32 crc = new Crc32();
                FileStream fsR = new FileStream(path + "\\" + fileName, FileMode.Open, FileAccess.Read);
                byte[] bt = new byte[fsR.Length];
                fsR.Read(bt, 0, bt.Length);
                //存储要压缩的文件
                ZipEntry entry = new ZipEntry(fileName);
                entry.Size = fsR.Length;
                entry.DateTime = DateTime.Now;
                fsR.Close();
                crc.Reset();  //清除crc内容
                crc.Update(bt);  //更新文件内容到crc中
                entry.Crc = crc.Value;   //将文件内容放到压缩文件中
                output.PutNextEntry(entry);
                //将数据写入压缩流中
                output.Write(bt, 0, bt.Length);
                output.Close();

                File.Delete(path + "\\" + fileName);
            }

            //反序列化
            //FileStream fs1 = File.OpenRead(path + "\\" + fileName);
            //fs1.Position = 0;
            //DataSet dataSet = (DataSet)formatter.Deserialize(fs1);
        }


    }


}
