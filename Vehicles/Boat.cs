namespace Garage1._0.Vehicles
{
    internal class Boat : Vehicle
    {
        public double Length { get; set; }
        public Boat(string color, string regNr, int wheels, double length):base(color, regNr, wheels) => Length = length;

        public override string ToString()
        {
            return base.ToString() + $"Length: {Length}";
        }
    }
}
