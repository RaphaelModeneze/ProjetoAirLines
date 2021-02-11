namespace AirLines.Tripulantes.Cabine
{
    public class ChefeServico : Tripulante
    {
        public ChefeServico()
        {
            PodeDirigir = true;
        }

        public override bool PodeFicarAcompanhadoCom(Tripulante tripulante)
        {
            return true;
        }
    }
}
