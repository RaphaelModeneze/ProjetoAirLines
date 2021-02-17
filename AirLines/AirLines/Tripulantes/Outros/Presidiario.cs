using AirLines.Tripulantes.Contracts;

namespace AirLines.Tripulantes.Outros
{
    public class Presidiario : ITripulante
    {

        public bool PodeDirigir(ITripulante tripulante) => false;

        public bool PodeFicarAcompanhadoCom(ITripulante tripulante)
        {
            return tripulante.GetType().Equals(typeof(Policial));
        }
    }
}
