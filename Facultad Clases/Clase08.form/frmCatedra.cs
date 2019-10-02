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
    public partial class frmCatedra : Form
    {
        private Catedra cat = new Catedra();
        List<AlumnoCalificado> alucal = new List<AlumnoCalificado>();

        public frmCatedra()
        {
            InitializeComponent();
            
        }

        private void frmCatedra_Load(object sender, EventArgs e)
        {
            foreach (ETipoOrdenamiento eTipo in Enum.GetValues(typeof(ETipoOrdenamiento)))
            {
                cboxOrden.Items.Add(eTipo);
            }
            cboxOrden.SelectedIndex = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAlumno alumno = new frmAlumno();
            alumno.ShowDialog();
            if (alumno.DialogResult == DialogResult.OK)
            {
                cat.Alumnos.Add(alumno.mialumno);
                listUpdater();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (lboxAlumno.SelectedItem != null)
            {
                frmAlumno alumno = new frmAlumno(cat.Alumnos[lboxAlumno.SelectedIndex]);
                alumno.ShowDialog();
                if (alumno.DialogResult == DialogResult.OK)
                {
                    cat.Alumnos[lboxAlumno.SelectedIndex] = alumno.mialumno;
                    listUpdater();
                }

            }
        }



        public void listUpdater()
        {
            this.lboxAlumno.Items.Clear();
            foreach (Alumno auxiliar in cat.Alumnos)
            {
                this.lboxAlumno.Items.Add(auxiliar);
            }
            this.lboxCalificado.Items.Clear();
            foreach (Alumno auxiliar in alucal)
            {
                this.lboxCalificado.Items.Add(auxiliar);
            }
        }

        private void cboxOrden_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboxOrden.Text)
            {
                case "LegajoAscendiente":
                    cat.Alumnos.Sort(Alumno.OrdenarPorLegajoAsc);
                    break;
                case "LegajoDescendiente":
                    cat.Alumnos.Sort(Alumno.OrdenarPorLegajoDesc);
                    break;
                case "ApellidoAscendiente":
                    cat.Alumnos.Sort(Alumno.OrdenarPorApellidoAsc);
                    break;
                case "ApellidoDescendiente":
                    cat.Alumnos.Sort(Alumno.OrdenarPorApellidoDesc);
                    break;
                default:
                    break;
            }
            listUpdater();

        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {
            if (lboxAlumno.SelectedItem != null)
            {
                frmAlumnoCalificado alumno = new frmAlumnoCalificado(cat.Alumnos[lboxAlumno.SelectedIndex]);
                alumno.ShowDialog();
                if (alumno.DialogResult == DialogResult.OK)
                {
                    alucal.Add(alumno.mialumno);
                    cat.Alumnos.RemoveAt(lboxAlumno.SelectedIndex);
                    listUpdater();
                }

            }
        }
    }
}
