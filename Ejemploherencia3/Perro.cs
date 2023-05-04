using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemploherencia3
{
    internal class Perro : AnimalDomestico, Runner
    {
        public override string comunicarse()
        {                                     // sobreesecribo el metodo comunicarse de la clase perro 
            return "Guauu...Guauu";
        }

        public string correr()
        {
            return "Corre como un perro...";  // interfaz runner..escribimos el comportamiento del metodo
        }
    }
}
