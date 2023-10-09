﻿using Garage1._0.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0.UI
{
    internal interface IUI
    {
        void PrintMainMenu();
        void PrintSetupMessage();
        void Pause();
        string Prompt(string Message);
        void PrintErrorMessage(string errorMessage);
        void PrintMessage(string Message);
        void PrintVehicle(IVehicle vehicle);
    }
}
