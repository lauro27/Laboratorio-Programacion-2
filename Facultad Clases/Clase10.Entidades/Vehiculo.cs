using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10.Entidades
{
    public class Vehiculo
    {
        protected double _precio;

        public void MostrarPrecio() { }

        public Vehiculo(double precio)
        {
            _precio = precio;
        }
    }
}
