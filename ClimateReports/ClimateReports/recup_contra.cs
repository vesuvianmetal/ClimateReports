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
        private Attachment Data;

        public recup_contra()
        {
            InitializeComponent();
            ConexionBD.ObtenerConexion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          try
            {
                //Revisa si es diferente de vacio, de serlo hace lo que tiene dentro
                //el if.
                if (!(textBox1.Text.Trim() == ""))
                {
                    To = textBox1.Text;
                    //Subject = textBox3.Text;
                    Body = textBox2.Text;

                    mail = new MailMessage();
                    mail.To.Add(new MailAddress(this.To));
                    mail.From = new MailAddress("SoftwareDevelopers13@gmail.com");
                    //mail.Subject = Subject;
                    mail.Body = Body;
                    mail.IsBodyHtml = false;

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
                MessageBox.Show("Algo salio mal");
            }
        }
    }
}
