using AirLines.Tripulantes.Contracts;

namespace AirLines.Tripulantes.Outros
{
    public class Policial : ITripulante
    {
        public bool PodeDirigir(ITripulante tripulante) => true;

        public bool PodeFicarAcompanhadoCom(ITripulante tripulante)
        {
            return true;
        }
    }
}
