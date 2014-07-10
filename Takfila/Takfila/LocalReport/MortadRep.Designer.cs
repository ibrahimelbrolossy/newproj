namespace Takfila.LocalReport
{
    partial class MortadRep
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.MortdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MyDataSet = new Takfila.LocalReport.MyDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MortdTableAdapter = new Takfila.LocalReport.MyDataSetTableAdapters.MortdTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.MortdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // MortdBindingSource
            // 
            this.MortdBindingSource.DataMember = "Mortd";
            this.MortdBindingSource.DataSource = this.MyDataSet;
            // 
            // MyDataSet
            // 
            this.MyDataSet.DataSetName = "MyDataSet";
            this.MyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "gadrep";
            reportDataSource1.Value = this.MortdBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Takfila.LocalReport.Mortd.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(373, 45);
            this.reportViewer1.TabIndex = 0;
            // 
            // MortdTableAdapter
            // 
            this.MortdTableAdapter.ClearBeforeFill = true;
            // 
            // MortadRep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 45);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MortadRep";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "جاري الطباعة";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.MortadRep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MortdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MortdBindingSource;
        private MyDataSet MyDataSet;
        private MyDataSetTableAdapters.MortdTableAdapter MortdTableAdapter;
    }
}