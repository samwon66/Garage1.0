namespace Garage1._0.Vehicles
{
    internal class Boat : Vehicle
    {
        
            private double lenght;

            public double Lenght
            {
                get { return lenght; }
                set { lenght = value; }
            }

            internal Boat(string RegNum, uint NrOfwheels, double Lenght) : base(RegNum, NrOfwheels)
            {
                lenght = Lenght;
            }

        
    }
}
