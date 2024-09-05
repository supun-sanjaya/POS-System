namespace POS_SYSTEM
{
    partial class Main_Form
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
            this.sidebar = new System.Windows.Forms.Panel();
            this.btn_returnitem = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btn_report = new System.Windows.Forms.Button();
            this.btn_adduser = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Stock = new System.Windows.Forms.Button();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.btn_expnd = new System.Windows.Forms.Button();
            this.btn_setting = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_addproduct = new System.Windows.Forms.Button();
            this.btn_cashier = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.dashboardPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sidebar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.sidebar.Controls.Add(this.btn_returnitem);
            this.sidebar.Controls.Add(this.lblUsername);
            this.sidebar.Controls.Add(this.btn_report);
            this.sidebar.Controls.Add(this.btn_adduser);
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.btn_Stock);
            this.sidebar.Controls.Add(this.btn_dashboard);
            this.sidebar.Controls.Add(this.btn_expnd);
            this.sidebar.Controls.Add(this.btn_setting);
            this.sidebar.Controls.Add(this.btn_logout);
            this.sidebar.Controls.Add(this.btn_addproduct);
            this.sidebar.Controls.Add(this.btn_cashier);
            this.sidebar.Location = new System.Drawing.Point(1, 34);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(196, 584);
            this.sidebar.TabIndex = 0;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_Paint);
            // 
            // btn_returnitem
            // 
            this.btn_returnitem.AutoSize = true;
            this.btn_returnitem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btn_returnitem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_returnitem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_returnitem.FlatAppearance.BorderSize = 0;
            this.btn_returnitem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_returnitem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_returnitem.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_returnitem.Image = global::POS_SYSTEM.Properties.Resources.icons8_return_28;
            this.btn_returnitem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_returnitem.Location = new System.Drawing.Point(8, 348);
            this.btn_returnitem.Name = "btn_returnitem";
            this.btn_returnitem.Size = new System.Drawing.Size(216, 43);
            this.btn_returnitem.TabIndex = 12;
            this.btn_returnitem.Text = "        Return Items";
            this.btn_returnitem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_returnitem.UseVisualStyleBackColor = false;
            this.btn_returnitem.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUsername.Location = new System.Drawing.Point(77, 112);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(0, 21);
            this.lblUsername.TabIndex = 11;
            // 
            // btn_report
            // 
            this.btn_report.AutoSize = true;
            this.btn_report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btn_report.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_report.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_report.FlatAppearance.BorderSize = 0;
            this.btn_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_report.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_report.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_report.Image = global::POS_SYSTEM.Properties.Resources.icons8_report_28;
            this.btn_report.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_report.Location = new System.Drawing.Point(7, 443);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(216, 40);
            this.btn_report.TabIndex = 10;
            this.btn_report.Text = "        Report ";
            this.btn_report.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_report.UseVisualStyleBackColor = false;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // btn_adduser
            // 
            this.btn_adduser.AutoSize = true;
            this.btn_adduser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btn_adduser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_adduser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_adduser.FlatAppearance.BorderSize = 0;
            this.btn_adduser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adduser.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_adduser.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_adduser.Image = global::POS_SYSTEM.Properties.Resources.icons8_add_users_28;
            this.btn_adduser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_adduser.Location = new System.Drawing.Point(8, 396);
            this.btn_adduser.Name = "btn_adduser";
            this.btn_adduser.Size = new System.Drawing.Size(216, 40);
            this.btn_adduser.TabIndex = 9;
            this.btn_adduser.Text = "        Add Users";
            this.btn_adduser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_adduser.UseVisualStyleBackColor = false;
            this.btn_adduser.Click += new System.EventHandler(this.btn_adduser_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::POS_SYSTEM.Properties.Resources.icons8_user_64;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(65, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(78, 82);
            this.panel1.TabIndex = 8;
            // 
            // btn_Stock
            // 
            this.btn_Stock.AutoSize = true;
            this.btn_Stock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btn_Stock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Stock.FlatAppearance.BorderSize = 0;
            this.btn_Stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Stock.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Stock.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Stock.Image = global::POS_SYSTEM.Properties.Resources.icons8_increase_28;
            this.btn_Stock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Stock.Location = new System.Drawing.Point(8, 254);
            this.btn_Stock.Name = "btn_Stock";
            this.btn_Stock.Size = new System.Drawing.Size(216, 40);
            this.btn_Stock.TabIndex = 7;
            this.btn_Stock.Text = "        Stock";
            this.btn_Stock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Stock.UseVisualStyleBackColor = false;
            this.btn_Stock.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.AutoSize = true;
            this.btn_dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btn_dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_dashboard.FlatAppearance.BorderSize = 0;
            this.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dashboard.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashboard.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_dashboard.Image = global::POS_SYSTEM.Properties.Resources.icons8_dashboard_28;
            this.btn_dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dashboard.Location = new System.Drawing.Point(7, 162);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(216, 40);
            this.btn_dashboard.TabIndex = 6;
            this.btn_dashboard.Text = "        Dashboard";
            this.btn_dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dashboard.UseVisualStyleBackColor = false;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            // 
            // btn_expnd
            // 
            this.btn_expnd.AutoSize = true;
            this.btn_expnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btn_expnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_expnd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_expnd.FlatAppearance.BorderSize = 0;
            this.btn_expnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_expnd.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_expnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_expnd.Image = global::POS_SYSTEM.Properties.Resources.icons8_menu_28;
            this.btn_expnd.Location = new System.Drawing.Point(3, 21);
            this.btn_expnd.Name = "btn_expnd";
            this.btn_expnd.Size = new System.Drawing.Size(41, 38);
            this.btn_expnd.TabIndex = 5;
            this.btn_expnd.UseVisualStyleBackColor = false;
            this.btn_expnd.Click += new System.EventHandler(this.btn_expnd_Click);
            // 
            // btn_setting
            // 
            this.btn_setting.AutoSize = true;
            this.btn_setting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btn_setting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_setting.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_setting.FlatAppearance.BorderSize = 0;
            this.btn_setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_setting.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_setting.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_setting.Image = global::POS_SYSTEM.Properties.Resources.icons8_setting_28;
            this.btn_setting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_setting.Location = new System.Drawing.Point(8, 491);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Size = new System.Drawing.Size(216, 40);
            this.btn_setting.TabIndex = 5;
            this.btn_setting.Text = "        Setting";
            this.btn_setting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_setting.UseVisualStyleBackColor = false;
            this.btn_setting.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.AutoSize = true;
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btn_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_logout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_logout.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_logout.Image = global::POS_SYSTEM.Properties.Resources.icons8_logout_28;
            this.btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.Location = new System.Drawing.Point(8, 538);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(216, 40);
            this.btn_logout.TabIndex = 4;
            this.btn_logout.Text = "        Logout";
            this.btn_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_addproduct
            // 
            this.btn_addproduct.AutoSize = true;
            this.btn_addproduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btn_addproduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_addproduct.FlatAppearance.BorderSize = 0;
            this.btn_addproduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addproduct.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addproduct.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_addproduct.Image = global::POS_SYSTEM.Properties.Resources.icons8_add_28__1_;
            this.btn_addproduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addproduct.Location = new System.Drawing.Point(8, 208);
            this.btn_addproduct.Name = "btn_addproduct";
            this.btn_addproduct.Size = new System.Drawing.Size(216, 40);
            this.btn_addproduct.TabIndex = 2;
            this.btn_addproduct.Text = "        ADD Product";
            this.btn_addproduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addproduct.UseVisualStyleBackColor = false;
            this.btn_addproduct.Click += new System.EventHandler(this.btn_addproduct_Click);
            // 
            // btn_cashier
            // 
            this.btn_cashier.AutoSize = true;
            this.btn_cashier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btn_cashier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_cashier.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_cashier.FlatAppearance.BorderSize = 0;
            this.btn_cashier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cashier.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_cashier.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_cashier.Image = global::POS_SYSTEM.Properties.Resources.icons8_checkout_28;
            this.btn_cashier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cashier.Location = new System.Drawing.Point(8, 301);
            this.btn_cashier.Name = "btn_cashier";
            this.btn_cashier.Size = new System.Drawing.Size(216, 40);
            this.btn_cashier.TabIndex = 3;
            this.btn_cashier.Text = "        CASHIER";
            this.btn_cashier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cashier.UseVisualStyleBackColor = false;
            this.btn_cashier.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_exit);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1118, 40);
            this.panel2.TabIndex = 1;
            this.panel2.DoubleClick += new System.EventHandler(this.panel2_DoubleClick);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.Image = global::POS_SYSTEM.Properties.Resources.icons8_minimize_20;
            this.button3.Location = new System.Drawing.Point(1010, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 26);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Image = global::POS_SYSTEM.Properties.Resources.icons8_maximizing_pop_up_window_box_under_web_page_builder_20;
            this.button2.Location = new System.Drawing.Point(1046, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 26);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Witch Magic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "POS System";
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.AutoSize = true;
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_exit.Image = global::POS_SYSTEM.Properties.Resources.icons8_exit_28;
            this.btn_exit.Location = new System.Drawing.Point(1078, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(34, 34);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.button6_Click);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // dashboardPanel
            // 
            this.dashboardPanel.BackColor = System.Drawing.Color.Snow;
            this.dashboardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardPanel.Location = new System.Drawing.Point(0, 0);
            this.dashboardPanel.Name = "dashboardPanel";
            this.dashboardPanel.Size = new System.Drawing.Size(1118, 620);
            this.dashboardPanel.TabIndex = 4;
            this.dashboardPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.dashboardPanel_Paint);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1118, 620);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.dashboardPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_Form";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.sidebar.ResumeLayout(false);
            this.sidebar.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Button btn_addproduct;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_cashier;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_expnd;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Button btn_Stock;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel dashboardPanel;
        private System.Windows.Forms.Label lblUsername;
        public System.Windows.Forms.Button btn_report;
        public System.Windows.Forms.Button btn_setting;
        public System.Windows.Forms.Button btn_adduser;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Button btn_returnitem;
    }
}