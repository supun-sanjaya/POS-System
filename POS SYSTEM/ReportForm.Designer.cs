namespace POS_SYSTEM
{
    partial class ReportForm
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
            this.btn_creditReport = new System.Windows.Forms.Button();
            this.panl_reportdashboard = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_userlogdetails = new System.Windows.Forms.Button();
            this.panelR = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_StockReport = new System.Windows.Forms.Button();
            this.panl_reportdashboard.SuspendLayout();
            this.panelR.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_creditReport
            // 
            this.btn_creditReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_creditReport.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_creditReport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_creditReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_creditReport.Location = new System.Drawing.Point(145, 417);
            this.btn_creditReport.Name = "btn_creditReport";
            this.btn_creditReport.Size = new System.Drawing.Size(357, 108);
            this.btn_creditReport.TabIndex = 13;
            this.btn_creditReport.Text = "Credit Report";
            this.btn_creditReport.UseVisualStyleBackColor = false;
            this.btn_creditReport.Click += new System.EventHandler(this.btn_creditReport_Click);
            // 
            // panl_reportdashboard
            // 
            this.panl_reportdashboard.BackColor = System.Drawing.SystemColors.Control;
            this.panl_reportdashboard.Controls.Add(this.button3);
            this.panl_reportdashboard.Controls.Add(this.button1);
            this.panl_reportdashboard.Controls.Add(this.btn_userlogdetails);
            this.panl_reportdashboard.Controls.Add(this.btn_creditReport);
            this.panl_reportdashboard.Controls.Add(this.panelR);
            this.panl_reportdashboard.Controls.Add(this.btn_StockReport);
            this.panl_reportdashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panl_reportdashboard.Location = new System.Drawing.Point(0, 0);
            this.panl_reportdashboard.Name = "panl_reportdashboard";
            this.panl_reportdashboard.Size = new System.Drawing.Size(1118, 620);
            this.panl_reportdashboard.TabIndex = 15;
            this.panl_reportdashboard.Paint += new System.Windows.Forms.PaintEventHandler(this.panl_reportdashboard_Paint);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Purple;
            this.button3.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(619, 175);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(384, 108);
            this.button3.TabIndex = 18;
            this.button3.Text = "Lowest Qty";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Purple;
            this.button1.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(619, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(384, 108);
            this.button1.TabIndex = 16;
            this.button1.Text = "Sales Report";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_userlogdetails
            // 
            this.btn_userlogdetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_userlogdetails.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_userlogdetails.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_userlogdetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_userlogdetails.Location = new System.Drawing.Point(619, 415);
            this.btn_userlogdetails.Name = "btn_userlogdetails";
            this.btn_userlogdetails.Size = new System.Drawing.Size(384, 108);
            this.btn_userlogdetails.TabIndex = 15;
            this.btn_userlogdetails.Text = "Users LOGIN Details";
            this.btn_userlogdetails.UseVisualStyleBackColor = false;
            this.btn_userlogdetails.Click += new System.EventHandler(this.btn_userlogdetails_Click);
            // 
            // panelR
            // 
            this.panelR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelR.Controls.Add(this.label1);
            this.panelR.Location = new System.Drawing.Point(63, 62);
            this.panelR.Name = "panelR";
            this.panelR.Size = new System.Drawing.Size(1055, 70);
            this.panelR.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(383, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reports Dashboard";
            // 
            // btn_StockReport
            // 
            this.btn_StockReport.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_StockReport.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StockReport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_StockReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_StockReport.Location = new System.Drawing.Point(145, 292);
            this.btn_StockReport.Name = "btn_StockReport";
            this.btn_StockReport.Size = new System.Drawing.Size(357, 106);
            this.btn_StockReport.TabIndex = 11;
            this.btn_StockReport.Text = "Stock Report";
            this.btn_StockReport.UseVisualStyleBackColor = false;
            this.btn_StockReport.Click += new System.EventHandler(this.btn_StockReport_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 620);
            this.Controls.Add(this.panl_reportdashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.panl_reportdashboard.ResumeLayout(false);
            this.panelR.ResumeLayout(false);
            this.panelR.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn_StockReport;
        public System.Windows.Forms.Button btn_userlogdetails;
        public System.Windows.Forms.Button btn_creditReport;
        public System.Windows.Forms.Panel panelR;
        public System.Windows.Forms.Panel panl_reportdashboard;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button3;
    }
}