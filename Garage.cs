using Garage1._0.Vehicles;
using System.Collections;
using System.ComponentModel;

namespace Garage1._0
{
    public class Garage<T> : IEnumerable<T> where T : IVehicle
    {
        private T[] vehicles;

        public Garage(int capacity)
        {
            vehicles = new T[capacity];
        }

        public void Park(T vehicle)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] == null)
                {
                    vehicles[i] = vehicle;
                }
            }
        }

        public void RemoveVehicle(string inputRegNr)
        {
            foreach (var v in vehicles)
            {

            }
        }

        public IEnumerator GetEnumerator()
        {
            return vehicles.GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            foreach (var v in vehicles)
            {
                yield return v;
            }
        }
    }
}
