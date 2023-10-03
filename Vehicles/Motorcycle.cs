namespace Garage1._0.Vehicles
{
    internal class Motorcycle : Vehicle
    {
        public double CylinderVolume { get; set; }
        public Motorcycle(string color, int regNr, int weight, int wheel, int parkingSlot, double cylinderVolume) : base(color, regNr, weight, wheel, parkingSlot)
        => CylinderVolume = cylinderVolume;
    }
}
