﻿namespace Takfila.LocalReport
{
    partial class brviewer
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
            this.KedGadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MyDataSet = new Takfila.LocalReport.MyDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.kedGadDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KedGadTableAdapter = new Takfila.LocalReport.MyDataSetTableAdapters.KedGadTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.KedGadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kedGadDataTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // KedGadBindingSource
            // 
            this.KedGadBindingSource.DataMember = "KedGad";
            this.KedGadBindingSource.DataSource = this.MyDataSet;
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
            reportDataSource1.Value = this.KedGadBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Takfila.LocalReport.kedbranch.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(385, 82);
            this.reportViewer1.TabIndex = 4;
            this.reportViewer1.Visible = false;
            // 
            // kedGadDataTableBindingSource
            // 
            this.kedGadDataTableBindingSource.DataSource = typeof(Takfila.LocalReport.MyDataSet.KedGadDataTable);
            // 
            // KedGadTableAdapter
            // 
            this.KedGadTableAdapter.ClearBeforeFill = true;
            // 
            // brviewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 82);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "brviewer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "جاري الطباعة";
            this.Load += new System.EventHandler(this.brviewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KedGadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kedGadDataTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource KedGadBindingSource;
        private MyDataSet MyDataSet;
        private MyDataSetTableAdapters.KedGadTableAdapter KedGadTableAdapter;
        private System.Windows.Forms.BindingSource kedGadDataTableBindingSource;
    }
}