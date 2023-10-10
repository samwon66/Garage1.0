namespace Garage1._0.Vehicles
{
    internal class Bus : Vehicle
    {
        private uint nrOfSeats;

        public uint NrOfSeats
        {
            get { return nrOfSeats; }
        }

        internal Bus(string RegNum, uint NrOfwheels, uint NrOfSeats) : base(RegNum, NrOfwheels)
        {
            nrOfSeats = NrOfSeats;
        }


    }
}
