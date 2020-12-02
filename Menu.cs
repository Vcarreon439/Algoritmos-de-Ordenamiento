using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDU4_Algoritmos
{
    /// <summary>
    /// Para futuras implementaciones.
    /// </summary>
    public static class Menu
    {
        public static void MenuL1(ref Lista_Enlazad lista) 
        {
            bool rep = true;
            try
            {
                do
                {
                    Console.Clear();
                    Console.Title = "Menu Principal - Programa Ordenamiento";
                    Console.WriteLine("1.-Crear Arreglo");
                    Console.WriteLine("2.-Mostrar Arreglos");
                    Console.WriteLine("3.-Arreglos predefinidos");
                    Console.WriteLine("4.-Arreglo aleatorio");
                    Console.WriteLine("5.-Ordenar Arreglo");
                    Console.WriteLine("6.-Información del programa");
                    Console.WriteLine("7.-Salir del Programa");

                    switch (int.Parse(Console.ReadLine()))
                    {

                        case 1:
                            CrearArreglo(ref lista);
                            break;

                        case 2:
                            Lista_Enlazad.Mostrar(lista);
                            Console.ReadKey();
                            rep = true;
                            break;

                        case 3:
                            break;

                        case 4:
                            break;

                        case 5:
                            break;

                        case 6:
                            Console.Title = "Información";
                            Console.Clear();
                            Console.WriteLine("Materia: Estructura de Datos");
                            Console.WriteLine("Docente: ING.NANCY GABRIELA MARÍN CASTAÑEDA");
                            Console.WriteLine("Tercer Semestre | Grupo A | Agosto - Diciembre");
                            Console.WriteLine("Programa hecho por:");
                            Console.WriteLine("\tVictor Hugo Carreon Pulido -192310436");
                            Console.WriteLine("\tAndrea Evelyn Mejia Rubio -192310177");
                            Console.WriteLine( "\tEdgar Eduardo Arguijo Vazquez -192310252");
                            Console.ReadKey();
                            rep = true;
                            break;

                        case 7:
                            Environment.Exit(0);
                            break;


                        default:
                            Console.Clear();
                            Console.WriteLine("Elija una opción válida");
                            rep = true;
                            break;
                    }

                } while (rep);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static public void CrearArreglo(ref Lista_Enlazad list) 
        {
            int[] arreglo = null;
            bool rep = true;
            do
            {
                try
                {
                    Console.Write("Escriba el nombre de su arreglo:");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Escriba los elementos del arreglo separados por un espacio");
                    string elementos = Console.ReadLine();
                    arreglo = Array.ConvertAll(elementos.Split(' '), s => int.Parse(s));
                    NodoLista nodo = new NodoLista(arreglo, nombre);
                    list.InsertarALaCabeza(nodo);
                    rep = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    rep = true;
                }

            } while (rep);
        }
    }
    
}
