using AirLines.Tripulantes.Cabine;
using AirLines.Tripulantes.Contracts;

namespace AirLines.Tripulantes.Tecnico
{
    public class Oficial : ITripulante
    {
        public bool PodeDirigir(ITripulante tripulante) => false;

        public bool PodeFicarAcompanhadoCom(ITripulante tripulante)
        {
            return !tripulante.GetType().Equals(typeof(ChefeServico));
        }
    }
}
