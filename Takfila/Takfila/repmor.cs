using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Takfila
{
    public partial class repmor : Form
    {
        int _bc, _mc, _yc;
        string _repneame;
        public repmor(int bc , int mc,int yc,string repname)
        {
            _bc = bc;
            _mc = mc;
            _yc = yc;
            _repneame = repname;
            InitializeComponent();
        }
         //UserEntry u = new UserEntry();
        private void repmor_Load(object sender, EventArgs e)
        {
            ReportDocument cryRpt = new ReportDocument();
            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            Tables CrTables;

            cryRpt.Load(Application.StartupPath + "\\"+_repneame+".rpt ");
            
            //crConnectionInfo.ServerName = "survay2.db.11066803.hostedresource.com";
            //crConnectionInfo.DatabaseName = "survay2";
            //crConnectionInfo.UserID = "survay2";
            //crConnectionInfo.Password = "A626239@mm";

            System.Data.SqlClient.SqlConnectionStringBuilder dbb = new System.Data.SqlClient.SqlConnectionStringBuilder(System.Configuration.ConfigurationManager.ConnectionStrings["takConn"].ConnectionString);
            crConnectionInfo.ServerName = dbb.DataSource;
            crConnectionInfo.DatabaseName = dbb.InitialCatalog;
            crConnectionInfo.UserID = dbb.UserID;
            crConnectionInfo.Password = dbb.Password;

            ParameterFields parameterFileds = new ParameterFields();
            ParameterField paraFiled = new ParameterField();
            ParameterDiscreteValue paraDescritValue;
            ParameterField paraFiled1 = new ParameterField();
            ParameterDiscreteValue paraDescritValue1;
            ParameterField paraFiled2 = new ParameterField();
            ParameterDiscreteValue paraDescritValue2;

            paraFiled.Name = "b_c";
            paraFiled.CurrentValues.Clear();
            paraDescritValue = new ParameterDiscreteValue();
            paraDescritValue.Value = _bc;
            paraFiled.CurrentValues.Add(paraDescritValue);
            parameterFileds.Add(paraFiled);


            paraFiled1.Name = "b_m";
            paraFiled1.CurrentValues.Clear();
            paraDescritValue1 = new ParameterDiscreteValue();
            paraDescritValue1.Value =_mc;
            paraFiled1.CurrentValues.Add(paraDescritValue1);
            parameterFileds.Add(paraFiled1);

            paraFiled2.Name = "b_y";
            paraFiled2.CurrentValues.Clear();
            paraDescritValue2 = new ParameterDiscreteValue();
            paraDescritValue2.Value = _yc;
            paraFiled2.CurrentValues.Add(paraDescritValue2);
            parameterFileds.Add(paraFiled2);

            CrTables = cryRpt.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            {
                crtableLogoninfo = CrTable.LogOnInfo;
                crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                CrTable.ApplyLogOnInfo(crtableLogoninfo);
            }
            crystalReportViewer1.ParameterFieldInfo = parameterFileds;
            crystalReportViewer1.ReportSource = cryRpt;
           // //crystalReportViewer1.Refresh();
           // //crystalReportViewer1.RefreshReport();
            
           // //parameter reports
           
           

           
        }
    }
}
