using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeElectronics.Models
{
    public class WashingMachine : WMLoadType
    {
        public override string Name { get; set; } = "Washing Machine";
        public override double PowerConsumption { get; set; }
        public override string CompanyName { get; set; }
    }
}
