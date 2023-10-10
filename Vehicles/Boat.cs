namespace Garage1._0.Vehicles
{
    internal class Boat : Vehicle
    {

        public int Length { get; set; }

        public Boat(string color, int noOfWheels, string regNo, int length) : base(color, noOfWheels, regNo)
        {
            Length = length;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}\t\tReg.no:{RegNo}\tColor:{Color}\tNo of wheels:{NoOfWheels}\tLength:{Length}";
        }


    }
}
