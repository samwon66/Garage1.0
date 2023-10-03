namespace Garage1._0.Vehicles
{
    internal class Boat : Vehicle
    {
        public double Length { get; set; }
        public Boat(string color, string regNr, double weight, int wheel, double length, int parkingSlot):base(color, regNr, weight, wheel, parkingSlot) => Length = length;
    }
}
