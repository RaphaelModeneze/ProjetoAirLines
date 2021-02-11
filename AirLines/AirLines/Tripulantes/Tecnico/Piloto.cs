namespace AirLines.Tripulantes.Tecnico
{
    public class Piloto : Tripulante
    {
        public Piloto()
        {
            PodeDirigir = true;
        }

        public override bool PodeFicarAcompanhadoCom(Tripulante tripulante)
        {
            return true;
        }
    }
}
