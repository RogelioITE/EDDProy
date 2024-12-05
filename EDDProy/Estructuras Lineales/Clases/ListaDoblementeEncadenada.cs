using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_Lineales.Clases
{
    internal class ListaDoblementeEncadenada
    {
        private Nodo Inicio, Fin;

        public void Insertar(int posicion, int dato)
        {
            Nodo nuevo = new Nodo { Dato = dato };

            if (Inicio == null)
            {
                Inicio = nuevo;
                Fin = nuevo;
                return;
            }

            if (posicion <= 1)
            {
                nuevo.Sig = Inicio;
                Inicio.Prev = nuevo;
                Inicio = nuevo;
                return;
            }

            Nodo actual = Inicio;
            int pos = 1;

            while (pos < posicion && actual != null)
            {
                actual = actual.Sig;
                pos++;
            }

            if (actual != null)
            {
                nuevo.Sig = actual;
                nuevo.Prev = actual.Prev;
                actual.Prev.Sig = nuevo;
                actual.Prev = nuevo;
            }
            else
            {
                nuevo.Prev = Fin;
                Fin.Sig = nuevo;
                Fin = nuevo;
            }
        }

        public int Eliminar(int posicion)
        {
            if (Inicio == null)
                throw new InvalidOperationException("La lista está vacía.");

            if (posicion <= 1)
            {
                int dato = Inicio.Dato;
                Inicio = Inicio.Sig;
                if (Inicio != null)
                    Inicio.Prev = null;
                else
                    Fin = null;
                return dato;
            }

            Nodo actual = Inicio;
            int pos = 1;

            while (pos < posicion && actual != null)
            {
                actual = actual.Sig;
                pos++;
            }

            if (actual != null)
            {
                int datoEliminado = actual.Dato;
                if (actual.Sig != null)
                    actual.Sig.Prev = actual.Prev;
                else
                    Fin = actual.Prev;

                actual.Prev.Sig = actual.Sig;
                return datoEliminado;
            }
            throw new InvalidOperationException("Posición no encontrada.");
        }

        public List<int> Mostrar()
        {
            var elementos = new List<int>();
            Nodo actual = Inicio;
            while (actual != null)
            {
                elementos.Add(actual.Dato);
                actual = actual.Sig;
            }
            return elementos;
        }
    }
}
