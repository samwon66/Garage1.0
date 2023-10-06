namespace Garage1._0.Vehicles
{
    internal class Bus : Vehicle
    {
        public int NumberOfSeats { get; set; }

        public Bus(string color, string regNr, double weight, int wheels, int numberOfSeats) : base(color, regNr, wheels)
        {
            NumberOfSeats = numberOfSeats;
        }

        public override string ToString()
        {
            return base.ToString() + $"Number of seats: {NumberOfSeats}";
        }

    }
}
