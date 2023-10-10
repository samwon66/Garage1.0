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
            throw new NotImplementedException();
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
