namespace AirLines.Tripulantes.Contracts
{
    public interface ITripulante
    {
        bool PodeDirigir(ITripulante tripulante);
        bool PodeFicarAcompanhadoCom(ITripulante tripulante);
    }
}
