using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Takfila.from_web
{
    public partial class webuser : Form
    {
        public webuser()
        {
            InitializeComponent();
        }
         Takfila.Classes.DbWork db = new Classes.DbWork();
        private void webuser_Load(object sender, EventArgs e)
        {
            loaduser();
        }
        private void loaduser()
        {
            DataTable tbl = new DataTable();
            BindingSource bs = new BindingSource();
            SqlCommand cmd = new SqlCommand("SELECT users.userid, users.username, users.password, users.FullName, users.job, bransh.code, bransh.branch, users.tel3 FROM   bransh INNER JOIN users ON bransh.code = users.branch  order by tel3 desc", db.con1);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tbl);
            dataGridView1.DataSource = tbl;
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
