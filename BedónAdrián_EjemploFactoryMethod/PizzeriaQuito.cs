using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedónAdrián_EjemploFactoryMethod
{
    public class PizzeriaQuito:Pizzería
    {
        public override Pizza CrearPizza(string tipo)
        {
            if (tipo == "carnes")
            {
                return new PizzaCarnes("Quito");
            }
            else if (tipo == "napo")
            {
                return new PizzaNapolitana("Quito");
            }
            else
            {
                return null;
            }
        }
    }
}
