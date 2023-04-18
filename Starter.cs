using HomeElectronics.Models;
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
            Refrigerator refrLG = new Refrigerator()
            {
                PowerConsumption = 70
            };
            Console.WriteLine();
        }
    }
}
