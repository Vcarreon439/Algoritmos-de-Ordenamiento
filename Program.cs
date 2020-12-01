using System;
using System.Diagnostics;

namespace EDU4_Algoritmos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Predefinido = { 15, 67, 08, 16, 44, 27, 12, 35 };
            Predefinido.Imprimir();
            Console.WriteLine("________________________");
            Predefinido.Burbuja();
            Predefinido.Imprimir();
            Console.WriteLine("________________________");
            Console.ReadKey();
        }
    }
}


