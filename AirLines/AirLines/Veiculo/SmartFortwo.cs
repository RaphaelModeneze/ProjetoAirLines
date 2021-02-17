using AirLines.Locais;
using AirLines.Resources;
using AirLines.Tripulantes.Contracts;
using AirLines.Veiculo.Contract;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AirLines.Veiculo
{
    public class SmartFortwo : ISmartFortwo
    {
        private const int LimiteDeTripulantesParaVeiculo = 2;

        public Local Local { get; set; }
        public List<ITripulante> ListaTripulantesDoVeiculo { get; set; }

        public SmartFortwo()
        {
            ListaTripulantesDoVeiculo = new List<ITripulante>();
        }

        public void Embarcar(List<ITripulante> tripulantes, Local rota)
        {
            AtualizarLocalVeiculo(rota);
            ValidarTripulantes(tripulantes);
            ListaTripulantesDoVeiculo.AddRange(tripulantes);
            Local.RemoverTripulantes(ListaTripulantesDoVeiculo);
        }

        private void ValidarTripulantes(List<ITripulante> tripulantes)
        {

            if (!tripulantes.Any())
                throw new Exception(Resource.ListaVazia);

            if (tripulantes.Count > LimiteDeTripulantesParaVeiculo)
                throw new Exception(Resource.ExcedeLimiteVeiculo);

            foreach (var tripulante in tripulantes)
            {
                if (!Local.TripulantesNoLocal.Contains(tripulante))
                    throw new Exception(Resource.TripulanteNaoEstaLocal);
            }

            var motorista = tripulantes.Find(x => x.PodeDirigir(x));
            if (motorista == null) throw new Exception(Resource.SemMotorista);

            ValidarPassageiro(tripulantes, motorista);
        }

        private void ValidarPassageiro(List<ITripulante> tripulantes, ITripulante motorista)
        {
            foreach (var tripulante in tripulantes.Where(x => !x.Equals(motorista)))
            {
                if (!tripulante.PodeFicarAcompanhadoCom(motorista))
                    throw new Exception(Resource.NaoAutorizado);
            }
        }

        public void Desembarcar()
        {
            Local.AdicionarTripulantes(ListaTripulantesDoVeiculo);
            ListaTripulantesDoVeiculo.Clear();
        }

        public void Transportar(Local rota)
        {
            AtualizarLocalVeiculo(rota);
            Desembarcar();
        }

        private void AtualizarLocalVeiculo(Local local)
        {
            Local = local;
        }

        public Local ObterLocalAtual()
        {
            return Local;
        }

    }
}
