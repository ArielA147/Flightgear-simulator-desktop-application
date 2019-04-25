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
