using Garage1._0.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            throw new NotImplementedException();
        }

        public bool ParkBoat(string color, int noOfWheels, string regNo, int length)
        {
            throw new NotImplementedException();
        }

        public bool ParkBus(string color, int noOfWheels, string regNo, int noOfSeats)
        {
            throw new NotImplementedException();
        }

        public bool ParkCar(string color, int noOfWheels, string regNo, string fuelType)
        {
            throw new NotImplementedException();
        }

        public bool ParkMotorcycle(string color, int noOfWheels, string regNo, int cylinderVolume)
        {
            throw new NotImplementedException();
        }

        public void SeedData()
        {
            throw new NotImplementedException();
        }

        public bool UnparkVehicle(int index)
        {
            throw new NotImplementedException();
        }
    }
}
