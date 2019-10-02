using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase04.entidades
{
    public class ClaseCosa
    {
        private int entero;
        private string cadena;
        private DateTime fecha;

        public ClaseCosa()
        {
            this.entero = -1;
            this.cadena = "sin valor";
            this.fecha = DateTime.Today;
        }
        public ClaseCosa(int i, string s, DateTime d) : this(i,s)
        {
            this.fecha = d;
        }
        public ClaseCosa(int i):this()
        {
            this.entero = i;
        }
        public ClaseCosa(string s):this()
        {
            this.cadena = s;
        }
        public ClaseCosa(DateTime d) : this()
        {
            this.fecha = d;
        }
        public ClaseCosa(int i, string s):this(s)
        {
            this.entero = i;
        }
        public ClaseCosa(int i, DateTime d) : this(d)
        {
            this.entero = i;
        }
        public ClaseCosa(string s, DateTime d) : this(d)
        {
            this.cadena = s;
        }

        public string Mostrar()
        {
            return this.entero + " - " + this.cadena + " - " + this.fecha;
        }

        public void EstablecerValor(int i)
        {
            this.entero = i;
        }
        public void EstablecerValor(string s)
        {
            this.cadena = s;
        }
        public void EstablecerValor(DateTime d)
        {
            this.fecha = d;
        }
    }
}
