using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase07.entidades
{
    public class Libro
    {
        private string titulo;
        private string autor;
        private List<Capitulo> capitulos;

        public string Titulo { get { return titulo; } }
        public string Autor { get { return autor; } }

        public int CantidadCapitulos
        {
            get
            {
                return capitulos.Count;
            }
        }

        public int CantidadPaginas
        {
            get
            {
                int i = 0;
                foreach (Capitulo c in capitulos)
                {
                    i += c.Paginas;
                }
                return i;
            }
        }

        public Capitulo this[int index]
        {
            get
            {
                if (index > capitulos.Count -1)
                {
                    return null;
                }
                return capitulos[index];
            }
            set
            {
                if (capitulos == null)
                { capitulos.Add(value); }
                else
                {
                    if (index > capitulos.Count - 1)
                    {
                        capitulos.Add(value);
                    }
                    else
                    {
                        capitulos[index] = value;
                    }
                }
                
            }
        }


        public Libro(string t, string a)
        {
            this.titulo = t;
            this.autor = a;
            this.capitulos = new List<Capitulo>();
        }

    }
}
