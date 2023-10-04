using Garage1._0.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
    internal interface IHandler
    {
        public void VehicleCheckIn() { }

        public void VehicleCheckOut() { }

        public void ListAllVehicle() { }
        public void ListAmountOfEachTypeVehicle() { }

        public void FindVehicle() { }

        public void TrackVehicleByRegNr() { }

        public void KeepCountingSlots() { }
    }
}
