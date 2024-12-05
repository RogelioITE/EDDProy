using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_Lineales.Clases
{
    internal class ListaCircularDoble
    {
        private Nodo Inicio, Fin;

        public void Insertar(int dato)
        {
            Nodo nuevo = new Nodo { Dato = dato };

            if (Inicio == null)
            {
                Inicio = nuevo;
                Fin = nuevo;
                Inicio.Prev = Fin;
                Fin.Sig = Inicio;
            }
            else
            {
                nuevo.Prev = Fin;
                nuevo.Sig = Inicio;
                Fin.Sig = nuevo;
                Inicio.Prev = nuevo;
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
    }
}
