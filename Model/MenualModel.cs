using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FlightSimulator
{
    class MenualModel : IsenderModel
    {
        /// <summary>
        /// send commands via client.
        /// </summary>
        /// <param name="contenct">contain textbox commands</param>
        public void SendCommand(string path, string value)
        {
            if (Client.Instance.IsConnact)
            {
                // send massege to simulator with client.
                new Task(() =>
                {
                    Client.Instance.SendMsg(path, value);
                }).Start();
            }
        }
    }
}
