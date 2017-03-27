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
    public partial class Reporte_General : Form
    {
        public Reporte_General()
        {
            InitializeComponent();
        }

        private void Reporte_General_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
