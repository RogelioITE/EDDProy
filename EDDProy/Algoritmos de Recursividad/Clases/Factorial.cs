using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace EDDemo.Algoritmos_de_Recursividad.Clases
{
    internal class Factorial
    {
        public int ContadorOperaciones { get; private set; }

        public Factorial()
        {
            ContadorOperaciones = 0;
        }

        public (BigInteger resultado, long tiempo) Calcular(BigInteger n)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            ContadorOperaciones = 0;

            BigInteger resultado = CalcularFactorial(n);

            stopwatch.Stop();
            return (resultado, stopwatch.ElapsedMilliseconds);
        }

        private BigInteger CalcularFactorial(BigInteger n)
        {
            ContadorOperaciones++;
            if (n < 0)
                throw new ArgumentException("El factorial no está definido para números negativos.");
            if (n == 0) return 1;
            return n * CalcularFactorial(n - 1);
        }

        public string Complejidad()
        {
            return "Complejidad: O(n)";
        }
    }
}