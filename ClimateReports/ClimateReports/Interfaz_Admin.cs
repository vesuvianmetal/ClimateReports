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
    public partial class Interfaz_Admin : Form
    {
        //se le asigna clase de conexion a la variable conn para asi tener conexion a la base de datos
        MySqlConnection conn = ConexionBD.ObtenerConexion();

        //metodo para limpiar los campos
        void limpiarcampos()
        {
            
            txtam.Clear();
            txtap.Clear();
            txtconfcon.Clear();
            txtcontraseña.Clear();
            //txtdelcontra.Clear();
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


        void encriptar()
        {
            try
            {
                double exp = 2.0;
                Int64 pal1 = int.Parse(txtcontraseña.Text);
                Int64 val1 = pal1 * 2;
                Int64 val2 = (int)Math.Pow(val1, exp);
                Int64 val3 = val2 / 4;
                Int64 val4 = val3 * 8;
                Int64 val5 = val4 - 12345;

                var hexa = val5.ToString("X");
                txtcontraseña.Text = hexa.ToString();
                txtconfcon.Text = hexa.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        void desencriptar()
        {
            Int64 numero1 = Int64.Parse(txtcontraseña.Text, System.Globalization.NumberStyles.HexNumber);
            Int64 numero2 = numero1 + 12345;
            Int64 numero3 = numero2 / 8;
            Int64 numero4 = numero3 * 4;
            Int64 numero5 = (int)Math.Sqrt(numero4);
            Int64 numero6 = numero5 / 2;
            txtcontraseña.Text = numero6.ToString();
        }
        void condesen()
        {
            string vara = "";
            string contra = "select usu_pass from usuario where usu_id = '" + txtdelid.Text + "'";
            MySqlCommand cmd_query = new MySqlCommand(contra, conn);
            MySqlDataReader leerx;
            try
            {
                conn.Open();
                leerx = cmd_query.ExecuteReader();

                if (leerx.Read())
                {
                    vara = leerx[0].ToString();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            conn.Close();

            double exp2 = 2.0;
            Int64 numero1 = Int64.Parse(txtconfcon.Text);
            Int64 val1 = numero1 * 2;
            Int64 val2 = (int)Math.Pow(val1, exp2);
            Int64 val3 = val2 / 4;
            Int64 val4 = val3 * 8;
            Int64 val5 = val4 - 12345;
            var hexa = val5.ToString("X");
            txtconfcon.Text = hexa.ToString();
        }

        //metodo para agregar un usuario
        void agregarusuario()
        {
            encriptar();
            string query_agregar = "insert into usuario (usu_usuario,usu_nombre,usu_apellido_p,usu_apellido_m,usu_telefono,usu_email,usu_tipo_usu,usu_pass) values ( '" + txtusuario.Text + "' , '" + txtnombre.Text + "' , '" + txtap.Text + "' , '" + txtam.Text + "' , '" + txttelefono.Text + "' , '" + txtemail.Text + "' , '" + combousuario.SelectedItem + "' , '" + txtcontraseña.Text + "')";
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
                else if (combousuario.SelectedItem == null)
                {
                    MessageBox.Show("Debe Seleccion Un Tipo De Usuario");
                }

                else if (txtcontraseña.Text.Contains(" "))
                {
                    MessageBox.Show("No Se Aceptan Espacion En El Campo De Contraseña");
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

            //cierra conexion a base de datos
            conn.Close();

            //llama el metodo para borrar campos
            // limpiarcampos();

        }

        //metodo para borrar usuario
        void borrarusuario()
        {
            condesen();

            //query para buscar el usuario que se desea eliminar
            string buscarconfirmacion = "select  * from usuario where usu_id='" + txtdelid.Text + "' and usu_pass = '" + txtconfcon.Text + "'";
            MySqlCommand cmd_buscarconfirmacion = new MySqlCommand(buscarconfirmacion, conn);
            MySqlDataReader leerconfirmacion;


            //query para eliminar el usuario
            string query_borrar = "delete from usuario where usu_id = '" + txtdelid.Text + "'";
            MySqlCommand cmd_query_borrar = new MySqlCommand(query_borrar, conn);
            MySqlDataReader leerqueryborrar;
            try
            {
                if (txtconfcon.Text.Equals(""))
                {
                    MessageBox.Show("Debe Confirmar La Contraseña Del Usuario A Eliminar");
                }
                else
                {


                    //abre la conexion a la base de datos
                    conn.Open();

                    //ejecuta el el comando que busca la confirmacion de la contraseña del usuario
                    leerconfirmacion = cmd_buscarconfirmacion.ExecuteReader();

                    //si la confirmacion de la contraseña es correcta entonces procede
                    if (leerconfirmacion.Read())
                    {
                        //cierra conexion a del comando de confimacion
                        leerconfirmacion.Close();

                        //ejecuta el comando para borrar el usuario
                        leerqueryborrar = cmd_query_borrar.ExecuteReader();

                        //una vez eliminado el usuario muestra el siguiente mensaje
                        MessageBox.Show("Usuario Eliminado Correctamente");

                    }

                    else if (leerconfirmacion.Read() == false)
                    {
                        MessageBox.Show("Confirmacion De Contraseña Es Incorrecta");
                    }

                }

                //atrapa cualquier error y los muestra como ventanas con el  error
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //cierra la conexion a la base de datos
            conn.Close();

            //manda a llamar el metodo para llamar la tabla
            filltabla();

        }



        void filltabla()
            {
                // Se abre la conexion
                conn.Open();


                String querytablausuario = "select distinct usu_id as ID , usu_usuario as Usuario, usu_nombre as Nombre,usu_apellido_p as ApellidoPaterno, usu_apellido_m as ApellidoMaterno, usu_telefono as Telefono, usu_email as Correo, Usu_tipo_usu as TipoUsuario, usu_pass as Password from usuario";
            // select usu_id as ID , usu_usuario as Usuario, usu_nombre as Nombre,usu_apellido_p as Apellido Paterno, usu_apellido_m as Apellido Materno, usu_telefono as Telefono, usu_email as Correo, Usu_tipo_usu as Tipo Usuario, usu_pass as Contraseña

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

            //llena la tabla desde que se inicia la ventana
            filltabla();
        }

        //accion que se va a realizar al presionar el boton de agregar usuario
        private void btnagregar_Click(object sender, EventArgs e)
        {
            //manda a llamar el metodo de agregar usuario
            agregarusuario();

            //manda a llamar el metodo para borrar campos
            limpiarcampos();

            //manda a llamar el metodo para llenar la tabla
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
                //txtdelcontra.Text = row.Cells[8].Value.ToString();
               
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {

            //manda a llamar el metodo de limpiar campos
            limpiarcampos();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

            //manda a llamar el metodo para borrar un usuario
            borrarusuario();

            //manda a llamar el metodo para llenar la tabla
            filltabla();

            //manda a llama el metodo para borrar los campos
            limpiarcampos();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 cerrarsession = new Form1();
            cerrarsession.Show();
            this.Hide();
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtdelcontra_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Interfaz_Admin_Load(object sender, EventArgs e)
        {

        }

        private void Interfaz_Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2_admin f2a = new Form2_admin();
            f2a.Show();
            this.Dispose();
        }

        private void combousuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}
