using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Developer : Persona // con el ": Persona" ya se crea la relacion de herencia
    {
        public string seniority { get; set; }
    }
}
