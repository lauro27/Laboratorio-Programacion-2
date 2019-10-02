using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorfismo
{
    public class Local : Llamada
    {
        private float _costo;

        public override float CostoLlamada { get { return _costo; } }

        private float CalcularCosto()
        {
            return 0;
        }

        public override bool Equals(object obj)
        {
            return obj is Local;
        }

        public Local(string origen, float duracion, string destino, float costo): base(origen,destino,duracion)
        {
            this._costo = costo;
        }
        
        public Local(Llamada unaLlamada, float costo) : base(unaLlamada.NroOrigen, unaLlamada.NroDestino, unaLlamada.Duracion)
        {
            this._costo = costo;
        }

        

        protected override string Mostrar()
        {
            return base.Mostrar() + " Costo: " + this.CostoLlamada;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}