using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalDomestico ad1 = new AnimalDomestico();
            ad1.Nombre = "pope";

            Perro pe1 = new Perro();
            Gato ga1 = new Gato();

            //Console.WriteLine(ad1.comunicarse());
            //Console.WriteLine(pe1.comunicarse());
            //Console.WriteLine(ga1.comunicarse());

            List<Animal> animales = new List<Animal>();
            animales.Add(pe1);
            animales.Add(ga1);
            animales.Add(ad1);
            animales.Add(new Aguila());
            animales.Add(new Tigre());

            List<Flyable> listaVoladores = new List<Flyable>();



            foreach (Animal item in animales)
            {
                Console.WriteLine(item.comunicarse());
            }

            //POLIMORFISMO: CARACTERISTICA QUE TIENEN LOS OBJETOS,
            //DE FRENTE A UN MISMO ESTIMULO COMPORTARSE DE MANERA DISTINTA


            Console.ReadKey();
        }
    }
}
