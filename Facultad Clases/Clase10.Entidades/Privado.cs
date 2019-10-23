using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10.Entidades
{
    class Privado:Avion,IAFIP
    {
        int _valoracionesServicioDeAbordo;

        public Privado(double precio, double velocidad, int valoracion) : base(precio, velocidad)
        {
            _valoracionesServicioDeAbordo = valoracion;
        }
    }
}
