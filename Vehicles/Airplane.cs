namespace Garage1._0.Vehicles
{
    internal class Airplane : Vehicle
    {
        public int NumberOfEngines { get; set; }

        public Airplane(string color, int noOfWheels, string regNo, int numberOfEngines) : base(color, noOfWheels, regNo)
        {
            NumberOfEngines = numberOfEngines;
        }

        public override string ToString()
        {
            return base.ToString() + "\tNo of engines:" + NumberOfEngines;
        }
    }
}
