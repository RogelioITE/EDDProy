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
    public partial class frmShellSort : Form
    {
        private ShellSort shellSort;

        public frmShellSort()
        {
            InitializeComponent();
            shellSort = new ShellSort();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            try
            {
                // Parsear los datos ingresados por el usuario
                List<int> lista = txtDatos.Text.Split(',')
                    .Select(int.Parse)
                    .ToList();

                // Ordenar la lista usando ShellSort
                shellSort.Ordenar(lista);

                // Mostrar los resultados en el ListBox
                lstResultados.Items.Clear();
                foreach (int num in lista)
                {
                    lstResultados.Items.Add(num);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
        }
    }
}