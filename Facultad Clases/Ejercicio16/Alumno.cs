using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Alumno
    {
        byte nota1, nota2;
        float notaFinal;
        string apellido;
        int legajo;
        string nombre;

        public Alumno(string s1, string s2, int i)
        {
            this.nombre = s1;
            this.apellido = s2;
            this.legajo = i;
        }

        public void CalcularFinal()
        {
            if (this.nota1 >= 4 && this.nota2 >= 4)
            {
                Random r = new Random();
                notaFinal = r.Next(10);
            }
            else { notaFinal = -1; }
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }

        public string Mostrar()
        {
            string r;
            r = this.nombre + " " + this.apellido + " - " + this.legajo + " - Nota 1: " + this.nota1 + " Nota 2: " + this.nota2;
            if (notaFinal != -1)
            {
                r += " - Nota Final: " + notaFinal;
            }
            return r;
        }
    }
}
