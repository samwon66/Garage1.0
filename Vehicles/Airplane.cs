namespace Garage1._0.Vehicles
{
    internal class Airplane : Vehicle
    {
        public int NumberOfEngines { get; set; }
        public int Length { get; set; }

        public Airplane(string color, int regNr, int weight, int wheel, int parkingSlot, int numberOfEngines, int length) : base(color, regNr, weight, wheel, parkingSlot)
        {
            NumberOfEngines = numberOfEngines;
            Length = length;
        }

        
    }
}
