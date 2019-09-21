namespace WindowsFormsApplication1
{
    partial class form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form));
            this.usernameLB = new System.Windows.Forms.Label();
            this.passwordLb = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.response = new System.Windows.Forms.Label();
            this.showPwd = new System.Windows.Forms.CheckBox();
            this.picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLB
            // 
            this.usernameLB.AutoSize = true;
            this.usernameLB.Location = new System.Drawing.Point(41, 41);
            this.usernameLB.Name = "usernameLB";
            this.usernameLB.Size = new System.Drawing.Size(58, 13);
            this.usernameLB.TabIndex = 0;
            this.usernameLB.Text = "Username:";
            // 
            // passwordLb
            // 
            this.passwordLb.AutoSize = true;
            this.passwordLb.Location = new System.Drawing.Point(43, 86);
            this.passwordLb.Name = "passwordLb";
            this.passwordLb.Size = new System.Drawing.Size(56, 13);
            this.passwordLb.TabIndex = 1;
            this.passwordLb.Text = "Password:";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(105, 38);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(100, 20);
            this.username.TabIndex = 2;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(105, 83);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(100, 20);
            this.password.TabIndex = 3;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // login
            // 
            this.login.Cursor = System.Windows.Forms.Cursors.Default;
            this.login.Enabled = false;
            this.login.Location = new System.Drawing.Point(46, 210);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 4;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(159, 210);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "Clear";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // response
            // 
            this.response.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.response.Location = new System.Drawing.Point(46, 140);
            this.response.Name = "response";
            this.response.Size = new System.Drawing.Size(188, 32);
            this.response.TabIndex = 6;
            this.response.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // showPwd
            // 
            this.showPwd.AutoSize = true;
            this.showPwd.Location = new System.Drawing.Point(106, 109);
            this.showPwd.Name = "showPwd";
            this.showPwd.Size = new System.Drawing.Size(99, 17);
            this.showPwd.TabIndex = 7;
            this.showPwd.Text = "show password";
            this.showPwd.UseVisualStyleBackColor = true;
            this.showPwd.CheckedChanged += new System.EventHandler(this.showPwd_CheckedChanged);
            // 
            // picture
            // 
            this.picture.InitialImage = null;
            this.picture.Location = new System.Drawing.Point(119, 175);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(43, 29);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 8;
            this.picture.TabStop = false;
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.showPwd);
            this.Controls.Add(this.response);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.login);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.passwordLb);
            this.Controls.Add(this.usernameLB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PASSWORD";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLB;
        private System.Windows.Forms.Label passwordLb;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label response;
        private System.Windows.Forms.CheckBox showPwd;
        private System.Windows.Forms.PictureBox picture;
    }
}

