using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_Lineales.Clases
{
    internal class Cola
    {
        private Nodo Primero, Ultimo;

        // Método para encolar (agregar al final)
        public void Queue(int dato)
        {
            Nodo nuevo = new Nodo { Dato = dato, Sig = null };

            if (Ultimo == null)
            {
                // Si la cola está vacía
                Primero = Ultimo = nuevo;
            }
            else
            {
                Ultimo.Sig = nuevo; // El último apunta al nuevo nodo
                Ultimo = nuevo;     // Actualizamos el último
            }
        }

        // Método para desencolar (eliminar del frente)
        public int DeQueue()
        {
            if (Primero == null)
            {
                return -1; // Cola vacía
            }

            int dato = Primero.Dato; // Obtenemos el dato del nodo al frente
            Primero = Primero.Sig;   // Avanzamos al siguiente nodo

            if (Primero == null)
            {
                Ultimo = null; // Si la cola quedó vacía
            }

            return dato;
        }

        // Método para obtener el primer nodo de la cola
        public Nodo ObtenerPrimero()
        {
            return Primero; // Devuelve el nodo al frente de la cola
        }
    }
}