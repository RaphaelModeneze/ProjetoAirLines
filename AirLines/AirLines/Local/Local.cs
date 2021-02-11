using AirLines.Tripulantes;
using System;
using System.Collections.Generic;

namespace AirLines.Local
{
    public class Local
    {
        public List<Tripulante> TripulantesNoLocal { get; set; }

        public Local()
        {
            TripulantesNoLocal = new List<Tripulante>();
        }

        public void AdicionarTripulantes(List<Tripulante> tripulantes)
        {
            if (tripulantes is null) throw new ArgumentNullException(nameof(tripulantes));

            TripulantesNoLocal.AddRange(tripulantes);
        }

        internal void RemoverTripulantes(List<Tripulante> tripulantes)
        {
            if (tripulantes is null) throw new ArgumentNullException(nameof(tripulantes));

            tripulantes.ForEach(x => TripulantesNoLocal.Remove(x));
        }
    }
}
