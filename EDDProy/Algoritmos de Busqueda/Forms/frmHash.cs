using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Algoritmos_de_Busqueda.Clases;
using System.IO;

namespace EDDemo.Algoritmos_de_Busqueda.Forms
{
    public partial class frmHash : Form
    {
        private Hash hashTable;

        public frmHash()
        {
            InitializeComponent();
            hashTable = new Hash(10); // Inicializamos la tabla hash con tamaño 10
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                int clave = int.Parse(txtClave.Text);
                string valor = txtValor.Text;

                hashTable.Insertar(clave, valor); // Método de la clase Hash
                MessageBox.Show($"Clave {clave} con valor '{valor}' ingresada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtClave.Clear();
                txtValor.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al ingresar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int clave = int.Parse(txtBuscarClave.Text);
                string resultado = hashTable.Buscar(clave); // Método de la clase Hash

                lstResultado.Items.Clear();
                lstResultado.Items.Add($"Clave: {clave}, Valor: {resultado}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCargarArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string[] lines = File.ReadAllLines(openFileDialog.FileName);

                        foreach (var line in lines)
                        {
                            string[] parts = line.Split(',');

                            if (parts.Length == 2 && int.TryParse(parts[0], out int clave))
                            {
                                hashTable.Insertar(clave, parts[1]); // Método de la clase Hash
                            }
                            else
                            {
                                MessageBox.Show($"Línea inválida: {line}", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }

                        MessageBox.Show("Archivo cargado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}