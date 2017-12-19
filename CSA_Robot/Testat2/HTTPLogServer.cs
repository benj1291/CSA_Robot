using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Testat2
{
    class HTTPLogServer
    {
        TcpListener tcpListener;
        public event EventHandler HttpLog;

        public HTTPLogServer(int port)
        {
            tcpListener = new TcpListener(IPAddress.Any, port);
        }

        public void Start()
        {
            tcpListener.Start();
            HttpLog?.Invoke("HTTP Server Startet", null);
            while (true)
            {
                TcpClient client = tcpListener.AcceptTcpClient();
                HttpLog?.Invoke("HTTP Server Connected", null);
                HTTPLogServerHandler httpLogServerhandler = new HTTPLogServerHandler(client);
                new Thread(httpLogServerhandler.HandleRequest).Start();
            }
        }
    }
}
