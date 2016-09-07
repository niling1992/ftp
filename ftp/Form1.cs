using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace ftp
{
    public partial class Form1 : Form
    {
        bool isAttExisted = false;
        string attachment;
        public Form1()
        {
            InitializeComponent();
        }

        private void Download(string filePath, string fileSrc, string fileName, string ftpServerIP, string ftpUserName, string ftpPwd)
        {
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
            using (FileStream OutputStream = new FileStream(filePath + "\\" + fileName, FileMode.Create))
            {
                FtpWebRequest ReqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpServerIP + "/" + fileSrc));

                ReqFTP.Method = WebRequestMethods.Ftp.DownloadFile;

                ReqFTP.UseBinary = true;

                ReqFTP.Credentials = new NetworkCredential(ftpUserName, ftpPwd);

                using (FtpWebResponse response = (FtpWebResponse)ReqFTP.GetResponse())
                {

                    using (Stream FtpStream = response.GetResponseStream())
                    {

                        long Cl = response.ContentLength;

                        int bufferSize = 2048;

                        int readCount;

                        byte[] buffer = new byte[bufferSize];

                        readCount = FtpStream.Read(buffer, 0, bufferSize);

                        while (readCount > 0)
                        {
                            OutputStream.Write(buffer, 0, readCount);

                            readCount = FtpStream.Read(buffer, 0, bufferSize);
                        }

                        FtpStream.Close();
                    }

                    response.Close();

                }

                OutputStream.Close();
            }

        }
        private void UploadSmall(string sFileDstPath, string FolderName, string ftpServerIP, string ftpUserName, string ftpPwd)
        {

            FileInfo fileInf = new FileInfo(sFileDstPath);

            FtpWebRequest reqFTP;

            reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri("ftp://" + ftpServerIP + "/" + FolderName + "/" + fileInf.Name));

            reqFTP.Credentials = new NetworkCredential(ftpUserName, ftpPwd);

            reqFTP.KeepAlive = false;

            reqFTP.Method = WebRequestMethods.Ftp.UploadFile;

            reqFTP.UseBinary = true;

            reqFTP.ContentLength = fileInf.Length;

            int buffLength = 2048;

            byte[] buff = new byte[buffLength];

            int contentLen;

            using (FileStream fs = fileInf.OpenRead())
            {

                using (Stream strm = reqFTP.GetRequestStream())
                {

                    contentLen = fs.Read(buff, 0, buffLength);

                    while (contentLen != 0)
                    {

                        strm.Write(buff, 0, contentLen);

                        contentLen = fs.Read(buff, 0, buffLength);
                    }

                    strm.Close();
                }

                fs.Close();
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw;
            string sub = textBox_title.Text;
            string filename = sub + ".txt";
            string content = textBox_content.Text;
            if (!File.Exists(filename))
            {
                //不存在就新建一个文本文件,并写入一些内容
                sw = File.CreateText(filename);
                sw.Write(content);
            }
            else
            {
                //如果存在就添加一些文本内容
                sw = File.AppendText(filename);
                sw.Write(content);
            }
            sw.Close();
            UploadSmall(".\\" + filename, "UPLOAD", "210.21.48.7:2312", "FSYMSXT", "FSYMSXT");
            if (isAttExisted)
                UploadSmall(attachment, "UPLOAD", "210.21.48.7:2312", "FSYMSXT", "FSYMSXT");
            MessageBox.Show("提交成功，谢谢您的意见反馈！");
        }

        private void button_attachment_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                isAttExisted = true;
                attachment = openFileDialog1.FileName;
                textBox_attachment.Text = attachment;
            }
            else
                return;
        }
        
    }
}
