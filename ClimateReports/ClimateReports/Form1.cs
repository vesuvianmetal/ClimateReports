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
//hola

namespace ClimateReports
{
    public partial class Form1 : Form
    {

        void iniciar_sesion()
        {
            ///validacion de campos
            ///valida si uno o ambos campos del login estan vacios.
            if (txtusuario.Text.Equals("") || txtcontra.Text.Equals(""))
            {
                ///muestra ventana con error si se presenta la validacion.
                MessageBox.Show("Usuario O Contraseña Invalida, Porfavor Intente Denuevo");
            }
            else if (txtcontra.Text.TrimEnd().Contains(" ") || txtusuario.Text.TrimEnd().Contains(" "))
            {


                MessageBox.Show("Los Campos No Aceptan Espacios");
            }
            ///si los campos no presentan error de que esten vacios se procede a correr este codigo
            else
            {
                ///con.open() sirve para abrir la conexion a la base de datos.
                conn.Open();



                ///string query inicio es una declaracion de el query(CONSULTA) que se va a realizar a la base de datos.
                string query_inicio = "select * from usuario where USU_NOMBRE = '" + txtusuario.Text + "' AND USU_PASS = SHA1('" + txtcontra.Text + "')";


                ///mysql command exe_query sirve como preparacion del query(CONSULTA) junto con la variable de conexion
                ///para asi poder convertirlo en un comando a realizar.
                MySqlCommand exe_query_inicio = new MySqlCommand(query_inicio, conn);
               
               

                ///string cap es la declaracion de variable que servira para capturar un valor dentro
                ///de la base de datos.
                string cap;
                //string prueba;

             //   prueba = comboBox1.SelectedItem.ToString();


                MySqlDataReader leer_exe;

                try
                {
                    ///de establece la orden de ejecucion de query (CONSULTAS)
                    leer_exe = exe_query_inicio.ExecuteReader();


                    ///validacion
                    ///validacion de usuario existente
                    if (leer_exe.Read())
                    {

                        MessageBox.Show("CONECTADO");

                        ///se le indica a la variable cap que valor de la columna va a obtener, el (8) significa el numero
                        ///de columna que va a obtener
                        cap = leer_exe.GetString("USU_Tipo_Usu");

                        ///si existe el usuario, verifica con la variable cap que tipo de usuario es
                        ///y dependiendo el usuario, le muestra la ventana a la que tiene permisos de acceder
                        if (cap.Equals("Administrador"))
                        {
                            Form2_admin menu = new Form2_admin();
                            menu.Show();

                           // Interfaz_Admin IA = new Interfaz_Admin();
                            //IA.Show();
                            this.Hide();
                        }
                        else if (cap.Equals("General"))
                        {
                            Form2 menu = new Form2();
                            menu.Show();
                            this.Hide();
                        }
                    }

                    /// si el usuario no existe o la contraseña es erronea entonces muestra mensaje de error
                    else if (leer_exe.Read() == false)
                    {
                        ///mensaje de error que se mostrara
                        MessageBox.Show("Inicio Fallido, Usuario y/o Contraseña Incorrecta, Otro Motivo Puede Ser La Conexion");

                    }





                }

                ///si hay algun error del codigo, muestra un error con su causante.
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                ///conn.close() sirve para cerrar la conexion a la base de datos
                conn.Close();
            }
        }

        /// <summary>
        /// conn = declaracion de variable para obtener conexion a la base de datos 
        /// </summary>
        MySqlConnection conn = ConexionBD.ObtenerConexion();

        public Form1()
        {
            ///metodo que inicia todos los componentes dentro del frame.
            InitializeComponent();
        }


        private void btncancelar_Click(object sender, EventArgs e)
        {
            ///this.dispose sirve para realizar la accion de cerrar frame al presionar el boton cancelar.
            this.Dispose();
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {


        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            ///manda a llamar metodo para iniciar sesion
            try
            {
                iniciar_sesion();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
        /// <summary>
        /// accion que se realizara si se presiona la tecla enter en el campo de contraseña
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtcontra_KeyDown(object sender, KeyEventArgs e)
        {

            ///si la tecla enter es presionada entonces se realizara la siguiente accion
            if (e.KeyCode == Keys.Enter)
            {
                ///manda a llamar el metodo de iniciar sesion
                iniciar_sesion();
            }



            /*  else if (e.KeyCode == Keys.Space)
              {
                  e.Handled = false;

              }
              base.OnKeyDown(e);
      */
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            recup_contra RP = new recup_contra();
            RP.Visible = true;

        }
        //evento que sucedera cuando se presione el link label de ayuda
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/");
        }

        private void txtcontra_Leave(object sender, EventArgs e)
        {
            if (this.Text.Contains(" "))
            {
                MessageBox.Show("En Este Campo No Se Aceptan Espacios");
                this.Focus();
            }
        }
    


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
           
         

            


        }
    }
}



