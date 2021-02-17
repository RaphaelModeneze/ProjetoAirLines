using AirLines.Tripulantes.Contracts;

namespace AirLines.Tripulantes.Tecnico
{
    public class Piloto : ITripulante
    {
        public bool PodeDirigir(ITripulante tripulante) => true;

        public bool PodeFicarAcompanhadoCom(ITripulante tripulante)
        {
            return true;
        }
    }
}
