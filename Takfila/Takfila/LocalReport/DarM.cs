﻿using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Takfila.LocalReport
{
    public partial class DarM : Form
    {
       
         int _bc, _mc, _yc;
        public DarM(int bc, int mc, int yc)
        {
            InitializeComponent();
            _bc = bc;
            _mc = mc;
            _yc = yc;
        }

        private void DarM_Load(object sender, EventArgs e)
        {
          
            this.KedGadTableAdapter.Fill(this.MyDataSet.KedGad, _bc, _mc, _yc);

            reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.Percent;
            if (Program.def_P == "")
            {
                PrintDialog pd = new PrintDialog();
                DialogResult pdr = pd.ShowDialog();
                if (pdr == System.Windows.Forms.DialogResult.OK)
                {
                    Program.def_P = pd.PrinterSettings.PrinterName;
                }
                if (pdr == System.Windows.Forms.DialogResult.Cancel)
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
