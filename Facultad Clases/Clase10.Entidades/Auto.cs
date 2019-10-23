using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10.Entidades
{
    abstract class Auto:Vehiculo
    {
        protected string _patente;

        public Auto(double precio, string patente):base(precio)
        {
            _patente = patente;
        }

        public void MostrarPatente()
        {
            Console.WriteLine("Patente: " + (string)_patente);
        }
    }
}
