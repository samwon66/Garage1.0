namespace Garage1._0.Vehicles
{
    internal class Bus : Vehicle
    {
        public int NumberOfSeats { get; set; }

        public Bus(string color, int noOfWheels, string regNo, int numberOfSeats) : base(color, noOfWheels, regNo)
        {
            NumberOfSeats = numberOfSeats;
        }
        public override string ToString()
        {
            return $"{this.GetType().Name}\t\tReg.no:{RegNo}\tColor:{Color}\tNo of wheels:{NoOfWheels}\tNo of seats:{NumberOfSeats}";
        }


    }
}
