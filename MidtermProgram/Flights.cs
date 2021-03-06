using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProgram
{
    class Flights
    {
        private int _ID;
        private int _airlineID;
        private string _departureCity;
        private string _destinationCity;
        private string _departureDate;
        private double _flightTime;
     

        public Flights(int id, int airlineID, string deptCity, string destCity, string deptDT, double flightTime)
        {
            ID = id;
            AirlineID = airlineID;
            DepartureCity = deptCity;
            DestinationCity = destCity;
            DepartureDate = deptDT;
            FlightTime = flightTime;
        }

        
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public int AirlineID
        {
            get { return _airlineID; }
            set { _airlineID = value; }
        }

        public string DepartureCity
        {
            get { return _departureCity; }
            set { _departureCity = value; }
        }

        public string DestinationCity
        {
            get { return _destinationCity; }
            set { _destinationCity = value; }
        }
        public string DepartureDate
        {
            get { return _departureDate; }
            set { _departureDate = value; }
        }
        public double FlightTime
        {
            get { return _flightTime; }
            set { _flightTime = value; }
        }
    }
}
