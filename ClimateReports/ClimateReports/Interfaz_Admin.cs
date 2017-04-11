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
    public partial class Interfaz_Admin : Form
    {
        MySqlConnection conn = ConexionBD.ObtenerConexion();

        void agregarusuario()
        {
            string query_agregar = "insert into usuario (usu_usuario,usu_nombre,usu_apellido_p,usu_apellido_m,usu_telefono,usu_email,usu_tipo_usu,usu_pass) values ( '" + txtusuario.Text + "','" + txtnombre.Text + "','" + txtap.Text + "','" + txtam.Text + "','"+txttelefono.Text+"','"+txtemail.Text+"','"+combousuario.SelectedItem+"','"+txtcontraseña.Text+"');";
            MySqlCommand cmd_queryagregar = new MySqlCommand(query_agregar, conn);
            MySqlDataReader leer;
            try
            {
                conn.Open();
                if (txtnombre.Text.Equals("") || txtusuario.Text.Equals("") || txtap.Text.Equals("") || txtam.Text.Equals("") || txtcontraseña.Text.Equals("")
                     || txtemail.Text.Equals("") || txttelefono.Text.Equals(""))
                {
                    MessageBox.Show("Alguno De Los Campos Esta Vacio");
                }
                else if (combousuario.SelectedItem.Equals("Escoga Tipo De Usuario"))
                {
                    MessageBox.Show("Debe Seleccion Un Tipo De Usuario");
                }
                else
                {
                    leer = cmd_queryagregar.ExecuteReader();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();

        }   
    


       
            void filltabla()
            {
                // Se abre la conexion
                conn.Open();


                String querytablausuario = "select * from usuario";

                // Se crea un DataTable que almacenará los datos desde donde se cargaran los datos al DataGridView
                DataTable dtDatos = new DataTable();

                // Se crea un MySqlAdapter para obtener los datos de la base
                MySqlDataAdapter mdaDatos = new MySqlDataAdapter(querytablausuario, conn);

                // Con la información del adaptador se rellena el DataTable
                mdaDatos.Fill(dtDatos);

                // Se asigna el DataTable como origen de datos del DataGridView
                dataGridView1.DataSource = dtDatos;

                // Se cierra la conexión a la base de datos
                conn.Close();
            }
        



        public Interfaz_Admin()
        {
            InitializeComponent();
            filltabla();
        }

        //accion que se va a realizar al presionar el boton de agregar usuario
        private void btnagregar_Click(object sender, EventArgs e)
        {
            //manda a llamar el metodo de agregar usuario
            agregarusuario();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
