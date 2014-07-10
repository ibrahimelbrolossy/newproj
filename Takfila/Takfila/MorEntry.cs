using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Takfila
{
    public partial class MorEntry : Form
    {
        public MorEntry()
        {
            InitializeComponent();
            new ToolTip().SetToolTip(pictureBox1, "السجل الأول");
            new ToolTip().SetToolTip(pictureBox2, "السجل الأخير");
            new ToolTip().SetToolTip(pictureBox3, "السجل السابق");
            new ToolTip().SetToolTip(pictureBox4, "السجل التالى");
            new ToolTip().SetToolTip(pictureBox5, "سجل جديد");
            new ToolTip().SetToolTip(pictureBox6, " حفـــظ");
            new ToolTip().SetToolTip(pictureBox7, " تعديل البيانات");
        }
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["taKConn"].ConnectionString);
        Takfila.Classes.DbWork db = new Classes.DbWork();
        Takfila.Mortad m = new Takfila.Mortad();
        private void ShowData()
        {
           branch.SelectedValue = m.Branch ;
           t_month.Text = m.Month.ToString();
           t_year.Text = m.Year.ToString();
           Fbalance.Text = m.First.ToString();
           q_cheq.Text= m.Q_cheq .ToString();
           n_cheq.Text= m.N_cheq .ToString();
           grama.Text = m.Grama.ToString();
           msaref.Text = m.Msaref.ToString();
           sdad.Text = m.Sdad.ToString();
           z_tah.Text = m.Z_tah.ToString();
           tawgeh_maden.Text = m.Tawgeh_maden.ToString();
           br1_madin.SelectedValue= m.Br1_madin ;
           br1_ksm.Text = m.Br1_ksm.ToString();
            //m.Br2_madin.ToString();
            //m.Br2_ksm.ToString();
           taw_m.Text = m.Taw_m.ToString();
           nakdy.Text = m.Nakdy.ToString();
           n_gra.Text = m.N_gra.ToString();
           mortag.Text = m.Mortag.ToString();
           gra_m.Text = m.Gra_m.ToString();
           gra_t.Text = m.Gra_t.ToString();
           gra_hq.Text = m.Gra_hq.ToString();
           gad_haly.Text = m.Gad_haly.ToString();
           gad_sabeq.Text = m.Gad_sabeq.ToString();
           tawgeh_daen.Text = m.Tawgeh_daen.ToString();
           eada.Text = m.Eada.ToString();
           morabha.Text = m.Morabha.ToString();
           br3_madin.SelectedValue= m.Br3_madin.ToString();
           br3_ksm.Text = m.Br3_ksm.ToString();
           // m.Br4_madin.ToString(); 
           //m. Br4_ksm .ToString();
           last.Text = m.Last.ToString();
           tas_madena.Text = m.Tas_madena.ToString();
           tas_madena_name.Text = m.Tas_madena_name as string;
           tas_daena.Text = m.Tas_daena.ToString();
           ta_da_na.Text = m.Ta_da_na as string;
           br1name.Text = m.Br1nmae as string;
           br2name.Text = m.Br2name as string;
           pos.TextAlign = HorizontalAlignment.Left;
           pos.Text = m.curuntposition();
        }
        private void loaddata()
        {
            m.Branch = Convert.ToInt32(branch.SelectedValue);
            m.Month = Convert.ToInt32(t_month.Text);
            m.Year = Convert.ToInt32(t_year.Text);
            m.First = Convert.ToDecimal(Fbalance.Text);
            m.Q_cheq = Convert.ToDecimal(q_cheq.Text);
            m.N_cheq = Convert.ToDecimal(n_cheq.Text);
            m.Grama = Convert.ToDecimal(grama.Text);
            m.Msaref = Convert.ToDecimal(msaref.Text);
            m.Sdad = Convert.ToDecimal(sdad.Text);
            m.Z_tah = Convert.ToDecimal(z_tah.Text);
            m.Tawgeh_maden = Convert.ToDecimal(tawgeh_maden.Text);
            m.Br1_madin = Convert.ToDecimal(br1_madin.SelectedValue);
            m.Br1_ksm = Convert.ToDecimal(br1_ksm.Text);
            //m.Br2_madin = Convert.ToDecimal(tbl.Rows[pos][14]);
            //m.Br2_ksm = Convert.ToDecimal(tbl.Rows[pos][15]);
            m.Taw_m = Convert.ToDecimal(taw_m.Text);
            m.Nakdy = Convert.ToDecimal(nakdy.Text);
            m.N_gra = Convert.ToDecimal(n_gra.Text);
            m.Mortag = Convert.ToDecimal(mortag.Text);
            m.Gra_m = Convert.ToDecimal(gra_m.Text);
            m.Gra_t = Convert.ToDecimal(gra_t.Text);
            m.Gra_hq = Convert.ToDecimal(gra_hq.Text);
            m.Gad_haly = Convert.ToDecimal(gad_haly.Text);
            m.Gad_sabeq = Convert.ToDecimal(gad_sabeq.Text);
            m.Tawgeh_daen = Convert.ToDecimal(tawgeh_daen.Text);
            m.Eada = Convert.ToDecimal(eada.Text);
            m.Morabha = Convert.ToDecimal(morabha.Text);
            m.Br3_madin = Convert.ToDecimal(br3_madin.SelectedValue);
            m.Br3_ksm = Convert.ToDecimal(br3_ksm.Text);
           // m.Br4_madin = Convert.ToDecimal(tbl.Rows[pos][30]);
           //m. Br4_ksm = Convert.ToDecimal(tbl.Rows[pos][31]);
            m. Last = Convert.ToDecimal(last.Text);
            m.Tas_madena = Convert.ToDecimal(tas_madena.Text);
            m.Tas_madena_name =tas_madena_name.Text.ToString();
            m.Tas_daena = Convert.ToDecimal(tas_daena.Text);
            m.Ta_da_na = ta_da_na.ToString();
            m.Br1nmae = this.br1_madin.GetItemText(this.br1_madin.SelectedItem);
            m.Br2name = this.br3_madin.GetItemText(this.br3_madin.SelectedItem);
        }
        private void MorEntry_Load(object sender, EventArgs e)
        {
            db.fill_branch(branch);
            db.fill_branch1(br1_madin);
            db.fill_branch1(br3_madin);
            m.AllData();
            m.movelast();
            ShowData();
            tot();
            newentry();
            DateTime d1 = DateTime.Today;
            t_month.Text = d1.Month.ToString();
            t_year.Text = d1.Year.ToString();
            
        }

        private void newentry()
        {
            pos.Text = "جديد";
           foreach (Control c in Controls)
            {
                if (c is TextBox)
                { c.Text = "0"; }
                else
                {
                    if (c is ComboBox)
                    {
                        ((ComboBox)c).SelectedIndex = -1;
                    }
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
                return;
            }
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46) && e.KeyChar != 130)
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
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
            tot();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            m.movefirst();
            ShowData();
            tot();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            m.movenext();
            ShowData();
            tot();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            m.moveprev();
            ShowData();
            tot();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            m.movelast();
            ShowData();
            tot();
        }
        private void tot()
        {
            double mad = Convert.ToDouble(Fbalance.Text) + Convert.ToDouble(msaref.Text) + Convert.ToDouble(q_cheq.Text) + Convert.ToDouble(sdad.Text) + Convert.ToDouble(grama.Text) + Convert.ToDouble(tawgeh_maden.Text) + Convert.ToDouble(z_tah.Text) + Convert.ToDouble(br1_ksm.Text) + Convert.ToDouble(tas_madena.Text);
          // =Nz([nakdy])+Nz([n_gra])+Nz([mortag])+Nz([gra_m])+ Nz([gra_t])+Nz([taw_m])+Nz([tawgeh daen])+Nz([gad_haly])+Nz([gad_sabeq])+Nz([Last])+Nz([gra_hq])+ Nz([eada])+Nz([br3_ksm])+Nz([morabha])+Nz([tas_daena])
        
            double dae = Convert.ToDouble(nakdy.Text) + Convert.ToDouble(n_gra.Text) + Convert.ToDouble(mortag.Text) + Convert.ToDouble(gra_t.Text) + Convert.ToDouble(gra_m.Text) + Convert.ToDouble(gra_hq.Text) + Convert.ToDouble(taw_m.Text) + Convert.ToDouble(tawgeh_daen.Text) + Convert.ToDouble(gad_haly.Text) + Convert.ToDouble(gad_sabeq.Text) + Convert.ToDouble(last.Text) + Convert.ToDouble(eada.Text) + Convert.ToDouble(br3_ksm.Text) + Convert.ToDouble(morabha.Text) + Convert.ToDouble(tas_daena.Text) ;
            txtDae.Text = String.Format("{0:0,0.000}", dae).ToString();
            txtMad.Text = String.Format("{0:0,0.000}", mad).ToString();
            //txtmas.Text = String.Format("{0:0,0.000}", mas).ToString();
            double farq = mad - dae;
            fr.Text = String.Format("{0:0,0.000}", farq).ToString();
        }
         private void button1_Click(object sender, EventArgs e)
          {
              branch.SelectedIndex = br_cbo().SelectedIndex;
              t_month.Value = mm();
              t_year.Value = yy();
 
             LocalEntry();
              SqlCommand cmd1 = new SqlCommand("spInsertMortd", conn);
              cmd1.CommandType = CommandType.StoredProcedure;
              //cmd1.Parameters.Clear();
              cmd1.Parameters.AddWithValue("@branch", branch.SelectedValue);
              cmd1.Parameters.AddWithValue("@month", t_month.Text);
              cmd1.Parameters.AddWithValue("@Year", t_year.Text);
              cmd1.Parameters.AddWithValue("@first", Fbalance.Text);
              cmd1.Parameters.AddWithValue("@q_cheq", q_cheq.Text);
              cmd1.Parameters.AddWithValue("@n_cheq", n_cheq.Text);
              cmd1.Parameters.AddWithValue("@grama", grama.Text);
              cmd1.Parameters.AddWithValue("@msaref", msaref.Text);
              cmd1.Parameters.AddWithValue("@sdad", sdad.Text);
              cmd1.Parameters.AddWithValue("@z_tah", z_tah.Text);
              cmd1.Parameters.AddWithValue("@tawgeh_maden", tawgeh_maden.Text);
              cmd1.Parameters.AddWithValue("@br1_madin", br1_madin.SelectedValue);
              cmd1.Parameters.AddWithValue("@br1_ksm", br1_ksm.Text);

              cmd1.Parameters.AddWithValue("@taw_m", taw_m.Text);
              cmd1.Parameters.AddWithValue("@nakdy", nakdy.Text);
              cmd1.Parameters.AddWithValue("@n_gra", n_gra.Text);
              cmd1.Parameters.AddWithValue("@mortag", mortag.Text);
              cmd1.Parameters.AddWithValue("@gra_m", gra_m.Text);
              cmd1.Parameters.AddWithValue("@gra_t", gra_t.Text);
              cmd1.Parameters.AddWithValue("@gra_hq", gra_hq.Text);
              cmd1.Parameters.AddWithValue("@gad_haly", gad_haly.Text);
              cmd1.Parameters.AddWithValue("@gad_sabeq", gad_sabeq.Text);
              cmd1.Parameters.AddWithValue("@tawgeh_daen", tawgeh_daen.Text);
              cmd1.Parameters.AddWithValue("@eada", eada.Text);
              cmd1.Parameters.AddWithValue("@morabha", morabha.Text);
              cmd1.Parameters.AddWithValue("@br3_madin", br3_madin.Text);
              cmd1.Parameters.AddWithValue("@br3_ksm", br3_ksm.Text);

              cmd1.Parameters.AddWithValue("@last", last.Text);
              cmd1.Parameters.AddWithValue("@tas_madena", tas_madena.Text);
              cmd1.Parameters.AddWithValue("@tas_madena_name", tas_madena_name.Text);
              cmd1.Parameters.AddWithValue("@tas_daena", tas_daena.Text);
              cmd1.Parameters.AddWithValue("@ta_da_na", ta_da_na.Text);
              cmd1.Parameters.AddWithValue("@br1nmae", this.br1_madin.GetItemText(this.br1_madin.SelectedItem));
              cmd1.Parameters.AddWithValue("@br2name", this.br3_madin.GetItemText(this.br3_madin.SelectedItem));
              this.Cursor = Cursors.WaitCursor;
              if (branch.SelectedIndex != -1)
              {
                  DataTable tbl = new DataTable();
                  tbl = db.runquery("select branch,month,year from mortd where branch='" + branch.SelectedValue + "' and month='" + t_month.Text + "' and year='" + t_year.Text + "' ");
                  if (tbl.Rows.Count == 1)
                      MessageBox.Show("تم تسجيل البيانات من قبل");
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
                              //loaddata();
                              MorEntry_Load(null, null);
                              this.Cursor = Cursors.Default;
                          }
                          else
                          {
                              this.Cursor = Cursors.Default;
                              MessageBox.Show("لا يوجد اتصال بالانترنت ولن تسجل البيانات اون لاين");
                          }
                      }
                      catch (Exception ex)
                      {
                          MessageBox.Show(ex.Message.ToString());
                          conn.Close();
                      }
                  }
              }
              else
                  MessageBox.Show("يجب اختيار الفرع أولاً");

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
        private void button2_Click(object sender, EventArgs e) // update
        {


            UpdateLocal();
            SqlCommand cmd1 = new SqlCommand("spUpdateMortd", conn);
            cmd1.CommandType = CommandType.StoredProcedure;
            //cmd1.Parameters.Clear();
            cmd1.Parameters.AddWithValue("@branch", branch.SelectedValue);
            cmd1.Parameters.AddWithValue("@month", t_month.Text);
            cmd1.Parameters.AddWithValue("@Year", t_year.Text);
            cmd1.Parameters.AddWithValue("@first", Fbalance.Text);
            cmd1.Parameters.AddWithValue("@q_cheq", q_cheq.Text);
            cmd1.Parameters.AddWithValue("@n_cheq", n_cheq.Text);
            cmd1.Parameters.AddWithValue("@grama", grama.Text);
            cmd1.Parameters.AddWithValue("@msaref", msaref.Text);
            cmd1.Parameters.AddWithValue("@sdad", sdad.Text);
            cmd1.Parameters.AddWithValue("@z_tah", z_tah.Text);
            cmd1.Parameters.AddWithValue("@tawgeh_maden", tawgeh_maden.Text);
            cmd1.Parameters.AddWithValue("@br1_madin", br1_madin.SelectedValue);
            cmd1.Parameters.AddWithValue("@br1_ksm", br1_ksm.Text);

            cmd1.Parameters.AddWithValue("@taw_m", taw_m.Text);
            cmd1.Parameters.AddWithValue("@nakdy", nakdy.Text);
            cmd1.Parameters.AddWithValue("@n_gra", n_gra.Text);
            cmd1.Parameters.AddWithValue("@mortag", mortag.Text);
            cmd1.Parameters.AddWithValue("@gra_m", gra_m.Text);
            cmd1.Parameters.AddWithValue("@gra_t", gra_t.Text);
            cmd1.Parameters.AddWithValue("@gra_hq", gra_hq.Text);
            cmd1.Parameters.AddWithValue("@gad_haly", gad_haly.Text);
            cmd1.Parameters.AddWithValue("@gad_sabeq", gad_sabeq.Text);
            cmd1.Parameters.AddWithValue("@tawgeh_daen", tawgeh_daen.Text);
            cmd1.Parameters.AddWithValue("@eada", eada.Text);
            cmd1.Parameters.AddWithValue("@morabha", morabha.Text);
            cmd1.Parameters.AddWithValue("@br3_madin", br3_madin.Text);
            cmd1.Parameters.AddWithValue("@br3_ksm", br3_ksm.Text);

            cmd1.Parameters.AddWithValue("@last", last.Text);
            cmd1.Parameters.AddWithValue("@tas_madena", tas_madena.Text);
            cmd1.Parameters.AddWithValue("@tas_madena_name", tas_madena_name.Text);
            cmd1.Parameters.AddWithValue("@tas_daena", tas_daena.Text);
            cmd1.Parameters.AddWithValue("@ta_da_na", ta_da_na.Text);
            cmd1.Parameters.AddWithValue("@br1nmae", this.br1_madin.GetItemText(this.br1_madin.SelectedItem));
            cmd1.Parameters.AddWithValue("@br2name", this.br3_madin.GetItemText(this.br3_madin.SelectedItem));
            this.Cursor = Cursors.WaitCursor;
            if (branch.SelectedIndex != -1)
            {
                DataTable tbl = new DataTable();
                tbl = db.runquery("select branch,month,year from mortd where branch='" + branch.SelectedValue + "' and month='" + t_month.Text + "' and year='" + t_year.Text + "' ");
                if (tbl.Rows.Count != 1)
                    MessageBox.Show("لم يتم تسجيل البيانات من قبل");
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
                            //loaddata();
                            MorEntry_Load(null, null);
                            this.Cursor = Cursors.Default;
                        }
                        else
                        {
                            this.Cursor = Cursors.Default;
                            MessageBox.Show("لا يوجد اتصال بالانترنت ولن تسجل البيانات اون لاين");
                        }
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show(ex.Message.ToString());
                        conn.Close();
                        this.Cursor = Cursors.Default;
                    }
                }
            }
            else
                MessageBox.Show("يجب اختيار الفرع أولاً");
                this.Cursor = Cursors.Default;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            newentry();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            
        }

        private void LocalEntry()

        {
            
            SqlCeCommand cmd1;
            cmd1 = new SqlCeCommand("INSERT INTO mortd (branch, [month], [year], [first1], q_cheq, n_cheq, grama, msaref, sdad, z_tah, [tawgeh maden], br1_madin, br1_ksm, taw_m, nakdy, n_gra, mortag, gra_m, gra_t, gra_hq, gad_haly, gad_sabeq, [tawgeh daen], eada, morabha, br3_madin, br3_ksm, [last], tas_madena, tas_madena_name, tas_daena, ta_da_na, br1nmae, br2name) VALUES(@branch,@month,@Year,@first,@q_cheq,@n_cheq,@grama,@msaref,@sdad,@z_tah,@tawgeh_maden,@br1_madin,@br1_ksm,@taw_m,@nakdy,@n_gra,@mortag,@gra_m,@gra_t,@gra_hq,@gad_haly,@gad_sabeq,@tawgeh_daen,@eada,@morabha,@br3_madin,@br3_ksm,@last,@tas_madena,@tas_madena_name,@tas_daena,@ta_da_na,@br1nmae,@br2name)", db.con);
            cmd1.Parameters.AddWithValue("@branch", branch.SelectedValue);
            cmd1.Parameters.AddWithValue("@month", t_month.Text);
            cmd1.Parameters.AddWithValue("@Year", t_year.Text);
            cmd1.Parameters.AddWithValue("@first", Fbalance.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@q_cheq", q_cheq.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@n_cheq", n_cheq.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@grama", grama.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@msaref", msaref.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@sdad", sdad.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@z_tah", z_tah.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@tawgeh_maden", tawgeh_maden.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@br1_madin", br1_madin.SelectedValue ?? DBNull.Value);
            cmd1.Parameters.AddWithValue("@br1_ksm", br1_ksm.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@taw_m", taw_m.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@nakdy", nakdy.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@n_gra", n_gra.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@mortag", mortag.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@gra_m", gra_m.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@gra_t", gra_t.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@gra_hq", gra_hq.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@gad_haly", gad_haly.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@gad_sabeq", gad_sabeq.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@tawgeh_daen", tawgeh_daen.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@eada", eada.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@morabha", morabha.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@br3_madin", br3_madin.SelectedValue ?? DBNull.Value);
            cmd1.Parameters.AddWithValue("@br3_ksm", br3_ksm.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@last", last.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@tas_madena", tas_madena.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@tas_madena_name", tas_madena_name.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@tas_daena", tas_daena.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@ta_da_na", ta_da_na.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@br1nmae", this.br1_madin.GetItemText(this.br1_madin.SelectedItem) ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@br2name", this.br3_madin.GetItemText(this.br3_madin.SelectedItem) ?? DBNull.Value.ToString());
            if (branch.SelectedIndex != -1)
            {
                DataTable tbl = new DataTable();
                tbl = db.Ce_runquery("select branch,month,year from mortd where branch='" + branch.SelectedValue + "' and month='" + t_month.Text + "' and year='" + t_year.Text + "' ");
                if (tbl.Rows.Count == 1)
                    MessageBox.Show("تم تسجيل البيانات من قبل");
                else
                {
                    try
                    {
                        db.con.Open();
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("الرجاء الانتظار قليلاً لحين تحديث البيانات على الشبكة");
                        db.con.Close();
                        loaddata();
                        //MorEntry_Load(null, null);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                        db.con.Close();
                    }
                }
            }
            else
                MessageBox.Show("يجب اختيار الفرع أولاً");
        }
        private void UpdateLocal()
        {
            
            SqlCeCommand cmd1;
            cmd1 = new SqlCeCommand("UPDATE mortd SET [first1] = @first,[q_cheq] = @q_cheq ,[n_cheq] = @n_cheq ,[grama] = @grama ,[msaref] = @msaref ,[sdad] = @sdad ,[z_tah] = @z_tah ,[tawgeh maden] = @tawgeh_maden ,[br1_madin] = @br1_madin ,[br1_ksm] = @br1_ksm ,[taw_m] = @taw_m ,[nakdy] = @nakdy ,[n_gra] = @n_gra ,[mortag] = @mortag ,[gra_m] = @gra_m ,[gra_t] = @gra_t ,[gra_hq] = @gra_hq ,[gad_haly] = @gad_haly ,[gad_sabeq] = @gad_sabeq ,[tawgeh daen] = @tawgeh_daen ,[eada] = @eada ,[morabha] = @morabha ,[br3_madin] = @br3_madin ,[br3_ksm] = @br3_ksm ,[last] = @last ,[tas_madena] = @tas_madena ,[tas_madena_name] = @tas_madena_name ,[tas_daena] = @tas_daena ,[ta_da_na] = @ta_da_na ,[br1nmae]=@br1nmae ,[br2name]=@br2name WHERE [branch] = @branch and [month] = @month and [year] = @year  ", db.con);
            cmd1.Parameters.AddWithValue("@branch", branch.SelectedValue);
            cmd1.Parameters.AddWithValue("@month", t_month.Text);
            cmd1.Parameters.AddWithValue("@Year", t_year.Text);
            cmd1.Parameters.AddWithValue("@first", Fbalance.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@q_cheq", q_cheq.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@n_cheq", n_cheq.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@grama", grama.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@msaref", msaref.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@sdad", sdad.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@z_tah", z_tah.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@tawgeh_maden", tawgeh_maden.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@br1_madin", br1_madin.SelectedValue ?? DBNull.Value);
            cmd1.Parameters.AddWithValue("@br1_ksm", br1_ksm.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@taw_m", taw_m.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@nakdy", nakdy.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@n_gra", n_gra.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@mortag", mortag.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@gra_m", gra_m.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@gra_t", gra_t.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@gra_hq", gra_hq.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@gad_haly", gad_haly.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@gad_sabeq", gad_sabeq.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@tawgeh_daen", tawgeh_daen.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@eada", eada.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@morabha", morabha.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@br3_madin", br3_madin.SelectedValue ?? DBNull.Value);
            cmd1.Parameters.AddWithValue("@br3_ksm", br3_ksm.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@last", last.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@tas_madena", tas_madena.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@tas_madena_name", tas_madena_name.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@tas_daena", tas_daena.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@ta_da_na", ta_da_na.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@br1nmae", this.br1_madin.GetItemText(this.br1_madin.SelectedItem) ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@br2name", this.br3_madin.GetItemText(this.br3_madin.SelectedItem) ?? DBNull.Value.ToString());
            if (branch.SelectedIndex != -1)
            {
                DataTable tbl = new DataTable();
                tbl = db.Ce_runquery("select branch,month,year from mortd where branch='" + branch.SelectedValue + "' and month='" + t_month.Text + "' and year='" + t_year.Text + "' ");
                if (tbl.Rows.Count != 1)
                    MessageBox.Show("لم يتم تسجيل البيانات من قبل");
                else
                {
                    try
                    {
                        db.con.Open();
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("الرجاء الانتظار قليلاً لحين تحديث البيانات على الشبكة");
                        db.con.Close();
                        loaddata();
                        //MorEntry_Load(null, null);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                        db.con.Close();
                    }
                }
            }
            else
                MessageBox.Show("يجب اختيار الفرع أولاً");
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void tas_daena_TextChanged(object sender, EventArgs e)
        {

        }

        private void ta_da_na_TextChanged(object sender, EventArgs e)
        {

        }

        private void ta_da_na_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
                return;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            m.movefirst();
            ShowData();
            tot();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            m.movenext();
            ShowData();
            tot();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            m.movelast();
            ShowData();
            tot();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            m.moveprev();
            ShowData();
            tot();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            newentry();
           
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void button3_Click_1(object sender, EventArgs e)
        {
        }


       
    }
}
