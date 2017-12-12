namespace Testat
{
    partial class mainForm
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
            this.buttonHalt = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.timerAlarmLed = new System.Windows.Forms.Timer();
            this.timerDistanceWarning = new System.Windows.Forms.Timer();
            this.driveView = new RobotView.DriveView();
            this.consoleView = new RobotView.ConsoleView();
            this.radarView = new RobotView.RadarView();
            this.commonRunParameters = new RobotView.CommonRunParameters();
            this.runLineView = new RobotView.RunLineView();
            this.runTurnView = new RobotView.RunTurnView();
            this.runArcView = new RobotView.RunArcView();
            this.SuspendLayout();
            // 
            // buttonHalt
            // 
            this.buttonHalt.Location = new System.Drawing.Point(215, 308);
            this.buttonHalt.Name = "buttonHalt";
            this.buttonHalt.Size = new System.Drawing.Size(97, 50);
            this.buttonHalt.TabIndex = 7;
            this.buttonHalt.Text = "Halt";
            this.buttonHalt.Click += new System.EventHandler(this.buttonHalt_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(338, 308);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(97, 50);
            this.buttonStop.TabIndex = 8;
            this.buttonStop.Text = "Stop";
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // timerAlarmLed
            // 
            this.timerAlarmLed.Enabled = true;
            this.timerAlarmLed.Tick += new System.EventHandler(this.timerAlarmLed_Tick);
            // 
            // timerDistanceWarning
            // 
            this.timerDistanceWarning.Enabled = true;
            this.timerDistanceWarning.Interval = 10;
            this.timerDistanceWarning.Tick += new System.EventHandler(this.timerDistanceWarning_Tick);
            // 
            // driveView
            // 
            this.driveView.Drive = null;
            this.driveView.Location = new System.Drawing.Point(3, 3);
            this.driveView.Name = "driveView";
            this.driveView.Size = new System.Drawing.Size(292, 289);
            this.driveView.TabIndex = 1;
            // 
            // consoleView
            // 
            this.consoleView.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.consoleView.Location = new System.Drawing.Point(4, 308);
            this.consoleView.Name = "consoleView";
            this.consoleView.RobotConosle = null;
            this.consoleView.Size = new System.Drawing.Size(205, 50);
            this.consoleView.TabIndex = 2;
            // 
            // radarView
            // 
            this.radarView.Location = new System.Drawing.Point(4, 365);
            this.radarView.Name = "radarView";
            this.radarView.Radar = null;
            this.radarView.Size = new System.Drawing.Size(459, 55);
            this.radarView.TabIndex = 9;
            // 
            // commonRunParameters
            // 
            this.commonRunParameters.Acceleration = 0.3F;
            this.commonRunParameters.Location = new System.Drawing.Point(470, 319);
            this.commonRunParameters.Name = "commonRunParameters";
            this.commonRunParameters.Size = new System.Drawing.Size(301, 84);
            this.commonRunParameters.Speed = 0.5F;
            this.commonRunParameters.TabIndex = 3;
            // 
            // runLineView
            // 
            this.runLineView.Location = new System.Drawing.Point(301, 3);
            this.runLineView.Name = "runLineView";
            this.runLineView.Size = new System.Drawing.Size(480, 70);
            this.runLineView.TabIndex = 4;
            // 
            // runTurnView
            // 
            this.runTurnView.Location = new System.Drawing.Point(301, 71);
            this.runTurnView.Name = "runTurnView";
            this.runTurnView.Size = new System.Drawing.Size(480, 70);
            this.runTurnView.TabIndex = 5;
            // 
            // runArcView
            // 
            this.runArcView.Location = new System.Drawing.Point(301, 142);
            this.runArcView.Name = "runArcView";
            this.runArcView.Size = new System.Drawing.Size(480, 150);
            this.runArcView.TabIndex = 6;
            // 
            // mainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(798, 429);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonHalt);
            this.Controls.Add(this.driveView);
            this.Controls.Add(this.consoleView);
            this.Controls.Add(this.radarView);
            this.Controls.Add(this.commonRunParameters);
            this.Controls.Add(this.runLineView);
            this.Controls.Add(this.runTurnView);
            this.Controls.Add(this.runArcView);
            this.Name = "mainForm";
            this.Text = "Testat";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion
        private RobotView.DriveView driveView;
        private RobotView.ConsoleView consoleView;
        private RobotView.RadarView radarView;
        private RobotView.CommonRunParameters commonRunParameters;
        private RobotView.RunLineView runLineView;
        private RobotView.RunTurnView runTurnView;
        private RobotView.RunArcView runArcView;
        private System.Windows.Forms.Button buttonHalt;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Timer timerAlarmLed;
        private System.Windows.Forms.Timer timerDistanceWarning;
    }
}

