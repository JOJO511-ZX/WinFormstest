namespace WinFormstest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnstart = new Button();
            lblStatus = new Label();
            dgvData = new DataGridView();
            lblAlarm = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // btnstart
            // 
            btnstart.Location = new Point(688, 105);
            btnstart.Name = "btnstart";
            btnstart.Size = new Size(149, 63);
            btnstart.TabIndex = 0;
            btnstart.Text = "开始采集\r\n";
            btnstart.UseVisualStyleBackColor = true;
            btnstart.Click += Btnstart_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(368, 498);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(94, 24);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "等待操作...";
            lblStatus.Click += LblStatus_Click;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(177, 105);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 62;
            dgvData.Size = new Size(491, 365);
            dgvData.TabIndex = 2;
            // 
            // lblAlarm
            // 
            lblAlarm.AutoSize = true;
            lblAlarm.Location = new Point(368, 54);
            lblAlarm.Name = "lblAlarm";
            lblAlarm.Size = new Size(82, 24);
            lblAlarm.TabIndex = 3;
            lblAlarm.Text = "设备正常";
            lblAlarm.Click += LalAlarm_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 578);
            Controls.Add(lblAlarm);
            Controls.Add(dgvData);
            Controls.Add(lblStatus);
            Controls.Add(btnstart);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnstart;
        private Label lblStatus;
        private DataGridView dgvData;
        private Label lblAlarm;
    }
}
