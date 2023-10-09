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
        int Capacity { get; }
        int NrOfParkedVehicles { get; }

        //IEnumerable<T> GetEnumerator();
        bool RemoveVehicle(T vehicle);
        bool AddVehicle(T vehicle);
        
    }
}
