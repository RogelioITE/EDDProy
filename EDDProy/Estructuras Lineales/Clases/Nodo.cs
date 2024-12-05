using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_Lineales.Clases
{
    internal class Nodo
    {
        public int Dato; // Dato almacenado en el nodo
        public Nodo Sig; // Siguiente nodo (para listas simples, circulares, colas y pilas)
        public Nodo Prev; // Nodo anterior (para listas dobles y circulares dobles)
    }
}
