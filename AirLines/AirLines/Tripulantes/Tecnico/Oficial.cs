using AirLines.Tripulantes.Cabine;

namespace AirLines.Tripulantes.Tecnico
{
    public class Oficial : Tripulante
    {

        public override bool PodeFicarAcompanhadoCom(Tripulante tripulante)
        {
            return !tripulante.GetType().Equals(typeof(ChefeServico));
        }
    }
}
