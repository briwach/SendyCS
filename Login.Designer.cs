namespace SendyApp
{
    partial class Login
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
            this.logGrp = new System.Windows.Forms.GroupBox();
            this.regGrp = new System.Windows.Forms.GroupBox();
            this.sgnBtn = new System.Windows.Forms.Button();
            this.regPwd = new System.Windows.Forms.TextBox();
            this.regUname = new System.Windows.Forms.TextBox();
            this.regEmail = new System.Windows.Forms.TextBox();
            this.regPhone = new System.Windows.Forms.TextBox();
            this.regName = new System.Windows.Forms.TextBox();
            this.regBtn = new System.Windows.Forms.Button();
            this.logBtn = new System.Windows.Forms.Button();
            this.pwdTbox = new System.Windows.Forms.TextBox();
            this.unameTbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.logGrp.SuspendLayout();
            this.regGrp.SuspendLayout();
            this.SuspendLayout();
            // 
            // logGrp
            // 
            this.logGrp.Controls.Add(this.regGrp);
            this.logGrp.Controls.Add(this.regBtn);
            this.logGrp.Controls.Add(this.logBtn);
            this.logGrp.Controls.Add(this.pwdTbox);
            this.logGrp.Controls.Add(this.unameTbox);
            this.logGrp.Controls.Add(this.label3);
            this.logGrp.Controls.Add(this.label2);
            this.logGrp.Controls.Add(this.label1);
            this.logGrp.Location = new System.Drawing.Point(28, 13);
            this.logGrp.Name = "logGrp";
            this.logGrp.Size = new System.Drawing.Size(225, 210);
            this.logGrp.TabIndex = 0;
            this.logGrp.TabStop = false;
            // 
            // regGrp
            // 
            this.regGrp.Controls.Add(this.sgnBtn);
            this.regGrp.Controls.Add(this.regPwd);
            this.regGrp.Controls.Add(this.regUname);
            this.regGrp.Controls.Add(this.regEmail);
            this.regGrp.Controls.Add(this.regPhone);
            this.regGrp.Controls.Add(this.regName);
            this.regGrp.Location = new System.Drawing.Point(0, 0);
            this.regGrp.Name = "regGrp";
            this.regGrp.Size = new System.Drawing.Size(225, 210);
            this.regGrp.TabIndex = 7;
            this.regGrp.TabStop = false;
            this.regGrp.Enter += new System.EventHandler(this.regGrp_Enter);
            // 
            // sgnBtn
            // 
            this.sgnBtn.Location = new System.Drawing.Point(7, 172);
            this.sgnBtn.Name = "sgnBtn";
            this.sgnBtn.Size = new System.Drawing.Size(212, 23);
            this.sgnBtn.TabIndex = 10;
            this.sgnBtn.Text = "Register";
            this.sgnBtn.UseVisualStyleBackColor = true;
            this.sgnBtn.Click += new System.EventHandler(this.sgnBtn_Click);
            // 
            // regPwd
            // 
            this.regPwd.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.regPwd.Location = new System.Drawing.Point(6, 127);
            this.regPwd.Name = "regPwd";
            this.regPwd.PasswordChar = '*';
            this.regPwd.Size = new System.Drawing.Size(213, 20);
            this.regPwd.TabIndex = 9;
            this.regPwd.Text = "Password";
            // 
            // regUname
            // 
            this.regUname.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.regUname.Location = new System.Drawing.Point(6, 101);
            this.regUname.Name = "regUname";
            this.regUname.Size = new System.Drawing.Size(213, 20);
            this.regUname.TabIndex = 8;
            this.regUname.Text = "Preferred Username";
            // 
            // regEmail
            // 
            this.regEmail.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.regEmail.Location = new System.Drawing.Point(6, 75);
            this.regEmail.Name = "regEmail";
            this.regEmail.Size = new System.Drawing.Size(213, 20);
            this.regEmail.TabIndex = 7;
            this.regEmail.Text = "Email";
            // 
            // regPhone
            // 
            this.regPhone.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.regPhone.Location = new System.Drawing.Point(6, 49);
            this.regPhone.Name = "regPhone";
            this.regPhone.Size = new System.Drawing.Size(213, 20);
            this.regPhone.TabIndex = 4;
            this.regPhone.Text = "Phone Number";
            // 
            // regName
            // 
            this.regName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.regName.Location = new System.Drawing.Point(6, 23);
            this.regName.Name = "regName";
            this.regName.Size = new System.Drawing.Size(213, 20);
            this.regName.TabIndex = 3;
            this.regName.Text = "Name";
            // 
            // regBtn
            // 
            this.regBtn.FlatAppearance.BorderSize = 0;
            this.regBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.regBtn.Location = new System.Drawing.Point(136, 177);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(55, 23);
            this.regBtn.TabIndex = 6;
            this.regBtn.Text = "Register";
            this.regBtn.UseVisualStyleBackColor = true;
            this.regBtn.Click += new System.EventHandler(this.regBtn_Click);
            // 
            // logBtn
            // 
            this.logBtn.Location = new System.Drawing.Point(6, 143);
            this.logBtn.Name = "logBtn";
            this.logBtn.Size = new System.Drawing.Size(213, 23);
            this.logBtn.TabIndex = 5;
            this.logBtn.Text = "Log In";
            this.logBtn.UseVisualStyleBackColor = true;
            this.logBtn.Click += new System.EventHandler(this.logBtn_Click);
            // 
            // pwdTbox
            // 
            this.pwdTbox.Location = new System.Drawing.Point(6, 105);
            this.pwdTbox.Name = "pwdTbox";
            this.pwdTbox.PasswordChar = '*';
            this.pwdTbox.Size = new System.Drawing.Size(213, 20);
            this.pwdTbox.TabIndex = 4;
            // 
            // unameTbox
            // 
            this.unameTbox.Location = new System.Drawing.Point(6, 46);
            this.unameTbox.Name = "unameTbox";
            this.unameTbox.Size = new System.Drawing.Size(213, 20);
            this.unameTbox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Don\'t have an account?";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.logGrp);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.logGrp.ResumeLayout(false);
            this.logGrp.PerformLayout();
            this.regGrp.ResumeLayout(false);
            this.regGrp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox logGrp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button regBtn;
        private System.Windows.Forms.TextBox unameTbox;
        private System.Windows.Forms.TextBox pwdTbox;
        private System.Windows.Forms.Button logBtn;
        private System.Windows.Forms.GroupBox regGrp;
        private System.Windows.Forms.Button sgnBtn;
        private System.Windows.Forms.TextBox regPwd;
        private System.Windows.Forms.TextBox regUname;
        private System.Windows.Forms.TextBox regEmail;
        private System.Windows.Forms.TextBox regPhone;
        private System.Windows.Forms.TextBox regName;
    }
}

