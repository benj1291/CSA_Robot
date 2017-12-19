using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.IO;

// Verbesserungsmöglichkeiten: StreamWriter Threadsicher machen

namespace Testat2 {
    public class CommandServer {
        private const String COMMAND_FILE = "commands.csv";

        private IPAddress ipAddress;
        private Int32 port = 4778;
        private TcpListener server;
        private TcpClient client;
        private List<TcpClient> listClients;
        private StreamWriter sw;

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
            server.Start();
            Console.WriteLine("Listening for connections...");

            this.client = server.AcceptTcpClient();
            listClients.Add(this.client);
            Console.WriteLine("Connection established...");

            ThreadPool.QueueUserWorkItem(o => this.CheckForMessages());
        }

        public void SendDoneMessage() {
            StreamWriter clientWriter = new StreamWriter(this.client.GetStream());

            reopenFile();

            clientWriter.WriteLine("ROBOTDONE");
            clientWriter.Flush();
        }

        private void reopenFile() {
            if (File.Exists(COMMAND_FILE)) {
                File.Delete(COMMAND_FILE);
            }

            sw = new StreamWriter(COMMAND_FILE, true);
            sw.AutoFlush = true;
        }

        private void CheckForMessages() {
            StreamReader sr = new StreamReader(this.client.GetStream());

            //von Benj
            if (File.Exists(COMMAND_FILE)) {
                File.Delete(COMMAND_FILE);
            }

            sw = new StreamWriter(COMMAND_FILE, true);
            sw.AutoFlush = true;
            String dataString;

            try {
                // Loop until client isn't connected anymore
                while (client.Client.Connected) {
                    dataString = sr.ReadLine();
                    Console.WriteLine("Received message");

                    // Only response to actual data
                    if (dataString != String.Empty && dataString != null) {
                        if (dataString.ToUpper().Equals("START")) {
                            // Send event
                            sw.Close();
                            this.onStartRobot(new EventArgs());
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
