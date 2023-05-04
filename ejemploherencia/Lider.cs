using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploherencia
{
    static class Lider     // no me deja heredar por estar sellada la clase madre persona
                            // Una clase static no puede heredar
    {
        public static string saludar()
        {
            return "HOLA COMO VAS??...";
        }
    }
}
