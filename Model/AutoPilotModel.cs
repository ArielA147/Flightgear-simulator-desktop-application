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
        /// <summary>
        /// send commands via client.
        /// </summary>
        /// <param name="contenct">contain textbox commands</param>
        public void SendCommands(string contenct)
        {
            if (Client.Instance.IsConnact)
            {
                string[] commands = contenct.Split('\n');
                // send massege to simulator with client.
                new Task(() =>
                {
                    Client.Instance.SendAutoPilotMassege(commands);
                }).Start();
            }
        }
    }
}
