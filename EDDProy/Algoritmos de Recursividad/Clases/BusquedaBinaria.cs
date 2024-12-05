using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Algoritmos_de_Recursividad.Clases
{
    internal class BusquedaBinaria
    {
        public int ContadorOperaciones { get; private set; }

        public BusquedaBinaria()
        {
            ContadorOperaciones = 0;
        }

        public (int indice, long tiempo) Buscar(int[] arr, int x)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            ContadorOperaciones = 0;

            int resultado = BuscarRecursivo(arr, 0, arr.Length - 1, x);

            stopwatch.Stop();
            return (resultado, stopwatch.ElapsedMilliseconds);
        }

        private int BuscarRecursivo(int[] arr, int low, int high, int x)
        {
            ContadorOperaciones++;
            if (high >= low)
            {
                int mid = low + (high - low) / 2;

                if (arr[mid] == x) return mid;
                if (arr[mid] > x) return BuscarRecursivo(arr, low, mid - 1, x);

                return BuscarRecursivo(arr, mid + 1, high, x);
            }
            return -1;
        }

        public string Complejidad()
        {
            return "Complejidad: O(log n)";
        }
    }
}
