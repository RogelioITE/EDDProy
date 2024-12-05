namespace EDDemo.Algoritmos_de_Ordenamiento.Forms
{
    partial class frmBurbuja
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
            this.txtNumeros = new System.Windows.Forms.TextBox();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.lstResultados = new System.Windows.Forms.ListBox();
            this.lblIngresarNumeros = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumeros
            // 
            this.txtNumeros.Location = new System.Drawing.Point(150, 50);
            this.txtNumeros.Name = "txtNumeros";
            this.txtNumeros.Size = new System.Drawing.Size(300, 22);
            this.txtNumeros.TabIndex = 0;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(150, 100);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(100, 30);
            this.btnOrdenar.TabIndex = 1;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // lstResultados
            // 
            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.ItemHeight = 16;
            this.lstResultados.Location = new System.Drawing.Point(150, 150);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(300, 100);
            this.lstResultados.TabIndex = 2;
            // 
            // lblIngresarNumeros
            // 
            this.lblIngresarNumeros.AutoSize = true;
            this.lblIngresarNumeros.Location = new System.Drawing.Point(150, 30);
            this.lblIngresarNumeros.Name = "lblIngresarNumeros";
            this.lblIngresarNumeros.Size = new System.Drawing.Size(246, 16);
            this.lblIngresarNumeros.TabIndex = 3;
            this.lblIngresarNumeros.Text = "Ingrese números separados por comas:";
            // 
            // frmBurbuja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.lblIngresarNumeros);
            this.Controls.Add(this.lstResultados);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.txtNumeros);
            this.Name = "frmBurbuja";
            this.Text = "Ordenamiento Burbuja";
            this.Load += new System.EventHandler(this.frmBurbuja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumeros;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.ListBox lstResultados;
        private System.Windows.Forms.Label lblIngresarNumeros;
    }
}
