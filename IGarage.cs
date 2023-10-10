using Garage1._0.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
    internal interface IGarage<T> : IEnumerable<T> where T : IVehicle
    {
        bool AddVehicle(Car car);

        public interface IGarage<T> : IEnumerable<T> where T : IVehicle
        {
            uint Capacity { get; }
            uint NrOfParkedVehicles { get; }

            IEnumerator<T> GetEnumerator();
            bool RemoveVehicle(T vehicle);
            bool AddVehicle(T vehicle);

        }

    }
}
