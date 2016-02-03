namespace potatozine
{
    partial class main
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
            this.carttab = new System.Windows.Forms.TabPage();
            this.accTab = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.tabs.SuspendLayout();
            this.carttab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.maintab);
            this.tabs.Controls.Add(this.carttab);
            this.tabs.Controls.Add(this.accTab);
            this.tabs.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabs.ItemSize = new System.Drawing.Size(78, 28);
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(673, 424);
            this.tabs.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabs.TabIndex = 0;
            // 
            // maintab
            // 
            this.maintab.BackColor = System.Drawing.Color.Silver;
            this.maintab.Location = new System.Drawing.Point(4, 32);
            this.maintab.Name = "maintab";
            this.maintab.Padding = new System.Windows.Forms.Padding(3);
            this.maintab.Size = new System.Drawing.Size(665, 388);
            this.maintab.TabIndex = 0;
            this.maintab.Text = "Catalog";
            this.maintab.Click += new System.EventHandler(this.maintab_Click);
            // 
            // carttab
            // 
            this.carttab.Controls.Add(this.btnCheckout);
            this.carttab.Controls.Add(this.listView1);
            this.carttab.Location = new System.Drawing.Point(4, 32);
            this.carttab.Name = "carttab";
            this.carttab.Padding = new System.Windows.Forms.Padding(3);
            this.carttab.Size = new System.Drawing.Size(665, 388);
            this.carttab.TabIndex = 1;
            this.carttab.Text = "Cart";
            this.carttab.UseVisualStyleBackColor = true;
            // 
            // accTab
            // 
            this.accTab.Location = new System.Drawing.Point(4, 32);
            this.accTab.Name = "accTab";
            this.accTab.Padding = new System.Windows.Forms.Padding(3);
            this.accTab.Size = new System.Drawing.Size(665, 388);
            this.accTab.TabIndex = 2;
            this.accTab.Text = "My Account";
            this.accTab.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.DimGray;
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.Location = new System.Drawing.Point(6, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(651, 196);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.Maroon;
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Location = new System.Drawing.Point(548, 337);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(109, 43);
            this.btnCheckout.TabIndex = 1;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = false;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(673, 424);
            this.Controls.Add(this.tabs);
            this.Name = "main";
            this.ShowIcon = false;
            this.Text = "Potatozine";
            this.tabs.ResumeLayout(false);
            this.carttab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage maintab;
        private System.Windows.Forms.TabPage carttab;
        private System.Windows.Forms.TabPage accTab;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.ListView listView1;
    }
}

