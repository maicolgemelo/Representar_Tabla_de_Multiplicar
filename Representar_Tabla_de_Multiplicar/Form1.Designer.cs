namespace Representar_Tabla_de_Multiplicar
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgTablaMultiplicacion = new System.Windows.Forms.DataGridView();
            this.Col_Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Consecutivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgTablaMultiplicacion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTablaMultiplicacion
            // 
            this.dgTablaMultiplicacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTablaMultiplicacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Valor,
            this.Col_Consecutivo,
            this.Col_Total});
            this.dgTablaMultiplicacion.Location = new System.Drawing.Point(223, 202);
            this.dgTablaMultiplicacion.Name = "dgTablaMultiplicacion";
            this.dgTablaMultiplicacion.Size = new System.Drawing.Size(350, 236);
            this.dgTablaMultiplicacion.TabIndex = 0;
            // 
            // Col_Valor
            // 
            this.Col_Valor.HeaderText = "Column1";
            this.Col_Valor.Name = "Col_Valor";
            this.Col_Valor.ReadOnly = true;
            // 
            // Col_Consecutivo
            // 
            this.Col_Consecutivo.HeaderText = "Consecutivo";
            this.Col_Consecutivo.Name = "Col_Consecutivo";
            this.Col_Consecutivo.ReadOnly = true;
            // 
            // Col_Total
            // 
            this.Col_Total.HeaderText = "Total";
            this.Col_Total.Name = "Col_Total";
            this.Col_Total.ReadOnly = true;
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreso.Location = new System.Drawing.Point(128, 72);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(201, 24);
            this.lblIngreso.TabIndex = 1;
            this.lblIngreso.Text = "Ingrese un numero: ";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(357, 72);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(162, 20);
            this.txtNumero.TabIndex = 2;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(598, 72);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(104, 33);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(598, 133);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(104, 30);
            this.btnBorrar.TabIndex = 4;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblIngreso);
            this.Controls.Add(this.dgTablaMultiplicacion);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgTablaMultiplicacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTablaMultiplicacion;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Consecutivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Total;
        private System.Windows.Forms.Button btnBorrar;
    }
}

