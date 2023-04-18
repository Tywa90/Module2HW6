﻿using HomeElectronics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeElectronics.Models
{
    public abstract class SmallElectronics : HomeElectronics, ICategory
    {
        public bool IsBig { get; set; } = false;
    }
}
