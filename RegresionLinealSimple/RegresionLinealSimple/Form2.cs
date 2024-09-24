using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RegresionLinealSimple
{
    public partial class Form2 : Form
    {

        //Se realiza para mantener una referencia a una instancia del formulario Form1 dentro de este otro Formulario
        //Form2; Para la comunicacion entre formularios
        private Form1 _form1;


        //Este es un constructor para el Formulario 2 (Form2), en este caso el constructor acepta un parametro del tipo Form1

        public Form2(Form1 form1)
        {

            InitializeComponent();
            //_form1 es una variable de instancia en el formulario actual, y se utiliza para almacenar una referencia 
            //a una instancia de otro objeto (en este caso una instancia de Form1)

            //asigna el valor del parametro form a la variable de instancia _form1
            _form1 = form1;

            btnCalcularb0.Enabled = false;
            texBoxCalculob0.Enabled = false;
            button1.Enabled = false;
            textBox1.Enabled = false;
            button2.Enabled = false;
            textBox2.Enabled = false;
            btnAnalisisVarianza.Enabled = false;
            txtAnalisisVarianza.Enabled = false;
            lblRegresion.Enabled = false;
            lblError.Enabled = false;
            lblTotal.Enabled = false;
            txtTotalSumaCuadrado.Enabled = false;
            txtTotalGradoLibertad.Enabled = false;
            dataGridView1.Enabled = false;
            btnVerificacionb1.Enabled = false;
            texboxsumatoria.Enabled = false;
            textBoxCalT.Enabled = false;
            texBoxCalculoTCuadrado.Enabled = false;
            btnCalcuIntervaloB1.Enabled = false;
            textBoxIntervalo1.Enabled = false;
            texBoxIntervalo2.Enabled = false;
            btnpredicciones.Enabled = false;
            textBoxpredicciones.Enabled = false;
            btnintervalopredicciony.Enabled = false;
            textBoxnegativo.Enabled = false;
            textBox3.Enabled = false;
            label3.Enabled = false;
            label4.Enabled = false;
            label5.Enabled = false;
            label7.Enabled = false;
            label6.Enabled = false;
            btnpredicciones.Enabled = false;
            textBoxpredicciones.Enabled = false;
            label8.Enabled = false;
            label9.Enabled = false;
            btnIntervaloMediaPoblacional.Enabled = false;
            lblIntervalo.Enabled = false;
            txtMenorIntervaloPoblacion.Enabled = false;
            txtMayorIntervaloPoblacion.Enabled = false;

        }

        //Para calcular b1
        private void CalcularB1_Click(object sender, EventArgs e)
        {
            calculob1();

        }

        private void btnCalcularb0_Click(object sender, EventArgs e)
        {

            string sumatoriavalorTotalAptitud = _form1.TotalAptitud;
            string sumatoriavalorTotalsatisfaccion = _form1.TotalSatisfaccion;
            string sumatoriavalorpotenciaAptitud = _form1.TotalPotenciaAptitud;
            string sumatoriavalorpotenciaSatisfaccion = _form1.TotalPotenciaSatis;
            string sumatoriavalorproductoxy = _form1.TotalProductoXY;

            //Conversion a numeros 

            double sumatotalAptitud = int.Parse(sumatoriavalorTotalAptitud);
            double sumatotalSatisfaccion = int.Parse(sumatoriavalorTotalsatisfaccion);
            double sumatotalpotenciaApti = int.Parse(sumatoriavalorpotenciaAptitud);
            double sumatotalpotenciaSatis = int.Parse(sumatoriavalorpotenciaSatisfaccion);
            double sumatotalProductoxy = int.Parse(sumatoriavalorproductoxy);

            double resultadoCal_b1 = ((sumatotalProductoxy - ((sumatotalAptitud) * (sumatotalSatisfaccion) / 10)) / (sumatotalpotenciaApti - ((Math.Pow(sumatotalAptitud, 2) / 10))));

            double resultadoCalb0 = (0.1 * (sumatotalSatisfaccion - resultadoCal_b1 * (sumatotalAptitud)));

            string resultadoCal_b0Formateado = resultadoCalb0.ToString("F4");

            texBoxCalculob0.Text = resultadoCal_b0Formateado;


            //Si x = 0
            double resultado1_Yc = resultadoCalb0 + resultadoCal_b1 * (0);
            double resultado2_YC = -resultadoCalb0 / resultadoCal_b1;

            MessageBox.Show("::   Yc = bo + b1(x)  ::" + " ," +
               "Si, X = 0; Y = " + resultado1_Yc + "" + "\n" +
               "............................................................................................" + " \n" +
               "Si Y = 0; X = " + resultado2_YC + "\n" + "\n" +
               "---------------------------------------------------------------------------------------" + " \n" +
               "El intercepto b0 representa el valor esperado de Y cuando X es igual a cero" + " ," +
               "En otras palabras, es el punto en el que la linea de regresion cruza el eje Y.");

            button1.Enabled = true;
            textBox1.Enabled = true;

        }

        public void calculob1()
        {
            //Se declara una variable local en Form2 llamada valorTotalAptitud que almacena el valor obtenido de la 
            //propiedad TotalAptitud de Form1.
            //_form1.TotalAptitud asigna el valor de TotalAptitud a la variable valorTotalAptitud.
            string sumatoriaTotalAptitud = _form1.TotalAptitud;
            string sumatoriaTotalsatisfaccion = _form1.TotalSatisfaccion;
            string sumatoriaPotenciaAptitud = _form1.TotalPotenciaAptitud;
            string sumatoriaPotenciaSatisfaccion = _form1.TotalPotenciaSatis;
            string sumatoriaProductoxy = _form1.TotalProductoXY;

            //Conversion de una cadena string, la que esta arriba a un numero decimal.

            double sumatotalAptitud = double.Parse(sumatoriaTotalAptitud);
            double sumatotalSatisfaccion = double.Parse(sumatoriaTotalsatisfaccion);
            double sumatotalpotenciaApti = double.Parse(sumatoriaPotenciaAptitud);
            double sumatotalpotenciaSatis = double.Parse(sumatoriaPotenciaSatisfaccion);
            double sumatotalProductoxy = double.Parse(sumatoriaProductoxy);


            //aqui ya se pueden hacer los calculos

            double resultadoCal_b1 = ((sumatotalProductoxy - ((sumatotalAptitud) * (sumatotalSatisfaccion) / 10)) / (sumatotalpotenciaApti - ((Math.Pow(sumatotalAptitud, 2) / 10))));

            string resultadoCal_b1Formateado = resultadoCal_b1.ToString("F4");

            texBoxCalculob1.Text = resultadoCal_b1Formateado;


            if (resultadoCal_b1 == 0)
            {
                MessageBox.Show("Este resultado indica que no hay relacion lineal entre la variable " +
                    "independiente x y la variable dependiente y");

            }

            else if (resultadoCal_b1 < 0)
            {
                MessageBox.Show("b1 representa el coeficiente de regresion lineal, en este caso b1 es = " + resultadoCal_b1Formateado +
                    "lo cual indica que a medida que X (puntaje de aptitud) aumenta, Y (puntaje de satisfaccion)" +
                    "  tiende a disminuir");
            }

            else if (resultadoCal_b1 > 0)
            {
                MessageBox.Show("b1 representa el coeficiente de regresion lineal, en este caso b1 es positivo  = " + resultadoCal_b1Formateado + " " +
                    "," +
                    "Lo cual significa que por cada unidad de aumento en el puntaje de aptitud, se espera que " +
                    "el puntaje de satisfaccion en el trabajo aumente en " + resultadoCal_b1Formateado + "," +
                    "b1 répresenta el cambio en la variable dependiente (Y)por cada unidad de cambio en la variable " +
                    "independiente (X)");

            }

            btnCalcularb0.Enabled = true;
            texBoxCalculob0.Enabled = true;

        }
        public void rcuadrado()
        {

            string sumatoriavalorproductoxy = _form1.TotalProductoXY;
            string sumatoriavalorTotalAptitud = _form1.TotalAptitud;
            string sumatoriavalorTotalsatisfaccion = _form1.TotalSatisfaccion;
            string sumatoriaPotenciaSatisfaccion = _form1.TotalPotenciaSatis;
            string sumatoriavalorpotenciaAptitud = _form1.TotalPotenciaAptitud;
            ////////////
            double sumatotalAptitud = int.Parse(sumatoriavalorTotalAptitud);
            double sumatotalSatisfaccion = int.Parse(sumatoriavalorTotalsatisfaccion);
            double sumatotalpotenciaSatis = int.Parse(sumatoriaPotenciaSatisfaccion);
            double sumatotalpotenciaApti = int.Parse(sumatoriavalorpotenciaAptitud);
            double sumatotalProductoxy = int.Parse(sumatoriavalorproductoxy);

            double resultadoCal_b1 = ((sumatotalProductoxy - ((sumatotalAptitud) * (sumatotalSatisfaccion) / 10)) / (sumatotalpotenciaApti - ((Math.Pow(sumatotalAptitud, 2) / 10))));

            double resultador = ((resultadoCal_b1 * (sumatotalProductoxy - ((sumatotalAptitud) * (sumatotalSatisfaccion) / 10))) / (sumatotalpotenciaSatis - ((Math.Pow(sumatotalSatisfaccion, 2) / 10))));

            string resulatdorFormateado = resultador.ToString("F4");
            textBox1.Text = resulatdorFormateado;

            double porcentaje = resultador * 100;
            string porcentajeFormateado = porcentaje.ToString("F2");

            if (resultador > 0 && resultador < 1)
            {
                MessageBox.Show($" {resulatdorFormateado} este valor siginifica que el {porcentajeFormateado} % de la " +
                    $"variabilidad del puntaje de sastifacción en el trabajo puede explicarse por la relación del puntaje" +
                    $"de aptitud del examen de admisión.");
            }
            else if (resultador > 1)
            {
                MessageBox.Show("R cuadrado debe estar en el rango de 0 y 1");
            }
            button2.Enabled = true;
            textBox2.Enabled = true;
        }
        public void CalculaR()
        {
            string sumatoriaTotalAptitud = _form1.TotalAptitud;
            string sumatoriaTotalsatisfaccion = _form1.TotalSatisfaccion;
            string sumatoriaPotenciaAptitud = _form1.TotalPotenciaAptitud;
            string sumatoriaPotenciaSatisfaccion = _form1.TotalPotenciaSatis;
            string sumatoriaProductoxy = _form1.TotalProductoXY;

            //Conversion de una cadena string, la que esta arriba a un numero decimal.

            double sumatotalAptitud = double.Parse(sumatoriaTotalAptitud);
            double sumatotalSatisfaccion = double.Parse(sumatoriaTotalsatisfaccion);
            double sumatotalpotenciaApti = double.Parse(sumatoriaPotenciaAptitud);
            double sumatotalpotenciaSatis = double.Parse(sumatoriaPotenciaSatisfaccion);
            double sumatotalProductoxy = double.Parse(sumatoriaProductoxy);

            double resultadoCal_b1 = ((sumatotalProductoxy - ((sumatotalAptitud) * (sumatotalSatisfaccion) / 10)) / (sumatotalpotenciaApti - ((Math.Pow(sumatotalAptitud, 2) / 10))));

            double resultador = ((resultadoCal_b1 * (sumatotalProductoxy - ((sumatotalAptitud) * (sumatotalSatisfaccion) / 10))) / (sumatotalpotenciaSatis - ((Math.Pow(sumatotalSatisfaccion, 2) / 10))));

            double raiz = Math.Sqrt(resultador);

            string raizFormateada = raiz.ToString("F4");

            textBox2.Text = raizFormateada;

            if (raiz == 1)
            {
                MessageBox.Show("Correlación positiva grande y perfecta, esto significa que hay una " +
                    "relación perfecta, fuerte y positiva entre el puntaje de aptitud del examen con el puntaje de satifación al trabajo.");
            }
            else if (raiz >= 0.9 || raiz < 0.99)
            {
                MessageBox.Show("Correlación positiva muy fuerte, esto significa que hay una " +
                    " relación  muy fuerte y positiva entre el puntaje de aptitud del examen con el puntaje de sastifación.");
            }
            else if (raiz >= 0.7 || raiz < 0.89)
            {
                MessageBox.Show("Correlación positiva fuerte, esto significa que hay una relacion fuerte y positiva " +
                    "entre el puntaje de aptitud del examen con el puntaje de sastifación.");
            }
            else if (raiz >= 0.4 || raiz < 0.69)
            {
                MessageBox.Show("Correlación positiva moderada, esto significa que hay una relacion moderada y positiva " +
                    "entre el punataje de aptitud del examen con el puntaje de satisfaccion del trabajo.");                 
            }
            else if (raiz >= 0.2 || raiz < 0.39)
            {
                MessageBox.Show("Correlación positiva mala, esto significa que hay una relacion mala y positiva " +
                    "entre el puntaje de aptitud del examen con el puntaje de satisfaccion al trabajo.");
            }
            else if (raiz >= 0.01 || raiz < 0.19)
            {
                MessageBox.Show("Correlación positiva muy mala, esto significa que hay una relacion muy mala y positiva " +
                    "entre el puntaje de aptitud del examen con el puntaje de satisfaccion al trabajo.");
            }
            else if (raiz == 0)
            {
                MessageBox.Show("Correlación nula, esto significa que no hay relacion lineal entre el puntaje de aptitud " +
                    "del examen con el puntaje de satisfaccion del trabajo.");
            }
            else if (raiz <= -0.01 || raiz > -0.19)
            {
                MessageBox.Show("Correlación negativa muy mala, esro significa que hay una relacion muy mala y negativa " +
                    "entre el puntaje de aptitud del examen con el puntaje de satisfaccio al trabajo.");
            }
            else if (raiz <= -0.2 || raiz > -0.39)
            {
                MessageBox.Show("Correlación negativa mala, esto significa que hay una relacion mala y negativa " +
                    "entre el puntaje de aptitud del examen con el examen de satisfaccion al trabajo.");
            }
            else if (raiz <= -0.4 || raiz > -0.69)
            {
                MessageBox.Show("Correlación negativa moderada, esto significa que hay una relacion moderada " +
                    "y negativa entre el puntaje de aptitud del examen con el puntaje de satisfaccio al trabajo.");
            }
            else if (raiz <= -0.7 || raiz > -0.89)
            {
                MessageBox.Show("Correlación negativa fuerte, esro significa que hay una relacion fuerte y negativa " +
                    "entre el puntaje de aptitud del examen con el puntaje de satisfaccion al trabajo.");
            }
            else if (raiz <= -0.9 || raiz > -0.99)
            {
                MessageBox.Show("Correlación negativa muy fuerte, esto significa que hay una relacion muy fuerte y negativa " +
                    "entre el puntaje de aptitud del examen con el puntaje de satisfaccion al trabajo.");
            }
            else if (raiz == -1)
            {
                MessageBox.Show("Correlación negativa grande y perfecta, esto significa que hay una relacion perfecta, " +
                    "fuerte y negativa entre el puntaje de aptitud del examen con el puntaje de stisfaccion al trabajo.");
            }


            btnAnalisisVarianza.Enabled = true;
            txtAnalisisVarianza.Enabled = true;
            lblRegresion.Enabled = true;
            lblError.Enabled = true;
            lblTotal.Enabled = true;
            txtTotalSumaCuadrado.Enabled = true;
            txtTotalGradoLibertad.Enabled = true;
            dataGridView1.Enabled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rcuadrado();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalculaR();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            //Se esta indicando la cantidad de filas que se añadiran a la tabla
            dataGridView1.Rows.Add(1);

        }

        private void btnAnalisisVarianza_Click(object sender, EventArgs e)
        {

            //Se declara una variable local en Form2 llamada sumatoriaTotalAptitud que almacena el valor obtenido de la 
            //propiedad TotalAptitud del Form1.
            //_form1.TotalAptitud asigna el valor de la propiedad TotalAptitud a la variable sumatoriaTotalAptitud con la que se estaran trabajando.
            string sumatoriaTotalAptitud = _form1.TotalAptitud;
            string sumatoriaTotalsatisfaccion = _form1.TotalSatisfaccion;
            string sumatoriaPotenciaAptitud = _form1.TotalPotenciaAptitud;
            string sumatoriaPotenciaSatisfaccion = _form1.TotalPotenciaSatis;
            string sumatoriaProductoxy = _form1.TotalProductoXY;

            //Conversion de una cadena string a un numero decimal.

            double sumatotalAptitud = double.Parse(sumatoriaTotalAptitud);
            double sumatotalSatisfaccion = double.Parse(sumatoriaTotalsatisfaccion);
            double sumatotalpotenciaApti = double.Parse(sumatoriaPotenciaAptitud);
            double sumatotalpotenciaSatis = double.Parse(sumatoriaPotenciaSatisfaccion);
            double sumatotalProductoxy = double.Parse(sumatoriaProductoxy);

            // Se calcula b1

            double resultadoCal_b1 = ((sumatotalProductoxy - ((sumatotalAptitud) * (sumatotalSatisfaccion) / 10)) / (sumatotalpotenciaApti - ((Math.Pow(sumatotalAptitud, 2) / 10))));

            // Se calcula r^2

            double numeradorPotenciaR = resultadoCal_b1 * (sumatotalProductoxy - ((sumatotalAptitud) * (sumatotalSatisfaccion)) / 10);

            double denominadorPotenciaR = sumatotalpotenciaSatis - ((Math.Pow(sumatotalSatisfaccion, 2) / 10));

            // Esto nos sirve para tomar, maximo 4 decimales en los calculos

            string numeradorPotenciaRFormateado = numeradorPotenciaR.ToString("F4");

            string denominadorPotenciaRFormateado = denominadorPotenciaR.ToString("F4");

            //-------------COLUMNA 1-------------

            //Añadimos a la tabla el valor de la suma cuadrada de regresion

            dataGridView1.Rows[0].Cells[0].Value = numeradorPotenciaRFormateado;

            // Calculamos el error

            double error = denominadorPotenciaR - numeradorPotenciaR;

            string errorFormateado = error.ToString("F4");

            //Añadimos a la tabla el valor de la suma cuadrada de error

            dataGridView1.Rows[1].Cells[0].Value = errorFormateado;

            //------------COLUMNA 2------------

            //Añadimos a la tabla el valor de el grado de libertad de la regresion

            int gl = 1;

            dataGridView1.Rows[0].Cells[1].Value = gl;

            //Añadimos a la tabla el valor de el grado de libertad de el error

            int totalMuestra = 10;

            dataGridView1.Rows[1].Cells[1].Value = totalMuestra - 2;

            // Calcularemos la suma total de la primer columna, podemos ver que sera la misma cantidad del denominador de r^2 y sumamos la segunda columna
            //Inicializamos las variables donde se guardaran los totales de la primera y segunda columna

            double sumaTotalCuadrado = 0;
            int totalGradoLibertad = 0;

            //Recorre las 2 filas de la tabla
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {

                //Las variabales van sumando y guardando todos los datos de cada fila respecto a su columna

                sumaTotalCuadrado += Convert.ToDouble(fila.Cells["sumaCuadrado"].Value);

                totalGradoLibertad += Convert.ToInt32(fila.Cells["gradoLibertad"].Value);

            }

            //Se imprimen en los textBox, los totales de las sumatorias de las 2 filas en su respectiva columna

            txtTotalSumaCuadrado.Text = sumaTotalCuadrado.ToString();

            txtTotalGradoLibertad.Text = totalGradoLibertad.ToString();

            //-------------COLUMNA 3-------------

            double minimoCuadradoRegresion = numeradorPotenciaR / gl;

            string minimoCuadradoRegresionFormateado = minimoCuadradoRegresion.ToString("F4");

            dataGridView1.Rows[0].Cells[2].Value = minimoCuadradoRegresionFormateado;

            double minimoCuadradoError = error / (totalMuestra - 2);

            string minimoCuadradoErrorFormateado = minimoCuadradoError.ToString("F4");

            dataGridView1.Rows[1].Cells[2].Value = minimoCuadradoErrorFormateado;

            //-------------COLUMNA 4----------

            double AnalisisVarianza = minimoCuadradoRegresion / minimoCuadradoError;

            string AnalisisVarianzaFormateado = AnalisisVarianza.ToString("F4");

            dataGridView1.Rows[0].Cells[3].Value = AnalisisVarianzaFormateado;


            //Mostramos el valor resultante de rv en el textbox
            txtAnalisisVarianza.Text = AnalisisVarianzaFormateado;


            //Este es el valor que se encontro en la tablita de ficher, en la intercepcion de 1 grado de libertad en el numerador
            // y 8 grado de libertad en el denominador. Ademas trabajamos con el nivel de confianza del 95% y con un nivel de significancia de 5%.

            double valorTablitaFicher = 14.69;

            //Validacion de los resultados de RV

            if (AnalisisVarianza > valorTablitaFicher)
            {
                MessageBox.Show(" RV es " + AnalisisVarianzaFormateado + ", podemos observar que RV es mayor al valor tabulado de la tablita de ficher, siendo Fo(995, 1, 8) = " +
                    valorTablitaFicher + " < " + AnalisisVarianzaFormateado + ", esto significa que se rechaza la hipotesis nula de que no hay ninguna relacion lineal entre el puntaje " +
                    "de aptitud y satisfaccion. Por lo tanto se afirma de que si existe una relacion lineal entre el puntaje de aptitud y el puntaje de satisfaccion al trabajo" +
                    ", es decir aceptamos la hipotesis alterna.");

            }
            else if (AnalisisVarianza < valorTablitaFicher)
            {

                MessageBox.Show(" RV es " + AnalisisVarianzaFormateado + ", podemos observar que RV es menor al valor tabulado de la tablita de ficher, siendo Fo(995, 1, 8) = " +
                    valorTablitaFicher + " > " + AnalisisVarianzaFormateado + ", esto significa que es verdadera la hipotesis nula de que no hay ninguna relacion lineal entre el puntaje " +
                    "de aptitud y satisfaccion al trabajo. Por lo tanto se afirma de que no existe una relacion lineal entre el puntaje de aptitud y el puntaje de satisfaccion al trabajo" +
                    ", es decir aceptamos la hipotesis nula.");


            }
            else
            {

                MessageBox.Show("No existe este analisis.");

            }

            btnVerificacionb1.Enabled = true;
            label3.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;

        }

        private void btnVerificacionb1_Click(object sender, EventArgs e)
        {
            texboxsumatoria.Enabled = true;
            textBoxCalT.Enabled = true;
            texBoxCalculoTCuadrado.Enabled = true;


            string sumatoriavalorpotenciaAptitud = _form1.TotalPotenciaAptitud;
            double sumatotalpotenciaApti = int.Parse(sumatoriavalorpotenciaAptitud);
            string sumatoriavalorTotalAptitud = _form1.TotalAptitud;
            double sumatotalAptitud = int.Parse(sumatoriavalorTotalAptitud);

            double sumatoria = sumatotalpotenciaApti - ((Math.Pow(sumatotalAptitud, 2)) / 10);
            string sumatoriaX = sumatoria.ToString();
            texboxsumatoria.Text = sumatoriaX;

            double sumatoriaConvertida = double.Parse(sumatoriaX);

            string sumatoriavalorTotalsatisfaccion = _form1.TotalSatisfaccion;

            string sumatoriavalorpotenciaSatisfaccion = _form1.TotalPotenciaSatis;
            string sumatoriavalorproductoxy = _form1.TotalProductoXY;

            //Conversion a numeros 


            double sumatotalSatisfaccion = int.Parse(sumatoriavalorTotalsatisfaccion);

            double sumatotalpotenciaSatis = int.Parse(sumatoriavalorpotenciaSatisfaccion);
            double sumatotalProductoxy = int.Parse(sumatoriavalorproductoxy);

            double resultadoCal_b1 = ((sumatotalProductoxy - ((sumatotalAptitud) * (sumatotalSatisfaccion) / 10)) / (sumatotalpotenciaApti - ((Math.Pow(sumatotalAptitud, 2) / 10))));

            string resultadoCal_b1Formateado = resultadoCal_b1.ToString("F4");

            texBoxCalculob1.Text = resultadoCal_b1Formateado;

            double resultCalb1Convertido = double.Parse(resultadoCal_b1Formateado);




            //Traemos el valor de la suma de cuadrado
            double sumaCuadrados = Convert.ToDouble(dataGridView1.Rows[1].Cells["sumaCuadrado"].Value);

            //calculo de t

            //Calculo de MCError 

            double McError = sumaCuadrados / 8;
            double calculoDivisionRaiz = McError / sumatoriaConvertida;

            //Calculo de T
            double CalculoT = resultCalb1Convertido / (Math.Sqrt(calculoDivisionRaiz));
            string CalculoTFormateado = CalculoT.ToString("F4");
            textBoxCalT.Text = CalculoTFormateado;

            //Calcular si T^2 es igual a Rv.

            //****************************************************
            //Traemos el valor de rv que se encuentra en la tabla de la varianza


            double razonVarianza = Convert.ToDouble(dataGridView1.Rows[0].Cells["analisiVarianza"].Value);

            double calculoTCuadrada = Math.Pow(CalculoT, 2);

            string calculoTCuadradaFormat = calculoTCuadrada.ToString("F4");
            texBoxCalculoTCuadrado.Text = calculoTCuadradaFormat;



            if (Math.Floor(calculoTCuadrada) == Math.Floor(razonVarianza))
            {
                MessageBox.Show("Ya que t^2 es igual a Rv, se asegura que Rv es correcta, de que hay una correlacion " +
                    "fuerte, creciente y β1 es correcta. ");

            }
            else
            {

                MessageBox.Show("si Rv y t^2 son diferentes, puede ser por que se estan analizando diferentes " +
                   "situaciones (mas de 2 grupos en ANOVA frente a solo 2 en la prueba t.");

            }

            btnCalcuIntervaloB1.Enabled = true;
            label7.Enabled = true;
            label6.Enabled = true;

        }

        private void btnCalcuIntervaloB1_Click(object sender, EventArgs e)
        {

            textBoxIntervalo1.Enabled = true;
            texBoxIntervalo2.Enabled = true;


            double valorTablaTStudent = 2.3060;
            string sumatoriavalorpotenciaAptitud = _form1.TotalPotenciaAptitud;
            double sumatotalpotenciaApti = int.Parse(sumatoriavalorpotenciaAptitud);
            string sumatoriavalorTotalAptitud = _form1.TotalAptitud;
            double sumatotalAptitud = int.Parse(sumatoriavalorTotalAptitud);

            double sumatoria = sumatotalpotenciaApti - ((Math.Pow(sumatotalAptitud, 2)) / 10);
            string sumatoriaX = sumatoria.ToString();
            texboxsumatoria.Text = sumatoriaX;

            double sumatoriaConvertida = double.Parse(sumatoriaX);

            string sumatoriavalorTotalsatisfaccion = _form1.TotalSatisfaccion;

            string sumatoriavalorpotenciaSatisfaccion = _form1.TotalPotenciaSatis;
            string sumatoriavalorproductoxy = _form1.TotalProductoXY;

            //Conversion a numeros 


            double sumatotalSatisfaccion = int.Parse(sumatoriavalorTotalsatisfaccion);

            double sumatotalpotenciaSatis = int.Parse(sumatoriavalorpotenciaSatisfaccion);
            double sumatotalProductoxy = int.Parse(sumatoriavalorproductoxy);

            double resultadoCal_b1 = ((sumatotalProductoxy - ((sumatotalAptitud) * (sumatotalSatisfaccion) / 10)) / (sumatotalpotenciaApti - ((Math.Pow(sumatotalAptitud, 2) / 10))));

            string resultadoCal_b1Formateado = resultadoCal_b1.ToString("F4");

            texBoxCalculob1.Text = resultadoCal_b1Formateado;

            double resultCalb1Convertido = double.Parse(resultadoCal_b1Formateado);


            //Traemos el valor de la suma de cuadrado
            double sumaCuadrados = Convert.ToDouble(dataGridView1.Rows[1].Cells["sumaCuadrado"].Value);

            //calculo de t

            //Calculo de MCError 

            double McError = sumaCuadrados / 8;


            double calculoIntervaloConfianzaParte1 = (resultCalb1Convertido - valorTablaTStudent * (Math.Sqrt(McError / sumatoriaConvertida)));
            string calculoInterConfian1Formateado = calculoIntervaloConfianzaParte1.ToString("F4");
            textBoxIntervalo1.Text = calculoInterConfian1Formateado;

            double calculoIntervaloConfianzaParte2 = (resultCalb1Convertido + valorTablaTStudent * (Math.Sqrt(McError / sumatoriaConvertida)));
            string calculoInterConfian2Formateado = calculoIntervaloConfianzaParte2.ToString("F4");
            texBoxIntervalo2.Text = calculoInterConfian2Formateado;

            MessageBox.Show("C, representa los intervalos de confianza para β1. tenemos el 95% de confianza al  " +
                "afirmar que el puntaje promedio de satisfaccion aumenta entre " + calculoInterConfian1Formateado +
                "y " + calculoInterConfian2Formateado + " puntos para cada aumento de 1 punto en el puntaje" +
                "de aptitud. Esto sugiere que a medida que mejoran las aptitudes, tambien se incrementa la " +
                "satisfaccion en el trabajo");

            btnpredicciones.Enabled = true;
            textBoxpredicciones.Enabled = true;
            btnpredicciones.Enabled = true;
            textBoxpredicciones.Enabled = true;
        }

        private void btnpredicciones_Click(object sender, EventArgs e)
        {
            string sumatoriavalorTotalAptitud = _form1.TotalAptitud;
            string sumatoriavalorTotalsatisfaccion = _form1.TotalSatisfaccion;
            string sumatoriavalorpotenciaAptitud = _form1.TotalPotenciaAptitud;
            string sumatoriavalorpotenciaSatisfaccion = _form1.TotalPotenciaSatis;
            string sumatoriavalorproductoxy = _form1.TotalProductoXY;

            //Conversion a numeros 

            double sumatotalAptitud = int.Parse(sumatoriavalorTotalAptitud);
            double sumatotalSatisfaccion = int.Parse(sumatoriavalorTotalsatisfaccion);
            double sumatotalpotenciaApti = int.Parse(sumatoriavalorpotenciaAptitud);
            double sumatotalpotenciaSatis = int.Parse(sumatoriavalorpotenciaSatisfaccion);
            double sumatotalProductoxy = int.Parse(sumatoriavalorproductoxy);

            double resultadoCal_b1 = ((sumatotalProductoxy - ((sumatotalAptitud) * (sumatotalSatisfaccion) / 10)) / (sumatotalpotenciaApti - ((Math.Pow(sumatotalAptitud, 2) / 10))));

            double resultadoCalb0 = (0.1 * (sumatotalSatisfaccion - resultadoCal_b1 * (sumatotalAptitud)));

            double yc = resultadoCalb0 + resultadoCal_b1 * (100);

            string ycformateado = yc.ToString("F3");

            textBoxpredicciones.Text = ycformateado;

            MessageBox.Show($"Si un profesional obtiene 100 de puntaje en una prueba de aptitud para" +
                " un estudio profesional, entonces el puntaje de sastifacción en un futuro en el trabajo será de " + ycformateado);


            btnintervalopredicciony.Enabled = true;
            textBoxnegativo.Enabled = true;
            textBox3.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
        }

        private void btnintervalopredicciony_Click(object sender, EventArgs e)
        {
            string sumatoriaTotalAptitud = _form1.TotalAptitud;
            string sumatoriaTotalsatisfaccion = _form1.TotalSatisfaccion;
            string sumatoriaPotenciaAptitud = _form1.TotalPotenciaAptitud;
            string sumatoriaPotenciaSatisfaccion = _form1.TotalPotenciaSatis;
            string sumatoriaProductoxy = _form1.TotalProductoXY;

            //Conversion de una cadena string a un numero decimal.

            double sumatotalAptitud = double.Parse(sumatoriaTotalAptitud);
            double sumatotalSatisfaccion = double.Parse(sumatoriaTotalsatisfaccion);
            double sumatotalpotenciaApti = double.Parse(sumatoriaPotenciaAptitud);
            double sumatotalpotenciaSatis = double.Parse(sumatoriaPotenciaSatisfaccion);
            double sumatotalProductoxy = double.Parse(sumatoriaProductoxy);


            double resultadoCal_b1 = ((sumatotalProductoxy - ((sumatotalAptitud) * (sumatotalSatisfaccion) / 10)) / (sumatotalpotenciaApti - ((Math.Pow(sumatotalAptitud, 2) / 10))));

            double resultadoCalb0 = (0.1 * (sumatotalSatisfaccion - resultadoCal_b1 * (sumatotalAptitud)));

            double numeradorPotenciaR = resultadoCal_b1 * (sumatotalProductoxy - ((sumatotalAptitud) * (sumatotalSatisfaccion)) / 10);

            double denominadorPotenciaR = sumatotalpotenciaSatis - ((Math.Pow(sumatotalSatisfaccion, 2) / 10));

            double error = denominadorPotenciaR - numeradorPotenciaR;

            int totalMuestra = 10;

            double minimoCuadradoError = error / (totalMuestra - 2);

            double yc = resultadoCalb0 + resultadoCal_b1 * (100);

            double sumatoria = sumatotalpotenciaApti - ((Math.Pow(sumatotalAptitud, 2)) / 10);

            double X = (sumatotalAptitud / totalMuestra);

            double to = 2.3060;

            // Calculo de los intervalos 

            double intervalo = yc + to * Math.Sqrt(minimoCuadradoError)*Math.Sqrt( 1 + 1/totalMuestra + Math.Pow(100 - X, 2) / sumatoria);

            double intervalonegativo = yc - to * Math.Sqrt(minimoCuadradoError) * Math.Sqrt(1 + (1 / totalMuestra) + Math.Pow(100 - X, 2) / sumatoria);

            string resultadopositivoFormateado = intervalo.ToString("F4");
            textBox3.Text = resultadopositivoFormateado;

            string resultadonrgativoFormateado = intervalonegativo.ToString("F4");
            textBoxnegativo.Text = resultadonrgativoFormateado;

            MessageBox.Show($"Podemos afirmar con un 95% de confianza que el puntaje de sastifacción de" +
                " una persona que obtiene 100 de puntaje de aptitud esta entre un puntaje de sastifacción de 99.0890 y 73.3110.");

            btnIntervaloMediaPoblacional.Enabled = true;
            lblIntervalo.Enabled = true;
            txtMenorIntervaloPoblacion.Enabled = true;
            txtMayorIntervaloPoblacion.Enabled = true;

        }

        private void btnIntervaloMediaPoblacional_Click(object sender, EventArgs e)
        {
            int totalMuestra = 10;
            int Xp = 100;

            string sumatoriaTotalAptitud = _form1.TotalAptitud;
            string sumatoriaTotalsatisfaccion = _form1.TotalSatisfaccion;
            string sumatoriaPotenciaAptitud = _form1.TotalPotenciaAptitud;
            string sumatoriaPotenciaSatisfaccion = _form1.TotalPotenciaSatis;
            string sumatoriaProductoxy = _form1.TotalProductoXY;

            //Conversion de una cadena string a un numero decimal.

            double sumatotalAptitud = double.Parse(sumatoriaTotalAptitud);
            double sumatotalSatisfaccion = double.Parse(sumatoriaTotalsatisfaccion);
            double sumatotalpotenciaApti = double.Parse(sumatoriaPotenciaAptitud);
            double sumatotalpotenciaSatis = double.Parse(sumatoriaPotenciaSatisfaccion);
            double sumatotalProductoxy = double.Parse(sumatoriaProductoxy);

            // Se calcula b1

            double resultadoCal_b1 = ((sumatotalProductoxy - ((sumatotalAptitud) * (sumatotalSatisfaccion) / 10)) / (sumatotalpotenciaApti - ((Math.Pow(sumatotalAptitud, 2) / 10))));

            //Se calcula bo

            double resultadoCalb0 = (0.1 * (sumatotalSatisfaccion - resultadoCal_b1 * (sumatotalAptitud)));

            // ----------- Calculamos la prediccion Yc --------------

            double yc = resultadoCalb0 + resultadoCal_b1 * (Xp);

            // ------ Valor tabulado de la taba de t student con un nivel de significancia de 0.05 ------

            double to = 2.3060;

            // ----------- Calculo de M.C.E --------------

            //Calculo de los valores de r^2

            double numeradorPotenciaR = resultadoCal_b1 * (sumatotalProductoxy - ((sumatotalAptitud) * (sumatotalSatisfaccion)) / 10);

            double denominadorPotenciaR = sumatotalpotenciaSatis - ((Math.Pow(sumatotalSatisfaccion, 2) / 10));

            // Calculamos el error

            double error = denominadorPotenciaR - numeradorPotenciaR;

            // ----------- Calculo de M.C.E -------------

            double minimoCuadradoError = error / (totalMuestra - 2);

            // ---------- Calculo de la media poblacional ---------- 

            double X = (sumatotalAptitud) / totalMuestra;

            // Calculo del denominador de la formula

            double  denominador = sumatotalpotenciaApti - ((Math.Pow(sumatotalAptitud, 2)) / totalMuestra);

            // Calculo de los intervalos de confianza para la media poblacional 

            double datoMenorIntervalo = yc - to * Math.Sqrt (minimoCuadradoError) * ( Math.Sqrt (1 / totalMuestra + (Math.Pow (Xp - X, 2) / denominador)));

            double datoMayorIntervalo = yc + to * Math.Sqrt(minimoCuadradoError) * (Math.Sqrt(1 / totalMuestra + (Math.Pow(Xp - X, 2) / denominador)));

            //Redondeamos a 4

            string datoMenorIntervaloFormateado = datoMenorIntervalo.ToString("F4");

            string datoMayorIntervaloFormateado = datoMayorIntervalo.ToString("F4");

            //Impresion en los texbox

            txtMenorIntervaloPoblacion.Text = datoMenorIntervaloFormateado.ToString();

            txtMayorIntervaloPoblacion.Text = datoMayorIntervaloFormateado.ToString();

            MessageBox.Show("Se puede afirmar con un 95% de confianza, que el puntaje de sastifaccion al trabajo " +
                "de una poblacion de trabajadores, cada uno de los cuales obtiene un puntaje de aptitud de " + Xp +
                " estara entre: " +datoMenorIntervaloFormateado+ " y " +datoMayorIntervaloFormateado + ".");

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {

            //Instancia del formulario #2

            Form1 conector = new Form1();
            this.Hide();
            conector.Show();

        }
    }
}
