using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_Lineales.Clases
{
    internal class ListaCircularSimple
    {
        private Nodo Inicio, Fin;

        public void Insertar(int dato)
        {
            Nodo nuevo = new Nodo { Dato = dato };

            if (Inicio == null)
            {
                Inicio = nuevo;
                Fin = nuevo;
                Fin.Sig = Inicio;
            }
            else
            {
                Fin.Sig = nuevo;
                nuevo.Sig = Inicio;
                Fin = nuevo;
            }
        }

        public List<int> Mostrar()
        {
            var elementos = new List<int>();
            if (Inicio == null)
                return elementos;

            Nodo actual = Inicio;
            do
            {
                elementos.Add(actual.Dato);
                actual = actual.Sig;
            } while (actual != Inicio);

            return elementos;
        }
        public int Eliminar(int posicion)
        {
            if (Inicio == null)
                throw new InvalidOperationException("La lista está vacía.");

            Nodo actual = Inicio;
            Nodo previo = Fin;
            int pos = 1;

            if (posicion == 1)
            {
                int dato = Inicio.Dato;
                if (Inicio == Fin) // Caso de un único elemento
                {
                    Inicio = null;
                    Fin = null;
                }
                else
                {
                    Inicio = Inicio.Sig;
                    Fin.Sig = Inicio;
                }
                return dato;
            }

            do
            {
                if (pos == posicion)
                {
                    int dato = actual.Dato;
                    previo.Sig = actual.Sig;

                    if (actual == Fin)
                        Fin = previo;

                    return dato;
                }
                previo = actual;
                actual = actual.Sig;
                pos++;
            } while (actual != Inicio);

            throw new InvalidOperationException("Posición no encontrada.");
        }

    }
}
