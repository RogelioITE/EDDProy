using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EDDemo.Estructuras_Lineales.Clases.Pila;

namespace EDDemo.Estructuras_Lineales.Forms
{
    public partial class frmPila : Form
    {
        private Pilas pila;

        public frmPila()
        {
            InitializeComponent();
            pila = new Pilas(); // Instancia de la clase Pilas
        }

        private void MostrarPila()
        {
            lstPila.Items.Clear();
            Nodo actual = pila.ObtenerTop();

            while (actual != null)
            {
                lstPila.Items.Add(actual.Dato); // Agrega el dato al ListBox
                actual = actual.sig;
            }
        }

        private void BtnPush_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDato.Text, out int dato))
            {
                pila.Push(dato, lstPila); // Inserta el dato en la pila y actualiza la lista
                txtDato.Clear();
                MessageBox.Show($"Dato {dato} agregado correctamente a la pila.");
            }
            else
            {
                MessageBox.Show("Por favor ingrese un número válido.");
            }
        }

        private void BtnPop_Click(object sender, EventArgs e)
        {
            pila.Pop(lstPila); // Elimina el dato del tope y actualiza la lista
            MostrarPila();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            pila.Mostrar(lstPila); // Muestra el contenido actual de la pila
        }

        private void lstPila_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Evento opcional si necesitas manejar clics en el ListBox
        }
        private void frmPila_Load(object sender, EventArgs e)
        {

        }
    }
}
