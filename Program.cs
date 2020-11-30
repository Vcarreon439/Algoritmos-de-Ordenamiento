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
            int[] arreglo = new int[50];
            arreglo.Llenar();
            arreglo.Imprimir();
            Console.WriteLine();
            arreglo.QuickSort(0, arreglo.Length - 1);
            arreglo.Imprimir();
            Console.ReadKey();

        }
    }
}
