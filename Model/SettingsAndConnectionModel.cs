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
        private Server server;
        public void ConnectCommand()
        {
            // connect the client in seperate thread.
            new Task(() =>
            {
                Client.Instance.connect(ApplicationSettingsModel.Instance.FlightCommandPort, ApplicationSettingsModel.Instance.FlightServerIP);
            }).Start();
        }

        public void OpenServer()
        {
            server = Server.Instance;
            server.Start();
        }

        public void CloseConnection()
        {
            Server.Instance.Stop(); // closing the server
            Client.Instance.Close(); // closing the client
        }

    }
}
