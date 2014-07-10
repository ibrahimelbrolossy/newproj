using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlServerCe;

namespace Takfila
{
    public partial class login : Form
    {
        public login()
        {
          
            InitializeComponent();
          
        }
        
        public int UType;
        public static string selectuser;
        bool bgc = false;
        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new System.Net.WebClient())
                using (var stream = client.OpenRead("http://www.google.com"))
                {
                    return true;
                   
                }
            }
            catch
            {
                return false;
            }
            
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            btn_login.Enabled = false;
            timer1.Enabled = true;
            backgroundWorker1.RunWorkerAsync();

        
        }

        #region MyRegion

        private void getuserdata()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["taKConn2"].ConnectionString);
            SqlCommand cmd = new SqlCommand("SELECT userid, tel3 FROM users where username=N'" + textBox1.Text + "' and [password]=N'" + textBox2.Text + "' ", conn);
            DataTable tbl = new DataTable();
           
            
            try
            {
                if (CheckForInternetConnection())
                {
                    
                    conn.Open();
                   
                    tbl.Load(cmd.ExecuteReader());
                    conn.Close();
                    Classes.DbWork db = new Classes.DbWork();
                    DataTable tb = new DataTable();
                    Program.b = "";
                    SqlCeCommand cmd1 ;
                    
                    switch (tbl.Rows[0][1].ToString())
                    {
                        case "6":
                            Program.a = "select code,branch from branch where auditor ='" + tbl.Rows[0][0] + "' ";
                            break;
                        case "5":
                            Program.a = "select code,branch from branch where f_aud ='" + tbl.Rows[0][0] + "' ";
                            break;
                        case "4":
                            Program.a = "select code,branch from branch where m_aud ='" + tbl.Rows[0][0] + "' ";
                            break;
                        
                    }

                            cmd1 = new SqlCeCommand(Program.a, db.con);
                            try
                            {
                                db.con.Open();
                                tb.Load(cmd1.ExecuteReader());
                                db.con.Close();
                                foreach (DataRow r in tb.Rows)
                                {
                                    Program.b += r[0].ToString();
                                    Program.b += ",";
                                }
                                Program.b = Program.b.Remove(Program.b.Length - 1);
                                
                            }
                            catch (Exception)
                            {
                                db.con.Close();
                            }


                    }

                    
                else
                {
                    this.Cursor = Cursors.Default;
                    MessageBox.Show("يجب ان تكون متصل بالانترنت");
                }
            }
            catch (Exception)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show("اسم المستخدم أو كلمة المرور غير صحيحية", "برنامج التقفيلة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                conn.Close();
            } 

            

        }

            #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_Load(object sender, EventArgs e)
        {
            //if (CheckForInternetConnection()==false)
            
            //    MessageBox.Show("يجب ان تكون متصل بالانترنت ");

           

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
                return;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            if (bgc)
            {
                timer1.Enabled = false;
                this.Close();
            }


            if (Convert.ToInt32(progressBar1.Value) == 99)
            {
                MessageBox.Show("فشل التحقق من البيانات"+ "\n"+"تأكد من الإتصال بالانترنت"+ "\n"+" وحاول مرة أخرى");
                Application.Exit();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (backgroundWorker1.CancellationPending)
                e.Cancel = true;
            
            getuserdata();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            bgc = true;
        }

        

        

       
    }
}
