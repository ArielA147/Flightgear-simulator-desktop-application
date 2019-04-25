﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;


namespace Model
{
    public class ClientHandler : IClientHandler
    {
        public delegate void dataResives(string[] massege);
        public event dataResives dataEvent;
        private bool stop = false;
        public void HandleClient(TcpClient client)
        {
            // get client stream for reading and writing.
            NetworkStream stearm = client.GetStream();
            StreamReader reader = new StreamReader(stearm);
            {
                // get client commnad line.
                while (!stop) { 
                    string commnadLine = reader.ReadLine();
                    string[] tokens = commnadLine.Split(',');
                    dataEvent?.Invoke(tokens);
                }
            }
            stearm.Close();
            client.Close();
        }
        public void CloseConnaction()
        {
            stop = true;
        }
    }
}
