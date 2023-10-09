using Garage1._0.UI;
using Garage1._0.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
    
    internal class Manager
    {
        private IUI ui;
        private bool isRunning = true;


        internal Manager(IUI consoleUI)
        {
            ui = consoleUI;
        }

        internal void Run()
        {
            do
            {
                ui.PrintMainMenu();
                if(isRunning) ui.Pause();
            }
            while(isRunning);
        }
        

  
    }
}
