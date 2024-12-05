namespace EDDemo.Algoritmos_de_Busqueda.Forms
{
    partial class frmHash
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblClave = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblBuscarClave = new System.Windows.Forms.Label();
            this.txtBuscarClave = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lstResultado = new System.Windows.Forms.ListBox();
            this.btnCargarArchivo = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(30, 30);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(45, 16);
            this.lblClave.TabIndex = 0;
            this.lblClave.Text = "Clave:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(30, 70);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(42, 16);
            this.lblValor.TabIndex = 1;
            this.lblValor.Text = "Valor:";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(100, 30);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(150, 22);
            this.txtClave.TabIndex = 2;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(100, 70);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(150, 22);
            this.txtValor.TabIndex = 3;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(270, 50);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(100, 30);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblBuscarClave
            // 
            this.lblBuscarClave.AutoSize = true;
            this.lblBuscarClave.Location = new System.Drawing.Point(30, 120);
            this.lblBuscarClave.Name = "lblBuscarClave";
            this.lblBuscarClave.Size = new System.Drawing.Size(88, 16);
            this.lblBuscarClave.TabIndex = 5;
            this.lblBuscarClave.Text = "Buscar Clave:";
            // 
            // txtBuscarClave
            // 
            this.txtBuscarClave.Location = new System.Drawing.Point(130, 120);
            this.txtBuscarClave.Name = "txtBuscarClave";
            this.txtBuscarClave.Size = new System.Drawing.Size(120, 22);
            this.txtBuscarClave.TabIndex = 6;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(270, 115);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 30);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lstResultado
            // 
            this.lstResultado.FormattingEnabled = true;
            this.lstResultado.ItemHeight = 16;
            this.lstResultado.Location = new System.Drawing.Point(30, 160);
            this.lstResultado.Name = "lstResultado";
            this.lstResultado.Size = new System.Drawing.Size(340, 100);
            this.lstResultado.TabIndex = 8;
            // 
            // btnCargarArchivo
            // 
            this.btnCargarArchivo.Location = new System.Drawing.Point(30, 280);
            this.btnCargarArchivo.Name = "btnCargarArchivo";
            this.btnCargarArchivo.Size = new System.Drawing.Size(150, 30);
            this.btnCargarArchivo.TabIndex = 9;
            this.btnCargarArchivo.Text = "Cargar Archivo";
            this.btnCargarArchivo.UseVisualStyleBackColor = true;
            this.btnCargarArchivo.Click += new System.EventHandler(this.btnCargarArchivo_Click);
            // 
            // frmHash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Controls.Add(this.btnCargarArchivo);
            this.Controls.Add(this.lstResultado);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscarClave);
            this.Controls.Add(this.lblBuscarClave);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblClave);
            this.Name = "frmHash";
            this.Text = "Hash";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblBuscarClave;
        private System.Windows.Forms.TextBox txtBuscarClave;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ListBox lstResultado;
        private System.Windows.Forms.Button btnCargarArchivo;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}
