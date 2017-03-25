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
    }
}
