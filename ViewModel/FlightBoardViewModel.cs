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
            // add function from this view model that listen to flightBoard model.
            model.FlightBoardData += updateFlightBoardData;
        }

        // define Lon and Len Properties
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

        // change value of lon and len according to data that receive from model.
        public void updateFlightBoardData(string ValueLon, string ValueLat)
        {
            Lon = Convert.ToDouble(ValueLon);
            Lat = Convert.ToDouble(ValueLat);
        }
    }
}
