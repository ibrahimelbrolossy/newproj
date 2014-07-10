using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
namespace Takfila
{
    public partial class Sader_Bank : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["taKConn"].ConnectionString);
        SqlCeConnection con = new SqlCeConnection(@"Data Source= |DataDirectory|\Mylocaldatabase.sdf");
        Takfila.Classes.DbWork db = new Classes.DbWork();
        public Sader_Bank()
        {
            InitializeComponent();
        }
        public void Fill_branch()
        {
            DataTable tbl = new DataTable();
            tbl = db.Ce_runquery("select code,branch from branch");
            branch.DataSource = tbl;
            branch.DisplayMember = tbl.Columns[1].ToString();
            branch.ValueMember = tbl.Columns[0].ToString();

        }
        public void Fill_bank1()
        {
            DataTable tbl = new DataTable();
            tbl = db.Ce_runquery("select kh_s,kh_no from s_kind");
            s_b1_name.DataSource = tbl;
            s_b1_name.DisplayMember = tbl.Columns[1].ToString();
            s_b1_name.ValueMember = tbl.Columns[0].ToString();
        }
        public void Fill_bank2()
        {
            DataTable tbl = new DataTable();
            tbl = db.Ce_runquery("select kh_s,kh_no from s_kind");
          
            s_b2_name.DataSource = tbl;
            s_b2_name.DisplayMember = tbl.Columns[1].ToString();
            s_b2_name.ValueMember = tbl.Columns[0].ToString();
        }
        public void Fill_bank3()
        {
            DataTable tbl = new DataTable();
            tbl = db.Ce_runquery("select kh_s,kh_no from s_kind");
            s_b3_name.DataSource = tbl;
            s_b3_name.DisplayMember = tbl.Columns[1].ToString();
            s_b3_name.ValueMember = tbl.Columns[0].ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Sader_Bank_Load(object sender, EventArgs e)
        {
            db.fill_branch(branch);
            branch.SelectedIndex = -1;
            Fill_bank1();
            Fill_bank2();
            Fill_bank3();
            s_b1_name.SelectedIndex = -1;
            s_b2_name.SelectedIndex = -1;
            s_b3_name.SelectedIndex = -1;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            branch.SelectedIndex = br_cbo().SelectedIndex;
            s_month.Value = mm();
            s_year.Value = yy();
            
            insert_ce_local();
            SqlCommand cmd1 = new SqlCommand("spInsertSader", conn);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@branch ", branch.SelectedValue);
            cmd1.Parameters.AddWithValue("@s_month", s_month.Text);
            cmd1.Parameters.AddWithValue("@s_year", s_year.Text);
            cmd1.Parameters.AddWithValue("@s_bank1", s_bank1.Text);
            cmd1.Parameters.AddWithValue("@S_b1_name", s_b1_name.SelectedValue);
            cmd1.Parameters.AddWithValue("@s_bank2", s_bank2.Text);
            cmd1.Parameters.AddWithValue("@S_b2_name", s_b2_name.SelectedValue);
            cmd1.Parameters.AddWithValue("@s_bank3", s_bank3.Text);
            cmd1.Parameters.AddWithValue("@S_b3_name", s_b3_name.SelectedValue);
            cmd1.Parameters.AddWithValue("@S_eatman", s_eatman.Text);
            cmd1.Parameters.AddWithValue("@memo", memo.Text);
            this.Cursor = Cursors.WaitCursor;
            decimal x = Convert.ToDecimal(s_bank1.Text);

            try
            {
                if (x == 0 || s_eatman.Text == "0")
                {
                    MessageBox.Show("يجب ادخال القيمة");
                    this.Cursor = Cursors.Default;
                }
                else
                {
                    if (branch.SelectedIndex != -1 || s_b1_name.SelectedIndex != -1 || br_cbo().SelectedIndex != -1)
                    {
                        DataTable tbl = new DataTable();
                        tbl = db.runquery("select branch,s_month,s_year from sader_b_e where branch='" + branch.SelectedValue + "' and s_month='" + s_month.Text + "' and s_year='" + s_year.Text + "' ");
                        if (tbl.Rows.Count == 1)
                            MessageBox.Show("تم تسجيل الصادر من قبل");
                        else
                        {
                            try
                            {
                                if (CheckForInternetConnection())
                                {
                                    conn.Open();
                                    cmd1.ExecuteNonQuery();
                                    MessageBox.Show("تم التسجيل");
                                    conn.Close();
                                    this.Cursor = Cursors.Default;
                                }
                                else
                                {
                                    this.Cursor = Cursors.Default;
                                    MessageBox.Show("لا يوجد اتصال بالانترنت ولن تسجل البيانات اون لاين");
                                }
                            }
                            catch (SqlException)
                            {
                                MessageBox.Show("تأكد من اختيار فرع وبنك واحد على الأقل");
                                conn.Close();
                            }
                        }
                    }
                    else
                        MessageBox.Show("تأكد من اختيار فرع وبنك واحد على الأقل");
                }


            }
            catch (Exception)
            {
                MessageBox.Show("لم يتم التسجيل يرجى مراجعة البيانات");
            }


            this.Cursor = Cursors.Default;     
         }
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
        private void insert_ce_local()
        {
             SqlCeCommand cmd1 = new SqlCeCommand("INSERT INTO Sader_B_E ([branch],[s_month] ,[s_year] ,[S_bank1] ,[s_b1_name],[S_bank2],[s_b2_name] ,[S_bank3],[s_b3_name],[S_eatman],[memo],[b1name],[b2nam3],[b3name]) VALUES  (@branch,@s_month,@s_year,@S_bank1,@s_b1_name,@S_bank2,@s_b2_name,@S_bank3,@s_b3_name ,@S_eatman,@memo,@b1,@b2,@b3)", db.con);
             cmd1.Parameters.AddWithValue("@branch", branch.SelectedValue);
             cmd1.Parameters.AddWithValue("@s_month", s_month.Text);
             cmd1.Parameters.AddWithValue("@s_year", s_year.Text);
             cmd1.Parameters.AddWithValue("@s_bank1", s_bank1.Text);
             cmd1.Parameters.AddWithValue("@S_b1_name", s_b1_name.SelectedValue ?? DBNull.Value);
             cmd1.Parameters.AddWithValue("@s_bank2", s_bank2.Text ?? DBNull.Value.ToString());
             cmd1.Parameters.AddWithValue("@S_b2_name", s_b2_name.SelectedValue ?? DBNull.Value);
             cmd1.Parameters.AddWithValue("@s_bank3", s_bank3.Text ?? DBNull.Value.ToString());
             cmd1.Parameters.AddWithValue("@S_b3_name", s_b3_name.SelectedValue ?? DBNull.Value);
             cmd1.Parameters.AddWithValue("@S_eatman", s_eatman.Text);
             cmd1.Parameters.AddWithValue("@memo", memo.Text ?? DBNull.Value.ToString());
             cmd1.Parameters.AddWithValue("@b1", this.s_b1_name.GetItemText(this.s_b1_name.SelectedItem) ?? DBNull.Value.ToString());
             cmd1.Parameters.AddWithValue("@b2", this.s_b2_name.GetItemText(this.s_b2_name.SelectedItem) ?? DBNull.Value.ToString());
             cmd1.Parameters.AddWithValue("@b3", this.s_b3_name.GetItemText(this.s_b3_name.SelectedItem) ?? DBNull.Value.ToString());
             decimal x = Convert.ToDecimal(s_bank1.Text);
             if (x == 0 || s_eatman.Text == "0")
                 MessageBox.Show("يجب ادخال القيمة");
             else
             {
                 if (branch.SelectedIndex != -1 || s_b1_name.SelectedIndex != -1)
                 {
                     DataTable tbl = new DataTable();
                     tbl = db.Ce_runquery("select branch,s_month,s_year from sader_b_e where branch='" + branch.SelectedValue + "' and s_month='" + s_month.Text + "' and s_year='" + s_year.Text + "' ");
                     if (tbl.Rows.Count == 1)
                        
                         MessageBox.Show("تم تسجيل الصادر من قبل");
                     else
                     {
                         try
                         {
                             db.con.Open();
                             cmd1.ExecuteNonQuery();
                             db.con.Close();
                             MessageBox.Show("انتظر قليلا لتسجيل البيانات اون لاين");
                         }
                         catch (SqlCeException ex)
                         {
                             MessageBox.Show(ex.Message);

                             //MessageBox.Show("تأكد من اختيار فرع وبنك واجد على الأقل");
                             db.con.Close();
                         }
                     }
                 }
                 else
                     MessageBox.Show("تأكد من اختيار فرع وبنك واجد على الأقل");
             }
        }

        private void s_bank1_Validating(object sender, CancelEventArgs e)
        {
            string Str = s_bank1.Text.Trim();
            double Num;
            bool isNum = double.TryParse(Str, out Num);
            if (s_bank1.Text == "" || isNum == false || Convert.ToDecimal(s_bank1.Text) <= 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(s_bank1, "يجب ادخال قيمة صحيحة");
                return;
            }
            else
            {
                //btnSaveOrder.Enabled = true; 
                errorProvider1.SetError(s_bank1, "");
            }
        }

        private void s_bank2_Validating(object sender, CancelEventArgs e)
        {
            string Str = s_bank2.Text.Trim();
            double Num;
            bool isNum = double.TryParse(Str, out Num);
            if (s_b2_name.SelectedIndex != -1)
            {
                if (s_bank2.Text == "" || isNum == false || Convert.ToDecimal(s_bank2.Text) <= 0)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(s_bank2, "يجب ادخال قيمة صحيحة");
                    return;
                }
                else
                {
                    //btnSaveOrder.Enabled = true; 
                    errorProvider1.SetError(s_bank2, "");
                }
            }
        }

        private void s_bank3_Validating(object sender, CancelEventArgs e)
        {
            string Str = s_bank3.Text.Trim();
            double Num;
            bool isNum = double.TryParse(Str, out Num);
            if (s_b3_name.SelectedIndex != -1)
            {
                if (s_bank3.Text == "" || isNum == false || Convert.ToDecimal(s_bank3.Text) <= 0)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(s_bank3, "يجب ادخال قيمة صحيحة");
                    return;
                }
                else
                {
                    //btnSaveOrder.Enabled = true; 
                    errorProvider1.SetError(s_bank3, "");
                }
            }
        }

        private void branch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void s_bank1_Leave(object sender, EventArgs e)
        {
            String Text = ((TextBox)sender).Text;
            double Num;

            if (double.TryParse(Text, out Num))
            {
                Text = String.Format("{0:0.000}", Num);
                ((TextBox)sender).Text = Text;
            }
            else
            {
                ((TextBox)sender).Text = "00.000";
            }
        }

        private ComboBox br_cbo()
        {
            ToolStrip brrr = (ToolStrip)this.ParentForm.Controls["ToolStrip1"];
            ToolStripComboBox brr = (ToolStripComboBox)brrr.Items["br_find"];
            ComboBox br = brr.ComboBox;
            if (br.SelectedIndex == -1)
                return null;
            else
                return br;
        }

        private int mm()
        {
            Main m = new Main();
            m = (Main)this.MdiParent;
            return (int)m.mon_find.Value;
        }

        private int yy()
        {
            Main m = null;
            m = (Main)this.MdiParent;
            return (int)m.year_find.Value;
        }


    }
}
