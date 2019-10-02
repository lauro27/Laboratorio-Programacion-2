using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05.entidades
{
    /// <summary>
    /// asdf
    /// </summary>
    public class Tinta
    {
        private ConsoleColor _color;
        private ETipoTinta _tipo;

        public Tinta()
        {
            this._color = ConsoleColor.Blue;
            this._tipo = ETipoTinta.comun;
        }
        public Tinta(ConsoleColor c) : this()
        {
            this._color = c;
        }
        public Tinta(ETipoTinta t) : this()
        {
            this._tipo = t;

        }
        public Tinta(ConsoleColor c, ETipoTinta t) : this(c)
        {
            this._tipo = t;
        }

        string Mostrar()
        {
            return "Color: " + _color.ToString() + " Tipo: " + _tipo.ToString();
        }

        public static string Mostrar(Tinta t)
        {
            return t._color.ToString() + " " + t._tipo.ToString();
        }

        public static bool operator == (Tinta t1, Tinta t2)
        {
            return (t1._color == t2._color && t1._tipo == t2._tipo && !(t1 == null || t2 == null));
        }

        public static bool operator !=(Tinta t1, Tinta t2)
        {
            return !(t1 == t2);
        }

        public static bool operator ==(Tinta t, ConsoleColor c)
        {
            return (t._color == c);
        }

        public static bool operator !=(Tinta t, ConsoleColor c)
        {
            return !(t == c);
        }

        //Al parecer esto es para que puedas usar string(t)
        public static explicit operator string(Tinta t)
        {
            return Mostrar(t);
        }
    }
}
