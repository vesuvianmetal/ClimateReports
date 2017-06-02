using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net.Mime;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace ClimateReports
{
    public partial class recup_contra : Form
    {
        MySqlConnection conn = ConexionBD.ObtenerConexion();
        //Estas variables seran las que guarden los datos que 
        //seran enviados en el mensaje.
        private string To;
        //private string Subject;
        private string Body;

        private MailMessage mail;
        // private Attachment Data;

        string vara = "";
        void encriptar()
        {
            try
            {
                double exp = 2.0;
                Int64 numero1 = Int64.Parse(vara, System.Globalization.NumberStyles.HexNumber);
                Int64 numero2 = numero1 + 12345;
                Int64 numero3 = numero2 / 8;
                Int64 numero4 = numero3 * 4;
                Int64 numero5 = (int)Math.Sqrt(numero4);
                Int64 numero6 = numero5 / 2;
                vara = numero6.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public recup_contra()
        {
            InitializeComponent();
            ConexionBD.ObtenerConexion();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {



            string  usu = usuario.Text;
           string email = correo.Text;
            string contra;
           

          try
            {


          //  MySqlCommand exe_query_inicio = new MySqlCommand(query_inicio, conn);
            //    string query_inicio = "Select USU_Usuario, USU_ ";



                //Revisa si es diferente de vacio, de serlo hace lo que tiene dentro
                //el if.
                if (!(correo.Text.Trim() == ""))
                {
                    
                    string query_inicio = "select USU_PASS from usuario where USU_nombre = '"+ usu + "' and USU_EMAIL= '"+email+"'";
                    MySqlCommand exe_query_inicio = new MySqlCommand(query_inicio, conn);
                    MySqlDataReader leer;

                    try
                    {
                        conn.Open();
                        leer = exe_query_inicio.ExecuteReader();

                        if(leer.Read())
                        {
                            vara = leer[0].ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                    encriptar();
                    To = correo.Text;
                    mail = new MailMessage();
                    mail.To.Add(new MailAddress(this.To));
                    mail.From = new MailAddress("SoftwareDevelopers13@gmail.com");
                    mail.Subject = "RECUPERACION DE CONTRASEÑA";
                    mail.Body = " " + usu + " Usted ha solicitado una recuperacion de contraseña: " +vara.ToString();
                    mail.IsBodyHtml = false;

                    conn.Close();
                    /*if (!(archivoAdjTxt.Text.Trim() == ""))
                    {
                        Data = new Attachment(archivoAdjTxt.Text, MediaTypeNames.Application.Octet);
                        mail.Attachments.Add(Data);
                    }*/

                    SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                    using (client)
                    {
                        client.Credentials = new System.Net.NetworkCredential("SoftwareDevelopers13@gmail.com", "Climate13");
                        client.EnableSsl = true;
                        client.Send(mail);
                    }
                    MessageBox.Show("Mensaje enviado");
                }
            }
            catch
            {
                MessageBox.Show("Mensaje no enviado Revise su conexion a internet");
            }



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void recup_contra_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
