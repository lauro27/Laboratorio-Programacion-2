using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Centralita central = new Centralita("Telefonica");
            central += new Local("A", 30, "B", 2.65f);
            Provincial p1 = new Provincial("C", "D", 21, Franja.Franja_1);
            central += p1;
            central += new Local("E", 45, "F", 1.99f);
            central += new Provincial(Franja.Franja_3, p1);
            Console.ReadKey();
        }
    }
}
