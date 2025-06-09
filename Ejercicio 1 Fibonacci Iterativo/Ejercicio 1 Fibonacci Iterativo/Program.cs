using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anterior = 0;
            int actual = 1;

            Console.WriteLine("Ingrese cantidad de terminos");
            int terminos = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < terminos; i++)
            {
                Console.WriteLine("=" + actual);

                int siguiente = anterior + actual;

                anterior = actual;

                actual = siguiente;
            }
        }
    }
}
