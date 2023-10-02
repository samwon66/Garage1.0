namespace Garage1._0.Vehicles
{
    internal class Vehicle
    {
        public string Color { get; set; }
        public int RegNr { get; set; }
        public int Weight { get; set; }
        public int Wheel { get; set; }

        public Vehicle(string color, int regNr, int weight, int wheel) 
        {
            Color = color;
            RegNr = regNr;
            Weight = weight;
            Wheel = wheel;
        }

    }
}
