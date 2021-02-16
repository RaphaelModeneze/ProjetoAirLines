using AirLines.Locais;
using AirLines.Tripulantes;
using AirLines.Tripulantes.Contracts;
using AirLines.Veiculo.Contract;
using System;
using System.Collections.Generic;

namespace AirLines
{
    public class Aeroporto
    {
        private readonly ISmartFortwo smartFortwo;

        public Local Aviao { get; set; }
        public Local Terminal { get; set; }

        public Aeroporto(ISmartFortwo smartFortwo)
        {
            Aviao = Locais.Aviao.GetAviao();
            Terminal = Locais.Terminal.GetTerminal();
            this.smartFortwo = smartFortwo;
        }

        public void IniciarEmbarque(List<ITripulante> tripulantes)
        {
            Terminal.TripulantesNoLocal = tripulantes;
        }

        public bool Tranferir(List<Tripulante> tripulantes)
        {
            try
            {
                smartFortwo.Embarcar(tripulantes, DeterminarRotaVeiculo());
                smartFortwo.Transportar(DeterminarRotaVeiculo());
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private Local DeterminarRotaVeiculo()
        {
            return (smartFortwo.ObterLocalAtual() == Terminal) ? Aviao : Terminal;
        }
    }
}
