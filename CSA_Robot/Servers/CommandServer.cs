using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;

namespace Servers {
    public class CommandServer {
        private IPAddress ipAddress;
        private Int32 port = 4778;
        private TcpListener server;
        private List<TcpClient> listClients;

        public event EventHandler StartRobot;

        public CommandServer(IPAddress ipAddress, Int32 port) {
            this.ipAddress = ipAddress;
            this.port = port;

            this.listClients = new List<TcpClient>();
            this.server = new TcpListener(this.ipAddress, this.port);
            this.ListenForClients();
        }

        protected virtual void onStartRobot(EventArgs e) {
            this.StartRobot?.Invoke(this, e);
        }

        public void ListenForClients() {
            TcpClient client;
            server.Start();
            Console.WriteLine("Listening for connections...");

            client = server.AcceptTcpClient();
            listClients.Add(client);
            Console.WriteLine("Connection established...");

            ThreadPool.QueueUserWorkItem(this.CheckForMessages, client);
        }

        private void CheckForMessages(Object o) {
            TcpClient client = (TcpClient)o;
            StreamReader sr = new StreamReader(client.GetStream());
            StreamWriter sw = new StreamWriter("D:/commands.txt", true);
            String dataString;

            sw.AutoFlush = true;

            try {
                // Loop until client isn't connected anymore
                while (client.Client.Connected) {
                    dataString = sr.ReadLine();
                    Console.WriteLine("Received message");

                    // Only response to actual data
                    if (dataString != String.Empty && dataString != null) {
                        if (dataString.ToUpper().Equals("START")) {
                            // Send event and close client
                            this.onStartRobot(new EventArgs());
                            client.Close();
                        } else {
                            sw.WriteLine(dataString);
                        }
                    }
                }

            } catch (Exception ex) {
                Console.WriteLine("An error has occured: " + ex.Message);

            } finally {
                sr.Close();
                sw.Close();
                client.Close();
            }
        }
    }
}
