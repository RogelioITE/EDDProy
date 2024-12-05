using EDDemo.Algoritmos_de_Busqueda.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Algoritmos_de_Busqueda.Forms
{
    public partial class frmBinaria : Form
    {
        private readonly Binaria busquedaBinaria;

        public frmBinaria()
        {
            InitializeComponent();
            busquedaBinaria = new Binaria();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int[] arreglo = txtArreglo.Text
                    .Split(',')
                    .Select(int.Parse)
                    .OrderBy(x => x) // Asegura que el arreglo esté ordenado.
                    .ToArray();

                int objetivo = int.Parse(txtObjetivo.Text);
                int resultado = busquedaBinaria.Buscar(arreglo, objetivo);

                lstResultado.Items.Clear();
                if (resultado != -1)
                    lstResultado.Items.Add($"El objetivo {objetivo} se encontró en el índice {resultado}.");
                else
                    lstResultado.Items.Add($"El objetivo {objetivo} no se encuentra en el arreglo.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
