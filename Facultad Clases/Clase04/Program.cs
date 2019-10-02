using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase04.entidades;
namespace Clase04
{
    class Program
    {
        static void Main(string[] args)
        {
            ClaseCosa c1 = new ClaseCosa();
            ClaseCosa c2 = new ClaseCosa();
            ClaseCosa c3 = new ClaseCosa(123, "meh", DateTime.UtcNow);
            ClaseCosa c4 = new ClaseCosa(456);
            ClaseCosa c5 = new ClaseCosa(DateTime.UtcNow);
            ClaseCosa c6 = new ClaseCosa("meh2");
            ClaseCosa c7 = new ClaseCosa(789, DateTime.Today);
            ClaseCosa c8 = new ClaseCosa(123456, "asd");
            ClaseCosa c9 = new ClaseCosa("ffff", DateTime.Now);

            c1.EstablecerValor("qwerty");
            c1.EstablecerValor(2);
            c1.EstablecerValor(DateTime.Now);

            Console.WriteLine(c1.Mostrar());
            Console.WriteLine(c2.Mostrar());
            Console.WriteLine(c3.Mostrar());
            Console.WriteLine(c4.Mostrar());
            Console.WriteLine(c5.Mostrar());
            Console.WriteLine(c6.Mostrar());
            Console.WriteLine(c7.Mostrar());
            Console.WriteLine(c8.Mostrar());
            Console.WriteLine(c9.Mostrar());
            Console.ReadKey();
        }
    }
}
