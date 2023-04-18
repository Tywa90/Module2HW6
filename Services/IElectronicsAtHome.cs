using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeElectronics.Services
{
    public interface IElectronics
    {
        public abstract string Name { get; set; }
        public abstract TypeOfElectronics Type { get; set; }
        public abstract int PowerConsumption { get; set; }
    }
}
