using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_Fibonacci_Recursivo
{
    internal class Program
    {
        static int Metodo(int termino)
        {
            if (termino == 0 || termino == 1)
            {
                return termino;
            }
            else
            {
                return Metodo(termino - 1) + Metodo(termino-2);
            }

        }

        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de términos a mostrar: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Resultado");
            for (int i=0;i<cantidad;i++)
            {
                Console.WriteLine(""+Metodo(i));
            }
        }
    }
}
