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
      

        //metodo para llenar la grafica
        void llenargrafica()
        {
         
            //consulta que se quiere hacer la base de datos  
            string query_grafica = "select distinct hum_nombre_sensor,hum_dato,temp_nombre_sensor,temp_dato,pre_nombre_sensor,pre_dato,vie_nombre_sensor,vie_dato from viento,presion,temperatura,humedad where hum_id=pre_id and temp_id=vie_id and hum_id=temp_id and pre_id=vie_id ;";


            //declaracion del comando que se le hara a mysql junto con la consulta y la variable de conexion
            MySqlCommand cmd_query_grafica = new MySqlCommand(query_grafica, conn);

            //declaracion de varaible que servira para ejecutar el comando a realizar a mysql
            MySqlDataReader leergrafica;

            try
            {
                //abre la conexion a la base de datos
                conn.Open();

                //se le asigna valor de ejecucion a la variable leergrafica
                leergrafica = cmd_query_grafica.ExecuteReader();

                ///antes de graficar se le borran todos los puntos a la grafica ya que al actualizar la grafica se tiene que re grafica todo de neuvo
                chart1.Series["Humedad"].Points.Clear();
                chart1.Series["Temperatura"].Points.Clear();
                chart1.Series["Presión"].Points.Clear();
                chart1.Series["Viento"].Points.Clear();

                //si la lectura de los datos es correcta de procede a graficar
                while (leergrafica.Read())
                {
                    ///se le declaran los valores que serviran para X y Y dentro de la grafica junto con los datos dentro de la base
                    ///de datos
                   
                    this.chart1.Series["Humedad"].Points.AddXY(leergrafica.GetString("hum_nombre_sensor"), leergrafica.GetFloat("hum_dato"));
                    this.chart1.Series["Temperatura"].Points.AddXY(leergrafica.GetString("temp_nombre_sensor"), leergrafica.GetFloat("temp_dato"));
                    this.chart1.Series["Presión"].Points.AddXY(leergrafica.GetString("pre_nombre_sensor"), leergrafica.GetFloat("pre_dato"));
                    this.chart1.Series["Viento"].Points.AddXY(leergrafica.GetString("vie_nombre_sensor"), leergrafica.GetFloat("vie_dato"));
                }



            }
            //atrapa cualquier error
            catch (Exception ex)
            {
                //muestra los errores atrapados y los muestra en una ventana
                MessageBox.Show(ex.Message);
            }

            //cierra la conexion a la base de datos
            conn.Close();

            
        }

        public Reporte_Detallado()
        {
            InitializeComponent();
           
        }

        //funcion que pasara cuando se presione el menustrip con el nombre de temperatura
        private void tempraturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //muestra la ventana de temperatura
            Temperatura T = new Temperatura();
            T.Show();
            
        }

        private void Reporte_Detallado_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();

            Form2 F2 = new Form2();
            F2.Show();
        }

        //funcion que pasara cuando se presione el menustrip con el nombre de viento

        private void vientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //muestra la ventana de viento
            Viento v = new Viento();
            v.Show();
        }

        //funcion que pasara cuando se presione el menustrip con el nombre de humedad

        private void humedadToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //muestra la ventana de humedad
            Humedad H = new Humedad();
            H.Show();
        }


        //funcion que pasara cuando se presione el menustrip con el nombre de presion

        private void presionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //muestra la ventana de presion
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

            //activa el timer
            llenar_grafica.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           //manda a llamar el metodo de graficar cada 10 segundos
            llenargrafica();
        }

        
        
        private void button1_Click(object sender, EventArgs e)
        {
            //abre la ventana de temperatura
            this.Dispose();
            Temperatura IT = new Temperatura();
            IT.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            //abre la ventana de viento
            Viento VIE = new Viento();
            VIE.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
            //abre la ventana de presion
            Presion PRE = new Presion();
            PRE.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
            //abre la ventana de humedad
            Humedad IH = new Humedad();
            IH.Show();
        }

        private void llenar_humedad_Tick(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string Query = "select hum_dato from humedad where hum_id=(select Max(hum_id) from humedad) ;";
                MySqlCommand MyCommand1 = new MySqlCommand(Query, conn);
                txtporhumedad.Text = MyCommand1.ExecuteScalar().ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void llenar_temp_Tick(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string Query = "select temp_dato from temperatura where temp_id=(select Max(temp_id) from temperatura) ; ";
                MySqlCommand MyCommand3 = new MySqlCommand(Query, conn);
                txttemp.Text = MyCommand3.ExecuteScalar().ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void llenar_presion_Tick(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string Query = "select pre_dato from presion where pre_id=(select Max(pre_id) from presion) ;";
                MySqlCommand MyCommand2 = new MySqlCommand(Query, conn);
                txtpresion.Text = MyCommand2.ExecuteScalar().ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void llenar_viento_Tick(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string Query = "select vie_dato from viento where vie_id=(select Max(vie_id) from viento) ;";
                MySqlCommand MyCommand4 = new MySqlCommand(Query, conn);
                txtviento.Text = MyCommand4.ExecuteScalar().ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 cerrarsesion = new Form1();
            cerrarsesion.Show();
            this.Dispose();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();

            //abre el login
            Form2 F2 = new Form2();
            F2.Show();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro Que Desea Cerrar Sesion?", "Cerrar Sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.Yes))
            {

                this.Dispose();
                Form1 cerrarsesion = new Form1();
                cerrarsesion.Show();

            }
            else
            {
            }





            
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txttemp_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reportarUnProblemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:/Users/Paul/Documents/Climate/index.html");
        }

        private void soporteTecnicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:/Users/Paul/Documents/Climate/manual_tecnico.html");
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void climateReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:/Users/Paul/Documents/Climate/contacto.html");
        }
    }
}
