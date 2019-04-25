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
        public void SendCommand(string path, string value)
        {
            if (Client.Instance.IsConnact)
            {
                new Task(() =>
                {
                    Client.Instance.SendMsg(path, value);
                }).Start();
            }
        }
    }
}
