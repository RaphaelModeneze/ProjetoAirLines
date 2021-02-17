using AirLines.Tripulantes.Contracts;
using AirLines.Tripulantes.Tecnico;

namespace AirLines.Tripulantes.Cabine
{
    public class Comissaria : ITripulante
    {
        public bool PodeDirigir(ITripulante tripulante) => false;

        public bool PodeFicarAcompanhadoCom(ITripulante tripulante)
        {
            return tripulante.GetType().Equals(typeof(Piloto));
        }
    }
}
