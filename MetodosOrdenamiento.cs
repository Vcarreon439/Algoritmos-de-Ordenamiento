using System;

namespace EDU4_Algoritmos
{
    public static class MetodosOrdenamiento
    {
        /// <summary>
        /// Metodo para llenar un arreglo
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arreglo"></param>
        /// /// <param name="tamaño"></param>
        public static void Llenar<T>(this T[] arreglo) where T : IComparable<T> 
        {
            Random rdm = new Random();

            for (int i = 0; i < arreglo.Length; i++)
            {
                T newval = (T)(Object)rdm.Next(0,1000);
                arreglo[i] = newval;
            }
        }


        /// <summary>
        /// Método Burbuja implementado como extensión
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arreglo">Arreglo a ordenar</param>
        public static void Burbuja<T>(this T[] arreglo) where T : IComparable<T>
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                for (int j = 0; j < arreglo.Length - 1; j++)
                {
                    if (arreglo[j].CompareTo(arreglo[j + 1]) > 0)
                    {
                        arreglo.Cambio(j, j+1);
                    }
                }
            }
        }

        /// <summary>
        /// Intercambia 2 elementos de un arreglo.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arreglo">Arrglo a modificar</param>
        /// <param name="valor1">Posicion del elemento 1</param>
        /// <param name="valor2">Posicion del elemento 2</param>
        private static void Cambio<T>(this T[] arreglo, int valor1, int valor2) where T : IComparable<T>
        {
            //Verificar dentro del rango
            if (arreglo.Length <= valor2 || arreglo.Length <= valor1)
                throw new IndexOutOfRangeException();

            //Intercambio
            T temporal = arreglo[valor1];
            arreglo[valor1] = arreglo[valor2];
            arreglo[valor2] = temporal;
        }

        /// <summary>
        /// Método ShellSort implementado como extensión
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arreglo">Arreglo a ordenar</param>
        public static void ShellSort<T>(this T[] arreglo) where T : IComparable<T>
        {
            // Distancia entre elementos que se van a comparar
            var d = arreglo.Length / 2;

            while (d >= 1)
            {
                for (var i = d; i < arreglo.Length; i++)
                {
                    var j = i;

                    while ((j >= d) && (arreglo.EsMayorQue(j,j-d)))
                    {
                        arreglo.Cambio(j, (j - d));
                        j = j - d;
                    }
                }

                d = d / 2;
            }
        }

        public static void RadixSort<T>(this T[] arreglo) where T : IComparable<T> 
        {
            int[] temp = new int[arreglo.Length];

            for (int shift = 31; shift > -1; shift --)
            {
                int j = 0;

                for (int i = 0; i < arreglo.Length; i++)
                {
                    bool mover = (Convert.ToInt32(arreglo[i]) << shift) >= 0;

                    if (shift==0 ? !mover : mover)
                    {
                        arreglo[i - j] = arreglo[i];
                    }
                    else
                    {
                        temp[j++] = Convert.ToInt32(arreglo[i]);
                    }
                }
                Array.Copy(temp, 0, arreglo,arreglo.Length - j, j);
            }
        }

        public static void QuickSort<T>(this T[] vector, int primero, int ultimo) where T : IComparable<T>
        {
            int[] Ctrl = { primero, ultimo, ((primero + ultimo) / 2) };
            int pivote;
            //central = (primero + ultimo) / 2;
            pivote = Convert.ToInt32(vector[Ctrl[2]]);
            //i = primero;
            //j = ultimo;
            do
            {
                while (Convert.ToInt32(vector[Ctrl[0]]) < pivote) Ctrl[0]++;
                while (Convert.ToInt32(vector[Ctrl[1]]) > pivote) Ctrl[1]--;
                if (Ctrl[0] <= Ctrl[1])
                {
                    int temp;
                    temp = Convert.ToInt32(vector[Ctrl[0]]);
                    vector[Ctrl[0]] = vector[Ctrl[1]];
                    //
                    T newval = (T)(Object)temp;
                    vector[Ctrl[1]] = newval;
                    Ctrl[0]++;
                    Ctrl[1]--;
                }
            } while (Ctrl[0] <= Ctrl[1]);

            if (primero < Ctrl[1])
                vector.QuickSort(primero, Ctrl[1]);

            if (Ctrl[0] < ultimo)
                vector.QuickSort(Ctrl[0], ultimo);
        }


        /// <summary>
        /// Comparación entre 2 elementos
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arreglo"></param>
        /// <param name="valor1"></param>
        /// <param name="valor2"></param>
        /// <returns>Booleano que establece si es mayor</returns>
        private static bool EsMayorQue<T>(this T[] arreglo, int valor1, int valor2) where T : IComparable<T> 
        {
            bool result = false;

            if (Convert.ToInt32(arreglo[valor1]) < Convert.ToInt32(arreglo[valor2]))
                result = true;

            return result;
        }

        /// <summary>
        /// Comparación entre 2 elementos
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arreglo"></param>
        /// <param name="valor1"></param>
        /// <param name="valor2"></param>
        /// <returns>Booleano que establece si es menor</returns>
        private static bool EsMenorQue<T>(this T[] arreglo, int valor1, int valor2) where T : IComparable<T>
        {
            bool result = false;

            if (Convert.ToInt32(arreglo[valor1]) > Convert.ToInt32(arreglo[valor2]))
                result = true;

            return result;
        }


        /// <summary>
        /// Metodo Imprimir implementado como extension
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arreglo">Arreglo a imprimir</param>
        public static void Imprimir<T>(this T[] arreglo) where T : IComparable<T> 
        {
            foreach (var item in arreglo)
                Console.WriteLine(item);
        }



    }
}
