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

        internal bool PopulateGarage()
        {
            return true;
        }

        internal  bool AddCar(string color, string regNr, int wheels, string fuelType)
        {
            bool success = false;
            Car car = new Car(color, regNr.ToUpper(), wheels, fuelType);
            if (ValidateRegNr(regNr))
                success = garage.AddVehicle(car);

            return success;
        }

        private bool ValidateRegNr(string regNr)
        {
            if (string.IsNullOrEmpty(regNr) || regNr.Length != 6 || regNr.Contains(" "))
                return false;
            string regNumbers = regNr.Substring(3,3);
            if (!int.TryParse(regNr.Substring(3, 3), out _) ||
                int.TryParse(regNr.Substring(3, 0), out _) ||
                int.TryParse(regNr.Substring(1, 1), out _) ||
                int.TryParse(regNr.Substring(2, 1), out _))
                return false;
            foreach (var vehicle in garage)
                if (vehicle != null)
                    if (vehicle.RegNr == regNr)
                        return false;

            return true;
        }
    }
}
