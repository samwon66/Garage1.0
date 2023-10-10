using Garage1._0.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0.UI
{
    public class ConsoleUI : IUI
    {
        public string GetMenuKey()
        {
            //Console.Write(" ");
            return Console.ReadLine().ToUpper();
        }

        public void Pause()
        {
            Console.WriteLine(" ");
            Console.ReadLine();
        }

        public void PrintErrorMessage(string errorMessage)
        {
            Console.WriteLine(errorMessage); ;
        }

        public void PrintMainMenu()
        {
            Console.Clear();
            Console.WriteLine("MENU\n" +
                "1. Populate garage\n" +
                "2. Add a vehicle\n" +
                "3. Remove a vehicle\n" + 
                "Q. Quit");
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine(message); ;
        }

        public void PrintVehicle(IVehicle vehicle)
        {
            Console.WriteLine(vehicle.ToString()); ;
        }

        


    }
}
