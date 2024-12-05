using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Algoritmos_de_Recursividad.Clases
{
    internal class SumaArreglo
    {
        public int ContadorOperaciones { get; private set; }

        public SumaArreglo()
        {
            ContadorOperaciones = 0;
        }

        public (int suma, long tiempo) Calcular(int[] arr)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            ContadorOperaciones = 0;

            int resultado = CalcularSuma(arr, arr.Length);

            stopwatch.Stop();
            return (resultado, stopwatch.ElapsedMilliseconds);
        }

        private int CalcularSuma(int[] arr, int n)
        {
            ContadorOperaciones++;
            if (n == 0) return 0;
            return arr[n - 1] + CalcularSuma(arr, n - 1);
        }

        public string Complejidad()
        {
            return "Complejidad: O(n)";
        }
    }
}
