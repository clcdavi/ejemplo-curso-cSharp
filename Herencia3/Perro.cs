﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3
{
    class Perro : AnimalDomestico
    {
        public override string comunicarse()
        {
            return "guau... guau...";
        }
    }
}
