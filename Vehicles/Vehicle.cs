namespace Garage1._0.Vehicles
{
    internal class Vehicle : IVehicle
    {
        public string Color { get; set; }
        public int NoOfWheels { get; set; }

        public string RegNo { get; set; }


        public Vehicle(string color, int noOfWheels, string regNo)
        {
            this.Color = color;
            this.NoOfWheels = noOfWheels;
            this.RegNo = regNo;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}\tReg.no:{RegNo}\tColor:{Color}\tNo of wheels:{NoOfWheels}";
        }




    }
}
