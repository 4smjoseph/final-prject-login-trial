namespace final_prject_login_trial
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.login_username = new System.Windows.Forms.TextBox();
            this.login_password = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.create_account_button = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label3 = new System.Windows.Forms.Label();
            this.code = new System.Windows.Forms.Label();
            this.input_code = new System.Windows.Forms.TextBox();
            this.code_visible = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PaleGreen;
            this.label1.Location = new System.Drawing.Point(252, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.PaleGreen;
            this.label2.Location = new System.Drawing.Point(252, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // login_username
            // 
            this.login_username.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.login_username.Location = new System.Drawing.Point(372, 132);
            this.login_username.Name = "login_username";
            this.login_username.Size = new System.Drawing.Size(171, 30);
            this.login_username.TabIndex = 2;
            // 
            // login_password
            // 
            this.login_password.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.login_password.Location = new System.Drawing.Point(372, 197);
            this.login_password.Name = "login_password";
            this.login_password.Size = new System.Drawing.Size(171, 30);
            this.login_password.TabIndex = 3;
            // 
            // login_button
            // 
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.ForeColor = System.Drawing.Color.PaleGreen;
            this.login_button.Location = new System.Drawing.Point(250, 312);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(75, 42);
            this.login_button.TabIndex = 4;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // create_account_button
            // 
            this.create_account_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_account_button.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_account_button.ForeColor = System.Drawing.Color.PaleGreen;
            this.create_account_button.Location = new System.Drawing.Point(372, 312);
            this.create_account_button.Name = "create_account_button";
            this.create_account_button.Size = new System.Drawing.Size(171, 42);
            this.create_account_button.TabIndex = 5;
            this.create_account_button.Text = "Create Account";
            this.create_account_button.UseVisualStyleBackColor = true;
            this.create_account_button.Click += new System.EventHandler(this.create_account_button_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.PaleGreen;
            this.label3.Location = new System.Drawing.Point(104, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Verification Code";
            // 
            // code
            // 
            this.code.AutoSize = true;
            this.code.Location = new System.Drawing.Point(394, 336);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(0, 21);
            this.code.TabIndex = 7;
            // 
            // input_code
            // 
            this.input_code.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.input_code.Location = new System.Drawing.Point(372, 259);
            this.input_code.Name = "input_code";
            this.input_code.Size = new System.Drawing.Size(171, 30);
            this.input_code.TabIndex = 8;
            // 
            // code_visible
            // 
            this.code_visible.AutoSize = true;
            this.code_visible.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.code_visible.ForeColor = System.Drawing.Color.PaleGreen;
            this.code_visible.Location = new System.Drawing.Point(269, 262);
            this.code_visible.Name = "code_visible";
            this.code_visible.Size = new System.Drawing.Size(58, 22);
            this.code_visible.TabIndex = 10;
            this.code_visible.Text = "code";
            // 
            // logo
            // 
            this.logo.AutoSize = true;
            this.logo.Font = new System.Drawing.Font("Lucida Calligraphy", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo.ForeColor = System.Drawing.Color.PaleGreen;
            this.logo.Location = new System.Drawing.Point(324, 47);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(103, 36);
            this.logo.TabIndex = 11;
            this.logo.Text = "LOGO";
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.code_visible);
            this.Controls.Add(this.input_code);
            this.Controls.Add(this.code);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.create_account_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.login_password);
            this.Controls.Add(this.login_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox login_username;
        private System.Windows.Forms.TextBox login_password;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button create_account_button;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label code;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox input_code;
        private System.Windows.Forms.Label code_visible;
        private System.Windows.Forms.Label logo;
    }
}

