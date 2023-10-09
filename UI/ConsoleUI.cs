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
            Console.Write(" ");
            return Console.ReadKey(intercept: true).KeyChar.ToString();
        }

        public void Pause()
        {
            Console.WriteLine(" ");
            Console.ReadKey(intercept: true);
        }

        public void PrintErrorMessage(string errorMessage)
        {
            throw new NotImplementedException();
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

        public void PrintMessage(string Message)
        {
            throw new NotImplementedException();
        }

        public void PrintSetupMessage()
        {
            throw new NotImplementedException();
        }

        public void PrintVehicle(IVehicle vehicle)
        {
            throw new NotImplementedException();
        }

        public string Prompt(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();

        }

        
    }
}
