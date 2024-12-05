using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Algoritmos_de_Ordenamiento.Clases
{
    internal class Burbuja
    {
        // Método de ordenamiento Burbuja
        public void MetodoBurbuja(int[] arreglo)
        {
            int n = arreglo.Length;
            for (int i = 0; i < n - 1; i++)
            {
                // Bandera para optimización
                bool huboIntercambio = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arreglo[j] > arreglo[j + 1])
                    {
                        // Intercambio de elementos
                        int temp = arreglo[j];
                        arreglo[j] = arreglo[j + 1];
                        arreglo[j + 1] = temp;
                        huboIntercambio = true;
                    }
                }
                // Si no hubo intercambios, la lista ya está ordenada
                if (!huboIntercambio)
                    break;
            }
        }
    }
}