using FlightSimulator.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSimulator.ViewModels
{
    public class FlightBoardViewModel : BaseNotify
    {
        private FlightBoardModel model;
        public FlightBoardViewModel()
        {
            model = new FlightBoardModel();
            model.FlightBoardData += updateFlightBoardData;
        }

        private double lon;
        public double Lon
        {
            get { return lon; }
            set
            {
                lon = value;
                NotifyPropertyChanged("Lon");
            }
        }

        private double lat;
        public double Lat
        {
            get { return lat; }
            set
            {
                lat = value;
                NotifyPropertyChanged("Lat");
            }
        }

        public void updateFlightBoardData(string ValueLon, string ValueLat)
        {
            Lon = Convert.ToDouble(ValueLon);
            Lat = Convert.ToDouble(ValueLat);
        }
    }
}
