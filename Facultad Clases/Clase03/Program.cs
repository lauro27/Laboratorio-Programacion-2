using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase 3";
            Persona p1 = new Persona();

            Console.WriteLine(p1.Mostrar());
            
            Persona p2 = new Persona();
            
            Console.WriteLine(p2.Mostrar());

            Persona p3 = new Persona("zxc", "vbn", 789);

            Console.WriteLine(p3.Mostrar());
            Console.ReadKey();
        }
    }
}