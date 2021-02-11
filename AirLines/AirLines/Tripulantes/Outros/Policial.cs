namespace AirLines.Tripulantes.Outros
{
    public class Policial : Tripulante
    {
        public Policial()
        {
            PodeDirigir = true;
        }

        public override bool PodeFicarAcompanhadoCom(Tripulante tripulante)
        {
            return true;
        }
    }
}
