using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Algoritmos_de_Recursividad.Forms;
using EDDemo.Estructuras_Lineales.Forms;
using EDDemo.Estructuras_No_Lineales;
using EDDemo.Algoritmos_de_Ordenamiento;
using EDDemo.Algoritmos_de_Ordenamiento.Forms;
using EDDemo.Algoritmos_de_Busqueda;
using EDDemo.Algoritmos_de_Busqueda.Forms;

namespace EDDemo
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void estructurasLinealesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void arbolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArboles mArboles = new frmArboles();
            mArboles.MdiParent = this;
            mArboles.Show();
        }

        private void estructurasNoLibealesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void algoritmosRecursivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRecursividad mRecursividad = new frmRecursividad();
            mRecursividad.MdiParent = this;
            mRecursividad.Show();
        }



        private void colasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCola frmCola = new frmCola();
            frmCola.MdiParent = this;
            frmCola.Show();

        }

        private void listasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaSimple frmListaSimple = new frmListaSimple();
            frmListaSimple.MdiParent = this;
            frmListaSimple.Show();
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaDoble frmListaDoble = new frmListaDoble();
            frmListaDoble.MdiParent = this;
            frmListaDoble.Show();
        }

        private void listaCircularSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaCircularSimple frmListaCircularSimple = new frmListaCircularSimple();
            frmListaCircularSimple.MdiParent = this;
            frmListaCircularSimple.Show();
        }

        private void listaCircularDoblementeEncadenadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaCircularDoble frmListaCircularDoble = new frmListaCircularDoble();
            frmListaCircularDoble.MdiParent = this;
            frmListaCircularDoble.Show();
        }

        private void pilasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmPila frmPila = new frmPila();
            frmPila.MdiParent = this;
            frmPila.Show();
        }

        private void burbujaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBurbuja frmBurbuja = new frmBurbuja();
            frmBurbuja.MdiParent = this;
            frmBurbuja.Show();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quicksortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuickSort frmQuickSort = new frmQuickSort();
            frmQuickSort.MdiParent = this;
            frmQuickSort.Show();
        }

        private void shellSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShellSort frmShellSort = new frmShellSort();
            frmShellSort.MdiParent = this;
            frmShellSort.Show();
        }

        private void radixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRadix frmRadix = new frmRadix();
            frmRadix.MdiParent = this;
            frmRadix.Show();
        }

        private void algoritmosDeBusquedaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHash frmHash = new frmHash();
            frmHash.MdiParent = this;
            frmHash.Show();
        }

        private void binariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBinaria binaria = new frmBinaria();
            binaria.MdiParent = this;
            binaria.Show();
        }
    }
}
