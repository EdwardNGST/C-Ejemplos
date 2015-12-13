using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPilas
{
    class Pila
    {
        class Nodo
        {
            public int info;
            public Nodo sig;
        }

        private Nodo raiz;

        public Pila()
        {
            raiz = null;
        }

        public void Insertar(int x)
        {
            Nodo Nuevo;
            Nuevo = new Nodo();
            Nuevo.info = x;

            if (raiz == null)
            {
                Nuevo.sig = null;
                raiz = Nuevo;
            }
            else
            {
                Nuevo.sig = raiz;
                raiz = Nuevo;
            }
        }

        public void Imprimir()
        {
            Nodo reco = raiz;
            Console.Write("Ultimo elemento de la pila: ");
            if (reco != null)
            {
                Console.Write(reco.info);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Pila Resultados= new Pila();
            Resultados.Insertar(10);
            Resultados.Imprimir();
            Resultados.Insertar(20);
            Resultados.Imprimir();
            Resultados.Insertar(34);
            Resultados.Imprimir();
            Console.ReadKey();
        }
    }
}
