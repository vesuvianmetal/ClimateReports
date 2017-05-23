using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


///Using Msql.Data.MysqlClient sirve para importar las librerias para estableces la conexion a mysql
using MySql.Data.MySqlClient;


namespace ClimateReports
{
    public partial class Humedad : Form
    {

        /// <summary>
        /// conn = declaracion de variable para obtener conexion a la base de datos 
        /// </summary>
        MySqlConnection conn = ConexionBD.ObtenerConexion();

        //metodo para llenar grafica
        void llenargrafica()
        {
            //consulta a la tabla de humedad
            string query_grafica = "select hum_dato,hum_nombre_sensor from humedad";

            //se declara el comando que se le hara a mysql junto con la consulta y la variable de conexion
            MySqlCommand cmd_query_grafica = new MySqlCommand(query_grafica, conn);

            //se declara una variable que servira para ejecutar el comando de llenar grafica
            MySqlDataReader leergrafica;
            try
            {

                //abre la conexion a la base de datos
                conn.Open();

                //se le asigna la ejecucion del comando a la variable leergrafica
                leergrafica = cmd_query_grafica.ExecuteReader();

                //antes de realizar la graficacion se le borra todos los puntos ya que cuando se actualize, se ocupa regraficar todo
                chart1.Series["Humedad"].Points.Clear();

                //si se leen los datos de la consulta entonces se reaaliza a graficas
                while (leergrafica.Read())
                {


                    //se le dan los valores a X y Y con los valores obtenidos de la base de datos
                    this.chart1.Series["Humedad"].Points.AddXY(leergrafica.GetString("hum_nombre_sensor"), leergrafica.GetFloat("hum_dato"));

                }



            }

            //atrapa cualquier error
            catch (Exception ex)
            {
                //muestra el error atrapado y los muestra en una ventana
                MessageBox.Show(ex.Message);
            }

            //cierra la conexion a la base de datos
            conn.Close();

        }

        public Humedad()
        {
            InitializeComponent();
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //cada que el timer haga un tick (en este caso es de 10 segundos) se realizara la funcion de llenar grafica
            llenargrafica();
        }

        private void Humedad_Load(object sender, EventArgs e)
        {
            //activa el timer
            timer1.Enabled = true;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Humedad_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Reporte_Detallado RP = new Reporte_Detallado();
            RP.ShowDialog();
        }
    }
}
