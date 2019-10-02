using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorfismo
{
    public class Provincial:Llamada
    {
        private Franja _franjaHoraria;

        public override float CostoLlamada { get { return 0; } }

        private float CalcularCosto()
        {
            return 0;
        }
        
        public override bool Equals(object obj)
        {
            return obj is Provincial;
        }

        protected override string Mostrar()
        {
            return base.Mostrar() + " - Franja: "+ this._franjaHoraria + " Costo: " + this.CostoLlamada;
        }

        public Provincial(Franja mifranja, Llamada unallamada):base(unallamada.NroOrigen, unallamada.NroDestino, unallamada.Duracion)
        {
            this._franjaHoraria = mifranja;
        }

        public Provincial(string origen, string destino, float duracion, Franja mifranja):base(origen, destino, duracion)
        {
            this._franjaHoraria = mifranja;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
