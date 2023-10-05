namespace Garage1._0.Vehicles
{
    internal class Vehicle
    {
        public string Color { get; set; }
        public string RegNr { get; set; }
        public double Weight { get; set; }
        public int Wheel { get; set; }

        public Vehicle(string color, string regNr, double weight, int wheel)
        {
            Color = color;
            RegNr = regNr;
            Weight = weight;
            Wheel = wheel;
        }

        public override string ToString()
        {
            return $"RegNumber: {RegNr}, Color: {Color}, Weigh: {Weight}, Wheel: {Wheel}";
        }



    }
}
