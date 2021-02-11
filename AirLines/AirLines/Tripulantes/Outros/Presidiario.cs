namespace AirLines.Tripulantes.Outros
{
    public class Presidiario : Tripulante
    {

        public override bool PodeFicarAcompanhadoCom(Tripulante tripulante)
        {
            return !tripulante.GetType().Equals(typeof(Policial));
        }
    }
}
