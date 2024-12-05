using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Algoritmos_de_Recursividad.Clases
{
    internal class Fibonacci
    {
        public int ContadorOperaciones { get; private set; }

        public Fibonacci()
        {
            ContadorOperaciones = 0;
        }

        public (long resultado, long tiempo) Calcular(int n)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            ContadorOperaciones = 0;

            long resultado = CalcularFibonacci(n);

            stopwatch.Stop();
            return (resultado, stopwatch.ElapsedMilliseconds);
        }

        private long CalcularFibonacci(int n)
        {
            ContadorOperaciones++;
            if (n < 0)
                throw new ArgumentException("La secuencia de Fibonacci no está definida para números negativos.");
            if (n == 0) return 0;
            if (n == 1) return 1;
            return CalcularFibonacci(n - 1) + CalcularFibonacci(n - 2);
        }

        public string Complejidad()
        {
            return "Complejidad: O(2^n)";
        }
    }
}