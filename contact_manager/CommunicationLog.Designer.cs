namespace contact_manager
{
    partial class CommunicationLog
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommunicationLog));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtInstanceID = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.DgvLogOutput = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvInput = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtpLog = new System.Windows.Forms.DateTimePicker();
            this.CmdLogSend = new System.Windows.Forms.Button();
            this.TxtLogInput = new System.Windows.Forms.TextBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLogOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.TxtInstanceID);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 983);
            this.panel1.TabIndex = 15;
            // 
            // TxtInstanceID
            // 
            this.TxtInstanceID.Location = new System.Drawing.Point(20, 915);
            this.TxtInstanceID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtInstanceID.Name = "TxtInstanceID";
            this.TxtInstanceID.ReadOnly = true;
            this.TxtInstanceID.Size = new System.Drawing.Size(229, 26);
            this.TxtInstanceID.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(20, 289);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(231, 51);
            this.button3.TabIndex = 3;
            this.button3.Text = "Neuer Mitarbeiter";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 229);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(231, 51);
            this.button2.TabIndex = 2;
            this.button2.Text = "Neuer Kunde";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 169);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Dashboard";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(18, 18);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 91);
            this.panel2.TabIndex = 0;
            // 
            // DgvLogOutput
            // 
            this.DgvLogOutput.AllowUserToAddRows = false;
            this.DgvLogOutput.AllowUserToOrderColumns = true;
            this.DgvLogOutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvLogOutput.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvLogOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLogOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DgvTime,
            this.DgvInput});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvLogOutput.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvLogOutput.Location = new System.Drawing.Point(280, 0);
            this.DgvLogOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvLogOutput.Name = "DgvLogOutput";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvLogOutput.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvLogOutput.RowHeadersWidth = 62;
            this.DgvLogOutput.Size = new System.Drawing.Size(1449, 765);
            this.DgvLogOutput.TabIndex = 14;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // DgvTime
            // 
            this.DgvTime.FillWeight = 25F;
            this.DgvTime.HeaderText = "Zeit";
            this.DgvTime.MinimumWidth = 8;
            this.DgvTime.Name = "DgvTime";
            // 
            // DgvInput
            // 
            this.DgvInput.HeaderText = "Input";
            this.DgvInput.MinimumWidth = 8;
            this.DgvInput.Name = "DgvInput";
            // 
            // DtpLog
            // 
            this.DtpLog.Location = new System.Drawing.Point(280, 774);
            this.DtpLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DtpLog.Name = "DtpLog";
            this.DtpLog.Size = new System.Drawing.Size(298, 26);
            this.DtpLog.TabIndex = 13;
            // 
            // CmdLogSend
            // 
            this.CmdLogSend.Location = new System.Drawing.Point(1581, 814);
            this.CmdLogSend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmdLogSend.Name = "CmdLogSend";
            this.CmdLogSend.Size = new System.Drawing.Size(148, 146);
            this.CmdLogSend.TabIndex = 12;
            this.CmdLogSend.Text = "Senden";
            this.CmdLogSend.UseVisualStyleBackColor = true;
            this.CmdLogSend.Click += new System.EventHandler(this.CmdLogSend_Click_1);
            // 
            // TxtLogInput
            // 
            this.TxtLogInput.Location = new System.Drawing.Point(280, 814);
            this.TxtLogInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtLogInput.Multiline = true;
            this.TxtLogInput.Name = "TxtLogInput";
            this.TxtLogInput.Size = new System.Drawing.Size(1290, 144);
            this.TxtLogInput.TabIndex = 11;
            // 
            // CommunicationLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1749, 983);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DgvLogOutput);
            this.Controls.Add(this.DtpLog);
            this.Controls.Add(this.CmdLogSend);
            this.Controls.Add(this.TxtLogInput);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CommunicationLog";
            this.Text = "CommunicationLog";
            this.Load += new System.EventHandler(this.CommunicationLog_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLogOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button CmdLogSend;
        private System.Windows.Forms.Timer timer3;
        public System.Windows.Forms.DataGridView DgvLogOutput;
        public System.Windows.Forms.TextBox TxtInstanceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DgvInput;
        public System.Windows.Forms.DateTimePicker DtpLog;
        public System.Windows.Forms.TextBox TxtLogInput;
    }
}