using Garage1._0.Vehicles;
using System.Collections;
using System.ComponentModel;

namespace Garage1._0
{
    internal class Garage<T> : IEnumerable<T> where T : IVehicle
    {
        private static int vehicleInGarage = 0;
        private static int totalParkingslots;
        private static int parkingslotsInUse = 0;
        private static int freeParkingslots = totalParkingslots - parkingslotsInUse;
        private static bool isFull = false;
        private static T[] garageArray = new T[totalParkingslots];

        public int VehicleInGarage { get; set; }
        public int TotalParkingslots { get; set; }
        public int ParkingslotsInUse { get ; set; }
        public int FreeParkingslots { get; set; }
        public bool IsFull 
        {
            get {  return isFull; } 
            set {
                if (FreeParkingslots == 0)
                {
                    IsFull = true;
                }
                else
                {
                    IsFull = false;
                }
            } 
        }


        public IEnumerator<T> GetEnumerator()
        {
            foreach (var v in garageArray)
            {
                yield return v;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void AddVehicleToGarage() 
        {
            VehicleInGarage++;
            ParkingslotsInUse++;
        }

        public void RemoveVrhicleFromGarage()
        {
            VehicleInGarage--;
            ParkingslotsInUse--;
        }

        public void AllVehicleInGarage() 
        {
            Console.WriteLine($"There is {VehicleInGarage} in the garage.");
            int index = 1;
            foreach (IVehicle v in garageArray)
            {
                if (v != null)
                {
                    Console.WriteLine($"{index} - Type: {v.GetType().Name}, RegisterNumber: {v.RegNr}");
                }
                index++;
            }
        }


        //public bool GarageIsFull()
        //{
        //    if (FreeParkingslots == 0)
        //    {
        //        return IsFull = true;
        //    }
        //    else
        //    {
        //        return IsFull = false;
        //    }
        //}
    }
}
