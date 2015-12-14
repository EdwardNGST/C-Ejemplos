using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venta
{
    class Program
    {
        static void Main(string[] args)
        {
            String Linea;
            int PrecioProducto;
            int Cantidad;
            int Costo;

            Console.Write("Ingrese el precio del articulo: ");
            Linea = Console.ReadLine();
            PrecioProducto = int.Parse(Linea);

            Console.Write("Ingrese la cantidad de articulos de su compra: ");
            Linea= Console.ReadLine();
            Cantidad = int.Parse(Linea);

            Costo = PrecioProducto * Cantidad;
            Console.Write("El costo total de su compra es: "+Costo);
            Console.ReadKey();
        }
    }
}
