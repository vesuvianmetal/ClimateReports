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

    

    public partial class Temperatura : Form
    {
        
        /// <summary>
        /// conn = declaracion de variable para obtener conexion a la base de datos 
        /// </summary>
        MySqlConnection conn = ConexionBD.ObtenerConexion();


        //metodo para llenar la grafica
        void llenargrafica()
        {

            //consulta que se le hara a la base de datos
            string query_grafica = "select * from temperatura";

            //declaracion de comando que se hara a mysql junto con consulta y la variable de conexion
            MySqlCommand cmd_query_grafica = new MySqlCommand(query_grafica, conn);

            //declaracion de variable que servira para ejecutar comando a mysql mas adelante
            MySqlDataReader leergrafica;
            try
            {

                //abre conexion a la base de datos
                conn.Open();


                ///se le asigna valor de ejecucion de comando a la variable leergrafica
                leergrafica = cmd_query_grafica.ExecuteReader();
                
                //se le borran los puntos a la grafica antes de graficar porque cuando se actualize
                //se tiene que regraficar por completo
                chart1.Series["Temperatura"].Points.Clear();
                

                //si la lectura de los datos es correcta se procede a graficar
                while (leergrafica.Read())
                {

                    //se le declaran el nombre y los valores que estan dentro de la base de datos para
                    //ser graficados
                   
                    this.chart1.Series["Temperatura"].Points.AddXY(leergrafica.GetString("temp_nombre_sensor"), leergrafica.GetFloat("temp_dato"));
                  
                }



            }

            //atrapa cualquie error
            catch (Exception ex)
            {
                //muestra los errores atrapados en una ventana
                MessageBox.Show(ex.Message);
            }

            //cierra la conexion a la base de datos
            conn.Close();

        }
        public Temperatura()
        {
            InitializeComponent();
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {

        }

        private void Temperatura_Load(object sender, EventArgs e)
        {

            //activa el timer
            timer1.Enabled = true;
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {

        }

        private void txtter_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ///cada que el timer haga tick (en este caso cada 10 segundos) se grafica denuevo
            llenargrafica();
        }
    }
}
