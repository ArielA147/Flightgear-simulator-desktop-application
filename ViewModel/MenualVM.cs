using FlightSimulator.Model;
using FlightSimulator.Model.Interface;
using FlightSimulator.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;

namespace FlightSimulator
{
    class MenualVM : BaseNotify
    {
        private IsenderModel model;

        public MenualVM()
        {
            model = new MenualModel();
        }
        /*
        private double aileron;
        public double Aileron
        {
            get { return aileron; }
            set
            {
                aileron = value;
                if (aileron < -1)
                    aileron = -1;
                else if (aileron > 1)
                    aileron = 1;
                model.SendCommand("/controls/flight/aileron", Convert.ToString(value));
            }
        }
        private double elevator;
        public double Elevator
        {
            get { return elevator; }
            set
            {
                elevator = value;
                if (elevator < -1)
                    elevator = -1;
                else if (elevator > 1)
                    elevator = 1;
                model.SendCommand("/controls/flight/elevator", Convert.ToString(value));
            }
        }
        */


       // private double rudder;
        public double Rudder
        {
            set
            {
                model.SendCommand("/controls/flight/rudder", Convert.ToString(value));  
            }
        }

       // private double throttle;
        public double Throttle
        {
            set
            {
                model.SendCommand("/controls/engines/current-engine/throttle", Convert.ToString(value));
            }
        }
    }
}
