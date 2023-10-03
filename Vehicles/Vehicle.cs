namespace Garage1._0.Vehicles
{
    internal abstract class Vehicle
    {
        public string Color { get; set; }
        public int RegNr { get; set; }
        public int Weight { get; set; }
        public int Wheel { get; set; }
        public int ParkingSlot { get; set; }

        public Vehicle(string color, int regNr, int weight, int wheel, int parkingSlot)
        {
            Color = color;
            RegNr = regNr;
            Weight = weight;
            Wheel = wheel;
            ParkingSlot = parkingSlot;
        }

    }
}
