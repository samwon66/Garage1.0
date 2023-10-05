using Garage1._0.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
    /// <summary>
    /// This class take care of all logic for handling the garage.
    /// </summary>
    internal class GarageHandler
    {
        
        
        public void InitVehicles()
        {
            Car car1 = new Car("white", "nbc432", 1.5, 4, "gas");
            Car car2 = new Car("black", "abc432", 1.2, 4, "gas");
            Car car3 = new Car("red", "bbc432", 1.4, 4, "diesel");
            Bus bus1 = new Bus("yellow", "vcm342", 2.5, 4, 30, 6.2);
            Motorcycle mc1 = new Motorcycle("black", "vms863", 0.9, 2, 0.8);
            Boat boat1 = new Boat("white", "fhj723", 2.1, 3, 7.8);
            Airplane airplane1 = new Airplane("silver", "koe034", 2.4, 3, 1, 6.1);
        }

        /// <summary>
        /// Fill the garage with vehicle.
        /// </summary>
        public void FillTheGarage() { }

        
    }
}
