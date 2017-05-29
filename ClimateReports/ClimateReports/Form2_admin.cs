using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//importa las librerias de mysql
using MySql.Data.MySqlClient;

namespace ClimateReports
{
    public partial class Form2_admin : Form
    {

        //se le asigna a la variable conn la conexion a la base de datos
        MySqlConnection conn = ConexionBD.ObtenerConexion();


        //metodo para llenar la grafica con datos d ela base de datos
        void llenargrafica()
        {


            //se hace la consulta a las tablas dentro de la base de datos
            string query_grafica = "select distinct hum_nombre_sensor,hum_dato,temp_nombre_sensor,temp_dato,pre_nombre_sensor,pre_dato,vie_nombre_sensor,vie_dato from viento,presion,temperatura,humedad where hum_id=pre_id and temp_id=vie_id and hum_id=temp_id and pre_id=vie_id ;";

            // se declara el comando que se le hara a mysql con la consulta que se hizo anteriormente
            MySqlCommand cmd_query_grafica = new MySqlCommand(query_grafica, conn);

            // se declara una variable que mas adenate servira para ejecutar el comando a mysql
            MySqlDataReader leergrafica;

            try
            {
                //conn.open() abre la conexion a la base de datos
                conn.Open();

                // se le asigna valor a leergrafica 
                leergrafica = cmd_query_grafica.ExecuteReader();

                ///antes de graficar se le borran los puntos a la grafica ya que cuando se actualiza se vuelve a realizar la misma operacion
                ///de graficacion
                chart1.Series["Humedad"].Points.Clear();
                chart1.Series["Temperatura"].Points.Clear();
                chart1.Series["Presión"].Points.Clear();
                chart1.Series["Viento"].Points.Clear();

                //si la lectura de los datos de la bd es correcta entonces comenzara a graficar
                while (leergrafica.Read())
                {

                    //con estos valores se les asigna los datos a cada una de las lineas de dispercion desde la base de datos segun sus valores
                    //y las tablas
                    this.chart1.Series["Humedad"].Points.AddXY(leergrafica.GetString("hum_nombre_sensor"), leergrafica.GetFloat("hum_dato"));
                    this.chart1.Series["Temperatura"].Points.AddXY(leergrafica.GetString("temp_nombre_sensor"), leergrafica.GetFloat("temp_dato"));
                    this.chart1.Series["Presión"].Points.AddXY(leergrafica.GetString("pre_nombre_sensor"), leergrafica.GetFloat("pre_dato"));
                    this.chart1.Series["Viento"].Points.AddXY(leergrafica.GetString("vie_nombre_sensor"), leergrafica.GetFloat("vie_dato"));
                }



            }

            //atrapa cualquier error 
            catch (Exception ex)
            {
                //cuando se atrapan los errores los muestra en una ventana
                MessageBox.Show(ex.Message);
            }

            //cierra la conexion a la base de datos
            conn.Close();



        }
        public Form2_admin()
        {
            InitializeComponent();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //cierra la ventana
            this.Dispose();

            //abre el login
            Form1 F1 = new Form1();
            F1.Show();
        }

        private void reportarUnProblemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com");
        }

        private void button5_Click(object sender, EventArgs e)
        {

            //cuando se presione el boton abrira la ventana que se selecciono
            Reporte_Detallado RP = new Reporte_Detallado();
            this.Visible = false;
            RP.Visible = true;
            // RP.Show();
            //this.Dispose();



            //RP.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //cuando se presione el boton abrira la ventana que se selecciono
            Reporte_General RG = new Reporte_General();
            RG.Show();
            this.Dispose();
        }

        private void Form2_admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Form1 Login = new Form1();
            Login.Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ///cada vez que el timer haga un tick (en este caso es de 10 segundos) va a realizar la funcion de llenar la grafica 
            llenargrafica();
        }

        private void Form2_admin_Load(object sender, EventArgs e)
        {

            //activa el timer que tiene un intervalo de 10 segundos
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Interfaz_Admin IA = new Interfaz_Admin();
            IA.Show();
            this.Hide();
        }
    }
}
