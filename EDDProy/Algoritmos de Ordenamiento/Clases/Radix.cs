using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Algoritmos_de_Ordenamiento.Clases
{
    internal class Radix
    {
        public void Ordenar(int[] arreglo)
        {
            int max = ObtenerMax(arreglo);

            // Aplicar Counting Sort para cada posición decimal
            for (int pos = 1; max / pos > 0; pos *= 10)
            {
                CountSort(arreglo, pos);
            }
        }

        private int ObtenerMax(int[] arreglo)
        {
            int max = arreglo[0];
            foreach (var num in arreglo)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }

        private void CountSort(int[] arreglo, int pos)
        {
            int n = arreglo.Length;
            int[] output = new int[n];
            int[] count = new int[10];

            // Calcular la frecuencia de los dígitos
            for (int i = 0; i < n; i++)
            {
                int digito = (arreglo[i] / pos) % 10;
                count[digito]++;
            }

            // Modificar el array de conteo para que contenga las posiciones acumuladas
            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            // Construir el array ordenado
            for (int i = n - 1; i >= 0; i--)
            {
                int digito = (arreglo[i] / pos) % 10;
                output[count[digito] - 1] = arreglo[i];
                count[digito]--;
            }

            // Copiar los elementos ordenados de vuelta al arreglo original
            for (int i = 0; i < n; i++)
            {
                arreglo[i] = output[i];
            }
        }
    }
}
