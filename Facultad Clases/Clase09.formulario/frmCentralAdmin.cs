using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaPolimorfismo;

namespace Clase09.formulario
{
    public partial class frmCentralAdmin : Form
    {
        public frmCentralAdmin()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void centralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCentral frmCentral = new frmCentral();
            frmCentral.Show();
        }
    }
}
