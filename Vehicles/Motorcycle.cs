using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0.Vehicles
{
    internal class Motorcycle : Vehicle
    {
        public double CylinderVolume { get; set; }
        public Motorcycle(string color, int regNr, int weight, int wheel, double cylinderVolume) : base(color, regNr, weight, wheel)
        {
            CylinderVolume = cylinderVolume;
        }
    }
}
