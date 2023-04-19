using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeElectronics.Models
{
    public abstract class OvenBuiltIn : OvenType
    {
        public bool IsElectric { get; set; } = true;
    }
}
