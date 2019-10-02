using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05.entidades
{
    public class Pluma
    {
        private string _marca;
        Tinta _tinta;
        int _cantidad;

        public Pluma()
        {
            this._marca = "Sin Marca";
            this._tinta = null;
            this._cantidad = 0;
        }
        public Pluma(int c) : this() { this._cantidad = c; }
        public Pluma(string m) : this() { this._marca = m; }
        public Pluma(Tinta t) : this() { this._tinta = t; }
        public Pluma(int c, string m) : this(c) { this._marca = m; }
        public Pluma(int c, Tinta t) : this(c) { this._tinta = t; }
        public Pluma(string m, Tinta t) : this(m) { this._tinta = t; }
        public Pluma(int c, string m, Tinta t) : this(c, m) { this._tinta = t; }

        private string Mostrar()
        {
            return "Marca: " + this._marca + " Tinta: " + (string)this._tinta + " Cantidad: " + this._cantidad.ToString();
        }

        //para poder hacer "string a = p;"
        public static implicit operator string(Pluma p)
        {
            return p.Mostrar();
        }

        public static bool operator ==(Pluma p, Tinta t) { return (p._tinta == t); }
        public static bool operator !=(Pluma p, Tinta t) { return !(p._tinta == t); }

        // si la tinta es la misma suma 1 a cantidad
        public static Pluma operator +(Pluma p, Tinta t)
        {
            if (p == t && p._cantidad < 100)
            {
                p._cantidad++;
            }
            return p;
        }

    }
}
