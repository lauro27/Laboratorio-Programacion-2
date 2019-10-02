using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase06.entidades;

namespace Clase06
{
    public partial class Form1 : Form
    {
        Paleta miPaleta;
        public Form1()
        {
            InitializeComponent();
        }

        private void temperaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string s;
            frmTempera tempera = new frmTempera();
            tempera.MdiParent = this;
            //gboxPaleta.Show();
            tempera.ShowDialog();
            if (tempera.DialogResult == DialogResult.OK)
            {
                this.miPaleta += tempera.mitemperita;
            }
            //crearPaletaToolStripMenuItem.Enabled = false;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            Tempera AuxTempera = null;
            string s;

            if (this.lboxTempera.SelectedIndex >= 0)
            {
                AuxTempera = this.miPaleta[this.lboxTempera.SelectedIndex];
            }

            if (AuxTempera != null)
            {
                frmTempera NewForm = new frmTempera();
                NewForm.ShowDialog();

                if (NewForm.DialogResult == DialogResult.OK)
                {
                    if (NewForm.mitemperita.GetCantidad > 0)
                    {
                        this.lboxTempera.Items.Clear();
                        this.miPaleta -= AuxTempera;

                        //if (this.MiPaleta == NewForm.MiTemperita)
                        // {

                        this.miPaleta += NewForm.mitemperita;
                        //  }
                        // else
                        //  {
                        //  this.MiPaleta += NewForm.MiTemperita;
                        // }

                        for (int i = 0; i < 5; i++)
                        {
                            if (this.miPaleta[i] != null)
                            {

                                this.lboxTempera.Items.Add((string)this.miPaleta[i]);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error. Cantidad menor a 0");
                    }
                }

            }
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            frmTempera NewForm = new frmTempera();
            NewForm.ShowDialog();

            if (NewForm.DialogResult == DialogResult.OK)
            {
                this.miPaleta += NewForm.mitemperita;

                this.lboxTempera.Items.Clear();

                for (int i = 0; i < 5; i++)
                {
                    if (this.miPaleta[i] != null)
                    {
                        this.lboxTempera.Items.Add((string)this.miPaleta[i]);
                    }
                }
            }
        }

        private void paletaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            this.miPaleta = 5;
            gboxPaleta.Visible = true;
            this.paletaToolStripMenuItem.Enabled = false;
        }
    }
}
