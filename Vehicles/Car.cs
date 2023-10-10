namespace Garage1._0.Vehicles
{
    internal class Car : Vehicle
    {
        public string FuelType { get; set; }

        public Car(string color, int noOfWheels, string regNo, string fuelType) : base(color, noOfWheels, regNo)
        {
            FuelType = fuelType;
        }
        public override string ToString()
        {
            return $"{this.GetType().Name}\t\tReg.no:{RegNo}\tColor:{Color}\tNo of wheels:{NoOfWheels}\tFuel type:{FuelType}";
        }
    }
}
