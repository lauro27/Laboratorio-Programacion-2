using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase06.entidades
{
    public class Paleta
    {
        private Tempera[] colores;
        private int cantidadMaximaColores;

        public Tempera this[int index]
        {
            get
            {
                if (index < this.colores.Length)
                {
                    return this.colores[index];
                }
                else
                {
                    return null;
                }
            }
        }

        private Paleta()
        {
            this.colores = new Tempera[5];
            this.cantidadMaximaColores = 5;
        }

        private Paleta(int c) : this()
        {
            this.colores = new Tempera[c];
            this.cantidadMaximaColores = c;
        }

        public static implicit operator Paleta(int i)
        {
            return new Paleta(i);
        }

        private static string Mostrar(Paleta p)
        {
            string r = "";
            foreach(Tempera t in p.colores)
            {
                r = r + t + "\n";
            }
            return r;
        }

        public static explicit operator string(Paleta p)
        {
            return Mostrar(p);
        }

        public static bool operator ==(Paleta p, Tempera t)
        {
            bool r = false;
            foreach (Tempera i in p.colores)
            {
                if (i == t && i != null)
                {
                    r = true;
                    break;
                }
            }
            return r;
        }

        public static bool operator !=(Paleta p, Tempera t)
        {
            return !(p == t);
        }

        public static Paleta operator +(Paleta paleta1, Tempera tempera1)
        {
            bool aux = false;
            int posicion = -1;
            int posicionTempera = -1;

            if (Object.Equals(paleta1, null) == false && Object.Equals(tempera1, null) == false)
            {
                if (paleta1 == tempera1)
                {
                    posicionTempera = paleta1 | tempera1;
                    paleta1.colores[posicionTempera] += tempera1;
                    aux = true;
                }
                else
                {
                    if (aux == false)
                    {
                        posicion = paleta1.obtenerLugarLibre();

                        if (posicion != -1)
                        {
                            paleta1.colores[posicion] = tempera1;
                        }
                    }
                }

            }

            return paleta1;

        }

        private int obtenerLugarLibre()
        {
            int retorno = -1;

            for (int i = 0; i < this.colores.Length; i++)
            {

                if (this.colores[i] == null)
                {
                    retorno = i;
                    break;

                }
            }

            return retorno;
        }
        public static int operator |(Paleta p, Tempera t)
        {
            int index = 0;
            foreach (Tempera i in p.colores)
            {
                if (i == t)
                {
                    return index;
                }
                else { index++; }
            }
            return -1;
        }
        public static Paleta operator -(Paleta paleta1, Tempera tempera1)
        {

            int posicionTempera = -1;

            if (Object.Equals(paleta1, null) == false && Object.Equals(tempera1, null) == false)
            {
                posicionTempera = paleta1 | tempera1;

                if (posicionTempera != -1)    // SI EXISTE LA TEMPERA
                {
                    paleta1.colores[posicionTempera] = paleta1.colores[posicionTempera] - tempera1; // RESTO SUS CANTIDADES CON SOBRECARGA DE - EN TEMPERAS

                }
            }
            return paleta1;
        }
    }
}
