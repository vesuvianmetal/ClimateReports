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
    public partial class Reporte_Detallado : Form
    {
        public Reporte_Detallado()
        {
            InitializeComponent();
        }

        private void tempraturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Temperatura T = new Temperatura();
            T.Show();
            
        }

        private void Reporte_Detallado_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void vientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Viento v = new Viento();
            v.Show();
        }

        private void humedadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Humedad H = new Humedad();
            H.Show();
        }

        private void presionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presion P = new Presion();
            P.Show();
        }
    }
}
