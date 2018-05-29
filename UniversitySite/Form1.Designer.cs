namespace UniversitySite
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.labelAuthorization = new System.Windows.Forms.Label();
            this.TextLogin = new System.Windows.Forms.TextBox();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextPassword = new System.Windows.Forms.TextBox();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.BackColor = System.Drawing.Color.PowderBlue;
            this.ButtonLogin.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLogin.Location = new System.Drawing.Point(184, 301);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(244, 41);
            this.ButtonLogin.TabIndex = 0;
            this.ButtonLogin.Text = "Sign in";
            this.ButtonLogin.UseVisualStyleBackColor = false;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // labelAuthorization
            // 
            this.labelAuthorization.AllowDrop = true;
            this.labelAuthorization.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAuthorization.AutoEllipsis = true;
            this.labelAuthorization.AutoSize = true;
            this.labelAuthorization.BackColor = System.Drawing.Color.White;
            this.labelAuthorization.Font = new System.Drawing.Font("Baskerville Old Face", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuthorization.Location = new System.Drawing.Point(176, 39);
            this.labelAuthorization.MaximumSize = new System.Drawing.Size(1000, 100);
            this.labelAuthorization.Name = "labelAuthorization";
            this.labelAuthorization.Size = new System.Drawing.Size(252, 45);
            this.labelAuthorization.TabIndex = 1;
            this.labelAuthorization.Text = "Authorization";
            // 
            // TextLogin
            // 
            this.TextLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextLogin.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextLogin.Location = new System.Drawing.Point(40, 138);
            this.TextLogin.Name = "TextLogin";
            this.TextLogin.Size = new System.Drawing.Size(531, 30);
            this.TextLogin.TabIndex = 2;
            this.TextLogin.TextChanged += new System.EventHandler(this.TextLogin_TextChanged);
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.TextPassword);
            this.panelLogin.Controls.Add(this.ButtonLogin);
            this.panelLogin.Controls.Add(this.TextLogin);
            this.panelLogin.Controls.Add(this.labelAuthorization);
            this.panelLogin.Location = new System.Drawing.Point(119, 37);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(608, 376);
            this.panelLogin.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(35, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(35, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login";
            // 
            // TextPassword
            // 
            this.TextPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextPassword.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPassword.Location = new System.Drawing.Point(40, 224);
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.Size = new System.Drawing.Size(531, 30);
            this.TextPassword.TabIndex = 3;
            this.TextPassword.UseSystemPasswordChar = true;
            this.TextPassword.TextChanged += new System.EventHandler(this.TextPassword_TextChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(878, 475);
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.Label labelAuthorization;
        private System.Windows.Forms.TextBox TextLogin;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.TextBox TextPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

