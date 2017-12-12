using RobotView;

namespace TestMotor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.driveCtrlView = new RobotView.DriveCtrlView();
            this.motorCtrlViewLeft = new RobotView.MotorCtrlView();
            this.motorCtrlViewRight = new RobotView.MotorCtrlView();
            this.SuspendLayout();
            // 
            // driveCtrlView
            // 
            this.driveCtrlView.DriveCtrl = null;
            this.driveCtrlView.Location = new System.Drawing.Point(312, 3);
            this.driveCtrlView.Name = "driveCtrlView";
            this.driveCtrlView.Size = new System.Drawing.Size(271, 57);
            this.driveCtrlView.TabIndex = 1;
            // 
            // motorCtrlViewLeft
            // 
            this.motorCtrlViewLeft.Location = new System.Drawing.Point(3, 93);
            this.motorCtrlViewLeft.MotorCtrl = null;
            this.motorCtrlViewLeft.Name = "motorCtrlViewLeft";
            this.motorCtrlViewLeft.Size = new System.Drawing.Size(431, 258);
            this.motorCtrlViewLeft.TabIndex = 2;
            // 
            // motorCtrlViewRight
            // 
            this.motorCtrlViewRight.Location = new System.Drawing.Point(440, 93);
            this.motorCtrlViewRight.MotorCtrl = null;
            this.motorCtrlViewRight.Name = "motorCtrlViewRight";
            this.motorCtrlViewRight.Size = new System.Drawing.Size(431, 258);
            this.motorCtrlViewRight.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(895, 374);
            this.Controls.Add(this.motorCtrlViewRight);
            this.Controls.Add(this.driveCtrlView);
            this.Controls.Add(this.motorCtrlViewLeft);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private RobotView.DriveCtrlView driveCtrlView;
        private RobotView.MotorCtrlView motorCtrlViewLeft;
        private MotorCtrlView motorCtrlViewRight;
    }
}

