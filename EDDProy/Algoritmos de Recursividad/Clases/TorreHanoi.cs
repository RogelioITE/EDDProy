using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Algoritmos_de_Recursividad.Clases
{
    internal class TorreHanoi
    {
        public int ContadorOperaciones { get; private set; }

        public TorreHanoi()
        {
            ContadorOperaciones = 0;
        }

        public (long tiempo, int movimientos) Resolver(int n, char fromRod, char toRod, char auxRod, Action<string> mostrarMovimiento)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            ContadorOperaciones = 0;

            ResolverHanoi(n, fromRod, toRod, auxRod, mostrarMovimiento);

            stopwatch.Stop();
            return (stopwatch.ElapsedMilliseconds, ContadorOperaciones);
        }

        private void ResolverHanoi(int n, char fromRod, char toRod, char auxRod, Action<string> mostrarMovimiento)
        {
            ContadorOperaciones++;
            if (n == 1)
            {
                mostrarMovimiento($"Mover disco 1 de {fromRod} a {toRod}");
                return;
            }
            ResolverHanoi(n - 1, fromRod, auxRod, toRod, mostrarMovimiento);
            mostrarMovimiento($"Mover disco {n} de {fromRod} a {toRod}");
            ResolverHanoi(n - 1, auxRod, toRod, fromRod, mostrarMovimiento);
        }

        public string Complejidad()
        {
            return "Complejidad: O(2^n)";
        }
    }
}
