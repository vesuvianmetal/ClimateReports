﻿using System;
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
    public partial class Temperatura_admin : Form
    {

        /// <summary>
        /// conn = declaracion de variable para obtener conexion a la base de datos 
        /// </summary>
        MySqlConnection conn = ConexionBD.ObtenerConexion();


        //metodo para llenar la grafica
        void llenargrafica()
        {

            //consulta que se le hara a la base de datos
            string query_grafica = "select temp_dato,temp_nombre_sensor from temperatura";

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



        public Temperatura_admin()
        {
            InitializeComponent();
        }

        private void llenar_tmin_Tick(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string Query = "select MIN(TEMP_DATO) from temperatura;";
                MySqlCommand MyCommand2 = new MySqlCommand(Query, conn);
                respuestatmin.Text = MyCommand2.ExecuteScalar().ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Temperatura_admin_Load(object sender, EventArgs e)
        {

            //activa el timer
            llenar_grafica.Enabled = true;
        }

        private void llenar_grafica_Tick(object sender, EventArgs e)
        {
            ///cada que el timer haga tick (en este caso cada 10 segundos) se grafica denuevo
            llenargrafica();
        }

        private void llenar_tmax_Tick(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string Query = "select MAX(TEMP_DATO) from temperatura;";
                MySqlCommand MyCommand2 = new MySqlCommand(Query, conn);
                respuestatmax.Text = MyCommand2.ExecuteScalar().ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void calcular_tmedia_Tick(object sender, EventArgs e)
        {
            string tmax, tmin, tmedia;
            float tempmax, tempmin, tempmedia;

            tmax = respuestatmax.Text.ToString();
            tmin = respuestatmin.Text.ToString();
            tempmax = float.Parse(tmax);
            tempmin = float.Parse(tmin);
            tempmedia = (tempmax + tempmin) / 2;
            tmedia = tempmedia.ToString();
            respuestatmedia.Text = tmedia;
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro Que Desea Cerrar Sesion?", "Cerrar Sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.Yes))
            {

                Form1 cerrarsession = new Form1();
                cerrarsession.Show();
                this.Dispose();

            }
            else
            {
            }






         
        }

        private void reporteDetalladoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Reporte_Detallado_admin rpdetalladoadmin = new Reporte_Detallado_admin();
            rpdetalladoadmin.Show();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form2_admin for2a = new Form2_admin();
            for2a.Show();
        }

        private void Temperatura_admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2_admin f2a = new Form2_admin();
            f2a.Show();
            this.Dispose();
        }

        private void reportarUnProblemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:/Users/Paul/Documents/Climate/index.html");
        }

        private void soporteTecnicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:/Users/Paul/Documents/Climate/manual_tecnico.html");
        }

        private void climateReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:/Users/Paul/Documents/Climate/contacto.html");
        }
    }
}
