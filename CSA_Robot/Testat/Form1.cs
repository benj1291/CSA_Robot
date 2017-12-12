using RobotCtrl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Testat
{
    public partial class mainForm : Form
    {

        private Robot robot;
        private bool alarm = false;
        private bool alarmLed = false;

        public mainForm()
        {
            InitializeComponent();

            robot = new Robot();

            driveView.Drive = robot.Drive;
            consoleView.RobotConosle = robot.RobotConsole;
            radarView.Radar = robot.Radar;
            runLineView.Drive = robot.Drive;
            runTurnView.Drive = robot.Drive;
            runArcView.Drive = robot.Drive;

            commonRunParameters.AccelerationChanged += AccelerationChanged;
            commonRunParameters.SpeedChanged += SpeedChanged;

            (robot.RobotConsole[Switches.Switch1]).SwitchStateChanged += PowerOn;
            (robot.RobotConsole[Switches.Switch2]).SwitchStateChanged += StartRunLine;
            (robot.RobotConsole[Switches.Switch3]).SwitchStateChanged += StartRunTurn;
            (robot.RobotConsole[Switches.Switch4]).SwitchStateChanged += StartRunArc;

            AccelerationChanged(null, EventArgs.Empty);
            SpeedChanged(null, EventArgs.Empty);

        }

        public bool Alarm
        {
            set
            {
                this.alarm = value;
            }
            get
            {
                return this.alarm;
            }
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

        private void PowerOn(object sender, EventArgs e)
        {
            this.robot.Drive.Power = true;
            (robot.RobotConsole[Switches.Switch1]).SwitchStateChanged -= PowerOn;
            (robot.RobotConsole[Switches.Switch1]).SwitchStateChanged += PowerOff;
        }

        private void PowerOff(object sender, EventArgs e)
        {
            this.robot.Drive.Power = false;
            (robot.RobotConsole[Switches.Switch1]).SwitchStateChanged -= PowerOff;
            (robot.RobotConsole[Switches.Switch1]).SwitchStateChanged += PowerOn;
        }

        private void StartRunLine(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new EventHandler<SwitchEventArgs>(StartRunLine), sender, e);
            }
            else
            {
                if (robot.RobotConsole[Switches.Switch2].SwitchEnabled)
                {
                    this.runLineView.Start();
                }
            }
        }

        private void StartRunTurn(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new EventHandler<SwitchEventArgs>(StartRunTurn), sender, e);
            }
            else
            {
                if (robot.RobotConsole[Switches.Switch3].SwitchEnabled)
                {
                    this.runTurnView.Start();
                }
            }
        }

        private void StartRunArc(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new EventHandler<SwitchEventArgs>(StartRunArc), sender, e);
            }
            else
            {
                if (robot.RobotConsole[Switches.Switch4].SwitchEnabled)
                {
                    this.runArcView.Start();
                }
            }
        }

        private void buttonHalt_Click(object sender, EventArgs e)
        {
            this.robot.Drive.Halt();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            this.robot.Drive.Stop();
        }

        private void timerAlarmLed_Tick(object sender, EventArgs e)
        {
            if (Alarm)
            {
                if (!this.alarmLed)
                {
                    robot.RobotConsole[Leds.Led1].LedEnabled = true;
                    robot.RobotConsole[Leds.Led2].LedEnabled = true;
                    robot.RobotConsole[Leds.Led3].LedEnabled = true;
                    robot.RobotConsole[Leds.Led4].LedEnabled = true;
                    this.alarmLed = true;
                }
                else
                {
                    robot.RobotConsole[Leds.Led1].LedEnabled = false;
                    robot.RobotConsole[Leds.Led2].LedEnabled = false;
                    robot.RobotConsole[Leds.Led3].LedEnabled = false;
                    robot.RobotConsole[Leds.Led4].LedEnabled = false;
                    this.alarmLed = false;
                }
            }
        }

        private void timerDistanceWarning_Tick(object sender, EventArgs e)
        {
            if (this.robot.Radar.Distance < 0.3 & this.robot.Radar.Distance > 0.2)
            {
                this.robot.Drive.Halt();
                this.Alarm = true;
            }
            else if(this.robot.Radar.Distance < 0.1)
            {
                this.robot.Drive.Stop();
                this.Alarm = true;
            }
            else
            {
                this.Alarm = false;
            }
        }
    }
}
