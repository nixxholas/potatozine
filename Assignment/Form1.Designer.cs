﻿namespace Assignment
{
    partial class Form1
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
            this.picBanner = new System.Windows.Forms.PictureBox();
            this.lstCatergory = new System.Windows.Forms.ListBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.btnLstItms = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnCart = new System.Windows.Forms.Button();
            this.lblPotatoZine = new System.Windows.Forms.Label();
            this.picItem1 = new System.Windows.Forms.PictureBox();
            this.picItem2 = new System.Windows.Forms.PictureBox();
            this.picItem3 = new System.Windows.Forms.PictureBox();
            this.picItem6 = new System.Windows.Forms.PictureBox();
            this.picItem5 = new System.Windows.Forms.PictureBox();
            this.picItem4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // picBanner
            // 
            this.picBanner.BackgroundImage = global::Assignment.Properties.Resources.main;
            this.picBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBanner.Location = new System.Drawing.Point(9, 55);
            this.picBanner.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picBanner.Name = "picBanner";
            this.picBanner.Size = new System.Drawing.Size(708, 208);
            this.picBanner.TabIndex = 0;
            this.picBanner.TabStop = false;
            // 
            // lstCatergory
            // 
            this.lstCatergory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCatergory.FormattingEnabled = true;
            this.lstCatergory.ItemHeight = 17;
            this.lstCatergory.Items.AddRange(new object[] {
            "Fashion",
            "Technology",
            "Travel"});
            this.lstCatergory.Location = new System.Drawing.Point(9, 296);
            this.lstCatergory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstCatergory.Name = "lstCatergory";
            this.lstCatergory.Size = new System.Drawing.Size(173, 208);
            this.lstCatergory.TabIndex = 1;
            this.lstCatergory.SelectedIndexChanged += new System.EventHandler(this.lstCatergory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(8, 270);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(106, 24);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Catergories";
            // 
            // btnLstItms
            // 
            this.btnLstItms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLstItms.Location = new System.Drawing.Point(9, 569);
            this.btnLstItms.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLstItms.Name = "btnLstItms";
            this.btnLstItms.Size = new System.Drawing.Size(172, 30);
            this.btnLstItms.TabIndex = 3;
            this.btnLstItms.Text = "List Items";
            this.btnLstItms.UseVisualStyleBackColor = true;
            this.btnLstItms.Click += new System.EventHandler(this.btnLstItms_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Teal;
            this.panelTop.Controls.Add(this.btnCart);
            this.panelTop.Controls.Add(this.lblPotatoZine);
            this.panelTop.Location = new System.Drawing.Point(-5, -1);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(746, 41);
            this.panelTop.TabIndex = 4;
            // 
            // btnCart
            // 
            this.btnCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCart.Location = new System.Drawing.Point(658, 6);
            this.btnCart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(74, 29);
            this.btnCart.TabIndex = 1;
            this.btnCart.Text = "My Cart";
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
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
            // picItem1
            // 
            this.picItem1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picItem1.Location = new System.Drawing.Point(192, 296);
            this.picItem1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picItem1.Name = "picItem1";
            this.picItem1.Size = new System.Drawing.Size(166, 236);
            this.picItem1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picItem1.TabIndex = 5;
            this.picItem1.TabStop = false;
            this.picItem1.Click += new System.EventHandler(this.picItem1_Click);
            // 
            // picItem2
            // 
            this.picItem2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picItem2.Location = new System.Drawing.Point(370, 296);
            this.picItem2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picItem2.Name = "picItem2";
            this.picItem2.Size = new System.Drawing.Size(166, 236);
            this.picItem2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picItem2.TabIndex = 6;
            this.picItem2.TabStop = false;
            this.picItem2.Click += new System.EventHandler(this.picItem2_Click);
            // 
            // picItem3
            // 
            this.picItem3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.picItem3.Location = new System.Drawing.Point(551, 296);
            this.picItem3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picItem3.Name = "picItem3";
            this.picItem3.Size = new System.Drawing.Size(166, 236);
            this.picItem3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picItem3.TabIndex = 7;
            this.picItem3.TabStop = false;
            this.picItem3.Click += new System.EventHandler(this.picItem3_Click);
            // 
            // picItem6
            // 
            this.picItem6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.picItem6.Location = new System.Drawing.Point(551, 546);
            this.picItem6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picItem6.Name = "picItem6";
            this.picItem6.Size = new System.Drawing.Size(166, 236);
            this.picItem6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picItem6.TabIndex = 10;
            this.picItem6.TabStop = false;
            this.picItem6.Click += new System.EventHandler(this.picItem6_Click);
            // 
            // picItem5
            // 
            this.picItem5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.picItem5.Location = new System.Drawing.Point(370, 546);
            this.picItem5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picItem5.Name = "picItem5";
            this.picItem5.Size = new System.Drawing.Size(166, 236);
            this.picItem5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picItem5.TabIndex = 9;
            this.picItem5.TabStop = false;
            this.picItem5.Click += new System.EventHandler(this.picItem5_Click);
            // 
            // picItem4
            // 
            this.picItem4.BackColor = System.Drawing.Color.Aqua;
            this.picItem4.Location = new System.Drawing.Point(192, 546);
            this.picItem4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picItem4.Name = "picItem4";
            this.picItem4.Size = new System.Drawing.Size(166, 236);
            this.picItem4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picItem4.TabIndex = 8;
            this.picItem4.TabStop = false;
            this.picItem4.Click += new System.EventHandler(this.picItem4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(776, 602);
            this.Controls.Add(this.picItem6);
            this.Controls.Add(this.picItem5);
            this.Controls.Add(this.picItem4);
            this.Controls.Add(this.picItem3);
            this.Controls.Add(this.picItem2);
            this.Controls.Add(this.picItem1);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.btnLstItms);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lstCatergory);
            this.Controls.Add(this.picBanner);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Potatozine Catalogue";
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picItem4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBanner;
        private System.Windows.Forms.ListBox lstCatergory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button btnLstItms;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblPotatoZine;
        private System.Windows.Forms.PictureBox picItem1;
        private System.Windows.Forms.PictureBox picItem2;
        private System.Windows.Forms.PictureBox picItem3;
        private System.Windows.Forms.PictureBox picItem6;
        private System.Windows.Forms.PictureBox picItem5;
        private System.Windows.Forms.PictureBox picItem4;
        private System.Windows.Forms.Button btnCart;
    }
}

