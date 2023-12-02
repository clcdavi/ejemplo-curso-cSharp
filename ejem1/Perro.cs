using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejem1
{
    class Perro
    {
        //perro tiene nombre, edad, raza

        private string nombre;
        private int edad;
        private string raza;


        public Perro(string nombre) //constructor
        {
            this.nombre = nombre;
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public string saludar()
        {
           return "Mi  nombre es " + nombre;
        }
        //sobrecarga de metodo
        public string saludar(string otroPerro)
        {
            return "Hola " + otroPerro +  ", mi nombre es " + nombre;
        }

    }
}

