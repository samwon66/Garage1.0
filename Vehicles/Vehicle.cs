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
        /// Get the chosen data of a vehicle
        /// </summary>
        /// <param name="vehicle"></param>
        /// <returns>Type, Regnr and color of vehicle</returns>
        public virtual string Data(Vehicle vehicle)
        {
            return $"******************\nType: {vehicle.GetType().Name}\nRegNr: {vehicle.RegNr}\nColor: {vehicle.Color}\n******************";
        }

        
    }
}
