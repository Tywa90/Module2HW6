﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeElectronics.Services;

namespace HomeElectronics.Models
{
    public abstract class TeapotType : SmallElectronics
    {
        public override TypeOfElectronics Type { get; set; } = TypeOfElectronics.Teapot;
    }
}