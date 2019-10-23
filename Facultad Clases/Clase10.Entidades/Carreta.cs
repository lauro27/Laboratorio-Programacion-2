using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10.Entidades
{
    class Carreta:Vehiculo,IARBA
    {
        public Carreta(double precio) : base(precio)
        { }

        double IARBA.CalcularImpuesto()
        {
            return this._precio * 0.18;
        }
    }
}
