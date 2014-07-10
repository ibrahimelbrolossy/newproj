namespace Takfila
{
    partial class loacaldata
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
            this.sherkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sherkaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sherkaBindingSource
            // 
            this.sherkaBindingSource.DataMember = "sherka";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // loacaldata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 261);
            this.Controls.Add(this.button1);
            this.Name = "loacaldata";
            this.Text = "loacaldata";
            this.Load += new System.EventHandler(this.loacaldata_Load);
            this.Shown += new System.EventHandler(this.loacaldata_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.sherkaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //private takfilaDataSet takfilaDataSet;
        private System.Windows.Forms.BindingSource sherkaBindingSource;
        //private takfilaDataSetTableAdapters.sherkaTableAdapter sherkaTableAdapter;
        //private System.Windows.Forms.DataGridViewTextBoxColumn shcodeDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn shnameDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn khDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn mbDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn edDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}