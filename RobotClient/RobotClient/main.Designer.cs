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
            this.label1.Location = new System.Drawing.Point(22, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP-Address: Port\r\n";
            // 
            // grpConfig
            // 
            this.grpConfig.Controls.Add(this.cmdConnect);
            this.grpConfig.Controls.Add(this.numPort);
            this.grpConfig.Controls.Add(this.txtIpAddress);
            this.grpConfig.Controls.Add(this.label1);
            this.grpConfig.Location = new System.Drawing.Point(18, 18);
            this.grpConfig.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpConfig.Name = "grpConfig";
            this.grpConfig.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpConfig.Size = new System.Drawing.Size(454, 148);
            this.grpConfig.TabIndex = 0;
            this.grpConfig.TabStop = false;
            this.grpConfig.Text = "Configuration";
            // 
            // cmdConnect
            // 
            this.cmdConnect.Location = new System.Drawing.Point(170, 89);
            this.cmdConnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdConnect.Name = "cmdConnect";
            this.cmdConnect.Size = new System.Drawing.Size(112, 35);
            this.cmdConnect.TabIndex = 2;
            this.cmdConnect.Text = "Connect";
            this.cmdConnect.UseVisualStyleBackColor = true;
            this.cmdConnect.Click += new System.EventHandler(this.cmdConnect_Click);
            // 
            // numPort
            // 
            this.numPort.Location = new System.Drawing.Point(342, 35);
            this.numPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.numPort.Size = new System.Drawing.Size(84, 26);
            this.numPort.TabIndex = 1;
            this.numPort.Value = new decimal(new int[] {
            4778,
            0,
            0,
            0});
            // 
            // txtIpAddress
            // 
            this.txtIpAddress.Location = new System.Drawing.Point(170, 35);
            this.txtIpAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIpAddress.Name = "txtIpAddress";
            this.txtIpAddress.Size = new System.Drawing.Size(162, 26);
            this.txtIpAddress.TabIndex = 0;
            this.txtIpAddress.Text = "192.168.1.20";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusClient});
            this.statusStrip1.Location = new System.Drawing.Point(0, 847);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(848, 30);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusClient
            // 
            this.statusClient.Name = "statusClient";
            this.statusClient.Size = new System.Drawing.Size(165, 25);
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
            this.grpBasic.Location = new System.Drawing.Point(20, 175);
            this.grpBasic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBasic.Name = "grpBasic";
            this.grpBasic.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBasic.Size = new System.Drawing.Size(454, 362);
            this.grpBasic.TabIndex = 1;
            this.grpBasic.TabStop = false;
            this.grpBasic.Text = "Commands";
            // 
            // cmdSend
            // 
            this.cmdSend.Location = new System.Drawing.Point(148, 275);
            this.cmdSend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdSend.Name = "cmdSend";
            this.cmdSend.Size = new System.Drawing.Size(158, 63);
            this.cmdSend.TabIndex = 8;
            this.cmdSend.Text = "Send command";
            this.cmdSend.UseVisualStyleBackColor = true;
            this.cmdSend.Click += new System.EventHandler(this.cmdSend_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(399, 215);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "°";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 215);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "m";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Angle";
            // 
            // txtAngle
            // 
            this.txtAngle.Enabled = false;
            this.txtAngle.Location = new System.Drawing.Point(246, 211);
            this.txtAngle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAngle.Name = "txtAngle";
            this.txtAngle.Size = new System.Drawing.Size(148, 26);
            this.txtAngle.TabIndex = 7;
            this.txtAngle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAngle_KeyDown);
            this.txtAngle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAngle_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Distance";
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(42, 211);
            this.txtDistance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(148, 26);
            this.txtDistance.TabIndex = 6;
            this.txtDistance.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDistance_KeyDown);
            this.txtDistance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDistance_KeyPress);
            // 
            // radioStart
            // 
            this.radioStart.AutoSize = true;
            this.radioStart.Location = new System.Drawing.Point(42, 135);
            this.radioStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioStart.Name = "radioStart";
            this.radioStart.Size = new System.Drawing.Size(110, 24);
            this.radioStart.TabIndex = 5;
            this.radioStart.Text = "Start robot";
            this.radioStart.UseVisualStyleBackColor = true;
            this.radioStart.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // radioArcR
            // 
            this.radioArcR.AutoSize = true;
            this.radioArcR.Location = new System.Drawing.Point(195, 100);
            this.radioArcR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioArcR.Name = "radioArcR";
            this.radioArcR.Size = new System.Drawing.Size(119, 24);
            this.radioArcR.TabIndex = 4;
            this.radioArcR.Text = "TrackArc(R)";
            this.radioArcR.UseVisualStyleBackColor = true;
            this.radioArcR.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // radioArcL
            // 
            this.radioArcL.AutoSize = true;
            this.radioArcL.Location = new System.Drawing.Point(42, 100);
            this.radioArcL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioArcL.Name = "radioArcL";
            this.radioArcL.Size = new System.Drawing.Size(120, 24);
            this.radioArcL.TabIndex = 3;
            this.radioArcL.Text = "TrackArc (L)";
            this.radioArcL.UseVisualStyleBackColor = true;
            this.radioArcL.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // radioTurnR
            // 
            this.radioTurnR.AutoSize = true;
            this.radioTurnR.Location = new System.Drawing.Point(195, 65);
            this.radioTurnR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioTurnR.Name = "radioTurnR";
            this.radioTurnR.Size = new System.Drawing.Size(131, 24);
            this.radioTurnR.TabIndex = 2;
            this.radioTurnR.Text = "TrackTurn (R)";
            this.radioTurnR.UseVisualStyleBackColor = true;
            this.radioTurnR.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // radioTurnL
            // 
            this.radioTurnL.AutoSize = true;
            this.radioTurnL.Location = new System.Drawing.Point(42, 65);
            this.radioTurnL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioTurnL.Name = "radioTurnL";
            this.radioTurnL.Size = new System.Drawing.Size(128, 24);
            this.radioTurnL.TabIndex = 1;
            this.radioTurnL.Text = "TrackTurn (L)";
            this.radioTurnL.UseVisualStyleBackColor = true;
            this.radioTurnL.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // radioLine
            // 
            this.radioLine.AutoSize = true;
            this.radioLine.Location = new System.Drawing.Point(42, 29);
            this.radioLine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioLine.Name = "radioLine";
            this.radioLine.Size = new System.Drawing.Size(103, 24);
            this.radioLine.TabIndex = 0;
            this.radioLine.Text = "TrackLine";
            this.radioLine.UseVisualStyleBackColor = true;
            this.radioLine.CheckedChanged += new System.EventHandler(this.Option_CheckedChanged);
            // 
            // listHistory
            // 
            this.listHistory.FormattingEnabled = true;
            this.listHistory.ItemHeight = 20;
            this.listHistory.Location = new System.Drawing.Point(486, 20);
            this.listHistory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listHistory.Name = "listHistory";
            this.listHistory.Size = new System.Drawing.Size(346, 804);
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
            this.grpProfessional.Location = new System.Drawing.Point(18, 546);
            this.grpProfessional.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpProfessional.Name = "grpProfessional";
            this.grpProfessional.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpProfessional.Size = new System.Drawing.Size(454, 280);
            this.grpProfessional.TabIndex = 2;
            this.grpProfessional.TabStop = false;
            this.grpProfessional.Text = "Commands (Professional)";
            // 
            // cmdSendProf
            // 
            this.cmdSendProf.Location = new System.Drawing.Point(315, 218);
            this.cmdSendProf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmdSendProf.Name = "cmdSendProf";
            this.cmdSendProf.Size = new System.Drawing.Size(112, 31);
            this.cmdSendProf.TabIndex = 1;
            this.cmdSendProf.Text = "Send";
            this.cmdSendProf.UseVisualStyleBackColor = true;
            this.cmdSendProf.Click += new System.EventHandler(this.cmdSendProf_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 109);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(326, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Example: TL 10.5 5 -> TrackTurn (L) 10.5° 5m";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(242, 32);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 60);
            this.label8.TabIndex = 3;
            this.label8.Text = "AL: TrackArc (L)\r\nAR: TrackArc (R)\r\nS: Start\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 194);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Command";
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(42, 218);
            this.txtCommand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(262, 26);
            this.txtCommand.TabIndex = 0;
            this.txtCommand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCommand_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 60);
            this.label6.TabIndex = 0;
            this.label6.Text = "L: TrackLine\r\nTL: TrackTurn (L)\r\nTR: TrackTurn (R)\r\n";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 877);
            this.Controls.Add(this.grpProfessional);
            this.Controls.Add(this.listHistory);
            this.Controls.Add(this.grpBasic);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grpConfig);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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