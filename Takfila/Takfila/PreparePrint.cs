using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace Takfila
{
    public partial class PreparePrint : Form
    {
        public PreparePrint()
        {
            InitializeComponent();
        }

        private void PPD_Load(object sender, EventArgs e)
        {
           
        }

        private void PreparePrint_Load(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Get a FileInfo object for the file that will
            // be uploaded.
         if(txtFile.Text !="" || txtFile.Text!=string.Empty)
         {
            string s = this.txtFile.Text;
            //s = "تقفيلة فرع الدوار شهر 1 سنة 2014" + s.Substring(s.LastIndexOf("."));
            FileInfo toUpload = new FileInfo(s);
            FileInfo toUpload1 = new FileInfo(this.txtFile.Text);


            // Substring(FileUpload1.FileName.LastIndexOf(".")));
            //string s = " my name . ibrahim";
            //s.IndexOf(".");
            //s.Substring(
            //Get a new FtpWebRequest object.
            FtpWebRequest request =
                (FtpWebRequest)WebRequest.Create(this.txtAddress.Text + "/" + toUpload.Name);

            //Method will be UploadFile.
            request.Method = WebRequestMethods.Ftp.UploadFile;

            //Set our credentials.
            request.Credentials = new NetworkCredential(this.txtUserName.Text, this.txtPassword.Text);

            //Setup a stream for the request and a stream for
            // the file we'll be uploading.
            Stream ftpStream = request.GetRequestStream();
            FileStream file = File.OpenRead(this.txtFile.Text);


            //Setup variables we'll use to read the file.
            int length = 1024;
            byte[] buffer = new byte[length];
            int bytesRead = 0;

            //Write the file to the request stream.
            do
            {
                bytesRead = file.Read(buffer, 0, length);
                ftpStream.Write(buffer, 0, bytesRead);
            }
            while (bytesRead != 0);

            //Close the streams.
            file.Close();
            ftpStream.Close();

            MessageBox.Show("تم التحميل بنجاح"); 
         }
         else
             MessageBox.Show("من فضلك اختار الملف المضغوط"); 
        }

        private void btnPickFile_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPickFile_Click_1(object sender, EventArgs e)
        {
            DialogResult result = fileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.txtFile.Text = fileDialog.FileName;
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = this.txtFile.Text;
            s = "تقفيلة فؤع الدو" + s.Substring(s.LastIndexOf("."));
            MessageBox.Show(s);
        }

       
    }
}
