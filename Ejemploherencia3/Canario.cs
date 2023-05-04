using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemploherencia3
{
    internal class Canario : AnimalSalvaje, Flyable          // interfaz
    {
        public string volar()                             // aca especificamos el metodo o el comportamiento que tiene la interfaz de volar 
        {
            return "Vuela como un canario...";
        }
    }
}
