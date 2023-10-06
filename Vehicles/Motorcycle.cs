namespace Garage1._0.Vehicles
{
    internal class Motorcycle : Vehicle
    {
        public double CylinderVolume { get; set; }
        public Motorcycle(string color, string regNr, int wheels, double cylinderVolume) : base(color, regNr, wheels)
        => CylinderVolume = cylinderVolume;

        public override string ToString()
        {
            return base.ToString() + $"Cylinder volyme: {CylinderVolume}";
        }
    }
}
