namespace RegresionLinealSimple
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.CalcularB1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.texBoxCalculob1 = new System.Windows.Forms.TextBox();
            this.btnCalcularb0 = new System.Windows.Forms.Button();
            this.texBoxCalculob0 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnAnalisisVarianza = new System.Windows.Forms.Button();
            this.txtAnalisisVarianza = new System.Windows.Forms.TextBox();
            this.lblRegresion = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sumaCuadrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradoLibertad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minimoCuadrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.analisiVarianza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotalSumaCuadrado = new System.Windows.Forms.TextBox();
            this.txtTotalGradoLibertad = new System.Windows.Forms.TextBox();
            this.btnVerificacionb1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.texboxsumatoria = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCalT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.texBoxCalculoTCuadrado = new System.Windows.Forms.TextBox();
            this.btnCalcuIntervaloB1 = new System.Windows.Forms.Button();
            this.textBoxIntervalo1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.texBoxIntervalo2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnpredicciones = new System.Windows.Forms.Button();
            this.textBoxpredicciones = new System.Windows.Forms.TextBox();
            this.btnintervalopredicciony = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBoxnegativo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnIntervaloMediaPoblacional = new System.Windows.Forms.Button();
            this.lblIntervalo = new System.Windows.Forms.Label();
            this.txtMenorIntervaloPoblacion = new System.Windows.Forms.TextBox();
            this.txtMayorIntervaloPoblacion = new System.Windows.Forms.TextBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(57, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(730, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "CALCULOS Y ANALISIS DE LA RELACION LINEAL ENTRE EL PUNTAJE DE APTITUD Y  SATISFAC" +
    "CION";
            // 
            // CalcularB1
            // 
            this.CalcularB1.BackColor = System.Drawing.Color.Transparent;
            this.CalcularB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcularB1.Location = new System.Drawing.Point(12, 67);
            this.CalcularB1.Name = "CalcularB1";
            this.CalcularB1.Size = new System.Drawing.Size(149, 34);
            this.CalcularB1.TabIndex = 1;
            this.CalcularB1.Text = " 1) Calcular b1";
            this.CalcularB1.UseVisualStyleBackColor = false;
            this.CalcularB1.Click += new System.EventHandler(this.CalcularB1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(197, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Resultados";
            // 
            // texBoxCalculob1
            // 
            this.texBoxCalculob1.Location = new System.Drawing.Point(183, 75);
            this.texBoxCalculob1.Name = "texBoxCalculob1";
            this.texBoxCalculob1.Size = new System.Drawing.Size(100, 20);
            this.texBoxCalculob1.TabIndex = 3;
            // 
            // btnCalcularb0
            // 
            this.btnCalcularb0.BackColor = System.Drawing.Color.Transparent;
            this.btnCalcularb0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularb0.Location = new System.Drawing.Point(12, 120);
            this.btnCalcularb0.Name = "btnCalcularb0";
            this.btnCalcularb0.Size = new System.Drawing.Size(149, 30);
            this.btnCalcularb0.TabIndex = 4;
            this.btnCalcularb0.Text = "2) Calcular b0";
            this.btnCalcularb0.UseVisualStyleBackColor = false;
            this.btnCalcularb0.Click += new System.EventHandler(this.btnCalcularb0_Click);
            // 
            // texBoxCalculob0
            // 
            this.texBoxCalculob0.Location = new System.Drawing.Point(183, 126);
            this.texBoxCalculob0.Name = "texBoxCalculob0";
            this.texBoxCalculob0.Size = new System.Drawing.Size(100, 20);
            this.texBoxCalculob0.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(11, 173);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "3) Calcular r^2";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(183, 178);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(97, 20);
            this.textBox1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(11, 221);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 28);
            this.button2.TabIndex = 8;
            this.button2.Text = "4) Calcular r";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(183, 229);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            // 
            // btnAnalisisVarianza
            // 
            this.btnAnalisisVarianza.BackColor = System.Drawing.Color.Transparent;
            this.btnAnalisisVarianza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalisisVarianza.Location = new System.Drawing.Point(12, 274);
            this.btnAnalisisVarianza.Name = "btnAnalisisVarianza";
            this.btnAnalisisVarianza.Size = new System.Drawing.Size(149, 23);
            this.btnAnalisisVarianza.TabIndex = 10;
            this.btnAnalisisVarianza.Text = "5) Calcular RV";
            this.btnAnalisisVarianza.UseVisualStyleBackColor = false;
            this.btnAnalisisVarianza.Click += new System.EventHandler(this.btnAnalisisVarianza_Click);
            // 
            // txtAnalisisVarianza
            // 
            this.txtAnalisisVarianza.Location = new System.Drawing.Point(183, 276);
            this.txtAnalisisVarianza.Name = "txtAnalisisVarianza";
            this.txtAnalisisVarianza.Size = new System.Drawing.Size(100, 20);
            this.txtAnalisisVarianza.TabIndex = 11;
            // 
            // lblRegresion
            // 
            this.lblRegresion.AutoSize = true;
            this.lblRegresion.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegresion.Location = new System.Drawing.Point(8, 389);
            this.lblRegresion.Name = "lblRegresion";
            this.lblRegresion.Size = new System.Drawing.Size(81, 18);
            this.lblRegresion.TabIndex = 12;
            this.lblRegresion.Text = "Regresion";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.Location = new System.Drawing.Point(17, 420);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(45, 18);
            this.lblError.TabIndex = 13;
            this.lblError.Text = "Error";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(18, 453);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 18);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "Total";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sumaCuadrado,
            this.gradoLibertad,
            this.minimoCuadrado,
            this.analisiVarianza});
            this.dataGridView1.Location = new System.Drawing.Point(95, 362);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(549, 86);
            this.dataGridView1.TabIndex = 15;
            // 
            // sumaCuadrado
            // 
            this.sumaCuadrado.HeaderText = "SC";
            this.sumaCuadrado.MinimumWidth = 6;
            this.sumaCuadrado.Name = "sumaCuadrado";
            this.sumaCuadrado.Width = 125;
            // 
            // gradoLibertad
            // 
            this.gradoLibertad.HeaderText = "GL";
            this.gradoLibertad.MinimumWidth = 6;
            this.gradoLibertad.Name = "gradoLibertad";
            this.gradoLibertad.Width = 125;
            // 
            // minimoCuadrado
            // 
            this.minimoCuadrado.HeaderText = "MC";
            this.minimoCuadrado.MinimumWidth = 6;
            this.minimoCuadrado.Name = "minimoCuadrado";
            this.minimoCuadrado.Width = 125;
            // 
            // analisiVarianza
            // 
            this.analisiVarianza.HeaderText = "RV";
            this.analisiVarianza.MinimumWidth = 6;
            this.analisiVarianza.Name = "analisiVarianza";
            this.analisiVarianza.Width = 125;
            // 
            // txtTotalSumaCuadrado
            // 
            this.txtTotalSumaCuadrado.Location = new System.Drawing.Point(147, 453);
            this.txtTotalSumaCuadrado.Name = "txtTotalSumaCuadrado";
            this.txtTotalSumaCuadrado.Size = new System.Drawing.Size(80, 20);
            this.txtTotalSumaCuadrado.TabIndex = 16;
            // 
            // txtTotalGradoLibertad
            // 
            this.txtTotalGradoLibertad.Location = new System.Drawing.Point(265, 454);
            this.txtTotalGradoLibertad.Name = "txtTotalGradoLibertad";
            this.txtTotalGradoLibertad.Size = new System.Drawing.Size(90, 20);
            this.txtTotalGradoLibertad.TabIndex = 17;
            // 
            // btnVerificacionb1
            // 
            this.btnVerificacionb1.BackColor = System.Drawing.Color.Transparent;
            this.btnVerificacionb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificacionb1.Location = new System.Drawing.Point(320, 66);
            this.btnVerificacionb1.Name = "btnVerificacionb1";
            this.btnVerificacionb1.Size = new System.Drawing.Size(204, 34);
            this.btnVerificacionb1.TabIndex = 18;
            this.btnVerificacionb1.Text = "6) Verificacion de b1";
            this.btnVerificacionb1.UseVisualStyleBackColor = false;
            this.btnVerificacionb1.Click += new System.EventHandler(this.btnVerificacionb1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(317, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "∑(Xj-x̅)^2 =";
            // 
            // texboxsumatoria
            // 
            this.texboxsumatoria.Location = new System.Drawing.Point(416, 111);
            this.texboxsumatoria.Name = "texboxsumatoria";
            this.texboxsumatoria.Size = new System.Drawing.Size(100, 20);
            this.texboxsumatoria.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(325, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "t =";
            // 
            // textBoxCalT
            // 
            this.textBoxCalT.Location = new System.Drawing.Point(416, 139);
            this.textBoxCalT.Name = "textBoxCalT";
            this.textBoxCalT.Size = new System.Drawing.Size(100, 20);
            this.textBoxCalT.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(326, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "t^2 =";
            // 
            // texBoxCalculoTCuadrado
            // 
            this.texBoxCalculoTCuadrado.Location = new System.Drawing.Point(416, 171);
            this.texBoxCalculoTCuadrado.Name = "texBoxCalculoTCuadrado";
            this.texBoxCalculoTCuadrado.Size = new System.Drawing.Size(100, 20);
            this.texBoxCalculoTCuadrado.TabIndex = 24;
            // 
            // btnCalcuIntervaloB1
            // 
            this.btnCalcuIntervaloB1.BackColor = System.Drawing.Color.Transparent;
            this.btnCalcuIntervaloB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcuIntervaloB1.Location = new System.Drawing.Point(320, 209);
            this.btnCalcuIntervaloB1.Name = "btnCalcuIntervaloB1";
            this.btnCalcuIntervaloB1.Size = new System.Drawing.Size(204, 50);
            this.btnCalcuIntervaloB1.TabIndex = 25;
            this.btnCalcuIntervaloB1.Text = "7) intervalo de confianza para β1";
            this.btnCalcuIntervaloB1.UseVisualStyleBackColor = false;
            this.btnCalcuIntervaloB1.Click += new System.EventHandler(this.btnCalcuIntervaloB1_Click);
            // 
            // textBoxIntervalo1
            // 
            this.textBoxIntervalo1.Location = new System.Drawing.Point(329, 283);
            this.textBoxIntervalo1.Name = "textBoxIntervalo1";
            this.textBoxIntervalo1.Size = new System.Drawing.Size(81, 20);
            this.textBoxIntervalo1.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(416, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "≤ β1 ≤";
            // 
            // texBoxIntervalo2
            // 
            this.texBoxIntervalo2.Location = new System.Drawing.Point(465, 284);
            this.texBoxIntervalo2.Name = "texBoxIntervalo2";
            this.texBoxIntervalo2.Size = new System.Drawing.Size(67, 20);
            this.texBoxIntervalo2.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(295, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "C =";
            // 
            // btnpredicciones
            // 
            this.btnpredicciones.BackColor = System.Drawing.Color.Transparent;
            this.btnpredicciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpredicciones.Location = new System.Drawing.Point(539, 67);
            this.btnpredicciones.Margin = new System.Windows.Forms.Padding(2);
            this.btnpredicciones.Name = "btnpredicciones";
            this.btnpredicciones.Size = new System.Drawing.Size(178, 35);
            this.btnpredicciones.TabIndex = 31;
            this.btnpredicciones.Text = "8 ) Calcular prediccion";
            this.btnpredicciones.UseVisualStyleBackColor = false;
            this.btnpredicciones.Click += new System.EventHandler(this.btnpredicciones_Click);
            // 
            // textBoxpredicciones
            // 
            this.textBoxpredicciones.Location = new System.Drawing.Point(734, 75);
            this.textBoxpredicciones.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxpredicciones.Name = "textBoxpredicciones";
            this.textBoxpredicciones.Size = new System.Drawing.Size(76, 20);
            this.textBoxpredicciones.TabIndex = 32;
            // 
            // btnintervalopredicciony
            // 
            this.btnintervalopredicciony.BackColor = System.Drawing.Color.Transparent;
            this.btnintervalopredicciony.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnintervalopredicciony.Location = new System.Drawing.Point(539, 116);
            this.btnintervalopredicciony.Margin = new System.Windows.Forms.Padding(2);
            this.btnintervalopredicciony.Name = "btnintervalopredicciony";
            this.btnintervalopredicciony.Size = new System.Drawing.Size(284, 36);
            this.btnintervalopredicciony.TabIndex = 33;
            this.btnintervalopredicciony.Text = "9) Intervalo de predicción para Y";
            this.btnintervalopredicciony.UseVisualStyleBackColor = false;
            this.btnintervalopredicciony.Click += new System.EventHandler(this.btnintervalopredicciony_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(699, 181);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(76, 20);
            this.textBox3.TabIndex = 34;
            // 
            // textBoxnegativo
            // 
            this.textBoxnegativo.Location = new System.Drawing.Point(699, 225);
            this.textBoxnegativo.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxnegativo.Name = "textBoxnegativo";
            this.textBoxnegativo.Size = new System.Drawing.Size(76, 20);
            this.textBoxnegativo.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(546, 182);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 16);
            this.label8.TabIndex = 36;
            this.label8.Text = "Con signo positivo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(546, 229);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 16);
            this.label9.TabIndex = 37;
            this.label9.Text = "Con signo negativo";
            // 
            // btnIntervaloMediaPoblacional
            // 
            this.btnIntervaloMediaPoblacional.BackColor = System.Drawing.Color.Transparent;
            this.btnIntervaloMediaPoblacional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntervaloMediaPoblacional.Location = new System.Drawing.Point(549, 273);
            this.btnIntervaloMediaPoblacional.Name = "btnIntervaloMediaPoblacional";
            this.btnIntervaloMediaPoblacional.Size = new System.Drawing.Size(274, 23);
            this.btnIntervaloMediaPoblacional.TabIndex = 38;
            this.btnIntervaloMediaPoblacional.Text = "10) Intervalo de confianza para Uy/ Xp";
            this.btnIntervaloMediaPoblacional.UseVisualStyleBackColor = false;
            this.btnIntervaloMediaPoblacional.Click += new System.EventHandler(this.btnIntervaloMediaPoblacional_Click);
            // 
            // lblIntervalo
            // 
            this.lblIntervalo.AutoSize = true;
            this.lblIntervalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntervalo.Location = new System.Drawing.Point(651, 329);
            this.lblIntervalo.Name = "lblIntervalo";
            this.lblIntervalo.Size = new System.Drawing.Size(76, 15);
            this.lblIntervalo.TabIndex = 40;
            this.lblIntervalo.Text = "≤ Uy / Xp ≤";
            // 
            // txtMenorIntervaloPoblacion
            // 
            this.txtMenorIntervaloPoblacion.Location = new System.Drawing.Point(561, 324);
            this.txtMenorIntervaloPoblacion.Name = "txtMenorIntervaloPoblacion";
            this.txtMenorIntervaloPoblacion.Size = new System.Drawing.Size(67, 20);
            this.txtMenorIntervaloPoblacion.TabIndex = 41;
            // 
            // txtMayorIntervaloPoblacion
            // 
            this.txtMayorIntervaloPoblacion.Location = new System.Drawing.Point(743, 324);
            this.txtMayorIntervaloPoblacion.Name = "txtMayorIntervaloPoblacion";
            this.txtMayorIntervaloPoblacion.Size = new System.Drawing.Size(67, 20);
            this.txtMayorIntervaloPoblacion.TabIndex = 42;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.RosyBrown;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(712, 454);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 43;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(837, 515);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.txtMayorIntervaloPoblacion);
            this.Controls.Add(this.txtMenorIntervaloPoblacion);
            this.Controls.Add(this.lblIntervalo);
            this.Controls.Add(this.btnIntervaloMediaPoblacional);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxnegativo);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btnintervalopredicciony);
            this.Controls.Add(this.textBoxpredicciones);
            this.Controls.Add(this.btnpredicciones);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.texBoxIntervalo2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxIntervalo1);
            this.Controls.Add(this.btnCalcuIntervaloB1);
            this.Controls.Add(this.texBoxCalculoTCuadrado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxCalT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.texboxsumatoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVerificacionb1);
            this.Controls.Add(this.txtTotalGradoLibertad);
            this.Controls.Add(this.txtTotalSumaCuadrado);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblRegresion);
            this.Controls.Add(this.txtAnalisisVarianza);
            this.Controls.Add(this.btnAnalisisVarianza);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.texBoxCalculob0);
            this.Controls.Add(this.btnCalcularb0);
            this.Controls.Add(this.texBoxCalculob1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CalcularB1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CalcularB1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox texBoxCalculob1;
        private System.Windows.Forms.Button btnCalcularb0;
        private System.Windows.Forms.TextBox texBoxCalculob0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnAnalisisVarianza;
        private System.Windows.Forms.TextBox txtAnalisisVarianza;
        private System.Windows.Forms.Label lblRegresion;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumaCuadrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradoLibertad;
        private System.Windows.Forms.DataGridViewTextBoxColumn minimoCuadrado;
        private System.Windows.Forms.DataGridViewTextBoxColumn analisiVarianza;
        private System.Windows.Forms.TextBox txtTotalSumaCuadrado;
        private System.Windows.Forms.TextBox txtTotalGradoLibertad;
        private System.Windows.Forms.Button btnVerificacionb1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox texboxsumatoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCalT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox texBoxCalculoTCuadrado;
        private System.Windows.Forms.Button btnCalcuIntervaloB1;
        private System.Windows.Forms.TextBox textBoxIntervalo1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox texBoxIntervalo2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnpredicciones;
        private System.Windows.Forms.TextBox textBoxpredicciones;
        private System.Windows.Forms.Button btnintervalopredicciony;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBoxnegativo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnIntervaloMediaPoblacional;
        private System.Windows.Forms.Label lblIntervalo;
        private System.Windows.Forms.TextBox txtMenorIntervaloPoblacion;
        private System.Windows.Forms.TextBox txtMayorIntervaloPoblacion;
        private System.Windows.Forms.Button btnRegresar;
    }
}