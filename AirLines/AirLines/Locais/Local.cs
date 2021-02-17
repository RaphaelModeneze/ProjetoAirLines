using AirLines.Locais.Contracts;
using AirLines.Locais.Enum;
using AirLines.Tripulantes.Contracts;
using System;
using System.Collections.Generic;

namespace AirLines.Locais
{
    public class Local : ILocal
    {
        public List<ITripulante> TripulantesNoLocal { get; set; }
        public EnumLocal TipoLocal { get; set; }

        public Local(EnumLocal TipoLocal)
        {
            this.TipoLocal = TipoLocal;
            TripulantesNoLocal = new List<ITripulante>();
        }

        public void AdicionarTripulantes(List<ITripulante> tripulantes)
        {
            if (tripulantes is null) throw new Exception(nameof(tripulantes));

            TripulantesNoLocal.AddRange(tripulantes);
        }

        public void RemoverTripulantes(List<ITripulante> tripulantes)
        {
            if (tripulantes is null) throw new Exception(nameof(tripulantes));

            tripulantes.ForEach(x => TripulantesNoLocal.Remove(x));
        }

    }
}
