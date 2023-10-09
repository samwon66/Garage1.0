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
        private IUI ui;
        private GarageHandler handler;
        private bool isRunning = true;


        internal Manager(IUI consoleUI)
        {
            ui = consoleUI;
        }

        internal void Run()
        {
            do
            {
                ui.PrintMainMenu();
                DoChoice();
                if(isRunning) 
                    ui.Pause();
            }
            while(isRunning);
        }
        
        internal void DoChoice()
        {
            string choice = GetMenuChoice();
            var menu = new Dictionary<string, Action>
            {
                { "1", AddRandomVehicles }, 
                { "2", AddAVehicle },
                { "3", RemoveAVehicle },
                { "Q", Quit }
            };
        }

        private void RemoveAVehicle()
        {
            throw new NotImplementedException();
        }

        private void AddAVehicle()
        {
            throw new NotImplementedException();
        }

        private void AddRandomVehicles()
        {
            ui.PrintMessage("\n Add a number of random vehicles.");
            int nrOfVehicle = GetPopulationSize();
            bool success = Populate(nrOfVehicle);
            if (success)
                ui.PrintMessage($" {nrOfVehicle} vehicles added.");
        }

        private bool Populate(int nrOfVehicle)
        {
            int nrAdded;
            nrAdded = handler.PopulateGarage(nrOfVehicle);
            if (nrAdded < nrOfVehicle)
            {
                ui.PrintErrorMessage($" {nrAdded} vehicles added. Garage is full.");
            }
            return nrAdded == nrOfVehicle;

        }

        private int GetPopulationSize()
        {
            int size;
            bool success;
            string errMsg = "";

            do
            {
                string input = ui.Prompt("How many vehicles? ");
                success = int.TryParse(input, out size);

                if (!success)
                    errMsg = "Input must be a number";
                if (success && (size == 0))
                {
                    errMsg = "Size must be greater than 0";
                    success = false;
                }
                if (success && (size > handler.GarageCapacity))
                {
                    errMsg = $" Size must not be greater than garage capacity {handler.GarageCapacity}";
                    success = false;
                }
                if (!success)
                    ui.PrintErrorMessage("Wrong input " + errMsg);
            }
            while (!success);

            return size;
        }

        private void Quit()
        {
            Environment.Exit(0);
        }

        private string GetMenuChoice()
        {
            string key;
            string errMsg ="";
            bool success;

            do
            {
                key = ui.GetMenuKey();
                if(key.ToUpper() == "Q")
                    return key.ToUpper();
                success = int.TryParse(key.ToString(), out int choice);
                if (!success)
                    errMsg = "You must enter a number.";
                if (success && (choice == 0))
                {
                    success = false;
                    errMsg = "You can not enter 0";
                }
                if (success && (choice > 7))
                {
                    success = false;
                    errMsg = "It must be less than 7";
                }
                if (!success)
                    ui.PrintErrorMessage("Wrong input "+ errMsg);
            }
            while (!success);

            return key;
        }
  
    }
}
