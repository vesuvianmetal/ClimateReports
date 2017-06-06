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
    public partial class Reporte_General_admin : Form
    {

        /// <summary>
        /// conn = declaracion de variable para obtener conexion a la base de datos 
        /// </summary>
        MySqlConnection conn = ConexionBD.ObtenerConexion();
        private void filltabla()
        {
            conn.Open();
            // Se abre la conexion



            String querytablageneral = " select distinct humedad.hum_dato  as Humedad,presion.pre_dato as Presion,temperatura.temp_dato as Temperatura,viento.vie_dato as Viento, viento.vie_tiempo as Fecha from humedad,presion,temperatura,viento;";

            // Se crea un DataTable que almacenará los datos desde donde se cargaran los datos al DataGridView
            DataTable dtDatos = new DataTable();

            // Se crea un MySqlAdapter para obtener los datos de la base
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter(querytablageneral, conn);

            // Con la información del adaptador se rellena el DataTable
            mdaDatos.Fill(dtDatos);

            // Se asigna el DataTable como origen de datos del DataGridView
            dataGridView1.DataSource = dtDatos;

            // Se cierra la conexión a la base de datos
            conn.Close();
        }



        public Reporte_General_admin()
        {
            InitializeComponent();
            //manda a llamar el metodo para llenar tabla desde en inicio
            filltabla();
        }

        private void Reporte_General_admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Form2_admin f2admin = new Form2_admin();
            f2admin.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //obtiene la coleccion que contiene todas las filas
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

            ///asigna los valores de los registros a los textbox.
            txthumedad.Text = row.Cells[0].Value.ToString();
            txtpresion.Text = row.Cells[1].Value.ToString();
            txttemp.Text = row.Cells[2].Value.ToString();
            txtviento.Text = row.Cells[3].Value.ToString();
        }

        private void obtener_humedad_Tick(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string Query = "select hum_dato from humedad where hum_id=(select Max(hum_id) from humedad) ;";
                MySqlCommand MyCommand1 = new MySqlCommand(Query, conn);
                txthumedad.Text = MyCommand1.ExecuteScalar().ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void obtener_presion_Tick(object sender, EventArgs e)
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

        private void obtener_temp_Tick(object sender, EventArgs e)
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

        private void obtener_viento_Tick(object sender, EventArgs e)
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

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();

            //abre el login
            Form2_admin Form2admin = new Form2_admin();
            Form2admin.Show();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:/Users/Paul/Documents/Climate/index.html");
        }

        private void climateReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:/Users/Paul/Documents/Climate/contacto.html");
        }
    }
}
