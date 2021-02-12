using AirLines.Tripulantes;
using System.Collections.Generic;

namespace AirLines.Locals.Contracts
{
    public interface ILocal
    {
        void AdicionarTripulantes(List<Tripulante> tripulantes);
        void RemoverTripulantes(List<Tripulante> tripulantes);
    }
}