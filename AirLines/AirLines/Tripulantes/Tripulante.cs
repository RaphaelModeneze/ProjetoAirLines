using AirLines.Tripulantes.Contracts;

namespace AirLines.Tripulantes
{
    public abstract class Tripulante : ITripulante
    {
        public bool PodeDirigir { get; set; }

        public abstract bool PodeFicarAcompanhadoCom(Tripulante tripulante);
    }
}
