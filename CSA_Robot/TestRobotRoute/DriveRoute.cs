using RobotCtrl;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TestRobotRoute
{
    class DriveRoute
    {
        private float _acceleration = 0.3F;
        private float _speed = 0.5F;
        private string _pathRouteFile;
        private bool _done;
        private Robot _robot;
        private DriveLog _driveLog;

        public DriveRoute()
        {
            this.DriveLog = new DriveLog();
            this.Robot = new Robot();
            this.Robot.Drive.Power = true;
        }

        public string PathDriveRouteFile
        {
            private get
            {
                return this._pathRouteFile;
            }
            set
            {
                this._pathRouteFile = value;
            }
        }

        public bool Done
        {
            get
            {
                return this._done;
            }
            set
            {
                this._done = value;
            }
        }

        public Robot Robot
        {
            private get
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

        public void Start()
        {
            this.Start(this.PathDriveRouteFile);
        }

        public void Start(string pathRouteFile)
        {
            this.Done = false;
            this.PathDriveRouteFile = pathRouteFile;
            var driveCommands = encodeDriveCommand();
            this.Run(driveCommands);
            this.Done = true;
        }

        private List<DriveCommand> encodeDriveCommand()
        {
            var listDriveCommand = new List<DriveCommand>();

            using (var streamReader = new StreamReader(this.PathDriveRouteFile))
            {
                while (!streamReader.EndOfStream)
                {
                    var line = streamReader.ReadLine();
                    listDriveCommand.Add(DriveCommand.CreateDriveCommand(line, this.Robot, this.DriveLog, this.Acceleration, this.Speed));
                }
            }

            return listDriveCommand;
        }

        private void Run(List<DriveCommand> driveCommands)
        {
            DriveLog.RepressLog();
            DriveLog.CreateLog();
            DriveLog.AddLogEntry(DateTime.Now.ToString("dd/MM/yyyy-hh:mm:ss.fff") + ";" + Robot.Drive.DriveInfo.Position.X.ToString() + ";" + Robot.Drive.DriveInfo.Position.Y.ToString());
            foreach (DriveCommand dc in driveCommands)
            {
                Console.WriteLine("Befehl: " + dc.ToString());
                dc.Run();
            }
            DriveLog.CloseLog();
        }
    }
}
