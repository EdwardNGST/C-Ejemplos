using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumaypromedio_de_cuatro_Numeros
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
            int Promedio;

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

            Suma = Numero1 + Numero2 + Numero3 + Numero4;
            Promedio = (Numero1+Numero2+Numero3+Numero4)/4;

            Console.WriteLine("El resultado de la suma de los cuatro numeros es: " + Suma);
            Console.WriteLine("El promedio de los cuatro numeros es: "+Promedio);
            Console.ReadKey();
        }
    }
}
