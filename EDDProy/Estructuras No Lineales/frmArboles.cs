using EDDemo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;


//using GraphVizWrapper;
//using GraphVizWrapper.Queries;
//using GraphVizWrapper.Commands;

//using csdot;
//using csdot.Attributes.DataTypes;

namespace EDDemo.Estructuras_No_Lineales
{
    public partial class frmArboles : Form
    {
        ArbolBusqueda miArbol;
        NodoBinario miRaiz;

        public frmArboles()
        {
            InitializeComponent();
            miArbol = new ArbolBusqueda();
            miRaiz = null;
        }


        private void btnInsertar_Click(object sender, EventArgs e)
        {
            int valor = int.Parse(txtDato.Text);
            miRaiz = miArbol.RegresaRaiz();

            if (miArbol.ExisteNodo(valor, miRaiz))
            {
                MessageBox.Show("El nodo ya existe en el árbol.");
                txtDato.Text = "";
                return;
            }

            // Limpiar `strArbol` antes de agregar y mostrar
            miArbol.strArbol = "";
            miArbol.InsertaNodo(valor, ref miRaiz);
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;

            txtDato.Text = "";
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            miArbol = null;
            miRaiz = null;
            miArbol = new ArbolBusqueda();
            txtArbol.Text  = "";
            txtDato.Text = "";
            lblRecorridoPreOrden.Text = "";
            lblRecorridoInOrden.Text = "";
            lblRecorridoPostOrden.Text = "";
        }

        private void btnGrafica_Click(object sender, EventArgs e)
        {
            String graphVizString;

            miRaiz = miArbol.RegresaRaiz();
            if (miRaiz == null)
            {
                MessageBox.Show("El arbol esta vacio");
                return;
            }

            StringBuilder b = new StringBuilder();
            b.Append("digraph G { node [shape=\"circle\"]; " + Environment.NewLine);
            b.Append(miArbol.ToDot(miRaiz));
            b.Append("}");
            graphVizString =  b.ToString();

            //graphVizString = @" digraph g{ label=""Graph""; labelloc=top;labeljust=left;}";
            //graphVizString = @"digraph Arbol{Raiz->60; 60->40. 60->90; 40->34; 40->50;}";
            Bitmap bm = FileDotEngine.Run(graphVizString);

            
            frmGrafica graf = new frmGrafica();
            graf.ActualizaGrafica(bm);
            graf.MdiParent = this.MdiParent;
            graf.Show();
        }


        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            //Recorrido en PreOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPreOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoPreOrden.Text = "";
            miArbol.PreOrden(miRaiz);

            lblRecorridoPreOrden.Text = miArbol.strRecorrido;


            //Recorrido en InOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPostOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoInOrden.Text = "";
            miArbol.InOrden(miRaiz);
            lblRecorridoInOrden.Text = miArbol.strRecorrido;


            //Recorrido en PostOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null) {
                lblRecorridoPostOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoPostOrden.Text = ""; 
            miArbol.PostOrden(miRaiz);
            lblRecorridoPostOrden.Text = miArbol.strRecorrido;
        }

        private void btnCrearArbol_Click(object sender, EventArgs e)
        {
            // Limpiar el árbol anterior
            miArbol = new ArbolBusqueda();
            txtArbol.Text = "";
            txtDato.Text = "";
            miArbol.strArbol = "";

            Random rnd = new Random();
            miRaiz = miArbol.RegresaRaiz();  // Obtener la raíz inicial solo una vez

            for (int nNodos = 1; nNodos <= txtNodos.Value; nNodos++)
            {
                int Dato = rnd.Next(1, 100);

                // Verificar si el dato ya existe en el árbol antes de insertarlo
                if (!miArbol.ExisteNodo(Dato, miRaiz))
                {
                    // Si no existe, insertar el nodo con el dato generado
                    miArbol.InsertaNodo(Dato, ref miRaiz);
                }
                else
                {
                    // Si el nodo ya existe, reducir nNodos para mantener el mismo número total de nodos
                    nNodos--;
                }
            }

            // Leer el árbol completo y mostrarlo en la caja de texto
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;

            txtDato.Text = "";
        }

        private void frmArboles_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDato.Text))
            {
                MessageBox.Show("Por favor ingresa un valor para buscar.");
                return;
            }

            int valor = int.Parse(txtDato.Text);
            miRaiz = miArbol.RegresaRaiz();

            if (miRaiz == null)
            {
                MessageBox.Show("El árbol está vacío");
                return;
            }

            bool encontrado = miArbol.ExisteNodo(valor, miRaiz);

            if (encontrado)
            {
                MessageBox.Show("Se ha encontrado el dato: " + valor);
            }
            else
            {
                MessageBox.Show("Valor no encontrado");
            }

            txtDato.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDato.Text))
            {
                MessageBox.Show("Por favor ingresa un valor para buscar.");
                return;
            }

            int valor = int.Parse(txtDato.Text);
            miRaiz = miArbol.RegresaRaiz();

            if (miRaiz == null)
            {
                MessageBox.Show("El árbol está vacío");
                return;
            }

            bool encontrado = miArbol.ExisteNodo(valor, miRaiz);

            if (encontrado)
            {
                MessageBox.Show("Se ha encontrado el dato: " + valor);
            }
            else
            {
                MessageBox.Show("Valor no encontrado");
            }

            txtDato.Text = "";
        }

        private void btnElmarb_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();

            if (miRaiz == null)
            {
                MessageBox.Show("El árbol está vacío");
                return;
            }

            // Podar el árbol
            miArbol.podarArbol(ref miRaiz);

            // Actualizar visualización en la interfaz
            txtArbol.Text = "";
            lblRecorridoPreOrden.Text = "";
            lblRecorridoInOrden.Text = "";
            lblRecorridoPostOrden.Text = "";

            MessageBox.Show("El árbol ha sido podado.");
        }

        private void btnPrd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDato.Text))
            {
                MessageBox.Show("Por favor, ingresa un valor para eliminar.");
                return;
            }

            int valor = int.Parse(txtDato.Text);
            miRaiz = miArbol.RegresaRaiz();

            if (miRaiz == null)
            {
                MessageBox.Show("El árbol está vacío");
                return;
            }

            bool eliminado = miArbol.EliminarNodoConPredecesor(valor, ref miRaiz);

            if (eliminado)
            {
                MessageBox.Show("Nodo eliminado usando el predecesor: " + valor);
                miArbol.strArbol = "";
                miArbol.MuestraArbolAcostado(1, miRaiz);
                txtArbol.Text = miArbol.strArbol;
            }
            else
            {
                MessageBox.Show("Valor no encontrado en el árbol");
            }
        }

        private void btnSuce_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDato.Text))
            {
                MessageBox.Show("Por favor, ingresa un valor para eliminar.");
                return;
            }

            int valor = int.Parse(txtDato.Text);
            miRaiz = miArbol.RegresaRaiz();

            if (miRaiz == null)
            {
                MessageBox.Show("El árbol está vacío");
                return;
            }

            bool eliminado = miArbol.EliminarNodoConSucesor(valor, ref miRaiz);

            if (eliminado)
            {
                MessageBox.Show("Nodo eliminado usando el sucesor: " + valor);
                miArbol.strArbol = "";
                miArbol.MuestraArbolAcostado(1, miRaiz);
                txtArbol.Text = miArbol.strArbol;
            }
            else
            {
                MessageBox.Show("Valor no encontrado en el árbol");
            }
        }

        private void btnAmp_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblAmp.Text = "El árbol está vacío.";
                return;
            }

            miArbol.RecorrerPorNiveles(miRaiz, ref miArbol.strRecorrido);
            lblAmp.Text = miArbol.strRecorrido.Trim(); // Muestra el recorrido en el label
        }

        private void btnAltu_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();

            if (miRaiz == null)
            {
                MessageBox.Show("El árbol está vacío.");
                return;
            }

            int altura = miArbol.ObtenerAltura(miRaiz);
            MessageBox.Show("Altura del árbol: " + altura);
        }

        private void btnConth_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();

            if (miRaiz == null)
            {
                MessageBox.Show("El árbol está vacío.");
                return;
            }

            int cantidadHojas = miArbol.ContarHojas(miRaiz);
            MessageBox.Show("Cantidad de hojas en el árbol: " + cantidadHojas);
        }

        private void btnNodarb_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();

            if (miRaiz == null)
            {
                MessageBox.Show("El árbol está vacío.");
                return;
            }

            int cantidadNodos = miArbol.ContarNodos(miRaiz);
            MessageBox.Show("Cantidad de nodos en el árbol: " + cantidadNodos);
        }

        private void btnComp_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();

            if (miRaiz == null)
            {
                MessageBox.Show("El árbol está vacío.");
                return;
            }

            int cantidadNodos = miArbol.ContarNodos(miRaiz);
            bool esCompleto = miArbol.EsCompleto(miRaiz, 0, cantidadNodos);

            MessageBox.Show(esCompleto ? "El árbol es binario completo." : "El árbol no es binario completo.");
        }

        private void btnLlen_Click(object sender, EventArgs e)
        {
            miRaiz = miArbol.RegresaRaiz();

            if (miRaiz == null)
            {
                MessageBox.Show("El árbol está vacío.");
                return;
            }

            bool esLleno = miArbol.EsLleno(miRaiz);

            MessageBox.Show(esLleno ? "El árbol es binario lleno." : "El árbol no es binario lleno.");
        }

        private void lblAmp_Click(object sender, EventArgs e)
        {

        }
    }
}
