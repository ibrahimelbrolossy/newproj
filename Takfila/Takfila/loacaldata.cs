using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.IO;

namespace Takfila
{
    public partial class loacaldata : Form
    {
        public loacaldata()
        {
            InitializeComponent();
        }
        public SqlCeConnection con = new SqlCeConnection(@"Data Source=G:\MyWebSites\2014\Takfila\Takfila\bin\Debug\Mylocaldatabase.sdf");
        private void loacaldata_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'takfilaDataSet.sherka' table. You can move, or remove it, as needed.
         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlCeCommand cmd = new SqlCeCommand(" insert into sherka(shcode,sh_name,kh,mb,ed) values (@code,@name,@kh,@mb,@ed)", con);
            //foreach (DataGridViewRow row in dgv.Rows)
            //{
            //    if (!row.IsNewRow)
            //    {
            //        cmd.Parameters.AddWithValue("@code",row.Cells[0].Value);
            //        cmd.Parameters.AddWithValue("@name", row.Cells[1].Value);
            //        cmd.Parameters.AddWithValue("@kh", row.Cells[2].Value);
            //        cmd.Parameters.AddWithValue("@mb", row.Cells[3].Value);
            //        cmd.Parameters.AddWithValue("@ed", row.Cells[4].Value);
            //        cmd.ExecuteNonQuery();
            //        cmd.Parameters.Clear();
            //    }
            //}
            //MessageBox.Show("تم صرف عدد   " + (dgv.Rows.Count - 1).ToString() + "  سلعة ");
        
             //string constring = Properties.Settings.Default.mydataConnectionString;
            //SqlCeConnection conn = new SqlCeConnection(constring);
            if (File.Exists(Application.StartupPath+" \\Mylocaldatabase.sdf") == true)
            {
                SqlCeCommand cmd;
                string sql1 = "CREATE TABLE Sader_B_E("
                  + "[id] [int] IDENTITY(1,1) NOT NULL,"
                  + "[branch] [int] NOT NULL,"
                  + "[s_month] [int] NOT NULL,"
                  + "[s_year] [int] NOT NULL,"
                  + "[S_bank1] [float] NULL,"
                  + "[s_b1_name] [nvarchar] (255) NULL,"
                  + "[S_bank2] [float] NULL,"
                  + "[s_b2_name] [nvarchar] (255) NULL,"
                  + "[S_bank3] [float] NULL,"
                  + "[s_b3_name] [nvarchar] (255) NULL,"
                  + "[S_eatman] [float] NULL,"
                  + "[memo] [nvarchar](255) NULL,"
                  + "CONSTRAINT cu_pk  PRIMARY KEY ("
                  +"[branch] ,"
                  +"[S_month] ,"
	              +"[S_year]))";

                cmd = new SqlCeCommand(sql1, con);
 
              try
              {
               
                cmd.ExecuteNonQuery();
               
                  MessageBox.Show("ok create");
              }
              catch (SqlCeException sqlexception)
              {
                MessageBox.Show(sqlexception.Message, "Oh Fudge.",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
              }
              catch (Exception ex)
              {
                MessageBox.Show(ex.Message, "Fooey.", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
              }
              finally
              {
                con.Close();
              }
            }
            else
                MessageBox.Show("error");
       
        }

        private void loacaldata_Shown(object sender, EventArgs e)
        {
            try
            {
                con.Open();
            }
            catch (SqlCeException ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
