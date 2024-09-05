namespace POS_SYSTEM
{
    partial class ReturnItem
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
            this.db_returnitem = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_billno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_addreturn = new System.Windows.Forms.Button();
            this.text_reqtyr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_updatere = new System.Windows.Forms.Button();
            this.txt_barcoder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.db_returnitem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // db_returnitem
            // 
            this.db_returnitem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.db_returnitem.BackgroundColor = System.Drawing.SystemColors.Window;
            this.db_returnitem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.db_returnitem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.db_returnitem.Location = new System.Drawing.Point(464, 92);
            this.db_returnitem.Name = "db_returnitem";
            this.db_returnitem.Size = new System.Drawing.Size(627, 500);
            this.db_returnitem.TabIndex = 3;
            this.db_returnitem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.db_returnitem_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_billno);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_addreturn);
            this.groupBox1.Controls.Add(this.text_reqtyr);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_updatere);
            this.groupBox1.Controls.Add(this.txt_barcoder);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(86, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 511);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Return Items";
            // 
            // txt_billno
            // 
            this.txt_billno.Location = new System.Drawing.Point(106, 45);
            this.txt_billno.Name = "txt_billno";
            this.txt_billno.Size = new System.Drawing.Size(220, 28);
            this.txt_billno.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(27, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Bill No";
            // 
            // btn_addreturn
            // 
            this.btn_addreturn.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_addreturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addreturn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_addreturn.Image = global::POS_SYSTEM.Properties.Resources.icons8_add_281;
            this.btn_addreturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addreturn.Location = new System.Drawing.Point(31, 169);
            this.btn_addreturn.Name = "btn_addreturn";
            this.btn_addreturn.Size = new System.Drawing.Size(295, 35);
            this.btn_addreturn.TabIndex = 24;
            this.btn_addreturn.Text = "ADD Return Item";
            this.btn_addreturn.UseVisualStyleBackColor = false;
            this.btn_addreturn.Click += new System.EventHandler(this.btn_addreturn_Click);
            // 
            // text_reqtyr
            // 
            this.text_reqtyr.Location = new System.Drawing.Point(106, 131);
            this.text_reqtyr.Name = "text_reqtyr";
            this.text_reqtyr.Size = new System.Drawing.Size(220, 28);
            this.text_reqtyr.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(27, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Quantity";
            // 
            // btn_updatere
            // 
            this.btn_updatere.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_updatere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_updatere.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_updatere.Image = global::POS_SYSTEM.Properties.Resources.icons8_renew_28;
            this.btn_updatere.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_updatere.Location = new System.Drawing.Point(16, 242);
            this.btn_updatere.Name = "btn_updatere";
            this.btn_updatere.Size = new System.Drawing.Size(310, 91);
            this.btn_updatere.TabIndex = 20;
            this.btn_updatere.Text = "Return Item Check And Update";
            this.btn_updatere.UseVisualStyleBackColor = false;
            this.btn_updatere.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txt_barcoder
            // 
            this.txt_barcoder.Location = new System.Drawing.Point(106, 88);
            this.txt_barcoder.Name = "txt_barcoder";
            this.txt_barcoder.Size = new System.Drawing.Size(220, 28);
            this.txt_barcoder.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(27, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Barcode";
            // 
            // ReturnItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 620);
            this.Controls.Add(this.db_returnitem);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReturnItem";
            this.Text = "ReturnItem";
            this.Load += new System.EventHandler(this.ReturnItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_returnitem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView db_returnitem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_barcoder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_addreturn;
        private System.Windows.Forms.TextBox text_reqtyr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_billno;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btn_updatere;
    }
}