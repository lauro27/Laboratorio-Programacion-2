using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10.Entidades
{
    class Comercial:Avion
    {
        private int _capacidadPasajeros;
        int CapacidadPasajeros { get { return _capacidadPasajeros; } }
        public Comercial(double precio, double velocidad, int pasajeros) : base(precio, velocidad)
        {
            _capacidadPasajeros = pasajeros;
        }

        double IARBA.CalcularImpuesto()
        {
            return this._precio * 0.25;
        }
    }
}
