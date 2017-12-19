using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Testat2
{
    class DriveLog
    {
        StreamWriter streamWriter;
        public DriveLog() { }

        public void CreateLog()
        {
            if (File.Exists("log.csv"))
            {
                Console.WriteLine("altes Log gelöscht!");
                File.Delete("log.csv");
            }
            streamWriter = new StreamWriter("log.csv", true);
            streamWriter.WriteLine("Team 13");
        }

        public void AddLogEntry(string log)
        {
            streamWriter.WriteLine(log);
        }

        public void CloseLog()
        {
            streamWriter.Close();
            this.PublishLog();
        }

        public void PublishLog()
        {
            this.RepressLog();
            File.Copy("log.csv", "httpLog.csv");
            Console.WriteLine("Log auf HTTP Server veröffentlicht");
        }

        public void RepressLog()
        {
            if (File.Exists("httpLog.csv"))
            {
                File.Delete("httpLog.csv");
                Console.WriteLine("veröffentlichetes Log gelöscht");
            }
        }
            
    }
}
