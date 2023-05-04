using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemploherencia3
{
    internal class Aguila : AnimalSalvaje, Flyable       // ponemos una , y luego el nombre de la interfaz
    {
        public string volar()
        {
            return "Vuela como un aguila...";

        }
    }
}
