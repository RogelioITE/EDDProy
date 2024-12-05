using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_Lineales.Clases
{
    internal class ListaSimple
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
                Inicio = nuevo;
                return;
            }

            Nodo actual = Inicio;
            Nodo previo = null;
            int pos = 1;

            while (pos < posicion && actual != null)
            {
                previo = actual;
                actual = actual.Sig;
                pos++;
            }

            if (actual != null)
            {
                nuevo.Sig = actual;
                previo.Sig = nuevo;
            }
            else
            {
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
                return dato;
            }

            Nodo actual = Inicio;
            Nodo previo = null;
            int pos = 1;

            while (pos < posicion && actual != null)
            {
                previo = actual;
                actual = actual.Sig;
                pos++;
            }

            if (actual != null)
            {
                int datoEliminado = actual.Dato;
                previo.Sig = actual.Sig;

                if (actual == Fin)
                    Fin = previo;

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