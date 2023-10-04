using Garage1._0.Vehicles;
using System.Collections;

namespace Garage1._0
{
    internal class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        private T[]? vehicles = null;
        
        public int ParkingSlot { get; set; }
        public int CountVehicle { get; set; }

        public Garage(int parkingSlot) => ParkingSlot = parkingSlot;
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
