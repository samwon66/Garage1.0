using Garage1._0.UI;
using Garage1._0.Vehicles;

namespace Garage1._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager(new ConsoleUI(), new GarageHandler());
            manager.Run();


        }
    }
}