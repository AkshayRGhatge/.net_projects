using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermProgram
{
    class Passenger
    {
        private int _ID;
        private int _customerID;
        private int _flightID;
        


        public Passenger(int id,int custID,int fID)
        {
            ID = id;
            CustomerID = custID;
            FlightID=fID;
            
        }

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public int CustomerID
        {
            get { return _customerID; }
            set { _customerID = value; }
        }

        public int FlightID
        {
            get { return _flightID; }
            set { _flightID = value; }
        }

        public Passenger()
        {

        }

    }
}
