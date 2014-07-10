using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Takfila
{
    class Maftouh : Takfila.Classes.MainTable
    {
        #region MyRegion
        private int _branch_id;

        public int Branch_id
        {
            get { return _branch_id; }
            set { _branch_id = value; }
        }
        private int _t_month;

        public int T_month
        {
            get { return _t_month; }
            set { _t_month = value; }
        }
        private int _t_year;

        public int T_year
        {
            get { return _t_year; }
            set { _t_year = value; }
        }
        private decimal _first_balance;

        public decimal First_balance
        {
            get { return _first_balance; }
            set { _first_balance = value; }
        }
        private decimal _sales_ad;

        public decimal Sales_ad
        {
            get { return _sales_ad; }
            set { _sales_ad = value; }
        }
        private decimal _sales_as;

        public decimal Sales_as
        {
            get { return _sales_as; }
            set { _sales_as = value; }
        }
        private decimal _return_mor;

        public decimal Return_mor
        {
            get { return _return_mor; }
            set { _return_mor = value; }
        }
        private decimal _ta_mor;

        public decimal Ta_mor
        {
            get { return _ta_mor; }
            set { _ta_mor = value; }
        }
        private decimal _tak_tam;


        public decimal Tak_tam
        {
            get { return _tak_tam; }
            set { _tak_tam = value; }
        }
        private decimal _ziadat_nk;

        public decimal Ziadat_nk
        {
            get { return _ziadat_nk; }
            set { _ziadat_nk = value; }
        }
        private decimal _ziadat_esarat;

        public decimal Ziadat_esarat
        {
            get { return _ziadat_esarat; }
            set { _ziadat_esarat = value; }
        }
        private decimal _ziadat_esarat_mor;

        public decimal Ziadat_esarat_mor
        {
            get { return _ziadat_esarat_mor; }
            set { _ziadat_esarat_mor = value; }
        }
        private decimal _ziadat_ksm;

        public decimal Ziadat_ksm
        {
            get { return _ziadat_ksm; }
            set { _ziadat_ksm = value; }
        }
        private decimal _br1_madin;

        public decimal Br1_madin
        {
            get { return _br1_madin; }
            set { _br1_madin = value; }
        }
        private decimal _br1_ksm;

        public decimal Br1_ksm
        {
            get { return _br1_ksm; }
            set { _br1_ksm = value; }
        }
        private decimal _br2_madin;

        public decimal Br2_madin
        {
            get { return _br2_madin; }
            set { _br2_madin = value; }
        }
        private decimal _br2_ksm;

        public decimal Br2_ksm
        {
            get { return _br2_ksm; }
            set { _br2_ksm = value; }
        }
        private decimal _br3_madin;

        public decimal Br3_madin
        {
            get { return _br3_madin; }
            set { _br3_madin = value; }
        }
        private decimal _br3_ksm;

        public decimal Br3_ksm
        {
            get { return _br3_ksm; }
            set { _br3_ksm = value; }
        }
        private decimal _br4_madin;

        public decimal Br4_madin
        {
            get { return _br4_madin; }
            set { _br4_madin = value; }
        }
        private decimal _br4m_ksm;

        public decimal Br4m_ksm
        {
            get { return _br4m_ksm; }
            set { _br4m_ksm = value; }
        }
        private decimal _gad_haly;

        public decimal Gad_haly
        {
            get { return _gad_haly; }
            set { _gad_haly = value; }
        }
        private decimal _gad_mokdm;

        public decimal Gad_mokdm
        {
            get { return _gad_mokdm; }
            set { _gad_mokdm = value; }
        }
        private decimal _eada_tah;

        public decimal Eada_tah
        {
            get { return _eada_tah; }
            set { _eada_tah = value; }
        }
        private decimal _mas_gad;

        public decimal Mas_gad
        {
            get { return _mas_gad; }
            set { _mas_gad = value; }
        }
        private decimal _mas_eada;

        public decimal Mas_eada
        {
            get { return _mas_eada; }
            set { _mas_eada = value; }
        }
        private decimal _sader_d_m;

        public decimal Sader_d_m
        {
            get { return _sader_d_m; }
            set { _sader_d_m = value; }
        }
        private decimal _mortagaat_ad;

        public decimal Mortagaat_ad
        {
            get { return _mortagaat_ad; }
            set { _mortagaat_ad = value; }
        }
        private decimal _mortagaat_as;

        public decimal Mortagaat_as
        {
            get { return _mortagaat_as; }
            set { _mortagaat_as = value; }
        }
        private decimal _nakdy4;

        public decimal Nakdy4
        {
            get { return _nakdy4; }
            set { _nakdy4 = value; }
        }
        private decimal _nakdy44;

        public decimal Nakdy44
        {
            get { return _nakdy44; }
            set { _nakdy44 = value; }
        }
        private decimal _agel71;

        public decimal Agel71
        {
            get { return _agel71; }
            set { _agel71 = value; }
        }
        private decimal _agel5;

        public decimal Agel5
        {
            get { return _agel5; }
            set { _agel5 = value; }
        }
        private decimal _agel82;

        public decimal Agel82
        {
            get { return _agel82; }
            set { _agel82 = value; }
        }
        private decimal _agel_hkomy;

        public decimal Agel_hkomy
        {
            get { return _agel_hkomy; }
            set { _agel_hkomy = value; }
        }
        private decimal _ksm_mas;

        public decimal Ksm_mas
        {
            get { return _ksm_mas; }
            set { _ksm_mas = value; }
        }
        private decimal _yom12;

        public decimal Yom12
        {
            get { return _yom12; }
            set { _yom12 = value; }
        }
        private decimal _haq_cus;

        public decimal Haq_cus
        {
            get { return _haq_cus; }
            set { _haq_cus = value; }
        }
        private decimal _motgawez;

        public decimal Motgawez
        {
            get { return _motgawez; }
            set { _motgawez = value; }
        }
        private decimal _b_c;

        public decimal B_c
        {
            get { return _b_c; }
            set { _b_c = value; }
        }
        private decimal _ksm_sher1;

        public decimal Ksm_sher1
        {
            get { return _ksm_sher1; }
            set { _ksm_sher1 = value; }
        }
        private decimal _sh1_ksm;

        public decimal Sh1_ksm
        {
            get { return _sh1_ksm; }
            set { _sh1_ksm = value; }
        }
        private decimal _ksm_sher2;

        public decimal Ksm_sher2
        {
            get { return _ksm_sher2; }
            set { _ksm_sher2 = value; }
        }
        private decimal _sh2_ksm;

        public decimal Sh2_ksm
        {
            get { return _sh2_ksm; }
            set { _sh2_ksm = value; }
        }
        private decimal _ksm_sher3;

        public decimal Ksm_sher3
        {
            get { return _ksm_sher3; }
            set { _ksm_sher3 = value; }
        }
        private decimal _sh3_ksm;

        public decimal Sh3_ksm
        {
            get { return _sh3_ksm; }
            set { _sh3_ksm = value; }
        }
        private decimal _ksm_sher4;

        public decimal Ksm_sher4
        {
            get { return _ksm_sher4; }
            set { _ksm_sher4 = value; }
        }
        private decimal _sh4_ksm;

        public decimal Sh4_ksm
        {
            get { return _sh4_ksm; }
            set { _sh4_ksm = value; }
        }
        private decimal _ksm_sher5;

        public decimal Ksm_sher5
        {
            get { return _ksm_sher5; }
            set { _ksm_sher5 = value; }
        }
        private decimal _sh5_ksm;

        public decimal Sh5_ksm
        {
            get { return _sh5_ksm; }
            set { _sh5_ksm = value; }
        }
        private decimal _ksm_sher6;

        public decimal Ksm_sher6
        {
            get { return _ksm_sher6; }
            set { _ksm_sher6 = value; }
        }
        private decimal _sh6_ksm;

        public decimal Sh6_ksm
        {
            get { return _sh6_ksm; }
            set { _sh6_ksm = value; }
        }
        private decimal _ksm_sher7;

        public decimal Ksm_sher7
        {
            get { return _ksm_sher7; }
            set { _ksm_sher7 = value; }
        }
        private decimal _sh7_ksm;

        public decimal Sh7_ksm
        {
            get { return _sh7_ksm; }
            set { _sh7_ksm = value; }
        }
        private decimal _ksm_sher8;

        public decimal Ksm_sher8
        {
            get { return _ksm_sher8; }
            set { _ksm_sher8 = value; }
        }
        private decimal _sh8_ksm;

        public decimal Sh8_ksm
        {
            get { return _sh8_ksm; }
            set { _sh8_ksm = value; }
        }
        private decimal _ksm_sher9;

        public decimal Ksm_sher9
        {
            get { return _ksm_sher9; }
            set { _ksm_sher9 = value; }
        }
        private decimal _sh9_ksm;

        public decimal Sh9_ksm
        {
            get { return _sh9_ksm; }
            set { _sh9_ksm = value; }
        }
        private decimal _ksm_sher10;

        public decimal Ksm_sher10
        {
            get { return _ksm_sher10; }
            set { _ksm_sher10 = value; }
        }
        private decimal _sh10_ksm;

        public decimal Sh10_ksm
        {
            get { return _sh10_ksm; }
            set { _sh10_ksm = value; }
        }
        private decimal _ksm_youm;

        public decimal Ksm_youm
        {
            get { return _ksm_youm; }
            set { _ksm_youm = value; }
        }
        private decimal _ksm_asn;

        public decimal Ksm_asn
        {
            get { return _ksm_asn; }
            set { _ksm_asn = value; }
        }
        private decimal _ksm_hosb;

        public decimal Ksm_hosb
        {
            get { return _ksm_hosb; }
            set { _ksm_hosb = value; }
        }
        private decimal _ksm_mortbat;

        public decimal Ksm_mortbat
        {
            get { return _ksm_mortbat; }
            set { _ksm_mortbat = value; }
        }
        private decimal _ksm_deal_month;

        public decimal Ksm_deal_month
        {
            get { return _ksm_deal_month; }
            set { _ksm_deal_month = value; }
        }
        private decimal _ksm_deal_qur;

        public decimal Ksm_deal_qur
        {
            get { return _ksm_deal_qur; }
            set { _ksm_deal_qur = value; }
        }
        private decimal _ksm_deal_6;

        public decimal Ksm_deal_6
        {
            get { return _ksm_deal_6; }
            set { _ksm_deal_6 = value; }
        }
        private decimal _tas_hosb;

        public decimal Tas_hosb
        {
            get { return _tas_hosb; }
            set { _tas_hosb = value; }
        }
        private decimal _d_a_t;

        public decimal D_a_t
        {
            get { return _d_a_t; }
            set { _d_a_t = value; }
        }
        private decimal _es_sabeq;

        public decimal Es_sabeq
        {
            get { return _es_sabeq; }
            set { _es_sabeq = value; }
        }
        private decimal _morabha;

        public decimal Morabha
        {
            get { return _morabha; }
            set { _morabha = value; }
        }
        private decimal _tawg_mor;

        public decimal Tawg_mor
        {
            get { return _tawg_mor; }
            set { _tawg_mor = value; }
        }
        private decimal _sharq_7;

        public decimal Sharq_7
        {
            get { return _sharq_7; }
            set { _sharq_7 = value; }
        }
        private decimal _sharq_8;

        public decimal Sharq_8
        {
            get { return _sharq_8; }
            set { _sharq_8 = value; }
        }
        private decimal _sdad_sk;

        public decimal Sdad_sk
        {
            get { return _sdad_sk; }
            set { _sdad_sk = value; }
        }
        private decimal _tawg_last_year;

        public decimal Tawg_last_year
        {
            get { return _tawg_last_year; }
            set { _tawg_last_year = value; }
        }
        private decimal _tawg_ksm_sabeq;

        public decimal Tawg_ksm_sabeq
        {
            get { return _tawg_ksm_sabeq; }
            set { _tawg_ksm_sabeq = value; }
        }
        private decimal _twag_mor_sab;

        public decimal Twag_mor_sab
        {
            get { return _twag_mor_sab; }
            set { _twag_mor_sab = value; }
        }
        private decimal _br4_daen;

        public decimal Br4_daen
        {
            get { return _br4_daen; }
            set { _br4_daen = value; }
        }
        private decimal _br4_ksm;

        public decimal Br4_ksm
        {
            get { return _br4_ksm; }
            set { _br4_ksm = value; }
        }
        private decimal _br5_daen;

        public decimal Br5_daen
        {
            get { return _br5_daen; }
            set { _br5_daen = value; }
        }
        private decimal _br5_ksm;

        public decimal Br5_ksm
        {
            get { return _br5_ksm; }
            set { _br5_ksm = value; }
        }
        private decimal _br6_daen;

        public decimal Br6_daen
        {
            get { return _br6_daen; }
            set { _br6_daen = value; }
        }
        private decimal _br6_ksm;

        public decimal Br6_ksm
        {
            get { return _br6_ksm; }
            set { _br6_ksm = value; }
        }
        private decimal _last_balance;

        public decimal Last_balance
        {
            get { return _last_balance; }
            set { _last_balance = value; }
        }
        private decimal _tas_madena;

        public decimal Tas_madena
        {
            get { return _tas_madena; }
            set { _tas_madena = value; }
        }
        private string _tas_madena_name;

        public string Tas_madena_name
        {
            get { return _tas_madena_name; }
            set { _tas_madena_name = value; }
        }
        private decimal _tas_daena;

        public decimal Tas_daena
        {
            get { return _tas_daena; }
            set { _tas_daena = value; }
        }
        private string _ta_da_na;

        public string Ta_da_na
        {
            get { return _ta_da_na; }
            set { _ta_da_na = value; }
        }
        private decimal _sh_d_m;

        public decimal Sh_d_m
        {
            get { return _sh_d_m; }
            set { _sh_d_m = value; }
        }
        private string _shname1;

        public string Shname1
        {
            get { return _shname1; }
            set { _shname1 = value; }
        }
        private int _shcode1;

        public int Shcode1
        {
            get { return _shcode1; }
            set { _shcode1 = value; }
        }
        private string _shname2;

        public string Shname2
        {
            get { return _shname2; }
            set { _shname2 = value; }
        }
        private int _shcode2;

        public int Shcode2
        {
            get { return _shcode2; }
            set { _shcode2 = value; }
        }
        private string _shname3;

        public string Shname3
        {
            get { return _shname3; }
            set { _shname3 = value; }
        }
        private int _shcode3;

        public int Shcode3
        {
            get { return _shcode3; }
            set { _shcode3 = value; }
        }
        private string _shname4;

        public string Shname4
        {
            get { return _shname4; }
            set { _shname4 = value; }
        }
        private int _shcode4;

        public int Shcode4
        {
            get { return _shcode4; }
            set { _shcode4 = value; }
        }
        private string _shname5;

        public string Shname5
        {
            get { return _shname5; }
            set { _shname5 = value; }
        }
        private int _shcode5;

        public int Shcode5
        {
            get { return _shcode5; }
            set { _shcode5 = value; }
        }
        private string _shname6;

        public string Shname6
        {
            get { return _shname6; }
            set { _shname6 = value; }
        }
        private int _shcode6;

        public int Shcode6
        {
            get { return _shcode6; }
            set { _shcode6 = value; }
        }
        private string _shname7;

        public string Shname7
        {
            get { return _shname7; }
            set { _shname7 = value; }
        }
        private int _shcode7;

        public int Shcode7
        {
            get { return _shcode7; }
            set { _shcode7 = value; }
        }
        private string _shname8;

        public string Shname8
        {
            get { return _shname8; }
            set { _shname8 = value; }
        }
        private int _shcode8;

        public int Shcode8
        {
            get { return _shcode8; }
            set { _shcode8 = value; }
        }
        private string _shname9;

        public string Shname9
        {
            get { return _shname9; }
            set { _shname9 = value; }
        }
        private int _shcode9;

        public int Shcode9
        {
            get { return _shcode9; }
            set { _shcode9 = value; }
        }
        private string _shname10;

        public string Shname10
        {
            get { return _shname10; }
            set { _shname10 = value; }
        }
        private int _shcode10;

        public int Shcode10
        {
            get { return _shcode10; }
            set { _shcode10 = value; }
        }
        private string _branname1;

        public string Branname1
        {
            get { return _branname1; }
            set { _branname1 = value; }
        }
        private int _brancode1;

        public int Brancode1
        {
            get { return _brancode1; }
            set { _brancode1 = value; }
        }
        private string _branname2;

        public string Branname2
        {
            get { return _branname2; }
            set { _branname2 = value; }
        }
        private int _brancode2;

        public int Brancode2
        {
            get { return _brancode2; }
            set { _brancode2 = value; }
        }
        private string _branname3;

        public string Branname3
        {
            get { return _branname3; }
            set { _branname3 = value; }
        }
        private int _brancode3;

        public int Brancode3
        {
            get { return _brancode3; }
            set { _brancode3 = value; }
        }
        private string _branname4;

        public string Branname4
        {
            get { return _branname4; }
            set { _branname4 = value; }
        }
        private int _brancode4;

        public int Brancode4
        {
            get { return _brancode4; }
            set { _brancode4 = value; }
        }
        private string _branname5;

        public string Branname5
        {
            get { return _branname5; }
            set { _branname5 = value; }
        }
        private int _brancode5;

        public int Brancode5
        {
            get { return _brancode5; }
            set { _brancode5 = value; }
        }
        private string _branname6;

        public string Branname6
        {
            get { return _branname6; }
            set { _branname6 = value; }
        }
        private int _brancode6;

        public int Brancode6
        {
            get { return _brancode6; }
            set { _brancode6 = value; }
        }
        private string _branname7;

        public string Branname7
        {
            get { return _branname7; }
            set { _branname7 = value; }
        }
        private int _brancode7;

        public int Brancode7
        {
            get { return _brancode7; }
            set { _brancode7 = value; }
        }
        private string _darname;

        public string Darname
        {
            get { return _darname; }
            set { _darname = value; }
        }
        private int _darcode;

        public int Darcode
        {
            get { return _darcode; }
            set { _darcode = value; }
        }
        #endregion
        public DataTable AllData()
        {
            string sel = "select * from Customers where branch_id in(" + Program.b + ") order by serial";
            tbl.Clear();
            tbl = DBw.Ce_runquery(sel);
            DataColumn[] keyColumn = new DataColumn[3];
            keyColumn[0] = tbl.Columns["branch_id"];
            keyColumn[1] = tbl.Columns["t_month"];
            keyColumn[2] = tbl.Columns["t_year"];
            //tbl.PrimaryKey = keyColumn;
            tbl.Constraints.Add("keyColumn",keyColumn,true);
            
            return tbl;
        }
       
        protected override void setdata()
        {
            for (int i = 0; i < tbl.Rows.Count; i++)
            {
                DataRow row = tbl.Rows[i];
                for (int x = 0; x < tbl.Columns.Count; x++)
                {
                    if (row[x] == DBNull.Value)
                    {
                        row[x] = 0;
                    }
                }
            }
            Branch_id = Convert.ToInt32(tbl.Rows[pos][1]);
            T_month = Convert.ToInt32(tbl.Rows[pos][2]);
            T_year = Convert.ToInt32(tbl.Rows[pos][3]);
            First_balance = Convert.ToDecimal(tbl.Rows[pos][4]);
            Sales_ad = Convert.ToDecimal(tbl.Rows[pos][5]);
            Sales_as = Convert.ToDecimal(tbl.Rows[pos][6]);
            Return_mor = Convert.ToDecimal(tbl.Rows[pos][7]);
            Ta_mor = Convert.ToDecimal(tbl.Rows[pos][8]);
            Tak_tam = Convert.ToDecimal(tbl.Rows[pos][9]);
            Ziadat_nk = Convert.ToDecimal(tbl.Rows[pos][10]);
            Ziadat_esarat = Convert.ToDecimal(tbl.Rows[pos][11]);
            Ziadat_esarat_mor = Convert.ToDecimal(tbl.Rows[pos][12]);
            Ziadat_ksm = Convert.ToDecimal(tbl.Rows[pos][13]);
            Br1_madin = Convert.ToDecimal(tbl.Rows[pos][14]);
            Br1_ksm = Convert.ToDecimal(tbl.Rows[pos][15]);
            Br2_madin = Convert.ToDecimal(tbl.Rows[pos][16]);
            Br2_ksm = Convert.ToDecimal(tbl.Rows[pos][17]);
            Br3_madin = Convert.ToDecimal(tbl.Rows[pos][18]);
            Br3_ksm = Convert.ToDecimal(tbl.Rows[pos][19]);
            Br4_madin = Convert.ToDecimal(tbl.Rows[pos][20]);
            Br4m_ksm = Convert.ToDecimal(tbl.Rows[pos][21]);
            Gad_haly = Convert.ToDecimal(tbl.Rows[pos][22]);
            Gad_mokdm = Convert.ToDecimal(tbl.Rows[pos][23]);
            Eada_tah = Convert.ToDecimal(tbl.Rows[pos][24]);
            Mas_gad = Convert.ToDecimal(tbl.Rows[pos][25]);
            Mas_eada = Convert.ToDecimal(tbl.Rows[pos][26]);
            Sader_d_m = Convert.ToDecimal(tbl.Rows[pos][27]);
            Mortagaat_ad = Convert.ToDecimal(tbl.Rows[pos][28]);
            Mortagaat_as = Convert.ToDecimal(tbl.Rows[pos][29]);
            Nakdy4 = Convert.ToDecimal(tbl.Rows[pos][30]);
            Nakdy44 = Convert.ToDecimal(tbl.Rows[pos][31]);
            Agel71 = Convert.ToDecimal(tbl.Rows[pos][32]);
            Agel5 = Convert.ToDecimal(tbl.Rows[pos][33]);
            Agel82 = Convert.ToDecimal(tbl.Rows[pos][34]);
            Agel_hkomy = Convert.ToDecimal(tbl.Rows[pos][35]);
            Ksm_mas = Convert.ToDecimal(tbl.Rows[pos][36]);
            Yom12 = Convert.ToDecimal(tbl.Rows[pos][37]);
            Haq_cus = Convert.ToDecimal(tbl.Rows[pos][38]);
            Motgawez = Convert.ToDecimal(tbl.Rows[pos][39]);
            B_c = Convert.ToDecimal(tbl.Rows[pos][40]);
            Ksm_sher1 = Convert.ToDecimal(tbl.Rows[pos][41]);
            Sh1_ksm = Convert.ToDecimal(tbl.Rows[pos][42]);
            Ksm_sher2 = Convert.ToDecimal(tbl.Rows[pos][43]);
            Sh2_ksm = Convert.ToDecimal(tbl.Rows[pos][44]);
            Ksm_sher3 = Convert.ToDecimal(tbl.Rows[pos][45]);
            Sh3_ksm = Convert.ToDecimal(tbl.Rows[pos][46]);
            Ksm_sher4 = Convert.ToDecimal(tbl.Rows[pos][47]);
            Sh4_ksm = Convert.ToDecimal(tbl.Rows[pos][48]);
            Ksm_sher5 = Convert.ToDecimal(tbl.Rows[pos][49]);
            Sh5_ksm = Convert.ToDecimal(tbl.Rows[pos][50]);
            Ksm_sher6 = Convert.ToDecimal(tbl.Rows[pos][51]);
            Sh6_ksm = Convert.ToDecimal(tbl.Rows[pos][52]);
            Ksm_sher7 = Convert.ToDecimal(tbl.Rows[pos][53]);
            Sh7_ksm = Convert.ToDecimal(tbl.Rows[pos][54]);
            Ksm_sher8=Convert.ToDecimal(tbl.Rows[pos][55]);
            Sh8_ksm = Convert.ToDecimal(tbl.Rows[pos][56]);
            Ksm_sher9 = Convert.ToDecimal(tbl.Rows[pos][57]);
            Sh9_ksm = Convert.ToDecimal(tbl.Rows[pos][58]);
            Ksm_sher10 = Convert.ToDecimal(tbl.Rows[pos][59]);
            Sh10_ksm = Convert.ToDecimal(tbl.Rows[pos][60]);
            Ksm_youm = Convert.ToDecimal(tbl.Rows[pos][61]);
            Ksm_asn = Convert.ToDecimal(tbl.Rows[pos][62]);
            Ksm_hosb = Convert.ToDecimal(tbl.Rows[pos][63]);
            Ksm_mortbat = Convert.ToDecimal(tbl.Rows[pos][64]);
            Ksm_deal_month = Convert.ToDecimal(tbl.Rows[pos][65]);
            Ksm_deal_qur = Convert.ToDecimal(tbl.Rows[pos][66]);
            Ksm_deal_6 = Convert.ToDecimal(tbl.Rows[pos][67]);
            Tas_hosb = Convert.ToDecimal(tbl.Rows[pos][68]);
            D_a_t = Convert.ToDecimal(tbl.Rows[pos][69]);
            Es_sabeq = Convert.ToDecimal(tbl.Rows[pos][70]);
            Morabha = Convert.ToDecimal(tbl.Rows[pos][71]);
            Tawg_mor = Convert.ToDecimal(tbl.Rows[pos][72]);
            Sharq_7 = Convert.ToDecimal(tbl.Rows[pos][73]);
            Sharq_8 = Convert.ToDecimal(tbl.Rows[pos][74]);
            Sdad_sk = Convert.ToDecimal(tbl.Rows[pos][75]);
            Tawg_last_year = Convert.ToDecimal(tbl.Rows[pos][76]);
            Tawg_ksm_sabeq = Convert.ToDecimal(tbl.Rows[pos][77]);
            Twag_mor_sab = Convert.ToDecimal(tbl.Rows[pos][78]);
            Br4_daen = Convert.ToDecimal(tbl.Rows[pos][79]);
            Br4_ksm = Convert.ToDecimal(tbl.Rows[pos][80]);
            Br5_daen = Convert.ToDecimal(tbl.Rows[pos][81]);
            Br5_ksm = Convert.ToDecimal(tbl.Rows[pos][82]);
            Br6_daen = Convert.ToDecimal(tbl.Rows[pos][83]);
            Br6_ksm = Convert.ToDecimal(tbl.Rows[pos][84]);
            Last_balance = Convert.ToDecimal(tbl.Rows[pos][85]);
            Tas_madena = Convert.ToDecimal(tbl.Rows[pos][86]);
            Tas_madena_name = tbl.Rows[pos][87].ToString() as string;
            Tas_daena = Convert.ToDecimal(tbl.Rows[pos][88]);
            Ta_da_na = tbl.Rows[pos][89].ToString();
            Sh_d_m = Convert.ToDecimal(tbl.Rows[pos][90]);
            Shname1 = tbl.Rows[pos][92].ToString();
            Shcode1 = Convert.ToInt32(tbl.Rows[pos][93]);
            Shname2 = tbl.Rows[pos][94].ToString();
            Shcode2 = Convert.ToInt32(tbl.Rows[pos][95]);
            Shname3 = tbl.Rows[pos][96].ToString();
            Shcode3 = Convert.ToInt32(tbl.Rows[pos][97]);
            Shname4 = tbl.Rows[pos][98].ToString();
            Shcode4 = Convert.ToInt32(tbl.Rows[pos][99]);
            Shname5 = tbl.Rows[pos][100].ToString();
            Shcode5 = Convert.ToInt32(tbl.Rows[pos][101]);
            Shname6 = tbl.Rows[pos][102].ToString();
            Shcode6 = Convert.ToInt32(tbl.Rows[pos][103]);
            Shname7 = tbl.Rows[pos][104].ToString();
            Shcode7 = Convert.ToInt32(tbl.Rows[pos][105]);
            Shname8 = tbl.Rows[pos][106].ToString();
            Shcode8 = Convert.ToInt32(tbl.Rows[pos][107]);
            Shname9 = tbl.Rows[pos][108].ToString();
            Shcode9 = Convert.ToInt32(tbl.Rows[pos][109]);
            Shname10 = tbl.Rows[pos][110].ToString();
            Shcode10 = Convert.ToInt32(tbl.Rows[pos][111]);
            Branname1 = tbl.Rows[pos][112].ToString();
            Brancode1 = Convert.ToInt32(tbl.Rows[pos][113]);
            Branname2 = tbl.Rows[pos][114].ToString();
            Brancode2 = Convert.ToInt32(tbl.Rows[pos][115]);
            Branname3 = tbl.Rows[pos][116].ToString();
            Brancode3 = Convert.ToInt32(tbl.Rows[pos][117]);
            Branname4 = tbl.Rows[pos][118].ToString();
            Brancode4 = Convert.ToInt32(tbl.Rows[pos][119]);
            Branname5 = tbl.Rows[pos][120].ToString();
            Brancode5 = Convert.ToInt32(tbl.Rows[pos][121]);
            Branname6 = tbl.Rows[pos][122].ToString();
            Brancode6 = Convert.ToInt32(tbl.Rows[pos][123]);
            Branname7 = tbl.Rows[pos][124].ToString();
            Brancode7 = Convert.ToInt32(tbl.Rows[pos][125]);
            Darname = tbl.Rows[pos][126].ToString();
            Darcode = Convert.ToInt32(tbl.Rows[pos][127]);

        }
    }
}
