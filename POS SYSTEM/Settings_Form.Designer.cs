namespace POS_SYSTEM
{
    partial class Settings_Form
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txt_server = new System.Windows.Forms.TextBox();
            this.txt_parth = new System.Windows.Forms.TextBox();
            this.btn_restore = new System.Windows.Forms.Button();
            this.txt_serverre = new System.Windows.Forms.TextBox();
            this.btn_selectparth = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(581, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Settings";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(25, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 62);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Business Name\r\n&& Address";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(25, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 26);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Business Name";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkCyan;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(25, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(247, 59);
            this.button2.TabIndex = 4;
            this.button2.Text = "Add Business Logo";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txt_address);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Engravers MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(85, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1021, 540);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.Location = new System.Drawing.Point(25, 138);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(247, 26);
            this.txt_address.TabIndex = 5;
            this.txt_address.Text = "Address";
            this.txt_address.Click += new System.EventHandler(this.txt_address_Click);
            this.txt_address.TextChanged += new System.EventHandler(this.txt_address_TextChanged);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(320, 79);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 37);
            this.button3.TabIndex = 6;
            this.button3.Text = "Backup";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txt_server
            // 
            this.txt_server.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_server.Location = new System.Drawing.Point(41, 85);
            this.txt_server.Name = "txt_server";
            this.txt_server.Size = new System.Drawing.Size(259, 26);
            this.txt_server.TabIndex = 7;
            this.txt_server.Text = "Server Name";
            this.txt_server.Click += new System.EventHandler(this.txt_server_Click);
            this.txt_server.TextChanged += new System.EventHandler(this.txt_server_TextChanged);
            // 
            // txt_parth
            // 
            this.txt_parth.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txt_parth.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_parth.Location = new System.Drawing.Point(34, 93);
            this.txt_parth.Name = "txt_parth";
            this.txt_parth.ReadOnly = true;
            this.txt_parth.Size = new System.Drawing.Size(259, 26);
            this.txt_parth.TabIndex = 9;
            // 
            // btn_restore
            // 
            this.btn_restore.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_restore.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_restore.Location = new System.Drawing.Point(115, 212);
            this.btn_restore.Name = "btn_restore";
            this.btn_restore.Size = new System.Drawing.Size(291, 40);
            this.btn_restore.TabIndex = 8;
            this.btn_restore.Text = "Restore";
            this.btn_restore.UseVisualStyleBackColor = false;
            this.btn_restore.Click += new System.EventHandler(this.btn_restore_Click);
            // 
            // txt_serverre
            // 
            this.txt_serverre.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_serverre.Location = new System.Drawing.Point(34, 155);
            this.txt_serverre.Name = "txt_serverre";
            this.txt_serverre.Size = new System.Drawing.Size(259, 26);
            this.txt_serverre.TabIndex = 10;
            this.txt_serverre.Text = "Server Name";
            this.txt_serverre.Click += new System.EventHandler(this.txt_serverre_Click);
            this.txt_serverre.TextChanged += new System.EventHandler(this.txt_serverre_TextChanged);
            // 
            // btn_selectparth
            // 
            this.btn_selectparth.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_selectparth.Font = new System.Drawing.Font("Engravers MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_selectparth.Location = new System.Drawing.Point(299, 86);
            this.btn_selectparth.Name = "btn_selectparth";
            this.btn_selectparth.Size = new System.Drawing.Size(176, 40);
            this.btn_selectparth.TabIndex = 11;
            this.btn_selectparth.Text = "Select Parth";
            this.btn_selectparth.UseVisualStyleBackColor = false;
            this.btn_selectparth.Click += new System.EventHandler(this.btn_selectparth_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SeaGreen;
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.txt_server);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Font = new System.Drawing.Font("Engravers MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(455, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(536, 458);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Backup / Restore";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_selectparth);
            this.panel1.Controls.Add(this.txt_serverre);
            this.panel1.Controls.Add(this.btn_restore);
            this.panel1.Controls.Add(this.txt_parth);
            this.panel1.Location = new System.Drawing.Point(6, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 274);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(517, 40);
            this.panel2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(95, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Restore the Backup";
            // 
            // Settings_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1118, 620);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings_Form";
            this.Load += new System.EventHandler(this.Settings_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txt_server;
        private System.Windows.Forms.TextBox txt_parth;
        private System.Windows.Forms.Button btn_restore;
        private System.Windows.Forms.TextBox txt_serverre;
        private System.Windows.Forms.Button btn_selectparth;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}