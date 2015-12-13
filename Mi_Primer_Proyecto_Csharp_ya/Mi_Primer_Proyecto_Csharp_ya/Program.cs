using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mi_Primer_Proyecto_Csharp_ya{
    class Program{
        static void Main(string[] args){

            int HorasTrabajadas;
            float CostoHora;
            float Sueldo;
            string Linea;

            Console.Write("Ingrese Horas trabajadas por el operario:");
            Linea = Console.ReadLine();
            HorasTrabajadas = int.Parse(Linea);
            Console.Write("Ingrese el pago por hora:");
            Linea = Console.ReadLine();
            CostoHora = float.Parse(Linea);
            Sueldo = HorasTrabajadas * CostoHora;
            Console.Write("El sueldo total del operario es:");
            Console.Write(Sueldo);
            Console.ReadKey();

        }
    }
}
