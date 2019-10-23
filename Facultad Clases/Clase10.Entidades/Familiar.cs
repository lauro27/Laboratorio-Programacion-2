using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10.Entidades
{
    class Familiar:Auto
    {
        private int _cantAsientos;

        public Familiar(double precio, string patente, int cantidadAsientos): base(precio, patente)
        {
            _cantAsientos = cantidadAsientos;
        }
    }
}
