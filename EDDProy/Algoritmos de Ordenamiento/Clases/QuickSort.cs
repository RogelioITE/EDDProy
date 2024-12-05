using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Algoritmos_de_Ordenamiento.Clases
{
    internal class QuickSort
    {
        // Método público para ordenar una lista
        public void Ordenar(List<int> lista)
        {
            QuickSortRecursive(lista, 0, lista.Count - 1);
        }

        // Método recursivo de QuickSort
        private void QuickSortRecursive(List<int> lista, int l, int h)
        {
            if (l < h)
            {
                int p = Particionar(lista, l, h);
                QuickSortRecursive(lista, l, p - 1);
                QuickSortRecursive(lista, p + 1, h);
            }
        }

        // Método de partición
        private int Particionar(List<int> lista, int l, int h)
        {
            int pivote = lista[h];
            int primerAlto = l;

            for (int i = l; i < h; i++)
            {
                if (lista[i] < pivote)
                {
                    Intercambiar(lista, i, primerAlto);
                    primerAlto++;
                }
            }

            // Colocar el pivote en su posición correcta
            Intercambiar(lista, primerAlto, h);
            return primerAlto;
        }

        // Método para intercambiar elementos en la lista
        private void Intercambiar(List<int> lista, int i, int j)
        {
            int temp = lista[i];
            lista[i] = lista[j];
            lista[j] = temp;
        }
    }
}
