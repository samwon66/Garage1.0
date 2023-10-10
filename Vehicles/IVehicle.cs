namespace Garage1._0.Vehicles
{
    public interface IVehicle
    {
        uint NrOfwheels { get; }
        string RegNum { get; }
        ConsoleColor Colour { get; set; }
    }
}
