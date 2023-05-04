using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemploherencia2
{
    internal class Auto : Vehiculo  
    {
        public int Puertas { get; set; }

        public int Año { get; set; }
        public string Marca { get; set; }
        public string Color { get; set; }


        // Agregacion

        public Motor Motor { get; set; }    // va a tener un objeto de tipo motor como propiedad del vehiculo esto es "asociacion"
                                       

        // Composicion

        public Chasis Chasis { get; }  // el auto si o si nace con un chasis desde el principio,esta seria una clase indispensable
                                        // en este caso es solo get,porque no voy a setear desde afuera el chasis,solo mostrar



    }
}
