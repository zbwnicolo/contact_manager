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
            this.CmdCreatPersonSave = new System.Windows.Forms.Button();
            this.TxtInstanceID = new System.Windows.Forms.TextBox();
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
            this.panel1.Controls.Add(this.CmdCreatPersonSave);
            this.panel1.Controls.Add(this.TxtInstanceID);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 639);
            this.panel1.TabIndex = 15;
            // 
            // CmdCreatPersonSave
            // 
            this.CmdCreatPersonSave.Location = new System.Drawing.Point(13, 561);
            this.CmdCreatPersonSave.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.CmdCreatPersonSave.Name = "CmdCreatPersonSave";
            this.CmdCreatPersonSave.Size = new System.Drawing.Size(155, 31);
            this.CmdCreatPersonSave.TabIndex = 31;
            this.CmdCreatPersonSave.Text = "Speichern u. Beenden";
            this.CmdCreatPersonSave.UseVisualStyleBackColor = true;
            this.CmdCreatPersonSave.Click += new System.EventHandler(this.CmdCreatPersonSave_Click);
            // 
            // TxtInstanceID
            // 
            this.TxtInstanceID.Location = new System.Drawing.Point(13, 604);
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
            this.DgvLogOutput.Location = new System.Drawing.Point(187, 0);
            this.DgvLogOutput.Name = "DgvLogOutput";
            this.DgvLogOutput.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvLogOutput.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvLogOutput.RowHeadersWidth = 62;
            this.DgvLogOutput.Size = new System.Drawing.Size(966, 497);
            this.DgvLogOutput.TabIndex = 14;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // DgvTime
            // 
            this.DgvTime.FillWeight = 25F;
            this.DgvTime.HeaderText = "Zeit";
            this.DgvTime.MinimumWidth = 8;
            this.DgvTime.Name = "DgvTime";
            this.DgvTime.ReadOnly = true;
            // 
            // DgvInput
            // 
            this.DgvInput.HeaderText = "Input";
            this.DgvInput.MinimumWidth = 8;
            this.DgvInput.Name = "DgvInput";
            this.DgvInput.ReadOnly = true;
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CommunicationLog";
            this.Text = "Kommunikation";
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
        public System.Windows.Forms.Button CmdCreatPersonSave;
    }
}