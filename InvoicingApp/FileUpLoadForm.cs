using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataAccesses;
using System.Data.SqlClient;
using InvoicingUtil;
using System.IO;
using InvoicingApp.FileService;
using System.Xml;
using System.ServiceModel;
using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib.Checksums;
using System.Threading;
using System.Configuration;
namespace InvoicingApp
{
    public partial class FileUpLoadForm : Form
    {
        FileTransportServiceClient fileTransportServiceClient;
        Stream stream;
        string file = "";
        EntityUpload entityUpload;
        bool uploadSuccess = true;

        public FileUpLoadForm()
        {
            InitializeComponent();
        }

        private void btnSetAddress_Click(object sender, EventArgs e)
        {
            
            XmlDocument doc = new XmlDocument();
            doc.Load(Application.StartupPath + "\\InvoicingApp.exe.config");
            XmlNode node = doc.SelectSingleNode("configuration/system.serviceModel/client/endpoint");
            node.Attributes["address"].Value = "http://"
                                                + txtAddress1.Text
                                                + "." + txtAddress2.Text
                                                + "." + txtAddress3.Text
                                                + "." + txtAddress4.Text
                                                + "" + ":80/FileUpLoad/";
            doc.Save(Application.StartupPath + "\\InvoicingApp.exe.config");
            labAddress.Text = txtAddress1.Text
                            + "." + txtAddress2.Text
                            + "." + txtAddress3.Text
                            + "." + txtAddress4.Text;

            MessageBox.Show("服务器地址修改成功！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FileUpLoadForm_Load(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(Application.StartupPath + "\\InvoicingApp.exe.config");
            XmlNode node = doc.SelectSingleNode("configuration/system.serviceModel/client/endpoint");
            string address = node.Attributes["address"].Value.Replace("http://", "");
            labAddress.Text = address.Substring(0, address.LastIndexOf(':'));
            txtAddress1.Text = labAddress.Text.Split('.')[0];
            txtAddress2.Text = labAddress.Text.Split('.')[1];
            txtAddress3.Text = labAddress.Text.Split('.')[2];
            txtAddress4.Text = labAddress.Text.Split('.')[3];
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(298, 220);
            btnSend.Enabled = false;
            btnSetAddress.Enabled = false;
            proBar.Value = 0;
            labTarg.Visible = true;
            proBar.Visible = true;

            //将一方法加入线程中 
            Thread tdProc = new Thread(new ThreadStart(FileUpload));

            //开始线程
            tdProc.Start();

            //进度条的线程

            Thread tdProcBar = new Thread(new ThreadStart(CheckOver));

            tdProcBar.Start();

        }

        private void FileUpload()
        {
            Setlabel("正在压缩数据...");
            DataAccess dataAccess = new DataAccess();
            dataAccess.Open();

            GetData getData = new GetData(dataAccess.Connection);
            DataTable dtCompany = getData.GetSingleTable("tc_company");
            if (dtCompany == null || dtCompany.Rows.Count == 0)
            {
                SetformSize(new System.Drawing.Size(298, 170));
                SetprocBar(proBar);
                SetlabelVisible(labTarg);
                MessageBox.Show("先填写公司信息后才可以数据申报！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string companyName = dtCompany.Rows[0]["company_name"].ToString();
            string businessLis = dtCompany.Rows[0]["company_business_licence"].ToString();
            dataAccess.Open();
            SqlCommand cmdBK = new SqlCommand();
            cmdBK.CommandType = CommandType.Text;
            cmdBK.Connection = dataAccess.Connection;
            if (!File.Exists(LoginUser.SqlSetUpPath.Substring(0, LoginUser.SqlSetUpPath.Length - 1)))
            {

                Directory.CreateDirectory(LoginUser.SqlSetUpPath.Substring(0, LoginUser.SqlSetUpPath.Length - 1));
            }

            DateTime dateNow = DateTime.Now;
            file = LoginUser.SqlSetUpPath + companyName + "_" + businessLis;
            cmdBK.CommandText = "backup database tc_invoicing to disk='" + file + "' with init";
            cmdBK.ExecuteNonQuery();

            //dataAccess.Close();
            try
            {

                //压缩
                ZipOutputStream output = new ZipOutputStream(File.Create(file + ".dat"));
                output.SetLevel(5);
                Crc32 crc = new Crc32();
                FileStream fsR = new FileStream(file, FileMode.Open, FileAccess.Read);
                byte[] bt = new byte[fsR.Length];
                fsR.Read(bt, 0, bt.Length);
                //存储要压缩的文件
                ZipEntry entry = new ZipEntry(file.Substring(file.LastIndexOf('\\') + 1));
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

                stream = this.TransferDocument(file + ".dat");
                long maxTransBuffer = long.Parse(ConfigurationSettings.AppSettings["maxTransBuffer"]);
                if (stream.Length > maxTransBuffer)
                {
                    SetformSize(new System.Drawing.Size(298, 170));
                    SetprocBar(proBar);
                    SetlabelVisible(labTarg);
                    MessageBox.Show("数据文件过大，无法上传！最大数据量为：5M。", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                fileTransportServiceClient = new FileTransportServiceClient();
                fileTransportServiceClient.ChannelFactory.Endpoint.Address = new EndpointAddress("http://" + labAddress.Text.Trim() + ":80/FileUpLoad/");
                Setlabel("正在连接服务器...");
                fileTransportServiceClient.Open();
                Setlabel("上传数据中，请稍候...");
                fileTransportServiceClient.UploadFile(file.Substring(file.LastIndexOf('\\') + 1) + ".dat", stream);

                SetprocBar(proBar);
                SetlabelVisible(labTarg);
                MessageBox.Show("数据上传成功！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                uploadSuccess = true;
                Setbtn(btnSend, btnSetAddress);
                SetformSize(new System.Drawing.Size(298, 170));
            }
            catch (CommunicationException commEx)
            {
                SetformSize(new System.Drawing.Size(298, 170));
                SetprocBar(proBar);
                SetlabelVisible(labTarg);
                MessageBox.Show("上传失败：远程服务器无法连接，请查看服务器地址是否正确或服务器是否开启！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                uploadSuccess = false;
                Setbtn(btnSend, btnSetAddress);
            }
            catch (System.TimeoutException timeEx)
            {
                SetformSize(new System.Drawing.Size(298, 170));
                SetprocBar(proBar);
                SetlabelVisible(labTarg);
                MessageBox.Show("连接人数过多，请等待5分钟后再次申报！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                uploadSuccess = false;
                Setbtn(btnSend, btnSetAddress);
            }
            catch (Exception ex)
            {
                SetformSize(new System.Drawing.Size(298, 170));
                SetprocBar(proBar);
                SetlabelVisible(labTarg);
                MessageBox.Show("上传失败：" + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                uploadSuccess = false;
                Setbtn(btnSend, btnSetAddress);
            }
            finally
            {
                Setbtn(btnSend, btnSetAddress);
                if (stream != null)
                {
                    stream.Close();
                    stream.Dispose();
                    stream = null;
                }

                if (File.Exists(file))
                {
                    File.Delete(file);
                }
                if (File.Exists(file + ".dat"))
                {
                    File.Delete(file + ".dat");
                }

                if (fileTransportServiceClient != null && fileTransportServiceClient.State == CommunicationState.Opened)
                {
                    fileTransportServiceClient.Close();
                    fileTransportServiceClient = null;
                }

                if (uploadSuccess)
                {
                    entityUpload = new EntityUpload();
                    entityUpload.Upload_date = dateNow;
                    entityUpload.Upload_result = "上传成功";
                    entityUpload.Upload_ip = txtAddress1.Text.Trim()
                                            + "." + txtAddress2.Text.Trim()
                                            + "." + txtAddress3.Text.Trim()
                                            + "." + txtAddress4.Text.Trim();
                    getData = new GetData(dataAccess.Connection, dataAccess.Transaction);
                    int result = getData.InsertUploadRow(entityUpload);
                }
                else
                {
                    entityUpload = new EntityUpload();
                    entityUpload.Upload_date = dateNow;
                    entityUpload.Upload_result = "上传失败";
                    entityUpload.Upload_ip = txtAddress1.Text.Trim()
                                            + "." + txtAddress2.Text.Trim()
                                            + "." + txtAddress3.Text.Trim()
                                            + "." + txtAddress4.Text.Trim();
                    getData = new GetData(dataAccess.Connection, dataAccess.Transaction);
                    int result = getData.InsertUploadRow(entityUpload);

                }

                if (dataAccess != null && dataAccess.Connection != null)
                {
                    dataAccess.Close();
                }
            }

            Setbtn(btnSend, btnSetAddress);

        }

        private Stream TransferDocument(string filePath)
        {
            FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);

            return stream;
        }

        private void txt_Leave(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请输入0～255之间的整数！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (int.Parse(txt.Text.Trim()) > 255)
            {
                MessageBox.Show("请输入0～255之间的整数！", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt.Focus();
            }
        }

        private delegate void SetProc(ProgressBar pb, int step);

        private delegate void SetBtn(Button button, Button button2);

        private delegate void SetProBar(ProgressBar procgerssBar);

        private delegate void SetLabel(string text);

        private delegate void SetLabelVisable(Label lb);

        private delegate void SetFormSize(Size size);

        private void SetProcBar(ProgressBar pb, int step)
        {

            if (pb.InvokeRequired)
            {
                SetProc setProc = new SetProc(SetProcBar);
                pb.Invoke(setProc, pb, step);
            }
            else
            {
                if ((pb.Value + step) > pb.Maximum)
                {
                    pb.Value = 0;
                    pb.Value += step;
                }
                else
                {
                    pb.Value += step;
                }
            }
        }

        private void Setbtn(Button button1, Button button2)
        {
            if (button1.InvokeRequired && button2.InvokeRequired)
            {
                button1.Invoke(new SetBtn(Setbtn), button1, button2);
            }
            else
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }
        }

        private void SetprocBar(ProgressBar pb)
        {
            if (pb.InvokeRequired)
            {
                pb.Invoke(new SetProBar(SetprocBar), proBar);
            }
            else
            {
                pb.Value = 0;
                pb.Visible = false;
            }
        }

        private void Setlabel(string text)
        {
            if (labTarg.InvokeRequired)
            {
                labTarg.Invoke(new SetLabel(Setlabel), text);
            }
            else
            {
                labTarg.Text = text;
            }
        }

        private void SetlabelVisible(Label lb)
        {
            if (lb.InvokeRequired)
            {
                lb.Invoke(new SetLabelVisable(SetlabelVisible), lb);
            }
            else
            {
                lb.Visible = false;
            }
        }

        private void SetformSize(Size size)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new SetFormSize(SetformSize), size);
            }
            else
            {
                this.Size = size;
            }
        }

        private void CheckOver()
        {

            //空的时候一直走进度条
            while (btnSend.Enabled == false)
            {

                //让进度条走慢点
                Thread.Sleep(10);

                //加1的走，默认长度为100
                SetProcBar(proBar, 1);
                //MessageBox.Show("this");
            }

        }

    }
}
