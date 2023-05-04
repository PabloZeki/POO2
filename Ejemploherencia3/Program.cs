using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemploherencia3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnimalDomestico a1 = new AnimalDomestico();
            a1.Nombre = "pepe";

            Gato g1 = new Gato();
            g1.comunicarse();     // metodo o comportamiento heredado de la clase madre ( animal) 

            Perro p1 = new Perro();
            p1.comunicarse();

            List<Animal> animales = new List<Animal>();       // creo una coleccion para guardar animales
            animales.Add(g1);
            animales.Add(p1);
            animales.Add(new Pez());
            animales.Add(new Aguila());      // ACA GENERO obejtos cuya referncia va estar en la lista o coleccion no como p1 o g1 que estan
            animales.Add(new Gato());         // referenciados a una variable,estos objetos no van a poder ser accedidos desde otro lado que no sea esta coleccion o lista
            animales.Add(new Canario());      // a no ser que luego los pase a una varible y ahi si podria acceder a esos objetos
           
            List<Flyable>listavoladores = new List<Flyable>(); // me armo una coleccion de los animales que pueden volar (usando la interfaz)
            listavoladores.Add(new Canario());
            listavoladores.Add(new Aguila());                  // agrego los animales que pueden volar

            List<Runner>listacorredores = new List<Runner>();    // me armo una coleccion de animales que corren

            listacorredores.Add(new Perro());
            listacorredores.Add(new Tigre());              // agrego los animales corredores a una coleccion de corredores
            listacorredores.Add(new Gato());




            foreach (Animal item in animales)
            {                                           // aca creo el foreach para recorrer los animales..tienen algo en comun todos
                Console.WriteLine(item.comunicarse());   // que todos pueden comunicarse,ante el mimso estimulo cada especie de animal responde distinto
                                                         // esto es polimorfismo
            }

            // Console.WriteLine(a1.ToString());          // ToString para una de las propiedades que trae por defecto el objeto al crear la clase

            Console.WriteLine(g1.comunicarse());          

            Console.ReadKey();
            
        }
    }
}
