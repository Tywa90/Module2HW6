using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeElectronics.Services;

namespace HomeElectronics.Models
{
    public class Oven : OvenBuiltIn
    {
        public override string Name { get; set; } = "Oven Built-In";
        public override double PowerConsumption { get; set; }
        public override string CompanyName { get; set; }
    }
}
