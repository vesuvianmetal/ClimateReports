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


        void llenargrafica()
        {
            string query_grafica = "select * from humedad";

            MySqlCommand cmd_query_grafica = new MySqlCommand(query_grafica, conn);
            MySqlDataReader leergrafica;
            try
            {
                conn.Open();

                leergrafica = cmd_query_grafica.ExecuteReader();

                chart1.Series["Humedad"].Points.Clear();

                while (leergrafica.Read())
                {



                    this.chart1.Series["Humedad"].Points.AddXY(leergrafica.GetString("hum_nombre_sensor"), leergrafica.GetFloat("hum_dato"));

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            llenargrafica();
        }

        private void Humedad_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
