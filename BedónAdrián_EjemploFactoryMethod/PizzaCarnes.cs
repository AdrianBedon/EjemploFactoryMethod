using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedónAdrián_EjemploFactoryMethod
{
    public class PizzaCarnes:Pizza
    {
        public PizzaCarnes(string origen) 
        {
            _descripcion = "Pizza de carnes";
            _origen = origen;
        }
    }
}
