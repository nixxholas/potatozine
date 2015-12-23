namespace Assignment
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
            this.refBtn = new System.Windows.Forms.Button();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Teal;
            this.panelTop.Controls.Add(this.btnBackShop);
            this.panelTop.Controls.Add(this.lblPotatoZine);
            this.panelTop.Location = new System.Drawing.Point(1, -1);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(995, 50);
            this.panelTop.TabIndex = 16;
            // 
            // btnBackShop
            // 
            this.btnBackShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackShop.Location = new System.Drawing.Point(803, 7);
            this.btnBackShop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackShop.Name = "btnBackShop";
            this.btnBackShop.Size = new System.Drawing.Size(172, 33);
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
            this.lblPotatoZine.Location = new System.Drawing.Point(16, 7);
            this.lblPotatoZine.Name = "lblPotatoZine";
            this.lblPotatoZine.Size = new System.Drawing.Size(137, 38);
            this.lblPotatoZine.TabIndex = 0;
            this.lblPotatoZine.Text = "PotatoZine";
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCart.Location = new System.Drawing.Point(20, 65);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(135, 32);
            this.lblCart.TabIndex = 17;
            this.lblCart.Text = "Your Cart";
            // 
            // btnCartRem
            // 
            this.btnCartRem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCartRem.Location = new System.Drawing.Point(736, 112);
            this.btnCartRem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCartRem.Name = "btnCartRem";
            this.btnCartRem.Size = new System.Drawing.Size(229, 47);
            this.btnCartRem.TabIndex = 19;
            this.btnCartRem.Text = "Remove Item";
            this.btnCartRem.UseVisualStyleBackColor = true;
            this.btnCartRem.Click += new System.EventHandler(this.btnCartRem_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(736, 444);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 47);
            this.button1.TabIndex = 20;
            this.button1.Text = "CheckOut";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(731, 366);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(79, 32);
            this.lblSubTotal.TabIndex = 21;
            this.lblSubTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(736, 401);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(229, 38);
            this.txtTotal.TabIndex = 22;
            // 
            // refBtn
            // 
            this.refBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refBtn.Location = new System.Drawing.Point(736, 183);
            this.refBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.refBtn.Name = "refBtn";
            this.refBtn.Size = new System.Drawing.Size(229, 47);
            this.refBtn.TabIndex = 24;
            this.refBtn.Text = "Refresh";
            this.refBtn.UseVisualStyleBackColor = true;
            this.refBtn.Click += new System.EventHandler(this.refBtn_Click);
            // 
            // lstCart
            // 
            this.lstCart.FormattingEnabled = true;
            this.lstCart.ItemHeight = 16;
            this.lstCart.Location = new System.Drawing.Point(27, 112);
            this.lstCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(699, 372);
            this.lstCart.TabIndex = 25;
            // 
            // CartGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 548);
            this.Controls.Add(this.lstCart);
            this.Controls.Add(this.refBtn);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCartRem);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.lblCart);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button refBtn;
        private System.Windows.Forms.ListBox lstCart;
    }
}