using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemploherencia2
{
    internal class Vehiculo
    {
        public string Motor { get; set; }   // aca podemos decir que todos las demas clases tienen un motor algo en comun
        public string Patente { get; set; }
        public string Color { get; set; }

    }
}
