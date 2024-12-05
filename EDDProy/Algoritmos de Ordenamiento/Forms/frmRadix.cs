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
    public partial class frmRadix : Form
    {
        private Radix radix;

        public frmRadix()
        {
            InitializeComponent();
            radix = new Radix();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            try
            {
                int[] arreglo = txtArreglo.Text.Split(',').Select(int.Parse).ToArray();
                radix.Ordenar(arreglo);

                lstResultado.Items.Clear();
                foreach (int num in arreglo)
                {
                    lstResultado.Items.Add(num);
                }

                MessageBox.Show("Arreglo ordenado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}

