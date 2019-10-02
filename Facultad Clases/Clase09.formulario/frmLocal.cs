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
    public partial class frmLocal : frmLlamada
    {
        Local l;
        Local miLocal { get { return l; } }
        public frmLocal():base()
        {
            InitializeComponent();
        }

        protected override void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtOrigen.Text != "" && txtDestino.Text != "" && txtDuracion.Text != "" && txtCosto.Text != "")
            {
                try
                {
                    float d, c;
                    d = float.Parse(txtDuracion.Text);
                    c = float.Parse(txtCosto.Text);
                    l = new Local(txtOrigen.Text, d, txtDestino.Text, c);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    throw;
                }
            }
        }

        protected override void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
