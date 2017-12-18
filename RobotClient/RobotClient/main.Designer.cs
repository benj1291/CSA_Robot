namespace RobotClient {
    partial class main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.grpConfig = new System.Windows.Forms.GroupBox();
            this.cmdConnect = new System.Windows.Forms.Button();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.txtIpAddress = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusClient = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpBasic = new System.Windows.Forms.GroupBox();
            this.cmdSend = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAngle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.radioStart = new System.Windows.Forms.RadioButton();
            this.radioArcR = new System.Windows.Forms.RadioButton();
            this.radioArcL = new System.Windows.Forms.RadioButton();
            this.radioTurnR = new System.Windows.Forms.RadioButton();
            this.radioTurnL = new System.Windows.Forms.RadioButton();
            this.radioLine = new System.Windows.Forms.RadioButton();
            this.listHistory = new System.Windows.Forms.ListBox();
            this.grpProfessional = new System.Windows.Forms.GroupBox();
            this.cmdSendProf = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grpConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.grpBasic.SuspendLayout();
            this.grpProfessional.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP-Address: Port\r\n";
            // 
            // grpConfig
            // 
            this.grpConfig.Controls.Add(this.cmdConnect);
            this.grpConfig.Controls.Add(this.numPort);
            this.grpConfig.Controls.Add(this.txtIpAddress);
            this.grpConfig.Controls.Add(this.label1);
            this.grpConfig.Location = new System.Drawing.Point(12, 12);
            this.grpConfig.Name = "grpConfig";
            this.grpConfig.Size = new System.Drawing.Size(303, 96);
            this.grpConfig.TabIndex = 0;
            this.grpConfig.TabStop = false;
            this.grpConfig.Text = "Configuration";
            // 
            // cmdConnect
            // 
            this.cmdConnect.Location = new System.Drawing.Point(113, 58);
            this.cmdConnect.Name = "cmdConnect";
            this.cmdConnect.Size = new System.Drawing.Size(75, 23);
            this.cmdConnect.TabIndex = 2;
            this.cmdConnect.Text = "Connect";
            this.cmdConnect.UseVisualStyleBackColor = true;
            this.cmdConnect.Click += new System.EventHandler(this.cmdConnect_Click);
            // 
            // numPort
            // 
            this.numPort.Location = new System.Drawing.Point(228, 23);
            this.numPort.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numPort.Minimum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.numPort.Name = "numPort";
            this.numPort.Size = new System.Drawing.Size(56, 20);
            this.numPort.TabIndex = 1;
            this.numPort.Value = new decimal(new int[] {
            4778,
            0,
            0,
            0});
            // 
            // txtIpAddress
            // 
            this.txtIpAddress.Location = new System.Drawing.Point(113, 23);
            this.txtIpAddress.Name = "txtIpAddress";
            this.txtIpAddress.Size = new System.Drawing.Size(109, 20);
            this.txtIpAddress.TabIndex = 0;
            this.txtIpAddress.Text = "192.168.1.102";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusClient});
            this.statusStrip1.Location = new System.Drawing.Point(0, 548);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(565, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusClient
            // 
            this.statusClient.Name = "statusClient";
            this.statusClient.Size = new System.Drawing.Size(111, 17);
            this.statusClient.Text = "Connection: Closed";
            // 
            // grpBasic
            // 
            this.grpBasic.Controls.Add(this.cmdSend);
            this.grpBasic.Controls.Add(this.label5);
            this.grpBasic.Controls.Add(this.label4);
            this.grpBasic.Controls.Add(this.label3);
            this.grpBasic.Controls.Add(this.txtAngle);
            this.grpBasic.Controls.Add(this.label2);
            this.grpBasic.Controls.Add(this.txtDistance);
            this.grpBasic.Controls.Add(this.radioStart);
            this.grpBasic.Controls.Add(this.radioArcR);
            this.grpBasic.Controls.Add(this.radioArcL);
            this.grpBasic.Controls.Add(this.radioTurnR);
            this.grpBasic.Controls.Add(this.radioTurnL);
            this.grpBasic.Controls.Add(this.radioLine);
            this.grpBasic.Enabled = false;
            this.grpBasic.Location = new System.Drawing.Point(13, 114);
            this.grpBasic.Name = "grpBasic";
            this.grpBasic.Size = new System.Drawing.Size(303, 235);
            this.grpBasic.TabIndex = 1;
            this.grpBasic.TabStop = false;
            this.grpBasic.Text = "Commands";
            // 
            // cmdSend
            // 
            this.cmdSend.Location = new System.Drawing.Point(99, 179);
            this.cmdSend.Name = "cmdSend";
            this.cmdSend.Size = new System.Drawing.Size(105, 41);
            this.cmdSend.TabIndex = 8;
            this.cmdSend.Text = "Send command";
            this.cmdSend.UseVisualStyleBackColor = true;
            this.cmdSend.Click += new System.EventHandler(this.cmdSend_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "°";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "m";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Angle";
            // 
            // txtAngle
            // 
            this.txtAngle.Enabled = false;
            this.txtAngle.Location = new System.Drawing.Point(164, 137);
            this.txtAngle.Name = "txtAngle";
            this.txtAngle.Size = new System.Drawing.Size(100, 20);
            this.txtAngle.TabIndex = 7;
            this.txtAngle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAngle_KeyDown);
            this.txtAngle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAngle_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Distance";
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(28, 137);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(100, 20);
            this.txtDistance.TabIndex = 6;
            this.txtDistance.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDistance_KeyDown);
            this.txtDistance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDistance_KeyPress);
            // 
            // radioStart
            // 
            this.radioStart.AutoSize = true;
            this.radioStart.Location = new System.Drawing.Point(28, 88);
            this.radioStart.Name = "radioStart";
            this.radioStart.Size = new System.Drawing.Size(74, 17);
            this.radioStart.TabIndex = 5;
            this.radioStart.TabStop = true;
            this.radioStart.Text = "Start robot";
            this.radioStart.UseVisualStyleBackColor = true;
            this.radioStart.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // radioArcR
            // 
            this.radioArcR.AutoSize = true;
            this.radioArcR.Location = new System.Drawing.Point(130, 65);
            this.radioArcR.Name = "radioArcR";
            this.radioArcR.Size = new System.Drawing.Size(83, 17);
            this.radioArcR.TabIndex = 4;
            this.radioArcR.TabStop = true;
            this.radioArcR.Text = "TrackArc(R)";
            this.radioArcR.UseVisualStyleBackColor = true;
            this.radioArcR.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // radioArcL
            // 
            this.radioArcL.AutoSize = true;
            this.radioArcL.Location = new System.Drawing.Point(28, 65);
            this.radioArcL.Name = "radioArcL";
            this.radioArcL.Size = new System.Drawing.Size(84, 17);
            this.radioArcL.TabIndex = 3;
            this.radioArcL.TabStop = true;
            this.radioArcL.Text = "TrackArc (L)";
            this.radioArcL.UseVisualStyleBackColor = true;
            this.radioArcL.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // radioTurnR
            // 
            this.radioTurnR.AutoSize = true;
            this.radioTurnR.Location = new System.Drawing.Point(130, 42);
            this.radioTurnR.Name = "radioTurnR";
            this.radioTurnR.Size = new System.Drawing.Size(92, 17);
            this.radioTurnR.TabIndex = 2;
            this.radioTurnR.TabStop = true;
            this.radioTurnR.Text = "TrackTurn (R)";
            this.radioTurnR.UseVisualStyleBackColor = true;
            this.radioTurnR.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // radioTurnL
            // 
            this.radioTurnL.AutoSize = true;
            this.radioTurnL.Location = new System.Drawing.Point(28, 42);
            this.radioTurnL.Name = "radioTurnL";
            this.radioTurnL.Size = new System.Drawing.Size(90, 17);
            this.radioTurnL.TabIndex = 1;
            this.radioTurnL.TabStop = true;
            this.radioTurnL.Text = "TrackTurn (L)";
            this.radioTurnL.UseVisualStyleBackColor = true;
            this.radioTurnL.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // radioLine
            // 
            this.radioLine.AutoSize = true;
            this.radioLine.Checked = true;
            this.radioLine.Location = new System.Drawing.Point(28, 19);
            this.radioLine.Name = "radioLine";
            this.radioLine.Size = new System.Drawing.Size(73, 17);
            this.radioLine.TabIndex = 0;
            this.radioLine.TabStop = true;
            this.radioLine.Text = "TrackLine";
            this.radioLine.UseVisualStyleBackColor = true;
            this.radioLine.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // listHistory
            // 
            this.listHistory.FormattingEnabled = true;
            this.listHistory.Location = new System.Drawing.Point(324, 13);
            this.listHistory.Name = "listHistory";
            this.listHistory.Size = new System.Drawing.Size(232, 524);
            this.listHistory.TabIndex = 3;
            // 
            // grpProfessional
            // 
            this.grpProfessional.Controls.Add(this.cmdSendProf);
            this.grpProfessional.Controls.Add(this.label9);
            this.grpProfessional.Controls.Add(this.label8);
            this.grpProfessional.Controls.Add(this.label7);
            this.grpProfessional.Controls.Add(this.txtCommand);
            this.grpProfessional.Controls.Add(this.label6);
            this.grpProfessional.Enabled = false;
            this.grpProfessional.Location = new System.Drawing.Point(12, 355);
            this.grpProfessional.Name = "grpProfessional";
            this.grpProfessional.Size = new System.Drawing.Size(303, 182);
            this.grpProfessional.TabIndex = 2;
            this.grpProfessional.TabStop = false;
            this.grpProfessional.Text = "Commands (Professional)";
            // 
            // cmdSendProf
            // 
            this.cmdSendProf.Location = new System.Drawing.Point(210, 142);
            this.cmdSendProf.Name = "cmdSendProf";
            this.cmdSendProf.Size = new System.Drawing.Size(75, 20);
            this.cmdSendProf.TabIndex = 1;
            this.cmdSendProf.Text = "Send";
            this.cmdSendProf.UseVisualStyleBackColor = true;
            this.cmdSendProf.Click += new System.EventHandler(this.cmdSendProf_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(224, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Example: TL 10.5 5 -> TrackTurn (L) 10.5° 5m";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(161, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 39);
            this.label8.TabIndex = 3;
            this.label8.Text = "AL: TrackArc (L)\r\nAR: TrackArc (R)\r\nS: Start\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Command";
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(28, 142);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(176, 20);
            this.txtCommand.TabIndex = 0;
            this.txtCommand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCommand_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 39);
            this.label6.TabIndex = 0;
            this.label6.Text = "L: TrackLine\r\nTL: TrackTurn (L)\r\nTR: TrackTurn (R)\r\n";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 570);
            this.Controls.Add(this.grpProfessional);
            this.Controls.Add(this.listHistory);
            this.Controls.Add(this.grpBasic);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grpConfig);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "main";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Robot Controlsystem";
            this.Load += new System.EventHandler(this.main_Load);
            this.grpConfig.ResumeLayout(false);
            this.grpConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grpBasic.ResumeLayout(false);
            this.grpBasic.PerformLayout();
            this.grpProfessional.ResumeLayout(false);
            this.grpProfessional.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpConfig;
        private System.Windows.Forms.Button cmdConnect;
        private System.Windows.Forms.NumericUpDown numPort;
        private System.Windows.Forms.TextBox txtIpAddress;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusClient;
        private System.Windows.Forms.GroupBox grpBasic;
        private System.Windows.Forms.Button cmdSend;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAngle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.RadioButton radioStart;
        private System.Windows.Forms.RadioButton radioArcR;
        private System.Windows.Forms.RadioButton radioArcL;
        private System.Windows.Forms.RadioButton radioTurnR;
        private System.Windows.Forms.RadioButton radioTurnL;
        private System.Windows.Forms.RadioButton radioLine;
        private System.Windows.Forms.ListBox listHistory;
        private System.Windows.Forms.GroupBox grpProfessional;
        private System.Windows.Forms.Button cmdSendProf;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.Label label6;
    }
}