using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace Takfila.Classes
{
    class DbWork
    {
        SqlConnection conn;
        SqlCommand cmd;
        //SqlCeCommand cmd1;
        DataTable tbl;
        //protected int pos;
        public SqlCeConnection con = new SqlCeConnection(@"Data Source= |DataDirectory|\Mylocaldatabase.sdf");
        public SqlConnection con1 = new SqlConnection(ConfigurationManager.ConnectionStrings["takConn2"].ConnectionString);
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
        public void Connect(CommandType CT, string ProSql)
        {
            try
            {
                conn = new SqlConnection(ConfigurationManager.ConnectionStrings["taKConn"].ConnectionString);
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CT;
                cmd.CommandText = ProSql;
                conn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("تأكد من الاتصال بالانترنت");
                Application.Exit();
             }
        }
        public int RunPro(string storedname, SortedList ParVal)
        {
            Connect(CommandType.StoredProcedure, storedname);
            for (int x = 0; x < ParVal.Count; x++)
                cmd.Parameters.AddWithValue(ParVal.GetKey(x).ToString(), ParVal.GetByIndex(x).ToString());
            return RunUpdate();
            
        }
        public int RunUpdate(string InsDelUp)
        {
            Connect(CommandType.Text, InsDelUp);
            return RunUpdate();
        }
        private int RunUpdate()
        {
            try
            {
                int n = cmd.ExecuteNonQuery();
                conn.Close();
                return n;
            }
            catch (SqlException ex)
            {
                conn.Close();
                return ex.Number;
            }
        }
        public DataTable runquery(string select)
        {
            Connect(CommandType.Text, select);
            tbl = new DataTable();
            tbl.Load(cmd.ExecuteReader());
            conn.Close();
            return tbl;
        }

        public DataTable Ce_runquery(string select)
        {
            SqlCeCommand cmd = new SqlCeCommand(select, con);
            tbl = new DataTable();
            con.Open();
            tbl.Load(cmd.ExecuteReader());
            con.Close();
            return tbl;
        }
        public void fill_sh(ComboBox cbm)
        {
            SqlCeCommand cmd = new SqlCeCommand ("select shcode,sh_name from sherka",con);
            DataTable tbl = new DataTable();
            //tbl = runquery("select shcode,sh_name from sherka");
            try
            {
                con.Open();
                tbl.Load(cmd.ExecuteReader());
                con.Close();
            }
            catch (SqlCeException ex)
            {

                MessageBox.Show(ex.Message);
                con.Close();
            }
            cbm.DataSource = tbl;
            cbm.DisplayMember = tbl.Columns[1].ToString();
            cbm.ValueMember = tbl.Columns[0].ToString();
            cbm.SelectedIndex = -1;
            cbm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cbm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            cbm.DropDownStyle = ComboBoxStyle.DropDown;
        }
        public void fill_branch1(ComboBox cbm)
        {

            SqlCeCommand cmd = new SqlCeCommand("select code,branch from branch", con);
            DataTable tbl = new DataTable();
            //tbl = runquery("select code,branch from branch");
            try
            {
                con.Open();
                tbl.Load(cmd.ExecuteReader());
                con.Close();
            }
            catch (SqlCeException ex)
            {

                MessageBox.Show(ex.Message);
                con.Close();
            }
            cbm.DataSource = tbl;
            cbm.DisplayMember = tbl.Columns[1].ToString();
            cbm.ValueMember = tbl.Columns[0].ToString();
            cbm.SelectedIndex = -1;
            cbm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cbm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            cbm.DropDownStyle = ComboBoxStyle.DropDown;
        }
        public void fill_branch(ToolStripComboBox cbm)
        {
            SqlCeCommand cmd = new SqlCeCommand(Program.a, con);
            DataTable tbl = new DataTable();
            //tbl = runquery("select code,branch from branch");
            try
            {
                con.Open();
                tbl.Load(cmd.ExecuteReader());
                con.Close();
            }
            catch (SqlCeException ex)
            {

                MessageBox.Show(ex.Message);
                con.Close();
            }
            cbm.ComboBox.DataSource = tbl;
            cbm.ComboBox.DisplayMember = tbl.Columns[1].ToString();
            cbm.ComboBox.ValueMember = tbl.Columns[0].ToString();
            cbm.ComboBox.SelectedIndex = -1;
            cbm.ComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            cbm.ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public void fill_branch(ComboBox cbm)
        {
            SqlCeCommand cmd = new SqlCeCommand(Program.a, con);
            DataTable tbl = new DataTable();
            //tbl = runquery("select code,branch from branch");
            try
            {
                con.Open();
                tbl.Load(cmd.ExecuteReader());
                con.Close();
            }
            catch (SqlCeException ex)
            {

                MessageBox.Show(ex.Message);
                con.Close();
            }
            cbm.DataSource = tbl;
            cbm.DisplayMember = tbl.Columns[1].ToString();
            cbm.ValueMember = tbl.Columns[0].ToString();
            cbm.SelectedIndex = -1;
            cbm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            cbm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems  ;
            cbm.DropDownStyle = ComboBoxStyle.DropDown;
        }
        public void chekcombo(ComboBox cbm)
            {
                 if (cbm.SelectedIndex > -1)
                return;
            else
            {

                cbm.SelectedIndex = -1;
                cbm.Text = "";
            }
            }
        public int sel_max(string sel)
        {
            Connect(CommandType.Text, sel);
            int x = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();
            return x;
        }
        
    }
}
