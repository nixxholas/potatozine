﻿namespace Assignment
{
    partial class CartGUI
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnBackShop = new System.Windows.Forms.Button();
            this.lblPotatoZine = new System.Windows.Forms.Label();
            this.lblCart = new System.Windows.Forms.Label();
            this.btnCartRem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Teal;
            this.panelTop.Controls.Add(this.btnBackShop);
            this.panelTop.Controls.Add(this.lblPotatoZine);
            this.panelTop.Location = new System.Drawing.Point(1, -1);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(746, 41);
            this.panelTop.TabIndex = 16;
            // 
            // btnBackShop
            // 
            this.btnBackShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackShop.Location = new System.Drawing.Point(602, 6);
            this.btnBackShop.Margin = new System.Windows.Forms.Padding(2);
            this.btnBackShop.Name = "btnBackShop";
            this.btnBackShop.Size = new System.Drawing.Size(129, 27);
            this.btnBackShop.TabIndex = 1;
            this.btnBackShop.Text = "Back to Catalogue";
            this.btnBackShop.UseVisualStyleBackColor = true;
            this.btnBackShop.Click += new System.EventHandler(this.btnBackShop_Click);
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
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCart.Location = new System.Drawing.Point(15, 53);
            this.lblCart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(106, 26);
            this.lblCart.TabIndex = 17;
            this.lblCart.Text = "Your Cart";
            // 
            // btnCartRem
            // 
            this.btnCartRem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCartRem.Location = new System.Drawing.Point(552, 91);
            this.btnCartRem.Margin = new System.Windows.Forms.Padding(2);
            this.btnCartRem.Name = "btnCartRem";
            this.btnCartRem.Size = new System.Drawing.Size(172, 38);
            this.btnCartRem.TabIndex = 19;
            this.btnCartRem.Text = "Clear Cart";
            this.btnCartRem.UseVisualStyleBackColor = true;
            this.btnCartRem.Click += new System.EventHandler(this.btnCartRem_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(552, 361);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 38);
            this.button1.TabIndex = 20;
            this.button1.Text = "CheckOut";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(548, 297);
            this.lblSubTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(59, 26);
            this.lblSubTotal.TabIndex = 21;
            this.lblSubTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(552, 326);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(173, 32);
            this.txtTotal.TabIndex = 22;
            this.txtTotal.Text = "0";
            // 
            // lstCart
            // 
            this.lstCart.FormattingEnabled = true;
            this.lstCart.Location = new System.Drawing.Point(20, 91);
            this.lstCart.Margin = new System.Windows.Forms.Padding(2);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(525, 303);
            this.lstCart.TabIndex = 25;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(553, 148);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 38);
            this.button2.TabIndex = 26;
            this.button2.Text = "Remove Item";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CartGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 445);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lstCart);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCartRem);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.lblCart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CartGUI";
            this.Text = "                                ";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnBackShop;
        private System.Windows.Forms.Label lblPotatoZine;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.Button btnCartRem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.TextBox txtTotal;
        public System.Windows.Forms.ListBox lstCart;
        private System.Windows.Forms.Button button2;
    }
}