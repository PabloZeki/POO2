using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejemploherencia3
{
    internal class AnimalDomestico : Animal
    {
        public string Nombre { get; set; } // el animal domestico va a tener un nombre

        public override string ToString()
        {
            return "AnimalDomestico: " + Nombre;   // manera de sobreescribir el tostring que viene por defecto y mostrar en este caso el nombre
        }                                          // el nombre de mi animal domestico
    }
}
