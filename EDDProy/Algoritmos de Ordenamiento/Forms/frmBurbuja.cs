using EDDemo.Algoritmos_de_Ordenamiento.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Algoritmos_de_Ordenamiento.Forms
{
    public partial class frmBurbuja : Form
    {
        private Burbuja burbuja;

        public frmBurbuja()
        {
            InitializeComponent();
            burbuja = new Burbuja();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener números ingresados por el usuario
                int[] numeros = txtNumeros.Text
                    .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                // Ordenar los números con el método Burbuja
                burbuja.MetodoBurbuja(numeros);

                // Mostrar los resultados en el ListBox
                lstResultados.Items.Clear();
                foreach (int num in numeros)
                {
                    lstResultados.Items.Add(num);
                }

                MessageBox.Show("Ordenamiento completado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Asegúrese de ingresar números válidos separados por comas.\n" + ex.Message);
            }
        }

        private void frmBurbuja_Load(object sender, EventArgs e)
        {

        }
    }
}
