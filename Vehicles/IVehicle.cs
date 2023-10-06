using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0.Vehicles
{
    internal interface IVehicle
    {
        public string RegNr { get; set; }
        public string Color { get; set; }
        public int Wheels { get; set; }
    }
}
