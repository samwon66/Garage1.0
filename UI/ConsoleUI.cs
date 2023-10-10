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
        public void DrawList(IVehicle[] vehicles)
        {
            throw new NotImplementedException();
        }

        public void DrawMainMenu()
        {
            Console.Clear();
            Console.WriteLine("\n Garage menu:\n" +
                " -----------------------------\n" +
                " 1. Populate garage\n" +
                " 2. Add a vehicle\n" +
                " 3. Remove a vehicle\n" +
                " 4. Show a vehicles properties\n" +
                " 5. List all vehicles\n" +
                " 6. Show garage statistics\n" +
                " 7. Query vehicles\n" +
                " Q. Quit");
        }

        public void DrawSetupMessage()
        {
            throw new NotImplementedException();
        }

        public string GetMenuKey()
        {
            Console.Write(" ");
            string key = Console.ReadKey(intercept: true).KeyChar.ToString();
            return key;
        }

        public void Pause()
        {
            Console.Write(" ");
            Console.ReadKey(intercept: true);
        }

        public string Prompt(string Message)
        {
            Console.Write(Message);
            return Console.ReadLine();
        }

        public void ShowErrorMessage(string errorMessage)
        {
            Console.WriteLine(errorMessage);
            Console.Write(" ");
        }

        public void WriteCapacity(uint Capacity, uint Ocupied, uint Available)
        {
            throw new NotImplementedException();
        }

        public void WriteMessage(string Message)
        {
            Console.WriteLine(Message);
        }

        public void WriteTypeCount((Type, uint)[] typeCounts)
        {
            throw new NotImplementedException();
        }

        public void WriteVehicle(IVehicle vehicle)
        {
            throw new NotImplementedException();
        }
    }
}
