﻿using Garage1._0.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
    
    internal class GarageHandler
    {
        private IGarage<IVehicle> garage;
        private uint garageCapacity;

        public uint GarageCapacity 
        { 
            get { return garageCapacity; }
            set { garageCapacity = value; }
        }

        internal GarageHandler(uint NrOfPlaces)
        {
            garage = new Garage<IVehicle>(NrOfPlaces);
            garageCapacity = NrOfPlaces;
        }

        internal bool AddCar(string RegNum, uint NrOfwheels, string FuelType, ConsoleColor colour = ConsoleColor.Black)
        {
            bool success = false;
            Car car = new Car(RegNum.ToUpper(), NrOfwheels, FuelType);
            car.Colour = colour;

            if (ValidateRegNum(RegNum) && ValidateNrOfWheels(NrOfwheels, car.GetType().Name))
                success = garage.AddVehicle(car);

            return success;
        }

        private bool ValidateNrOfWheels(uint nrOfWheels, string Type)
        {
            switch (Type.ToLower())
            {
                case "car":
                    if (nrOfWheels >= 3 && nrOfWheels <= 4) return true;
                    else return false;

                case "motorcycle":
                    if (nrOfWheels >= 2 && nrOfWheels <= 4) return true;
                    else return false;

                case "bus":
                    if (nrOfWheels >= 4 && nrOfWheels <= 6) return true;
                    else return false;

                case "boat":
                    if (nrOfWheels == 0) return true;
                    else return false;

                case "airplane":
                    if (nrOfWheels == 3) return true;
                    else return false;
            }

            return true;
        }

        private bool ValidateRegNum(string RegNum)
        {
            if (string.IsNullOrWhiteSpace(RegNum) ||
                RegNum.Length != 6 ||
                RegNum.Contains(' ')) return false;

            string s = RegNum.Substring(3, 3);
            if (!int.TryParse(RegNum.Substring(3, 3), out _) ||
                int.TryParse(RegNum.Substring(0, 1), out _) ||
                int.TryParse(RegNum.Substring(1, 1), out _) ||
                int.TryParse(RegNum.Substring(2, 1), out _)) return false;

            foreach (var v in garage)
                if (v != null)
                    if (v.RegNum == RegNum) return false;   // Duplicate found

            return true;
        }
    }
}
