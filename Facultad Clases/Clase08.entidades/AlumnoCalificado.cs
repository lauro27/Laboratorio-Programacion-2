using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase08.entidades
{
    public class AlumnoCalificado:Alumno
    {
        protected double nota;

        public double Nota { get { return nota; } }

        public AlumnoCalificado(Alumno a, double nota): base(a.Apellido, a.Nombre,a.Legajo,a.Examen)
        {
            this.nota = nota;
        }

        public AlumnoCalificado(string no, string ap, int le, ETipoExamen ex, double nota) : base(ap, no, le, ex)
        {
            this.nota = nota;
        }

        public string Mostrar()
        {
            return base.Mostrar(new Alumno(apellido,nombre,legajo,examen)) + " Nota: " + nota;
        }

        public override string ToString()
        {
            return Mostrar();
        }
    }
}
