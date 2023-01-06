using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedónAdrián_EjemploFactoryMethod
{
    public abstract class Pizzería
    {
        public abstract Pizza CrearPizza(string tipo);
    }
}
