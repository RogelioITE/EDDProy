using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_Lineales.Clases
{
    internal class Pila
    {
        public class Pilas
        {
            private Nodo top; // Nodo superior de la pila

            public Pilas()
            {
                top = null;
            }

            public Nodo ObtenerTop()
            {
                return top;
            }

            public void Push(int dato, ListBox lstPila)
            {
                Nodo nuevo = new Nodo(dato);
                nuevo.sig = top;
                top = nuevo;

                lstPila.Items.Insert(0, $"Dato {dato} insertado en la pila."); // Muestra el dato insertado
            }

            public void Pop(ListBox lstPila)
            {
                if (top == null)
                {
                    lstPila.Items.Add("Pila vacía."); // Mensaje si la pila está vacía
                }
                else
                {
                    Nodo aux = top;
                    top = top.sig;
                    lstPila.Items.Insert(0, $"Dato {aux.Dato} eliminado de la pila."); // Muestra el dato eliminado
                }
            }

            public void Mostrar(ListBox lstPila)
            {
                lstPila.Items.Clear();
                if (top == null)
                {
                    lstPila.Items.Add("Pila vacía.");
                }
                else
                {
                    lstPila.Items.Add("Contenido de la pila:");
                    Nodo actual = top;
                    int posicion = 0;
                    while (actual != null)
                    {
                        lstPila.Items.Add($"[{posicion}] -> {actual.Dato}");
                        actual = actual.sig;
                        posicion++;
                    }
                }
            }
        }

        public class Nodo
        {
            public int Dato { get; set; } // Dato almacenado en el nodo
            public Nodo sig { get; set; } // Siguiente nodo

            public Nodo(int dato)
            {
                Dato = dato;
                sig = null;
            }
        }
    }
}