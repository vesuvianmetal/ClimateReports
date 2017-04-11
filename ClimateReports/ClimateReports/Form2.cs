using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClimateReports
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
          

            Reporte_Detallado RP = new Reporte_Detallado();
            RP.Show();

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void mesaDeAyudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        //metodo para cuando se cierre la ventana
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {

            ///cierra aplicacion por completo
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reporte_General RG = new Reporte_General();
            RG.Show();
        }
    }
}
