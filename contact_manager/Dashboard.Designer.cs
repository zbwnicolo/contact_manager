namespace contact_manager
{
    partial class Dashboard
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
            this.TxtSearchEmployee = new System.Windows.Forms.TextBox();
            this.CmdSearchEmployee = new System.Windows.Forms.Button();
            this.CmdDeleteEmployee = new System.Windows.Forms.Button();
            this.CmdInfoEmployee = new System.Windows.Forms.Button();
            this.CmdCreateEmployee = new System.Windows.Forms.Button();
            this.DataGridEmployee = new System.Windows.Forms.DataGridView();
            this.DataGridCustomer = new System.Windows.Forms.DataGridView();
            this.CmbFilterEmployee = new System.Windows.Forms.ComboBox();
            this.CmbFilterCustomer = new System.Windows.Forms.ComboBox();
            this.CmdCreateCustomer = new System.Windows.Forms.Button();
            this.CmdInfoCustomer = new System.Windows.Forms.Button();
            this.CmdDeleteCustomer = new System.Windows.Forms.Button();
            this.CmdSearchCustomer = new System.Windows.Forms.Button();
            this.TxtSearchCustomer = new System.Windows.Forms.TextBox();
            this.CmdComCustomer = new System.Windows.Forms.Button();
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdSaveExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtSearchEmployee
            // 
            this.TxtSearchEmployee.Location = new System.Drawing.Point(422, 15);
            this.TxtSearchEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtSearchEmployee.Name = "TxtSearchEmployee";
            this.TxtSearchEmployee.Size = new System.Drawing.Size(140, 20);
            this.TxtSearchEmployee.TabIndex = 0;
            // 
            // CmdSearchEmployee
            // 
            this.CmdSearchEmployee.Location = new System.Drawing.Point(626, 12);
            this.CmdSearchEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmdSearchEmployee.Name = "CmdSearchEmployee";
            this.CmdSearchEmployee.Size = new System.Drawing.Size(50, 24);
            this.CmdSearchEmployee.TabIndex = 1;
            this.CmdSearchEmployee.Text = "Suchen";
            this.CmdSearchEmployee.UseVisualStyleBackColor = true;
            // 
            // CmdDeleteEmployee
            // 
            this.CmdDeleteEmployee.Location = new System.Drawing.Point(831, 8);
            this.CmdDeleteEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmdDeleteEmployee.Name = "CmdDeleteEmployee";
            this.CmdDeleteEmployee.Size = new System.Drawing.Size(113, 24);
            this.CmdDeleteEmployee.TabIndex = 3;
            this.CmdDeleteEmployee.Text = "Mitarbeiter löschen";
            this.CmdDeleteEmployee.UseVisualStyleBackColor = true;
            // 
            // CmdInfoEmployee
            // 
            this.CmdInfoEmployee.Location = new System.Drawing.Point(957, 8);
            this.CmdInfoEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmdInfoEmployee.Name = "CmdInfoEmployee";
            this.CmdInfoEmployee.Size = new System.Drawing.Size(119, 24);
            this.CmdInfoEmployee.TabIndex = 4;
            this.CmdInfoEmployee.Text = "Mitarbeiterinformation";
            this.CmdInfoEmployee.UseVisualStyleBackColor = true;
            this.CmdInfoEmployee.Click += new System.EventHandler(this.CmdInfoEmployee_Click);
            // 
            // CmdCreateEmployee
            // 
            this.CmdCreateEmployee.Location = new System.Drawing.Point(1080, 8);
            this.CmdCreateEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmdCreateEmployee.Name = "CmdCreateEmployee";
            this.CmdCreateEmployee.Size = new System.Drawing.Size(109, 24);
            this.CmdCreateEmployee.TabIndex = 5;
            this.CmdCreateEmployee.Text = "Neuer Mitarbeiter";
            this.CmdCreateEmployee.UseVisualStyleBackColor = true;
            this.CmdCreateEmployee.Click += new System.EventHandler(this.CmdCreateEmployee_Click);
            // 
            // DataGridEmployee
            // 
            this.DataGridEmployee.AllowUserToAddRows = false;
            this.DataGridEmployee.AllowUserToDeleteRows = false;
            this.DataGridEmployee.AllowUserToOrderColumns = true;
            this.DataGridEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridEmployee.Location = new System.Drawing.Point(8, 49);
            this.DataGridEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DataGridEmployee.Name = "DataGridEmployee";
            this.DataGridEmployee.RowHeadersWidth = 62;
            this.DataGridEmployee.RowTemplate.Height = 28;
            this.DataGridEmployee.Size = new System.Drawing.Size(1181, 138);
            this.DataGridEmployee.TabIndex = 6;
            this.DataGridEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridEmployee_CellContentClick);
            // 
            // DataGridCustomer
            // 
            this.DataGridCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridCustomer.Location = new System.Drawing.Point(8, 512);
            this.DataGridCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DataGridCustomer.Name = "DataGridCustomer";
            this.DataGridCustomer.RowHeadersWidth = 62;
            this.DataGridCustomer.RowTemplate.Height = 28;
            this.DataGridCustomer.Size = new System.Drawing.Size(1181, 138);
            this.DataGridCustomer.TabIndex = 7;
            // 
            // CmbFilterEmployee
            // 
            this.CmbFilterEmployee.FormattingEnabled = true;
            this.CmbFilterEmployee.Location = new System.Drawing.Point(713, 12);
            this.CmbFilterEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmbFilterEmployee.Name = "CmbFilterEmployee";
            this.CmbFilterEmployee.Size = new System.Drawing.Size(82, 21);
            this.CmbFilterEmployee.TabIndex = 8;
            // 
            // CmbFilterCustomer
            // 
            this.CmbFilterCustomer.FormattingEnabled = true;
            this.CmbFilterCustomer.Location = new System.Drawing.Point(625, 467);
            this.CmbFilterCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmbFilterCustomer.Name = "CmbFilterCustomer";
            this.CmbFilterCustomer.Size = new System.Drawing.Size(82, 21);
            this.CmbFilterCustomer.TabIndex = 14;
            // 
            // CmdCreateCustomer
            // 
            this.CmdCreateCustomer.Location = new System.Drawing.Point(1067, 464);
            this.CmdCreateCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmdCreateCustomer.Name = "CmdCreateCustomer";
            this.CmdCreateCustomer.Size = new System.Drawing.Size(109, 24);
            this.CmdCreateCustomer.TabIndex = 13;
            this.CmdCreateCustomer.Text = "Neuer Kunde";
            this.CmdCreateCustomer.UseVisualStyleBackColor = true;
            // 
            // CmdInfoCustomer
            // 
            this.CmdInfoCustomer.Location = new System.Drawing.Point(943, 464);
            this.CmdInfoCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmdInfoCustomer.Name = "CmdInfoCustomer";
            this.CmdInfoCustomer.Size = new System.Drawing.Size(119, 24);
            this.CmdInfoCustomer.TabIndex = 12;
            this.CmdInfoCustomer.Text = "Kundeninformation";
            this.CmdInfoCustomer.UseVisualStyleBackColor = true;
            // 
            // CmdDeleteCustomer
            // 
            this.CmdDeleteCustomer.Location = new System.Drawing.Point(827, 464);
            this.CmdDeleteCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmdDeleteCustomer.Name = "CmdDeleteCustomer";
            this.CmdDeleteCustomer.Size = new System.Drawing.Size(113, 24);
            this.CmdDeleteCustomer.TabIndex = 11;
            this.CmdDeleteCustomer.Text = "Kunde löschen";
            this.CmdDeleteCustomer.UseVisualStyleBackColor = true;
            // 
            // CmdSearchCustomer
            // 
            this.CmdSearchCustomer.Location = new System.Drawing.Point(565, 464);
            this.CmdSearchCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmdSearchCustomer.Name = "CmdSearchCustomer";
            this.CmdSearchCustomer.Size = new System.Drawing.Size(50, 24);
            this.CmdSearchCustomer.TabIndex = 10;
            this.CmdSearchCustomer.Text = "Suchen";
            this.CmdSearchCustomer.UseVisualStyleBackColor = true;
            // 
            // TxtSearchCustomer
            // 
            this.TxtSearchCustomer.Location = new System.Drawing.Point(423, 469);
            this.TxtSearchCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtSearchCustomer.Name = "TxtSearchCustomer";
            this.TxtSearchCustomer.Size = new System.Drawing.Size(140, 20);
            this.TxtSearchCustomer.TabIndex = 9;
            // 
            // CmdComCustomer
            // 
            this.CmdComCustomer.Location = new System.Drawing.Point(710, 464);
            this.CmdComCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmdComCustomer.Name = "CmdComCustomer";
            this.CmdComCustomer.Size = new System.Drawing.Size(113, 24);
            this.CmdComCustomer.TabIndex = 15;
            this.CmdComCustomer.Text = "Kommunikation";
            this.CmdComCustomer.UseVisualStyleBackColor = true;
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(957, 683);
            this.CmdSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(69, 31);
            this.CmdSave.TabIndex = 16;
            this.CmdSave.Text = "Speichern";
            this.CmdSave.UseVisualStyleBackColor = true;
            // 
            // CmdSaveExit
            // 
            this.CmdSaveExit.Location = new System.Drawing.Point(1047, 683);
            this.CmdSaveExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmdSaveExit.Name = "CmdSaveExit";
            this.CmdSaveExit.Size = new System.Drawing.Size(129, 31);
            this.CmdSaveExit.TabIndex = 17;
            this.CmdSaveExit.Text = "Speichern und Beenden";
            this.CmdSaveExit.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 768);
            this.Controls.Add(this.CmdSaveExit);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.CmdComCustomer);
            this.Controls.Add(this.CmbFilterCustomer);
            this.Controls.Add(this.CmdCreateCustomer);
            this.Controls.Add(this.CmdInfoCustomer);
            this.Controls.Add(this.CmdDeleteCustomer);
            this.Controls.Add(this.CmdSearchCustomer);
            this.Controls.Add(this.TxtSearchCustomer);
            this.Controls.Add(this.CmbFilterEmployee);
            this.Controls.Add(this.DataGridCustomer);
            this.Controls.Add(this.DataGridEmployee);
            this.Controls.Add(this.CmdCreateEmployee);
            this.Controls.Add(this.CmdInfoEmployee);
            this.Controls.Add(this.CmdDeleteEmployee);
            this.Controls.Add(this.CmdSearchEmployee);
            this.Controls.Add(this.TxtSearchEmployee);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtSearchEmployee;
        private System.Windows.Forms.Button CmdSearchEmployee;
        private System.Windows.Forms.Button CmdDeleteEmployee;
        private System.Windows.Forms.Button CmdInfoEmployee;
        private System.Windows.Forms.Button CmdCreateEmployee;
        private System.Windows.Forms.DataGridView DataGridEmployee;
        private System.Windows.Forms.DataGridView DataGridCustomer;
        private System.Windows.Forms.ComboBox CmbFilterEmployee;
        private System.Windows.Forms.ComboBox CmbFilterCustomer;
        private System.Windows.Forms.Button CmdCreateCustomer;
        private System.Windows.Forms.Button CmdInfoCustomer;
        private System.Windows.Forms.Button CmdDeleteCustomer;
        private System.Windows.Forms.Button CmdSearchCustomer;
        private System.Windows.Forms.TextBox TxtSearchCustomer;
        private System.Windows.Forms.Button CmdComCustomer;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Button CmdSaveExit;
    }
}