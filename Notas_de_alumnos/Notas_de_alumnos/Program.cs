using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notas_de_alumnos
{
    class Program
    {
        static void Main(string[] args)
        {
            String Linea;
            float Calificaciones;
            int Alumnos=1;
            int Mayores=0;
            int Menores = 0;
            int Raros = 0;

            while(Alumnos <11){
                Console.Write("Ingresa la Calificacion Numero " + Alumnos+" (0-10)");
                Linea = Console.ReadLine();
                Calificaciones = float.Parse(Linea);
                Alumnos++;
                if(Calificaciones>=7){
                    Mayores = Mayores + 1;
                }

                if (Calificaciones < 7)
                {
                    Menores = Menores + 1;
                }
            }

            Console.WriteLine("La cantidad de aprobados fue: " + Mayores);
            Console.WriteLine("La cantidad de reprobados fue: " + Menores);
            Console.ReadKey();
        }
    }
}