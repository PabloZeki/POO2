using System;
using System.Collections.Generic;         // esta es la libreria de colecciones
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemploherencia2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Vehiculo > Auto > AutoDeportivo > AutoUrbano
            //>Camioneta                                      // la idea es buscar que cosa tienen en comun todos estas clases
            //>Moto

            Vehiculo v1 = new Vehiculo();
            Camioneta c1 = new Camioneta();        // ejemplos de herencia heradada de la clase madre vehiculo..patente y motor
            c1.CargaMaxima = 1000;
            c1.Color = "Amarillo";
            Camioneta c2 = new Camioneta();
            c2.Color = "Rojo";   
            Camioneta c3 = new Camioneta();
            c3.Color = "Verde";


            
            Auto a1 = new Auto();
            a1.Motor = new Motor();           // asociacion por agregacion,construyo un auto y luego le agrego un motor

            AutoDeportivo ad1 = new AutoDeportivo();
            ad1.Puertas = 2;
            AutoUrbano au1 = new AutoUrbano();
            au1.Puertas = 5;
            Moto m1 = new Moto();



            // ejemplos

            Vehiculo v2 = new Camioneta();     // me lo toma porque camioneta esta dentro de vehiculo
          //  Camioneta c2 = new Vehiculo();      // alreves no lo toma porque hay una jerarquia..vehiculo esta arriba de camioneta
            
            // Colecciones...



            List<Camioneta> listaCamionetas = new List<Camioneta>();    // asi creamos una lista de camionetas 
            listaCamionetas.Add(c1);                                // de esta manera con Add agrego un elemento camioneta "c1" a mi coleccion
            listaCamionetas.Add(c2);
            listaCamionetas.Add(c3);

            //listaCamionetas[1].Color = "azul";                 // aca yo puedo modificar un elemento que ya tengo cargado en mi colection,en este caso rojo por azul
            // c2.Color = "Negra";                                 // lo mimso que arriba,esto tmb modifica cuaalquiera de las dos maneras

            //Console.WriteLine("La cantidad de camionetas que tengo en mi lista es: " + listaCamionetas.Count);   // con el .count podemos saber cuantos elementos tiene mi lista o coleccion
            //listaCamionetas.Remove(c3); // para eliminar un objeto de la coleccion
            //Console.WriteLine("La cantidad de camionetas que tengo en mi lista es: " + listaCamionetas.Count);
            //Console.WriteLine("El color de la segunda camioneta es: " + listaCamionetas[1].Color);  // para saber el color del segundo elemento de mi lista
            

            foreach (Camioneta item in listaCamionetas)              // para recorrer mi colection..por ejemplo saber el color de todas las camionetas
            {
                Console.WriteLine("Color: " + item.Color);       // con cada vuelta me va a mostrar el item o camioneta el color que tenga cada una
                
            }
            Console.ReadKey();
        }
    }
}
