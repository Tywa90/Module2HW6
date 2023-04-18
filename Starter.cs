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
        public static void Run()
        {
            IElectronics[] home = new IElectronics[10];

            Refrigerator refrLG = new Refrigerator()
            {
                PowerConsumption = 70
            };

            Refrigerator refrBeko = new Refrigerator();
            home[0] = refrLG;
            Console.WriteLine();
        }
    }
}
