﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0.UI
{
    internal interface IUI
    {
        void PrintMessage(string message);
        void Clear();
        string GetInputInString(string input);
        int GetInputInInt(string input);
        void Quit();
        void Wait();
        
    }
}
