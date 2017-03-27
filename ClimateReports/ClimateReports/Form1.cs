using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ClimateReports
{
    public partial class Form1 : Form
    {
        SqlConnection conn = ConexionBD.ObtenerConexion();

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
           

            if (txtusuario.Text.Equals("") || txtcontra.Text.Equals(""))
            {
                MessageBox.Show("Usuario O Contraseña Invalidad, Porfavor Intente Denuevo");
            }
            else
            {
                conn.Open();

                string query_inicio = "select * from usuarios where USU_Usuario = '" + txtusuario.Text + "' AND USU_Contra ='" + txtcontra.Text + "'";
            SqlCommand exe_query_inicio = new SqlCommand(query_inicio, conn);
            string cap;
            SqlDataReader leer_exe;

            try
            {
                leer_exe = exe_query_inicio.ExecuteReader();

                if (leer_exe.Read())
                {

                    MessageBox.Show("CONECTADO");
                    cap = leer_exe.GetString(6);
                    if (cap.Equals("Administrador"))
                    {
                        Reporte_Detallado RD = new Reporte_Detallado();
                        RD.Show();
                        this.Hide();
                    }
                    else if (cap.Equals("General"))
                    {
                        Reporte_General RG = new Reporte_General();
                        RG.Show();
                        this.Hide();
                    }
                }
                else if (leer_exe.Read() == false)
                {

                    MessageBox.Show("Inicio Fallido, Usuario Y Contraseña O La Conexion");

                }





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }
             }


    }
}
    
    

