using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio nro. 1";
            string temp;
            int a, b, c, d, e;
            temp = Console.ReadLine();
            a = int.Parse(temp);
            temp = Console.ReadLine();
            b = int.Parse(temp);
            temp = Console.ReadLine();
            c = int.Parse(temp);
            temp = Console.ReadLine();
            d = int.Parse(temp);
            temp = Console.ReadLine();
            e = int.Parse(temp);

            if (a> b && a > c && a > d && a > e)
            {
                Console.WriteLine("El primer numero es el mas grande");
            }else if(b > c && b > d && b > e)
            {
                Console.WriteLine("El segundo numero es el mas grande");
            }
            else if (c > d && c > e)
            {
                Console.WriteLine("El tercer numero es el mas grande");
            }
            else if (d > e)
            {
                Console.WriteLine("El cuarto numero es el mas grande");
            }
            else
            {
                Console.WriteLine("El quinto numero es el mas grande");
            }
            if (a < b && a < c && a < d && a < e)
            {
                Console.WriteLine("El primer numero es el mas chico");
            }
            else if (b < c && b < d && b < e)
            {
                Console.WriteLine("El segundo numero es el mas chico");
            }
            else if (c < d && c < e)
            {
                Console.WriteLine("El tercer numero es el mas chico");
            }
            else if (d < e)
            {
                Console.WriteLine("El cuarto numero es el mas chico");
            }
            else
            {
                Console.WriteLine("El quinto numero es el mas chico");
            }


            Console.WriteLine("El promedio es " + ((a+b+c+d+e)/2));
            Console.ReadKey();
        }
    }
}
