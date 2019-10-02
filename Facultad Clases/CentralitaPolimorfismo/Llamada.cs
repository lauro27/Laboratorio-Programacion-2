using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorfismo
{
    public abstract class Llamada
    {
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;

        public abstract float CostoLlamada { get; }
        public float Duracion { get { return _duracion; } }
        public string NroDestino { get { return _nroDestino; } }
        public string NroOrigen { get { return _nroOrigen; } }

        public Llamada(string origen, string destino, float duracion)
        {
            this._nroOrigen = origen;
            this._nroDestino = destino;
            this._duracion = duracion;
        }

        protected virtual string Mostrar()
        {
            return "Numero destino: " + _nroDestino + " Numero Origen: " + _nroOrigen + " Duracion: " + _duracion;
        }

        public static bool operator ==(Llamada l1, Llamada l2)
        {
            return l1.Equals(l2);
        }

        public static bool operator !=(Llamada l1, Llamada l2) { return !(l1 == l2); }

        public int OrdenarPorDuracion(Llamada l1, Llamada l2)
        {
            if (l1.Duracion > l2.Duracion) { return 1; }
            else if (l1.Duracion < l2.Duracion) { return -1; }
            else { return 0; }
        }

        public override bool Equals(Object obj)
        {
            return obj is Local;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
