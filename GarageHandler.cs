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
        private IGarage<IVehicle> garage;
        private int garageCapacity;

        public int GarageCapacity 
        { 
            get { return garageCapacity; }
            set { garageCapacity = value; }
        }

        public GarageHandler(int NrOfParkingSlots) 
        {
            garage = new Garage<IVehicle>(NrOfParkingSlots);
            garageCapacity = NrOfParkingSlots;
        }
    }
}
