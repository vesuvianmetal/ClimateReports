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
    public partial class Reporte_General : Form
    {

        void filltabla()
        {
            // Se abre la conexion
            conn.Open();


            String querytablageneral = "select * from viento";

            // Se crea un DataTable que almacenará los datos desde donde se cargaran los datos al DataGridView
            DataTable dtDatos = new DataTable();

            // Se crea un MySqlAdapter para obtener los datos de la base
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter(querytablageneral,conn);

            // Con la información del adaptador se rellena el DataTable
            mdaDatos.Fill(dtDatos);

            // Se asigna el DataTable como origen de datos del DataGridView
            dataGridView1.DataSource = dtDatos;

            // Se cierra la conexión a la base de datos
            conn.Close();
        }

        /// <summary>
        /// conn = declaracion de variable para obtener conexion a la base de datos 
        /// </summary>
        MySqlConnection conn = ConexionBD.ObtenerConexion();



        public Reporte_General()
        {
            InitializeComponent();
            filltabla();
        }

        private void Reporte_General_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
