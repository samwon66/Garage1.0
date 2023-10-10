using Garage1._0.Vehicles;

namespace Garage1._0
{
    internal interface IGarage<T> where T : IVehicle
    {
        bool IsFull { get; }
        int NoOfSpacesLeft { get; }
        int NoOfVehiclesParked { get; }

        bool Add(T item);
        IEnumerator<T> GetEnumerator();
        bool Remove(int index);

    }
}
