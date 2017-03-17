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
    public partial class Form1 : Form
    {
        MySqlConnection conn = ConexionBD.ObtenerConexion();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            string query_inicio = "select * from usuarios where Usuario='"+txtusuario.Text+"' and Contrasena='"+txtcontra.Text+"'";
               }
    }
}
