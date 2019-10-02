using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase06.entidades
{
    public class Tempera
    {
        private ConsoleColor color;
        private string marca;
        private int cantidad;

        public ConsoleColor GetColor
        {
            get { return this.color; }
        }

        public string GetMarca
        {
            get { return this.marca; }
        }
        public int GetCantidad
        {
            get { return this.cantidad; }
        }

        public Tempera(ConsoleColor c, string m, int q)
        {
            this.color = c;
            this.marca = m;
            this.cantidad = q;
        }

        private string Mostrar()
        {
            return "Color: " + this.color + " Marca: " + this.marca + " Cantidad: " + this.cantidad;
        }

        public static implicit operator string(Tempera t)
        {
            return t.Mostrar();
        }

        public static bool operator ==(Tempera tempera1, Tempera tempera2)
        {
            //return ((t1.marca == t2.marca) &&(t1.color == t2.color));
            bool retorno = false;
            if (Object.Equals(tempera1, null) && Object.Equals(tempera2, null))
            {
                retorno = true;
            }
            else
            {
                if (!Object.Equals(tempera1, null) && !Object.Equals(tempera2, null))
                {
                    if (tempera1.marca == tempera2.marca && tempera1.color == tempera2.color)
                    {
                        retorno = true;
                    }
                }
                else
                {
                    retorno = false;
                }

            }

            return retorno;
        }

        public static bool operator !=(Tempera t1, Tempera t2)
        {
            return !(t1 == t2);
        }

        public static Tempera operator +(Tempera t, int c)
        {
            t.cantidad += c;
            return t;
        }

        public static Tempera operator +(Tempera t1, Tempera t2)
        {
            if (t1 == t2)
            {
                t1.cantidad += t2.cantidad;
            }
            return t1;
        }

        public static Tempera operator -(Tempera tempera1, Tempera tempera2)
        {
            if (tempera1 == tempera2)
            {
                tempera1.cantidad = tempera1.cantidad - tempera2.cantidad;

                if (tempera1.cantidad < 1)
                {
                    tempera1 = null;
                }
            }
            return tempera1;
        }
    }
}
