using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ClimateReports
{
    public partial class Form2 : Form
    {
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



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();


            
        }



        public Form2()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
          

            Reporte_Detallado RP = new Reporte_Detallado();
            RP.Show();

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void mesaDeAyudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        //metodo para cuando se cierre la ventana
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {

            ///cierra aplicacion por completo
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reporte_General RG = new Reporte_General();
            RG.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            llenargrafica();
        }
    }
}
