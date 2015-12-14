using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumayProducto_CuatroNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            String Linea;

            int Numero1;
            int Numero2;
            int Numero3;
            int Numero4;

            int Suma;
            int Producto;

            Console.Write("Teclea el primer numero: ");
            Linea = Console.ReadLine();
            Numero1 = int.Parse(Linea);

            Console.Write("Teclea el segundo numero: ");
            Linea = Console.ReadLine();
            Numero2 = int.Parse(Linea);

            Console.Write("Teclea el tercer numero: ");
            Linea = Console.ReadLine();
            Numero3 = int.Parse(Linea);

            Console.Write("Teclea el cuarto numero: ");
            Linea = Console.ReadLine();
            Numero4 = int.Parse(Linea);

            Suma = Numero1 + Numero2;
            Producto = Numero3 * Numero4;

            Console.WriteLine("El resultado de la suma de los primeros dos numeros es: "+Suma);
            Console.WriteLine("El resultado del producto del tercer y cuarto numero es: " + Producto);
            Console.ReadKey();
        }
    }
}
