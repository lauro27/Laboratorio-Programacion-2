using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase08.entidades;
namespace Clase08.form
{
    public partial class frmAlumno : Form
    {
        private Alumno al;
        public Alumno mialumno { get { return al; } }
        public frmAlumno()
        {
            InitializeComponent();
            foreach (ETipoExamen et in Enum.GetValues(typeof(ETipoExamen)))
            {
                cboxExamen.Items.Add(et);
            }
            cboxExamen.SelectedIndex = 0;
        }

        public frmAlumno(Alumno alumno):this()
        {
            txtNombre.Text = alumno.Nombre;
            txtApellido.Text = alumno.Apellido;
            txtLegajo.Text = alumno.Legajo.ToString();
            txtLegajo.Enabled = false;
            cboxExamen.Text = alumno.Examen.ToString();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                ETipoExamen examen = ETipoExamen.Final;
                switch (cboxExamen.Text)
                {
                    case "Primero":
                        examen = ETipoExamen.Primero;
                        break;
                    case "Segundo":
                        examen = ETipoExamen.Segundo;
                        break;
                    case "Final":
                        examen = ETipoExamen.Final;
                        break;
                    default:
                        MessageBox.Show(cboxExamen.Text);
                        break;
                }
                al = new Alumno(txtNombre.Text, txtApellido.Text, int.Parse(txtLegajo.Text), examen);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
