using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona();
            Developer d1 = new Developer();
            Developer d2 = new Developer();
            Developer d3 = new Developer();
            d1.seniority = "Senior";
            d2.seniority = "SemiSenior";
            d3.seniority = "Junior";

            List<Developer> listDevelopers = new List<Developer>();
            listDevelopers.Add(d1);
            listDevelopers.Add(d2);
            listDevelopers.Add(d3);

            //Console.WriteLine("La cantidad de Developers es " + listDevelopers.Count);
            //listDevelopers[1].seniority = "SemiSenior nivel 2";
            //Console.WriteLine("El seniority segundo es " + listDevelopers[1].seniority);
            //listDevelopers.Remove(d3);
            //Console.WriteLine("La cantidad de Developers es " + listDevelopers.Count);

            foreach (Developer item in listDevelopers)
            {
                Console.WriteLine("Seniority " + item.seniority);
            }


            Console.ReadKey();
        }
    }
}
