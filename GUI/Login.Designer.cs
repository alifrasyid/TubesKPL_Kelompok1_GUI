namespace GUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.NamaAplikasi = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.IsiUsename = new System.Windows.Forms.TextBox();
            this.IsiPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.NamaAplikasi);
            this.panel1.Location = new System.Drawing.Point(-3, -4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1165, 59);
            this.panel1.TabIndex = 0;
            // 
            // NamaAplikasi
            // 
            this.NamaAplikasi.AutoSize = true;
            this.NamaAplikasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaAplikasi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.NamaAplikasi.Location = new System.Drawing.Point(19, 15);
            this.NamaAplikasi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NamaAplikasi.Name = "NamaAplikasi";
            this.NamaAplikasi.Size = new System.Drawing.Size(293, 39);
            this.NamaAplikasi.TabIndex = 0;
            this.NamaAplikasi.Text = "Sistem Toko Buku";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelLogin.Location = new System.Drawing.Point(468, 105);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(176, 69);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "Login";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(397, 217);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(86, 20);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(397, 319);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(83, 20);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password";
            // 
            // IsiUsename
            // 
            this.IsiUsename.Location = new System.Drawing.Point(401, 241);
            this.IsiUsename.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IsiUsename.Multiline = true;
            this.IsiUsename.Name = "IsiUsename";
            this.IsiUsename.Size = new System.Drawing.Size(300, 30);
            this.IsiUsename.TabIndex = 4;
            this.IsiUsename.TextChanged += new System.EventHandler(this.IsiUsename_TextChanged);
            // 
            // IsiPassword
            // 
            this.IsiPassword.Location = new System.Drawing.Point(401, 343);
            this.IsiPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IsiPassword.Multiline = true;
            this.IsiPassword.Name = "IsiPassword";
            this.IsiPassword.Size = new System.Drawing.Size(300, 30);
            this.IsiPassword.TabIndex = 5;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(493, 441);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(121, 36);
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1159, 640);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.IsiPassword);
            this.Controls.Add(this.IsiUsename);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label NamaAplikasi;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox IsiUsename;
        private System.Windows.Forms.TextBox IsiPassword;
        private System.Windows.Forms.Button buttonLogin;
    }
}

