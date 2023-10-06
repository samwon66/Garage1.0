namespace Garage1._0.Vehicles
{
    internal class Vehicle : IVehicle
    {
        public string Color { get; set; }
        public string RegNr { get; set; }
        public int Wheels { get; set; }

        public Vehicle(string color, string regNr, int wheels)
        {
            Color = color;
            RegNr = regNr;
            Wheels = wheels;
        }

        public override string ToString()
        {
            return $"RegNumber: {RegNr}, Color: {Color}, Wheel: {Wheels}";
        }



    }
}
