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

        /// <summary>
        /// conn = declaracion de variable para obtener conexion a la base de datos 
        /// </summary>
        MySqlConnection conn = ConexionBD.ObtenerConexion();



        public Reporte_General()
        {
            InitializeComponent();
        }

        private void Reporte_General_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {

        }
    }
}
