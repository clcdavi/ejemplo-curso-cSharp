using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejem2
{
    class Botella
    {
        //capacidad maxima: 100
        //cantidad actual: inicia en cero
        //metodo recarga: carga al 100 y devuelve el costo de recargar. 50 cada 100

        //constructor
        public Botella(string color, string material)
        {
            this.color = color;
            this.material = material;
            capacidad = 100;
            cantidadActual = 0;
        }

        //sobrecargar el constructor
        public Botella() { }
        //Destructor
        ~Botella()
        {
            //la logica
        }

        //Botella: capacidad, color, material
        //Propiedades
        private int capacidad;
        private string color;
        private string material;
        private int cantidadActual;

        public string Material
        {
            get { return material; }
        }

        public int Capacidad
        {
            get { return capacidad; }
        ////    set { capacidad = value; }
        }

        public int CantidadActual
        {
            get { return cantidadActual; }
        }

        //Metodos
        public float recargar()
        {
            if (cantidadActual > 0)
            {
                int dif = 100 - cantidadActual;

                float monto = dif * 50 / 100;
                cantidadActual = +dif;
                return monto;
            }
            cantidadActual = 100;
            return 50;
        }


    }
}
