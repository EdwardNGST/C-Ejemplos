using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alturadepersonas
{
    class Program
    {
        static void Main(string[] args)
        {
            String Linea;
            int NPersonas;
            float Altura;
            float SumaAlturas=0;
            float Promedio;
            int Contador=1;

            Console.Write("Cuantas personas se van a medir? ");
            Linea = Console.ReadLine();
            NPersonas = int.Parse(Linea);

            while(Contador<=NPersonas){
                Console.Write("Ingrese su altura ");
                Linea = Console.ReadLine();
                Altura = float.Parse(Linea);

                SumaAlturas = SumaAlturas + Altura;
                Contador++;
            }

            Promedio = SumaAlturas / NPersonas;

            Console.WriteLine("El total de personas que ingresaron su altura fue: "+NPersonas);
            Console.WriteLine("El promedio del total de las alturas fue: "+Promedio);

            Console.ReadKey();
        }
    }
}
