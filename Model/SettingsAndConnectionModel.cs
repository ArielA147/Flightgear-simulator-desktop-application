using FlightSimulator.Model;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSimulator
{
    class SettingsAndConnectionModel
    {
        //private ClientHandler ch;
        private Server server;
        //public delegate void updateViewModel(string Lon, string len);
        //public event updateViewModel FlightBoardData;

        //public LeftModel()
        //{
            //Server.Instance.dataEvent += getParametersFromServer;
        //}

        public void ConnectCommand()
        {
            new Task(() =>
            {
                Client.Instance.connect(ApplicationSettingsModel.Instance.FlightCommandPort, ApplicationSettingsModel.Instance.FlightServerIP);
            }).Start();
        }

        public void OpenServer()
        {
            //ch = new ClientHandler();
            //ch.dataEvent += getParametersFromServer;
            //server = new Server(ApplicationSettingsModel.Instance.FlightInfoPort, ApplicationSettingsModel.Instance.FlightServerIP, ch);
            server = Server.Instance;
            server.Start();
        }

        public void CloseConnection()
        {
            Server.Instance.Stop(); // closing the server
            Client.Instance.Close(); // closing the client
        }

        // public void getParametersFromServer(string[] args) {
        //     FlightBoardData?.Invoke(args[0], args[1]);    
        // }
    }
}
