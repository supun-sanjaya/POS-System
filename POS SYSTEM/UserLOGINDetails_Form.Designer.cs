namespace POS_SYSTEM
{
    partial class UserLOGINDetails_Form
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
            this.btn_filterDate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerst = new System.Windows.Forms.DateTimePicker();
            this.btn_Datesearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_creditViewReport)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Datesearch);
            this.groupBox1.Controls.Add(this.dateTimePickerst);
            this.groupBox1.Controls.Add(this.reportViewer1);
            this.groupBox1.Controls.Add(this.btn_refresh);
            this.groupBox1.Controls.Add(this.txt_search);
            this.groupBox1.Controls.Add(this.db_creditViewReport);
            this.groupBox1.Controls.Add(this.btn_filterDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(59, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1028, 534);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Users LOGIN Details";
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "POS_SYSTEM.Report4.rdlc";
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
            this.btn_refresh.Location = new System.Drawing.Point(571, 41);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(54, 39);
            this.btn_refresh.TabIndex = 30;
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(338, 48);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(144, 27);
            this.txt_search.TabIndex = 29;
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
            // btn_filterDate
            // 
            this.btn_filterDate.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_filterDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filterDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_filterDate.Image = global::POS_SYSTEM.Properties.Resources.icons8_search_28;
            this.btn_filterDate.Location = new System.Drawing.Point(498, 41);
            this.btn_filterDate.Name = "btn_filterDate";
            this.btn_filterDate.Size = new System.Drawing.Size(55, 38);
            this.btn_filterDate.TabIndex = 24;
            this.btn_filterDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_filterDate.UseVisualStyleBackColor = false;
            this.btn_filterDate.Click += new System.EventHandler(this.btn_filterDate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(241, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            // 
            // dateTimePickerst
            // 
            this.dateTimePickerst.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerst.Location = new System.Drawing.Point(744, 51);
            this.dateTimePickerst.Name = "dateTimePickerst";
            this.dateTimePickerst.Size = new System.Drawing.Size(138, 26);
            this.dateTimePickerst.TabIndex = 32;
            // 
            // btn_Datesearch
            // 
            this.btn_Datesearch.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Datesearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Datesearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Datesearch.Image = global::POS_SYSTEM.Properties.Resources.icons8_search_28;
            this.btn_Datesearch.Location = new System.Drawing.Point(888, 42);
            this.btn_Datesearch.Name = "btn_Datesearch";
            this.btn_Datesearch.Size = new System.Drawing.Size(55, 38);
            this.btn_Datesearch.TabIndex = 33;
            this.btn_Datesearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Datesearch.UseVisualStyleBackColor = false;
            this.btn_Datesearch.Click += new System.EventHandler(this.btn_Datesearch_Click);
            // 
            // UserLOGINDetails_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 620);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserLOGINDetails_Form";
            this.Text = "UserLOGINDetails_Form";
            this.Load += new System.EventHandler(this.UserLOGINDetails_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_creditViewReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.TextBox txt_search;
        public System.Windows.Forms.DataGridView db_creditViewReport;
        private System.Windows.Forms.Button btn_filterDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Datesearch;
        private System.Windows.Forms.DateTimePicker dateTimePickerst;
    }
}