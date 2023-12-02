using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejem2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Primer lote con 10 registros de productos, cada producto tiene:
                //-Codigo Articulo(3 digitos no correlativos)
                //-Precio 
                //-Codigo de marca(1 a 10)
            //Segundo lote con las ventas de la semana
                //-Codigo Articulo
                //-Cantidad
                //-Codigo Cliente (1 a 100)
            //Este lote corta con Codigo de Cliente Cero.

            //Articulo a1 = new Articulo();
            //a1.CodigoArticulo = 3;

            Articulo[] articulos = new Articulo[10];

            //articulos[6].CodigoMarca = 3;  //-queda comentado

            //for (int x = 0; x < 10; x++)
            //{
            //    Console.WriteLine("Ingrese los datos del producto");
            //    Console.WriteLine("Codigo");
            //    articulos[x].CodigoArticulo = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Precio: ");
            //    articulos[x].Precio = float.Parse(Console.ReadLine());
            //    Console.WriteLine("Marca 1 a 10");
            //    articulos[x].CodigoMarca = int.Parse(Console.ReadLine());
            //}

            //Cargado el vector con los 10 // -queda comentado

            //Venta venta = new Venta();
            //Console.WriteLine("Ingrese primer codigo de cliente: ");
            //venta.codigoCliente = int.Parse(Console.ReadLine());

            //while (venta.codigoCliente != 0)
            //{
            //    Console.WriteLine("Ingrese codigo de articulo: ");
            //    venta.codigoÁrticulo = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Ingrese cantidad: ");
            //    venta.cantidad = int.Parse(Console.ReadLine());





            //    Console.WriteLine("Ingrese codigo de cliente: ");
            //    venta.codigoCliente = int.Parse(Console.ReadLine());
            //}


            Botella b1 = new Botella("rojo", "plastico");
            Console.WriteLine("Capacidad de botella es " + b1.Capacidad);
            Console.WriteLine("La cantidad actual es: " + b1.CantidadActual);

            b1.recargar();
            Console.WriteLine("luego de recargar la cantidad actual es: " + b1.CantidadActual);


            Console.ReadKey();
        }
    }
}
