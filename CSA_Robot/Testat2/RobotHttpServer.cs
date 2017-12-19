using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace Testat2
{
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
            StreamReader reqReader = new StreamReader(client.GetStream());
            String request = "";

            // Only read the first header part, contains everything needed
            request += reqReader.ReadLine();

            // Check if the request is a GET request for /history
            if (request.ToUpper().Contains("GET") && request.ToUpper().Contains("/HISTORY")) {
                Console.WriteLine("Valid request received...");
                this.createResponse(client);
            }
        }

        private void createResponse(TcpClient client) {
            StreamWriter sw = new StreamWriter(client.GetStream());
            String historyData = this.readHistoryFile();

            // Prepare StreamWriter
            sw.AutoFlush = true;

            // Replace placeholder with actual data and sent to requester
            this.htmlResponse = this.htmlResponse.Replace("$data", historyData);
            sw.WriteLine(this.getHttpHeader());
            sw.WriteLine(this.htmlResponse);

            // Close StreamWriter and close client connection
            sw.Close();
            client.Close();
        }

        private String readHistoryFile() {
            StreamReader sr = new StreamReader("D:/history.txt", Encoding.ASCII);
            String historyData;

            historyData = sr.ReadToEnd();
            sr.Close();

            return historyData;
        }

        private String getHttpHeader() {
            String header;

            header = "HTTP/1.1 200 OK" + Environment.NewLine +
                "Content-Type: text/html" + Environment.NewLine +
                "Content-Length: " + this.htmlResponse.Length + Environment.NewLine +
                "Connection: close" + Environment.NewLine +
                Environment.NewLine;

            return header;
        }
    }
}
