using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeElectronics.Models
{
    public class CoffeeMachine : CoffeGrinder
    {
        public override string Name { get; set; } = "Coffee machine";
        public override double PowerConsumption { get; set; }
        public override string CompanyName { get; set; }
    }
}
