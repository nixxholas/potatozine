namespace Assignment
{
    partial class ItemInfo
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
            this.PicItemInfo = new System.Windows.Forms.PictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblPotatoZine = new System.Windows.Forms.Label();
            this.lblPdctInfo = new System.Windows.Forms.Label();
            this.lblProdNam = new System.Windows.Forms.Label();
            this.txtProdDesc = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnAddCart = new System.Windows.Forms.Button();
            this.lblCat = new System.Windows.Forms.Label();
            this.lblCatShown = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicItemInfo)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // PicItemInfo
            // 
            this.PicItemInfo.Location = new System.Drawing.Point(9, 95);
            this.PicItemInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PicItemInfo.Name = "PicItemInfo";
            this.PicItemInfo.Size = new System.Drawing.Size(216, 287);
            this.PicItemInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicItemInfo.TabIndex = 0;
            this.PicItemInfo.TabStop = false;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Teal;
            this.panelTop.Controls.Add(this.btnBack);
            this.panelTop.Controls.Add(this.lblPotatoZine);
            this.panelTop.Location = new System.Drawing.Point(-5, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(746, 41);
            this.panelTop.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(536, 6);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(195, 27);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back to Catalogue";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblPotatoZine
            // 
            this.lblPotatoZine.AutoSize = true;
            this.lblPotatoZine.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPotatoZine.ForeColor = System.Drawing.Color.White;
            this.lblPotatoZine.Location = new System.Drawing.Point(12, 6);
            this.lblPotatoZine.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPotatoZine.Name = "lblPotatoZine";
            this.lblPotatoZine.Size = new System.Drawing.Size(109, 30);
            this.lblPotatoZine.TabIndex = 0;
            this.lblPotatoZine.Text = "PotatoZine";
            // 
            // lblPdctInfo
            // 
            this.lblPdctInfo.AutoSize = true;
            this.lblPdctInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPdctInfo.Location = new System.Drawing.Point(9, 54);
            this.lblPdctInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPdctInfo.Name = "lblPdctInfo";
            this.lblPdctInfo.Size = new System.Drawing.Size(202, 26);
            this.lblPdctInfo.TabIndex = 6;
            this.lblPdctInfo.Text = "Product Information";
            // 
            // lblProdNam
            // 
            this.lblProdNam.AutoSize = true;
            this.lblProdNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdNam.Location = new System.Drawing.Point(240, 95);
            this.lblProdNam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProdNam.Name = "lblProdNam";
            this.lblProdNam.Size = new System.Drawing.Size(131, 24);
            this.lblProdNam.TabIndex = 7;
            this.lblProdNam.Text = "Product Name";
            // 
            // txtProdDesc
            // 
            this.txtProdDesc.Location = new System.Drawing.Point(244, 121);
            this.txtProdDesc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProdDesc.Multiline = true;
            this.txtProdDesc.Name = "txtProdDesc";
            this.txtProdDesc.ReadOnly = true;
            this.txtProdDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtProdDesc.Size = new System.Drawing.Size(483, 227);
            this.txtProdDesc.TabIndex = 8;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(369, 358);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(68, 20);
            this.lblQuantity.TabIndex = 9;
            this.lblQuantity.Text = "Quantity";
            // 
            // numQuantity
            // 
            this.numQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numQuantity.Location = new System.Drawing.Point(437, 353);
            this.numQuantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(90, 28);
            this.numQuantity.TabIndex = 11;
            this.numQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(240, 358);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 20);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(286, 353);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(76, 28);
            this.txtPrice.TabIndex = 13;
            // 
            // btnAddCart
            // 
            this.btnAddCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCart.Location = new System.Drawing.Point(607, 353);
            this.btnAddCart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(119, 29);
            this.btnAddCart.TabIndex = 14;
            this.btnAddCart.Text = "Add to cart";
            this.btnAddCart.UseVisualStyleBackColor = true;
            this.btnAddCart.Click += new System.EventHandler(this.btnAddCart_Click);
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCat.Location = new System.Drawing.Point(595, 95);
            this.lblCat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(85, 24);
            this.lblCat.TabIndex = 15;
            this.lblCat.Text = "Category";
            // 
            // lblCatShown
            // 
            this.lblCatShown.AutoSize = true;
            this.lblCatShown.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatShown.Location = new System.Drawing.Point(506, 95);
            this.lblCatShown.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCatShown.Name = "lblCatShown";
            this.lblCatShown.Size = new System.Drawing.Size(95, 24);
            this.lblCatShown.TabIndex = 16;
            this.lblCatShown.Text = "Category :";
            // 
            // ItemInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(735, 450);
            this.Controls.Add(this.lblCatShown);
            this.Controls.Add(this.lblCat);
            this.Controls.Add(this.btnAddCart);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtProdDesc);
            this.Controls.Add(this.lblProdNam);
            this.Controls.Add(this.lblPdctInfo);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.PicItemInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ItemInfo";
            this.Text = "Item Info";
            ((System.ComponentModel.ISupportInitialize)(this.PicItemInfo)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicItemInfo;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblPotatoZine;
        private System.Windows.Forms.Label lblPdctInfo;
        private System.Windows.Forms.Label lblProdNam;
        private System.Windows.Forms.TextBox txtProdDesc;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        public System.Windows.Forms.Button btnAddCart;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.Label lblCatShown;
    }
}