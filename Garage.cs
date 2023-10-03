using Garage1._0.Vehicles;
using System.Collections;

namespace Garage1._0
{
    internal class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        private T[] vehicles;
        public int ParkingSlot {  get; set; }
        public int CountVehicle {  get; set; }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
