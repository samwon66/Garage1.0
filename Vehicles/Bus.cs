using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0.Vehicles
{
    internal class Bus : Vehicle
    {
        public int NumberOfSeats { get; set; }
        public Bus(string color, int regNr, int weight, int wheel, int numberOfSeats) : base(color, regNr, weight, wheel)
        {
            NumberOfSeats = numberOfSeats;
        }
    }
}
