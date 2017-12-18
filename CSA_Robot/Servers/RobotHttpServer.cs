using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace Servers {
    class RobotHttpServer {
        private IPAddress ipAddress;
        private Int32 port;
        private TcpListener server;

        private String htmlResponse =
            "<html>" +
            "<header>" +
            "<title>Team 13 - HTML Server </title>" +
            "</header>" +
            "<body>$data</body>" +
            "</html>";

        public RobotHttpServer(IPAddress ipAddress, Int32 port) {
            this.ipAddress = ipAddress;
            this.port = port;

            this.server = new TcpListener(this.ipAddress, this.port);
        }

        public IPAddress IpAddress {
            get { return this.ipAddress; }
            set { this.ipAddress = value; }
        }

        public Int32 Port {
            get { return this.port; }
            set { this.port = value; }
        }

        public void StartServer() {
            this.ListenForClients();
        }

        private void ListenForClients() {
            TcpClient client;
            this.server.Start();
            Console.WriteLine("Listening for connections...");

            while (this.server != null && this.server.Server != null) {
                client = this.server.AcceptTcpClient();

                ThreadPool.QueueUserWorkItem(this.evaluateRequest, client);
            }
        }

        private void evaluateRequest(Object o) {
            TcpClient client = (TcpClient)o;
            NetworkStream netStream = client.GetStream();
            StreamReader reqReader = new StreamReader(netStream);
            String request = "";

            // Only read the first header part, contains everything needed
            request += reqReader.ReadLine();

            // Check if the request is a GET request for /history
            if (request.ToUpper().Contains("GET") && request.ToUpper().Contains("/HISTORY")) {
                Console.WriteLine("Valid request received...");

                String historyData = "";
                NetworkStream ns = client.GetStream();
                StreamReader sr = new StreamReader("D:/history.txt", Encoding.ASCII);
                StreamWriter sw = new StreamWriter(ns);

                // Prepare StreamWriter
                sw.AutoFlush = true;

                // Read all data from file and close StreamReader
                historyData = sr.ReadToEnd();
                sr.Close();

                // Replace placeholder with actual data and sent to requester
                this.htmlResponse = this.htmlResponse.Replace("$data", historyData);
                sw.WriteLine("HTTP/1.1 200 OK");
                sw.WriteLine("Content-type: text/html");
                sw.WriteLine("Content-Length: " + this.htmlResponse.Length);
                sw.WriteLine("Connection: close");
                sw.WriteLine("");
                sw.WriteLine(this.htmlResponse);

                // Close StreamWriter and close client connection
                sw.Close();
                client.Close();
            }
        }
    }
}
