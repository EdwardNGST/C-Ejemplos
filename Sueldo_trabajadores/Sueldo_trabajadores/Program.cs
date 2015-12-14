using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sueldo_trabajadores
{
    class Program
    {
        static void Main(string[] args)
        {
            String Linea;
            int Contador = 1 ;
            int Trabajadores;
            float Sueldo;
            float Entre=0; //Entre 100 y 300
            float Mas=0; //Mas de 300
            float DeMas=0; //Mas de 500
            float GastoTotal=0;
            float DeMenos=0; //Menos de 100

            Console.Write("Cuantos trabajadores ingresaran su sueldo? ");
            Linea = Console.ReadLine();
            Trabajadores=int.Parse(Linea);

            while (Contador <= Trabajadores)
            {
                Console.Write("Ingresa tu sueldo: ");
                Linea = Console.ReadLine();
                Sueldo=float.Parse(Linea);

                GastoTotal = GastoTotal + Sueldo;

                if (Sueldo >= 100 && Sueldo < 300){
                    Entre = Entre + 1;
                }
                if (Sueldo >= 300 && Sueldo<=500)
                {
                    Mas = Mas + 1;
                }
                if (Sueldo >500)
                {
                    DeMas = DeMas+ 1;
                }
                if (Sueldo <100)
                {
                    DeMenos = DeMenos+ 1;
                }

                Contador++;
            }

            Console.WriteLine("La cantidad de trabajadores que cobran entre $100 y $300 son: "+Entre);
            Console.WriteLine("La cantidad de trabajadores que cobran entre $300 y $500 son: " + Mas);
            Console.WriteLine("La cantidad de trabajadores que cobran mas de $500 son: " + DeMas);
            Console.WriteLine("La cantidad de trabajadores que cobran menos de $100 son: " + DeMenos);

            Console.WriteLine("El Sueldo total de lo que se gasto por todos los trabajadores es: " + GastoTotal);
            Console.ReadKey();
        }
    }
}
