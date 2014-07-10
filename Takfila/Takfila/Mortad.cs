using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Takfila
{
    class Mortad : Takfila.Classes.MainTable
    {
        #region MyRegion
        private int _branch;
        private int _month;
        public int Branch
        {
            get { return _branch; }
            set { _branch = value; }
        }
       

        public int Month
        {
            get { return _month; }
            set { _month = value; }
        }
        private int _Year;

        public int Year
        {
            get { return _Year; }
            set { _Year = value; }
        }
        private decimal _first;

        public decimal First
        {
            get { return _first; }
            set { _first = value; }
        }
        private decimal _q_cheq;

        public decimal Q_cheq
        {
            get { return _q_cheq; }
            set { _q_cheq = value; }
        }
        private decimal _n_cheq;

        public decimal N_cheq
        {
            get { return _n_cheq; }
            set { _n_cheq = value; }
        }
        private decimal _grama;

        public decimal Grama
        {
            get { return _grama; }
            set { _grama = value; }
        }
        private decimal _msaref;

        public decimal Msaref
        {
            get { return _msaref; }
            set { _msaref = value; }
        }
        private decimal _sdad;

        public decimal Sdad
        {
            get { return _sdad; }
            set { _sdad = value; }
        }
        private decimal _z_tah;

        public decimal Z_tah
        {
            get { return _z_tah; }
            set { _z_tah = value; }
        }
        private decimal _tawgeh_maden;

        public decimal Tawgeh_maden
        {
            get { return _tawgeh_maden; }
            set { _tawgeh_maden = value; }
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
        private decimal _taw_m;

        public decimal Taw_m
        {
            get { return _taw_m; }
            set { _taw_m = value; }
        }
        private decimal _nakdy;

        public decimal Nakdy
        {
            get { return _nakdy; }
            set { _nakdy = value; }
        }
        private decimal _n_gra;

        public decimal N_gra
        {
            get { return _n_gra; }
            set { _n_gra = value; }
        }
        private decimal _mortag;

        public decimal Mortag
        {
            get { return _mortag; }
            set { _mortag = value; }
        }
        private decimal _gra_m;

        public decimal Gra_m
        {
            get { return _gra_m; }
            set { _gra_m = value; }
        }
        private decimal _gra_t;

        public decimal Gra_t
        {
            get { return _gra_t; }
            set { _gra_t = value; }
        }
        private decimal _gra_hq;

        public decimal Gra_hq
        {
            get { return _gra_hq; }
            set { _gra_hq = value; }
        }
        private decimal _gad_haly;

        public decimal Gad_haly
        {
            get { return _gad_haly; }
            set { _gad_haly = value; }
        }
        private decimal _gad_sabeq;

        public decimal Gad_sabeq
        {
            get { return _gad_sabeq; }
            set { _gad_sabeq = value; }
        }
        private decimal _tawgeh_daen;

        public decimal Tawgeh_daen
        {
            get { return _tawgeh_daen; }
            set { _tawgeh_daen = value; }
        }
        private decimal _eada;

        public decimal Eada
        {
            get { return _eada; }
            set { _eada = value; }
        }
        private decimal _morabha;

        public decimal Morabha
        {
            get { return _morabha; }
            set { _morabha = value; }
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
        private decimal _br4_ksm;

        public decimal Br4_ksm
        {
            get { return _br4_ksm; }
            set { _br4_ksm = value; }
        }
        private decimal _last;

        public decimal Last
        {
            get { return _last; }
            set { _last = value; }
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
        private string br1nmae;

        public string Br1nmae
        {
            get { return br1nmae; }
            set { br1nmae = value; }
        }
        private string br2name;

        public string Br2name
        {
            get { return br2name; }
            set { br2name = value; }
        }
        
        #endregion // end var
        public DataTable AllData()
        {
            string sel = "select * from mortd where branch in("+Program.b+") order by serial";
            tbl.Clear();
            tbl = DBw.Ce_runquery(sel);
            DataColumn[] keyColumn = new DataColumn[3];
            keyColumn[0] = tbl.Columns["branch"];
            keyColumn[1] = tbl.Columns["month"];
            keyColumn[2] = tbl.Columns["year"];
            //tbl.PrimaryKey = keyColumn;
            tbl.Constraints.Add("keyColumn", keyColumn, true);

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
            Branch = Convert.ToInt32(tbl.Rows[pos][1]);
            Month = Convert.ToInt32(tbl.Rows[pos][2]);
            Year = Convert.ToInt32(tbl.Rows[pos][3]);
            First = Convert.ToDecimal(tbl.Rows[pos][38]);
            Q_cheq = Convert.ToDecimal(tbl.Rows[pos][4]);
            N_cheq = Convert.ToDecimal(tbl.Rows[pos][5]);
            Grama = Convert.ToDecimal(tbl.Rows[pos][6]);
            Msaref = Convert.ToDecimal(tbl.Rows[pos][7]);
            Sdad = Convert.ToDecimal(tbl.Rows[pos][8]);
            Z_tah = Convert.ToDecimal(tbl.Rows[pos][9]);
            Tawgeh_maden = Convert.ToDecimal(tbl.Rows[pos][10]);
            Br1_madin = Convert.ToDecimal(tbl.Rows[pos][11]);
            Br1_ksm = Convert.ToDecimal(tbl.Rows[pos][12]);
            Br2_madin = Convert.ToDecimal(tbl.Rows[pos][13]);
            Br2_ksm = Convert.ToDecimal(tbl.Rows[pos][14]);
            Taw_m = Convert.ToDecimal(tbl.Rows[pos][15]);
            Nakdy = Convert.ToDecimal(tbl.Rows[pos][16]);
            N_gra = Convert.ToDecimal(tbl.Rows[pos][17]);
            Mortag = Convert.ToDecimal(tbl.Rows[pos][18]);
            Gra_m = Convert.ToDecimal(tbl.Rows[pos][19]);
            Gra_t = Convert.ToDecimal(tbl.Rows[pos][20]);
            Gra_hq = Convert.ToDecimal(tbl.Rows[pos][21]);
            Gad_haly = Convert.ToDecimal(tbl.Rows[pos][22]);
            Gad_sabeq = Convert.ToDecimal(tbl.Rows[pos][23]);
            Tawgeh_daen = Convert.ToDecimal(tbl.Rows[pos][24]);
            Eada = Convert.ToDecimal(tbl.Rows[pos][25]);
            Morabha = Convert.ToDecimal(tbl.Rows[pos][26]);
            Br3_madin = Convert.ToDecimal(tbl.Rows[pos][27]);
            Br3_ksm = Convert.ToDecimal(tbl.Rows[pos][28]);
            Br4_madin = Convert.ToDecimal(tbl.Rows[pos][29]);
            Br4_ksm = Convert.ToDecimal(tbl.Rows[pos][30]);
            Last = Convert.ToDecimal(tbl.Rows[pos][31]);
            Tas_madena = Convert.ToDecimal(tbl.Rows[pos][32]);
            Tas_madena_name =(tbl.Rows[pos][33].ToString());
            Tas_daena = Convert.ToDecimal(tbl.Rows[pos][34]);
            Ta_da_na = (tbl.Rows[pos][35].ToString());
            Br1nmae = (tbl.Rows[pos][36].ToString());
            Br2name =(tbl.Rows[pos][37].ToString());
        }
    }
}
