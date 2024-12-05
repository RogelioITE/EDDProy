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
    public partial class frmListaSimple : Form
    {
        private ListaSimple lista;

        public frmListaSimple()
        {
            InitializeComponent();
            lista = new ListaSimple(); // Instancia de la clase ListaSimple
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                int dato = int.Parse(txtDato.Text);
                int posicion = string.IsNullOrEmpty(txtPosicion.Text) ? 1 : int.Parse(txtPosicion.Text);

                lista.Insertar(posicion, dato);
                MostrarLista(); // Actualiza la lista mostrada en el ListBox

                txtDato.Clear();
                txtPosicion.Clear();
                MessageBox.Show("Dato insertado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int posicion = string.IsNullOrEmpty(txtPosicion.Text) ? 1 : int.Parse(txtPosicion.Text);

                int eliminado = lista.Eliminar(posicion);
                MostrarLista(); // Actualiza la lista mostrada en el ListBox

                txtPosicion.Clear();
                MessageBox.Show($"Dato eliminado: {eliminado}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarLista();
        }

        private void MostrarLista()
        {
            lstListaSimple.Items.Clear(); // Limpia el ListBox
            foreach (int dato in lista.Mostrar())
            {
                lstListaSimple.Items.Add(dato); // Muestra cada dato de la lista
            }
        }
    }
}