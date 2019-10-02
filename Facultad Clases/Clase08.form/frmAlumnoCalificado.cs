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
    public partial class frmAlumnoCalificado : frmAlumno
    {
        private AlumnoCalificado al;
        public AlumnoCalificado mialumno { get { return al; } }
        public frmAlumnoCalificado()
        {
            InitializeComponent();
            
        }

        public frmAlumnoCalificado(Alumno alumno) : this()
        {
            txtNombre.Text = alumno.Nombre;
            txtApellido.Text = alumno.Apellido;
            txtLegajo.Text = alumno.Legajo.ToString();
            txtLegajo.Enabled = false;
            txtApellido.Enabled = false;
            cboxExamen.Enabled = false;
            txtNombre.Enabled = false;
            cboxExamen.Text = alumno.Examen.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtNota.Text) >= 0 || int.Parse(txtNota.Text) <= 10)
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
                    al = new AlumnoCalificado(txtNombre.Text, txtApellido.Text, int.Parse(txtLegajo.Text), examen, int.Parse(txtNota.Text));
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Nota invalida");
            }
        }
    }
}
