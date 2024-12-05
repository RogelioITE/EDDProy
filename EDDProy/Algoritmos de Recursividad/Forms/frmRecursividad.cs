using EDDemo.Algoritmos_de_Recursividad.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Algoritmos_de_Recursividad.Forms
{
    public partial class frmRecursividad : Form
    {
        public frmRecursividad()
        {
            InitializeComponent();
        }

        private void frmRecursividad_Load(object sender, EventArgs e)
        {
            // Carga inicial de los algoritmos en el ComboBox
            cmbAlgoritmos.Items.AddRange(new string[]
            {
                "Factorial",
                "Exponente",
                "Suma de Arreglo",
                "Fibonacci",
                "Búsqueda Binaria",
                "Torre de Hanoi"
            });
            cmbAlgoritmos.SelectedIndex = -1; // Ninguna selección inicial
            lblTiempo.Text = "Tiempo: --";
            lblComplejidad.Text = "Complejidad: --";
        }

        private void cmbAlgoritmos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cmbAlgoritmos.SelectedItem?.ToString();

            // Habilitar o deshabilitar txtInput2 según el algoritmo seleccionado
            switch (opcion)
            {
                case "Factorial":
                case "Fibonacci":
                case "Suma de Arreglo":
                case "Torre de Hanoi":
                    lblInput2.Visible = false;
                    txtInput2.Visible = false;
                    break;

                case "Exponente":
                case "Búsqueda Binaria":
                    lblInput2.Visible = true;
                    txtInput2.Visible = true;
                    lblInput2.Text = opcion == "Exponente" ? "Ingrese el exponente:" : "Valor a buscar:";
                    break;

                default:
                    MessageBox.Show("Seleccione un algoritmo válido.", "Error");
                    break;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                string opcion = cmbAlgoritmos.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(opcion))
                {
                    MessageBox.Show("Seleccione un algoritmo antes de continuar.", "Advertencia");
                    return;
                }

                lblResultados.Text = "Resultados:";
                lblTiempo.Text = "Tiempo: --";
                lblComplejidad.Text = "Complejidad: --";

                switch (opcion)
                {
                    case "Factorial":
                        var factorial = new Factorial();
                        BigInteger numeroFactorial = BigInteger.Parse(txtInput1.Text);
                        var (resultadoFactorial, tiempoFactorial) = factorial.Calcular(numeroFactorial);
                        lblResultados.Text = $"Factorial de {numeroFactorial} es {resultadoFactorial}";
                        lblTiempo.Text = $"Tiempo: {tiempoFactorial} ms";
                        lblComplejidad.Text = $"Complejidad: {factorial.Complejidad()}";
                        break;

                    case "Exponente":
                        var exponente = new Exponente();
                        BigInteger baseNum = BigInteger.Parse(txtInput1.Text);
                        BigInteger exp = BigInteger.Parse(txtInput2.Text);
                        var (resultadoExponente, tiempoExponente) = exponente.Calcular(baseNum, exp);
                        lblResultados.Text = $"{baseNum}^{exp} = {resultadoExponente}";
                        lblTiempo.Text = $"Tiempo: {tiempoExponente} ms";
                        lblComplejidad.Text = $"Complejidad: {exponente.Complejidad()}";
                        break;

                    case "Suma de Arreglo":
                        var suma = new SumaArreglo();
                        int[] arreglo = Array.ConvertAll(txtInput1.Text.Split(','), int.Parse);
                        var (sumaTotal, tiempoSuma) = suma.Calcular(arreglo);
                        lblResultados.Text = $"Suma total: {sumaTotal}";
                        lblTiempo.Text = $"Tiempo: {tiempoSuma} ms";
                        lblComplejidad.Text = $"Complejidad: {suma.Complejidad()}";
                        break;

                    case "Fibonacci":
                        var fibonacci = new Fibonacci();
                        int n = int.Parse(txtInput1.Text);
                        var (resultadoFib, tiempoFib) = fibonacci.Calcular(n);
                        lblResultados.Text = $"Fibonacci({n}): {resultadoFib}";
                        lblTiempo.Text = $"Tiempo: {tiempoFib} ms";
                        lblComplejidad.Text = $"Complejidad: {fibonacci.Complejidad()}";
                        break;

                    case "Búsqueda Binaria":
                        var busqueda = new BusquedaBinaria();
                        int[] arr = Array.ConvertAll(txtInput1.Text.Split(','), int.Parse);
                        Array.Sort(arr);
                        int objetivo = int.Parse(txtInput2.Text);
                        var (indice, tiempoBusqueda) = busqueda.Buscar(arr, objetivo);
                        lblResultados.Text = indice == -1
                            ? $"Número {objetivo} no encontrado."
                            : $"Número {objetivo} encontrado en índice {indice}.";
                        lblTiempo.Text = $"Tiempo: {tiempoBusqueda} ms";
                        lblComplejidad.Text = $"Complejidad: {busqueda.Complejidad()}";
                        break;

                    case "Torre de Hanoi":
                        var hanoi = new TorreHanoi();
                        int discos = int.Parse(txtInput1.Text);
                        var (tiempoHanoi, movimientosHanoi) = hanoi.Resolver(discos, 'A', 'C', 'B',
                            movimiento => lblResultados.Text += $"{movimiento}\n");
                        lblResultados.Text += $"\nMovimientos Totales: {movimientosHanoi}";
                        lblTiempo.Text = $"Tiempo: {tiempoHanoi} ms";
                        lblComplejidad.Text = $"Complejidad: {hanoi.Complejidad()}";
                        break;

                    default:
                        MessageBox.Show("Seleccione un algoritmo válido.", "Error");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Excepción");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtInput1.Text = string.Empty;
            txtInput2.Text = string.Empty;
            lblResultados.Text = "Resultados:";
            lblTiempo.Text = "Tiempo: --";
            lblComplejidad.Text = "Complejidad: --";
            cmbAlgoritmos.SelectedIndex = -1;
        }
    }
}