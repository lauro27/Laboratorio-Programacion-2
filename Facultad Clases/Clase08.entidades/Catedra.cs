using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase08.entidades
{
    public class Catedra
    {
        private List<Alumno> alumnos;

        public List<Alumno> Alumnos{ get { return alumnos; } }

        public Catedra()
        {
            this.alumnos = new List<Alumno>();
        }

        public static bool operator ==(Catedra c, Alumno a)
        {
            foreach (Alumno alist in c.Alumnos)
            {
                if (alist == a)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Catedra c, Alumno a)
        {
            return !(c==a);
        }
        public static bool operator -(Catedra c, Alumno a)
        {
            foreach (Alumno alist in c.Alumnos)
            {
                if (alist == a)
                {
                    c.alumnos.Remove(a);
                    return true;
                }
            }
            return false;
        }
        public static int operator |(Alumno a, Catedra c)
        {
            int i = 0;
            foreach (Alumno alist in c.Alumnos)
            {
                if (alist == a)
                {
                    return i;
                }
                i++;
            }
            return -1;
        }
        public static bool operator +(Catedra c, Alumno a)
        {
            foreach (Alumno alist in c.Alumnos)
            {
                if (alist == a)
                {
                    return false;
                }
            }
            c.alumnos.Add(a);
            return true;
        }

        public override string ToString()
        {
            string r = "";
            foreach (Alumno a in this.alumnos)
            {
                r += a.ToString() + "\n";
            }
            return r;
        }

    }
}
