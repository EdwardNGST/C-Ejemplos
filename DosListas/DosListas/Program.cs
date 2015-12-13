using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosListas
{
    class Program
    {
        static void Main(string[] args)
        {
            String Linea;
            byte Contador=1;
            byte Contador2 = 1;
            byte ListaUno=15;
            byte ListaDos=15;
            int ListaUnoValor;
            int ListaDosValor;
            int ListaUnoSuma=0;
            int ListaDosSuma = 0;

            Console.WriteLine("Lista Numero 1");

            while(Contador<=ListaUno){
                Console.Write("Ingrese el valor numero: "+Contador+" ");
                Linea = Console.ReadLine();
                ListaUnoValor=int.Parse(Linea);

                ListaUnoSuma = ListaUnoSuma + ListaUnoValor;

                Contador++;
            }

            Console.WriteLine("Lista Numero 2");

            while (Contador2 <= ListaDos)
            {
                Console.Write("Ingrese el valor numero : "+Contador2+" ");
                Linea = Console.ReadLine();
                ListaDosValor = int.Parse(Linea);

                ListaDosSuma = ListaDosSuma + ListaDosValor;

                Contador2++;
            }

            if (ListaUnoSuma > ListaDosSuma)
            {
                Console.Write("La lista numero uno es la mayor y su valor final es de: " + ListaUnoSuma);
            }
            if (ListaUnoSuma < ListaDosSuma)
            {
                Console.Write("La lista numero dos es la mayor y su valor final es de: " + ListaDosSuma);
            }
            if (ListaUnoSuma == ListaDosSuma)
            {
                Console.Write("Las dos listas terminaron con el mismo valor: " + ListaUnoSuma+" (Lista Uno) "+ListaDosSuma+" (Lista Dos) ");
            }
            Console.Write("By Blacklist");
            Console.ReadKey();
        }
    }
}
