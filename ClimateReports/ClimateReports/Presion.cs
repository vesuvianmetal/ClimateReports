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
    public partial class Presion : Form
    {

        /// <summary>
        /// conn = declaracion de variable para obtener conexion a la base de datos 
        /// </summary>
        MySqlConnection conn = ConexionBD.ObtenerConexion();



        public Presion()
        {
            InitializeComponent();
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ///con.open() sirve para abrir la conexion a la base de datos.
            conn.Open();

            ///string query inicio es una declaracion de el query(CONSULTA) que se va a realizar a la base de datos.
            string query_inicio = "select pre_presion from usuario where USU_Usuario = '" + txtusuario.Text + "' AND USU_PASS ='" + txtcontra.Text + "'";

            ///mysql command exe_query sirve como preparacion del query(CONSULTA) junto con la variable de conexion
            ///para asi poder convertirlo en un comando a realizar.
            MySqlCommand exe_query_inicio = new MySqlCommand(query_inicio, conn);
        }
    }
}
