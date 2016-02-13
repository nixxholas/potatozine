namespace potatozine
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblSelProdNam = new System.Windows.Forms.Label();
            this.itemView = new System.Windows.Forms.ListView();
            this.lblProdInfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSelCat = new System.Windows.Forms.Label();
            this.lstCatergory = new System.Windows.Forms.ListBox();
            this.carttab = new System.Windows.Forms.TabPage();
            this.cartView = new System.Windows.Forms.ListView();
            this.pidCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prodCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.memStatusBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.accTab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.registerBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabs.SuspendLayout();
            this.maintab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.carttab.SuspendLayout();
            this.accTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.maintab);
            this.tabs.Controls.Add(this.carttab);
            this.tabs.Controls.Add(this.accTab);
            this.tabs.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabs.ItemSize = new System.Drawing.Size(78, 28);
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(977, 653);
            this.tabs.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabs.TabIndex = 0;
            this.tabs.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabs_Selected);
            // 
            // maintab
            // 
            this.maintab.BackColor = System.Drawing.Color.Silver;
            this.maintab.Controls.Add(this.button1);
            this.maintab.Controls.Add(this.lblPrice);
            this.maintab.Controls.Add(this.lblQty);
            this.maintab.Controls.Add(this.numQty);
            this.maintab.Controls.Add(this.textBox3);
            this.maintab.Controls.Add(this.lblSelProdNam);
            this.maintab.Controls.Add(this.itemView);
            this.maintab.Controls.Add(this.lblProdInfo);
            this.maintab.Controls.Add(this.pictureBox1);
            this.maintab.Controls.Add(this.lblSelCat);
            this.maintab.Controls.Add(this.lstCatergory);
            this.maintab.Location = new System.Drawing.Point(4, 32);
            this.maintab.Name = "maintab";
            this.maintab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.maintab.Size = new System.Drawing.Size(890, 560);
            this.maintab.TabIndex = 0;
            this.maintab.Text = "Catalog";
            this.maintab.Click += new System.EventHandler(this.maintab_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(758, 498);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 46);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add To Cart";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(652, 470);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(46, 18);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Price:";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(652, 498);
            this.lblQty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(62, 18);
            this.lblQty.TabIndex = 8;
            this.lblQty.Text = "Quantity";
            // 
            // numQty
            // 
            this.numQty.Location = new System.Drawing.Point(655, 520);
            this.numQty.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(90, 24);
            this.numQty.TabIndex = 7;
            this.numQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(655, 318);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(232, 139);
            this.textBox3.TabIndex = 6;
            // 
            // lblSelProdNam
            // 
            this.lblSelProdNam.AutoSize = true;
            this.lblSelProdNam.Location = new System.Drawing.Point(652, 296);
            this.lblSelProdNam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelProdNam.Name = "lblSelProdNam";
            this.lblSelProdNam.Size = new System.Drawing.Size(37, 18);
            this.lblSelProdNam.TabIndex = 5;
            this.lblSelProdNam.Text = "Test";
            // 
            // itemView
            // 
            this.itemView.Location = new System.Drawing.Point(183, 50);
            this.itemView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.itemView.Name = "itemView";
            this.itemView.Size = new System.Drawing.Size(457, 495);
            this.itemView.TabIndex = 4;
            this.itemView.UseCompatibleStateImageBehavior = false;
            // 
            // lblProdInfo
            // 
            this.lblProdInfo.AutoSize = true;
            this.lblProdInfo.Location = new System.Drawing.Point(652, 28);
            this.lblProdInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProdInfo.Name = "lblProdInfo";
            this.lblProdInfo.Size = new System.Drawing.Size(138, 18);
            this.lblProdInfo.TabIndex = 3;
            this.lblProdInfo.Text = "Product Information";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(691, 50);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 242);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblSelCat
            // 
            this.lblSelCat.AutoSize = true;
            this.lblSelCat.Location = new System.Drawing.Point(6, 28);
            this.lblSelCat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelCat.Name = "lblSelCat";
            this.lblSelCat.Size = new System.Drawing.Size(113, 18);
            this.lblSelCat.TabIndex = 1;
            this.lblSelCat.Text = "Select Category";
            // 
            // lstCatergory
            // 
            this.lstCatergory.FormattingEnabled = true;
            this.lstCatergory.ItemHeight = 18;
            this.lstCatergory.Location = new System.Drawing.Point(6, 50);
            this.lstCatergory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstCatergory.Name = "lstCatergory";
            this.lstCatergory.Size = new System.Drawing.Size(161, 490);
            this.lstCatergory.TabIndex = 0;
            // 
            // carttab
            // 
            this.carttab.Controls.Add(this.cartView);
            this.carttab.Controls.Add(this.memStatusBox);
            this.carttab.Controls.Add(this.label3);
            this.carttab.Controls.Add(this.label2);
            this.carttab.Controls.Add(this.textBox2);
            this.carttab.Controls.Add(this.label1);
            this.carttab.Controls.Add(this.textBox1);
            this.carttab.Controls.Add(this.btnCheckout);
            this.carttab.Location = new System.Drawing.Point(4, 32);
            this.carttab.Name = "carttab";
            this.carttab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.carttab.Size = new System.Drawing.Size(890, 560);
            this.carttab.TabIndex = 1;
            this.carttab.Text = "Cart";
            this.carttab.UseVisualStyleBackColor = true;
            // 
            // cartView
            // 
            this.cartView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cartView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.pidCol,
            this.prodCol,
            this.descCol,
            this.priceCol});
            this.cartView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartView.ForeColor = System.Drawing.Color.White;
            this.cartView.GridLines = true;
            this.cartView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.cartView.Location = new System.Drawing.Point(8, 0);
            this.cartView.Name = "cartView";
            this.cartView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cartView.Size = new System.Drawing.Size(871, 368);
            this.cartView.TabIndex = 8;
            this.cartView.UseCompatibleStateImageBehavior = false;
            this.cartView.View = System.Windows.Forms.View.Details;
            // 
            // pidCol
            // 
            this.pidCol.Text = "ID";
            this.pidCol.Width = 80;
            // 
            // prodCol
            // 
            this.prodCol.Text = "Product";
            this.prodCol.Width = 225;
            // 
            // descCol
            // 
            this.descCol.Text = "Description";
            this.descCol.Width = 300;
            // 
            // priceCol
            // 
            this.priceCol.Text = "Price";
            this.priceCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.priceCol.Width = 100;
            // 
            // memStatusBox
            // 
            this.memStatusBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memStatusBox.ForeColor = System.Drawing.Color.Maroon;
            this.memStatusBox.Location = new System.Drawing.Point(153, 396);
            this.memStatusBox.Name = "memStatusBox";
            this.memStatusBox.ReadOnly = true;
            this.memStatusBox.Size = new System.Drawing.Size(140, 29);
            this.memStatusBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Member Status:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(601, 470);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Coupon Code:";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Maroon;
            this.textBox2.Location = new System.Drawing.Point(741, 467);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 29);
            this.textBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(679, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Maroon;
            this.textBox1.Location = new System.Drawing.Point(741, 396);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(141, 29);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckout.BackColor = System.Drawing.Color.Maroon;
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Location = new System.Drawing.Point(775, 509);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(109, 43);
            this.btnCheckout.TabIndex = 1;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // accTab
            // 
            this.accTab.Controls.Add(this.panel1);
            this.accTab.Location = new System.Drawing.Point(4, 32);
            this.accTab.Name = "accTab";
            this.accTab.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.accTab.Size = new System.Drawing.Size(969, 617);
            this.accTab.TabIndex = 2;
            this.accTab.Text = "My Account";
            this.accTab.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.registerBtn);
            this.panel1.Controls.Add(this.loginBtn);
            this.panel1.Controls.Add(this.passwordBox);
            this.panel1.Controls.Add(this.usernameBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(40, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 484);
            this.panel1.TabIndex = 0;
            // 
            // registerBtn
            // 
            this.registerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.registerBtn.BackColor = System.Drawing.Color.White;
            this.registerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.ForeColor = System.Drawing.Color.Black;
            this.registerBtn.Location = new System.Drawing.Point(308, 227);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(120, 49);
            this.registerBtn.TabIndex = 5;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.loginBtn.BackColor = System.Drawing.Color.White;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.Black;
            this.loginBtn.Location = new System.Drawing.Point(444, 227);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(120, 49);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.Location = new System.Drawing.Point(379, 174);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(207, 29);
            this.passwordBox.TabIndex = 3;
            // 
            // usernameBox
            // 
            this.usernameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.usernameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameBox.Location = new System.Drawing.Point(379, 130);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(207, 29);
            this.usernameBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(271, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 24);
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
            this.label4.Location = new System.Drawing.Point(271, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Username:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // catalogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(977, 653);
            this.Controls.Add(this.tabs);
            this.Name = "catalogue";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Potatozine";
            this.tabs.ResumeLayout(false);
            this.maintab.ResumeLayout(false);
            this.maintab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.carttab.ResumeLayout(false);
            this.carttab.PerformLayout();
            this.accTab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage maintab;
        private System.Windows.Forms.TabPage carttab;
        private System.Windows.Forms.TabPage accTab;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox memStatusBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.ColumnHeader pidCol;
        private System.Windows.Forms.ColumnHeader prodCol;
        private System.Windows.Forms.ColumnHeader descCol;
        private System.Windows.Forms.ColumnHeader priceCol;
        public System.Windows.Forms.ListView cartView;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblSelProdNam;
        private System.Windows.Forms.ListView itemView;
        private System.Windows.Forms.Label lblProdInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSelCat;
        private System.Windows.Forms.ListBox lstCatergory;
    }
}

