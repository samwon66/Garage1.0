namespace Garage1._0.Vehicles
{
    internal class Motorcycle : Vehicle
    {
        public int CylinderVolume { get; set; }

        public Motorcycle(string color, int noOfWheels, string regNo, int cylinderVolume) : base(color, noOfWheels, regNo)
        {
            CylinderVolume = cylinderVolume;
        }

        public override string ToString()
        {
            return base.ToString() + "\tCylinder volume:" + CylinderVolume;
        }
    }
}
