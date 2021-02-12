using AirLines.Locais.Contracts;
using AirLines.Locais.Enum;
using AirLines.Tripulantes;
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

        public void AdicionarTripulantes(List<Tripulante> tripulantes)
        {
            if (tripulantes is null) throw new ArgumentNullException(nameof(tripulantes));

            TripulantesNoLocal.AddRange(tripulantes);
        }

        public void RemoverTripulantes(List<Tripulante> tripulantes)
        {
            if (tripulantes is null) throw new ArgumentNullException(nameof(tripulantes));

            tripulantes.ForEach(x => TripulantesNoLocal.Remove(x));
        }
    }
}
