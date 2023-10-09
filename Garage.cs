using Garage1._0.Vehicles;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Garage1._0
{
    public class Garage<T> : IGarage<T> where T : IVehicle
    {
        private T[] vehicles;
        private int capacity;
        private int nrOfParkedVehicles;
        private bool isEmpty;
        private bool isFull;
        
        public int Capacity 
        {
            get { return capacity; }
        }

        public int NrOfParkedVehicles 
        {
            get { return nrOfParkedVehicles; }
        }

        public bool IsEmpty { get { return isEmpty; } }

        public bool IsFull { get { return isFull; } }

        public Garage(int Capacity)
        {
            capacity = Capacity;
            vehicles = new T[capacity];
            isEmpty = true;
            isFull = false;
        }

        public bool AddVehicle(T vehicle)
        {
            if (vehicle == null) return false; 
            else
               foreach (var v in vehicles) 
                    if ((IVehicle)v == (IVehicle)vehicle) return false; 
               
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] == null)
                {
                    vehicles[i] = vehicle;
                    nrOfParkedVehicles++;
                    isFull = (nrOfParkedVehicles == capacity);
                    return true;
                }
            }

            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool RemoveVehicle(T vehicle)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }


}
