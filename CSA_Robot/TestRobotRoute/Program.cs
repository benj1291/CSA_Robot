using RobotCtrl;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace TestRobotRoute
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# on Windows Embedded Systems");

            //TestFile erstellen
            if (File.Exists("test.csv"))
            {
                Console.WriteLine("altes Files gelöscht!");
                File.Delete("test.csv");
            }
            var streamWriter = new StreamWriter("test.csv", true);
            streamWriter.WriteLine("TrackLine;1.5");
            streamWriter.WriteLine("TrackTurnRight;90");
            streamWriter.WriteLine("TrackLine;0.5");
            streamWriter.WriteLine("TrackArcRight;90;0.5");
            streamWriter.WriteLine("TrackArcLeft;270;0.5");
            streamWriter.Close();

            //Log HTTP Server auf dem Port 8080 starten
            HTTPLogServer hs = new HTTPLogServer(8080);
            new Thread(hs.Start).Start();

            //DriveRoute erstellengit
            var driveRoute = new DriveRoute();
            driveRoute.Start("test.csv");


        }
    }
}
