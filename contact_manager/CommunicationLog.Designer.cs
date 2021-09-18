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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtInstanceID = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.DgvLogOutput = new System.Windows.Forms.DataGridView();
            this.DtpLog = new System.Windows.Forms.DateTimePicker();
            this.CmdLogSend = new System.Windows.Forms.Button();
            this.TxtLogInput = new System.Windows.Forms.TextBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvInput = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 639);
            this.panel1.TabIndex = 15;
            // 
            // TxtInstanceID
            // 
            this.TxtInstanceID.Location = new System.Drawing.Point(13, 595);
            this.TxtInstanceID.Name = "TxtInstanceID";
            this.TxtInstanceID.ReadOnly = true;
            this.TxtInstanceID.Size = new System.Drawing.Size(154, 20);
            this.TxtInstanceID.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 188);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 33);
            this.button3.TabIndex = 3;
            this.button3.Text = "Neuer Mitarbeiter";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "Neuer Kunde";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Dashboard";
            this.button1.UseVisualStyleBackColor = true;
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
            // DgvLogOutput
            // 
            this.DgvLogOutput.AllowUserToAddRows = false;
            this.DgvLogOutput.AllowUserToOrderColumns = true;
            this.DgvLogOutput.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvLogOutput.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvLogOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLogOutput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.DgvTime,
            this.DgvInput});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvLogOutput.DefaultCellStyle = dataGridViewCellStyle5;
            this.DgvLogOutput.Location = new System.Drawing.Point(187, 0);
            this.DgvLogOutput.Name = "DgvLogOutput";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvLogOutput.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DgvLogOutput.Size = new System.Drawing.Size(966, 497);
            this.DgvLogOutput.TabIndex = 14;
            // 
            // DtpLog
            // 
            this.DtpLog.Location = new System.Drawing.Point(187, 503);
            this.DtpLog.Name = "DtpLog";
            this.DtpLog.Size = new System.Drawing.Size(200, 20);
            this.DtpLog.TabIndex = 13;
            // 
            // CmdLogSend
            // 
            this.CmdLogSend.Location = new System.Drawing.Point(1054, 529);
            this.CmdLogSend.Name = "CmdLogSend";
            this.CmdLogSend.Size = new System.Drawing.Size(99, 95);
            this.CmdLogSend.TabIndex = 12;
            this.CmdLogSend.Text = "Senden";
            this.CmdLogSend.UseVisualStyleBackColor = true;
            this.CmdLogSend.Click += new System.EventHandler(this.CmdLogSend_Click_1);
            // 
            // TxtLogInput
            // 
            this.TxtLogInput.Location = new System.Drawing.Point(187, 529);
            this.TxtLogInput.Multiline = true;
            this.TxtLogInput.Name = "TxtLogInput";
            this.TxtLogInput.Size = new System.Drawing.Size(861, 95);
            this.TxtLogInput.TabIndex = 11;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // DgvTime
            // 
            this.DgvTime.FillWeight = 25F;
            this.DgvTime.HeaderText = "Zeit";
            this.DgvTime.Name = "DgvTime";
            // 
            // DgvInput
            // 
            this.DgvInput.HeaderText = "Input";
            this.DgvInput.Name = "DgvInput";
            // 
            // CommunicationLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 639);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DgvLogOutput);
            this.Controls.Add(this.DtpLog);
            this.Controls.Add(this.CmdLogSend);
            this.Controls.Add(this.TxtLogInput);
            this.Name = "CommunicationLog";
            this.Text = "CommunicationLog";
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