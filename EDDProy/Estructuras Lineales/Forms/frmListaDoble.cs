using EDDemo.Estructuras_Lineales.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_Lineales.Forms
{
    public partial class frmListaDoble : Form
    {
        private ListaDoblementeEncadenada lista;

        public frmListaDoble()
        {
            InitializeComponent();
            lista = new ListaDoblementeEncadenada(); // Inicializar la lista doblemente encadenada
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDato.Text, out int dato) && int.TryParse(txtPosicion.Text, out int posicion))
            {
                lista.Insertar(posicion, dato); // Insertar el dato en la posición indicada
                txtDato.Clear();
                txtPosicion.Clear();
                MostrarLista(); // Actualizar el ListBox
                MessageBox.Show($"Dato {dato} insertado en la posición {posicion}.");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido para el dato y la posición.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtPosicion.Text, out int posicion))
            {
                try
                {
                    int eliminado = lista.Eliminar(posicion); // Eliminar el dato en la posición indicada
                    txtPosicion.Clear();
                    MostrarLista(); // Actualizar el ListBox
                    MessageBox.Show($"Dato {eliminado} eliminado de la posición {posicion}.");
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message); // Manejar errores, como lista vacía o posición inválida
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido para la posición.");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarLista(); // Actualizar el ListBox con los elementos actuales de la lista
        }

        private void MostrarLista()
        {
            lstListaDoble.Items.Clear(); // Limpiar el ListBox
            var elementos = lista.Mostrar(); // Obtener la lista de elementos
            foreach (var elemento in elementos)
            {
                lstListaDoble.Items.Add(elemento); // Mostrar cada elemento en el ListBox
            }
        }
        private void frmListaDoble_Load(object sender, EventArgs e)
        {
            // Método vacío para manejar el evento Load.
            // Puedes agregar lógica aquí si es necesario.
        }
    }
}