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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtInstanceID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CmdSaveExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEmployee)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtSearchEmployee
            // 
            this.TxtSearchEmployee.Location = new System.Drawing.Point(194, 15);
            this.TxtSearchEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.TxtSearchEmployee.Name = "TxtSearchEmployee";
            this.TxtSearchEmployee.Size = new System.Drawing.Size(278, 20);
            this.TxtSearchEmployee.TabIndex = 0;
            this.TxtSearchEmployee.TextChanged += new System.EventHandler(this.TxtSearchEmployee_TextChanged);
            // 
            // CmdDeleteEmployee
            // 
            this.CmdDeleteEmployee.Location = new System.Drawing.Point(12, 161);
            this.CmdDeleteEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.CmdDeleteEmployee.Name = "CmdDeleteEmployee";
            this.CmdDeleteEmployee.Size = new System.Drawing.Size(155, 32);
            this.CmdDeleteEmployee.TabIndex = 3;
            this.CmdDeleteEmployee.Text = "Person löschen";
            this.CmdDeleteEmployee.UseVisualStyleBackColor = true;
            this.CmdDeleteEmployee.Click += new System.EventHandler(this.CmdDeleteEmployee_Click);
            // 
            // CmdInfoEmployee
            // 
            this.CmdInfoEmployee.Location = new System.Drawing.Point(12, 125);
            this.CmdInfoEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.CmdInfoEmployee.Name = "CmdInfoEmployee";
            this.CmdInfoEmployee.Size = new System.Drawing.Size(155, 32);
            this.CmdInfoEmployee.TabIndex = 4;
            this.CmdInfoEmployee.Text = "Bearbeiten/Info";
            this.CmdInfoEmployee.UseVisualStyleBackColor = true;
            this.CmdInfoEmployee.Click += new System.EventHandler(this.CmdInfoEmployee_Click);
            // 
            // CmdCreateEmployee
            // 
            this.CmdCreateEmployee.Location = new System.Drawing.Point(12, 89);
            this.CmdCreateEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.CmdCreateEmployee.Name = "CmdCreateEmployee";
            this.CmdCreateEmployee.Size = new System.Drawing.Size(155, 32);
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
            this.DataGridEmployee.Location = new System.Drawing.Point(186, 60);
            this.DataGridEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridEmployee.Name = "DataGridEmployee";
            this.DataGridEmployee.ReadOnly = true;
            this.DataGridEmployee.RowHeadersWidth = 62;
            this.DataGridEmployee.RowTemplate.Height = 28;
            this.DataGridEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridEmployee.Size = new System.Drawing.Size(986, 416);
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
            this.CmbFilterEmployee.Location = new System.Drawing.Point(76, 15);
            this.CmbFilterEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.CmbFilterEmployee.Name = "CmbFilterEmployee";
            this.CmbFilterEmployee.Size = new System.Drawing.Size(114, 21);
            this.CmbFilterEmployee.TabIndex = 8;
            this.CmbFilterEmployee.SelectedIndexChanged += new System.EventHandler(this.CmbFilterEmployee_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Filter:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.TxtInstanceID);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.CmdSaveExit);
            this.panel1.Controls.Add(this.CmdDeleteEmployee);
            this.panel1.Controls.Add(this.CmdInfoEmployee);
            this.panel1.Controls.Add(this.CmdCreateEmployee);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 487);
            this.panel1.TabIndex = 20;
            // 
            // TxtInstanceID
            // 
            this.TxtInstanceID.Location = new System.Drawing.Point(13, 595);
            this.TxtInstanceID.Name = "TxtInstanceID";
            this.TxtInstanceID.ReadOnly = true;
            this.TxtInstanceID.Size = new System.Drawing.Size(154, 20);
            this.TxtInstanceID.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(155, 59);
            this.panel2.TabIndex = 0;
            // 
            // CmdSaveExit
            // 
            this.CmdSaveExit.Location = new System.Drawing.Point(12, 445);
            this.CmdSaveExit.Margin = new System.Windows.Forms.Padding(2);
            this.CmdSaveExit.Name = "CmdSaveExit";
            this.CmdSaveExit.Size = new System.Drawing.Size(155, 31);
            this.CmdSaveExit.TabIndex = 17;
            this.CmdSaveExit.Text = "Beenden";
            this.CmdSaveExit.UseVisualStyleBackColor = true;
            this.CmdSaveExit.Click += new System.EventHandler(this.CmdSaveExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtSearchEmployee);
            this.groupBox1.Controls.Add(this.CmbFilterEmployee);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(698, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 43);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Suche";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1183, 487);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DataGridEmployee);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEmployee)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TextBox TxtSearchEmployee;
        public System.Windows.Forms.Button CmdDeleteEmployee;
        public System.Windows.Forms.Button CmdInfoEmployee;
        public System.Windows.Forms.Button CmdCreateEmployee;
        public System.Windows.Forms.DataGridView DataGridEmployee;
        public System.Windows.Forms.ComboBox CmbFilterEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox TxtInstanceID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button CmdSaveExit;
    }
}