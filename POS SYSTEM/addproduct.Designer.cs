namespace POS_SYSTEM
{
    partial class addproduct
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
            this.label10 = new System.Windows.Forms.Label();
            this.txt_totalAmount = new System.Windows.Forms.TextBox();
            this.txt_costonePro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_sellingPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.com_category = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_date = new System.Windows.Forms.DateTimePicker();
            this.txt_barcode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_proCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Qty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.db_productsView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_categoryadd = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_addCetagory = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_grn = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_productsView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_grn);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_totalAmount);
            this.groupBox1.Controls.Add(this.txt_costonePro);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_sellingPrice);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.com_category);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_date);
            this.groupBox1.Controls.Add(this.txt_barcode);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_description);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_proCode);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_Qty);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_search);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(85, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1005, 254);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADD PRODUCT";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label10.Location = new System.Drawing.Point(732, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 18);
            this.label10.TabIndex = 19;
            this.label10.Text = "Total Amount";
            // 
            // txt_totalAmount
            // 
            this.txt_totalAmount.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txt_totalAmount.Location = new System.Drawing.Point(854, 210);
            this.txt_totalAmount.Name = "txt_totalAmount";
            this.txt_totalAmount.ReadOnly = true;
            this.txt_totalAmount.Size = new System.Drawing.Size(133, 25);
            this.txt_totalAmount.TabIndex = 18;
            this.txt_totalAmount.TextChanged += new System.EventHandler(this.txt_totalAmount_TextChanged);
            // 
            // txt_costonePro
            // 
            this.txt_costonePro.Location = new System.Drawing.Point(553, 207);
            this.txt_costonePro.Name = "txt_costonePro";
            this.txt_costonePro.Size = new System.Drawing.Size(118, 25);
            this.txt_costonePro.TabIndex = 17;
            this.txt_costonePro.TextChanged += new System.EventHandler(this.txt_costonePro_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label9.Location = new System.Drawing.Point(28, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "Selling Price";
            // 
            // txt_sellingPrice
            // 
            this.txt_sellingPrice.Location = new System.Drawing.Point(140, 207);
            this.txt_sellingPrice.Name = "txt_sellingPrice";
            this.txt_sellingPrice.Size = new System.Drawing.Size(167, 25);
            this.txt_sellingPrice.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(360, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "One Product Cost Price";
            // 
            // com_category
            // 
            this.com_category.FormattingEnabled = true;
            this.com_category.Location = new System.Drawing.Point(810, 132);
            this.com_category.Name = "com_category";
            this.com_category.Size = new System.Drawing.Size(177, 26);
            this.com_category.TabIndex = 13;
            this.com_category.Text = "Select";
            this.com_category.SelectedIndexChanged += new System.EventHandler(this.com_category_SelectedIndexChanged);
            this.com_category.TextChanged += new System.EventHandler(this.com_category_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label8.Location = new System.Drawing.Point(722, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Category";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(28, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Description";
            // 
            // txt_date
            // 
            this.txt_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_date.Location = new System.Drawing.Point(847, 89);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(140, 25);
            this.txt_date.TabIndex = 10;
            // 
            // txt_barcode
            // 
            this.txt_barcode.Location = new System.Drawing.Point(117, 129);
            this.txt_barcode.Name = "txt_barcode";
            this.txt_barcode.Size = new System.Drawing.Size(202, 25);
            this.txt_barcode.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(722, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Stock In Date";
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(126, 169);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(374, 25);
            this.txt_description.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(28, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Barcode";
            // 
            // txt_proCode
            // 
            this.txt_proCode.Location = new System.Drawing.Point(487, 129);
            this.txt_proCode.Name = "txt_proCode";
            this.txt_proCode.Size = new System.Drawing.Size(184, 25);
            this.txt_proCode.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(364, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Product Code";
            // 
            // txt_Qty
            // 
            this.txt_Qty.Location = new System.Drawing.Point(846, 173);
            this.txt_Qty.Name = "txt_Qty";
            this.txt_Qty.Size = new System.Drawing.Size(141, 25);
            this.txt_Qty.TabIndex = 3;
            this.txt_Qty.TextChanged += new System.EventHandler(this.txt_Qty_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(722, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Add Quantity";
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.SystemColors.Window;
            this.txt_search.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt_search.Location = new System.Drawing.Point(99, 32);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(220, 25);
            this.txt_search.TabIndex = 1;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            this.txt_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_search_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(28, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search";
            // 
            // db_productsView
            // 
            this.db_productsView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.db_productsView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.db_productsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.db_productsView.Location = new System.Drawing.Point(85, 383);
            this.db_productsView.Name = "db_productsView";
            this.db_productsView.Size = new System.Drawing.Size(1005, 225);
            this.db_productsView.TabIndex = 4;
            this.db_productsView.SelectionChanged += new System.EventHandler(this.db_productsView_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Controls.Add(this.btn_update);
            this.groupBox2.Controls.Add(this.btn_save);
            this.groupBox2.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(89, 309);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(511, 64);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Product";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_delete.Location = new System.Drawing.Point(395, 22);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(99, 33);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_update.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_update.Location = new System.Drawing.Point(263, 23);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(99, 33);
            this.btn_update.TabIndex = 1;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_save.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_save.Location = new System.Drawing.Point(131, 22);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(99, 33);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_categoryadd
            // 
            this.txt_categoryadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_categoryadd.Location = new System.Drawing.Point(70, 25);
            this.txt_categoryadd.Name = "txt_categoryadd";
            this.txt_categoryadd.Size = new System.Drawing.Size(167, 26);
            this.txt_categoryadd.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_addCetagory);
            this.groupBox3.Controls.Add(this.txt_categoryadd);
            this.groupBox3.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox3.Location = new System.Drawing.Point(670, 309);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(420, 64);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Category";
            // 
            // btn_addCetagory
            // 
            this.btn_addCetagory.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_addCetagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addCetagory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_addCetagory.Image = global::POS_SYSTEM.Properties.Resources.icons8_add_28;
            this.btn_addCetagory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addCetagory.Location = new System.Drawing.Point(243, 21);
            this.btn_addCetagory.Name = "btn_addCetagory";
            this.btn_addCetagory.Size = new System.Drawing.Size(159, 33);
            this.btn_addCetagory.TabIndex = 3;
            this.btn_addCetagory.Text = "    Add Category";
            this.btn_addCetagory.UseVisualStyleBackColor = false;
            this.btn_addCetagory.Click += new System.EventHandler(this.btn_addCetagory_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(542, 33);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(54, 22);
            this.radioButton1.TabIndex = 20;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Yes";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(606, 33);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(46, 22);
            this.radioButton2.TabIndex = 21;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "No";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label11.Location = new System.Drawing.Point(385, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 18);
            this.label11.TabIndex = 22;
            this.label11.Text = "ADD Same Inovice";
            // 
            // txt_grn
            // 
            this.txt_grn.Location = new System.Drawing.Point(117, 84);
            this.txt_grn.Name = "txt_grn";
            this.txt_grn.Size = new System.Drawing.Size(202, 25);
            this.txt_grn.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label12.Location = new System.Drawing.Point(28, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 18);
            this.label12.TabIndex = 23;
            this.label12.Text = "GRN NO";
            // 
            // addproduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1118, 620);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.db_productsView);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addproduct";
            this.Text = "addproduct";
            this.Load += new System.EventHandler(this.addproduct_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_productsView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_Qty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox com_category;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker txt_date;
        private System.Windows.Forms.TextBox txt_barcode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_proCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView db_productsView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_addCetagory;
        private System.Windows.Forms.TextBox txt_sellingPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_totalAmount;
        private System.Windows.Forms.TextBox txt_costonePro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_categoryadd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox txt_grn;
        private System.Windows.Forms.Label label12;
    }
}