using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a1, a2, a3;
            a1 = new Alumno("asd", "qwe", 123);
            a2 = new Alumno("fgh", "rty", 456);
            a3 = new Alumno("jkl", "uio", 789);

            a1.Estudiar(2, 2);
            a2.Estudiar(4, 8);
            a3.Estudiar(7, 6);

            a1.CalcularFinal();
            a2.CalcularFinal();
            a3.CalcularFinal();

            Console.WriteLine(a1.Mostrar());
            Console.WriteLine(a2.Mostrar());
            Console.WriteLine(a3.Mostrar());

            Console.ReadKey();
        }
    }
}
