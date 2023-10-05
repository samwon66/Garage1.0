namespace Garage1._0.Vehicles
{
    internal class Boat : Vehicle
    {
        public double Length { get; set; }
        public Boat(string color, string regNr, double weight, int wheel, double length):base(color, regNr, weight, wheel) => Length = length;

        public override string ToString()
        {
            return base.ToString() + $"Length: {Length}";
        }
    }
}
