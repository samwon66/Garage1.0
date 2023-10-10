﻿using Garage1._0.Vehicles;
using System.Collections;

namespace Garage1._0
{
    public class Garage<T> : IEnumerable<T>, IGarage<T> where T : IVehicle
    {
        private T[] vehicleArray;
        private readonly int capacity;
        private bool isFull;

        public int NoOfVehiclesParked { get; private set; }
        public int NoOfSpacesLeft => vehicleArray.Length - NoOfVehiclesParked;
        public bool IsFull 
        {  
            get 
            { 
                if (this.capacity == this.NoOfVehiclesParked)
                    isFull = true;
                else
                    isFull = false;

                return isFull; 
            } 
        }

        public Garage(int capacity)
        {
            if (capacity <= 0)
                throw new ArgumentOutOfRangeException("The capacity have to be more than 0.");
            this.capacity = capacity;
            vehicleArray = new T[capacity];
        }

        public bool Add(T item)
        {
            ArgumentNullException.ThrowIfNull(item, nameof(item));

            bool result = false;
            for (int i = 0; i < vehicleArray.Length; i++)
            {
                if (vehicleArray[i] == null)
                {
                    vehicleArray[i] = item;
                    NoOfVehiclesParked++;
                    result = true;
                    return result;
                }
            }
            return result;
        }

        public bool Remove(int index)
        {
            bool result;
            if (index < 0 || index >= NoOfVehiclesParked)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                vehicleArray[index] = default!; 
                NoOfVehiclesParked--;
                result = true;
            }
            return result;
        }
        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in vehicleArray) 
            { 
                if (item != null)
                    yield return item; 
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
