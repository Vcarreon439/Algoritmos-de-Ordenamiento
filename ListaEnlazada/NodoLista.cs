using System;

namespace EDU4_Algoritmos
{
    public class NodoLista
    {
        //Añadir la clase Nodo

        //Atributo que almacena el valor del nodo
        public int[] ArrInt;
        
        /*Clase autorefenciada, atributo que indica en que 
        localidad de memoria esta el sigueinte nodo*/
        public NodoLista SiguienteNodo;

        ////Nombre con el que se identificara al nodo
        public string Nombre;

        public NodoLista(int[] arreglo, string nombre) 
        {
            this.ArrInt = arreglo;
            this.Nombre = nombre;
        }

        public NodoLista()
        {

        }
    }
}

