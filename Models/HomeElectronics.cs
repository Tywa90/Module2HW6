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
        public virtual TypeOfElectronics Type {
            get => throw new Exception("NotImplement GET PowerConsumption");
            set => throw new Exception("NotImplement SET PowerConsumption");
        }
        public abstract int PowerConsumption { get; set; }
    }
}
