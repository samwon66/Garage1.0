using Garage1._0.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
    internal class Factory
    {
        public Garage<IVehicle> MakeGarage(uint Capacity)
        {
            return new Garage<IVehicle>(Capacity);
        }
    }
}
