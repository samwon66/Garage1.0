using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0.UI
{
    public class ConsoleUI : IUI
    {
        public void Clear()
        {
            Console.Clear();
        }

        

        public string GetInput(string input)
        {
            throw new NotImplementedException();
        }

        public int GetInputByInt()
        {
            //int userEnter;
            //try
            //{
            //    if (userEnter != 0)
            //    {
            //        input = int.Parse(Console.ReadLine());
            //    }
            //}
            //catch(Exception) { Console.WriteLine("Wrong input"); }
            return 0;
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine(message); ;
        }

        public void Quit()
        {
            Environment.Exit(0);
        }

        public void Wait()
        {
            Console.ReadLine(); 
        }
    }
}
