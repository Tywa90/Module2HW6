using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeElectronics.Models
{
    public abstract class AirConditionerCompressor : ClimateType
    {
        public string EngineType { get; set; } = "invertor";
    }
}
