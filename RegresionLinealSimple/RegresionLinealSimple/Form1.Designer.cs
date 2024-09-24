namespace RegresionLinealSimple
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NumeroDeProfesional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PuntajeAptitudX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PuntajeSatisfaccionY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PotenciaDePuntajeDeAptitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PotenciaDePuntajeDeSatisfaccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductoDeAptitudySatisfaccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCalcularColumnas = new System.Windows.Forms.Button();
            this.btnCalcularTotales = new System.Windows.Forms.Button();
            this.txtTotalAptitud = new System.Windows.Forms.TextBox();
            this.txtTotalSatisfaccion = new System.Windows.Forms.TextBox();
            this.txtTotalPotenciaAptitud = new System.Windows.Forms.TextBox();
            this.txtTotalPotenciaSatisfaccion = new System.Windows.Forms.TextBox();
            this.txtTotalProductoAptitudSatisfaccion = new System.Windows.Forms.TextBox();
            this.btnCalculoAnalisis = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(210, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGRESION LINEAL SIMPLE";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroDeProfesional,
            this.PuntajeAptitudX,
            this.PuntajeSatisfaccionY,
            this.PotenciaDePuntajeDeAptitud,
            this.PotenciaDePuntajeDeSatisfaccion,
            this.ProductoDeAptitudySatisfaccion});
            this.dataGridView1.Location = new System.Drawing.Point(23, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(651, 303);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NumeroDeProfesional
            // 
            this.NumeroDeProfesional.HeaderText = "Numero de profesional";
            this.NumeroDeProfesional.Name = "NumeroDeProfesional";
            // 
            // PuntajeAptitudX
            // 
            this.PuntajeAptitudX.HeaderText = "Puntaje de aptitud (X)";
            this.PuntajeAptitudX.Name = "PuntajeAptitudX";
            // 
            // PuntajeSatisfaccionY
            // 
            this.PuntajeSatisfaccionY.HeaderText = "Puntaje de satisfaccion (Y)";
            this.PuntajeSatisfaccionY.Name = "PuntajeSatisfaccionY";
            // 
            // PotenciaDePuntajeDeAptitud
            // 
            this.PotenciaDePuntajeDeAptitud.HeaderText = "Puntaje de aptitud (X^2)";
            this.PotenciaDePuntajeDeAptitud.Name = "PotenciaDePuntajeDeAptitud";
            // 
            // PotenciaDePuntajeDeSatisfaccion
            // 
            this.PotenciaDePuntajeDeSatisfaccion.HeaderText = "Puntaje de satisfaccion (Y^2)";
            this.PotenciaDePuntajeDeSatisfaccion.Name = "PotenciaDePuntajeDeSatisfaccion";
            // 
            // ProductoDeAptitudySatisfaccion
            // 
            this.ProductoDeAptitudySatisfaccion.HeaderText = "Aptitud por Satisfaccion (X * Y)";
            this.ProductoDeAptitudySatisfaccion.Name = "ProductoDeAptitudySatisfaccion";
            // 
            // btnCalcularColumnas
            // 
            this.btnCalcularColumnas.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnCalcularColumnas.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularColumnas.ForeColor = System.Drawing.Color.Black;
            this.btnCalcularColumnas.Location = new System.Drawing.Point(3, 417);
            this.btnCalcularColumnas.Name = "btnCalcularColumnas";
            this.btnCalcularColumnas.Size = new System.Drawing.Size(164, 39);
            this.btnCalcularColumnas.TabIndex = 2;
            this.btnCalcularColumnas.Text = "Calcular Columnas";
            this.btnCalcularColumnas.UseVisualStyleBackColor = false;
            this.btnCalcularColumnas.Click += new System.EventHandler(this.btnCalcularColumnas_Click);
            // 
            // btnCalcularTotales
            // 
            this.btnCalcularTotales.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnCalcularTotales.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularTotales.ForeColor = System.Drawing.Color.Black;
            this.btnCalcularTotales.Location = new System.Drawing.Point(173, 420);
            this.btnCalcularTotales.Name = "btnCalcularTotales";
            this.btnCalcularTotales.Size = new System.Drawing.Size(161, 36);
            this.btnCalcularTotales.TabIndex = 3;
            this.btnCalcularTotales.Text = "Calcular Totales";
            this.btnCalcularTotales.UseVisualStyleBackColor = false;
            this.btnCalcularTotales.Click += new System.EventHandler(this.btnCalcularTotales_Click);
            // 
            // txtTotalAptitud
            // 
            this.txtTotalAptitud.BackColor = System.Drawing.Color.Snow;
            this.txtTotalAptitud.Location = new System.Drawing.Point(172, 354);
            this.txtTotalAptitud.Name = "txtTotalAptitud";
            this.txtTotalAptitud.Size = new System.Drawing.Size(83, 20);
            this.txtTotalAptitud.TabIndex = 4;
            // 
            // txtTotalSatisfaccion
            // 
            this.txtTotalSatisfaccion.BackColor = System.Drawing.Color.Snow;
            this.txtTotalSatisfaccion.Location = new System.Drawing.Point(276, 354);
            this.txtTotalSatisfaccion.Name = "txtTotalSatisfaccion";
            this.txtTotalSatisfaccion.Size = new System.Drawing.Size(87, 20);
            this.txtTotalSatisfaccion.TabIndex = 5;
            // 
            // txtTotalPotenciaAptitud
            // 
            this.txtTotalPotenciaAptitud.BackColor = System.Drawing.Color.Snow;
            this.txtTotalPotenciaAptitud.Location = new System.Drawing.Point(379, 354);
            this.txtTotalPotenciaAptitud.Name = "txtTotalPotenciaAptitud";
            this.txtTotalPotenciaAptitud.Size = new System.Drawing.Size(84, 20);
            this.txtTotalPotenciaAptitud.TabIndex = 6;
            // 
            // txtTotalPotenciaSatisfaccion
            // 
            this.txtTotalPotenciaSatisfaccion.BackColor = System.Drawing.Color.Snow;
            this.txtTotalPotenciaSatisfaccion.Location = new System.Drawing.Point(483, 354);
            this.txtTotalPotenciaSatisfaccion.Name = "txtTotalPotenciaSatisfaccion";
            this.txtTotalPotenciaSatisfaccion.Size = new System.Drawing.Size(85, 20);
            this.txtTotalPotenciaSatisfaccion.TabIndex = 7;
            // 
            // txtTotalProductoAptitudSatisfaccion
            // 
            this.txtTotalProductoAptitudSatisfaccion.BackColor = System.Drawing.Color.Snow;
            this.txtTotalProductoAptitudSatisfaccion.Location = new System.Drawing.Point(574, 354);
            this.txtTotalProductoAptitudSatisfaccion.Name = "txtTotalProductoAptitudSatisfaccion";
            this.txtTotalProductoAptitudSatisfaccion.Size = new System.Drawing.Size(88, 20);
            this.txtTotalProductoAptitudSatisfaccion.TabIndex = 8;
            // 
            // btnCalculoAnalisis
            // 
            this.btnCalculoAnalisis.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnCalculoAnalisis.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculoAnalisis.ForeColor = System.Drawing.Color.Black;
            this.btnCalculoAnalisis.Location = new System.Drawing.Point(353, 414);
            this.btnCalculoAnalisis.Name = "btnCalculoAnalisis";
            this.btnCalculoAnalisis.Size = new System.Drawing.Size(171, 48);
            this.btnCalculoAnalisis.TabIndex = 9;
            this.btnCalculoAnalisis.Text = "Calculos con sus analisis";
            this.btnCalculoAnalisis.UseVisualStyleBackColor = false;
            this.btnCalculoAnalisis.Click += new System.EventHandler(this.btnCalculoAnalisis_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSalir.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(599, 424);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 29);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Sumatorias";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(686, 468);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalculoAnalisis);
            this.Controls.Add(this.txtTotalProductoAptitudSatisfaccion);
            this.Controls.Add(this.txtTotalPotenciaSatisfaccion);
            this.Controls.Add(this.txtTotalPotenciaAptitud);
            this.Controls.Add(this.txtTotalSatisfaccion);
            this.Controls.Add(this.txtTotalAptitud);
            this.Controls.Add(this.btnCalcularTotales);
            this.Controls.Add(this.btnCalcularColumnas);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDeProfesional;
        private System.Windows.Forms.DataGridViewTextBoxColumn PuntajeAptitudX;
        private System.Windows.Forms.DataGridViewTextBoxColumn PuntajeSatisfaccionY;
        private System.Windows.Forms.DataGridViewTextBoxColumn PotenciaDePuntajeDeAptitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn PotenciaDePuntajeDeSatisfaccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoDeAptitudySatisfaccion;
        private System.Windows.Forms.Button btnCalcularColumnas;
        private System.Windows.Forms.Button btnCalcularTotales;
        private System.Windows.Forms.TextBox txtTotalAptitud;
        private System.Windows.Forms.TextBox txtTotalSatisfaccion;
        private System.Windows.Forms.TextBox txtTotalPotenciaAptitud;
        private System.Windows.Forms.TextBox txtTotalPotenciaSatisfaccion;
        private System.Windows.Forms.TextBox txtTotalProductoAptitudSatisfaccion;
        private System.Windows.Forms.Button btnCalculoAnalisis;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label2;
    }
}

