using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploherencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Persona > Lider > Developer > Tester       "" una familia de clases,persona es un lider,developer y tester"
           Persona p1 = new Persona();
            Developer d1 = new Developer();
            Tester t1 = new Tester();
            Lider.saludar();                      // de una clase estatica no se puede crear una instancia..direcatemente la uso
            
            Console.WriteLine(Lider.saludar());  
            Console.ReadKey();
        }
    }
}
