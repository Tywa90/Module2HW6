using HomeElectronics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeElectronics.Models
{
    public abstract class HomeElectronics : IElectronics
    {
        public abstract string Name { get; set; }
        public abstract TypeOfElectronics Type { get; set; }
        public abstract double PowerConsumption { get; set; }
        public abstract string CompanyName { get; set; }
    }
}
