using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSimulator
{
    interface IsenderModel
    {
        void SendCommand(string path, string value);
    }
}
