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
    public partial class Presion : Form
    {

        /// <summary>
        /// conn = declaracion de variable para obtener conexion a la base de datos 
        /// </summary>
        /// 
        MySqlConnection conn = ConexionBD.ObtenerConexion();

        //metodo para llenar grafica
        void llenargrafica()
        {


            
            //consulta que se desea realizar a la base de datos
            string query_grafica = "select pre_dato,pre_nombre_sensor from presion";

            //se declara el comando que se hara a la base de datos junto con la consulta y la variable de conxion
            MySqlCommand cmd_query_grafica = new MySqlCommand(query_grafica, conn);

            //se declara variable que mas adeltante servira para ejecutar el comando
            MySqlDataReader leergrafica;
            try
            {

                //abre la conexion a la base de datos
                conn.Open();

                //se le agina valor de ejecucion del comando a la variable leergrafica 
                leergrafica = cmd_query_grafica.ExecuteReader();

                //antes de graficar se le borran todos los puntos ya que cuando se actualiza se tiene que regrafica por completo
                chart1.Series["Presion"].Points.Clear();

                //si la lectura ala base de datos es correcta se procede a graficar
                while (leergrafica.Read())
                {


                    //se le asigna los valores y nombres a X y Y de la grafica
                    this.chart1.Series["Presion"].Points.AddXY(leergrafica.GetString("pre_nombre_sensor"), leergrafica.GetFloat("pre_dato"));

                }



            }

            //atrapa cualquier error
            catch (Exception ex)
            {
                //muestra los errores atrapados en una ventana
                MessageBox.Show(ex.Message);
            }

           //cierra la conexion a la base de datos
            conn.Close();
        }

        public Presion()
        {
            InitializeComponent();
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            //cuando el timer hace tick(en este caso es de 10 segundos) se actualizara la grafica 
            llenargrafica();
        }

        private void Presion_Load(object sender, EventArgs e)
        {

            //se activa el timer
            llenar_grafica.Enabled = true;
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {

        }

        private void Presion_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Reporte_Detallado RP = new Reporte_Detallado();
            RP.Show();
        }

        private void llenar_presion_Tick(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string Query = "select MAX(pre_DATO) from presion;";
                MySqlCommand MyCommand2 = new MySqlCommand(Query, conn);
                respuesta_pre.Text = MyCommand2.ExecuteScalar().ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void reporteDetalladoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Reporte_Detallado rp = new Reporte_Detallado();
            rp.Show();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
