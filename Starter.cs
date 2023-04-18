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
        private Refrigerator _RefrigeratorLG;
        private WashingMachine _washMachine;
        private Oven _oven;
        private AirConditioner _airConditioner1;
        private AirConditioner _airConditioner2;
        private CoffeeMachine _coffeeMachine;

        public Starter()
        {
            _RefrigeratorLG = new Refrigerator() { CompanyName = "LG", PowerConsumption = 0.242 };
            _washMachine = new WashingMachine() { CompanyName = "Indesit", PowerConsumption = 0.786, LoadType = "horizontal" };
            _oven = new Oven() { CompanyName = "Beko", PowerConsumption = 1.65 };
            _airConditioner1 = new AirConditioner() { CompanyName = "COOPER&HUNTER", PowerConsumption = 0.79 };
            _airConditioner2 = new AirConditioner() { CompanyName = "LG", PowerConsumption = 0.81 };
            _coffeeMachine = new CoffeeMachine() { CompanyName = "Siemens", PowerConsumption = 1.5 };
        }
        public void Run()
        {
            Console.WriteLine();
        }
    }
}
