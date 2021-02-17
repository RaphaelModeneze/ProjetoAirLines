using AirLines.Tripulantes.Contracts;

namespace AirLines.Tripulantes.Cabine
{
    public class ChefeServico : ITripulante
    {
        public bool PodeDirigir(ITripulante tripulante) => true;

        public bool PodeFicarAcompanhadoCom(ITripulante tripulante)
        {
            return true;
        }
    }
}
