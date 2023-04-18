﻿using HomeElectronics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeElectronics.Models
{
    public abstract class OvenType : BigElectronics
    {
        public override TypeOfElectronics Type { get; set; } = TypeOfElectronics.Oven;
    }
}
