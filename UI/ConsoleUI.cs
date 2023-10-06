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

        

        public string GetInputInString(string userInput)
        {
            userInput = Console.ReadLine();
            if(userInput == "" || userInput == " ")
            {
                PrintMessage("You must enter something.");
            }
            return userInput;
        }

        public int GetInputInInt(string input)
        {
            bool isCorrect = false;
            int inputInInteger;
            do
            {
                //string answer = GetInputinString(input);
                isCorrect = int.TryParse(GetInputInString(input), out inputInInteger);
                if(!isCorrect ) { PrintMessage("Please enter a number."); }
            }
            while (!isCorrect);
            return inputInInteger;
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
