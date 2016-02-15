namespace LoginWindowForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.chkPremium = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkRegular = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(157, 113);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(187, 30);
            this.txtUser.TabIndex = 2;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(157, 203);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(187, 30);
            this.txtPass.TabIndex = 3;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(38, 321);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 42);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(530, 321);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(113, 42);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(373, 203);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(189, 29);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Display Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(298, 321);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(113, 42);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // chkPremium
            // 
            this.chkPremium.AutoSize = true;
            this.chkPremium.Location = new System.Drawing.Point(110, 77);
            this.chkPremium.Name = "chkPremium";
            this.chkPremium.Size = new System.Drawing.Size(18, 17);
            this.chkPremium.TabIndex = 17;
            this.chkPremium.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Premium";
            // 
            // chkRegular
            // 
            this.chkRegular.AutoSize = true;
            this.chkRegular.Location = new System.Drawing.Point(100, 24);
            this.chkRegular.Name = "chkRegular";
            this.chkRegular.Size = new System.Drawing.Size(18, 17);
            this.chkRegular.TabIndex = 15;
            this.chkRegular.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Regular";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Membership:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.chkPremium);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.chkRegular);
            this.groupBox1.Location = new System.Drawing.Point(539, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 117);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 408);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.CheckBox chkPremium;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkRegular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

