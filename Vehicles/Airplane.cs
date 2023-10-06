namespace Garage1._0.Vehicles
{
    internal class Airplane : Vehicle
    {
        public int NumberOfEngines { get; set; }

        public Airplane(string color, string regNr, int wheels, int numberOfEngines) : base(color, regNr, wheels)
        {
            NumberOfEngines = numberOfEngines;
        }

        public override string ToString()
        {
            return base.ToString() + $"Number of engines: {NumberOfEngines}";
        }
    }
}
