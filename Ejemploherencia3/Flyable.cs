using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemploherencia3
{
    internal interface Flyable
    {
        string volar();      // esto es el prototipo o al firma de la interface en este caso en todas las clases que impletmente el metodo volar 
                              // va a ir un string
    }
}
