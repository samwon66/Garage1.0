using Garage1._0.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0.UI
{
    internal interface IUI
    {
        void DrawList(IVehicle[] vehicles);
        void DrawMainMenu();
        void DrawSetupMessage();
        string GetMenuKey();
        void Pause();
        string Prompt(string Message);
        void ShowErrorMessage(string errorMessage);
        void WriteCapacity(uint Capacity, uint Ocupied, uint Available);
        void WriteMessage(string Message);
        void WriteTypeCount((Type, uint)[] typeCounts);
        void WriteVehicle(IVehicle vehicle);
    }
}
