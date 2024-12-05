using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Algoritmos_de_Busqueda.Clases
{
    internal class Binaria
    {
        public int Buscar(int[] arreglo, int objetivo)
        {
            int izquierda = 0;
            int derecha = arreglo.Length - 1;

            while (izquierda <= derecha)
            {
                int medio = (izquierda + derecha) / 2;

                if (arreglo[medio] == objetivo)
                    return medio; // Retorna el índice donde se encuentra el objetivo.

                if (arreglo[medio] < objetivo)
                    izquierda = medio + 1; // El objetivo está en la mitad derecha.
                else
                    derecha = medio - 1; // El objetivo está en la mitad izquierda.
            }

            return -1; // Retorna -1 si no se encuentra el objetivo.
        }
    }
}
