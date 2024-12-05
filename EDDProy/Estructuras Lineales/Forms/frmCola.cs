using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Estructuras_Lineales.Clases;

namespace EDDemo.Estructuras_Lineales.Forms
{
    public partial class frmCola : Form
    {
        private Cola cola;

        public frmCola()
        {
            InitializeComponent();
            cola = new Cola(); // Inicializamos la clase Cola
        }

        private void MostrarCola()
        {
            lstCola.Items.Clear(); // Limpia el ListBox antes de mostrar la cola.

            Nodo actual = cola.ObtenerPrimero(); // Obtén el primer nodo de la cola.

            if (actual == null)
            {
                lstCola.Items.Add("La cola está vacía.");
                return;
            }

            while (actual != null)
            {
                lstCola.Items.Add(actual.Dato); // Agrega el dato al ListBox.
                actual = actual.Sig; // Avanza al siguiente nodo.
            }
        }

        private void btnEncolar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDato.Text, out int dato))
            {
                cola.Queue(dato); // Encola el dato
                txtDato.Clear(); // Limpia el TextBox
                MostrarCola(); // Muestra la cola actualizada
                MessageBox.Show($"Dato {dato} agregado correctamente a la cola.");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
        }

        private void btnDesencolar_Click(object sender, EventArgs e)
        {
            int eliminado = cola.DeQueue(); // Elimina el dato al frente de la cola
            if (eliminado != -1)
            {
                MostrarCola(); // Muestra la cola actualizada
                MessageBox.Show($"Dato {eliminado} eliminado de la cola.");
            }
            else
            {
                MessageBox.Show("La cola está vacía.");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarCola(); // Actualiza el ListBox con el contenido de la cola
        }
    }
}