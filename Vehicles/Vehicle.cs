namespace Garage1._0.Vehicles
{
    internal class Vehicle
    {
        public string Color { get; set; }
        public string RegNr { get; set; }
        public double Weight { get; set; }
        public int Wheel { get; set; }
        public int ParkingSlot { get; set; }

        public Vehicle(string color, string regNr, double weight, int wheel, int parkingSlot)
        {
            Color = color;
            RegNr = regNr;
            Weight = weight;
            Wheel = wheel;
            ParkingSlot = parkingSlot;
        }

        /// <summary>
        /// Get all the data of a vehicle
        /// </summary>
        /// <param name="vehicle"></param>
        /// <returns>a string of the data of vehicle</returns>
        public string Data(Vehicle vehicle)
        {
            return string.Empty;
        }

        /// <summary>
        /// Get the registration number of the vhicle
        /// </summary>
        /// <param name="vehicle"></param>
        /// <returns>registration number</returns>
        public string GetRegNr(Vehicle vehicle)
        {
            return string.Empty;
        }

    }
}
