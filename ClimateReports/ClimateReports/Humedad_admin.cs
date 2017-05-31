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
    public partial class Humedad_admin : Form
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

        public Humedad_admin()
        {
            InitializeComponent();
        }

        private void llenar_grafica_Tick(object sender, EventArgs e)
        {
            //cada que el timer haga un tick (en este caso es de 10 segundos) se realizara la funcion de llenar grafica
            llenargrafica();
        }

        private void Humedad_admin_Load(object sender, EventArgs e)
        {
            //activa el timer
            llenar_grafica.Enabled = true;
        }

        private void Humedad_admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Reporte_Detallado_admin RP = new Reporte_Detallado_admin();
            RPa.Show();
        }

        private void llenar_humedad_Tick(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string Query = "select hum_dato from humedad where hum_id=(select Max(hum_id) from humedad);";
                MySqlCommand MyCommand2 = new MySqlCommand(Query, conn);
                hume_abs.Text = MyCommand2.ExecuteScalar().ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void calcular_relativa_Tick(object sender, EventArgs e)
        {
            string hmax, hfin, hrela;
            float hum_max, hum_fin, hum_rela;

            conn.Open();
            string Query = "select MAX(hum_dato) from humedad;";
            MySqlCommand MyCommand2 = new MySqlCommand(Query, conn);
            hmax = MyCommand2.ExecuteScalar().ToString();
            conn.Close();

            hfin = hume_abs.Text.ToString();
            hum_max = float.Parse(hmax);
            hum_fin = float.Parse(hfin);
            hum_rela = (hum_fin / hum_max);
            hrela = hum_rela.ToString();
            hume_rel.Text = hrela;
        }

        private void reporteDetalladoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Reporte_Detallado_admin rpdta = new Reporte_Detallado_admin();
            rpdta.Show();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form2_admin f2a = new Form2_admin();
            f2a.Show();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
    }
}
