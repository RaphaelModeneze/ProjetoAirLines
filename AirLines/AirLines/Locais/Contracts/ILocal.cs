using AirLines.Tripulantes.Contracts;
using System.Collections.Generic;

namespace AirLines.Locais.Contracts
{
    public interface ILocal
    {
        void AdicionarTripulantes(List<ITripulante> tripulantes);
        void RemoverTripulantes(List<ITripulante> tripulantes);
    }
}