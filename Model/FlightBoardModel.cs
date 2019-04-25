using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSimulator.ViewModels
{
    class FlightBoardModel
    {
        public delegate void updateViewModel(string Lon, string Lat);
        public event updateViewModel FlightBoardData;
        
        public FlightBoardModel()
        {
            Server.Instance.dataEvent += getParametersFromServer;
        }

        public void getParametersFromServer(string[] args)
        {
            FlightBoardData?.Invoke(args[0], args[1]);
        }

    }
}
