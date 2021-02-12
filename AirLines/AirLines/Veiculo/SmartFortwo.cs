using AirLines.Locais;
using AirLines.Tripulantes;
using AirLines.Veiculo.Contract;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AirLines.Veiculo
{
    public class SmartFortwo : ISmartFortwo
    {
        public int LimiteDeTripulantesParaVeiculo => 2;
        public Local Local { get; set; }
        public List<Tripulante> ListaTripulantesDoVeiculo { get; set; }

        public SmartFortwo()
        {
            ListaTripulantesDoVeiculo = new List<Tripulante>();
        }

        public void Embarcar(List<Tripulante> tripulantes, Local rota)
        {
            AtribuirLocalVeiculo(rota);
            ValidarTripulantes(tripulantes);
            ListaTripulantesDoVeiculo.AddRange(tripulantes);
            Local.RemoverTripulantes(ListaTripulantesDoVeiculo);
        }

        private void ValidarTripulantes(List<Tripulante> tripulantes)
        {
            if (!tripulantes.Any())
                throw new Exception("Não existem tripulantes para embarcar");

            if (tripulantes.Count() > LimiteDeTripulantesParaVeiculo)
                throw new Exception("Tripulantes excede o limite de lugares do veículo");

            var motorista = tripulantes.Find(x => x.PodeDirigir);
            if (motorista == null)
                throw new Exception("Veículo sem motorista");

            ValidarPassageiro(tripulantes, motorista);
        }

        private void ValidarPassageiro(List<Tripulante> tripulantes, Tripulante motorista)
        {
            foreach (var tripulante in tripulantes.Where(x => !x.Equals(motorista)))
            {
                if (!tripulante.PodeFicarAcompanhadoCom(motorista))
                    throw new Exception($"{tripulante.GetType()} não pode ficar sozinho com {motorista.GetType()}");
            }
        }

        public void Desembarcar()
        {
            Local.AdicionarTripulantes(ListaTripulantesDoVeiculo);
            ListaTripulantesDoVeiculo.Clear();
        }

        public void Transportar(Local rota)
        {
            AtribuirLocalVeiculo(rota);
            Desembarcar();
        }

        private void AtribuirLocalVeiculo(Local local)
        {
            Local = local;
        }

        public Local ObterLocalAtual()
        {
            return Local;
        }

    }
}
