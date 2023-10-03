namespace Garage1._0.Vehicles
{
    internal class Bus : Vehicle
    {
        public int NumberOfSeats { get; set; }
        public double Length { get; set; }
        public Bus(string color, string regNr, double weight, int wheel, int parkingSlot, int numberOfSeats, double length ) : base(color, regNr, weight, wheel, parkingSlot)
        {
            NumberOfSeats = numberOfSeats;
            Length = length;
        }

    }
}
