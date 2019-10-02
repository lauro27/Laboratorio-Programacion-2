using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase07.entidades;

namespace Clase07.consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Capitulo c1 = "Primer Capitulo";
            Capitulo c2 = "Segundo Capitulo";
            Capitulo c3 = "Tercer Capitulo";

            Console.WriteLine(c1.Numero);
            Console.WriteLine(c1.Titulo);
            Console.WriteLine(c1.Paginas);
            Console.WriteLine(c2.Numero);
            Console.WriteLine(c2.Titulo);
            Console.WriteLine(c2.Paginas);
            Console.WriteLine(c3.Numero);
            Console.WriteLine(c3.Titulo);
            Console.WriteLine(c3.Paginas);

            Libro l1 = new Libro("Libro uno", "Autor uno");

            l1[0] = c1;
            l1[1] = c2;
            l1[3] = c3;

            Console.WriteLine(l1.CantidadPaginas);

            Console.WriteLine(l1.CantidadCapitulos);

            Console.ReadKey();
        }
    }
}
