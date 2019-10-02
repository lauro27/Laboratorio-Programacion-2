using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorfismo
{
    public class Centralita
    {
        private List<Llamada> _listaDeLlamadas;
        protected string _razonSocial;

        public float GananciaPorLocal { get { return 0; } }
        public float GananciaPorProvincial { get { return 0; } }
        public float GananciaTotal { get { return 0; } }
        public List<Llamada> Llamadas{ get { return _listaDeLlamadas; } }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this._listaDeLlamadas.Add(nuevaLlamada);
        }

        private float CalcularGanancia(TipoLlamada tipo)
        {
            return 0;
        }

        public Centralita() { }

        public Centralita(string nombreEmpresa) { }

        public static bool operator !=(Centralita central, Llamada nuevaLlamada)
        { return !(central == nuevaLlamada); }

        public static Centralita operator +(Centralita central, Llamada nuevaLlamada)
        {
            if (central != nuevaLlamada)
            { central.AgregarLlamada(nuevaLlamada); }
            return central;
        }

        public static bool operator ==(Centralita central, Llamada nuevaLlamada)
        {
            foreach (Llamada llamada in central.Llamadas)
            {
                if (llamada == nuevaLlamada)
                {
                    return true;
                }
            }
            return false;
        }

        public void OrdenarLlamadas()
        {

        }

        public override string ToString()
        {
            string r = "";
            foreach (Llamada llamada in Llamadas)
            {
                r += llamada + "\n";
            }
            return r;
        }
    }
}
