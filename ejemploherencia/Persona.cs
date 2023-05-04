using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace ejemploherencia
    {                                   // sealed es para sellar la clase no me permite heredar basicamente de la clase madre
         sealed  class Persona             // le ponemos abstract a una clase madre por ejemplo..para no crear instancias nuevas..como en este caso
    {                                   // solo usamos sus clases hijos e hijas
        public string Nombre { get; set; }
        public string Apellido { get; set; }       // estas propiedades deberian estar en lider,tester,developer osea se repiten
                                                   // la idea de esto es establecer relaciones entre las clases...
        public string Legajo { get; set; }        // la clase de mas jerarquia es persona,tester es una persona,lider es una persona,developer es una persona
    }
}
