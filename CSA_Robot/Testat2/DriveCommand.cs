using RobotCtrl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Testat2
{
    class DriveCommand
    {

        private int _valueA;
        private float _valueL;
        private float _acceleration;
        private float _speed;
        private DriveCommandTyp _driveCommandTyp;
        private Robot _robot;
        private DriveLog _driveLog;

        public DriveCommand()
        {
            
        }

        public override string ToString()
        {
            if((int)this.DriveCommandTyp <= 3)
            {
                return "<" + this.DriveCommandTyp + ":" + this.ValueA.ToString() + ">";
            }
            else
            {
                return "<" + this.DriveCommandTyp + ":" + this.ValueA.ToString() + "/" + this.ValueL.ToString() + ">";
            }
        }

        public int ValueA
        {
            get
            {
                return this._valueA;
            }
            set
            {
                this._valueA = value;
            }
        }

        public float ValueL
        {
            get
            {
                return this._valueL;
            }
            set
            {
                this._valueL = value;
            }
        }

        public float Acceleration
        {
            get
            {
                return this._acceleration;
            }
            set
            {
                this._acceleration = value;
            }
        }

        public float Speed
        {
            get
            {
                return this._speed;
            }
            set
            {
                this._speed = value;
            }
        }

        public DriveCommandTyp DriveCommandTyp
        {
            get
            {
                return this._driveCommandTyp;
            }
            set
            {
                this._driveCommandTyp = value;
            }
        }

        public Robot Robot
        {
            get
            {
                return this._robot;
            }
            set
            {
                this._robot = value;
            }
        }

        public DriveLog DriveLog
        {
            get
            {
                return this._driveLog;
            }
            set
            {
                this._driveLog = value;
            }
        }

        public static DriveCommand CreateDriveCommand(string commandCSV, Robot robot, DriveLog driveLog, float accleration, float speed)
        {
            var driveCommand = new DriveCommand();
            driveCommand.Robot = robot;
            driveCommand.DriveLog = driveLog;
            driveCommand.Acceleration = accleration;
            driveCommand.Speed = speed;
            var values = commandCSV.Split(';');
            var commandName = values[0];
            

            switch (commandName)
            {
                case "TrackLine":
                    driveCommand.DriveCommandTyp = DriveCommandTyp.TrackLine;
                    driveCommand.ValueL = float.Parse(values[1]);
                    break;
                
                case "TrackTurnLeft":
                    driveCommand.DriveCommandTyp = DriveCommandTyp.TrackTurnLeft;
                    driveCommand.ValueA = Convert.ToInt32(values[1]);
                    break;
                
                case "TrackTurnRight":
                    driveCommand.DriveCommandTyp = DriveCommandTyp.TrackTurnRight;
                    driveCommand.ValueA = Convert.ToInt32(values[1]) * -1;
                    break;
                
                case "TrackArcLeft":
                    driveCommand.DriveCommandTyp = DriveCommandTyp.TrackArcLeft;
                    driveCommand.ValueA = Convert.ToInt32(values[2]);
                    driveCommand.ValueL = float.Parse(values[1]);
                    break;
                
                case "TrackArcRight":
                    driveCommand.DriveCommandTyp = DriveCommandTyp.TrackArcRight;
                    driveCommand.ValueA = Convert.ToInt32(values[2]);
                    driveCommand.ValueL = float.Parse(values[1]);
                    break;
            }

            return driveCommand;
        }

        public void Run()
        {
            switch (this.DriveCommandTyp)
            {
                case DriveCommandTyp.TrackLine:
                    this.Robot.Drive.RunLine(this.ValueL, this.Speed, this.Acceleration);
                    break;

                case DriveCommandTyp.TrackTurnLeft:
                    this.Robot.Drive.RunTurn(this.ValueA, this.Speed, this.Acceleration);
                    break;

                case DriveCommandTyp.TrackTurnRight:
                    this.Robot.Drive.RunTurn(this.ValueA, this.Speed, this.Acceleration);
                    break;

                case DriveCommandTyp.TrackArcLeft:
                    this.Robot.Drive.RunArcLeft(this.ValueL, this.ValueA, this.Speed, this.Acceleration);
                    break;

                case DriveCommandTyp.TrackArcRight:
                    this.Robot.Drive.RunArcRight(this.ValueL, this.ValueA, this.Speed, this.Acceleration);
                    break;
            }

            while (!this.Robot.Drive.Done)
            {
                Thread.Sleep(100);
                DriveLog.AddLogEntry(DateTime.Now.ToString("dd/MM/yyyy-hh:mm:ss.fff") + ";" + Robot.Drive.DriveInfo.Position.X.ToString() + ";" + Robot.Drive.DriveInfo.Position.Y.ToString());
            }
        }
    }
}
