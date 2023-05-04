using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemploherencia2
{
    internal class Camioneta : Vehiculo
    {
        public float CargaMaxima { get; set; }   // por ejemplo este es un dato que no manejara ni un auto ni moto..es solo de camioneta
    }
}
