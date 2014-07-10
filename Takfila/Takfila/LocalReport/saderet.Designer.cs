namespace Takfila.LocalReport
{
    partial class saderet
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.saderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MyDataSet = new Takfila.LocalReport.MyDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.saderTableAdapter = new Takfila.LocalReport.MyDataSetTableAdapters.saderTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.saderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // saderBindingSource
            // 
            this.saderBindingSource.DataMember = "sader";
            this.saderBindingSource.DataSource = this.MyDataSet;
            // 
            // MyDataSet
            // 
            this.MyDataSet.DataSetName = "MyDataSet";
            this.MyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "gadrep";
            reportDataSource2.Value = this.saderBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Takfila.LocalReport.saderet.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(360, 61);
            this.reportViewer1.TabIndex = 0;
            // 
            // saderTableAdapter
            // 
            this.saderTableAdapter.ClearBeforeFill = true;
            // 
            // saderet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 61);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "saderet";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "جاري الطباعة";
            this.Load += new System.EventHandler(this.saderet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.saderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource saderBindingSource;
        private MyDataSet MyDataSet;
        private MyDataSetTableAdapters.saderTableAdapter saderTableAdapter;
    }
}