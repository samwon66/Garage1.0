using Garage1._0.Vehicles;
using System.Collections;

namespace Garage1._0
{
    internal class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        private T[]? vehicles = null;
        
        public int Capacity { get { return vehicles.Length; } }
        public int CountVehicle { get; private set; } = 0;
        public bool IsFull => CountVehicle >= Capacity;
        
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var v in vehicles)
            {  
                if (v != null)
                    yield return v; 
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
