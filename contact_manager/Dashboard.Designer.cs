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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.TxtSearchEmployee = new System.Windows.Forms.TextBox();
            this.CmdDeleteEmployee = new System.Windows.Forms.Button();
            this.CmdInfoEmployee = new System.Windows.Forms.Button();
            this.CmdCreateEmployee = new System.Windows.Forms.Button();
            this.DataGridEmployee = new System.Windows.Forms.DataGridView();
            this.CmbFilterEmployee = new System.Windows.Forms.ComboBox();
            this.CmdSaveExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtSearchEmployee
            // 
            this.TxtSearchEmployee.Location = new System.Drawing.Point(291, 24);
            this.TxtSearchEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtSearchEmployee.Name = "TxtSearchEmployee";
            this.TxtSearchEmployee.Size = new System.Drawing.Size(140, 20);
            this.TxtSearchEmployee.TabIndex = 0;
            this.TxtSearchEmployee.TextChanged += new System.EventHandler(this.TxtSearchEmployee_TextChanged);
            // 
            // CmdDeleteEmployee
            // 
            this.CmdDeleteEmployee.Location = new System.Drawing.Point(826, 24);
            this.CmdDeleteEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmdDeleteEmployee.Name = "CmdDeleteEmployee";
            this.CmdDeleteEmployee.Size = new System.Drawing.Size(113, 24);
            this.CmdDeleteEmployee.TabIndex = 3;
            this.CmdDeleteEmployee.Text = "Person löschen";
            this.CmdDeleteEmployee.UseVisualStyleBackColor = true;
            this.CmdDeleteEmployee.Click += new System.EventHandler(this.CmdDeleteEmployee_Click);
            // 
            // CmdInfoEmployee
            // 
            this.CmdInfoEmployee.Location = new System.Drawing.Point(943, 24);
            this.CmdInfoEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmdInfoEmployee.Name = "CmdInfoEmployee";
            this.CmdInfoEmployee.Size = new System.Drawing.Size(119, 24);
            this.CmdInfoEmployee.TabIndex = 4;
            this.CmdInfoEmployee.Text = "Bearbeiten/Info";
            this.CmdInfoEmployee.UseVisualStyleBackColor = true;
            this.CmdInfoEmployee.Click += new System.EventHandler(this.CmdInfoEmployee_Click);
            // 
            // CmdCreateEmployee
            // 
            this.CmdCreateEmployee.Location = new System.Drawing.Point(1066, 24);
            this.CmdCreateEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmdCreateEmployee.Name = "CmdCreateEmployee";
            this.CmdCreateEmployee.Size = new System.Drawing.Size(109, 24);
            this.CmdCreateEmployee.TabIndex = 5;
            this.CmdCreateEmployee.Text = "Neue Person";
            this.CmdCreateEmployee.UseVisualStyleBackColor = true;
            this.CmdCreateEmployee.Click += new System.EventHandler(this.CmdCreateEmployee_Click);
            // 
            // DataGridEmployee
            // 
            this.DataGridEmployee.AllowUserToAddRows = false;
            this.DataGridEmployee.AllowUserToDeleteRows = false;
            this.DataGridEmployee.AllowUserToOrderColumns = true;
            this.DataGridEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridEmployee.Location = new System.Drawing.Point(8, 72);
            this.DataGridEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DataGridEmployee.Name = "DataGridEmployee";
            this.DataGridEmployee.ReadOnly = true;
            this.DataGridEmployee.RowHeadersWidth = 62;
            this.DataGridEmployee.RowTemplate.Height = 28;
            this.DataGridEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridEmployee.Size = new System.Drawing.Size(1167, 361);
            this.DataGridEmployee.TabIndex = 6;
            // 
            // CmbFilterEmployee
            // 
            this.CmbFilterEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFilterEmployee.FormattingEnabled = true;
            this.CmbFilterEmployee.Items.AddRange(new object[] {
            "Alle",
            "Mitarbeiter",
            "Kunde",
            "Lernender"});
            this.CmbFilterEmployee.Location = new System.Drawing.Point(531, 24);
            this.CmbFilterEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmbFilterEmployee.Name = "CmbFilterEmployee";
            this.CmbFilterEmployee.Size = new System.Drawing.Size(114, 21);
            this.CmbFilterEmployee.TabIndex = 8;
            this.CmbFilterEmployee.SelectedIndexChanged += new System.EventHandler(this.CmbFilterEmployee_SelectedIndexChanged);
            // 
            // CmdSaveExit
            // 
            this.CmdSaveExit.Location = new System.Drawing.Point(1046, 445);
            this.CmdSaveExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmdSaveExit.Name = "CmdSaveExit";
            this.CmdSaveExit.Size = new System.Drawing.Size(129, 31);
            this.CmdSaveExit.TabIndex = 17;
            this.CmdSaveExit.Text = "Beenden";
            this.CmdSaveExit.UseVisualStyleBackColor = true;
            this.CmdSaveExit.Click += new System.EventHandler(this.CmdSaveExit_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(9, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(155, 59);
            this.panel2.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(495, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Filter:";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 487);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CmdSaveExit);
            this.Controls.Add(this.CmbFilterEmployee);
            this.Controls.Add(this.DataGridEmployee);
            this.Controls.Add(this.CmdCreateEmployee);
            this.Controls.Add(this.CmdInfoEmployee);
            this.Controls.Add(this.CmdDeleteEmployee);
            this.Controls.Add(this.TxtSearchEmployee);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox TxtSearchEmployee;
        public System.Windows.Forms.Button CmdDeleteEmployee;
        public System.Windows.Forms.Button CmdInfoEmployee;
        public System.Windows.Forms.Button CmdCreateEmployee;
        public System.Windows.Forms.DataGridView DataGridEmployee;
        public System.Windows.Forms.ComboBox CmbFilterEmployee;
        public System.Windows.Forms.Button CmdSaveExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}