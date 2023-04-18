using HomeElectronics.Models;
using HomeElectronics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeElectronics
{
    public class Starter
    {
        Refrigerator refrigeratorLG;
        WashingMachine washMachine;
        public Starter()
        {
            refrigeratorLG = new Refrigerator() { CompanyName = "LG", PowerConsumption = 1 };
            washMachine = new WashingMachine() { CompanyName = "Indesit", PowerConsumption = 0.786 };
        }
        public void Run()
        {
            Console.WriteLine();
        }
    }
}
