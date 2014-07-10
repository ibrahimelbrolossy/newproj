using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
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
    public partial class UserEntry : Form
    {
        public UserEntry()
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
        Maftouh m = new Maftouh();
        private void ShowData()
        {
            branch.SelectedValue = m.Branch_id;
            t_month.Text = m.T_month.ToString();
            t_year.Text = m.T_year.ToString();
            Fbalance.Text = m.First_balance.ToString();
            sales_ad.Text = m.Sales_ad.ToString();
            sales_as.Text = m.Sales_as.ToString();
            return_mor.Text = m.Return_mor.ToString();
            ta_mor.Text = m.Ta_mor.ToString();
            tak_tam.Text = m.Tak_tam.ToString();
            ziadat_nk.Text = m.Ziadat_nk.ToString();
            ziadat_esarat.Text = m.Ziadat_esarat.ToString();
            ziadat_esarat_mor.Text = m.Ziadat_esarat_mor.ToString();
            ziadat_ksm.Text = m.Ziadat_ksm.ToString();
            br1_madin.SelectedValue = m.Br1_madin.ToString();
            br1_ksm.Text = m.Br1_ksm.ToString();
            br2_madin.SelectedValue = m.Br2_madin.ToString();
            br2_ksm.Text = m.Br2_ksm.ToString();
            br3_madin.SelectedValue = m.Br3_madin.ToString();
            br3_ksm.Text = m.Br3_ksm.ToString();
            br4_madin.SelectedValue = m.Br4_madin.ToString();
            br4m_ksm.Text = m.Br4m_ksm.ToString();
            gad_haly.Text = m.Gad_haly.ToString();
            gad_mokdm.Text = m.Gad_mokdm.ToString();
            eada_tah.Text = m.Eada_tah.ToString();
            mas_gad.Text = m.Mas_gad.ToString();
            mas_eada.Text = m.Mas_eada.ToString();
            sader_d_m.Text = m.Sader_d_m.ToString();
            mortagaat_ad.Text = m.Mortagaat_ad.ToString();
            mortagaat_as.Text = m.Mortagaat_as.ToString();
            nakdy4.Text = m.Nakdy4.ToString();
            nakdy44.Text = m.Nakdy44.ToString();
            agel71.Text = m.Agel71.ToString();
            agel5.Text = m.Agel5.ToString();
            agel82.Text = m.Agel82.ToString();
            agel_hkomy.Text = m.Agel_hkomy.ToString();
            ksm_mas.Text = m.Ksm_mas.ToString();
            yom12.Text = m.Yom12.ToString();
            haq_cus.Text = m.Haq_cus.ToString();
            motgawez.Text = m.Motgawez.ToString();
            b_c.Text = m.B_c.ToString();
            ksm_sher1.SelectedValue = m.Ksm_sher1.ToString();
            sh1_ksm.Text = m.Sh1_ksm.ToString();
            ksm_sher2.SelectedValue = m.Ksm_sher2.ToString();
            sh2_ksm.Text = m.Sh2_ksm.ToString();
            ksm_sher3.SelectedValue = m.Ksm_sher3.ToString();
            sh3_ksm.Text = m.Sh3_ksm.ToString();
            ksm_sher4.SelectedValue = m.Ksm_sher4.ToString();
            sh4_ksm.Text = m.Sh4_ksm.ToString();
            ksm_sher5.SelectedValue = m.Ksm_sher5.ToString();
            sh5_ksm.Text = m.Sh5_ksm.ToString();
            ksm_sher6.SelectedValue = m.Ksm_sher6.ToString();
            sh6_ksm.Text = m.Sh6_ksm.ToString();
            ksm_sher7.SelectedValue = m.Ksm_sher7;
            sh7_ksm.Text = m.Sh7_ksm.ToString();
            ksm_sher8.SelectedValue = m.Ksm_sher8.ToString();
            sh8_ksm.Text = m.Sh8_ksm.ToString();
            ksm_sher9.SelectedValue = m.Ksm_sher9.ToString();
            sh9_ksm.Text = m.Sh9_ksm.ToString();
            ksm_sher10.SelectedValue = m.Ksm_sher10.ToString();
            sh10_ksm.Text = m.Sh10_ksm.ToString();
            ksm_youm.Text = m.Ksm_youm.ToString();
            ksm_asn.Text = m.Ksm_asn.ToString();
            ksm_hosb.Text = m.Ksm_hosb.ToString();
            ksm_mortbat.Text = m.Ksm_mortbat.ToString();
            ksm_deal_month.Text = m.Ksm_deal_month.ToString();
            ksm_deal_qur.Text = m.Ksm_deal_qur.ToString();
            ksm_deal_6.Text = m.Ksm_deal_6.ToString();
            tas_hosb.Text = m.Tas_hosb.ToString();
            d_a_t.Text = m.D_a_t.ToString();
            es_sabeq.Text = m.Es_sabeq.ToString();
            morabha.Text = m.Morabha.ToString();
            tawg_mor.Text = m.Tawg_mor.ToString();
            sharq_78.Text = m.Sharq_7.ToString();
            sharq_8.Text = m.Sharq_8.ToString();
            sadad_sk.Text = m.Sdad_sk.ToString();
            tawg_last_year.Text = m.Tawg_last_year.ToString();
            tawg_ksm_sabeq.Text = m.Tawg_ksm_sabeq.ToString();
            twag_mor_sab.Text = m.Twag_mor_sab.ToString();
            br4_daen.SelectedValue = m.Br4_daen.ToString();
            br4_ksm.Text = m.Br4_ksm.ToString();
            br5_daen.SelectedValue = m.Br5_daen.ToString();
            br5_ksm.Text = m.Br5_ksm.ToString();
            br6_daen.SelectedValue = m.Br6_daen.ToString();
            br6_ksm.Text = m.Br6_ksm.ToString();
            last_balance.Text = m.Last_balance.ToString();
            tas_madena.Text = m.Tas_madena.ToString();
            tas_madena_name.Text = m.Tas_madena_name as string;
            tas_daena.Text = m.Tas_daena.ToString();
            ta_da_na.Text = m.Ta_da_na as string;
            sh_d_m.SelectedValue = m.Sh_d_m.ToString();
            shnmae1.Text = m.Shname1 as string;
            shc1.Text = m.Shcode1.ToString();
            shc2.Text = m.Shcode2.ToString();
            shc3.Text = m.Shcode3.ToString();
            shc4.Text = m.Shcode4.ToString();
            shc5.Text = m.Shcode5.ToString();
            shc6.Text = m.Shcode6.ToString();
            shc7.Text = m.Shcode7.ToString();
            shc8.Text = m.Shcode8.ToString();
            shc9.Text = m.Shcode9.ToString();
            shc10.Text = m.Shcode10.ToString();
            dac.Text = m.Darcode.ToString();
            tas_hosb1.Text = (Convert.ToDecimal(tas_hosb.Text) + Convert.ToDecimal(sharq_78.Text)).ToString();
            youm96.Text = (Convert.ToDecimal(ksm_deal_month.Text) + Convert.ToDecimal(ksm_deal_qur.Text)).ToString();
            yoim79.Text = (Convert.ToDecimal(gad_haly.Text) + Convert.ToDecimal(gad_mokdm.Text) + Convert.ToDecimal(eada_tah.Text) + Convert.ToDecimal(mas_eada.Text) + Convert.ToDecimal(mas_gad.Text)).ToString();
            youm17.Text = (Convert.ToDouble(sh1_ksm.Text) + Convert.ToDouble(sh2_ksm.Text) + Convert.ToDouble(sh3_ksm.Text) + Convert.ToDouble(sh4_ksm.Text) + Convert.ToDouble(sh5_ksm.Text) + Convert.ToDouble(sh6_ksm.Text) + Convert.ToDouble(sh7_ksm.Text) + Convert.ToDouble(sh8_ksm.Text) + Convert.ToDouble(sh9_ksm.Text) + Convert.ToDouble(sh10_ksm.Text)).ToString();
            youm8.Text = ((Convert.ToDouble(br4_ksm.Text) + Convert.ToDouble(br5_ksm.Text) + Convert.ToDouble(br6_ksm.Text) + Convert.ToDouble(tas_daena.Text) + Convert.ToDouble(sharq_8.Text)) - (Convert.ToDouble(br1_ksm.Text) + Convert.ToDouble(br2_ksm.Text) + Convert.ToDouble(br3_ksm.Text) + Convert.ToDouble(br4m_ksm.Text) + Convert.ToDouble(tas_madena.Text) + Convert.ToDouble(sader_d_m.Text))).ToString();
            pos.Text = m.curuntposition();
        }
        private void loaddata()
        {

            try
            {
                m.Branch_id = Convert.ToInt32(branch.SelectedValue);
                m.T_month = Convert.ToInt32(t_month.Text);
                m.T_year = Convert.ToInt32(t_year.Text);
                m.First_balance = Convert.ToDecimal(Fbalance.Text);
                m.Sales_ad = Convert.ToDecimal(sales_ad.Text);
                m.Sales_as = Convert.ToDecimal(sales_as.Text);
                m.Return_mor = Convert.ToDecimal(return_mor.Text);
                m.Ta_mor = Convert.ToDecimal(ta_mor.Text);
                m.Tak_tam = Convert.ToDecimal(tak_tam.Text);
                m.Ziadat_nk = Convert.ToDecimal(ziadat_nk.Text);
                m.Ziadat_esarat = Convert.ToDecimal(ziadat_esarat.Text);
                m.Ziadat_esarat_mor = Convert.ToDecimal(ziadat_esarat_mor.Text);
                m.Ziadat_ksm = Convert.ToDecimal(ziadat_ksm.Text);
                m.Br1_madin = Convert.ToDecimal(br1_madin.SelectedValue);
                m.Br1_ksm = Convert.ToDecimal(br1_ksm.Text);
                m.Br2_madin = Convert.ToDecimal(br2_madin.SelectedValue);
                m.Br2_ksm = Convert.ToDecimal(br2_ksm.Text);
                m.Br3_madin = Convert.ToDecimal(br3_madin.SelectedValue);
                m.Br3_ksm = Convert.ToDecimal(br3_ksm.Text);
                m.Br4_madin = Convert.ToDecimal(br4_madin.SelectedValue);
                m.Br4m_ksm = Convert.ToDecimal(br4m_ksm.Text);
                m.Gad_haly = Convert.ToDecimal(gad_haly.Text);
                m.Gad_mokdm = Convert.ToDecimal(gad_mokdm.Text);
                m.Eada_tah = Convert.ToDecimal(eada_tah.Text);
                m.Mas_gad = Convert.ToDecimal(mas_gad.Text);
                m.Mas_eada = Convert.ToDecimal(mas_eada.Text);
                m.Sader_d_m = Convert.ToDecimal(sader_d_m.Text);
                m.Mortagaat_ad = Convert.ToDecimal(mortagaat_ad.Text);
                m.Mortagaat_as = Convert.ToDecimal(mortagaat_as.Text);
                m.Nakdy4 = Convert.ToDecimal(nakdy4.Text);
                m.Nakdy44 = Convert.ToDecimal(nakdy44.Text);
                m.Agel71 = Convert.ToDecimal(agel71.Text);
                m.Agel5 = Convert.ToDecimal(agel5.Text);
                m.Agel82 = Convert.ToDecimal(agel82.Text);
                m.Agel_hkomy = Convert.ToDecimal(agel_hkomy.Text);
                m.Ksm_mas = Convert.ToDecimal(ksm_mas.Text);
                m.Yom12 = Convert.ToDecimal(yom12.Text);
                m.Haq_cus = Convert.ToDecimal(haq_cus.Text);
                m.Motgawez = Convert.ToDecimal(motgawez.Text);
                m.B_c = Convert.ToDecimal(b_c.Text);
                m.Ksm_sher1 = Convert.ToDecimal(ksm_sher1.SelectedValue);
                m.Sh1_ksm = Convert.ToDecimal(sh1_ksm.Text);
                m.Ksm_sher2 = Convert.ToDecimal(ksm_sher2.SelectedValue);
                m.Sh2_ksm = Convert.ToDecimal(sh2_ksm.Text);
                m.Ksm_sher3 = Convert.ToDecimal(ksm_sher3.SelectedValue);
                m.Sh3_ksm = Convert.ToDecimal(sh3_ksm.Text);
                m.Ksm_sher4 = Convert.ToDecimal(ksm_sher4.SelectedValue);
                m.Sh4_ksm = Convert.ToDecimal(sh4_ksm.Text);
                m.Ksm_sher5 = Convert.ToDecimal(ksm_sher5.SelectedValue);
                m.Sh5_ksm = Convert.ToDecimal(sh5_ksm.Text);
                m.Ksm_sher6 = Convert.ToDecimal(ksm_sher6.SelectedValue);
                m.Sh6_ksm = Convert.ToDecimal(sh6_ksm.Text);
                m.Ksm_sher7 = Convert.ToDecimal(ksm_sher7.SelectedValue);
                m.Sh7_ksm = Convert.ToDecimal(sh7_ksm.Text);
                m.Ksm_sher8 = Convert.ToDecimal(ksm_sher8.SelectedValue);
                m.Sh8_ksm = Convert.ToDecimal(sh8_ksm.Text);
                m.Ksm_sher9 = Convert.ToDecimal(ksm_sher9.SelectedValue);
                m.Sh9_ksm = Convert.ToDecimal(sh9_ksm.Text);
                m.Ksm_sher10 = Convert.ToDecimal(ksm_sher10.SelectedValue);
                m.Sh10_ksm = Convert.ToDecimal(sh10_ksm.Text);
                m.Ksm_youm = Convert.ToDecimal(ksm_youm.Text);
                m.Ksm_asn = Convert.ToDecimal(ksm_asn.Text);
                m.Ksm_hosb = Convert.ToDecimal(ksm_hosb.Text);
                m.Ksm_mortbat = Convert.ToDecimal(ksm_mortbat.Text);
                m.Ksm_deal_month = Convert.ToDecimal(ksm_deal_month.Text);
                m.Ksm_deal_qur = Convert.ToDecimal(ksm_deal_qur.Text);
                m.Ksm_deal_6 = Convert.ToDecimal(ksm_deal_6.Text);
                m.Tas_hosb = Convert.ToDecimal(tas_hosb.Text);
                m.D_a_t = Convert.ToDecimal(d_a_t.Text);
                m.Es_sabeq = Convert.ToDecimal(es_sabeq.Text);
                m.Morabha = Convert.ToDecimal(morabha.Text);
                m.Tawg_mor = Convert.ToDecimal(tawg_mor.Text);
                m.Sharq_7 = Convert.ToDecimal(sharq_78.Text);
                m.Sharq_8 = Convert.ToDecimal(sharq_8.Text);
                m.Sdad_sk = Convert.ToDecimal(sadad_sk.Text);
                m.Tawg_last_year = Convert.ToDecimal(tawg_last_year.Text);
                m.Tawg_ksm_sabeq = Convert.ToDecimal(tawg_ksm_sabeq.Text);
                m.Twag_mor_sab = Convert.ToDecimal(twag_mor_sab.Text);
                m.Br4_daen = Convert.ToDecimal(br4_daen.SelectedValue);
                m.Br4_ksm = Convert.ToDecimal(br4_ksm.Text);
                m.Br5_daen = Convert.ToDecimal(br5_daen.SelectedValue);
                m.Br5_ksm = Convert.ToDecimal(br5_ksm.Text);
                m.Br6_daen = Convert.ToDecimal(br6_daen.SelectedValue);
                m.Br6_ksm = Convert.ToDecimal(br6_ksm.Text);
                m.Last_balance = Convert.ToDecimal(last_balance.Text);
                m.Tas_madena = Convert.ToDecimal(tas_madena.Text);
                m.Tas_madena_name = tas_madena_name.Text.ToString();
                m.Tas_daena = Convert.ToDecimal(tas_daena.Text);
                m.Ta_da_na = ta_da_na.Text.ToString();
                m.Sh_d_m = Convert.ToDecimal(sh_d_m.SelectedValue);
                m.Shname1 = shnmae1.Text;
                m.Shcode1 = Convert.ToInt32(shc1.Text);
                m.Shcode2 = Convert.ToInt32(shc2.Text);
                m.Shcode3 = Convert.ToInt32(shc3.Text);
                m.Shcode4 = Convert.ToInt32(shc4.Text);
                m.Shcode5 = Convert.ToInt32(shc5.Text);
                m.Shcode6 = Convert.ToInt32(shc6.Text);
                m.Shcode7 = Convert.ToInt32(shc7.Text);
                m.Shcode8 = Convert.ToInt32(shc8.Text);
                m.Shcode9 = Convert.ToInt32(shc9.Text);
                m.Shcode10 = Convert.ToInt32(shc10.Text);
                m.Darcode = Convert.ToInt32(dac.Text);
                tas_hosb1.Text = (Convert.ToDecimal(tas_hosb.Text) + Convert.ToDecimal(sharq_78.Text)).ToString();
                youm96.Text = (Convert.ToDecimal(ksm_deal_month.Text) + Convert.ToDecimal(ksm_deal_qur.Text)).ToString();
                yoim79.Text = (Convert.ToDecimal(gad_haly.Text) + Convert.ToDecimal(gad_mokdm.Text) + Convert.ToDecimal(eada_tah.Text) + Convert.ToDecimal(mas_eada.Text) + Convert.ToDecimal(mas_gad.Text)).ToString();
                youm17.Text = (Convert.ToDouble(sh1_ksm.Text) + Convert.ToDouble(sh2_ksm.Text) + Convert.ToDouble(sh3_ksm.Text) + Convert.ToDouble(sh4_ksm.Text) + Convert.ToDouble(sh5_ksm.Text) + Convert.ToDouble(sh6_ksm.Text) + Convert.ToDouble(sh7_ksm.Text) + Convert.ToDouble(sh8_ksm.Text) + Convert.ToDouble(sh9_ksm.Text) + Convert.ToDouble(sh10_ksm.Text)).ToString();
                youm8.Text = ((Convert.ToDouble(br4_ksm.Text) + Convert.ToDouble(br5_ksm.Text) + Convert.ToDouble(br6_ksm.Text) + Convert.ToDouble(tas_daena.Text) + Convert.ToDouble(sharq_8.Text)) - (Convert.ToDouble(br1_ksm.Text) + Convert.ToDouble(br2_ksm.Text) + Convert.ToDouble(br3_ksm.Text) + Convert.ToDouble(br4m_ksm.Text) + Convert.ToDouble(tas_madena.Text) + Convert.ToDouble(sader_d_m.Text))).ToString();
                //pos.Text = m.curuntposition();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void UserEntry_Load(object sender, EventArgs e)
        {
            db.fill_branch(branch);
            db.fill_branch1(br1_madin);
            db.fill_branch1(br2_madin);
            db.fill_branch1(br3_madin);
            db.fill_branch1(br4_madin);
            db.fill_branch1(br4_daen);
            db.fill_branch1(br5_daen);
            db.fill_branch1(br6_daen);
            db.fill_sh(sh_d_m);
            db.fill_sh(ksm_sher1);
            db.fill_sh(ksm_sher2);
            db.fill_sh(ksm_sher3);
            db.fill_sh(ksm_sher4);
            db.fill_sh(ksm_sher5);
            db.fill_sh(ksm_sher6);
            db.fill_sh(ksm_sher7);
            db.fill_sh(ksm_sher8);
            db.fill_sh(ksm_sher9);
            db.fill_sh(ksm_sher10);

            m.AllData();
            m.movelast();
            ShowData();
            tot();
            newentry(tabControl1);
            DateTime d1 = DateTime.Today;
            t_month.Text = d1.Month.ToString();
            t_year.Text = d1.Year.ToString();
        }
        private void newentry(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl.Controls.Count > 0) newentry(ctrl);
                if (ctrl is TextBox)
                {
                    ctrl.Text = "0";

                }
                else if (ctrl is ComboBox)
                {
                    ((ComboBox)ctrl).SelectedIndex = -1;
                }

            }
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            branch = br_cbo();

            branch.SelectedIndex = br_cbo().SelectedIndex;
            t_month.Value = mm();
            t_year.Value = yy();

            insert_local();
            SqlCommand cmd1 = new SqlCommand("spInsertCustomers", conn);
            cmd1.CommandType = CommandType.StoredProcedure;
            //cmd1.Parameters.Clear();
            cmd1.Parameters.AddWithValue("@branch_id", branch.SelectedValue);
            cmd1.Parameters.AddWithValue("@t_month", t_month.Text);
            cmd1.Parameters.AddWithValue("@t_year", t_year.Text);
            cmd1.Parameters.AddWithValue("@first_balance", Fbalance.Text);
            cmd1.Parameters.AddWithValue("@sales_ad", sales_ad.Text);
            cmd1.Parameters.AddWithValue("@sales_as", sales_as.Text);
            cmd1.Parameters.AddWithValue("@return_mor ", return_mor.Text);
            cmd1.Parameters.AddWithValue("@ta_mor", ta_mor.Text);
            cmd1.Parameters.AddWithValue("@tak_tam", tak_tam.Text);
            cmd1.Parameters.AddWithValue("@ziadat_nk", ziadat_nk.Text);
            cmd1.Parameters.AddWithValue("@ziadat_esarat", ziadat_esarat.Text);
            cmd1.Parameters.AddWithValue("@ziadat_esarat_mor", ziadat_esarat_mor.Text);
            cmd1.Parameters.AddWithValue("@ziadat_ksm", ziadat_ksm.Text);
            cmd1.Parameters.AddWithValue("@br1_madin", br1_madin.SelectedValue);
            cmd1.Parameters.AddWithValue("@br1_ksm", br1_ksm.Text);
            cmd1.Parameters.AddWithValue("@br2_madin", br2_madin.SelectedValue);
            cmd1.Parameters.AddWithValue("@br2_ksm", br2_ksm.Text);
            cmd1.Parameters.AddWithValue("@br3_madin", br3_madin.SelectedValue);
            cmd1.Parameters.AddWithValue("@br3_ksm", br3_ksm.Text);
            cmd1.Parameters.AddWithValue("@br4_madin", br4_madin.SelectedValue);
            cmd1.Parameters.AddWithValue("@br4m_ksm", br4m_ksm.Text);
            cmd1.Parameters.AddWithValue("@gad_haly", gad_haly.Text);
            cmd1.Parameters.AddWithValue("@gad_mokdm", gad_mokdm.Text);
            cmd1.Parameters.AddWithValue("@eada_tah", eada_tah.Text);
            cmd1.Parameters.AddWithValue("@mas_gad ", mas_gad.Text);
            cmd1.Parameters.AddWithValue("@mas_eada ", mas_eada.Text);
            cmd1.Parameters.AddWithValue("@sader_d_m", sader_d_m.Text);
            cmd1.Parameters.AddWithValue("@mortagaat_ad", mortagaat_ad.Text);
            cmd1.Parameters.AddWithValue("@mortagaat_as ", mortagaat_as.Text);
            cmd1.Parameters.AddWithValue("@nakdy4", nakdy4.Text);
            cmd1.Parameters.AddWithValue("@nakdy44", nakdy44.Text);
            cmd1.Parameters.AddWithValue("@agel71", agel71.Text);
            cmd1.Parameters.AddWithValue("@agel5", agel5.Text);
            cmd1.Parameters.AddWithValue("@agel82", agel82.Text);
            cmd1.Parameters.AddWithValue("@agel_hkomy", agel_hkomy.Text);
            cmd1.Parameters.AddWithValue("@ksm_mas", ksm_mas.Text);
            cmd1.Parameters.AddWithValue("@yom12", yom12.Text);
            cmd1.Parameters.AddWithValue("@haq_cus", haq_cus.Text);
            cmd1.Parameters.AddWithValue("@motgawez", motgawez.Text);
            cmd1.Parameters.AddWithValue("@b_c", b_c.Text);
            cmd1.Parameters.AddWithValue("@ksm_sher1 ", ksm_sher1.SelectedValue);
            cmd1.Parameters.AddWithValue("@sh1_ksm", sh1_ksm.Text);
            cmd1.Parameters.AddWithValue("@ksm_sher2", ksm_sher2.SelectedValue);
            cmd1.Parameters.AddWithValue("@sh2_ksm", sh2_ksm.Text);
            cmd1.Parameters.AddWithValue("@ksm_sher3 ", ksm_sher3.SelectedValue);
            cmd1.Parameters.AddWithValue("@sh3_ksm", sh3_ksm.Text);
            cmd1.Parameters.AddWithValue("@ksm_sher4", ksm_sher4.SelectedValue);
            cmd1.Parameters.AddWithValue("@sh4_ksm", sh4_ksm.Text);
            cmd1.Parameters.AddWithValue("@ksm_sher5", ksm_sher5.SelectedValue);
            cmd1.Parameters.AddWithValue("@sh5_ksm", sh5_ksm.Text);
            cmd1.Parameters.AddWithValue("@ksm_sher6", ksm_sher6.SelectedValue);
            cmd1.Parameters.AddWithValue("@sh6_ksm", sh6_ksm.Text);
            cmd1.Parameters.AddWithValue("@ksm_sher7", ksm_sher7.SelectedValue);
            cmd1.Parameters.AddWithValue("@sh7_ksm", sh7_ksm.Text);
            cmd1.Parameters.AddWithValue("@ksm_sher8", ksm_sher8.SelectedValue);
            cmd1.Parameters.AddWithValue("@sh8_ksm", sh8_ksm.Text);
            cmd1.Parameters.AddWithValue("@ksm_sher9", ksm_sher9.SelectedValue);
            cmd1.Parameters.AddWithValue("@sh9_ksm", sh9_ksm.Text);
            cmd1.Parameters.AddWithValue("@ksm_sher10", ksm_sher10.SelectedValue);
            cmd1.Parameters.AddWithValue("@sh10_ksm ", sh10_ksm.Text);
            cmd1.Parameters.AddWithValue("@ksm_youm", ksm_youm.Text);
            cmd1.Parameters.AddWithValue("@ksm_asn", ksm_asn.Text);
            cmd1.Parameters.AddWithValue("@ksm_hosb", ksm_hosb.Text);
            cmd1.Parameters.AddWithValue("@ksm_mortbat", ksm_mortbat.Text);
            cmd1.Parameters.AddWithValue("@ksm_deal_month", ksm_deal_month.Text);
            cmd1.Parameters.AddWithValue("@ksm_deal_qur", ksm_deal_qur.Text);
            cmd1.Parameters.AddWithValue("@ksm_deal_6", ksm_deal_6.Text);
            cmd1.Parameters.AddWithValue("@tas_hosb", tas_hosb.Text);
            cmd1.Parameters.AddWithValue("@d_a_t", d_a_t.Text);
            cmd1.Parameters.AddWithValue("@es_sabeq", es_sabeq.Text);
            cmd1.Parameters.AddWithValue("@morabha", morabha.Text);
            cmd1.Parameters.AddWithValue("@tawg_mor", tawg_mor.Text);
            cmd1.Parameters.AddWithValue("@sharq_7", sharq_78.Text);
            cmd1.Parameters.AddWithValue("@sharq_8", sharq_8.Text);
            cmd1.Parameters.AddWithValue("@sdad_sk", sadad_sk.Text);
            cmd1.Parameters.AddWithValue("@tawg_last_year", tawg_last_year.Text);
            cmd1.Parameters.AddWithValue("@tawg_ksm_sabeq", tawg_ksm_sabeq.Text);
            cmd1.Parameters.AddWithValue("@twag_mor_sab", twag_mor_sab.Text);
            cmd1.Parameters.AddWithValue("@br4_daen", br4_daen.SelectedValue);
            cmd1.Parameters.AddWithValue("@br4_ksm", br4_ksm.Text);
            cmd1.Parameters.AddWithValue("@br5_daen", br5_daen.SelectedValue);
            cmd1.Parameters.AddWithValue("@br5_ksm", br5_ksm.Text);
            cmd1.Parameters.AddWithValue("@br6_daen", br6_daen.SelectedValue);
            cmd1.Parameters.AddWithValue("@br6_ksm", br6_ksm.Text);
            cmd1.Parameters.AddWithValue("@last_balance", last_balance.Text);
            cmd1.Parameters.AddWithValue("@tas_madena", tas_madena.Text);
            cmd1.Parameters.AddWithValue("@tas_madena_name", tas_madena_name.Text);
            cmd1.Parameters.AddWithValue("@tas_daena", tas_daena.Text);
            cmd1.Parameters.AddWithValue("@ta_da_na", ta_da_na.Text);
            cmd1.Parameters.AddWithValue("@sh_d_m", sh_d_m.SelectedValue);
            cmd1.Parameters.AddWithValue("@shname1", this.ksm_sher1.GetItemText(this.ksm_sher1.SelectedItem));
            cmd1.Parameters.AddWithValue("@shcode1", shc1.Text);
            cmd1.Parameters.AddWithValue("@shname2", this.ksm_sher2.GetItemText(this.ksm_sher2.SelectedItem));
            cmd1.Parameters.AddWithValue("@shcode2", shc2.Text);
            cmd1.Parameters.AddWithValue("@shname3", this.ksm_sher3.GetItemText(this.ksm_sher3.SelectedItem));
            cmd1.Parameters.AddWithValue("@shcode3", shc3.Text);
            cmd1.Parameters.AddWithValue("@shname4", this.ksm_sher4.GetItemText(this.ksm_sher4.SelectedItem));
            cmd1.Parameters.AddWithValue("@shcode4", shc4.Text);
            cmd1.Parameters.AddWithValue("@shname5", this.ksm_sher5.GetItemText(this.ksm_sher5.SelectedItem));
            cmd1.Parameters.AddWithValue("@shcode5", shc5.Text);
            cmd1.Parameters.AddWithValue("@shname6", this.ksm_sher6.GetItemText(this.ksm_sher6.SelectedItem));
            cmd1.Parameters.AddWithValue("@shcode6", shc6.Text);
            cmd1.Parameters.AddWithValue("@shname7", this.ksm_sher7.GetItemText(this.ksm_sher7.SelectedItem));
            cmd1.Parameters.AddWithValue("@shcode7", shc7.Text);
            cmd1.Parameters.AddWithValue("@shname8", this.ksm_sher8.GetItemText(this.ksm_sher8.SelectedItem));
            cmd1.Parameters.AddWithValue("@shcode8", shc8.Text);
            cmd1.Parameters.AddWithValue("@shname9", this.ksm_sher9.GetItemText(this.ksm_sher9.SelectedItem));
            cmd1.Parameters.AddWithValue("@shcode9", shc9.Text);
            cmd1.Parameters.AddWithValue("@shname10", this.ksm_sher10.GetItemText(this.ksm_sher10.SelectedItem));
            cmd1.Parameters.AddWithValue("@shcode10", shc10.Text);
            cmd1.Parameters.AddWithValue("@branname1", this.br1_madin.GetItemText(this.br1_madin.SelectedItem));
            cmd1.Parameters.AddWithValue("@brancode1", br1_madin.SelectedValue);
            cmd1.Parameters.AddWithValue("@branname2", this.br2_madin.GetItemText(this.br2_madin.SelectedItem));
            cmd1.Parameters.AddWithValue("@brancode2", br2_madin.SelectedValue);
            cmd1.Parameters.AddWithValue("@branname3", this.br3_madin.GetItemText(this.br3_madin.SelectedItem));
            cmd1.Parameters.AddWithValue("@brancode3", br3_madin.SelectedValue);
            cmd1.Parameters.AddWithValue("@branname4", this.br4_madin.GetItemText(this.br4_madin.SelectedItem));
            cmd1.Parameters.AddWithValue("@brancode4", br4_madin.SelectedValue);
            cmd1.Parameters.AddWithValue("@branname5", this.br4_daen.GetItemText(this.br4_daen.SelectedItem));
            cmd1.Parameters.AddWithValue("@brancode5", br4_daen.SelectedValue);
            cmd1.Parameters.AddWithValue("@branname6", this.br5_daen.GetItemText(this.br5_daen.SelectedItem));
            cmd1.Parameters.AddWithValue("@brancode6", br5_daen.SelectedValue);
            cmd1.Parameters.AddWithValue("@branname7", this.br6_daen.GetItemText(this.br6_daen.SelectedItem));
            cmd1.Parameters.AddWithValue("@brancode7", br6_daen.SelectedValue);
            cmd1.Parameters.AddWithValue("@darname", this.sh_d_m.GetItemText(this.sh_d_m.SelectedItem));
            cmd1.Parameters.AddWithValue("@darcode", dac.Text);
            this.Cursor = Cursors.WaitCursor;
            if (branch.SelectedIndex != -1)
            {
                DataTable tbl = new DataTable();
                tbl = db.runquery("select branch_id,t_month,t_year from Customers where branch_id='" + branch.SelectedValue + "' and t_month='" + t_month.Text + "' and t_year='" + t_year.Text + "' ");
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
                            UserEntry_Load(null, null);
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
                        this.Cursor = Cursors.Default;
                    }
                }
            }
            else
                MessageBox.Show("يجب اختيار الفرع أولاً");
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
        private void insert_local()
        {

            SqlCeCommand cmd1;

            cmd1 = new SqlCeCommand("INSERT INTO Customers (branch_id, t_month, t_year, first_balance, [sales-ad], sales_as, return_mor, ta_mor, tak_tam, ziadat_nk, ziadat_esarat, ziadat_esarat_mor, ziadat_ksm, br1_madin, br1_ksm, br2_madin, br2_ksm, br3_madin, br3_ksm, br4_madin, br4m_ksm, gad_haly, gad_mokdm, eada_tah, mas_gad, mas_eada, sader_d_m, mortagaat_ad, mortagaat_as, nakdy4, nakdy44, agel71, agel5, agel82, agel_hkomy, ksm_mas, yom12, haq_cus, motgawez, b_c, ksm_sher1, sh1_ksm, ksm_sher2, sh2_ksm, ksm_sher3, sh3_ksm, ksm_sher4, sh4_ksm, ksm_sher5, sh5_ksm, ksm_sher6, sh6_ksm, ksm_sher7, sh7_ksm, ksm_sher8, sh8_ksm, ksm_sher9, sh9_ksm, ksm_sher10, sh10_ksm, ksm_youm, ksm_asn, ksm_hosb, ksm_mortbat, ksm_deal_month, ksm_deal_qur, ksm_deal_6, tas_hosb, d_a_t, es_sabeq, morabha, tawg_mor, sharq_78, sharq_8, sdad_sk, tawg_last_year, tawg_ksm_sabeq, twag_mor_sab, br4_daen, br4_ksm, br5_daen, br5_ksm, br6_daen, br6_ksm, last_balance, tas_madena, tas_madena_name, tas_daena, ta_da_na, sh_d_m, shname1, shcode1, shname2, shcode2, shname3, shcode3, shname4, shcode4, shname5, shcode5, shname6, shcode6, shname7, shcode7, shname8, shcode8, shname9, shcode9, shname10, shcode10, branname1, brancode1, branname2, brancode2, branname3, brancode3, branname4, brancode4, branname5, brancode5, branname6, brancode6, branname7, brancode7, darname, darcode) VALUES   (@branch_id,@t_month,@t_year,@first_balance,@sales_ad ,@sales_as,@return_mor,@ta_mor,@tak_tam,@ziadat_nk,@ziadat_esarat,@ziadat_esarat_mor,@ziadat_ksm,@br1_madin,@br1_ksm,@br2_madin,@br2_ksm,@br3_madin,@br3_ksm,@br4_madin,@br4m_ksm,@gad_haly,@gad_mokdm,@eada_tah,@mas_gad,@mas_eada,@sader_d_m,@mortagaat_ad,@mortagaat_as,@nakdy4,@nakdy44,@agel71,@agel5,@agel82,@agel_hkomy,@ksm_mas,@yom12,@haq_cus,@motgawez,@b_c,@ksm_sher1,@sh1_ksm,@ksm_sher2,@sh2_ksm,@ksm_sher3,@sh3_ksm,@ksm_sher4,@sh4_ksm,@ksm_sher5,@sh5_ksm,@ksm_sher6,@sh6_ksm,@ksm_sher7,@sh7_ksm,@ksm_sher8,@sh8_ksm,@ksm_sher9,@sh9_ksm,@ksm_sher10,@sh10_ksm,@ksm_youm,@ksm_asn,@ksm_hosb,@ksm_mortbat,@ksm_deal_month,@ksm_deal_qur,@ksm_deal_6,@tas_hosb,@d_a_t,@es_sabeq,@morabha,@tawg_mor,@sharq_7,@sharq_8,@sdad_sk,@tawg_last_year,@tawg_ksm_sabeq,@twag_mor_sab,@br4_daen,@br4_ksm,@br5_daen,@br5_ksm,@br6_daen,@br6_ksm,@last_balance,@tas_madena,@tas_madena_name,@tas_daena,@ta_da_na,@sh_d_m,@shname1,@shcode1,@shname2,@shcode2,@shname3,@shcode3,@shname4,@shcode4,@shname5,@shcode5,@shname6,@shcode6,@shname7,@shcode7,@shname8,@shcode8,@shname9,@shcode9,@shname10,@shcode10,@branname1,@brancode1,@branname2,@brancode2,@branname3,@brancode3,@branname4,@brancode4,@branname5,@brancode5,@branname6,@brancode6,@branname7,@brancode7,@darname,@darcode)", db.con);
            cmd1.Parameters.AddWithValue("@branch_id", branch.SelectedValue);
            cmd1.Parameters.AddWithValue("@t_month", t_month.Text);
            cmd1.Parameters.AddWithValue("@t_year", t_year.Text);
            cmd1.Parameters.AddWithValue("@first_balance", Fbalance.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@sales_ad", sales_ad.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@sales_as", sales_as.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@return_mor", return_mor.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@ta_mor", ta_mor.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@tak_tam", tak_tam.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@ziadat_nk", ziadat_nk.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@ziadat_esarat", ziadat_esarat.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@ziadat_esarat_mor", ziadat_esarat_mor.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@ziadat_ksm", ziadat_ksm.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@br1_madin", br1_madin.SelectedValue ?? DBNull.Value);
            cmd1.Parameters.AddWithValue("@br1_ksm", br1_ksm.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@br2_madin", br2_madin.SelectedValue ?? DBNull.Value);
            cmd1.Parameters.AddWithValue("@br2_ksm", br2_ksm.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@br3_madin", br3_madin.SelectedValue ?? DBNull.Value);
            cmd1.Parameters.AddWithValue("@br3_ksm", br3_ksm.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@br4_madin", br4_madin.SelectedValue ?? DBNull.Value);
            cmd1.Parameters.AddWithValue("@br4m_ksm", br4m_ksm.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@gad_haly", gad_haly.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@gad_mokdm", gad_mokdm.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@eada_tah", eada_tah.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@mas_gad", mas_gad.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@mas_eada", mas_eada.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@sader_d_m", sader_d_m.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@mortagaat_ad", mortagaat_ad.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@mortagaat_as", mortagaat_as.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@nakdy4", nakdy4.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@nakdy44", nakdy44.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@agel71", agel71.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@agel5", agel5.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@agel82", agel82.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@agel_hkomy", agel_hkomy.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@ksm_mas", ksm_mas.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@yom12", yom12.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@haq_cus", haq_cus.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@motgawez", motgawez.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@b_c", b_c.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@ksm_sher1", ksm_sher1.SelectedValue ?? DBNull.Value);
            cmd1.Parameters.AddWithValue("@sh1_ksm", sh1_ksm.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@ksm_sher2", ksm_sher2.SelectedValue ?? DBNull.Value);
            cmd1.Parameters.AddWithValue("@sh2_ksm", sh2_ksm.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@ksm_sher3", ksm_sher3.SelectedValue ?? DBNull.Value);
            cmd1.Parameters.AddWithValue("@sh3_ksm", sh3_ksm.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@ksm_sher4", ksm_sher4.SelectedValue ?? DBNull.Value);
            cmd1.Parameters.AddWithValue("@sh4_ksm", sh4_ksm.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@ksm_sher5", ksm_sher5.SelectedValue ?? DBNull.Value);
            cmd1.Parameters.AddWithValue("@sh5_ksm", sh5_ksm.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@ksm_sher6", ksm_sher6.SelectedValue ?? DBNull.Value);
            cmd1.Parameters.AddWithValue("@sh6_ksm", sh6_ksm.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@ksm_sher7", ksm_sher7.SelectedValue ?? DBNull.Value);
            cmd1.Parameters.AddWithValue("@sh7_ksm", sh7_ksm.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@ksm_sher8", ksm_sher8.SelectedValue ?? DBNull.Value);
            cmd1.Parameters.AddWithValue("@sh8_ksm", sh8_ksm.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@ksm_sher9", ksm_sher9.SelectedValue ?? DBNull.Value);
            cmd1.Parameters.AddWithValue("@sh9_ksm", sh9_ksm.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@ksm_sher10", ksm_sher10.SelectedValue ?? DBNull.Value);
            cmd1.Parameters.AddWithValue("@sh10_ksm", sh10_ksm.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@ksm_youm", ksm_youm.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@ksm_asn", ksm_asn.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@ksm_hosb", ksm_hosb.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@ksm_mortbat", ksm_mortbat.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@ksm_deal_month", ksm_deal_month.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@ksm_deal_qur", ksm_deal_qur.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@ksm_deal_6", ksm_deal_6.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@tas_hosb", tas_hosb.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@d_a_t", d_a_t.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@es_sabeq", es_sabeq.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@morabha", morabha.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@tawg_mor", tawg_mor.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@sharq_7", sharq_78.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@sharq_8", sharq_8.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@sdad_sk", sadad_sk.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@tawg_last_year", tawg_last_year.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@tawg_ksm_sabeq", tawg_ksm_sabeq.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@twag_mor_sab", twag_mor_sab.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@br4_daen", br4_daen.SelectedValue ?? DBNull.Value);
            cmd1.Parameters.AddWithValue("@br4_ksm", br4_ksm.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@br5_daen", br5_daen.SelectedValue ?? DBNull.Value);
            cmd1.Parameters.AddWithValue("@br5_ksm", br5_ksm.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@br6_daen", br6_daen.SelectedValue ?? DBNull.Value);
            cmd1.Parameters.AddWithValue("@br6_ksm", br6_ksm.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@last_balance", last_balance.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@tas_madena", tas_madena.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@tas_madena_name", tas_madena_name.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@tas_daena", tas_daena.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@ta_da_na", ta_da_na.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@sh_d_m", sh_d_m.SelectedValue ?? DBNull.Value);
            cmd1.Parameters.AddWithValue("@shname1", this.ksm_sher1.GetItemText(this.ksm_sher1.SelectedItem) ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@shcode1", shc1.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@shname2", this.ksm_sher2.GetItemText(this.ksm_sher2.SelectedItem) ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@shcode2", shc2.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@shname3", this.ksm_sher3.GetItemText(this.ksm_sher3.SelectedItem) ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@shcode3", shc3.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@shname4", this.ksm_sher4.GetItemText(this.ksm_sher4.SelectedItem) ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@shcode4", shc4.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@shname5", this.ksm_sher5.GetItemText(this.ksm_sher5.SelectedItem) ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@shcode5", shc5.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@shname6", this.ksm_sher6.GetItemText(this.ksm_sher6.SelectedItem) ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@shcode6", shc6.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@shname7", this.ksm_sher7.GetItemText(this.ksm_sher7.SelectedItem) ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@shcode7", shc7.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@shname8", this.ksm_sher8.GetItemText(this.ksm_sher8.SelectedItem) ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@shcode8", shc8.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@shname9", this.ksm_sher9.GetItemText(this.ksm_sher9.SelectedItem) ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@shcode9", shc9.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@shname10", this.ksm_sher10.GetItemText(this.ksm_sher10.SelectedItem) ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@shcode10", shc10.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@branname1", this.br1_madin.GetItemText(this.br1_madin.SelectedItem) ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@brancode1", br1_madin.SelectedValue ?? DBNull.Value);
            cmd1.Parameters.AddWithValue("@branname2", this.br2_madin.GetItemText(this.br2_madin.SelectedItem) ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@brancode2", br2_madin.SelectedValue ?? DBNull.Value);
            cmd1.Parameters.AddWithValue("@branname3", this.br3_madin.GetItemText(this.br3_madin.SelectedItem) ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@brancode3", br3_madin.SelectedValue ?? DBNull.Value);
            cmd1.Parameters.AddWithValue("@branname4", this.br4_madin.GetItemText(this.br4_madin.SelectedItem) ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@brancode4", br4_madin.SelectedValue ?? DBNull.Value);
            cmd1.Parameters.AddWithValue("@branname5", this.br4_daen.GetItemText(this.br4_daen.SelectedItem) ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@brancode5", br4_daen.SelectedValue ?? DBNull.Value);
            cmd1.Parameters.AddWithValue("@branname6", this.br5_daen.GetItemText(this.br5_daen.SelectedItem) ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@brancode6", br5_daen.SelectedValue ?? DBNull.Value);
            cmd1.Parameters.AddWithValue("@branname7", this.br6_daen.GetItemText(this.br6_daen.SelectedItem) ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@brancode7", br6_daen.SelectedValue ?? DBNull.Value);
            cmd1.Parameters.AddWithValue("@darname", this.sh_d_m.GetItemText(this.sh_d_m.SelectedItem) ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@darcode", dac.Text ?? DBNull.Value.ToString());
            if (branch.SelectedIndex != -1)
            {
                DataTable tbl = new DataTable();
                tbl = db.Ce_runquery("select branch_id,t_month,t_year from Customers where branch_id='" + branch.SelectedValue + "' and t_month='" + t_month.Text + "' and t_year='" + t_year.Text + "' ");
                if (tbl.Rows.Count == 1)
                    MessageBox.Show("تم تسجيل البيانات من قبل");
                else
                {
                    try
                    {
                        db.con.Open();
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("الرجاء الانتظار قليلاً حتى يتم تحديث البيانات أون لاين");
                        db.con.Close();
                        loaddata();
                        //UserEntry_Load(null, null);
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

        #region MyRegion
        private void Fbalance_KeyPress(object sender, KeyPressEventArgs e)
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
        private void Fbalance_Leave(object sender, EventArgs e)
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
            tas_hosb1.Text = (Convert.ToDecimal(tas_hosb.Text) + Convert.ToDecimal(sharq_78.Text)).ToString();
            youm96.Text = (Convert.ToDecimal(ksm_deal_month.Text) + Convert.ToDecimal(ksm_deal_qur.Text)).ToString();
            yoim79.Text = (Convert.ToDecimal(gad_haly.Text) + Convert.ToDecimal(gad_mokdm.Text) + Convert.ToDecimal(eada_tah.Text) + Convert.ToDecimal(mas_eada.Text) + Convert.ToDecimal(mas_gad.Text)).ToString();
            youm17.Text = (Convert.ToDouble(sh1_ksm.Text) + Convert.ToDouble(sh2_ksm.Text) + Convert.ToDouble(sh3_ksm.Text) + Convert.ToDouble(sh4_ksm.Text) + Convert.ToDouble(sh5_ksm.Text) + Convert.ToDouble(sh6_ksm.Text) + Convert.ToDouble(sh7_ksm.Text) + Convert.ToDouble(sh8_ksm.Text) + Convert.ToDouble(sh9_ksm.Text) + Convert.ToDouble(sh10_ksm.Text)).ToString();

            youm8.Text = ((Convert.ToDouble(br4_ksm.Text) + Convert.ToDouble(br5_ksm.Text) + Convert.ToDouble(br6_ksm.Text) + Convert.ToDouble(tas_daena.Text) + Convert.ToDouble(sharq_8.Text)) - (Convert.ToDouble(br1_ksm.Text) + Convert.ToDouble(br2_ksm.Text) + Convert.ToDouble(br3_ksm.Text) + Convert.ToDouble(br4m_ksm.Text) + Convert.ToDouble(tas_madena.Text) + Convert.ToDouble(sader_d_m.Text))).ToString();



        }

        private void yom8ssafy()
        {
            double br1m = 0;
            double.TryParse(br1_ksm.Text, out br1m);
            double br2m = 0;
            double.TryParse(br2_ksm.Text, out br2m);
            double br3m = 0;
            double.TryParse(br3_ksm.Text, out br3m);
            double br4m = 0;
            double.TryParse(br4m_ksm.Text, out br4m);
            double sader = 0;
            double.TryParse(sader_d_m.Text, out sader);
            double tam = 0;
            double.TryParse(tas_madena.Text, out tam);
            double br4d = 0;
            double.TryParse(br4_ksm.Text, out br4d);
            double br5d = 0;
            double.TryParse(br5_ksm.Text, out br5d);
            double br6d = 0;
            double.TryParse(br6_ksm.Text, out br6d);
            double shr = 0;
            double.TryParse(sharq_8.Text, out shr);
            double tad = 0;
            double.TryParse(tas_daena.Text, out tad);
            saf_8.Text = String.Format("{0:0,0.000}", ((br4d + br5d + br6d + shr + tad) - (br1m + br2m + br3m + br4m + sader + tam)));
        }
        private void br1_madin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
                return;
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void gad_haly_TextChanged(object sender, EventArgs e)
        {

        }

        private void gad_mokdm_TextChanged(object sender, EventArgs e)
        {

        }

        private void eada_tah_TextChanged(object sender, EventArgs e)
        {

        }

        private void ksm_sher1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ksm_sher1.SelectedIndex == -1)
                shc1.Text = "0";
        }
        private void ksm_sher1_Leave(object sender, EventArgs e)
        {
            if (ksm_sher1.SelectedIndex != -1)
            {
                shc1.Text = shcode(ksm_sher1.SelectedValue.ToString());
                shnmae1.Text = this.ksm_sher1.GetItemText(this.ksm_sher1.SelectedItem);
            }
            else
                shc1.Text = "0";
        }
        private string shcode(string cbmselect)
        {
            SqlCeCommand cmd = new SqlCeCommand("select kh from sherka where shcode='" + cbmselect + "' ", db.con);
            DataTable tbl = new DataTable();

            try
            {
                db.con.Open();
                tbl.Load(cmd.ExecuteReader());
                db.con.Close();
            }
            catch (SqlCeException ex)
            {

                MessageBox.Show(ex.Message);
                db.con.Close();
            }
            string sh;
            sh = (tbl.Rows[0][0]).ToString();
            return sh;
        }

        private void ksm_sher2_Leave(object sender, EventArgs e)
        {
            if (ksm_sher2.SelectedIndex != -1)
                shc2.Text = shcode(ksm_sher2.SelectedValue.ToString());
            else
                shc2.Text = "0";
        }

        private void ksm_sher3_Leave(object sender, EventArgs e)
        {
            if (ksm_sher3.SelectedIndex != -1)
                shc3.Text = shcode(ksm_sher3.SelectedValue.ToString());
            else
                shc3.Text = "0";
        }

        private void ksm_sher4_Leave(object sender, EventArgs e)
        {
            if (ksm_sher4.SelectedIndex != -1)
                shc4.Text = shcode(ksm_sher4.SelectedValue.ToString());
            else
                shc4.Text = "0";
        }

        private void ksm_sher5_Leave(object sender, EventArgs e)
        {
            if (ksm_sher5.SelectedIndex != -1)
                shc5.Text = shcode(ksm_sher5.SelectedValue.ToString());
            else
                shc5.Text = "0";
        }

        private void ksm_sher6_Leave(object sender, EventArgs e)
        {
            if (ksm_sher6.SelectedIndex != -1)
                shc6.Text = shcode(ksm_sher6.SelectedValue.ToString());
            else
                shc6.Text = "0";
        }

        private void ksm_sher7_Leave(object sender, EventArgs e)
        {
            if (ksm_sher7.SelectedIndex != -1)
                shc7.Text = shcode(ksm_sher7.SelectedValue.ToString());
            else
                shc7.Text = "0";
        }

        private void ksm_sher8_Leave(object sender, EventArgs e)
        {
            if (ksm_sher8.SelectedIndex != -1)
                shc8.Text = shcode(ksm_sher8.SelectedValue.ToString());
            else
                shc8.Text = "0";
        }

        private void ksm_sher9_Leave(object sender, EventArgs e)
        {
            if (ksm_sher9.SelectedIndex != -1)
                shc9.Text = shcode(ksm_sher9.SelectedValue.ToString());
            else
                shc9.Text = "0";
        }

        private void ksm_sher10_Leave(object sender, EventArgs e)
        {
            if (ksm_sher10.SelectedIndex != -1)
                shc10.Text = shcode(ksm_sher10.SelectedValue.ToString());
            else
                shc10.Text = "0";
        }


        private void ksm_sher3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
                return;
            }

        }

        private void tot()
        {
            double mad = Convert.ToDouble(Fbalance.Text) + Convert.ToDouble(sales_ad.Text) + Convert.ToDouble(sales_as.Text) + Convert.ToDouble(return_mor.Text) + Convert.ToDouble(ta_mor.Text) + Convert.ToDouble(tak_tam.Text) + Convert.ToDouble(ziadat_nk.Text) + Convert.ToDouble(ziadat_esarat.Text) + Convert.ToDouble(ziadat_esarat_mor.Text) + Convert.ToDouble(ziadat_ksm.Text) + Convert.ToDouble(br1_ksm.Text) + Convert.ToDouble(br2_ksm.Text) + Convert.ToDouble(br3_ksm.Text) + Convert.ToDouble(br4m_ksm.Text) + Convert.ToDouble(gad_haly.Text) + Convert.ToDouble(gad_mokdm.Text) + Convert.ToDouble(eada_tah.Text) + Convert.ToDouble(mas_gad.Text) + Convert.ToDouble(mas_eada.Text) + Convert.ToDouble(sader_d_m.Text) + Convert.ToDouble(tas_madena.Text);
            double mas = (Convert.ToDouble(ksm_mas.Text) + Convert.ToDouble(yom12.Text) + Convert.ToDouble(ziadat_ksm.Text) - Convert.ToDouble(tawg_ksm_sabeq.Text));
            double dae = mas + Convert.ToDouble(tawg_ksm_sabeq.Text) + Convert.ToDouble(mortagaat_ad.Text) + Convert.ToDouble(mortagaat_as.Text) + Convert.ToDouble(nakdy4.Text) + Convert.ToDouble(nakdy44.Text) + Convert.ToDouble(agel71.Text) + Convert.ToDouble(agel5.Text) + Convert.ToDouble(agel82.Text) + Convert.ToDouble(agel_hkomy.Text) + Convert.ToDouble(haq_cus.Text) + Convert.ToDouble(motgawez.Text) + Convert.ToDouble(b_c.Text) + Convert.ToDouble(sh1_ksm.Text) + Convert.ToDouble(sh2_ksm.Text) + Convert.ToDouble(sh3_ksm.Text) + Convert.ToDouble(sh4_ksm.Text) + Convert.ToDouble(sh5_ksm.Text) + Convert.ToDouble(sh6_ksm.Text) + Convert.ToDouble(sh7_ksm.Text) + Convert.ToDouble(sh8_ksm.Text) + Convert.ToDouble(sh9_ksm.Text) + Convert.ToDouble(sh10_ksm.Text) + Convert.ToDouble(ksm_youm.Text) + Convert.ToDouble(ksm_asn.Text) + Convert.ToDouble(ksm_hosb.Text) + Convert.ToDouble(ksm_mortbat.Text) + Convert.ToDouble(ksm_deal_month.Text) + Convert.ToDouble(ksm_deal_qur.Text) + Convert.ToDouble(ksm_deal_6.Text) + Convert.ToDouble(tas_hosb.Text) + Convert.ToDouble(d_a_t.Text) + Convert.ToDouble(es_sabeq.Text) + Convert.ToDouble(morabha.Text) + Convert.ToDouble(tawg_mor.Text) + Convert.ToDouble(sharq_78.Text) + Convert.ToDouble(sharq_8.Text) + Convert.ToDouble(sadad_sk.Text) + Convert.ToDouble(tawg_last_year.Text) + Convert.ToDouble(twag_mor_sab.Text) + Convert.ToDouble(br4_ksm.Text) + Convert.ToDouble(br5_ksm.Text) + Convert.ToDouble(br6_ksm.Text) + Convert.ToDouble(last_balance.Text) + Convert.ToDouble(tas_daena.Text);
            txtDae.Text = String.Format("{0:0,0.000}", dae).ToString();
            txtMad.Text = String.Format("{0:0,0.000}", mad).ToString();
            txtmas.Text = String.Format("{0:0,0.000}", mas).ToString();
            double farq = mad - dae;
            fr.Text = String.Format("{0:0,0.000}", farq).ToString();
            double ally = Convert.ToDouble(nakdy4.Text) + Convert.ToDouble(agel5.Text) + Convert.ToDouble(ksm_mas.Text) + Convert.ToDouble(youm8.Text) + Convert.ToDouble(yom12.Text) + Convert.ToDouble(ksm_youm.Text) + Convert.ToDouble(youm17.Text) + Convert.ToDouble(morabha.Text) + Convert.ToDouble(nakdy44.Text) + Convert.ToDouble(ksm_asn.Text) + Convert.ToDouble(b_c.Text) - Convert.ToDouble(tak_tam.Text) + Convert.ToDouble(agel71.Text) + Convert.ToDouble(motgawez.Text) + Convert.ToDouble(tas_hosb1.Text) - Convert.ToDouble(yoim79.Text) + Convert.ToDouble(agel82.Text) + Convert.ToDouble(youm96.Text) + Convert.ToDouble(d_a_t.Text) + Convert.ToDouble(ksm_hosb.Text) + Convert.ToDouble(ksm_mortbat.Text) + Convert.ToDouble(haq_cus.Text) + Convert.ToDouble(ksm_deal_6.Text) + Convert.ToDouble(agel_hkomy.Text)+Convert.ToDouble(youm10.Text);
            textBox2.Text = String.Format("{0:0,0.000}", ally).ToString();
        }

        private void sh_d_m_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sh_d_m_Leave(object sender, EventArgs e)
        {
            if (sh_d_m.SelectedIndex != -1)
                dac.Text = shcode(sh_d_m.SelectedValue.ToString());
            else
                dac.Text = "";
        }
        #endregion

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

        private void button10_Click(object sender, EventArgs e)
        {
            newentry(tabControl1);

        }



        private void button12_Click(object sender, EventArgs e) // update
        {


            UpdateLocal();
            SqlCommand cmd1 = new SqlCommand("spUpdateCustomers", conn);
            cmd1.CommandType = CommandType.StoredProcedure;
            //cmd1.Parameters.Clear();
            cmd1.Parameters.AddWithValue("@branch_id", branch.SelectedValue);
            cmd1.Parameters.AddWithValue("@t_month", t_month.Text);
            cmd1.Parameters.AddWithValue("@t_year", t_year.Text);
            cmd1.Parameters.AddWithValue("@first_balance", Fbalance.Text);
            cmd1.Parameters.AddWithValue("@sales_ad", sales_ad.Text);
            cmd1.Parameters.AddWithValue("@sales_as", sales_as.Text);
            cmd1.Parameters.AddWithValue("@return_mor ", return_mor.Text);
            cmd1.Parameters.AddWithValue("@ta_mor", ta_mor.Text);
            cmd1.Parameters.AddWithValue("@tak_tam", tak_tam.Text);
            cmd1.Parameters.AddWithValue("@ziadat_nk", ziadat_nk.Text);
            cmd1.Parameters.AddWithValue("@ziadat_esarat", ziadat_esarat.Text);
            cmd1.Parameters.AddWithValue("@ziadat_esarat_mor", ziadat_esarat_mor.Text);
            cmd1.Parameters.AddWithValue("@ziadat_ksm", ziadat_ksm.Text);
            cmd1.Parameters.AddWithValue("@br1_madin", br1_madin.SelectedValue);
            cmd1.Parameters.AddWithValue("@br1_ksm", br1_ksm.Text);
            cmd1.Parameters.AddWithValue("@br2_madin", br2_madin.SelectedValue);
            cmd1.Parameters.AddWithValue("@br2_ksm", br2_ksm.Text);
            cmd1.Parameters.AddWithValue("@br3_madin", br3_madin.SelectedValue);
            cmd1.Parameters.AddWithValue("@br3_ksm", br3_ksm.Text);
            cmd1.Parameters.AddWithValue("@br4_madin", br4_madin.SelectedValue);
            cmd1.Parameters.AddWithValue("@br4m_ksm", br4m_ksm.Text);
            cmd1.Parameters.AddWithValue("@gad_haly", gad_haly.Text);
            cmd1.Parameters.AddWithValue("@gad_mokdm", gad_mokdm.Text);
            cmd1.Parameters.AddWithValue("@eada_tah", eada_tah.Text);
            cmd1.Parameters.AddWithValue("@mas_gad ", mas_gad.Text);
            cmd1.Parameters.AddWithValue("@mas_eada ", mas_eada.Text);
            cmd1.Parameters.AddWithValue("@sader_d_m", sader_d_m.Text);
            cmd1.Parameters.AddWithValue("@mortagaat_ad", mortagaat_ad.Text);
            cmd1.Parameters.AddWithValue("@mortagaat_as ", mortagaat_as.Text);
            cmd1.Parameters.AddWithValue("@nakdy4", nakdy4.Text);
            cmd1.Parameters.AddWithValue("@nakdy44", nakdy44.Text);
            cmd1.Parameters.AddWithValue("@agel71", agel71.Text);
            cmd1.Parameters.AddWithValue("@agel5", agel5.Text);
            cmd1.Parameters.AddWithValue("@agel82", agel82.Text);
            cmd1.Parameters.AddWithValue("@agel_hkomy", agel_hkomy.Text);
            cmd1.Parameters.AddWithValue("@ksm_mas", ksm_mas.Text);
            cmd1.Parameters.AddWithValue("@yom12", yom12.Text);
            cmd1.Parameters.AddWithValue("@haq_cus", haq_cus.Text);
            cmd1.Parameters.AddWithValue("@motgawez", motgawez.Text);
            cmd1.Parameters.AddWithValue("@b_c", b_c.Text);
            cmd1.Parameters.AddWithValue("@ksm_sher1 ", ksm_sher1.SelectedValue);
            cmd1.Parameters.AddWithValue("@sh1_ksm", sh1_ksm.Text);
            cmd1.Parameters.AddWithValue("@ksm_sher2", ksm_sher2.SelectedValue);
            cmd1.Parameters.AddWithValue("@sh2_ksm", sh2_ksm.Text);
            cmd1.Parameters.AddWithValue("@ksm_sher3 ", ksm_sher3.SelectedValue);
            cmd1.Parameters.AddWithValue("@sh3_ksm", sh3_ksm.Text);
            cmd1.Parameters.AddWithValue("@ksm_sher4", ksm_sher4.SelectedValue);
            cmd1.Parameters.AddWithValue("@sh4_ksm", sh4_ksm.Text);
            cmd1.Parameters.AddWithValue("@ksm_sher5", ksm_sher5.SelectedValue);
            cmd1.Parameters.AddWithValue("@sh5_ksm", sh5_ksm.Text);
            cmd1.Parameters.AddWithValue("@ksm_sher6", ksm_sher6.SelectedValue);
            cmd1.Parameters.AddWithValue("@sh6_ksm", sh6_ksm.Text);
            cmd1.Parameters.AddWithValue("@ksm_sher7", ksm_sher7.SelectedValue);
            cmd1.Parameters.AddWithValue("@sh7_ksm", sh7_ksm.Text);
            cmd1.Parameters.AddWithValue("@ksm_sher8", ksm_sher8.SelectedValue);
            cmd1.Parameters.AddWithValue("@sh8_ksm", sh8_ksm.Text);
            cmd1.Parameters.AddWithValue("@ksm_sher9", ksm_sher9.SelectedValue);
            cmd1.Parameters.AddWithValue("@sh9_ksm", sh9_ksm.Text);
            cmd1.Parameters.AddWithValue("@ksm_sher10", ksm_sher10.SelectedValue);
            cmd1.Parameters.AddWithValue("@sh10_ksm ", sh10_ksm.Text);
            cmd1.Parameters.AddWithValue("@ksm_youm", ksm_youm.Text);
            cmd1.Parameters.AddWithValue("@ksm_asn", ksm_asn.Text);
            cmd1.Parameters.AddWithValue("@ksm_hosb", ksm_hosb.Text);
            cmd1.Parameters.AddWithValue("@ksm_mortbat", ksm_mortbat.Text);
            cmd1.Parameters.AddWithValue("@ksm_deal_month", ksm_deal_month.Text);
            cmd1.Parameters.AddWithValue("@ksm_deal_qur", ksm_deal_qur.Text);
            cmd1.Parameters.AddWithValue("@ksm_deal_6", ksm_deal_6.Text);
            cmd1.Parameters.AddWithValue("@tas_hosb", tas_hosb.Text);
            cmd1.Parameters.AddWithValue("@d_a_t", d_a_t.Text);
            cmd1.Parameters.AddWithValue("@es_sabeq", es_sabeq.Text);
            cmd1.Parameters.AddWithValue("@morabha", morabha.Text);
            cmd1.Parameters.AddWithValue("@tawg_mor", tawg_mor.Text);
            cmd1.Parameters.AddWithValue("@sharq_7", sharq_78.Text);
            cmd1.Parameters.AddWithValue("@sharq_8", sharq_8.Text);
            cmd1.Parameters.AddWithValue("@sdad_sk", sadad_sk.Text);
            cmd1.Parameters.AddWithValue("@tawg_last_year", tawg_last_year.Text);
            cmd1.Parameters.AddWithValue("@tawg_ksm_sabeq", tawg_ksm_sabeq.Text);
            cmd1.Parameters.AddWithValue("@twag_mor_sab", twag_mor_sab.Text);
            cmd1.Parameters.AddWithValue("@br4_daen", br4_daen.SelectedValue);
            cmd1.Parameters.AddWithValue("@br4_ksm", br4_ksm.Text);
            cmd1.Parameters.AddWithValue("@br5_daen", br5_daen.SelectedValue);
            cmd1.Parameters.AddWithValue("@br5_ksm", br5_ksm.Text);
            cmd1.Parameters.AddWithValue("@br6_daen", br6_daen.SelectedValue);
            cmd1.Parameters.AddWithValue("@br6_ksm", br6_ksm.Text);
            cmd1.Parameters.AddWithValue("@last_balance", last_balance.Text);
            cmd1.Parameters.AddWithValue("@tas_madena", tas_madena.Text);
            cmd1.Parameters.AddWithValue("@tas_madena_name", tas_madena_name.Text);
            cmd1.Parameters.AddWithValue("@tas_daena", tas_daena.Text);
            cmd1.Parameters.AddWithValue("@ta_da_na", ta_da_na.Text);
            cmd1.Parameters.AddWithValue("@sh_d_m", sh_d_m.SelectedValue);
            cmd1.Parameters.AddWithValue("@shname1", this.ksm_sher1.GetItemText(this.ksm_sher1.SelectedItem));
            cmd1.Parameters.AddWithValue("@shcode1", shc1.Text);
            cmd1.Parameters.AddWithValue("@shname2", this.ksm_sher2.GetItemText(this.ksm_sher2.SelectedItem));
            cmd1.Parameters.AddWithValue("@shcode2", shc2.Text);
            cmd1.Parameters.AddWithValue("@shname3", this.ksm_sher3.GetItemText(this.ksm_sher3.SelectedItem));
            cmd1.Parameters.AddWithValue("@shcode3", shc3.Text);
            cmd1.Parameters.AddWithValue("@shname4", this.ksm_sher4.GetItemText(this.ksm_sher4.SelectedItem));
            cmd1.Parameters.AddWithValue("@shcode4", shc4.Text);
            cmd1.Parameters.AddWithValue("@shname5", this.ksm_sher5.GetItemText(this.ksm_sher5.SelectedItem));
            cmd1.Parameters.AddWithValue("@shcode5", shc5.Text);
            cmd1.Parameters.AddWithValue("@shname6", this.ksm_sher6.GetItemText(this.ksm_sher6.SelectedItem));
            cmd1.Parameters.AddWithValue("@shcode6", shc6.Text);
            cmd1.Parameters.AddWithValue("@shname7", this.ksm_sher7.GetItemText(this.ksm_sher7.SelectedItem));
            cmd1.Parameters.AddWithValue("@shcode7", shc7.Text);
            cmd1.Parameters.AddWithValue("@shname8", this.ksm_sher8.GetItemText(this.ksm_sher8.SelectedItem));
            cmd1.Parameters.AddWithValue("@shcode8", shc8.Text);
            cmd1.Parameters.AddWithValue("@shname9", this.ksm_sher9.GetItemText(this.ksm_sher9.SelectedItem));
            cmd1.Parameters.AddWithValue("@shcode9", shc9.Text);
            cmd1.Parameters.AddWithValue("@shname10", this.ksm_sher10.GetItemText(this.ksm_sher10.SelectedItem));
            cmd1.Parameters.AddWithValue("@shcode10", shc10.Text);
            cmd1.Parameters.AddWithValue("@branname1", this.br1_madin.GetItemText(this.br1_madin.SelectedItem));
            cmd1.Parameters.AddWithValue("@brancode1", br1_madin.SelectedValue);
            cmd1.Parameters.AddWithValue("@branname2", this.br2_madin.GetItemText(this.br2_madin.SelectedItem));
            cmd1.Parameters.AddWithValue("@brancode2", br2_madin.SelectedValue);
            cmd1.Parameters.AddWithValue("@branname3", this.br3_madin.GetItemText(this.br3_madin.SelectedItem));
            cmd1.Parameters.AddWithValue("@brancode3", br3_madin.SelectedValue);
            cmd1.Parameters.AddWithValue("@branname4", this.br4_madin.GetItemText(this.br4_madin.SelectedItem));
            cmd1.Parameters.AddWithValue("@brancode4", br4_madin.SelectedValue);
            cmd1.Parameters.AddWithValue("@branname5", this.br4_daen.GetItemText(this.br4_daen.SelectedItem));
            cmd1.Parameters.AddWithValue("@brancode5", br4_daen.SelectedValue);
            cmd1.Parameters.AddWithValue("@branname6", this.br5_daen.GetItemText(this.br5_daen.SelectedItem));
            cmd1.Parameters.AddWithValue("@brancode6", br5_daen.SelectedValue);
            cmd1.Parameters.AddWithValue("@branname7", this.br6_daen.GetItemText(this.br6_daen.SelectedItem));
            cmd1.Parameters.AddWithValue("@brancode7", br6_daen.SelectedValue);
            cmd1.Parameters.AddWithValue("@darname", this.sh_d_m.GetItemText(this.sh_d_m.SelectedItem));
            cmd1.Parameters.AddWithValue("@darcode", dac.Text);
            this.Cursor = Cursors.WaitCursor;
            try
            {
                if (CheckForInternetConnection())
                {
                    conn.Open();
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("تم التسجيل");
                    conn.Close();
                    //loaddata();
                    UserEntry_Load(null, null);
                    this.Cursor = Cursors.Default;
                }
                else
                {
                    this.Cursor = Cursors.Default;
                    MessageBox.Show("لا يوجد اتصال بالانترنت ولن تسجل البيانات اون لاين");
                }
            }
            catch (SqlException ex)
            {
                //MessageBox.Show(ex.Message.ToString());
                conn.Close();
                this.Cursor = Cursors.Default;
            }
        }





        private void button15_Click(object sender, EventArgs e)
        {

        }
        private void UpdateLocal()
        {

            SqlCeCommand cmd1;

            cmd1 = new SqlCeCommand("UPDATE Customers SET [branch_id] = @branch_id ,[t_month] = @t_month ,[t_year] = @t_year ,[first_balance] = @first_balance ,[sales-ad] = @sales_ad ,[sales_as] = @sales_as ,[return_mor] = @return_mor ,[ta_mor] = @ta_mor ,[tak_tam] = @tak_tam ,[ziadat_nk] = @ziadat_nk ,[ziadat_esarat] = @ziadat_esarat ,[ziadat_esarat_mor] = @ziadat_esarat_mor ,[ziadat_ksm] = @ziadat_ksm ,[br1_madin] = @br1_madin ,[br1_ksm] = @br1_ksm ,[br2_madin] = @br2_madin ,[br2_ksm] = @br2_ksm ,[br3_madin] = @br3_madin ,[br3_ksm] = @br3_ksm ,[br4_madin] = @br4_madin ,[br4m_ksm] = @br4m_ksm ,[gad_haly] = @gad_haly ,[gad_mokdm] = @gad_mokdm ,[eada_tah] = @eada_tah ,[mas_gad] = @mas_gad ,[mas_eada] = @mas_eada ,[sader_d_m] = @sader_d_m ,[mortagaat_ad] = @mortagaat_ad ,[mortagaat_as] = @mortagaat_as ,[nakdy4] = @nakdy4 ,[nakdy44] = @nakdy44 ,[agel71] = @agel71 ,[agel5] = @agel5 ,[agel82] = @agel82 ,[agel_hkomy] = @agel_hkomy ,[ksm_mas] = @ksm_mas ,[yom12] = @yom12 ,[haq_cus] = @haq_cus ,[motgawez] = @motgawez ,[b_c] = @b_c ,[ksm_sher1] = @ksm_sher1 ,[sh1_ksm] = @sh1_ksm ,[ksm_sher2] = @ksm_sher2 ,[sh2_ksm] = @sh2_ksm ,[ksm_sher3] = @ksm_sher3 ,[sh3_ksm] = @sh3_ksm ,[ksm_sher4] = @ksm_sher4 ,[sh4_ksm] = @sh4_ksm ,[ksm_sher5] = @ksm_sher5 ,[sh5_ksm] = @sh5_ksm ,[ksm_sher6] = @ksm_sher6 ,[sh6_ksm] = @sh6_ksm ,[ksm_sher7] = @ksm_sher7 ,[sh7_ksm] = @sh7_ksm ,[ksm_sher8] = @ksm_sher8 ,[sh8_ksm] = @sh8_ksm ,[ksm_sher9] = @ksm_sher9 ,[sh9_ksm] = @sh9_ksm ,[ksm_sher10] = @ksm_sher10 ,[sh10_ksm] = @sh10_ksm ,[ksm_youm] = @ksm_youm ,[ksm_asn] = @ksm_asn ,[ksm_hosb] = @ksm_hosb ,[ksm_mortbat] = @ksm_mortbat ,[ksm_deal_month] = @ksm_deal_month ,[ksm_deal_qur] = @ksm_deal_qur ,[ksm_deal_6] = @ksm_deal_6 ,[tas_hosb] = @tas_hosb ,[d_a_t] = @d_a_t ,[es_sabeq] = @es_sabeq ,[morabha] = @morabha ,[tawg_mor] = @tawg_mor ,[sharq_78] = @sharq_7 ,[sharq_8] = @sharq_8 ,[sdad_sk] = @sdad_sk ,[tawg_last_year] = @tawg_last_year ,[tawg_ksm_sabeq] = @tawg_ksm_sabeq ,[twag_mor_sab] = @twag_mor_sab ,[br4_daen] = @br4_daen ,[br4_ksm] = @br4_ksm ,[br5_daen] = @br5_daen ,[br5_ksm] = @br5_ksm ,[br6_daen] = @br6_daen ,[br6_ksm] = @br6_ksm ,[last_balance] = @last_balance ,[tas_madena] = @tas_madena ,[tas_madena_name] = @tas_madena_name ,[tas_daena] = @tas_daena ,[ta_da_na] = @ta_da_na ,[sh_d_m] = @sh_d_m ,[shname1]= @shname1 ,[shcode1]= @shcode1 ,[shname2]= @shname2 ,[shcode2]= @shcode2 ,[shname3]= @shname3 ,[shcode3]= @shcode3 ,[shname4]= @shname4 ,[shcode4]= @shcode4 ,[shname5]= @shname5 ,[shcode5]= @shcode5 ,[shname6]= @shname6 ,[shcode6]= @shcode6 ,[shname7]= @shname7 ,[shcode7]= @shcode7 ,[shname8]= @shname8 ,[shcode8]= @shcode8 ,[shname9]= @shname9 ,[shcode9]= @shcode9 ,[shname10]= @shname10 ,[shcode10]= @shcode10 ,[branname1]= @branname1 ,[brancode1]= @brancode1 ,[branname2]= @branname2 ,[brancode2]= @brancode2 ,[branname3]= @branname3 ,[brancode3] =@brancode3 ,[branname4]= @branname4 ,[brancode4]= @brancode4 ,[branname5]= @branname5 ,[brancode5]= @brancode5 ,[branname6]= @branname6 ,[brancode6]= @brancode6 ,[branname7]= @branname7 ,[brancode7]= @brancode7 ,[darname]= @darname ,[darcode] =@darcode WHERE [branch_id] = @branch_id and [t_month] = @t_month and [t_year] = @t_year", db.con);
            cmd1.Parameters.AddWithValue("@branch_id", branch.SelectedValue);
            cmd1.Parameters.AddWithValue("@t_month", t_month.Text);
            cmd1.Parameters.AddWithValue("@t_year", t_year.Text);
            cmd1.Parameters.AddWithValue("@first_balance", Fbalance.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@sales_ad", sales_ad.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@sales_as", sales_as.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@return_mor", return_mor.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@ta_mor", ta_mor.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@tak_tam", tak_tam.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@ziadat_nk", ziadat_nk.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@ziadat_esarat", ziadat_esarat.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@ziadat_esarat_mor", ziadat_esarat_mor.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@ziadat_ksm", ziadat_ksm.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@br1_madin", br1_madin.SelectedValue ?? DBNull.Value);
            cmd1.Parameters.AddWithValue("@br1_ksm", br1_ksm.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@br2_madin", br2_madin.SelectedValue ?? DBNull.Value);
            cmd1.Parameters.AddWithValue("@br2_ksm", br2_ksm.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@br3_madin", br3_madin.SelectedValue ?? DBNull.Value);
            cmd1.Parameters.AddWithValue("@br3_ksm", br3_ksm.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@br4_madin", br4_madin.SelectedValue ?? DBNull.Value);
            cmd1.Parameters.AddWithValue("@br4m_ksm", br4m_ksm.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@gad_haly", gad_haly.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@gad_mokdm", gad_mokdm.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@eada_tah", eada_tah.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@mas_gad", mas_gad.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@mas_eada", mas_eada.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@sader_d_m", sader_d_m.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@mortagaat_ad", mortagaat_ad.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@mortagaat_as", mortagaat_as.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@nakdy4", nakdy4.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@nakdy44", nakdy44.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@agel71", agel71.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@agel5", agel5.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@agel82", agel82.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@agel_hkomy", agel_hkomy.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@ksm_mas", ksm_mas.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@yom12", yom12.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@haq_cus", haq_cus.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@motgawez", motgawez.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@b_c", b_c.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@ksm_sher1", ksm_sher1.SelectedValue ?? DBNull.Value);
            cmd1.Parameters.AddWithValue("@sh1_ksm", sh1_ksm.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@ksm_sher2", ksm_sher2.SelectedValue ?? DBNull.Value);
            cmd1.Parameters.AddWithValue("@sh2_ksm", sh2_ksm.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@ksm_sher3", ksm_sher3.SelectedValue ?? DBNull.Value);
            cmd1.Parameters.AddWithValue("@sh3_ksm", sh3_ksm.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@ksm_sher4", ksm_sher4.SelectedValue ?? DBNull.Value);
            cmd1.Parameters.AddWithValue("@sh4_ksm", sh4_ksm.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@ksm_sher5", ksm_sher5.SelectedValue ?? DBNull.Value);
            cmd1.Parameters.AddWithValue("@sh5_ksm", sh5_ksm.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@ksm_sher6", ksm_sher6.SelectedValue ?? DBNull.Value);
            cmd1.Parameters.AddWithValue("@sh6_ksm", sh6_ksm.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@ksm_sher7", ksm_sher7.SelectedValue ?? DBNull.Value);
            cmd1.Parameters.AddWithValue("@sh7_ksm", sh7_ksm.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@ksm_sher8", ksm_sher8.SelectedValue ?? DBNull.Value);
            cmd1.Parameters.AddWithValue("@sh8_ksm", sh8_ksm.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@ksm_sher9", ksm_sher9.SelectedValue ?? DBNull.Value);
            cmd1.Parameters.AddWithValue("@sh9_ksm", sh9_ksm.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@ksm_sher10", ksm_sher10.SelectedValue ?? DBNull.Value);
            cmd1.Parameters.AddWithValue("@sh10_ksm", sh10_ksm.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@ksm_youm", ksm_youm.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@ksm_asn", ksm_asn.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@ksm_hosb", ksm_hosb.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@ksm_mortbat", ksm_mortbat.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@ksm_deal_month", ksm_deal_month.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@ksm_deal_qur", ksm_deal_qur.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@ksm_deal_6", ksm_deal_6.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@tas_hosb", tas_hosb.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@d_a_t", d_a_t.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@es_sabeq", es_sabeq.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@morabha", morabha.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@tawg_mor", tawg_mor.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@sharq_7", sharq_78.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@sharq_8", sharq_8.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@sdad_sk", sadad_sk.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@tawg_last_year", tawg_last_year.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@tawg_ksm_sabeq", tawg_ksm_sabeq.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@twag_mor_sab", twag_mor_sab.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@br4_daen", br4_daen.SelectedValue ?? DBNull.Value);
            cmd1.Parameters.AddWithValue("@br4_ksm", br4_ksm.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@br5_daen", br5_daen.SelectedValue ?? DBNull.Value);
            cmd1.Parameters.AddWithValue("@br5_ksm", br5_ksm.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@br6_daen", br6_daen.SelectedValue ?? DBNull.Value);
            cmd1.Parameters.AddWithValue("@br6_ksm", br6_ksm.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@last_balance", last_balance.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@tas_madena", tas_madena.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@tas_madena_name", tas_madena_name.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@tas_daena", tas_daena.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@ta_da_na", ta_da_na.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@sh_d_m", sh_d_m.SelectedValue ?? DBNull.Value);
            cmd1.Parameters.AddWithValue("@shname1", this.ksm_sher1.GetItemText(this.ksm_sher1.SelectedItem) ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@shcode1", shc1.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@shname2", this.ksm_sher2.GetItemText(this.ksm_sher2.SelectedItem) ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@shcode2", shc2.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@shname3", this.ksm_sher3.GetItemText(this.ksm_sher3.SelectedItem) ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@shcode3", shc3.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@shname4", this.ksm_sher4.GetItemText(this.ksm_sher4.SelectedItem) ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@shcode4", shc4.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@shname5", this.ksm_sher5.GetItemText(this.ksm_sher5.SelectedItem) ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@shcode5", shc5.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@shname6", this.ksm_sher6.GetItemText(this.ksm_sher6.SelectedItem) ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@shcode6", shc6.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@shname7", this.ksm_sher7.GetItemText(this.ksm_sher7.SelectedItem) ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@shcode7", shc7.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@shname8", this.ksm_sher8.GetItemText(this.ksm_sher8.SelectedItem) ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@shcode8", shc8.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@shname9", this.ksm_sher9.GetItemText(this.ksm_sher9.SelectedItem) ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@shcode9", shc9.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@shname10", this.ksm_sher10.GetItemText(this.ksm_sher10.SelectedItem) ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@shcode10", shc10.Text ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@branname1", this.br1_madin.GetItemText(this.br1_madin.SelectedItem) ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@brancode1", br1_madin.SelectedValue ?? DBNull.Value);
            cmd1.Parameters.AddWithValue("@branname2", this.br2_madin.GetItemText(this.br2_madin.SelectedItem) ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@brancode2", br2_madin.SelectedValue ?? DBNull.Value);
            cmd1.Parameters.AddWithValue("@branname3", this.br3_madin.GetItemText(this.br3_madin.SelectedItem) ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@brancode3", br3_madin.SelectedValue ?? DBNull.Value);
            cmd1.Parameters.AddWithValue("@branname4", this.br4_madin.GetItemText(this.br4_madin.SelectedItem) ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@brancode4", br4_madin.SelectedValue ?? DBNull.Value);
            cmd1.Parameters.AddWithValue("@branname5", this.br4_daen.GetItemText(this.br4_daen.SelectedItem) ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@brancode5", br4_daen.SelectedValue ?? DBNull.Value);
            cmd1.Parameters.AddWithValue("@branname6", this.br5_daen.GetItemText(this.br5_daen.SelectedItem) ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@brancode6", br5_daen.SelectedValue ?? DBNull.Value);
            cmd1.Parameters.AddWithValue("@branname7", this.br6_daen.GetItemText(this.br6_daen.SelectedItem) ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@brancode7", br6_daen.SelectedValue ?? DBNull.Value);
            cmd1.Parameters.AddWithValue("@darname", this.sh_d_m.GetItemText(this.sh_d_m.SelectedItem) ?? DBNull.Value.ToString());
            cmd1.Parameters.AddWithValue("@darcode", dac.Text ?? DBNull.Value.ToString());
            if (branch.SelectedIndex != -1)
            {
                DataTable tbl = new DataTable();
                tbl = db.Ce_runquery("select branch_id,t_month,t_year from Customers where branch_id='" + branch.SelectedValue + "' and t_month='" + t_month.Text + "' and t_year='" + t_year.Text + "' ");
                if (tbl.Rows.Count != 1)
                    MessageBox.Show("لم تم تسجيل البيانات من قبل");
                else
                {
                    try
                    {
                        db.con.Open();
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("الرجاء الانتظار قليلا لتحديث البيانات أون لاين");
                        db.con.Close();
                        loaddata();
                        //UserEntry_Load(null, null);
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

        private void sh1_ksm_Validating(object sender, CancelEventArgs e)
        {
            if (Convert.ToDecimal(sh1_ksm.Text) == 0)
            {
                ksm_sher1.SelectedIndex = -1;
            }
        }

        private void ksm_sher1_Validating(object sender, CancelEventArgs e)
        {
            if (ksm_sher1.SelectedIndex > -1)
                return;
            else
            {
                ksm_sher1.SelectedIndex = -1;
                ksm_sher1.Text = "";
            }
        }

        private void sh1_ksm_Validated(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(sh1_ksm.Text) == 0)
            {
                ksm_sher1.SelectedIndex = -1;
            }
        }

        private void ksm_sher2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ksm_sher2.SelectedIndex > -1)
                return;
            else
            {
                ksm_sher2.SelectedIndex = -1;
                ksm_sher2.Text = "";
            }
        }

        private void ksm_sher3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ksm_sher3.SelectedIndex > -1)
                return;
            else
            {
                ksm_sher3.SelectedIndex = -1;
                ksm_sher3.Text = "";
            }
        }

        private void ksm_sher4_Validating(object sender, CancelEventArgs e)
        {
            if (ksm_sher4.SelectedIndex > -1)
                return;
            else
            {
                ksm_sher4.SelectedIndex = -1;
                ksm_sher4.Text = "";
            }
        }

        private void ksm_sher5_Validating(object sender, CancelEventArgs e)
        {
            if (ksm_sher5.SelectedIndex > -1)
                return;
            else
            {
                ksm_sher5.SelectedIndex = -1;
                ksm_sher5.Text = "";
            }
        }

        private void ksm_sher6_Validating(object sender, CancelEventArgs e)
        {
            if (ksm_sher6.SelectedIndex > -1)
                return;
            else
            {
                ksm_sher6.SelectedIndex = -1;
                ksm_sher6.Text = "";
            }
        }

        private void ksm_sher7_Validating(object sender, CancelEventArgs e)
        {
            if (ksm_sher7.SelectedIndex > -1)
                return;
            else
            {
                ksm_sher7.SelectedIndex = -1;
                ksm_sher7.Text = "";
            }
        }

        private void ksm_sher8_Validating(object sender, CancelEventArgs e)
        {
            if (ksm_sher8.SelectedIndex > -1)
                return;
            else
            {
                ksm_sher8.SelectedIndex = -1;
                ksm_sher8.Text = "";
            }
        }

        private void ksm_sher9_Validating(object sender, CancelEventArgs e)
        {
            if (ksm_sher9.SelectedIndex > -1)
                return;
            else
            {
                ksm_sher9.SelectedIndex = -1;
                ksm_sher9.Text = "";
            }
        }

        private void ksm_sher10_Validating(object sender, CancelEventArgs e)
        {
            if (ksm_sher10.SelectedIndex > -1)
                return;
            else
            {
                ksm_sher10.SelectedIndex = -1;
                ksm_sher10.Text = "";
            }
        }

        private void ksm_sher1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
                return;
            }
        }

        private void sh2_ksm_Validated(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(sh2_ksm.Text) == 0)
            {
                ksm_sher2.SelectedIndex = -1;
            }
        }

        private void sh3_ksm_Validating(object sender, CancelEventArgs e)
        {
            if (Convert.ToDecimal(sh3_ksm.Text) == 0)
            {
                ksm_sher3.SelectedIndex = -1;
            }
        }

        private void sh4_ksm_Validating(object sender, CancelEventArgs e)
        {
            if (Convert.ToDecimal(sh4_ksm.Text) == 0)
            {
                ksm_sher4.SelectedIndex = -1;
            }
        }

        private void sh5_ksm_Validating(object sender, CancelEventArgs e)
        {
            if (Convert.ToDecimal(sh5_ksm.Text) == 0)
            {
                ksm_sher5.SelectedIndex = -1;
            }
        }

        private void sh6_ksm_Validating(object sender, CancelEventArgs e)
        {
            if (Convert.ToDecimal(sh6_ksm.Text) == 0)
            {
                ksm_sher6.SelectedIndex = -1;
            }
        }

        private void sh7_ksm_Validating(object sender, CancelEventArgs e)
        {
            if (Convert.ToDecimal(sh7_ksm.Text) == 0)
            {
                ksm_sher7.SelectedIndex = -1;
            }
        }

        private void sh8_ksm_Validating(object sender, CancelEventArgs e)
        {
            if (Convert.ToDecimal(sh8_ksm.Text) == 0)
            {
                ksm_sher8.SelectedIndex = -1;
            }
        }

        private void sh9_ksm_Validating(object sender, CancelEventArgs e)
        {
            if (Convert.ToDecimal(sh9_ksm.Text) == 0)
            {
                ksm_sher9.SelectedIndex = -1;
            }
        }

        private void sh10_ksm_Validating(object sender, CancelEventArgs e)
        {
            if (Convert.ToDecimal(sh10_ksm.Text) == 0)
            {
                ksm_sher10.SelectedIndex = -1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            br1_madin.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 5;
            ksm_sher1.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 6;
            tas_hosb.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
            gad_haly.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
            ksm_deal_month.Focus();
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




        private void UserEntry_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            youm8.Focus();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            yoim79.Focus();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            youm96.Focus();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            youm17.Focus();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            tas_hosb1.Focus();
        }



    }

}
