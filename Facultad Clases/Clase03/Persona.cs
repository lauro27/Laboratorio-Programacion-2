using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase03
{
    class Persona
    {

        public string nombre;
        public string apellido;
        public int dni;

        public Persona(string s1, string s2, int i)
        {
            this.nombre = s1;
            this.apellido = s2;
            this.dni = i;
        }

        public Persona()
        {
            this.nombre = Console.ReadLine();
            this.apellido = Console.ReadLine();
            this.dni = int.Parse(Console.ReadLine());
        }

        public string Mostrar()
        {
            return this.nombre + " " + this.apellido + " - " + this.dni;
        }
    }
}
