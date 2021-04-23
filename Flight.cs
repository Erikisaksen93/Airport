using System;
using System.Collections.Generic;
using System.Text;

namespace Airport
{
    class Flight
    {
        public string Ident { get; private set; }
        public int FlightNumber { get; private set; }
        public int Seats { get; private set; }
        public Aircraft Aircraft { get; private set; }
        public List<Passenger> Passengers = new List<Passenger>();
    }
}
