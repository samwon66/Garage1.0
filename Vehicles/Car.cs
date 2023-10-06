namespace Garage1._0.Vehicles
{
    internal class Car : Vehicle
    {
        public string FuelType { get; set; }
        public Car(string color, string regNr, int wheels, string fuelType) : base(color, regNr, wheels) => FuelType = fuelType;

        public override string ToString()
        {
            return base.ToString() + $"Fuel: {FuelType}";
        }
    }
}
