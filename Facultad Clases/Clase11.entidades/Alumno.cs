using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase11.entidades
{
    class Alumno : Persona
    {
        public double nota;

        public Alumno(string n, string a, int e, double nota) : base(n, a, e)
        {
            this.nota = nota;
        }

        public override string ToString()
        {
            return base.ToString() + " " + this.nota;
        }
    }
}
