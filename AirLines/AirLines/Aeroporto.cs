using AirLines.Local;
using AirLines.Tripulantes;
using AirLines.Veiculo;
using System;
using System.Collections.Generic;

namespace AirLines
{
    public class Aeroporto
    {
        public Aviao Aviao { get; set; }
        public Terminal Terminal { get; set; }
        public SmartFortwo SmartFortwo { get; set; }

        public Aeroporto()
        {
            Aviao = new Aviao();
            Terminal = new Terminal();
            SmartFortwo = new SmartFortwo(Terminal);
        }

        public void IniciarEmbarque(List<Tripulante> tripulantes)
        {
            Terminal.TripulantesNoLocal = tripulantes;
        }

        public void Tranferir(List<Tripulante> tripulantes)
        {
            try
            {
                SmartFortwo.Embarcar(tripulantes);
                var rota = DeterminarRotaVeiculo();
                SmartFortwo.Transportar(rota);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private Local.Local DeterminarRotaVeiculo()
        {
            return SmartFortwo.Local.Equals(Terminal) ? Aviao : (Local.Local)Terminal;
        }
    }
}
