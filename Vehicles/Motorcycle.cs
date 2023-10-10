namespace Garage1._0.Vehicles
{
    internal class Motorcycle : Vehicle
    {
        private double cylinderVolume;

        public double CylinderVolume
        {
            get { return cylinderVolume; }
        }

        internal Motorcycle(string RegNum, uint NrOfwheels, double CylinderVolume) : base(RegNum, NrOfwheels)
        {
            cylinderVolume = CylinderVolume;
        }
    }
}
