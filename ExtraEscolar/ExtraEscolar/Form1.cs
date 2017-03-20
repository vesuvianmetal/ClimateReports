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

namespace ExtraEscolar
{
    public partial class Extraescolares : Form
    {
        MySqlConnection conn = ConexionBD.Obtener_Conexion(); 
        public Extraescolares()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Text files | *.csv";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName;
                fileName = dlg.FileName;
                txtruta.Text = fileName;
            }
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            conn.Open();

            string path = txtruta.Text;
            int Numero_Control = 0;
            string Apellido_Paterno = "";
            string Apellido_Materno = "";
            string Carrera = "";
            string ExtraEscolar = "";
            string Estado = "";
            string nombre = "";
            try
            {




                MySqlCommand query_insertar_csv = new MySqlCommand("INSERT INTO alumnos(Numero_Control,Nombre,Apellido_Paterno,Apellido_Materno,Carrera,ExtraEscolar,Estado)VALUES(@a,@b,@c,@d,@e,@f,@g)", conn);
                query_insertar_csv.Parameters.AddWithValue("a", Numero_Control);
                query_insertar_csv.Parameters.AddWithValue("b", nombre);
                query_insertar_csv.Parameters.AddWithValue("c", Apellido_Paterno);
                query_insertar_csv.Parameters.AddWithValue("d", Apellido_Materno);
                query_insertar_csv.Parameters.AddWithValue("e", Carrera);
                query_insertar_csv.Parameters.AddWithValue("f", ExtraEscolar);
                query_insertar_csv.Parameters.AddWithValue("g", Estado);

                query_insertar_csv.ExecuteNonQuery();
                conn.Close();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                }
            }
           
        }
    
