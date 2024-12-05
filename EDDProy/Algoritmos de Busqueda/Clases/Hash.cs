using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Algoritmos_de_Busqueda.Clases
{
    public class Hash
    {
        private readonly int _tam; // Tamaño de la tabla hash
        private readonly LinkedList<KeyValuePair<int, string>>[] _tabla; // Array de listas enlazadas

        public Hash(int tam)
        {
            _tam = tam;
            _tabla = new LinkedList<KeyValuePair<int, string>>[tam];

            for (int i = 0; i < tam; i++)
            {
                _tabla[i] = new LinkedList<KeyValuePair<int, string>>();
            }
        }

        // Método para insertar clave y valor en la tabla hash
        public void Insertar(int clave, string valor)
        {
            int index = HashFunction(clave);

            foreach (var pair in _tabla[index])
            {
                if (pair.Key == clave)
                {
                    throw new Exception("La clave ya existe en la tabla hash.");
                }
            }

            _tabla[index].AddLast(new KeyValuePair<int, string>(clave, valor));
        }

        // Método para buscar un valor por su clave en la tabla hash
        public string Buscar(int clave)
        {
            int index = HashFunction(clave);

            foreach (var pair in _tabla[index])
            {
                if (pair.Key == clave)
                {
                    return pair.Value;
                }
            }

            return "No encontrado";
        }

        // Método para limpiar la tabla hash
        public void Limpiar()
        {
            for (int i = 0; i < _tam; i++)
            {
                _tabla[i].Clear();
            }
        }

        // Función de hash para calcular el índice
        private int HashFunction(int clave)
        {
            return clave % _tam;
        }
    }
}