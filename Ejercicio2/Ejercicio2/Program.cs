using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            float num = -1;
            while (num <= 0)
            {
                Console.Write("Ingrese numero:");
                num = float.Parse(Console.ReadLine());
                if (num <= 0)
                {
                    Console.WriteLine("ERROR. Reingresar numero");
                }
            }
            Console.WriteLine("Potencia de 2: "+(Math.Pow(num,2))+" Potencia de 3: " + (Math.Pow(num, 3)));
            Console.ReadKey();
        }
    }
}
