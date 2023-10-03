namespace Garage1._0.Vehicles
{
    internal class Car : Vehicle
    {
        public string FuelType { get; set; }
        public Car(string color, string regNr, double weight, int wheel, int parkingSlot, string fuelType) : base(color, regNr, weight, wheel, parkingSlot) => FuelType = fuelType;
    }
}
