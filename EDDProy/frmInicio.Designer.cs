
namespace EDDemo
{
    partial class frmInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.algoritmosRecursivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estructurasLinealesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pilasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaCircularSimpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaCircularDoblementeEncadenadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estructurasNoLibealesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arbolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.burbujaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quicksortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shellSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algoritmosDeBusquedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algoritmosRecursivosToolStripMenuItem,
            this.estructurasLinealesToolStripMenuItem,
            this.estructurasNoLibealesToolStripMenuItem,
            this.aToolStripMenuItem,
            this.algoritmosDeBusquedaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1210, 26);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // algoritmosRecursivosToolStripMenuItem
            // 
            this.algoritmosRecursivosToolStripMenuItem.Name = "algoritmosRecursivosToolStripMenuItem";
            this.algoritmosRecursivosToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.algoritmosRecursivosToolStripMenuItem.Text = "Algoritmos Recursivos";
            this.algoritmosRecursivosToolStripMenuItem.Click += new System.EventHandler(this.algoritmosRecursivosToolStripMenuItem_Click);
            // 
            // estructurasLinealesToolStripMenuItem
            // 
            this.estructurasLinealesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pilasToolStripMenuItem,
            this.colasToolStripMenuItem,
            this.listasToolStripMenuItem,
            this.listaToolStripMenuItem,
            this.listaCircularSimpleToolStripMenuItem,
            this.listaCircularDoblementeEncadenadaToolStripMenuItem});
            this.estructurasLinealesToolStripMenuItem.Name = "estructurasLinealesToolStripMenuItem";
            this.estructurasLinealesToolStripMenuItem.Size = new System.Drawing.Size(148, 24);
            this.estructurasLinealesToolStripMenuItem.Text = "Estructuras lineales";
            this.estructurasLinealesToolStripMenuItem.Click += new System.EventHandler(this.estructurasLinealesToolStripMenuItem_Click);
            // 
            // pilasToolStripMenuItem
            // 
            this.pilasToolStripMenuItem.Name = "pilasToolStripMenuItem";
            this.pilasToolStripMenuItem.Size = new System.Drawing.Size(348, 26);
            this.pilasToolStripMenuItem.Text = "Pilas";
            this.pilasToolStripMenuItem.Click += new System.EventHandler(this.pilasToolStripMenuItem_Click_1);
            // 
            // colasToolStripMenuItem
            // 
            this.colasToolStripMenuItem.Name = "colasToolStripMenuItem";
            this.colasToolStripMenuItem.Size = new System.Drawing.Size(348, 26);
            this.colasToolStripMenuItem.Text = "Colas";
            this.colasToolStripMenuItem.Click += new System.EventHandler(this.colasToolStripMenuItem_Click);
            // 
            // listasToolStripMenuItem
            // 
            this.listasToolStripMenuItem.Name = "listasToolStripMenuItem";
            this.listasToolStripMenuItem.Size = new System.Drawing.Size(348, 26);
            this.listasToolStripMenuItem.Text = "Lista Simple";
            this.listasToolStripMenuItem.Click += new System.EventHandler(this.listasToolStripMenuItem_Click);
            // 
            // listaToolStripMenuItem
            // 
            this.listaToolStripMenuItem.Name = "listaToolStripMenuItem";
            this.listaToolStripMenuItem.Size = new System.Drawing.Size(348, 26);
            this.listaToolStripMenuItem.Text = "Lista Doblemente Encadenada";
            this.listaToolStripMenuItem.Click += new System.EventHandler(this.listaToolStripMenuItem_Click);
            // 
            // listaCircularSimpleToolStripMenuItem
            // 
            this.listaCircularSimpleToolStripMenuItem.Name = "listaCircularSimpleToolStripMenuItem";
            this.listaCircularSimpleToolStripMenuItem.Size = new System.Drawing.Size(348, 26);
            this.listaCircularSimpleToolStripMenuItem.Text = "Lista Circular Simple";
            this.listaCircularSimpleToolStripMenuItem.Click += new System.EventHandler(this.listaCircularSimpleToolStripMenuItem_Click);
            // 
            // listaCircularDoblementeEncadenadaToolStripMenuItem
            // 
            this.listaCircularDoblementeEncadenadaToolStripMenuItem.Name = "listaCircularDoblementeEncadenadaToolStripMenuItem";
            this.listaCircularDoblementeEncadenadaToolStripMenuItem.Size = new System.Drawing.Size(348, 26);
            this.listaCircularDoblementeEncadenadaToolStripMenuItem.Text = "Lista Circular Doblemente Encadenada";
            this.listaCircularDoblementeEncadenadaToolStripMenuItem.Click += new System.EventHandler(this.listaCircularDoblementeEncadenadaToolStripMenuItem_Click);
            // 
            // estructurasNoLibealesToolStripMenuItem
            // 
            this.estructurasNoLibealesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arbolesToolStripMenuItem});
            this.estructurasNoLibealesToolStripMenuItem.Name = "estructurasNoLibealesToolStripMenuItem";
            this.estructurasNoLibealesToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.estructurasNoLibealesToolStripMenuItem.Text = "Estructuras no lineales";
            this.estructurasNoLibealesToolStripMenuItem.Click += new System.EventHandler(this.estructurasNoLibealesToolStripMenuItem_Click);
            // 
            // arbolesToolStripMenuItem
            // 
            this.arbolesToolStripMenuItem.Name = "arbolesToolStripMenuItem";
            this.arbolesToolStripMenuItem.Size = new System.Drawing.Size(143, 26);
            this.arbolesToolStripMenuItem.Text = "Arboles";
            this.arbolesToolStripMenuItem.Click += new System.EventHandler(this.arbolesToolStripMenuItem_Click);
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.burbujaToolStripMenuItem,
            this.quicksortToolStripMenuItem,
            this.shellSortToolStripMenuItem,
            this.radixToolStripMenuItem});
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(218, 24);
            this.aToolStripMenuItem.Text = "Algoritmos de Ordenamiento";
            this.aToolStripMenuItem.Click += new System.EventHandler(this.aToolStripMenuItem_Click);
            // 
            // burbujaToolStripMenuItem
            // 
            this.burbujaToolStripMenuItem.Name = "burbujaToolStripMenuItem";
            this.burbujaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.burbujaToolStripMenuItem.Text = "Burbuja";
            this.burbujaToolStripMenuItem.Click += new System.EventHandler(this.burbujaToolStripMenuItem_Click);
            // 
            // quicksortToolStripMenuItem
            // 
            this.quicksortToolStripMenuItem.Name = "quicksortToolStripMenuItem";
            this.quicksortToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.quicksortToolStripMenuItem.Text = "QuickSort";
            this.quicksortToolStripMenuItem.Click += new System.EventHandler(this.quicksortToolStripMenuItem_Click);
            // 
            // shellSortToolStripMenuItem
            // 
            this.shellSortToolStripMenuItem.Name = "shellSortToolStripMenuItem";
            this.shellSortToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.shellSortToolStripMenuItem.Text = "ShellSort";
            this.shellSortToolStripMenuItem.Click += new System.EventHandler(this.shellSortToolStripMenuItem_Click);
            // 
            // radixToolStripMenuItem
            // 
            this.radixToolStripMenuItem.Name = "radixToolStripMenuItem";
            this.radixToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.radixToolStripMenuItem.Text = "Radix";
            this.radixToolStripMenuItem.Click += new System.EventHandler(this.radixToolStripMenuItem_Click);
            // 
            // algoritmosDeBusquedaToolStripMenuItem
            // 
            this.algoritmosDeBusquedaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hashToolStripMenuItem,
            this.binariaToolStripMenuItem});
            this.algoritmosDeBusquedaToolStripMenuItem.Name = "algoritmosDeBusquedaToolStripMenuItem";
            this.algoritmosDeBusquedaToolStripMenuItem.Size = new System.Drawing.Size(187, 24);
            this.algoritmosDeBusquedaToolStripMenuItem.Text = "Algoritmos de Busqueda";
            this.algoritmosDeBusquedaToolStripMenuItem.Click += new System.EventHandler(this.algoritmosDeBusquedaToolStripMenuItem_Click);
            // 
            // hashToolStripMenuItem
            // 
            this.hashToolStripMenuItem.Name = "hashToolStripMenuItem";
            this.hashToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.hashToolStripMenuItem.Text = "Hash";
            this.hashToolStripMenuItem.Click += new System.EventHandler(this.hashToolStripMenuItem_Click);
            // 
            // binariaToolStripMenuItem
            // 
            this.binariaToolStripMenuItem.Name = "binariaToolStripMenuItem";
            this.binariaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.binariaToolStripMenuItem.Text = "Binaria";
            this.binariaToolStripMenuItem.Click += new System.EventHandler(this.binariaToolStripMenuItem_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 492);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmInicio";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem estructurasLinealesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estructurasNoLibealesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arbolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algoritmosRecursivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaCircularSimpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaCircularDoblementeEncadenadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pilasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem burbujaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quicksortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shellSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem radixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algoritmosDeBusquedaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binariaToolStripMenuItem;
    }
}

