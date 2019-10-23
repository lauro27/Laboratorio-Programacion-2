using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModPar.Entidades
{
    public class Materia
    {
        private List<Alumno> _alumnos;
        private EMateria _nombre;
        private static Random _notaParaUnAlumno;

        public List<Alumno> Alumnos { get { return _alumnos; } set { _alumnos = value; } }
        public EMateria Nombre { get { return _nombre; } set { _nombre = value; } }

        public void CalificarAlumnos()
        {
            foreach (Alumno a in this.Alumnos)
            {
                a.Nota = _notaParaUnAlumno.Next(10);
            }
        }

        public static explicit operator string(Materia materia)
        {
            return materia.Mostrar();
        }

        public static implicit operator float(Materia materia)
        {
            float r = 0;
            foreach (Alumno alumno in materia.Alumnos)
            {
                r += alumno.Nota;
            }
            return (r / materia.Alumnos.Count);
        }

        public static implicit operator Materia(EMateria materia)
        {
            return new Materia(materia);
        }

        private Materia() { Alumnos = new List<Alumno>(); }

        static Materia() { _notaParaUnAlumno = new Random(); }

        private Materia(EMateria nombre):this() { this.Nombre = nombre; }

        private string Mostrar()
        {
            StringBuilder r = new StringBuilder();
            r.AppendLine("Materia: "+ this.Nombre.ToString());
            r.AppendLine("*******************************************");
            r.AppendLine("*****************ALUMNOS*******************");
            foreach (Alumno alumno in this.Alumnos)
            {
                r.AppendLine(Alumno.Mostrar(alumno));
            }
            return r.ToString();
        }

        #region operadores
        public static bool operator ==(Materia m, Alumno a)
        {
            foreach (Alumno al in m.Alumnos)
            {
                if (a == al) { return true; }
            }
            return false;
        }

        public static bool operator !=(Materia m, Alumno a)
        {
            return !(m == a);
        }

        public static Materia operator +(Materia m, Alumno a)
        {
            foreach (Alumno alumno in m.Alumnos)
            {
                if ((alumno == a))
                {
                    Console.WriteLine("Alumno ya existente");
                    return m;
                }
            }
            Console.WriteLine("Alumno agregado");
            m.Alumnos.Add(a);
            return m;
        }

        public static Materia operator -(Materia m, Alumno a)
        {
            foreach (Alumno al in m.Alumnos)
            {
                if (a == al)
                {
                    m.Alumnos.Remove(a);
                    Console.WriteLine("Alumno eliminado");
                    return m;
                }
            }
            Console.WriteLine("Alumno no encontrado");
            return m;
        }
        #endregion
    }
}