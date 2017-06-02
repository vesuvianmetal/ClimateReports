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
    public partial class Viento : Form
    {


        /// <summary>
        /// conn = declaracion de variable para obtener conexion a la base de datos 
        /// </summary>
        MySqlConnection conn = ConexionBD.ObtenerConexion();

        //metodo para llenar la grafica
        void llenargrafica()
        {

            //consulta que se hara a mysql
            string query_grafica = "select * from viento";

            //delcaracion de comando a mysql junto con la consulta y la variable de conexion
            MySqlCommand cmd_query_grafica = new MySqlCommand(query_grafica, conn);

            //declaracion de variable que mas adelante servira para ejecutar el comando a mysql
            MySqlDataReader leergrafica;
            try
            {
                //abre la conexion a la base de datos
                conn.Open();

                //se le asigna valor de ejecucion de comando a la variable leergrafica
                leergrafica = cmd_query_grafica.ExecuteReader();

                /// antes de graficar se le borran todos los puntos ya que al actualizar de tiene que 
                /// regraficar todo 
                chartvientos.Series["Viento"].Points.Clear();


                ///si la lectura de la base de datos es correcta se procede a graficar
                while (leergrafica.Read())
                {


                    //se le asignan los valores y nombre desde la base de datos y los grafica
                    this.chartvientos.Series["Viento"].Points.AddXY(leergrafica.GetString("vie_nombre_sensor"), leergrafica.GetFloat("vie_dato"));

                }



            }

            //atrapa cualquier error
            catch (Exception ex)
            {

                //muestra los errores atrapados y los muestra en una ventana
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        public Viento()
        {
            InitializeComponent();
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {

        }

        private void Viento_Load(object sender, EventArgs e)
        {
            //activa el timer
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ///cada que el timer haga tick (en este caso es cada 10 segundos) se grafica denuevo
            llenargrafica();
        }

        private void Viento_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Reporte_Detallado RP = new Reporte_Detallado();
            RP.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnenviar_Click(object sender, EventArgs e)
        {

        }

        private void btnimprimir_Click_1(object sender, EventArgs e)
        {

        }
    }
}
