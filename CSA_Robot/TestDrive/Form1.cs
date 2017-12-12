using RobotCtrl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestDrive
{
    public partial class Form1 : Form
    {
        private Robot robot;

        public Form1()
        {
            InitializeComponent();
            robot = new Robot();
            driveView.Drive = robot.Drive;
            runLineView.Drive = robot.Drive;
            runTurnView.Drive = robot.Drive;
            runArcView.Drive = robot.Drive;
            commonRunParameters.AccelerationChanged += AccelerationChanged;
            commonRunParameters.SpeedChanged += SpeedChanged;

            robot.Drive.Power = true;

            SpeedChanged(null, EventArgs.Empty);
            AccelerationChanged(null, EventArgs.Empty);
        }

        private void SpeedChanged(object sender, EventArgs e)
        {
            runLineView.Speed = commonRunParameters.Speed;
            runTurnView.Speed = commonRunParameters.Speed;
            runArcView.Speed = commonRunParameters.Speed;
        }

        private void AccelerationChanged(object sender, EventArgs e)
        {
            runLineView.Acceleration = commonRunParameters.Acceleration;
            runTurnView.Accleration = commonRunParameters.Acceleration;
            runArcView.Accleration = commonRunParameters.Acceleration;
        }
    }
}
