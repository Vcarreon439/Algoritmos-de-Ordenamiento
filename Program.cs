using System;
using System.Diagnostics;

namespace EDU4_Algoritmos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Predefinido = { 4,8,90,32,1,67,54,16};
            Predefinido.Imprimir();
            Console.WriteLine("________________________");
            Predefinido.Burbuja();
            Predefinido.Imprimir();
            Console.WriteLine("________________________");
            Console.ReadKey();
        }
    }
}


