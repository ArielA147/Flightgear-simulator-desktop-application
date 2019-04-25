using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSimulator
{
    class AutoPilotModel
    {
        public void SendCommands(string contenct)
        {
            if (Client.Instance.IsConnact)
            {
                string[] commands = contenct.Split('\n');
                new Task(() =>
                {
                    Client.Instance.SendAutoPilotMassege(commands);
                }).Start();
            }
        }
    }
}
