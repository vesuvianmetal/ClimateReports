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


        void limpiarcampos()
        {
            txtam.Clear();
            txtap.Clear();
            txtconfcon.Clear();
            txtcontraseña.Clear();
            txtdelcontra.Clear();
            txtdelemail.Clear();
            txtdelid.Clear();
            txtdelmat.Clear();
            txtdelnombre.Clear();
            txtdelpat.Clear();
            txtdeltelefono.Clear();
            txtdelusuario.Clear();
            txtemail.Clear();
            txtnombre.Clear();
            txttelefono.Clear();
            txtusuario.Clear();
        }
        void agregarusuario()
        {
            string query_agregar = "insert into usuario (usu_usuario,usu_nombre,usu_apellido_p,usu_apellido_m,usu_telefono,usu_email,usu_tipo_usu,usu_pass) values ( '" + txtusuario.Text + "' , '" + txtnombre.Text + "' , '" + txtap.Text + "' , '" + txtam.Text + "' , '"+txttelefono.Text+"' , '"+txtemail.Text+"' , '" +combousuario.SelectedItem+"' , SHA1('"+txtcontraseña.Text+"') )";
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
                    MessageBox.Show("Usuario Agregado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            limpiarcampos();

        }   






     /*void helper_borrar()
        {
           
           

            try
            {

               


            } catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }
        }
        */


        void borrarusuario()
        {
            string buscarconfirmacion = "select  * from usuario where usu_id='" + txtdelid.Text + "' and usu_pass = SHA1('"+txtconfcon.Text+"')";
            MySqlCommand cmd_buscarconfirmacion = new MySqlCommand(buscarconfirmacion,conn);
            MySqlDataReader leerconfirmacion;



            string query_borrar = "delete from usuario where usu_id = '" + txtdelid.Text + "'";
            MySqlCommand cmd_query_borrar = new MySqlCommand(query_borrar,conn);
            MySqlDataReader leerqueryborrar;
            try
            {
                conn.Open();

                leerconfirmacion = cmd_buscarconfirmacion.ExecuteReader();
               

                if (leerconfirmacion.Read())
                {
                    leerconfirmacion.Close();
                    leerqueryborrar = cmd_query_borrar.ExecuteReader();
                    

                    

                }
                



            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
            conn.Close();
            filltabla();
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
            limpiarcampos();
            filltabla();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                txtdelid.Text = row.Cells[0].Value.ToString();
                txtdelusuario.Text = row.Cells[1].Value.ToString();
                txtdelnombre.Text = row.Cells[2].Value.ToString();
                txtdelpat.Text = row.Cells[3].Value.ToString();
                txtdelmat.Text = row.Cells[4].Value.ToString();
               txtdeltelefono.Text = row.Cells[5].Value.ToString();
                txtdelemail.Text = row.Cells[6].Value.ToString();
                txtdelcontra.Text = row.Cells[8].Value.ToString();
               
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            limpiarcampos();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            borrarusuario();


            limpiarcampos();
        }
    }
}
