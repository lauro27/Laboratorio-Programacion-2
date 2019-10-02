using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase07.entidades
{
    public class Capitulo
    {
        private int numero;
        private string titulo;
        private int paginas;
        private static Random generadorDeNumeros = new Random();
        private static Random generadorDePaginas = new Random();

        public int Numero
        {
            get { return numero; }
        }
        public string Titulo
        {
            get { return titulo; }
        }
        public int Paginas
        {
            get { return paginas; }
        }

        private Capitulo(int num, string tit, int pag)
        {
            this.numero = num;
            this.titulo = tit;
            this.paginas = pag;
        }



        public static implicit operator Capitulo(string s)
        {
            return new Capitulo(generadorDeNumeros.Next(1, 65), s, generadorDePaginas.Next(15, 233));
        }
        
        public static bool operator == (Capitulo c1, Capitulo c2)
        {
            if (c1.Titulo == c2.Titulo && c1.Numero == c2.Numero)
            {
                return true;
            }
            else { return false; }
        }

        public static bool operator !=(Capitulo c1, Capitulo c2)
        {
            return !(c1 == c2);
        }
    }
}
