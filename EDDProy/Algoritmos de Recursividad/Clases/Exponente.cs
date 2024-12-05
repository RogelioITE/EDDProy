using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace EDDemo.Algoritmos_de_Recursividad.Clases
{
    internal class Exponente
    {
        public int ContadorOperaciones { get; private set; }

        public Exponente()
        {
            ContadorOperaciones = 0;
        }

        public (BigInteger resultado, long tiempo) Calcular(BigInteger baseNum, BigInteger exp)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            ContadorOperaciones = 0;

            BigInteger resultado = CalcularExponente(baseNum, exp);

            stopwatch.Stop();
            return (resultado, stopwatch.ElapsedMilliseconds);
        }

        private BigInteger CalcularExponente(BigInteger baseNum, BigInteger exp)
        {
            ContadorOperaciones++;
            if (exp < 0)
                throw new ArgumentException("El exponente no soporta valores negativos en esta implementación.");
            if (exp == 0) return 1;
            return baseNum * CalcularExponente(baseNum, exp - 1);
        }

        public string Complejidad()
        {
            return "Complejidad: O(n)";
        }
    }
}
