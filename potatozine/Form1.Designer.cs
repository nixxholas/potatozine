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
            this.tabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs.Controls.Add(this.maintab);
            this.tabs.Controls.Add(this.carttab);
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(673, 424);
            this.tabs.TabIndex = 0;
            // 
            // maintab
            // 
            this.maintab.BackColor = System.Drawing.Color.Silver;
            this.maintab.Location = new System.Drawing.Point(4, 22);
            this.maintab.Name = "maintab";
            this.maintab.Padding = new System.Windows.Forms.Padding(3);
            this.maintab.Size = new System.Drawing.Size(665, 398);
            this.maintab.TabIndex = 0;
            this.maintab.Text = "Catalog";
            // 
            // carttab
            // 
            this.carttab.Location = new System.Drawing.Point(4, 22);
            this.carttab.Name = "carttab";
            this.carttab.Padding = new System.Windows.Forms.Padding(3);
            this.carttab.Size = new System.Drawing.Size(665, 398);
            this.carttab.TabIndex = 1;
            this.carttab.Text = "Cart";
            this.carttab.UseVisualStyleBackColor = true;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage maintab;
        private System.Windows.Forms.TabPage carttab;
    }
}

