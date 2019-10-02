using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase04.entidades;

namespace Clase04.formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            ClaseCosa c1 = new ClaseCosa();
            int iparse = -1;
            DateTime fparse = DateTime.MinValue;
            try
            {
                sslStatus.ForeColor = Color.Black;
                iparse = int.Parse(txtEntero.Text);
                fparse = DateTime.Parse(txtFecha.Text);
                if (txtCadena.Text != "" && txtEntero.Text != "" && txtFecha.Text != "")
                { c1 = new ClaseCosa(iparse, txtCadena.Text, fparse); }
                lstCosas.Items.Add(c1.Mostrar());
                sslStatus.Text = "Agregado: " + c1.Mostrar();
            }
            catch
            {
                sslStatus.ForeColor = Color.Red;
                sslStatus.Text = "Error: Datos no validos";
            }
            
        }

        private void btnRojo_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void btnNegro_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void btnAzul_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }
    }
}
