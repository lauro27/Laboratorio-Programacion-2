using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10.Entidades
{
    class Avion: Vehiculo, IAFIP, IARBA
    {
        protected double _velocidadMaxima;
        double VelocidadMaxima { get { return _velocidadMaxima; } }

        public Avion(double precio, double veMax) : base(precio)
        {
            _velocidadMaxima = veMax;
        }

        double IAFIP.CalcularImpuesto()
        {
            return this._precio * 0.33;
        }

        double IARBA.CalcularImpuesto()
        {
            return this._precio * 0.27;
        }
    }
}
