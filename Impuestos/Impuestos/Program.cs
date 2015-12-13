using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impuestos
{
    class Program
    {
        static void Main(string[] args)
        {
            float sueldo;
            string linea;
            Console.Write("Ingrese el sueldo:");
            linea = Console.ReadLine();
            sueldo = float.Parse(linea);
            if (sueldo > 3000)
            {
                Console.Write("Esta persona debe abonar impuestos");
            }
            if (sueldo < 3000 && sueldo >0)
            {
                Console.Write("Esta persona no debe abonar impuestos");
            }
            if (sueldo <= 0)
            {
                Console.Write("Esta cantidad no existe");
            }
            Console.ReadKey();
        }
    }
}
