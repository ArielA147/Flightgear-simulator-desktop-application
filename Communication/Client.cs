using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Net;
using System.Threading.Tasks;

namespace Model
{
    public class Client
    {
        private TcpClient clientTcp ;
        private NetworkStream stream;

        public bool IsConnact { set; get; } = false;

        #region SingleTon
        private static Client m_Instance = null;
        public static Client Instance
        {
            get
            {
                if (m_Instance == null)
                    m_Instance = new Client();
                return m_Instance;
            }
        }
        #endregion

        public void connect(int port, string serverIp)
        {
            clientTcp = new TcpClient();
            while (!clientTcp.Connected) {
                try { clientTcp.Connect(IPAddress.Parse(serverIp), port); }
                catch(Exception) { }
            }
            stream = clientTcp.GetStream();
            IsConnact = true;
            Console.WriteLine("u are connacted");
        }

        public void SendMsg(string path, string value)
        {
            string msg = "set"+" " + path +" "+ value + "\r\n";
            byte[] massegeToSend = ASCIIEncoding.ASCII.GetBytes(msg);
            stream.Write(massegeToSend, 0, massegeToSend.Length);
        }

        public void SendAutoPilotMassege(string[] commands)
        {
            foreach(string command in commands)
            {
                string commandForSend = command + "\r\n";
                byte[] massegeToSend = ASCIIEncoding.ASCII.GetBytes(commandForSend);
                stream.Write(massegeToSend, 0, massegeToSend.Length);
                System.Threading.Thread.Sleep(2000);
            }
        }

        public void Close()
        {
            if (clientTcp != null)
            {
                clientTcp.Close();
                stream.Close();
                IsConnact = false;
            }
        }
    }
}
