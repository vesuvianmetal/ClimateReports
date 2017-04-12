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


        void llenargrafica()
        {


            string query_grafica = "select * from viento";

            MySqlCommand cmd_query_grafica = new MySqlCommand(query_grafica, conn);
            MySqlDataReader leergrafica;
            try
            {
                conn.Open();

                leergrafica = cmd_query_grafica.ExecuteReader();

                chartvientos.Series["Viento"].Points.Clear();

                while (leergrafica.Read())
                {



                    this.chartvientos.Series["Viento"].Points.AddXY(leergrafica.GetString("vie_nombre_sensor"), leergrafica.GetFloat("vie_dato"));

                }



            }
            catch (Exception ex)
            {
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
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            llenargrafica();
        }
    }
}
