namespace EDDemo.Algoritmos_de_Ordenamiento.Forms
{
    partial class frmQuickSort
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
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.lstResultados = new System.Windows.Forms.ListBox();
            this.lblIngresarDatos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDatos
            // 
            this.txtDatos.Location = new System.Drawing.Point(50, 50);
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.Size = new System.Drawing.Size(200, 22);
            this.txtDatos.TabIndex = 0;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(280, 50);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(100, 23);
            this.btnOrdenar.TabIndex = 1;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // lstResultados
            // 
            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.ItemHeight = 16;
            this.lstResultados.Location = new System.Drawing.Point(50, 100);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(330, 180);
            this.lstResultados.TabIndex = 2;
            // 
            // lblIngresarDatos
            // 
            this.lblIngresarDatos.AutoSize = true;
            this.lblIngresarDatos.Location = new System.Drawing.Point(50, 20);
            this.lblIngresarDatos.Name = "lblIngresarDatos";
            this.lblIngresarDatos.Size = new System.Drawing.Size(230, 16);
            this.lblIngresarDatos.TabIndex = 3;
            this.lblIngresarDatos.Text = "Ingrese números separados por coma:";
            // 
            // frmQuickSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 350);
            this.Controls.Add(this.lblIngresarDatos);
            this.Controls.Add(this.lstResultados);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.txtDatos);
            this.Name = "frmQuickSort";
            this.Text = "QuickSort";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtDatos;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.ListBox lstResultados;
        private System.Windows.Forms.Label lblIngresarDatos;
    }
}
