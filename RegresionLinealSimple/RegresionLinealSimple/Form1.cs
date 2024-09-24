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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            btnCalcularTotales.Enabled = false;

            btnCalculoAnalisis.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //Se esta indicando la cantidad de filas que se añadiran a la tabla
            dataGridView1.Rows.Add(10); 

            //Añadimos en orden el numero de los profesionales
            dataGridView1.Rows[0].Cells[0].Value = 1;
            dataGridView1.Rows[1].Cells[0].Value = 2;
            dataGridView1.Rows[2].Cells[0].Value = 3;
            dataGridView1.Rows[3].Cells[0].Value = 4;
            dataGridView1.Rows[4].Cells[0].Value = 5;
            dataGridView1.Rows[5].Cells[0].Value = 6;
            dataGridView1.Rows[6].Cells[0].Value = 7;
            dataGridView1.Rows[7].Cells[0].Value = 8;
            dataGridView1.Rows[8].Cells[0].Value = 9;
            dataGridView1.Rows[9].Cells[0].Value = 10;

            //Añadimos en orden, la respuesta al puntaje de aptitud del examen conforme cada profesional
            dataGridView1.Rows[0].Cells[1].Value = 50;
            dataGridView1.Rows[1].Cells[1].Value = 55;
            dataGridView1.Rows[2].Cells[1].Value = 60;
            dataGridView1.Rows[3].Cells[1].Value = 65;
            dataGridView1.Rows[4].Cells[1].Value = 70;
            dataGridView1.Rows[5].Cells[1].Value = 75;
            dataGridView1.Rows[6].Cells[1].Value = 80;
            dataGridView1.Rows[7].Cells[1].Value = 85;
            dataGridView1.Rows[8].Cells[1].Value = 90;
            dataGridView1.Rows[9].Cells[1].Value = 95;

            //Añadimos en orden, la respuesta al puntaje de satisfaccion al trabajo conforme cada profesional
            dataGridView1.Rows[0].Cells[2].Value = 58;
            dataGridView1.Rows[1].Cells[2].Value = 54;
            dataGridView1.Rows[2].Cells[2].Value = 67;
            dataGridView1.Rows[3].Cells[2].Value = 64;
            dataGridView1.Rows[4].Cells[2].Value = 66;
            dataGridView1.Rows[5].Cells[2].Value = 73;
            dataGridView1.Rows[6].Cells[2].Value = 70;
            dataGridView1.Rows[7].Cells[2].Value = 85;
            dataGridView1.Rows[8].Cells[2].Value = 74;
            dataGridView1.Rows[9].Cells[2].Value = 85;

            //Permite la edicion de celdas 
            dataGridView1.ReadOnly = false;

        } 

        private void btnCalcularColumnas_Click(object sender, EventArgs e)
        {

            //Recorre todas las filas de la tabla
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {

                //Se verifica que las filas de las columna X y Y no esten vacia
                if (fila.Cells["PuntajeAptitudX"].Value != null && fila.Cells["PuntajeSatisfaccionY"].Value != null)
                {

                    //Obtenemos el valor de la columna x de cada fila y elevamos al cuadrado
                    int puntajeAptitud = Convert.ToInt32(fila.Cells["PuntajeAptitudX"].Value);

                    int potenciaPuntajeAptitud = puntajeAptitud * puntajeAptitud;

                    //Guardamos el valor de x al cuadrado, en la columna de x^2
                    fila.Cells["PotenciaDePuntajeDeAptitud"].Value = potenciaPuntajeAptitud;


                    //Obtenemos el valor de la columna y de cada fila y elevamos al cuadrado
                    int puntajeSatisfaccion = Convert.ToInt32(fila.Cells["PuntajeSatisfaccionY"].Value);

                    int potenciaPuntajeSatisfaccion = puntajeSatisfaccion * puntajeSatisfaccion;

                    //Guardamos el valor de y al cuadrado, en la columna de x^2
                    fila.Cells["PotenciaDePuntajeDeSatisfaccion"].Value = potenciaPuntajeSatisfaccion;


                    //Se multiplica el valor de cada fila de la columna X y Y
                    int productoPuntajeSatisfaccion = puntajeAptitud * puntajeSatisfaccion;

                    //Guardamos el valor del producto, en la columna de x*y
                    fila.Cells["ProductoDeAptitudySatisfaccion"].Value = productoPuntajeSatisfaccion;


                }
            }

            //Habilitamos el boton de los totales
            btnCalcularTotales.Enabled = true;
        }

        private void btnCalcularTotales_Click(object sender, EventArgs e)
        {

            //Inicializamos las variables donde guardaran los totales de cada columna 
            int totalPuntajeAptitud = 0, totalPuntajeSatisfaccion = 0, totalPotenciaAptitud = 0, totalPotenciaSatisfaccion = 0, totalProductoAptitudSatisfaccion = 0;

            //Recorre todas las filas de la tabla
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                
                //Las variabales van sumando y guardando todos los datos de cada fila respecto a su columna

                totalPuntajeAptitud += Convert.ToInt32(fila.Cells["PuntajeAptitudX"].Value);

                totalPuntajeSatisfaccion += Convert.ToInt32(fila.Cells["PuntajeSatisfaccionY"].Value);

                totalPotenciaAptitud += Convert.ToInt32(fila.Cells["PotenciaDePuntajeDeAptitud"].Value);

                totalPotenciaSatisfaccion += Convert.ToInt32(fila.Cells["PotenciaDePuntajeDeSatisfaccion"].Value);

                totalProductoAptitudSatisfaccion += Convert.ToInt32(fila.Cells["ProductoDeAptitudySatisfaccion"].Value);

            }

            //Se imprimen en los textBox, los totales de las sumatorias de cada fila en su respectiva columna

            txtTotalAptitud.Text = totalPuntajeAptitud.ToString();

            txtTotalSatisfaccion.Text = totalPuntajeSatisfaccion.ToString();

            txtTotalPotenciaAptitud.Text = totalPotenciaAptitud.ToString();

            txtTotalPotenciaSatisfaccion.Text = totalPotenciaSatisfaccion.ToString();

            txtTotalProductoAptitudSatisfaccion.Text = totalProductoAptitudSatisfaccion.ToString();


            btnCalculoAnalisis.Enabled = true;
        }

        private void btnCalculoAnalisis_Click(object sender, EventArgs e)
        {

            this.Hide();

            //Instancia del formulario #2

            Form2 conector = new Form2(this);
            conector.Show();

        }
        
        private void btnSalir_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        //Estas son propiedades para obtener el valor de cada uno de los Textbox donde se calcularon las sumatorias
        public string TotalAptitud
        {
            get { return txtTotalAptitud.Text; }

        }
        public string TotalSatisfaccion
        {
            get { return txtTotalSatisfaccion.Text; }
        }

        public string TotalPotenciaAptitud
        {
            get { return txtTotalPotenciaAptitud.Text; }
        }

        public string TotalPotenciaSatis
        {
            get { return txtTotalPotenciaSatisfaccion.Text; }
        }

        public string TotalProductoXY
        {
            get { return txtTotalProductoAptitudSatisfaccion.Text; }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int colIndex = e.ColumnIndex;
            string nuevoValor = dataGridView1.Rows[rowIndex].Cells[colIndex].ToString();
        }
    }
}
