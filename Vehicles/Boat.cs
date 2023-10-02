using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0.Vehicles
{
    internal class Boat : Vehicle
    {
        public int Length { get; set; }
        public Boat(string color, int regNr, int weight, int wheel, int length) : base(color, regNr, weight, wheel)
        {
            Length = length;
        }
    }
}
