﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Free
{
    public abstract class Weapon
    {
        public string Name { get; set; }

        public abstract int GetRandomDamage();


    }
}
