using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Threading;

// Verbesserungsmöglichkeiten: Mehr abstrahieren
// -> Momentan wird spezifisch auf "ROBOTDONE" gehört
// -> Generell auf Messages hören und ein generelles Event schicken.

namespace RobotClient {
    public class Client {

        private IPAddress ipAddress;
        private int port;
        private TcpClient tcpClient;
        private NetworkStream netStream;
        private BufferedStream bufferStream;
        private StreamWriter sw;
        private StreamReader sr;

        public event EventHandler Connection;
        public event EventHandler RobotDone;

        public Client(IPAddress ipAddress, int port) {
            this.ipAddress = ipAddress;
            this.port = port;

            this.tcpClient = new TcpClient(this.ipAddress.ToString(), this.port);
            this.netStream = this.tcpClient.GetStream();
            this.bufferStream = new BufferedStream(this.netStream);
            this.sw = new StreamWriter(this.bufferStream);
            this.sr = new StreamReader(this.bufferStream);

            if (this.tcpClient.Connected) {
                this.onConnection(new EventArgs());
            }

            ThreadPool.QueueUserWorkItem(o => this.ListenForDone());
        }

        public IPAddress IpAddress {
            get { return this.ipAddress; }
            set { this.ipAddress = value; }
        }

        public int Port {
            get { return this.port; }
            set { this.port = value; }
        }
        
        public bool IsConnected {
            get { return this.tcpClient.Connected; }
        }

        public void Start() {
            tcpClient.Connect(this.ipAddress, this.port);
        }

        public void Send(String data) {
            if (!this.tcpClient.Connected) {
                this.onConnection(new EventArgs());
                return;
            }

            this.sw.WriteLine(data);
            this.sw.Flush();
        }
        
        private void ListenForDone() {
            String dataString;

            while (this.tcpClient.Connected) {
                try {

                    dataString = sr.ReadLine();

                    if (dataString != String.Empty && dataString != null) {
                        if (dataString.ToUpper().Equals("ROBOTDONE")) {
                            // Send event
                            this.onRobotDone(new EventArgs());
                        }
                    }
                } catch (IOException e) {
                    Console.WriteLine("Error has occured: " + e.Message);
                }
            }
        }

        protected virtual void onConnection(EventArgs e) {
            this.Connection?.Invoke(this, e);
        }
        
        protected virtual void onRobotDone(EventArgs e) {
            this.RobotDone?.Invoke(this, e);
        }
    }
}
