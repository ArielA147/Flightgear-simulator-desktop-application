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
        /// <summary>
        /// define a delegate that get lon and let params from server.
        /// </summary>
        /// <param name="Lon">lon parameter</param>
        /// <param name="Lat">len parameter</param>
        public delegate void updateViewModel(string Lon, string Lat);
        public event updateViewModel FlightBoardData;
        
        public FlightBoardModel()
        {
            // add model function as listener to server input parameters.
            Server.Instance.dataEvent += getParametersFromServer;
        }

        public void getParametersFromServer(string[] args)
        {
            // pass arguments to view model.
            FlightBoardData?.Invoke(args[0], args[1]);
        }

    }
}
