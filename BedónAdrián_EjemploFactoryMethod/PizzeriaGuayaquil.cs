using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedónAdrián_EjemploFactoryMethod
{
    public class PizzeriaGuayaquil : Pizzería
    {
        public override Pizza CrearPizza(string tipo)
        {
            if (tipo == "carnes")
            {
                return new PizzaCarnes("Guayaquil");
            }
            else if (tipo == "napo")
            {
                return new PizzaNapolitana("Guayaquil");
            }
            else
            {
                return null;
            }
        }
    }
}
