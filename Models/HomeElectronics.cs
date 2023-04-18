using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeElectronics.Models
{
    public abstract class HomeElectronics
    {
        public abstract string Name { get; set; }
        public abstract string TypeOfElectronics { get; set; }
        public abstract int PowerConsumption { get; set; }
    }
}
