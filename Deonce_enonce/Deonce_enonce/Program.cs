using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deonce_enonce
{
    class Program
    {
        static void Main(string[] args)
        {
            int Contador=1;
            int FinalContador=25;
            int Numero = 11;

            while (Contador <= FinalContador)
            {
                Console.Write(Numero);
                if (Contador < 25)
                {
                    Console.Write(" - ");
                }
                Numero = Numero+11;
                Contador++;
            }
            Console.ReadKey();
        }
    }
}
