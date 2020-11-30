using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDU4_Algoritmos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = { 4, 8, 90, 23, 1, 67, 54, 16 };
            arreglo.Imprimir();
            Console.WriteLine();
            arreglo.Burbuja();
            arreglo.Imprimir();
            Console.ReadKey();

        }
    }
}
