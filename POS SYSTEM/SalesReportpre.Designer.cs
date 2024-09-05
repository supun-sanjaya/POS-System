namespace POS_SYSTEM
{
    partial class SalesReportpre
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_totalincome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerst = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickered = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_filterDate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txt_netTotalincome = new System.Windows.Forms.TextBox();
            this.txt_creditAmount = new System.Windows.Forms.TextBox();
            this.db_stockViewReport = new System.Windows.Forms.DataGridView();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.db_credittotalincome = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_stockViewReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_credittotalincome)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(116, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select Date Range :";
            // 
            // txt_totalincome
            // 
            this.txt_totalincome.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalincome.Location = new System.Drawing.Point(897, 55);
            this.txt_totalincome.Name = "txt_totalincome";
            this.txt_totalincome.Size = new System.Drawing.Size(121, 27);
            this.txt_totalincome.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(277, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "From";
            // 
            // dateTimePickerst
            // 
            this.dateTimePickerst.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerst.Location = new System.Drawing.Point(335, 49);
            this.dateTimePickerst.Name = "dateTimePickerst";
            this.dateTimePickerst.Size = new System.Drawing.Size(114, 27);
            this.dateTimePickerst.TabIndex = 21;
            // 
            // dateTimePickered
            // 
            this.dateTimePickered.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickered.Location = new System.Drawing.Point(491, 49);
            this.dateTimePickered.Name = "dateTimePickered";
            this.dateTimePickered.Size = new System.Drawing.Size(111, 27);
            this.dateTimePickered.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(455, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "To";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btn_filterDate
            // 
            this.btn_filterDate.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_filterDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filterDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_filterDate.Image = global::POS_SYSTEM.Properties.Resources.icons8_search_28;
            this.btn_filterDate.Location = new System.Drawing.Point(620, 43);
            this.btn_filterDate.Name = "btn_filterDate";
            this.btn_filterDate.Size = new System.Drawing.Size(37, 35);
            this.btn_filterDate.TabIndex = 24;
            this.btn_filterDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_filterDate.UseVisualStyleBackColor = false;
            this.btn_filterDate.Click += new System.EventHandler(this.btn_filterDate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(767, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 40);
            this.label4.TabIndex = 25;
            this.label4.Text = "Total Income : \r\nWith Credit";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reportViewer1);
            this.groupBox1.Controls.Add(this.txt_netTotalincome);
            this.groupBox1.Controls.Add(this.txt_creditAmount);
            this.groupBox1.Controls.Add(this.db_stockViewReport);
            this.groupBox1.Controls.Add(this.btn_refresh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_filterDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePickered);
            this.groupBox1.Controls.Add(this.dateTimePickerst);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_totalincome);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.db_credittotalincome);
            this.groupBox1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(78, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1028, 534);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sales Report";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "POS_SYSTEM.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(110, 112);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(659, 416);
            this.reportViewer1.TabIndex = 29;
            // 
            // txt_netTotalincome
            // 
            this.txt_netTotalincome.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_netTotalincome.Location = new System.Drawing.Point(894, 191);
            this.txt_netTotalincome.Name = "txt_netTotalincome";
            this.txt_netTotalincome.Size = new System.Drawing.Size(121, 27);
            this.txt_netTotalincome.TabIndex = 33;
            // 
            // txt_creditAmount
            // 
            this.txt_creditAmount.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_creditAmount.Location = new System.Drawing.Point(897, 108);
            this.txt_creditAmount.Name = "txt_creditAmount";
            this.txt_creditAmount.Size = new System.Drawing.Size(121, 27);
            this.txt_creditAmount.TabIndex = 31;
            // 
            // db_stockViewReport
            // 
            this.db_stockViewReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.db_stockViewReport.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.db_stockViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.db_stockViewReport.Location = new System.Drawing.Point(255, 112);
            this.db_stockViewReport.Name = "db_stockViewReport";
            this.db_stockViewReport.Size = new System.Drawing.Size(418, 331);
            this.db_stockViewReport.TabIndex = 26;
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_refresh.Image = global::POS_SYSTEM.Properties.Resources.icons8_refresh_20;
            this.btn_refresh.Location = new System.Drawing.Point(674, 41);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(34, 36);
            this.btn_refresh.TabIndex = 30;
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(777, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 40);
            this.label5.TabIndex = 32;
            this.label5.Text = "Total Credit :\r\nAmount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(786, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 40);
            this.label6.TabIndex = 34;
            this.label6.Text = "Net Total    :\r\nIncome ";
            // 
            // db_credittotalincome
            // 
            this.db_credittotalincome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.db_credittotalincome.Location = new System.Drawing.Point(377, 361);
            this.db_credittotalincome.Name = "db_credittotalincome";
            this.db_credittotalincome.Size = new System.Drawing.Size(240, 150);
            this.db_credittotalincome.TabIndex = 35;
            // 
            // SalesReportpre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 620);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalesReportpre";
            this.Text = "SalesReportpre";
            this.Load += new System.EventHandler(this.SalesReportpre_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_stockViewReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_credittotalincome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_totalincome;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dateTimePickerst;
        public System.Windows.Forms.DateTimePicker dateTimePickered;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_filterDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView db_stockViewReport;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.TextBox txt_netTotalincome;
        private System.Windows.Forms.TextBox txt_creditAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView db_credittotalincome;
    }
}