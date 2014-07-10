using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Takfila.LocalReport
{
    public partial class CusView : Form
    {
        int _bc, _mc, _yc;
        public CusView(int bc, int mc, int yc)
        {
            InitializeComponent();
            _bc = bc;
            _mc = mc;
            _yc = yc;
        }

        private void CusView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'MyDataSet.Cust' table. You can move, or remove it, as needed.
            this.CustTableAdapter.Fill(this.MyDataSet.Cust,_bc,_mc,_yc);
            reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            if (Program.def_P == "")
            {
                PrintDialog pd = new PrintDialog();
                DialogResult pdr = pd.ShowDialog();
                if(pdr== System.Windows.Forms.DialogResult.OK)
                {
                    Program.def_P = pd.PrinterSettings.PrinterName;
                }
                if (pdr== System.Windows.Forms.DialogResult.Cancel)
                {
                    this.Close();
                }
            }

            AutoPrint();
            this.Close();
        }
        private void AutoPrint()
        {
            AutoPrintCls autoprintme = new AutoPrintCls(reportViewer1.LocalReport);
            autoprintme.PrinterSettings.PrinterName = Program.def_P;
            autoprintme.Print();
        }
    }
}
