namespace TestDrive
{
    partial class Form1
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
            this.driveView = new RobotView.DriveView();
            this.commonRunParameters = new RobotView.CommonRunParameters();
            this.runLineView = new RobotView.RunLineView();
            this.runTurnView = new RobotView.RunTurnView();
            this.runArcView = new RobotView.RunArcView();
            this.SuspendLayout();
            // 
            // driveView
            // 
            this.driveView.Drive = null;
            this.driveView.Location = new System.Drawing.Point(21, 118);
            this.driveView.Name = "driveView";
            this.driveView.Size = new System.Drawing.Size(309, 304);
            this.driveView.TabIndex = 1;
            // 
            // commonRunParameters
            // 
            this.commonRunParameters.Acceleration = 0.3F;
            this.commonRunParameters.Location = new System.Drawing.Point(21, 3);
            this.commonRunParameters.Name = "commonRunParameters";
            this.commonRunParameters.Size = new System.Drawing.Size(309, 94);
            this.commonRunParameters.Speed = 0.5F;
            this.commonRunParameters.TabIndex = 2;
            // 
            // runLineView
            // 
            this.runLineView.Location = new System.Drawing.Point(361, 17);
            this.runLineView.Name = "runLineView";
            this.runLineView.Size = new System.Drawing.Size(471, 80);
            this.runLineView.TabIndex = 3;
            // 
            // runTurnView
            // 
            this.runTurnView.Location = new System.Drawing.Point(361, 97);
            this.runTurnView.Name = "runTurnView";
            this.runTurnView.Size = new System.Drawing.Size(480, 70);
            this.runTurnView.TabIndex = 4;
            // 
            // runArcView
            // 
            this.runArcView.Location = new System.Drawing.Point(361, 173);
            this.runArcView.Name = "runArcView";
            this.runArcView.Size = new System.Drawing.Size(480, 150);
            this.runArcView.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(874, 521);
            this.Controls.Add(this.driveView);
            this.Controls.Add(this.commonRunParameters);
            this.Controls.Add(this.runLineView);
            this.Controls.Add(this.runTurnView);
            this.Controls.Add(this.runArcView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private RobotView.DriveView driveView;
        private RobotView.CommonRunParameters commonRunParameters;
        private RobotView.RunLineView runLineView;
        private RobotView.RunTurnView runTurnView;
        private RobotView.RunArcView runArcView;
    }
}

