using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase08.entidades
{
    public class Alumno
    {
        protected string apellido;
        protected string nombre;
        protected int legajo;
        protected ETipoExamen examen;

        public string Apellido { get { return apellido; } }
        public string Nombre { get { return nombre; } }
        public int Legajo { get { return legajo; } }
        public ETipoExamen Examen { get { return examen; } }

        public Alumno(string ape, string no, int le, ETipoExamen ex)
        {
            this.apellido = ape;
            this.nombre = no;
            this.legajo = le;
            this.examen = ex;
        }

        public string Mostrar(Alumno a)
        {
            return a.apellido + " " + a.nombre + " " + a.legajo;
        }

        public static bool operator ==(Alumno a1, Alumno a2)
        {
            return (a1.legajo == a2.legajo);
        }

        public static bool operator !=(Alumno a1, Alumno a2)
        {
            return !(a1 == a2);
        }

        public static int OrdenarPorLegajoAsc(Alumno a1, Alumno a2)
        {
            if (a1.legajo < a2.legajo)
            {
                return 1;
            }
            else if (a1.legajo == a2.legajo)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        public static int OrdenarPorLegajoDesc(Alumno a1, Alumno a2)
        {
            return -1 * OrdenarPorLegajoAsc(a1, a2);
        }

        public static int OrdenarPorApellidoAsc(Alumno a1, Alumno a2)
        {
            if (String.Compare(a1.apellido,a2.apellido)< 0)
            {
                return 1;
            }
            else if (String.Compare(a1.apellido, a2.apellido) == 0)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        public static int OrdenarPorApellidoDesc(Alumno a1, Alumno a2)
        {
            return OrdenarPorApellidoAsc(a1, a2) * -1;
        }

        public override string ToString()
        {
            string r = this.apellido + " " + this.nombre + " - " + this.legajo + " - " + this.examen.ToString();
            return r;
        }
    }
}
