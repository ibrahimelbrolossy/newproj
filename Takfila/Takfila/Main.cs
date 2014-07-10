using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Takfila
{

    public partial class Main : Form
    {
        Takfila.Classes.DbWork db = new Classes.DbWork();
        ComboBox br_find1 = null;
        public Main()
        {
            InitializeComponent();
        }

        private void تقفيلةالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserEntry u = new UserEntry();
            showMdiChild(u);
        }

        private void تقفيلةالمرتدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MorEntry m = new MorEntry();
            showMdiChild(m);
        }

        private void تحميلالمرفقاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreparePrint p = new PreparePrint();
            p.ShowDialog();
        }


        private void Main_Load(object sender, EventArgs e)
        {
            login l = new login();
            l.ShowDialog();
            if (Program.a != "")
            {
                toolStrip1.Visible = true;
                menuStrip1.Visible = true;

                db.fill_branch(br_find);
                br_find1 = br_find.ComboBox;
                DateTime d1 = DateTime.Today;
                mon_find.Text = d1.Month.ToString();
                year_find.Text = d1.Year.ToString();
                ToolStripControlHost tshost1 = new ToolStripControlHost(mon_find);
                ToolStripControlHost tshost2 = new ToolStripControlHost(year_find);
                toolStrip1.Items.Add(tshost1);
                toolStrip1.Items.Add(toolStripSeparator3);
                toolStrip1.Items.Add(toolStripSeparator4);
                toolStrip1.Items.Add(toolStripLabel2);
                toolStrip1.Items.Add(tshost2);




            }

        }

        private void حسابالمرتدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable tbl = new DataTable();
            tbl = db.runquery("select branch,month,year from mortd where branch='" + br_find1.SelectedValue + "' and month='" + mon_find.Text + "' and year='" + year_find.Text + "' ");
            if (tbl.Rows.Count == 1)
            {
                if (br_find1.SelectedIndex != -1)
                {
                    Form frm = new Form();
                    frm = new repmor((int)br_find1.SelectedValue, Convert.ToInt32(mon_find.Text), Convert.ToInt32(year_find.Text), "mortd1");
                    showMdiChild(frm);
                }
                else
                    MessageBox.Show("اختار الفرع من فضلك");
            }
            else
                MessageBox.Show("لم يتم تسجيل البيانات");

        }

        private void حسابالعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.def_P = "";

            DataTable tbl = new DataTable();
            tbl = db.runquery("select branch_id,t_month,t_year from Customers where branch_id='" + br_find1.SelectedValue + "' and t_month='" + mon_find.Text + "' and t_year='" + year_find.Text + "' ");
            if (br_find1.SelectedIndex != -1)
            {
                if (tbl.Rows.Count == 1)
                {
                    Form frm = new Form();
                    frm = new repmor((int)br_find1.SelectedValue, Convert.ToInt32(mon_find.Text), Convert.ToInt32(year_find.Text), "cus");
                    showMdiChild(frm);

                }
                else
                    MessageBox.Show("لم يتم تسجيل البيانات");
            }
            else
                MessageBox.Show("اختار الفرع من فضلك" );

        }

        private void قيدالخصمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable tbl = new DataTable();
            tbl = db.runquery("select branch_id,t_month,t_year from Customers where branch_id='" + br_find1.SelectedValue + "' and t_month='" + mon_find.Text + "' and t_year='" + year_find.Text + "' ");
            if (tbl.Rows.Count == 1)
            {
                if (br_find1.SelectedIndex != -1)
                {
                    Form frm = new Form();
                    frm = new repmor((int)br_find1.SelectedValue, Convert.ToInt32(mon_find.Text), Convert.ToInt32(year_find.Text), "ked_ksm");
                    showMdiChild(frm);
                }
                else
                    MessageBox.Show("اختار الفرع من فضلك");
            }
            else
                MessageBox.Show("لم يتم تسجيل البيانات");

        }

        private void قيدالجدولةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable tbl = new DataTable();
            tbl = db.runquery("select branch_id,t_month,t_year from Customers where branch_id='" + br_find1.SelectedValue + "' and t_month='" + mon_find.Text + "' and t_year='" + year_find.Text + "' ");
            if (tbl.Rows.Count == 1)
            {
                if (br_find1.SelectedIndex != -1)
                {
                    Form frm = new Form();
                    frm = new repmor((int)br_find1.SelectedValue, Convert.ToInt32(mon_find.Text), Convert.ToInt32(year_find.Text), "ked_gad");
                    showMdiChild(frm);
                }
                else
                    MessageBox.Show("اختار الفرع من فضلك");
            }
            else
                MessageBox.Show("لم يتم تسجيل البيانات");

        }

        private void قيدسدادالفروعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable tbl = new DataTable();
            tbl = db.runquery("select branch_id,t_month,t_year from Customers where branch_id='" + br_find1.SelectedValue + "' and t_month='" + mon_find.Text + "' and t_year='" + year_find.Text + "' ");
            if (tbl.Rows.Count == 1)
            {
                if (br_find1.SelectedIndex != -1)
                {
                    Form frm = new Form();
                    frm = new repmor((int)br_find1.SelectedValue, Convert.ToInt32(mon_find.Text), Convert.ToInt32(year_find.Text), "ked_br");
                    showMdiChild(frm);
                }
                else
                    MessageBox.Show("اختار الفرع من فضلك");
            }
            else
                MessageBox.Show("لم يتم تسجيل البيانات");

        }

        private void التحميلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ftpForm f = new ftpForm();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loacaldata l = new loacaldata();
            l.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable tbl = new DataTable();
            tbl = db.Ce_runquery("select branch_id,t_month,t_year from Customers where branch_id='" + br_find1.SelectedValue + "' and t_month='" + mon_find.Text + "' and t_year='" + year_find.Text + "' ");
            if (tbl.Rows.Count == 1)
            {
                if (br_find1.SelectedIndex != -1)
                {
                    LocalReport.viewr v = new LocalReport.viewr((int)br_find1.SelectedValue, Convert.ToInt32(mon_find.Text), Convert.ToInt32(year_find.Text));
                    v.ShowDialog();
                }
                else
                    MessageBox.Show("اختار الفرع من فضلك");
            }
            else
                MessageBox.Show("لم يتم تسجيل البيانات");
        }

        private void صادرالبنكواائتمانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sader_Bank s = new Sader_Bank();
            showMdiChild(s);
        }

        private void قيدالفروعToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.def_P = "";
            DataTable tbl = new DataTable();
            tbl = db.Ce_runquery("select branch_id,t_month,t_year from Customers where branch_id='" + br_find1.SelectedValue + "' and t_month='" + mon_find.Text + "' and t_year='" + year_find.Text + "' ");
            if (tbl.Rows.Count == 1)
            {
                if (br_find1.SelectedIndex != -1)
                {
                    LocalReport.brviewer b = new LocalReport.brviewer((int)br_find1.SelectedValue, Convert.ToInt32(mon_find.Text), Convert.ToInt32(year_find.Text));
                    b.ShowDialog();
                }
                else
                    MessageBox.Show("اختار الفرع من فضلك");
            }
            else
                MessageBox.Show("لم يتم تسجيل البيانات");
        }

        private void قيدالجدولةToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Program.def_P = "";
            DataTable tbl = new DataTable();
            tbl = db.Ce_runquery("select branch_id,t_month,t_year from Customers where branch_id='" + br_find1.SelectedValue + "' and t_month='" + mon_find.Text + "' and t_year='" + year_find.Text + "' ");
            if (tbl.Rows.Count == 1)
            {
                if (br_find1.SelectedIndex != -1)
                {
                    LocalReport.viewr k = new LocalReport.viewr((int)br_find1.SelectedValue, Convert.ToInt32(mon_find.Text), Convert.ToInt32(year_find.Text));
                    k.ShowDialog();
                }
                else
                    MessageBox.Show("اختار الفرع من فضلك");
            }
            else
                MessageBox.Show("لم يتم تسجيل البيانات");
        }

        private void حسابالعملاءToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Program.def_P = "";
            DataTable tbl = new DataTable();
            tbl = db.Ce_runquery("select branch_id,t_month,t_year from Customers where branch_id='" + br_find1.SelectedValue + "' and t_month='" + mon_find.Text + "' and t_year='" + year_find.Text + "' ");
            if (tbl.Rows.Count == 1)
            {
                if (br_find1.SelectedIndex != -1)
                {
                    LocalReport.CusView c = new LocalReport.CusView((int)br_find1.SelectedValue, Convert.ToInt32(mon_find.Text), Convert.ToInt32(year_find.Text));
                    c.ShowDialog();
                }
                else
                    MessageBox.Show("اختار الفرع من فضلك");
            }
            else
                MessageBox.Show("لم يتم تسجيل البيانات");
        }

        private void حسابالمرتدToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Program.def_P = "";
            DataTable tbl = new DataTable();
            tbl = db.Ce_runquery("select branch,month,year from mortd where branch='" + br_find1.SelectedValue + "' and month='" + mon_find.Text + "' and year='" + year_find.Text + "' ");
            if (tbl.Rows.Count == 1)
            {
                if (br_find1.SelectedIndex != -1)
                {
                    LocalReport.MortadRep c = new LocalReport.MortadRep((int)br_find1.SelectedValue, Convert.ToInt32(mon_find.Text), Convert.ToInt32(year_find.Text));
                    c.ShowDialog();
                }
                else
                    MessageBox.Show("اختار الفرع من فضلك");
            }
            else
                MessageBox.Show("لم يتم تسجيل البيانات");
        }

        private void توجيهمنعملاءالىمرتدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.def_P = "";
            DataTable tbl = new DataTable();
            tbl = db.Ce_runquery("select branch_id,t_month,t_year from Customers where branch_id='" + br_find1.SelectedValue + "' and t_month='" + mon_find.Text + "' and t_year='" + year_find.Text + "' ");
            if (tbl.Rows.Count == 1)
            {
                if (br_find1.SelectedIndex != -1)
                {
                    LocalReport.cusmor c = new LocalReport.cusmor((int)br_find1.SelectedValue, Convert.ToInt32(mon_find.Text), Convert.ToInt32(year_find.Text));
                    c.ShowDialog();
                }
                else
                    MessageBox.Show("اختار الفرع من فضلك");
            }
            else
                MessageBox.Show("لم يتم تسجيل البيانات");
        }

        private void قيدصادرالعيناتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.def_P = "";
            DataTable tbl = new DataTable();
            tbl = db.Ce_runquery("select branch_id,t_month,t_year from Customers where branch_id='" + br_find1.SelectedValue + "' and t_month='" + mon_find.Text + "' and t_year='" + year_find.Text + "' ");
            if (tbl.Rows.Count == 1)
            {
                if (br_find1.SelectedIndex != -1)
                {
                    LocalReport.DarM c = new LocalReport.DarM((int)br_find1.SelectedValue, Convert.ToInt32(mon_find.Text), Convert.ToInt32(year_find.Text));
                    c.ShowDialog();
                }
                else
                    MessageBox.Show("اختار الفرع من فضلك");
            }
            else
                MessageBox.Show("لم يتم تسجيل البيانات");
        }

        private void توجيهمنمرتدلعملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.def_P = "";
            DataTable tbl = new DataTable();
            tbl = db.Ce_runquery("select branch_id,t_month,t_year from Customers where branch_id='" + br_find1.SelectedValue + "' and t_month='" + mon_find.Text + "' and t_year='" + year_find.Text + "' ");
            if (tbl.Rows.Count == 1)
            {
                if (br_find1.SelectedIndex != -1)
                {
                    LocalReport.morcus c = new LocalReport.morcus((int)br_find1.SelectedValue, Convert.ToInt32(mon_find.Text), Convert.ToInt32(year_find.Text));
                    c.ShowDialog();
                }
                else
                    MessageBox.Show("اختار الفرع من فضلك");
            }
            else
                MessageBox.Show("لم يتم تسجيل البيانات");

        }

        private void قيدغراماتحقعميلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.def_P = "";
            DataTable tbl = new DataTable();
            tbl = db.Ce_runquery("select branch,month,year from mortd where branch='" + br_find1.SelectedValue + "' and month='" + mon_find.Text + "' and year='" + year_find.Text + "' ");
            if (tbl.Rows.Count == 1)
            {
                if (br_find1.SelectedIndex != -1)
                {
                    LocalReport.grama c = new LocalReport.grama((int)br_find1.SelectedValue, Convert.ToInt32(mon_find.Text), Convert.ToInt32(year_find.Text));
                    c.ShowDialog();
                }
                else
                    MessageBox.Show("اختار الفرع من فضلك");
            }
            else
                MessageBox.Show("لم يتم تسجيل البيانات");
        }

        private void قيدالبنكToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.def_P = "";
            DataTable tbl = new DataTable();
            tbl = db.Ce_runquery("select branch,s_month,s_year from sader_b_e where branch='" + br_find1.SelectedValue + "' and s_month='" + mon_find.Text + "' and s_year='" + year_find.Text + "' ");
            if (tbl.Rows.Count == 1)
            {
                if (br_find1.SelectedIndex != -1)
                {
                    LocalReport.sad c = new LocalReport.sad((int)br_find1.SelectedValue, Convert.ToInt32(mon_find.Text), Convert.ToInt32(year_find.Text));
                    c.ShowDialog();
                }
                else
                    MessageBox.Show("اختار الفرع من فضلك");
            }
            else
                MessageBox.Show("لم يتم تسجيل البيانات");
        }

        private void قيدصادرالائتمانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.def_P = "";
            DataTable tbl = new DataTable();
            tbl = db.Ce_runquery("select branch,s_month,s_year from sader_b_e where branch='" + br_find1.SelectedValue + "' and s_month='" + mon_find.Text + "' and s_year='" + year_find.Text + "' ");
            if (tbl.Rows.Count == 1)
            {
                if (br_find1.SelectedIndex != -1)
                {
                    LocalReport.saderet c = new LocalReport.saderet((int)br_find1.SelectedValue, Convert.ToInt32(mon_find.Text), Convert.ToInt32(year_find.Text));
                    c.ShowDialog();
                }
                else
                    MessageBox.Show("اختار الفرع من فضلك");
            }
            else
                MessageBox.Show("لم يتم تسجيل البيانات");

        }

        private void قيدالخصمالمسموحToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.def_P = "";
            DataTable tbl = new DataTable();
            tbl = db.Ce_runquery("select branch_id,t_month,t_year from Customers where branch_id='" + br_find1.SelectedValue + "' and t_month='" + mon_find.Text + "' and t_year='" + year_find.Text + "' ");
            if (tbl.Rows.Count == 1)
            {
                if (br_find1.SelectedIndex != -1)
                {
                    LocalReport.kedksmmas v = new LocalReport.kedksmmas((int)br_find1.SelectedValue, Convert.ToInt32(mon_find.Text), Convert.ToInt32(year_find.Text));
                    v.ShowDialog();
                }
                else
                    MessageBox.Show("اختار الفرع من فضلك");
            }
            else
                MessageBox.Show("لم يتم تسجيل البيانات");
        }

        private void prentmor()
        {
            DataTable tbl = new DataTable();
            tbl = db.Ce_runquery("select branch,month,year from mortd where branch='" + br_find1.SelectedValue + "' and month='" + mon_find.Text + "' and year='" + year_find.Text + "' ");

            if (br_find1.SelectedIndex != -1)
            {
                if (tbl.Rows.Count == 1)
                {

                    LocalReport.grama c = new LocalReport.grama((int)br_find1.SelectedValue, Convert.ToInt32(mon_find.Text), Convert.ToInt32(year_find.Text));
                    c.ShowDialog();
                    LocalReport.MortadRep x = new LocalReport.MortadRep((int)br_find1.SelectedValue, Convert.ToInt32(mon_find.Text), Convert.ToInt32(year_find.Text));
                    x.ShowDialog();
                }
                else

                    MessageBox.Show("لم يتم تسجيل بيانات المرتد");
            }
            else
                MessageBox.Show("اختار الفرع من فضلك");
        }
        private void prentsader()
        {
            DataTable tbl = new DataTable();
            tbl = db.Ce_runquery("select branch,s_month,s_year from sader_b_e where branch='" + br_find1.SelectedValue + "' and s_month='" + mon_find.Text + "' and s_year='" + year_find.Text + "' ");

            if (br_find1.SelectedIndex != -1)
            {
                if (tbl.Rows.Count == 1)
                {
                    LocalReport.sad c = new LocalReport.sad((int)br_find1.SelectedValue, Convert.ToInt32(mon_find.Text), Convert.ToInt32(year_find.Text));
                    c.ShowDialog();
                    LocalReport.saderet e = new LocalReport.saderet((int)br_find1.SelectedValue, Convert.ToInt32(mon_find.Text), Convert.ToInt32(year_find.Text));
                    e.ShowDialog();
                }
                else
                    MessageBox.Show(" لم يتم تسجيل بيانات صادر البنوك والئتمان  ");
            }
            else
                MessageBox.Show(" اختار الفرع من فضلك ");
        }

        private void br_find_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void br_find_Validating(object sender, CancelEventArgs e)
        {
            if (br_find1.SelectedIndex > -1)
                return;
            else
            {

                br_find1.SelectedIndex = -1;
                br_find1.Text = "";
            }
        }

        private void br_find_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
                return;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {


            string bakfile = "backup " + DateTime.Now.ToString("d-M-yyyy");
            //MessageBox.Show(bakfile);
            File.Copy("Mylocaldatabase.sdf", @"e:\" + bakfile + ".sdf");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Takfila.from_web.webuser w = new from_web.webuser();
            w.ShowDialog();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            from_web.webuser m = new from_web.webuser();
            m.ShowDialog();

        }

        private void طباعةجميعالتقاريرToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void showMdiChild( Form chlfrm)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType() == chlfrm.GetType())
                {
                    frm.Focus();
                    return;
                }
            }

            chlfrm.MdiParent = this;
            chlfrm.Show();
            chlfrm.Dock = DockStyle.Fill;

        }

        private void طباعةالتقفيلةكاملةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.def_P = "";
            DataTable tbl = new DataTable();
            tbl = db.Ce_runquery("select branch_id,t_month,t_year from Customers where branch_id='" + br_find1.SelectedValue + "' and t_month='" + mon_find.Text + "' and t_year='" + year_find.Text + "' ");
            PrintDialog pd = new PrintDialog();
            DialogResult pdr = pd.ShowDialog();
            if (pdr == System.Windows.Forms.DialogResult.OK)
            {
                Program.def_P = pd.PrinterSettings.PrinterName;

                if (br_find1.SelectedIndex != -1)
                {
                    if (tbl.Rows.Count == 1)
                    {
                        LocalReport.CusView n = new LocalReport.CusView((int)br_find1.SelectedValue, Convert.ToInt32(mon_find.Text), Convert.ToInt32(year_find.Text));
                        n.Show();
                        LocalReport.kedksmmas v = new LocalReport.kedksmmas((int)br_find1.SelectedValue, Convert.ToInt32(mon_find.Text), Convert.ToInt32(year_find.Text));
                        v.Show();
                        LocalReport.viewr k = new LocalReport.viewr((int)br_find1.SelectedValue, Convert.ToInt32(mon_find.Text), Convert.ToInt32(year_find.Text));
                        k.ShowDialog();
                        LocalReport.DarM c = new LocalReport.DarM((int)br_find1.SelectedValue, Convert.ToInt32(mon_find.Text), Convert.ToInt32(year_find.Text));
                        c.Show();
                        LocalReport.morcus m = new LocalReport.morcus((int)br_find1.SelectedValue, Convert.ToInt32(mon_find.Text), Convert.ToInt32(year_find.Text));
                        m.ShowDialog();
                        LocalReport.cusmor y = new LocalReport.cusmor((int)br_find1.SelectedValue, Convert.ToInt32(mon_find.Text), Convert.ToInt32(year_find.Text));
                        y.ShowDialog();
                        LocalReport.brviewer b = new LocalReport.brviewer((int)br_find1.SelectedValue, Convert.ToInt32(mon_find.Text), Convert.ToInt32(year_find.Text));
                        b.ShowDialog();
                        prentmor();
                        prentsader();
                    }
                    else
                        MessageBox.Show("لم يتم تسجيل البيانات");
                }
                else
                    MessageBox.Show("اختار الفرع من فضلك");

                Program.def_P = "";


            }
            if (pdr == System.Windows.Forms.DialogResult.Cancel)
            {
                MessageBox.Show("تم إلغاء الطباعة");
                return;
            }



        }

    }
}
