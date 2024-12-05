using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Algoritmos_de_Ordenamiento.Clases
{
    internal class ShellSort
    {
        public void Ordenar(List<int> lista)
        {
            int n = lista.Count;
            int intervalo = n / 2;

            while (intervalo >= 1)
            {
                for (int i = 0; i + intervalo < n; i++)
                {
                    int j = i;
                    while (j >= 0)
                    {
                        int k = j + intervalo;
                        if (lista[j] > lista[k])
                        {
                            // Intercambiar elementos
                            Intercambiar(lista, j, k);
                            j -= intervalo;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                intervalo /= 2;
            }
        }

        private void Intercambiar(List<int> lista, int i, int j)
        {
            int temp = lista[i];
            lista[i] = lista[j];
            lista[j] = temp;
        }
    }
}