using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0.Vehicles
{
    internal class Airplane : Vehicle
    {
        public int NumberOfEngines { get; set; }
        
        public Airplane(string color, int regNr, int weight, int wheel, int numberOfEngines) : base(color, regNr, weight, wheel)
        {
            NumberOfEngines = numberOfEngines;
        }
    }
}
