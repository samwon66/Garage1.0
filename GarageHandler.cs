using Garage1._0.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
    
    internal class GarageHandler
    {
        private Garage<Vehicle> garage;

        public GarageHandler(int capacity)
        {
            garage = new Garage<Vehicle>(capacity);
        }

        internal void AddVehicle(Vehicle vehicle)
        {
            garage.Park(vehicle);
        }

        internal void RemoveVehicle(string regNr)
        {
            garage.RemoveVehicle(regNr);
        }
    }
}
