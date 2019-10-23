using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10.Entidades
{
    class Deportivo: Auto, IAFIP, IARBA
    {
        private int _caballoFuerza;

        int CaballoFuerza { get { return _caballoFuerza; } }

        public Deportivo(double precio, string patente, int hp) : base(precio, patente)
        {
            _caballoFuerza = hp;
        }

        public double CalcularImpuesto()
        {
            return this._precio * 0.28;
        }
    }
}
