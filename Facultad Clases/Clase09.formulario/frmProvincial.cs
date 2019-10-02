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
    public partial class frmProvincial : frmLlamada
    {
        protected Provincial p;
        public Provincial miprovincial { get { return p; } }
        public frmProvincial()
        {
            InitializeComponent();
            
        }

        private void frmProvincial_Load(object sender, EventArgs e)
        {
            foreach (Franja f in Enum.GetValues(typeof(Franja)))
            {
                cboxFranja.Items.Add(f);
            }
            cboxFranja.SelectedIndex = 0;
        }

        protected override void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtOrigen.Text != "" && txtDestino.Text != "" && txtDuracion.Text != "" && cboxFranja.Text != "")
            {
                try
                {
                    float d;
                    d = float.Parse(txtDuracion.Text);

                    Franja f = (Franja)cboxFranja.SelectedItem;
                    
                    p = new Provincial(txtOrigen.Text, txtDestino.Text, d, f);
                    switch (f)
                    {
                        case Franja.Franja_1:
                            break;
                        case Franja.Franja_2:
                            break;
                        case Franja.Franja_3:
                            break;
                        default:
                            break;
                    }
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
