﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedónAdrián_EjemploFactoryMethod
{
    public class PizzaNapolitana:Pizza
    {
        public PizzaNapolitana(string origen)
        {
            _descripcion = "Pizza Napolitana";
            _origen = origen;
        }
    }
}
