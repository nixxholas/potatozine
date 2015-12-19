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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBackShop = new System.Windows.Forms.Button();
            this.lblPotatoZine = new System.Windows.Forms.Label();
            this.lblCart = new System.Windows.Forms.Label();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.btnCartRem = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.btnBackShop);
            this.panel1.Controls.Add(this.lblPotatoZine);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 41);
            this.panel1.TabIndex = 16;
            // 
            // btnBackShop
            // 
            this.btnBackShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackShop.Location = new System.Drawing.Point(602, 6);
            this.btnBackShop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBackShop.Name = "btnBackShop";
            this.btnBackShop.Size = new System.Drawing.Size(129, 27);
            this.btnBackShop.TabIndex = 1;
            this.btnBackShop.Text = "Back to Catalogue";
            this.btnBackShop.UseVisualStyleBackColor = true;
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
            // lstCart
            // 
            this.lstCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCart.FormattingEnabled = true;
            this.lstCart.ItemHeight = 20;
            this.lstCart.Location = new System.Drawing.Point(18, 91);
            this.lstCart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstCart.Name = "lstCart";
            this.lstCart.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstCart.Size = new System.Drawing.Size(506, 324);
            this.lstCart.TabIndex = 18;
            // 
            // btnCartRem
            // 
            this.btnCartRem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCartRem.Location = new System.Drawing.Point(552, 91);
            this.btnCartRem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCartRem.Name = "btnCartRem";
            this.btnCartRem.Size = new System.Drawing.Size(172, 38);
            this.btnCartRem.TabIndex = 19;
            this.btnCartRem.Text = "Remove Item";
            this.btnCartRem.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(552, 381);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 38);
            this.button1.TabIndex = 20;
            this.button1.Text = "CheckOut";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CartGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 445);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCartRem);
            this.Controls.Add(this.lstCart);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCart);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CartGUI";
            this.Text = "CartGUI";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBackShop;
        private System.Windows.Forms.Label lblPotatoZine;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.Button btnCartRem;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ListBox lstCart;
    }
}