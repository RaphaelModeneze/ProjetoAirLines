using AirLines.Tripulantes;
using System.Collections.Generic;

namespace AirLines.Locais.Contracts
{
    public interface ILocal
    {
        void AdicionarTripulantes(List<Tripulante> tripulantes);
        void RemoverTripulantes(List<Tripulante> tripulantes);
    }
}