using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace RobotClient {
    public class Client {

        private IPAddress ipAddress;
        private int port;
        private TcpClient tcpClient;
        private NetworkStream netStream;
        private BufferedStream bufferStream;
        private StreamWriter sw;

        public event EventHandler Connection;

        public Client(IPAddress ipAddress, int port) {
            this.ipAddress = ipAddress;
            this.port = port;

            this.tcpClient = new TcpClient(this.ipAddress.ToString(), this.port);
            this.netStream = this.tcpClient.GetStream();
            this.bufferStream = new BufferedStream(this.netStream);
            this.sw = new StreamWriter(this.bufferStream);

            if (this.tcpClient.Connected) {
                this.onConnection(new EventArgs());
            }
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
        protected virtual void onConnection(EventArgs e) {
            this.Connection?.Invoke(this, e);
        }
    }
}
