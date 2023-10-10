using Garage1._0.UI;

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
                        ParkVehicle();
                        break;

                    case "2":
                        UnParkVehicle();
                        break;

                    case "3":
                        ListVehicles();
                        break;

                    case "4":
                        ListVehicleTypesAndAmount();
                        break;

                    case "5":
                        FindByRegNo();
                        break;

                    case "6":
                        FindByProperties();
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

        private void FindByProperties()
        {
            throw new NotImplementedException();
        }

        private void FindByRegNo()
        {
            throw new NotImplementedException();
        }

        private void ListVehicleTypesAndAmount()
        {
            throw new NotImplementedException();
        }

        private void UnParkVehicle()
        {
            if (handler.CheckIfEmptyGarage() == true) 
            {
                ui.Print("Sorry, the garage is empty.");
                return;
            }

            ui.Print("Which vehicle in the list you want to unpark? ");
            string vehiclesInGarage = handler.ListAllVehiclesInGarage();
            ui.Print(vehiclesInGarage);
            int inputNumber = ui.GetIntInput("");

            while (inputNumber <= 0 || inputNumber > handler.GetNoOfVehiclesParked())
            {
                ui.Print("That was an invalid input, please try again with a valid number.");
                inputNumber = ui.GetIntInput("");
            }

            if (handler.UnparkVehicle(inputNumber - 1) == true)
                ui.Print("Your vehicle was unparked.");
        }

        private void ParkVehicle()
        {
            bool isFull = handler.CheckIfFullGarage();
            if (isFull)
            {
                ui.Print("Sorry, your garage is already full.");
                return;
            }
            {
                int validVehicle = 5;
                int vehicleType = ui.GetIntInput("Select the type of vehicle you want to park : (1, 2, 3, 4, 5)" 
                    + "\n1. Airplane" 
                    + "\n2. Boat" 
                    + "\n3. Bus" 
                    + "\n4. Car" 
                    + "\n5. Motorcycle");

                while (vehicleType <= 0 || vehicleType > validVehicle)
                {
                    ui.Print("That was a invalid type of vehicle, please try again. (1,2,3,4,5)");
                    vehicleType = ui.GetIntInput("");
                }

                string color = ui.GetStringInput("Color: ");
                int noOfWheels = ui.GetIntInput("Numbers of wheels: ");
                while (noOfWheels < 0)
                {
                    noOfWheels = ui.GetIntInput("Number of wheels can not be negative, please try again.");
                }

                string regNo;
                bool isExisting = false;
                do
                {
                    regNo = ui.GetStringInput("Reg. number: ");
                    if (handler.CheckRegNoBeforeAdding(regNo) == true)
                    {
                        ui.Print("The reg. number already exists. Please try again.");
                        isExisting = true;
                    }
                    else
                        isExisting = false;
                }
                while (isExisting);

                switch (vehicleType)
                {
                    case 1:
                        int noOfEngines = ui.GetIntInput("Number of engines: ");

                        if (handler.ParkAirplane(color, noOfWheels, regNo, noOfEngines) == true)
                            ui.PrintAddSuceed();
                        break;

                    case 2:
                        int length = ui.GetIntInput("Length: ");

                        if (handler.ParkBoat(color, noOfWheels, regNo, length) == true)
                            ui.PrintAddSuceed();
                        break;

                    case 3:
                        int noOfSeats = ui.GetIntInput("Number of seats: ");

                        if (handler.ParkBus(color, noOfWheels, regNo, noOfSeats) == true)
                            ui.PrintAddSuceed();
                        break;

                    case 4:
                        string fuelType = ui.GetStringInput("Fuel type?: ");

                        if (handler.ParkCar(color, noOfWheels, regNo, fuelType) == true)
                            ui.PrintAddSuceed();
                        break;

                    case 5:
                        int cylinderVolume = ui.GetIntInput("Cylinder volume: ");

                        if (handler.ParkMotorcycle(color, noOfWheels, regNo, cylinderVolume) == true)
                            ui.PrintAddSuceed();
                        break;

                    default:
                        ui.Print("Please enter some valid input (1, 2, 3, 4, 5");
                        break;
                }

            }
        }

        private void ListVehicles()
        {
            ui.Print("\nHere are the vehicles you have parked in the garage now.");
            string vehiclesInGarage = handler.ListAllVehiclesInGarage();
            ui.Print(vehiclesInGarage);
            ui.Print($"Number of empty parking spaces left in your garage is {handler.GetNoOfSpacesLeft()}\n");
        }

        private string ShowMainMenu()
        {
            return ("\nPlease choose what you want to do with your garage." +
                    "\n1. Park a vehicle" + 
                    "\n2. Unpark a vehicle" + 
                    "\n3. List all vehicles in the garage" + 
                    "\n4. List vehicle types and amount" + 
                    "\n5. Find a vehicle by registration number" + 
                    "\n6. Find vehicle by one or more properties" +
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
