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
        string GetMenuKey();
        void PrintMainMenu();
        void Pause();
        void PrintErrorMessage(string errorMessage);
        void PrintMessage(string Message);
        void PrintVehicle(IVehicle vehicle);
    }
}
