using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_No_Lineales
{
    public class ArbolBusqueda
    {
        private NodoBinario Raiz;
        public string strArbol;
        public string strRecorrido;

        public ArbolBusqueda()
        {
            Raiz = null;
            strArbol = "";
            strRecorrido = "";
        }

        public bool EstaVacio()
        {
            return Raiz == null;
        }

        public NodoBinario RegresaRaiz()
        {
            return Raiz;
        }

        // Método para verificar si un valor ya existe en el árbol
        public bool ExisteNodo(int Dato, NodoBinario Nodo)
        {
            if (Nodo == null) return false;
            if (Nodo.Dato == Dato) return true;

            // Buscar en el subárbol izquierdo o derecho según el valor
            if (Dato < Nodo.Dato)
                return ExisteNodo(Dato, Nodo.Izq);
            else
                return ExisteNodo(Dato, Nodo.Der);
        }

        public void InsertaNodo(int Dato, ref NodoBinario Nodo)
        {
            // Si el nodo es nulo, se crea uno nuevo
            if (Nodo == null)
            {
                Nodo = new NodoBinario(Dato);
                if (Raiz == null)
                    Raiz = Nodo;
            }
            else if (Dato < Nodo.Dato)
            {
                InsertaNodo(Dato, ref Nodo.Izq);
            }
            else if (Dato > Nodo.Dato)
            {
                InsertaNodo(Dato, ref Nodo.Der);
            }
            else
            {
                // Si el dato ya existe en el árbol, no se inserta (nodo duplicado)
                return;
            }
        }


        public void MuestraArbolAcostado(int nivel, NodoBinario nodo)
        {
            if (nodo == null)
                return;

            MuestraArbolAcostado(nivel + 1, nodo.Der);
            strArbol += new string(' ', 6 * nivel) + nodo.Dato + "\r\n";
            MuestraArbolAcostado(nivel + 1, nodo.Izq);

            // Mensaje de depuración
            Console.WriteLine($"Nivel {nivel}: {nodo.Dato}");
        }



        public string ToDot(NodoBinario nodo)
        {
            StringBuilder b = new StringBuilder();
            if (nodo.Izq != null)
            {
                b.AppendFormat("{0}->{1} [side=L] {2} ", nodo.Dato, nodo.Izq.Dato, Environment.NewLine);
                b.Append(ToDot(nodo.Izq));
            }

            if (nodo.Der != null)
            {
                b.AppendFormat("{0}->{1} [side=R] {2} ", nodo.Dato, nodo.Der.Dato, Environment.NewLine);
                b.Append(ToDot(nodo.Der));
            }
            return b.ToString();
        }

        public void PreOrden(NodoBinario nodo)
        {
            if (nodo == null) return;

            strRecorrido += nodo.Dato + ", ";
            PreOrden(nodo.Izq);
            PreOrden(nodo.Der);
        }

        public void InOrden(NodoBinario nodo)
        {
            if (nodo == null) return;

            InOrden(nodo.Izq);
            strRecorrido += nodo.Dato + ", ";
            InOrden(nodo.Der);
        }

        public void PostOrden(NodoBinario nodo)
        {
            if (nodo == null) return;

            PostOrden(nodo.Izq);
            PostOrden(nodo.Der);
            strRecorrido += nodo.Dato + ", ";
        }

        public void podarArbol(ref NodoBinario nodo)
        {
            if (nodo == null)
            {
                return;
            }

            // Llama recursivamente para eliminar el subárbol izquierdo y derecho
            podarArbol(ref nodo.Izq);
            podarArbol(ref nodo.Der);

            // Elimina el nodo actual
            nodo = null;
        }

        public bool EliminarNodoConPredecesor(int valor, ref NodoBinario nodo)
        {
            if (nodo == null) return false;

            if (valor < nodo.Dato)
            {
                return EliminarNodoConPredecesor(valor, ref nodo.Izq);
            }
            else if (valor > nodo.Dato)
            {
                return EliminarNodoConPredecesor(valor, ref nodo.Der);
            }
            else // Encontró el nodo a eliminar
            {
                if (nodo.Izq != null && nodo.Der != null)
                {
                    // Encontrar el predecesor (máximo en el subárbol izquierdo)
                    NodoBinario predecesor = nodo.Izq;
                    NodoBinario parentPredecesor = nodo;
                    while (predecesor.Der != null)
                    {
                        parentPredecesor = predecesor;
                        predecesor = predecesor.Der;
                    }
                    nodo.Dato = predecesor.Dato; // Reemplaza valor del nodo actual
                    return EliminarNodoConPredecesor(predecesor.Dato, ref nodo.Izq); // Elimina el predecesor
                }
                else
                {
                    // Caso con uno o ningún hijo
                    nodo = (nodo.Izq != null) ? nodo.Izq : nodo.Der;
                }
                return true;
            }
        }

        public bool EliminarNodoConSucesor(int valor, ref NodoBinario nodo)
        {
            if (nodo == null) return false;

            if (valor < nodo.Dato)
            {
                return EliminarNodoConSucesor(valor, ref nodo.Izq);
            }
            else if (valor > nodo.Dato)
            {
                return EliminarNodoConSucesor(valor, ref nodo.Der);
            }
            else // Encontró el nodo a eliminar
            {
                if (nodo.Izq != null && nodo.Der != null)
                {
                    // Encontrar el sucesor (mínimo en el subárbol derecho)
                    NodoBinario sucesor = nodo.Der;
                    NodoBinario parentSucesor = nodo;
                    while (sucesor.Izq != null)
                    {
                        parentSucesor = sucesor;
                        sucesor = sucesor.Izq;
                    }
                    nodo.Dato = sucesor.Dato; // Reemplaza valor del nodo actual
                    return EliminarNodoConSucesor(sucesor.Dato, ref nodo.Der); // Elimina el sucesor
                }
                else
                {
                    // Caso con uno o ningún hijo
                    nodo = (nodo.Izq != null) ? nodo.Izq : nodo.Der;
                }
                return true;
            }
        }

        public void RecorrerPorNiveles(NodoBinario nodo, ref string recorrido)
        {
            if (nodo == null)
            {
                recorrido = "El árbol está vacío.";
                return;
            }

            Queue<NodoBinario> cola = new Queue<NodoBinario>();
            cola.Enqueue(nodo);

            while (cola.Count > 0)
            {
                NodoBinario actual = cola.Dequeue();
                recorrido += actual.Dato + " "; // Agrega el dato del nodo al recorrido

                if (actual.Izq != null)
                    cola.Enqueue(actual.Izq);
                if (actual.Der != null)
                    cola.Enqueue(actual.Der);
            }
        }
        public int ObtenerAltura(NodoBinario nodo)
        {
            if (nodo == null)
                return 0;

            int alturaIzquierda = ObtenerAltura(nodo.Izq);
            int alturaDerecha = ObtenerAltura(nodo.Der);

            // Altura del nodo actual es la mayor altura de sus subárboles + 1
            return Math.Max(alturaIzquierda, alturaDerecha) + 1;
        }

        public int ContarHojas(NodoBinario nodo)
        {
            if (nodo == null)
                return 0;

            // Si el nodo no tiene hijos, es una hoja
            if (nodo.Izq == null && nodo.Der == null)
                return 1;

            // Llama recursivamente en ambos subárboles y suma el resultado
            return ContarHojas(nodo.Izq) + ContarHojas(nodo.Der);
        }
        public int ContarNodos(NodoBinario nodo)
        {
            if (nodo == null)
                return 0;

            // Cuenta el nodo actual y llama recursivamente para los nodos izquierdo y derecho
            return 1 + ContarNodos(nodo.Izq) + ContarNodos(nodo.Der);
        }
        public bool EsCompleto(NodoBinario nodo, int index, int cantidadNodos)
        {
            // Un árbol vacío es completo
            if (nodo == null)
                return true;

            // Si el índice de un nodo es mayor o igual al número total de nodos, no es completo
            if (index >= cantidadNodos)
                return false;

            // Verificar recursivamente en los subárboles izquierdo y derecho
            return EsCompleto(nodo.Izq, 2 * index + 1, cantidadNodos) &&
                   EsCompleto(nodo.Der, 2 * index + 2, cantidadNodos);
        }
        public bool EsLleno(NodoBinario nodo)
        {
            if (nodo == null)
                return true;

            // Si el nodo tiene exactamente dos hijos, continúa revisando
            if (nodo.Izq != null && nodo.Der != null)
                return EsLleno(nodo.Izq) && EsLleno(nodo.Der);

            // Si el nodo no tiene hijos, es una hoja, por lo que también es válido
            if (nodo.Izq == null && nodo.Der == null)
                return true;

            // Si el nodo tiene solo un hijo, no es un árbol binario lleno
            return false;
        }
    }
}