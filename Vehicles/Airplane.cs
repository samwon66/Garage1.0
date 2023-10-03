namespace Garage1._0.Vehicles
{
    internal class Airplane : Vehicle
    {
        public int NumberOfEngines { get; set; }
        public double Length { get; set; }

        public Airplane(string color, string regNr, double weight, int wheel, int parkingSlot, int numberOfEngines, double length) : base(color, regNr, weight, wheel, parkingSlot)
        {
            NumberOfEngines = numberOfEngines;
            Length = length;
        }

        
    }
}
