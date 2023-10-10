namespace Garage1._0.UI
{
    public class ConsoleUI : IUI
    {
        public string GetStringInput(string message)
        {
            string answer = string.Empty;
            bool success = false;

            do
            {
                Print($"{message} ");
                var input = Console.ReadLine()!.ToUpper();
                if (input != null)
                    answer = input;

                if (string.IsNullOrEmpty(answer))
                        Print($"You must enter a valid input. Please try again.");
                else
                    success = true;

            } while (!success);

            return answer!;
        }

        public int GetIntInput(string message)
        {
            bool isInt = false;
            int answer;
            do
            {
                string input = GetStringInput(message);

                isInt = int.TryParse(input, out answer);
                if (!isInt)
                    Print($"That was not a valid input. Please try again.");
            }
            while (isInt == false);

            return answer;
        }

        public void Print(string message)
        {
            Console.WriteLine(message);
        }

        public void PrintAddSuceed()
        {
            Console.WriteLine("Your vehicle was sucessfully parked in the garage!");
        }

        public void PrintPropertyMessage(string type, string color, int noOfWheels)  
        {
            Console.Clear();
            string text = "Here is the result from your search criteria \"All ";
            text += color == "X" ? "" : $"{color} ";
            text += type == "X" ? "vehicles " : $"{type}s ";
            text += noOfWheels == -1 ? "\".\n" : $"with {noOfWheels} wheels\"\n";
            Console.WriteLine(text);
        }

        public void Clear()
        {
            Console.Clear();
        }
    }
}
