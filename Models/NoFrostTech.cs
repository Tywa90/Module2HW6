﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeElectronics.Models
{
    public abstract class NoFrostTech : RefrigratorType
    {
        public bool IsNoFrost { get; set; } = true;
    }
}
