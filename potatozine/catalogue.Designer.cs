﻿namespace potatozine
{
    partial class catalogue
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
            this.tabs = new System.Windows.Forms.TabControl();
            this.maintab = new System.Windows.Forms.TabPage();
            this.lblPID = new System.Windows.Forms.Label();
            this.FlwPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddCart = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.txtSelDesc = new System.Windows.Forms.TextBox();
            this.lblSelProdNam = new System.Windows.Forms.Label();
            this.lblProdInfo = new System.Windows.Forms.Label();
            this.PicSelProd = new System.Windows.Forms.PictureBox();
            this.lblSelCat = new System.Windows.Forms.Label();
            this.lstCatergory = new System.Windows.Forms.ListBox();
            this.carttab = new System.Windows.Forms.TabPage();
            this.cartView = new System.Windows.Forms.DataGridView();
            this.memStatusBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.couponBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.totalcartBox = new System.Windows.Forms.TextBox();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.accTab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.registerBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Report = new System.Windows.Forms.TabPage();
            this.lblTotSale = new System.Windows.Forms.Label();
            this.lblAvgSales = new System.Windows.Forms.Label();
            this.DGVrep = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.lblGreet = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.tabs.SuspendLayout();
            this.maintab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSelProd)).BeginInit();
            this.carttab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartView)).BeginInit();
            this.accTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Report.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVrep)).BeginInit();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs.Controls.Add(this.maintab);
            this.tabs.Controls.Add(this.carttab);
            this.tabs.Controls.Add(this.accTab);
            this.tabs.Controls.Add(this.Report);
            this.tabs.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabs.ItemSize = new System.Drawing.Size(78, 28);
            this.tabs.Location = new System.Drawing.Point(21, 38);
            this.tabs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1236, 738);
            this.tabs.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabs.TabIndex = 0;
            this.tabs.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabs_Selected);
            // 
            // maintab
            // 
            this.maintab.BackColor = System.Drawing.Color.Silver;
            this.maintab.Controls.Add(this.lblPID);
            this.maintab.Controls.Add(this.FlwPanel);
            this.maintab.Controls.Add(this.btnAddCart);
            this.maintab.Controls.Add(this.lblPrice);
            this.maintab.Controls.Add(this.lblQty);
            this.maintab.Controls.Add(this.numQty);
            this.maintab.Controls.Add(this.txtSelDesc);
            this.maintab.Controls.Add(this.lblSelProdNam);
            this.maintab.Controls.Add(this.lblProdInfo);
            this.maintab.Controls.Add(this.PicSelProd);
            this.maintab.Controls.Add(this.lblSelCat);
            this.maintab.Controls.Add(this.lstCatergory);
            this.maintab.Location = new System.Drawing.Point(4, 32);
            this.maintab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maintab.Name = "maintab";
            this.maintab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maintab.Size = new System.Drawing.Size(1228, 702);
            this.maintab.TabIndex = 0;
            this.maintab.Text = "Catalog";
            this.maintab.Click += new System.EventHandler(this.maintab_Click);
            // 
            // lblPID
            // 
            this.lblPID.AutoSize = true;
            this.lblPID.Location = new System.Drawing.Point(1107, 340);
            this.lblPID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPID.Name = "lblPID";
            this.lblPID.Size = new System.Drawing.Size(0, 24);
            this.lblPID.TabIndex = 12;
            this.lblPID.Visible = false;
            // 
            // FlwPanel
            // 
            this.FlwPanel.AutoScroll = true;
            this.FlwPanel.Location = new System.Drawing.Point(243, 37);
            this.FlwPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FlwPanel.Name = "FlwPanel";
            this.FlwPanel.Size = new System.Drawing.Size(608, 608);
            this.FlwPanel.TabIndex = 11;
            // 
            // btnAddCart
            // 
            this.btnAddCart.Location = new System.Drawing.Point(1011, 588);
            this.btnAddCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(171, 57);
            this.btnAddCart.TabIndex = 10;
            this.btnAddCart.Text = "Add To Cart";
            this.btnAddCart.UseVisualStyleBackColor = true;
            this.btnAddCart.Click += new System.EventHandler(this.btnAddCart_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(869, 554);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(58, 24);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Price:";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(869, 588);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(78, 24);
            this.lblQty.TabIndex = 8;
            this.lblQty.Text = "Quantity";
            // 
            // numQty
            // 
            this.numQty.Location = new System.Drawing.Point(873, 615);
            this.numQty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(120, 29);
            this.numQty.TabIndex = 7;
            this.numQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtSelDesc
            // 
            this.txtSelDesc.Location = new System.Drawing.Point(873, 367);
            this.txtSelDesc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSelDesc.Multiline = true;
            this.txtSelDesc.Name = "txtSelDesc";
            this.txtSelDesc.ReadOnly = true;
            this.txtSelDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSelDesc.Size = new System.Drawing.Size(308, 170);
            this.txtSelDesc.TabIndex = 6;
            // 
            // lblSelProdNam
            // 
            this.lblSelProdNam.AutoSize = true;
            this.lblSelProdNam.Location = new System.Drawing.Point(869, 340);
            this.lblSelProdNam.Name = "lblSelProdNam";
            this.lblSelProdNam.Size = new System.Drawing.Size(0, 24);
            this.lblSelProdNam.TabIndex = 5;
            // 
            // lblProdInfo
            // 
            this.lblProdInfo.AutoSize = true;
            this.lblProdInfo.Location = new System.Drawing.Point(869, 10);
            this.lblProdInfo.Name = "lblProdInfo";
            this.lblProdInfo.Size = new System.Drawing.Size(172, 24);
            this.lblProdInfo.TabIndex = 3;
            this.lblProdInfo.Text = "Product Information";
            // 
            // PicSelProd
            // 
            this.PicSelProd.Location = new System.Drawing.Point(921, 37);
            this.PicSelProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PicSelProd.Name = "PicSelProd";
            this.PicSelProd.Size = new System.Drawing.Size(223, 298);
            this.PicSelProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicSelProd.TabIndex = 2;
            this.PicSelProd.TabStop = false;
            // 
            // lblSelCat
            // 
            this.lblSelCat.AutoSize = true;
            this.lblSelCat.Location = new System.Drawing.Point(8, 10);
            this.lblSelCat.Name = "lblSelCat";
            this.lblSelCat.Size = new System.Drawing.Size(142, 24);
            this.lblSelCat.TabIndex = 1;
            this.lblSelCat.Text = "Select Category";
            // 
            // lstCatergory
            // 
            this.lstCatergory.FormattingEnabled = true;
            this.lstCatergory.ItemHeight = 24;
            this.lstCatergory.Location = new System.Drawing.Point(8, 37);
            this.lstCatergory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstCatergory.Name = "lstCatergory";
            this.lstCatergory.Size = new System.Drawing.Size(213, 580);
            this.lstCatergory.TabIndex = 0;
            this.lstCatergory.SelectedIndexChanged += new System.EventHandler(this.lstCatergory_SelectedIndexChanged);
            // 
            // carttab
            // 
            this.carttab.Controls.Add(this.cartView);
            this.carttab.Controls.Add(this.memStatusBox);
            this.carttab.Controls.Add(this.label3);
            this.carttab.Controls.Add(this.label2);
            this.carttab.Controls.Add(this.couponBox);
            this.carttab.Controls.Add(this.label1);
            this.carttab.Controls.Add(this.totalcartBox);
            this.carttab.Controls.Add(this.btnCheckout);
            this.carttab.Location = new System.Drawing.Point(4, 32);
            this.carttab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.carttab.Name = "carttab";
            this.carttab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.carttab.Size = new System.Drawing.Size(1228, 702);
            this.carttab.TabIndex = 1;
            this.carttab.Text = "Cart";
            this.carttab.UseVisualStyleBackColor = true;
            // 
            // cartView
            // 
            this.cartView.AllowUserToAddRows = false;
            this.cartView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartView.Location = new System.Drawing.Point(9, 9);
            this.cartView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cartView.Name = "cartView";
            this.cartView.ReadOnly = true;
            this.cartView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.cartView.Size = new System.Drawing.Size(1207, 446);
            this.cartView.TabIndex = 8;
            this.cartView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.cartView_RowsAdded);
            this.cartView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.cartView_RowsRemoved);
            // 
            // memStatusBox
            // 
            this.memStatusBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memStatusBox.ForeColor = System.Drawing.Color.Maroon;
            this.memStatusBox.Location = new System.Drawing.Point(200, 478);
            this.memStatusBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.memStatusBox.Name = "memStatusBox";
            this.memStatusBox.ReadOnly = true;
            this.memStatusBox.Size = new System.Drawing.Size(185, 34);
            this.memStatusBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 481);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Member Status:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(843, 544);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Coupon Code:";
            // 
            // couponBox
            // 
            this.couponBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.couponBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.couponBox.ForeColor = System.Drawing.Color.Maroon;
            this.couponBox.Location = new System.Drawing.Point(1029, 540);
            this.couponBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.couponBox.Name = "couponBox";
            this.couponBox.Size = new System.Drawing.Size(185, 34);
            this.couponBox.TabIndex = 4;
            this.couponBox.TextChanged += new System.EventHandler(this.couponBox_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(947, 481);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total:";
            // 
            // totalcartBox
            // 
            this.totalcartBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalcartBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.totalcartBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalcartBox.ForeColor = System.Drawing.Color.Maroon;
            this.totalcartBox.Location = new System.Drawing.Point(1029, 478);
            this.totalcartBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.totalcartBox.Name = "totalcartBox";
            this.totalcartBox.ReadOnly = true;
            this.totalcartBox.Size = new System.Drawing.Size(187, 34);
            this.totalcartBox.TabIndex = 2;
            this.totalcartBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckout.BackColor = System.Drawing.Color.Maroon;
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Location = new System.Drawing.Point(1047, 588);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(145, 53);
            this.btnCheckout.TabIndex = 1;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // accTab
            // 
            this.accTab.Controls.Add(this.panel1);
            this.accTab.Location = new System.Drawing.Point(4, 32);
            this.accTab.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.accTab.Name = "accTab";
            this.accTab.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.accTab.Size = new System.Drawing.Size(1228, 702);
            this.accTab.TabIndex = 2;
            this.accTab.Text = "My Account";
            this.accTab.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.registerBtn);
            this.panel1.Controls.Add(this.loginBtn);
            this.panel1.Controls.Add(this.passwordBox);
            this.panel1.Controls.Add(this.usernameBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(8, -26);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1209, 667);
            this.panel1.TabIndex = 0;
            // 
            // registerBtn
            // 
            this.registerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.registerBtn.BackColor = System.Drawing.Color.White;
            this.registerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.ForeColor = System.Drawing.Color.Black;
            this.registerBtn.Location = new System.Drawing.Point(431, 363);
            this.registerBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(139, 69);
            this.registerBtn.TabIndex = 5;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.loginBtn.BackColor = System.Drawing.Color.White;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.Black;
            this.loginBtn.Location = new System.Drawing.Point(612, 363);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(139, 69);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(521, 277);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(275, 34);
            this.passwordBox.TabIndex = 3;
            // 
            // usernameBox
            // 
            this.usernameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.usernameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameBox.Location = new System.Drawing.Point(521, 223);
            this.usernameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(275, 34);
            this.usernameBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(377, 281);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Password:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(377, 226);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Username:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Report
            // 
            this.Report.Controls.Add(this.lblTotSale);
            this.Report.Controls.Add(this.lblAvgSales);
            this.Report.Controls.Add(this.DGVrep);
            this.Report.Location = new System.Drawing.Point(4, 32);
            this.Report.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(1228, 702);
            this.Report.TabIndex = 3;
            this.Report.Text = "Report";
            this.Report.UseVisualStyleBackColor = true;
            // 
            // lblTotSale
            // 
            this.lblTotSale.AutoSize = true;
            this.lblTotSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotSale.Location = new System.Drawing.Point(661, 494);
            this.lblTotSale.Name = "lblTotSale";
            this.lblTotSale.Size = new System.Drawing.Size(171, 36);
            this.lblTotSale.TabIndex = 11;
            this.lblTotSale.Text = "Total Sales:";
            // 
            // lblAvgSales
            // 
            this.lblAvgSales.AutoSize = true;
            this.lblAvgSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgSales.Location = new System.Drawing.Point(45, 494);
            this.lblAvgSales.Name = "lblAvgSales";
            this.lblAvgSales.Size = new System.Drawing.Size(216, 36);
            this.lblAvgSales.TabIndex = 10;
            this.lblAvgSales.Text = "Average Sales:";
            // 
            // DGVrep
            // 
            this.DGVrep.AllowUserToAddRows = false;
            this.DGVrep.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVrep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVrep.Location = new System.Drawing.Point(4, 4);
            this.DGVrep.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGVrep.Name = "DGVrep";
            this.DGVrep.ReadOnly = true;
            this.DGVrep.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGVrep.Size = new System.Drawing.Size(1207, 446);
            this.DGVrep.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(21, 5);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "Welcome,";
            // 
            // lblGreet
            // 
            this.lblGreet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblGreet.AutoSize = true;
            this.lblGreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreet.ForeColor = System.Drawing.SystemColors.Control;
            this.lblGreet.Location = new System.Drawing.Point(145, 5);
            this.lblGreet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGreet.Name = "lblGreet";
            this.lblGreet.Size = new System.Drawing.Size(76, 29);
            this.lblGreet.TabIndex = 2;
            this.lblGreet.Text = "Guest";
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(1137, 9);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 38);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Visible = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(412, 5);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(270, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Potatozine Revision 120";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage_1);
            // 
            // catalogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1273, 734);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblGreet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tabs);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "catalogue";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Potatozine";
            this.Load += new System.EventHandler(this.catalogue_Load);
            this.tabs.ResumeLayout(false);
            this.maintab.ResumeLayout(false);
            this.maintab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSelProd)).EndInit();
            this.carttab.ResumeLayout(false);
            this.carttab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartView)).EndInit();
            this.accTab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Report.ResumeLayout(false);
            this.Report.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVrep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage maintab;
        private System.Windows.Forms.TabPage carttab;
        private System.Windows.Forms.TabPage accTab;
        private System.Windows.Forms.TextBox totalcartBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox couponBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox memStatusBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnAddCart;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.TextBox txtSelDesc;
        private System.Windows.Forms.Label lblSelProdNam;
        private System.Windows.Forms.Label lblProdInfo;
        private System.Windows.Forms.PictureBox PicSelProd;
        private System.Windows.Forms.Label lblSelCat;
        private System.Windows.Forms.ListBox lstCatergory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblGreet;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.FlowLayoutPanel FlwPanel;
        private System.Windows.Forms.Label lblPID;
        private System.Windows.Forms.DataGridView cartView;
        private System.Windows.Forms.TabPage Report;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DGVrep;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.Label lblTotSale;
        private System.Windows.Forms.Label lblAvgSales;
    }
}

