using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplos_de_ocho
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numero=8;
            int NumeroFinal = 500;

            while(Numero<=NumeroFinal){
                Console.Write(Numero);
                Numero=Numero+8;

                if (Numero < 500)
                {
                    Console.Write(" - ");
                }
            }
            Console.Write(" - "+NumeroFinal);
            Console.ReadKey();
        }
    }
}
