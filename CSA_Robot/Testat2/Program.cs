using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;

namespace Testat2
{
    class Program
    {
        static DriveRoute driveRoute;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# on Windows Embedded Systems");


            driveRoute = new DriveRoute();
            driveRoute.PathDriveRouteFile = "commands.csv";

            HTTPLogServer hs = new HTTPLogServer(8080);
            new Thread(hs.Start).Start();

            var commandServer = new CommandServer(IPAddress.Any, 4778);
            commandServer.StartRobot += StartDriveRobot;
        }

        private static void StartDriveRobot(object sender, EventArgs e)
        {
            Console.WriteLine("Route gestartet");
            //var streamReader = new StreamReader("commands.csv");
            //string line;
            //while ((line = streamReader.ReadLine()) != null)
            //{
            //Console.WriteLine(line);
            //}
            //streamReader.Close();
            driveRoute.Start();
        }

    }
}
