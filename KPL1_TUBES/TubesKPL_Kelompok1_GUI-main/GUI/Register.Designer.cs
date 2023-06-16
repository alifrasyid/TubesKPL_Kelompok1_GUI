namespace GUI
{
    partial class Register
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.IsiPassword = new System.Windows.Forms.TextBox();
            this.IsiUsename = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelRegister = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.NamaAplikasi);
            this.panel1.Location = new System.Drawing.Point(-2, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 48);
            this.panel1.TabIndex = 1;
            // 
            // NamaAplikasi
            // 
            this.NamaAplikasi.AutoSize = true;
            this.NamaAplikasi.Font = new System.Drawing.Font("Forte", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaAplikasi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.NamaAplikasi.Location = new System.Drawing.Point(14, 12);
            this.NamaAplikasi.Name = "NamaAplikasi";
            this.NamaAplikasi.Size = new System.Drawing.Size(219, 30);
            this.NamaAplikasi.TabIndex = 0;
            this.NamaAplikasi.Text = "Sistem Toko Buku";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Franklin Gothic Demi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(368, 362);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(91, 29);
            this.buttonLogin.TabIndex = 12;
            this.buttonLogin.Text = "Sign Up";
            this.buttonLogin.UseVisualStyleBackColor = true;
            // 
            // IsiPassword
            // 
            this.IsiPassword.Location = new System.Drawing.Point(299, 283);
            this.IsiPassword.Multiline = true;
            this.IsiPassword.Name = "IsiPassword";
            this.IsiPassword.Size = new System.Drawing.Size(226, 25);
            this.IsiPassword.TabIndex = 11;
            // 
            // IsiUsename
            // 
            this.IsiUsename.Location = new System.Drawing.Point(299, 200);
            this.IsiUsename.Multiline = true;
            this.IsiUsename.Name = "IsiUsename";
            this.IsiUsename.Size = new System.Drawing.Size(226, 25);
            this.IsiUsename.TabIndex = 10;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(296, 263);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(63, 17);
            this.labelPassword.TabIndex = 9;
            this.labelPassword.Text = "Password";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(296, 180);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(66, 17);
            this.labelUsername.TabIndex = 8;
            this.labelUsername.Text = "Username";
            // 
            // labelRegister
            // 
            this.labelRegister.AutoSize = true;
            this.labelRegister.Font = new System.Drawing.Font("Forte", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegister.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelRegister.Location = new System.Drawing.Point(323, 92);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(177, 52);
            this.labelRegister.TabIndex = 7;
            this.labelRegister.Text = "Sign Up";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(869, 520);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.IsiPassword);
            this.Controls.Add(this.IsiUsename);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelRegister);
            this.Controls.Add(this.panel1);
            this.Name = "Register";
            this.Text = "Register";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label NamaAplikasi;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox IsiPassword;
        private System.Windows.Forms.TextBox IsiUsename;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelRegister;
    }
}