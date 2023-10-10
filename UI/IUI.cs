namespace Garage1._0.UI
{
    public interface IUI
    {
        void Clear();
        int GetIntInput(string message);
        string GetStringInput(string message);
        void Print(string message);
        void PrintAddSuceed();
        void PrintPropertyMessage(string type, string color, int noOfWheels);
    }
}
