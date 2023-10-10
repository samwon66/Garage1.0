namespace Garage1._0.Vehicles
{
    internal class Airplane : Vehicle
    {
        private uint nrOfEngines;

        public uint NrOfEngines
        {
            get { return nrOfEngines; }
            set { nrOfEngines = value; }
        }

        internal Airplane(string RegNum, uint NrOfwheels, uint NrOfEngines) : base(RegNum, NrOfwheels)
        {
            nrOfEngines = NrOfEngines;
        }
    }
}
