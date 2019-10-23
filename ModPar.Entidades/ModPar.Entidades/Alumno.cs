using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModPar.Entidades
{
    public class Alumno
    {
        private string _apellido;
        private int _legajo;
        private string _nombre;
        private float _nota;

        public string Apellido { get { return _apellido; } set { _apellido = value; } }
        public int Legajo { get { return _legajo; } set { _legajo = value; } }
        public string Nombre { get { return _nombre; } set { _nombre= value; } }
        public float Nota { get { return _nota; } set { _nota = value; } }

        public Alumno(int legajo, string nombre, string apellido)
        {
            Legajo = legajo;
            Nombre = nombre;
            Apellido = apellido;
        }

        private string Mostrar()
        {
            return this.Apellido + ", " + this.Nombre + " - Legajo: " + this.Legajo + " - Nota: " + this.Nota;
        }

        public static string Mostrar(Alumno a)
        {
            return a.Mostrar();
        }

        public static bool operator ==(Alumno a1, Alumno a2) { return (a1.Legajo == a2.Legajo); }
        public static bool operator !=(Alumno a1, Alumno a2) { return !(a1 == a2); }
    }
}
