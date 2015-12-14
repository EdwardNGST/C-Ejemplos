using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            String Linea;
            int Pares;
            float Base;
            float Altura;
            float Superficie;
            int MayoresDoce = 0;


            Console.Write("Que Cantidad de Pares de Datos Desea Ingresar: ");
            Linea = Console.ReadLine();
            Pares = int.Parse(Linea);

            for (int Contador = 1; Contador <= Pares;Contador++ )
            {
                Console.Write("Ingresa la medida de la base de el triangulo: ");
                Linea=Console.ReadLine();
                Base = float.Parse(Linea);

                Console.Write("Ingresa la medida del perimetro de el triangulo: ");
                Linea=Console.ReadLine();
                Altura = float.Parse(Linea);

                Console.WriteLine("La base del triangulo es: " + Base);
                Console.WriteLine("La altura del triangulo es: "+ Altura);

                Superficie = (Base * Altura)*2;

                Console.WriteLine("La superficie del triangulo es: " + Superficie);
                Console.WriteLine("Presiona cualquier tecla para continuar...");
                Console.ReadKey();

                if (Superficie >= 12)
                {
                    MayoresDoce = MayoresDoce + 1;
                }
            }

            Console.WriteLine("La cantidad de triangulos con superficie mayor a doce son: " + MayoresDoce);
            Console.ReadKey();
        }
    }
}
