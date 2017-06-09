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
    public partial class Form2 : Form
    {

        //se le asigna a la variable conn la conexion a la base de datos
        MySqlConnection conn = ConexionBD.ObtenerConexion();


       



        public Form2()
        {
            InitializeComponent();
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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void mesaDeAyudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            //activa el timer que tiene un intervalo de 10 segundos
            timer1.Enabled = true;
        }

        //metodo para cuando se cierre la ventana
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Form1 Login = new Form1();
            Login.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //cuando se presione el boton abrira la ventana que se selecciono
            Reporte_General RG = new Reporte_General();
            RG.Show();
            this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }


        //funciona que se realizara al presionar el boton de cerrar session en el menustrip
        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro Que Desea Cerrar Sesion?", "Cerrar Sesion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result.Equals(DialogResult.Yes))
            {
                
                //cierra la ventana
                this.Dispose();

                //abre el login
                Form1 F1 = new Form1();
                F1.Show();
            }
            else
            {
            }
            
        }

        //cuando se presione reportar un problema en el menustrip, se abrira el navegaor predeterminado con la pagina asiganada en el URL
        private void reportarUnProblemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:/Users/Paul/Documents/Climate/index.html");
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void proporcionarUnaSugerenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void soporteTecnicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:/Users/Paul/Documents/Climate/manual_tecnico.html");
        }

        private void climateReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:/Users/Paul/Documents/Climate/contacto.html");
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
