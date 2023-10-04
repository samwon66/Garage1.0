﻿namespace Garage1._0.Vehicles
{
    internal class Motorcycle : Vehicle
    {
        public double CylinderVolume { get; set; }
        public Motorcycle(string color, string regNr, double weight, int wheel, int parkingSlot, double cylinderVolume) : base(color, regNr, weight, wheel, parkingSlot)
        => CylinderVolume = cylinderVolume;

        public override string ToString()
        {
            return base.ToString() + $"Cylinder volyme: {CylinderVolume}";
        }
    }
}
