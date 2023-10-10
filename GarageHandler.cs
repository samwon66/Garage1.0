using Garage1._0.Vehicles;

namespace Garage1._0
{

    internal class GarageHandler : IHandler
    {
        public Garage<Vehicle> garage = null!;

        public GarageHandler() { }
        
        public bool CheckIfEmptyGarage()
        {
            return (garage.NoOfVehiclesParked == 0)? true : false;
        }

        public bool CheckIfFullGarage()
        {
            return (garage.IsFull == true)? true : false;
        }

        public bool CheckRegNoBeforeAdding(string inputRegNo)
        {
            throw new NotImplementedException();
        }

        public void CreateGarage(int capacity)
        {
            Garage<Vehicle> garage = new Garage<Vehicle>(capacity);
            this.garage = garage;
        }

        public string FindByProperty(string type, string color, int noOfWheels)
        {
            throw new NotImplementedException();
        }

        public string FindVehicleByRegNo(string inputRegNo)
        {
            throw new NotImplementedException();
        }

        public string GetNoOfEachType()
        {
            throw new NotImplementedException();
        }

        public int GetNoOfSpacesLeft()
        {
            throw new NotImplementedException();
        }

        public int GetNoOfVehiclesParked()
        {
            throw new NotImplementedException();
        }

        public string ListAllVehiclesInGarage()
        {
            throw new NotImplementedException();
        }

        public bool ParkAirplane(string color, int noOfWheels, string regNo, int numberOfEngines)
        {
            Airplane airplane = new Airplane(color, noOfWheels, regNo, numberOfEngines);
            if (garage.Add(airplane) == true)
                return true;
            else 
                return false;
        }

        public bool ParkBoat(string color, int noOfWheels, string regNo, int length)
        {
            Boat boat = new Boat(color, noOfWheels, regNo, length);
            if (garage.Add(boat) == true)
                return true;
            else 
                return false;
        }

        public bool ParkBus(string color, int noOfWheels, string regNo, int noOfSeats)
        {
            Bus bus = new Bus(color, noOfWheels, regNo, noOfSeats);
            if (garage.Add(bus) == true)
                return true;
            else 
                return false;
        }

        public bool ParkCar(string color, int noOfWheels, string regNo, string fuelType)
        {
            Car car = new Car(color, noOfWheels, regNo, fuelType);
            if (garage.Add(car) == true)
                return true;
            else 
                return false;
        }

        public bool ParkMotorcycle(string color, int noOfWheels, string regNo, int cylinderVolume)
        {
            Motorcycle motorcycle = new Motorcycle(color, noOfWheels, regNo, cylinderVolume);
            if (garage.Add(motorcycle) == true)
                return true;
            else 
                return false;
        }

        public void SeedData()
        {
            ParkBoat(color: "white", noOfWheels: 0, regNo: "SEA0101", length: 32);
            ParkAirplane(color: "red", noOfWheels: 3, regNo: "SKY123", numberOfEngines: 2);
            ParkMotorcycle(color: "black", noOfWheels: 3, regNo: "ACC900", cylinderVolume: 1000);
            ParkBoat(color: "red", noOfWheels: 0, regNo: "SEA002", length: 25);
            ParkCar(color: "white", noOfWheels: 4, regNo: "CAR001", fuelType: "diesel");
            ParkAirplane(color: "black", noOfWheels: 3, regNo: "SKY222", numberOfEngines: 1);
            ParkBus(color: "green", noOfWheels: 4, regNo: "BUS001", noOfSeats: 40);
            ParkMotorcycle(color: "yellow", noOfWheels: 2, regNo: "ACC800", cylinderVolume: 850);
            ParkCar(color: "red", noOfWheels: 4, regNo: "XGA492", fuelType: "gasoline");
            ParkCar(color: "black", noOfWheels: 4, regNo: "CAR002", fuelType: "electric");
            ParkBus(color: "yellow", noOfWheels: 4, regNo: "BUS002", noOfSeats: 50);
            ParkMotorcycle(color: "yellow", noOfWheels: 3, regNo: "ACC700", cylinderVolume: 900);
        }

        public bool UnparkVehicle(int index)
        {
            throw new NotImplementedException();
        }
    }
}
