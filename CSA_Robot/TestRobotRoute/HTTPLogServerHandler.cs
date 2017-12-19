using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace TestRobotRoute
{
    class HTTPLogServerHandler
    {
        private TcpClient client;

        public HTTPLogServerHandler(TcpClient client)
        {
            this.client = client;
        }

        public void HandleRequest()
        {
            try
            {
                StreamReader sr = new StreamReader(client.GetStream());
                StreamWriter sw = new StreamWriter(client.GetStream());

                while (sr.ReadLine() != String.Empty)
                {

                }

                try
                {
                    StreamReader streamReaderLog = new StreamReader("httpLog.csv");
                    sw.WriteLine("HTTP/1.1 200 OK");
                    sw.WriteLine("Content-type: text/csv");
                    sw.WriteLine("Content-Disposition: attachment; filename=\"routeLog.csv\"");
                    sw.WriteLine("Connection:close");
                    sw.WriteLine("");
                    string logEntryLine;
                    while ((logEntryLine = streamReaderLog.ReadLine()) != null)
                    {
                        sw.WriteLine(logEntryLine);
                    }
                    Console.WriteLine("Routen Log von Client heruntergeladen");

                }
                catch(Exception e)
                {
                    sw.WriteLine("HTTP/1.1 200 OK");
                    sw.WriteLine("Content-type: text/html");
                    sw.WriteLine("Connection:close");
                    sw.WriteLine("");
                    sw.WriteLine("<h1>kein Log gefunden!</h1>");
                }
                finally
                {
                    sw.Flush();
                    client.Close();
                }

            }
            catch (Exception e)
            {

            }
        }
    }
}
