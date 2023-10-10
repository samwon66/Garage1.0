namespace Garage1._0.Vehicles
{
    public interface IVehicle
    {
        string Color { get; set; }
        int NoOfWheels { get; set; }
        string RegNo { get; set; }

        string ToString();
    }
}
