namespace POS_SYSTEM
{
    partial class CreditReport
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.db_creditViewReport = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_filterDate = new System.Windows.Forms.Button();
            this.txt_totalcreditamount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_creditViewReport)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reportViewer1);
            this.groupBox1.Controls.Add(this.btn_refresh);
            this.groupBox1.Controls.Add(this.txt_search);
            this.groupBox1.Controls.Add(this.db_creditViewReport);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_filterDate);
            this.groupBox1.Controls.Add(this.txt_totalcreditamount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(65, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1028, 534);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credit Report";
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "POS_SYSTEM.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(120, 111);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(684, 399);
            this.reportViewer1.TabIndex = 31;
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_refresh.Image = global::POS_SYSTEM.Properties.Resources.icons8_refresh_20;
            this.btn_refresh.Location = new System.Drawing.Point(424, 41);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(54, 39);
            this.btn_refresh.TabIndex = 30;
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(191, 48);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(144, 27);
            this.txt_search.TabIndex = 29;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            this.txt_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_search_KeyDown);
            // 
            // db_creditViewReport
            // 
            this.db_creditViewReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.db_creditViewReport.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.db_creditViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.db_creditViewReport.Location = new System.Drawing.Point(140, 124);
            this.db_creditViewReport.Name = "db_creditViewReport";
            this.db_creditViewReport.Size = new System.Drawing.Size(556, 245);
            this.db_creditViewReport.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(542, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Total Credit Amount : ";
            // 
            // btn_filterDate
            // 
            this.btn_filterDate.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_filterDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filterDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_filterDate.Image = global::POS_SYSTEM.Properties.Resources.icons8_search_28;
            this.btn_filterDate.Location = new System.Drawing.Point(351, 41);
            this.btn_filterDate.Name = "btn_filterDate";
            this.btn_filterDate.Size = new System.Drawing.Size(55, 38);
            this.btn_filterDate.TabIndex = 24;
            this.btn_filterDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_filterDate.UseVisualStyleBackColor = false;
            this.btn_filterDate.Click += new System.EventHandler(this.btn_filterDate_Click);
            // 
            // txt_totalcreditamount
            // 
            this.txt_totalcreditamount.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txt_totalcreditamount.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalcreditamount.Location = new System.Drawing.Point(717, 48);
            this.txt_totalcreditamount.Name = "txt_totalcreditamount";
            this.txt_totalcreditamount.ReadOnly = true;
            this.txt_totalcreditamount.Size = new System.Drawing.Size(144, 26);
            this.txt_totalcreditamount.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(116, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bill no :";
            // 
            // CreditReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 620);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreditReport";
            this.Text = "CreditReport";
            this.Load += new System.EventHandler(this.CreditReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_creditViewReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView db_creditViewReport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_filterDate;
        private System.Windows.Forms.TextBox txt_totalcreditamount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_refresh;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}