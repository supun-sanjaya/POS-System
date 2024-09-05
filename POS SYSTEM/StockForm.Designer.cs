namespace POS_SYSTEM
{
    partial class StockForm
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
            this.btn_filterDate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerst = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickered = new System.Windows.Forms.DateTimePicker();
            this.com_category = new System.Windows.Forms.ComboBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.db_stockView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_stockView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_filterDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePickerst);
            this.groupBox1.Controls.Add(this.dateTimePickered);
            this.groupBox1.Controls.Add(this.com_category);
            this.groupBox1.Controls.Add(this.btn_refresh);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.txt_search);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(67, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1027, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_filterDate
            // 
            this.btn_filterDate.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_filterDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filterDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_filterDate.Image = global::POS_SYSTEM.Properties.Resources.icons8_search_28;
            this.btn_filterDate.Location = new System.Drawing.Point(693, 75);
            this.btn_filterDate.Name = "btn_filterDate";
            this.btn_filterDate.Size = new System.Drawing.Size(317, 35);
            this.btn_filterDate.TabIndex = 10;
            this.btn_filterDate.Text = "                     Filter";
            this.btn_filterDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_filterDate.UseVisualStyleBackColor = false;
            this.btn_filterDate.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(837, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "To";
            // 
            // dateTimePickerst
            // 
            this.dateTimePickerst.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerst.Location = new System.Drawing.Point(693, 36);
            this.dateTimePickerst.Name = "dateTimePickerst";
            this.dateTimePickerst.Size = new System.Drawing.Size(138, 28);
            this.dateTimePickerst.TabIndex = 8;
            // 
            // dateTimePickered
            // 
            this.dateTimePickered.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickered.Location = new System.Drawing.Point(872, 36);
            this.dateTimePickered.Name = "dateTimePickered";
            this.dateTimePickered.Size = new System.Drawing.Size(138, 28);
            this.dateTimePickered.TabIndex = 7;
            // 
            // com_category
            // 
            this.com_category.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.com_category.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.com_category.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_category.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.com_category.FormattingEnabled = true;
            this.com_category.Location = new System.Drawing.Point(397, 35);
            this.com_category.Name = "com_category";
            this.com_category.Size = new System.Drawing.Size(201, 28);
            this.com_category.TabIndex = 6;
            this.com_category.Text = "Search Category ";
            this.com_category.SelectedIndexChanged += new System.EventHandler(this.com_category_SelectedIndexChanged);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_refresh.Image = global::POS_SYSTEM.Properties.Resources.icons8_refresh_20;
            this.btn_refresh.Location = new System.Drawing.Point(310, 31);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(44, 35);
            this.btn_refresh.TabIndex = 5;
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_search.Image = global::POS_SYSTEM.Properties.Resources.icons8_search_28;
            this.btn_search.Location = new System.Drawing.Point(264, 31);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(44, 35);
            this.btn_search.TabIndex = 4;
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            this.btn_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn_search_KeyPress);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(17, 36);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(241, 27);
            this.txt_search.TabIndex = 3;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            this.txt_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_search_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(635, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "From";
            // 
            // db_stockView
            // 
            this.db_stockView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.db_stockView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.db_stockView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.db_stockView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.db_stockView.Location = new System.Drawing.Point(67, 183);
            this.db_stockView.Name = "db_stockView";
            this.db_stockView.Size = new System.Drawing.Size(1027, 414);
            this.db_stockView.TabIndex = 1;
            // 
            // StockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 620);
            this.Controls.Add(this.db_stockView);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StockForm";
            this.Text = "StockForm";
            this.Load += new System.EventHandler(this.StockForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_stockView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.ComboBox com_category;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerst;
        private System.Windows.Forms.DateTimePicker dateTimePickered;
        private System.Windows.Forms.Button btn_filterDate;
        private System.Windows.Forms.DataGridView db_stockView;
    }
}