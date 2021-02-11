using AirLines.Tripulantes.Tecnico;

namespace AirLines.Tripulantes.Cabine
{
    public class Comissaria : Tripulante
    {

        public override bool PodeFicarAcompanhadoCom(Tripulante tripulante)
        {
            return tripulante.GetType().Equals(typeof(Piloto));
        }
    }
}
