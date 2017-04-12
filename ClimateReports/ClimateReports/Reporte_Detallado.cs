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
    public partial class Reporte_Detallado : Form
    {


        /// <summary>
        /// conn = declaracion de variable para obtener conexion a la base de datos 
        /// </summary>
        MySqlConnection conn = ConexionBD.ObtenerConexion();
      
        void llenargrafica()
        {
           
            string query_grafica = "select * from humedad,presion,temperatura,viento;";

            MySqlCommand cmd_query_grafica = new MySqlCommand(query_grafica, conn);
            MySqlDataReader leergrafica;
            try
            {
                conn.Open();

                leergrafica = cmd_query_grafica.ExecuteReader();
                chart1.Series["Humedad"].Points.Clear();
                chart1.Series["Temperatura"].Points.Clear();
                chart1.Series["Presión"].Points.Clear();
                chart1.Series["Viento"].Points.Clear();
                while (leergrafica.Read())
                {
                    
                   
                    this.chart1.Series["Humedad"].Points.AddXY(leergrafica.GetString("hum_nombre_sensor"), leergrafica.GetFloat("hum_dato"));
                    this.chart1.Series["Temperatura"].Points.AddXY(leergrafica.GetString("temp_nombre_sensor"), leergrafica.GetFloat("temp_dato"));
                    this.chart1.Series["Presión"].Points.AddXY(leergrafica.GetString("pre_nombre_sensor"), leergrafica.GetFloat("pre_dato"));
                    this.chart1.Series["Viento"].Points.AddXY(leergrafica.GetString("vie_nombre_sensor"), leergrafica.GetFloat("vie_dato"));
                }



            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();

            
        }

        public Reporte_Detallado()
        {
            InitializeComponent();
            llenargrafica();
        }

        private void tempraturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Temperatura T = new Temperatura();
            T.Show();
            
        }

        private void Reporte_Detallado_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void vientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Viento v = new Viento();
            v.Show();
        }

        private void humedadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Humedad H = new Humedad();
            H.Show();
        }

        private void presionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presion P = new Presion();
            P.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtviento_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reporte_Detallado_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            llenargrafica();
        }
    }
}
