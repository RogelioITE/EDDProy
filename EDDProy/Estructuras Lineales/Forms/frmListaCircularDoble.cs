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
    public partial class frmListaCircularDoble : Form
    {
        private ListaCircularDoble listaCircularDoble;

        public frmListaCircularDoble()
        {
            InitializeComponent();
            listaCircularDoble = new ListaCircularDoble();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDato.Text, out int dato))
            {
                listaCircularDoble.Insertar(dato); // Llama al método Insertar de la clase
                txtDato.Clear();
                MostrarLista();
                MessageBox.Show($"Dato {dato} agregado correctamente a la lista.");
            }
            else
            {
                MessageBox.Show("Ingrese un número válido.");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarLista(); // Muestra los elementos de la lista
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstListaCircularDoble.SelectedItem != null)
            {
                int datoAEliminar = int.Parse(lstListaCircularDoble.SelectedItem.ToString());
                EliminarElemento(datoAEliminar);
                MostrarLista();
                MessageBox.Show($"Elemento {datoAEliminar} eliminado.");
            }
            else
            {
                MessageBox.Show("Seleccione un elemento de la lista para eliminar.");
            }
        }

        private void MostrarLista()
        {
            lstListaCircularDoble.Items.Clear();
            List<int> elementos = listaCircularDoble.Mostrar();
            foreach (var elemento in elementos)
            {
                lstListaCircularDoble.Items.Add(elemento);
            }
        }

        private void EliminarElemento(int dato)
        {
            // Implementa lógica para eliminar el nodo correspondiente
            MessageBox.Show($"Método de eliminación no implementado para {dato}."); // Puedes personalizar según necesidades
        }

        private void frmListaCircularDoble_Load(object sender, EventArgs e)
        {

        }
    }
}