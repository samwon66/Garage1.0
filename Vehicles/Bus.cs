namespace Garage1._0.Vehicles
{
    internal class Bus : Vehicle
    {
        public int NumberOfSeats { get; set; }
        public int Length { get; set; }
        public Bus(string color, int regNr, int weight, int wheel, int parkingSlot, int numberOfSeats, int length ) : base(color, regNr, weight, wheel, parkingSlot)
        {
            NumberOfSeats = numberOfSeats;
            Length = length;
        }

    }
}
