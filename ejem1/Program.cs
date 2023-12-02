using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejem1
{
    class Program
    {
        static void Main(string[] args)
        {
            Perro pe1 = new Perro("luli");
            //pe1.Nombre = Luli;
            //string algo = pe1.Nombre;

            pe1.Edad = 7;

            int algo = pe1.Edad;
            Console.WriteLine(pe1.saludar());
            Console.WriteLine(pe1.saludar("Davi"));
            Console.WriteLine(value: "la edad del perro es: " + pe1.Edad);
            Console.ReadKey();
        }
    }
}
