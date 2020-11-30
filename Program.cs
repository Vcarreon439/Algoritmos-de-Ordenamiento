using System;
using System.Diagnostics;

namespace EDU4_Algoritmos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Region de creacion del arreglo
            Stopwatch timeMeasure = new Stopwatch();
            timeMeasure.Start();
            //500, 1000, 10000
            int[] arreglo = new int[200];
            arreglo.Llenar();
            timeMeasure.Stop();
            Console.WriteLine("Creacion del Arreglo");
            Console.WriteLine($"Tiempo: {timeMeasure.Elapsed.TotalMilliseconds} ms");
            Console.WriteLine($"Precision: {(1.0 / Stopwatch.Frequency).ToString("E")} segundos");

            Console.WriteLine("_________________________________________");
            //arreglo.Imprimir();
            Console.WriteLine("_________________________________________");

            timeMeasure = new Stopwatch();
            timeMeasure.Start();
            arreglo.QuickSort(0, arreglo.Length-1);
            timeMeasure.Stop();
            Console.WriteLine("Acomdo del arreglo");
            Console.WriteLine($"Tiempo: {timeMeasure.Elapsed.TotalMilliseconds} ms");
            Console.WriteLine($"Precision: {(1.0 / Stopwatch.Frequency).ToString("E")} segundos");

            Console.WriteLine("_________________________________________");
            arreglo.Imprimir();
            Console.WriteLine("_________________________________________");

            /*if (Stopwatch.IsHighResolution)
                Console.WriteLine("Alta precisión");
            else
                Console.WriteLine("Baja precisión");*/




            Console.ReadKey();


            /*
            arreglo.Imprimir();
            Console.WriteLine();
            arreglo.QuickSort(0, arreglo.Length - 1);
            arreglo.Imprimir();
            Console.ReadKey();*/

        }
    }
}
