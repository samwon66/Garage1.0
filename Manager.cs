using Garage1._0.UI;
using Garage1._0.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
    
    internal class Manager
    {
        private IUI ui = new ConsoleUI();
  
        internal void Run()
        {
            do
            {
                DisplayMenu();
                int choice = int.Parse(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        CreatGarage();
                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    case 0:
                        ui.Quit();
                        break;

                    default:
                        break;

                }
            }
            while (true);


        }

        private void DisplayMenu()
        {
             ui.Clear();
             ui.PrintMessage("Welcome to my garage!");
             ui.PrintMessage("Navigate through the menu by entering the number of choice.");
             ui.PrintMessage("1. Create a new garage.");
             ui.PrintMessage("2. Add a vehicle to the garage.");
             ui.PrintMessage("3. Remove a vehicle from the garage.");
             ui.PrintMessage("4. List all the vehicle in the garage.");
             ui.PrintMessage("0. Quit");
             ui.Wait();
            
        }

        private void CreatGarage()
        {
            ui.PrintMessage("How many parkingslots does your new garage has?");
            ui.Wait();
            int size = Convert.ToInt32(Console.ReadLine());
            GarageHandler handler = new GarageHandler(size);

        }

  
    }
}
