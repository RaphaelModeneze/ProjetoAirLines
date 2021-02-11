using AirLines.Local.Enum;
using AirLines.Tripulantes;
using AirLines.Veiculo.Contract;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AirLines.Veiculo
{
    public class SmartFortwo : ISmartFortwo
    {
        public int Limite => 2;
        public LocalVeiculo LocalVeiculo { get; set; }
        public Local.Local Local { get; set; }
        public List<Tripulante> ListaTripulantes { get; set; }

        public SmartFortwo(Local.Local origem)
        {
            LocalVeiculo = LocalVeiculo.Terminal;
            Local = origem;
            ListaTripulantes = new List<Tripulante>();
        }

        public void MyMethod(Tripulante tripulante)
        {
            ListaTripulantes.Add(tripulante);
        }

        public void Embarcar(List<Tripulante> tripulantes)
        {
            ValidarTripulantes(tripulantes);

            ListaTripulantes.AddRange(tripulantes);

            Local.RemoverTripulantes(ListaTripulantes);
        }

        private void ValidarTripulantes(List<Tripulante> tripulantes)
        {
            var motorista = tripulantes.Find(x => x.PodeDirigir);
            if (motorista == null) { throw new Exception("Veículo sem motorista"); }

            ValidarPassageiro(tripulantes, motorista);
        }

        private void ValidarPassageiro(List<Tripulante> tripulantes, Tripulante motorista)
        {
            foreach (var tripulante in tripulantes.Where(x => !x.Equals(motorista)))
            {
                if (!tripulante.PodeFicarAcompanhadoCom(motorista))
                {
                    throw new Exception($"{tripulante.GetType()} não pode ficar sozinho com {motorista.GetType()}");
                }
            }
        }

        public void Desembarcar()
        {
            Local.AdicionarTripulantes(ListaTripulantes);
            ListaTripulantes.Clear();
        }

        public void Transportar(Local.Local rota)
        {
            Local = rota;
            Desembarcar();
        }

        public void DestinoVeiculo()
        {
            LocalVeiculo = (LocalVeiculo.Equals(LocalVeiculo.Terminal) ? LocalVeiculo.Aviao : LocalVeiculo.Terminal);
        }

    }
}
