namespace Garage1._0
{
    /// <summary>
    /// This class handle all the interface for user.
    /// </summary>
    public class UI
    {
        public void Print(string message) 
        {  
            Console.WriteLine(message); 
        }
        public string Read(string input) 
        { 
            if (input == null)
            {
                return $"You must entered some input.";
            }
            else 
               return Console.ReadLine(); 
        }
    }
}
