using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase11.entidades
{
    class Empleado : Persona
    {
        public int legajo;
        public double sueldo;

        public Empleado(string n, string a, int e, int l, double s) : base(n, a, e)
        {
            this.legajo = l;
            this.sueldo = s;
        }

        public override string ToString()
        {
            return this.legajo + " " + base.ToString() + " " + this.sueldo;
        }
    }
}
