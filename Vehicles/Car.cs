namespace Garage1._0.Vehicles
{
    internal class Car : Vehicle
    {
        private string fuelType;

        public string FuelType
        {
            get { return fuelType; }
        }

        public Car(string RegNum, uint NrOfwheels, string FuelType) : base(RegNum, NrOfwheels)
        {
            fuelType = FuelType;
        }
    }
}
