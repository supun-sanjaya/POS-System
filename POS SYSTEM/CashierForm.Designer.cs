namespace POS_SYSTEM
{
    partial class CashierForm
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
            this.txt_datecurr = new System.Windows.Forms.Label();
            this.txt_billno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_totalItemsPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_barcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cartDataGridView = new System.Windows.Forms.DataGridView();
            this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_removeall = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_cart = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_netbill = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_pay = new System.Windows.Forms.Button();
            this.txt_balance = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_payamount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_billamount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_TotalQty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_proprice = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_availableqty = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_procode = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_datecurr);
            this.groupBox1.Controls.Add(this.txt_billno);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_totalItemsPrice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_qty);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_refresh);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.txt_barcode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Elephant", 12F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(61, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1045, 137);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cashier Interface";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_datecurr
            // 
            this.txt_datecurr.AutoSize = true;
            this.txt_datecurr.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_datecurr.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txt_datecurr.Location = new System.Drawing.Point(902, 35);
            this.txt_datecurr.Name = "txt_datecurr";
            this.txt_datecurr.Size = new System.Drawing.Size(0, 20);
            this.txt_datecurr.TabIndex = 19;
            // 
            // txt_billno
            // 
            this.txt_billno.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_billno.Location = new System.Drawing.Point(499, 89);
            this.txt_billno.Name = "txt_billno";
            this.txt_billno.ReadOnly = true;
            this.txt_billno.Size = new System.Drawing.Size(182, 28);
            this.txt_billno.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(393, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Bill Number ";
            // 
            // txt_totalItemsPrice
            // 
            this.txt_totalItemsPrice.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_totalItemsPrice.Location = new System.Drawing.Point(880, 89);
            this.txt_totalItemsPrice.Name = "txt_totalItemsPrice";
            this.txt_totalItemsPrice.ReadOnly = true;
            this.txt_totalItemsPrice.Size = new System.Drawing.Size(150, 28);
            this.txt_totalItemsPrice.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(740, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Total Item Price";
            // 
            // txt_qty
            // 
            this.txt_qty.Location = new System.Drawing.Point(559, 50);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(122, 28);
            this.txt_qty.TabIndex = 14;
            this.txt_qty.TextChanged += new System.EventHandler(this.txt_qty_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(507, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "QTY";
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_refresh.Image = global::POS_SYSTEM.Properties.Resources.icons8_refresh_20;
            this.btn_refresh.Location = new System.Drawing.Point(392, 46);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(44, 35);
            this.btn_refresh.TabIndex = 12;
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_search.Image = global::POS_SYSTEM.Properties.Resources.icons8_search_28;
            this.btn_search.Location = new System.Drawing.Point(346, 46);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(44, 35);
            this.btn_search.TabIndex = 11;
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_barcode
            // 
            this.txt_barcode.Location = new System.Drawing.Point(120, 50);
            this.txt_barcode.Name = "txt_barcode";
            this.txt_barcode.Size = new System.Drawing.Size(220, 28);
            this.txt_barcode.TabIndex = 8;
            this.txt_barcode.TextChanged += new System.EventHandler(this.txt_barcode_TextChanged);
            this.txt_barcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_barcode_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(41, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Barcode";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cartDataGridView);
            this.panel1.Location = new System.Drawing.Point(61, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 266);
            this.panel1.TabIndex = 11;
            // 
            // cartDataGridView
            // 
            this.cartDataGridView.AllowUserToAddRows = false;
            this.cartDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barcode,
            this.Product_Description,
            this.Price,
            this.QTY,
            this.TotalAmount});
            this.cartDataGridView.Location = new System.Drawing.Point(3, 3);
            this.cartDataGridView.Name = "cartDataGridView";
            this.cartDataGridView.Size = new System.Drawing.Size(505, 256);
            this.cartDataGridView.TabIndex = 0;
            this.cartDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cartDataGridView_CellContentClick);
            // 
            // barcode
            // 
            this.barcode.HeaderText = "Barcode";
            this.barcode.Name = "barcode";
            // 
            // Product_Description
            // 
            this.Product_Description.HeaderText = "Product Description";
            this.Product_Description.Name = "Product_Description";
            // 
            // Price
            // 
            this.Price.HeaderText = "UnitPrice";
            this.Price.Name = "Price";
            // 
            // QTY
            // 
            this.QTY.HeaderText = "Quantity";
            this.QTY.Name = "QTY";
            // 
            // TotalAmount
            // 
            this.TotalAmount.HeaderText = "TotalAmount";
            this.TotalAmount.Name = "TotalAmount";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btn_removeall);
            this.panel2.Controls.Add(this.btn_remove);
            this.panel2.Controls.Add(this.btn_cart);
            this.panel2.Location = new System.Drawing.Point(576, 188);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 266);
            this.panel2.TabIndex = 12;
            // 
            // btn_removeall
            // 
            this.btn_removeall.BackColor = System.Drawing.Color.Brown;
            this.btn_removeall.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removeall.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_removeall.Image = global::POS_SYSTEM.Properties.Resources.icons8_delete_281;
            this.btn_removeall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_removeall.Location = new System.Drawing.Point(22, 167);
            this.btn_removeall.Name = "btn_removeall";
            this.btn_removeall.Size = new System.Drawing.Size(213, 39);
            this.btn_removeall.TabIndex = 12;
            this.btn_removeall.Text = "Remove  All";
            this.btn_removeall.UseVisualStyleBackColor = false;
            this.btn_removeall.Click += new System.EventHandler(this.btn_removeall_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.Brown;
            this.btn_remove.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_remove.Image = global::POS_SYSTEM.Properties.Resources.icons8_delete_28;
            this.btn_remove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_remove.Location = new System.Drawing.Point(22, 107);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(213, 39);
            this.btn_remove.TabIndex = 11;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_cart
            // 
            this.btn_cart.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_cart.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_cart.Image = global::POS_SYSTEM.Properties.Resources.icons8_cart_40;
            this.btn_cart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cart.Location = new System.Drawing.Point(22, 25);
            this.btn_cart.Name = "btn_cart";
            this.btn_cart.Size = new System.Drawing.Size(213, 59);
            this.btn_cart.TabIndex = 10;
            this.btn_cart.Text = "ADD to Cart";
            this.btn_cart.UseVisualStyleBackColor = false;
            this.btn_cart.Click += new System.EventHandler(this.btn_cart_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGreen;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.txt_netbill);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.btn_pay);
            this.panel3.Controls.Add(this.txt_balance);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txt_payamount);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txt_discount);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txt_billamount);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txt_TotalQty);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Font = new System.Drawing.Font("Elephant", 11.25F);
            this.panel3.Location = new System.Drawing.Point(839, 188);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 405);
            this.panel3.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label15.Location = new System.Drawing.Point(27, 215);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 20);
            this.label15.TabIndex = 28;
            this.label15.Text = "Amount :";
            // 
            // txt_netbill
            // 
            this.txt_netbill.Font = new System.Drawing.Font("Elephant", 11.25F);
            this.txt_netbill.Location = new System.Drawing.Point(112, 211);
            this.txt_netbill.Name = "txt_netbill";
            this.txt_netbill.Size = new System.Drawing.Size(139, 27);
            this.txt_netbill.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label14.Location = new System.Drawing.Point(6, 197);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 20);
            this.label14.TabIndex = 26;
            this.label14.Text = "Net Bill";
            // 
            // btn_pay
            // 
            this.btn_pay.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pay.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_pay.Image = global::POS_SYSTEM.Properties.Resources.icons8_print_28;
            this.btn_pay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pay.Location = new System.Drawing.Point(19, 304);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(224, 55);
            this.btn_pay.TabIndex = 25;
            this.btn_pay.Text = "Pay & Print";
            this.btn_pay.UseVisualStyleBackColor = false;
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // txt_balance
            // 
            this.txt_balance.Font = new System.Drawing.Font("Elephant", 11.25F);
            this.txt_balance.Location = new System.Drawing.Point(86, 254);
            this.txt_balance.Name = "txt_balance";
            this.txt_balance.Size = new System.Drawing.Size(139, 27);
            this.txt_balance.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(6, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Balance :";
            // 
            // txt_payamount
            // 
            this.txt_payamount.Font = new System.Drawing.Font("Elephant", 11.25F);
            this.txt_payamount.Location = new System.Drawing.Point(122, 147);
            this.txt_payamount.Name = "txt_payamount";
            this.txt_payamount.Size = new System.Drawing.Size(138, 27);
            this.txt_payamount.TabIndex = 22;
            this.txt_payamount.Click += new System.EventHandler(this.txt_payamount_Click);
            this.txt_payamount.TextChanged += new System.EventHandler(this.txt_payamount_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(6, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Payed Amount";
            // 
            // txt_discount
            // 
            this.txt_discount.Font = new System.Drawing.Font("Elephant", 11.25F);
            this.txt_discount.Location = new System.Drawing.Point(86, 107);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(139, 27);
            this.txt_discount.TabIndex = 20;
            this.txt_discount.Click += new System.EventHandler(this.txt_discount_Click);
            this.txt_discount.TextChanged += new System.EventHandler(this.txt_discount_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(6, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Discount ";
            // 
            // txt_billamount
            // 
            this.txt_billamount.Font = new System.Drawing.Font("Elephant", 11.25F);
            this.txt_billamount.Location = new System.Drawing.Point(111, 54);
            this.txt_billamount.Name = "txt_billamount";
            this.txt_billamount.Size = new System.Drawing.Size(140, 27);
            this.txt_billamount.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(6, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Bill Amount";
            // 
            // txt_TotalQty
            // 
            this.txt_TotalQty.Font = new System.Drawing.Font("Elephant", 11.25F);
            this.txt_TotalQty.Location = new System.Drawing.Point(103, 16);
            this.txt_TotalQty.Name = "txt_TotalQty";
            this.txt_TotalQty.Size = new System.Drawing.Size(122, 27);
            this.txt_TotalQty.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Total QTY";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.txt_proprice);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.txt_availableqty);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.txt_procode);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.txt_description);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Location = new System.Drawing.Point(61, 460);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(771, 133);
            this.panel4.TabIndex = 14;
            // 
            // txt_proprice
            // 
            this.txt_proprice.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_proprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_proprice.Location = new System.Drawing.Point(630, 71);
            this.txt_proprice.Name = "txt_proprice";
            this.txt_proprice.ReadOnly = true;
            this.txt_proprice.Size = new System.Drawing.Size(122, 22);
            this.txt_proprice.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label13.Location = new System.Drawing.Point(505, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 20);
            this.label13.TabIndex = 21;
            this.label13.Text = "Product Price";
            // 
            // txt_availableqty
            // 
            this.txt_availableqty.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_availableqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_availableqty.Location = new System.Drawing.Point(658, 32);
            this.txt_availableqty.Name = "txt_availableqty";
            this.txt_availableqty.ReadOnly = true;
            this.txt_availableqty.Size = new System.Drawing.Size(92, 22);
            this.txt_availableqty.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label12.Location = new System.Drawing.Point(533, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 20);
            this.label12.TabIndex = 19;
            this.label12.Text = "Available QTY";
            // 
            // txt_procode
            // 
            this.txt_procode.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_procode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_procode.Location = new System.Drawing.Point(158, 70);
            this.txt_procode.Name = "txt_procode";
            this.txt_procode.ReadOnly = true;
            this.txt_procode.Size = new System.Drawing.Size(152, 22);
            this.txt_procode.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label11.Location = new System.Drawing.Point(39, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "Product Code";
            // 
            // txt_description
            // 
            this.txt_description.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_description.Location = new System.Drawing.Point(208, 30);
            this.txt_description.Name = "txt_description";
            this.txt_description.ReadOnly = true;
            this.txt_description.Size = new System.Drawing.Size(300, 22);
            this.txt_description.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label10.Location = new System.Drawing.Point(39, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Product Description";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // CashierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 620);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CashierForm";
            this.Text = "CashierForm";
            this.Load += new System.EventHandler(this.CashierForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cartDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_cart;
        private System.Windows.Forms.TextBox txt_barcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_billno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_totalItemsPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_removeall;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_pay;
        private System.Windows.Forms.TextBox txt_balance;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_payamount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_discount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_billamount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_TotalQty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_proprice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_availableqty;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_procode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView cartDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.Label txt_datecurr;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_netbill;
        private System.Windows.Forms.Label label14;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}