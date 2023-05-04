using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemploherencia3
{
    internal class Gato : AnimalDomestico, Runner
    {
        public override string comunicarse()
        {
            return "Miau...Miauu";            // hago override del comunicarse que hereda Gato de su clase madre animal ( ruido ruido)
                                                // por ( miau...miauuu)
        }

        public string correr()
        {
            return "Corre como un gato...";    // 
        }
    }
}
