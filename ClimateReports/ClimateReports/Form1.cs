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
    public partial class Form1 : Form
    {
        /// <summary>
        /// conn = declaracion de variable para obtener conexion a la base de datos 
        /// </summary>
        //MySqlConnection conn = ConexionBD.ObtenerConexion();

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
           
            ///validacion de campos
            ///valida si uno o ambos campos del login estan vacios.
            if (txtusuario.Text.Equals("") || txtcontra.Text.Equals(""))
            {
                ///muestra ventana con error si se presenta la validacion.
                MessageBox.Show("Usuario O Contraseña Invalida, Porfavor Intente Denuevo");
            }

            ///si los campos no presentan error de que esten vacios se procede a correr este codigo
            else
            {
                ///con.open() sirve para abrir la conexion a la base de datos.
               // conn.Open();
            
                ///string query inicio es una declaracion de el query(CONSULTA) que se va a realizar a la base de datos.
            string query_inicio = "select * from usuario where USU_Usuario = '" + txtusuario.Text + "' AND USU_PASS ='" + txtcontra.Text + "'";

                ///mysql command exe_query sirve como preparacion del query(CONSULTA) junto con la variable de conexion
                ///para asi poder convertirlo en un comando a realizar.
               // MySqlCommand exe_query_inicio = new MySqlCommand(query_inicio, conn);

                ///string cap es la declaracion de variable que servira para capturar un valor dentro
                ///de la base de datos.
                string cap;


                
          //  MySqlDataReader leer_exe;

            try
            {
                    ///de establece la orden de ejecucion de query (CONSULTAS)
                leer_exe = exe_query_inicio.ExecuteReader();


                    ///validacion
                    ///validacion de usuario existente
                /*if (leer_exe.Read())
                {

                    MessageBox.Show("CONECTADO");

                        ///se le indica a la variable cap que valor de la columna va a obtener, el (8) significa el numero
                        ///de columna que va a obtener
                    //cap = leer_exe.GetString("USU_TIPO_USU");

                        ///si existe el usuario, verifica con la variable cap que tipo de usuario es
                        ///y dependiendo el usuario, le muestra la ventana a la que tiene permisos de acceder
                    if (cap.Equals("Admin"))
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

                /// si el usuario no existe o la contraseña es erronea entonces muestra mensaje de error
                else if (leer_exe.Read() == false)
                {
                        ///mensaje de error que se mostrara
                    MessageBox.Show("Inicio Fallido, Usuario Y Contraseña O La Conexion");

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
             }*/

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }
    }
}
    
    

