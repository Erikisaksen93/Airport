using System;
using System.Collections.Generic;
using System.Text;

namespace Airport
{
    class Passenger
    {
        public string FirstName { get; private set; }
        public string SurName { get; private set; }
        public List<Bag> Bags = new List<Bag>();

    }
}
