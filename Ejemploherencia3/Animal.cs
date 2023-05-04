using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemploherencia3
{
    internal class Animal
    {
        public virtual string comunicarse()      // metodo o comportamiendo general de todos los animales..comunicarse
                                                  // le agrego el virtual para que me de la opcion de poder sobreescribir el comunicarse (override)
        {
            return "ruido...ruido";
        }

       
    }
}
