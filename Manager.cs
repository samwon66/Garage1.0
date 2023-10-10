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
        private readonly IUI ui;
        private readonly IHandler handler;
        private bool inProgress;

        public Manager(IUI ui, IHandler handler)
        {
            this.ui = ui;
            this.handler = handler;
        }

        internal void Run()
        {
            Initialize();
            Start();
        }

        private void Start()
        {
            inProgress = true;

            do
            {
                string input = ui.GetStringInput(ShowMainMenu());
                switch (input)
                {
                    case "1":
                        break;

                    case "2":
                        break;

                    case "3":
                        break;

                    case "4":
                        break;

                    case "Q":
                        inProgress = false;
                        break;

                    default:
                        ui.Print("Please enter a valid input (1, 2, 3, 4, Q)");
                        break;
                }
            }
            while (inProgress);
        }

        private string ShowMainMenu()
        {
            return ("\nPlease choose what you want to do with your garage." +
                    "\n1. Park a vehicle" + 
                    "\n2. Unpark a vehicle" + 
                    "\n3. List all vehicles in the garage" + "" +
                    "\nQ. Quit");
        }

        private void Initialize()
        {
            ui.Print("Welcome to Garage1.0.");
            int capacity = ui.GetIntInput("How many parking slots do you need in your garage?");
            while (capacity <= 0)
            {
                capacity = ui.GetIntInput("Your garage needs to have at least one slot. Please try again!");
            }
            handler.CreateGarage(capacity);

            string answer = ui.GetStringInput("Do you want to fill your garage with some vehicles? (yes / no)");
            while (answer.ToLower() != "yes" && answer.ToLower() != "no")
            {
                answer = ui.GetStringInput("Invalid input, please try again!");
            }

            if (answer.ToLower() != "yes")
                handler.SeedData();
        }

        
    }
}
