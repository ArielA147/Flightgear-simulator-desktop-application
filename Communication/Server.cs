using FlightSimulator.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Model
{
    public class Server
    {
        #region SingleTon
        private static Server m_Instance = null;
        public static Server Instance
        {
            get
            {
                if (m_Instance == null)
                    m_Instance = new Server();
                return m_Instance;
            }
        }
        #endregion

        // private members
        public delegate void dataResives(string[] massege);
        public event dataResives dataEvent;
        private bool stop = false;
        private int port;
        private string id;
        private TcpListener listener;
        public Server()
        {
            // inisilze port and id according to settingsModel data.
            this.port = ApplicationSettingsModel.Instance.FlightInfoPort;
            this.id = ApplicationSettingsModel.Instance.FlightServerIP;
        }
        public void Start()
        {
            // represents a network endpoint as an ip address and port number. 
            IPEndPoint ep = new IPEndPoint(IPAddress.Any,port); 
            listener = new TcpListener(ep);
            // start listening for client requests.
            listener.Start();
            
            // create new thread.
            Thread thread = new Thread(() =>
            {
                try
                {
                    // after the connection, get client.
                    TcpClient client = listener.AcceptTcpClient();
                    stop = false;
                    NetworkStream stearm = client.GetStream();
                    StreamReader reader = new StreamReader(stearm);
                    {
                        // get client commnad line.
                        while (!stop)
                        {
                            string commnadLine = reader.ReadLine();
                            Debug.WriteLine("got command: {0}", commnadLine);
                            string[] tokens = commnadLine.Split(',');
                            dataEvent?.Invoke(tokens);
                        }
                    }
                    stearm.Close();
                    client.Close();
                }
                catch (SocketException) { }

                Debug.WriteLine("Server stopped");
            });
            //start this thread.
            thread.Start();
        }
        // stop listenning for another requests
        public void Stop()
        {
            stop = true;
            listener?.Stop();
        }
    }
}
