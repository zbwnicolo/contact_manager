
namespace contact_manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.TxtLoginUsername = new System.Windows.Forms.TextBox();
            this.TxtLoginPassword = new System.Windows.Forms.TextBox();
            this.CmdLoginLogin = new System.Windows.Forms.Button();
            this.CmdLoginReset = new System.Windows.Forms.Button();
            this.CmdLoginExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // TxtLoginUsername
            // 
            this.TxtLoginUsername.Location = new System.Drawing.Point(238, 103);
            this.TxtLoginUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtLoginUsername.Name = "TxtLoginUsername";
            this.TxtLoginUsername.Size = new System.Drawing.Size(139, 20);
            this.TxtLoginUsername.TabIndex = 0;
            // 
            // TxtLoginPassword
            // 
            this.TxtLoginPassword.Location = new System.Drawing.Point(238, 143);
            this.TxtLoginPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtLoginPassword.Name = "TxtLoginPassword";
            this.TxtLoginPassword.Size = new System.Drawing.Size(139, 20);
            this.TxtLoginPassword.TabIndex = 1;
            // 
            // CmdLoginLogin
            // 
            this.CmdLoginLogin.Location = new System.Drawing.Point(8, 255);
            this.CmdLoginLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmdLoginLogin.Name = "CmdLoginLogin";
            this.CmdLoginLogin.Size = new System.Drawing.Size(103, 30);
            this.CmdLoginLogin.TabIndex = 2;
            this.CmdLoginLogin.Text = "Login";
            this.CmdLoginLogin.UseVisualStyleBackColor = true;
            this.CmdLoginLogin.Click += new System.EventHandler(this.CmdLoginLogin_Click);
            // 
            // CmdLoginReset
            // 
            this.CmdLoginReset.Location = new System.Drawing.Point(204, 255);
            this.CmdLoginReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmdLoginReset.Name = "CmdLoginReset";
            this.CmdLoginReset.Size = new System.Drawing.Size(105, 30);
            this.CmdLoginReset.TabIndex = 3;
            this.CmdLoginReset.Text = "Reset";
            this.CmdLoginReset.UseVisualStyleBackColor = true;
            this.CmdLoginReset.Click += new System.EventHandler(this.CmdLoginReset_Click);
            // 
            // CmdLoginExit
            // 
            this.CmdLoginExit.Location = new System.Drawing.Point(422, 255);
            this.CmdLoginExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmdLoginExit.Name = "CmdLoginExit";
            this.CmdLoginExit.Size = new System.Drawing.Size(103, 30);
            this.CmdLoginExit.TabIndex = 4;
            this.CmdLoginExit.Text = "Exit";
            this.CmdLoginExit.UseVisualStyleBackColor = true;
            this.CmdLoginExit.Click += new System.EventHandler(this.CmdLoginExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Benutzername";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Passwort";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(9, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(155, 59);
            this.panel2.TabIndex = 7;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmdLoginExit);
            this.Controls.Add(this.CmdLoginReset);
            this.Controls.Add(this.CmdLoginLogin);
            this.Controls.Add(this.TxtLoginPassword);
            this.Controls.Add(this.TxtLoginUsername);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtLoginUsername;
        private System.Windows.Forms.TextBox TxtLoginPassword;
        private System.Windows.Forms.Button CmdLoginLogin;
        private System.Windows.Forms.Button CmdLoginReset;
        private System.Windows.Forms.Button CmdLoginExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
    }
}