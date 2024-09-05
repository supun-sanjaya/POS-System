namespace POS_SYSTEM
{
    partial class QtyRefillstock
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
            this.btn_filterDate = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.db_stockViewReport = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_stockViewReport)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reportViewer1);
            this.groupBox1.Controls.Add(this.btn_filterDate);
            this.groupBox1.Controls.Add(this.btn_refresh);
            this.groupBox1.Controls.Add(this.txt_search);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.db_stockViewReport);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(73, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1027, 539);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lowerst Qty Items";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "POS_SYSTEM.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(59, 97);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(652, 424);
            this.reportViewer1.TabIndex = 23;
            // 
            // btn_filterDate
            // 
            this.btn_filterDate.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_filterDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filterDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_filterDate.Image = global::POS_SYSTEM.Properties.Resources.icons8_search_28;
            this.btn_filterDate.Location = new System.Drawing.Point(751, 142);
            this.btn_filterDate.Name = "btn_filterDate";
            this.btn_filterDate.Size = new System.Drawing.Size(237, 36);
            this.btn_filterDate.TabIndex = 17;
            this.btn_filterDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_filterDate.UseVisualStyleBackColor = false;
            this.btn_filterDate.Click += new System.EventHandler(this.btn_filterDate_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_refresh.Image = global::POS_SYSTEM.Properties.Resources.icons8_refresh_20;
            this.btn_refresh.Location = new System.Drawing.Point(751, 193);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(237, 37);
            this.btn_refresh.TabIndex = 14;
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(751, 97);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(237, 27);
            this.txt_search.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(233, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "These Items Qty Is Less Than 8";
            // 
            // db_stockViewReport
            // 
            this.db_stockViewReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.db_stockViewReport.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.db_stockViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.db_stockViewReport.Location = new System.Drawing.Point(91, 165);
            this.db_stockViewReport.Name = "db_stockViewReport";
            this.db_stockViewReport.Size = new System.Drawing.Size(524, 207);
            this.db_stockViewReport.TabIndex = 0;
            // 
            // QtyRefillstock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 620);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QtyRefillstock";
            this.Text = "QtyRefillstock";
            this.Load += new System.EventHandler(this.QtyRefillstock_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_stockViewReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btn_filterDate;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView db_stockViewReport;
    }
}