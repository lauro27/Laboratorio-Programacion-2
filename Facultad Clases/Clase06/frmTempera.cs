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
    public partial class frmTempera : Form
    {
        private entidades.Tempera mitempera;

        public entidades.Tempera mitemperita
        {
            get
            {
                return this.mitempera;
            }
        }
        public frmTempera()
        {
            InitializeComponent();
            foreach (ConsoleColor c in Enum.GetValues(typeof(ConsoleColor)))
            {
                this.cboxColor.Items.Add(c);
            }
            this.cboxColor.SelectedItem = ConsoleColor.Magenta;
            this.cboxColor.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public frmTempera(entidades.Tempera tempera1)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            this.txtMarca.Text = tempera1.GetMarca;
            this.txtCantidad.Text = tempera1.GetCantidad.ToString();
            this.cboxColor.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
            {
                cboxColor.Items.Add(color);
            }
            this.cboxColor.Text = tempera1.GetColor.ToString();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Tempera t = new entidades.Tempera((ConsoleColor)Enum.Parse(typeof(ConsoleColor), cboxColor.Text), txtMarca.Text, int.Parse(txtCantidad.Text));
            MessageBox.Show(t);
            this.DialogResult = DialogResult.OK;
        }
    }
}
