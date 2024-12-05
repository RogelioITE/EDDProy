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
    public partial class frmListaCircularSimple : Form
    {
        private ListaCircularSimple listaCircular;

        public frmListaCircularSimple()
        {
            InitializeComponent();
            listaCircular = new ListaCircularSimple(); // Inicializar la lista circular
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDato.Text, out int dato))
            {
                listaCircular.Insertar(dato); // Insertar el dato en la lista circular
                txtDato.Clear();
                MostrarLista(); // Mostrar la lista actualizada
                MessageBox.Show($"Dato {dato} insertado en la lista circular.");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarLista(); // Mostrar los elementos actuales de la lista circular
        }

        private void MostrarLista()
        {
            lstListaCircular.Items.Clear(); // Limpiar el ListBox
            var elementos = listaCircular.Mostrar(); // Obtener los elementos de la lista circular
            foreach (var elemento in elementos)
            {
                lstListaCircular.Items.Add(elemento); // Agregar cada elemento al ListBox
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtPosicion.Text, out int posicion))
            {
                try
                {
                    int eliminado = listaCircular.Eliminar(posicion);
                    MostrarLista(); // Actualiza la lista
                    MessageBox.Show($"Dato {eliminado} eliminado de la lista circular.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una posición válida.");
            }
        }

        private void frmListaCircularSimple_Load(object sender, EventArgs e)
        {

        }
    }
}