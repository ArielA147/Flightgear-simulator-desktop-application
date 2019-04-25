using FlightSimulator.ViewModels;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSimulator.Model.EventArgs
{
    public class VirtualJoystickEventArgs : BaseNotify
    {
        private double aileron;
        public double Aileron {
            get { return aileron; }
            set
            {
                aileron = value;
                if (aileron < -1)
                    aileron = -1;
                else if(aileron > 1)
                    aileron = 1;
                if (Client.Instance.IsConnact)
                    Client.Instance.SendMsg("/controls/flight/aileron", Convert.ToString(value));
            }
        }
        private double elevator;
        public double Elevator {
            get { return elevator; }
            set
            {
                elevator = value;
                if (elevator < -1)
                    elevator = -1;
                else if (elevator > 1)
                    elevator = 1;
                if (Client.Instance.IsConnact)
                    Client.Instance.SendMsg("/controls/flight/elevator", Convert.ToString(value));
            }
        }
    }
}
