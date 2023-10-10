﻿using Garage1._0.Vehicles;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Numerics;

namespace Garage1._0
{
    public class Garage<T> : IGarage<T> where T : IVehicle
    {
        private T[] vehicles;
        private uint capacity;
        private uint nrOfParkedVehicles;
        private bool isEmpty;
        private bool isFull;

        public uint Capacity
        {
            get { return capacity; }
        }
        public uint NrOfParkedVehicles
        {
            get { return nrOfParkedVehicles; }
        }
        public bool IsEmpty
        {
            get { return isEmpty; }
        }
        public bool IsFull
        {
            get { return isFull; }
        }

        public Garage(uint Capacity)
        {
            capacity = Capacity;
            vehicles = new T[Capacity];
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

        public bool RemoveVehicle(T vehicle)
        {
            if (vehicle == null) return false;

            for (int i = 0; i < vehicles.Length; i++)
            {
                if ((IVehicle)vehicles[i] == (IVehicle)vehicle)
                {
                    vehicles[i] = default(T);
                    nrOfParkedVehicles--;
                    isEmpty = (nrOfParkedVehicles == 0);
                    return true;
                }
            }

            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T vehicle in vehicles)
            {
                if (vehicle != null)             
                    yield return vehicle;
            }
        }

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return GetEnumerator();
        //}
    }


}
