using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerimetrodeunCuadrado{
    class Program{
        static void Main(string[] args){

            String Linea;
            float Lado;
            float Perimetro;

            Console.Write("Teclea el lado del cuadrado: ");
            Linea=Console.ReadLine();
            Lado = int.Parse(Linea);
            Perimetro = Lado * 4;
            Console.Write("El perimetro de tu cuadrado es: " + Perimetro);
            Console.ReadKey();

        }
    }
}
