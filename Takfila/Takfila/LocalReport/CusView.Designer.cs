namespace Takfila.LocalReport
{
    partial class CusView
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
            this.CustBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MyDataSet = new Takfila.LocalReport.MyDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CustTableAdapter = new Takfila.LocalReport.MyDataSetTableAdapters.CustTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CustBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // CustBindingSource
            // 
            this.CustBindingSource.DataMember = "Cust";
            this.CustBindingSource.DataSource = this.MyDataSet;
            // 
            // MyDataSet
            // 
            this.MyDataSet.DataSetName = "MyDataSet";
            this.MyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.DocumentMapWidth = 82;
            reportDataSource1.Name = "gadrep";
            reportDataSource1.Value = this.CustBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Takfila.LocalReport.Customer.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(184, 62);
            this.reportViewer1.TabIndex = 0;
            // 
            // CustTableAdapter
            // 
            this.CustTableAdapter.ClearBeforeFill = true;
            // 
            // CusView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 62);
            this.ControlBox = false;
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CusView";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "طباعة حساب العملاء";
            this.Load += new System.EventHandler(this.CusView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CustBindingSource;
        private MyDataSet MyDataSet;
        private MyDataSetTableAdapters.CustTableAdapter CustTableAdapter;
    }
}